package es.unican.proxys;

import java.sql.Connection;
import java.sql.PreparedStatement;
import java.sql.ResultSet;
import java.sql.SQLException;
import java.util.HashSet;
import java.util.LinkedList;
import java.util.List;
import java.util.Set;

import es.unican.ds.connectionpool.ConnectionsPool;
import es.unican.ds.datamappers.FacturacionDataMapper;
import es.unican.ds.datamappers.SerieDataMapper;
import es.unican.ds.domain.CapitulosVistos;
import es.unican.ds.domain.CuentaBancaria;
import es.unican.ds.domain.Facturacion;
import es.unican.ds.domain.Serie;
import es.unican.ds.domain.Usuario;

/**
 * Clase Proxy de un usuario
 * @author Adrian Garcia Cubas
 *
 */
public class UsuarioProxy extends Usuario{

	//ATRIBUTOS
	
	protected boolean seriesTerminadasCargadas;
	protected boolean seriesPendientesCargadas;
	protected boolean seriesEmpezadasCargadas;
	protected boolean facturasCargadas;
	protected boolean capitulosVistosCargados;

	//CONSTRUCTOR
	
	public UsuarioProxy(String nombre, String contrasenha, CuentaBancaria cuenta) {
		super(nombre, contrasenha, cuenta);
		this.facturasCargadas = false;
		this.seriesTerminadasCargadas = false;
		this.seriesPendientesCargadas = false;
		this.seriesEmpezadasCargadas = false;
		this.capitulosVistosCargados = false;
	}

	//GGETERS
	
	@Override
	public Set<Serie> getSeriesTerminadas() throws SQLException{
		if(!seriesTerminadasCargadas) {
			this.seriesTerminadas = loadSeriesTerminadas();
			seriesTerminadasCargadas = true;
		}
		return super.getSeriesTerminadas();
	}

	@Override
	public Set<Serie> getSeriesPendientes() throws SQLException{
		if(!seriesPendientesCargadas) {
			this.seriesPendientes = loadSeriesPendientes();
			seriesPendientesCargadas = true;
		}
		return super.getSeriesPendientes();
	}

	@Override
	public Set<Serie> getSeriesEmpezadas() throws SQLException{
		if(!seriesPendientesCargadas) {
			this.seriesEmpezadas = loadSeriesEmpezadas();
			seriesPendientesCargadas = true;
		}
		return super.getSeriesEmpezadas();
	}

	@Override
	public List<Facturacion> getFacturas() throws SQLException{
		if(!facturasCargadas) {
			this.facturas = loadFacturas();
			facturasCargadas = true;
		}
		return super.getFacturas();
	}
	
	@Override
	public List<CapitulosVistos> getCapitulosVistos() throws SQLException{
		if(!capitulosVistosCargados) {
			loadCapitulosVistos();
		}
		return super.getCapitulosVistos();
	}

	//CARGADORES

	protected Set<Serie> loadSeriesTerminadas() throws SQLException{
		return loadSeries("SeriesTerminadas");
	}

	protected Set<Serie> loadSeriesPendientes() throws SQLException{
		return loadSeries("SeriesPendientes");
	}

	protected Set<Serie> loadSeriesEmpezadas() throws SQLException{
		return loadSeries("SeriesEmpezadas");
	}

	protected void loadCapitulosVistos() throws SQLException{
		//TODO
	}


	/**
	 * Metodo que carga las series desde la base de datos cuando se requiera
	 * @param tabla tabla con las series que se quieren cargar
	 * @return Set con las series que se quieran cargar del usuario
	 * @throws SQLException
	 */
	private Set<Serie> loadSeries(String tabla) throws SQLException{

		Connection conn = ConnectionsPool.getInstance().requestConnection();
		Set<Serie> seriesCargadas = new HashSet<Serie>();

		String query = "SELECT serie FROM " + tabla + " WHERE usuario = ?";

		PreparedStatement ps = conn.prepareStatement(query);
		//ps.setString(1, tabla);
		ps.setLong(1, (int)this.getId());
		ResultSet rs = ps.executeQuery();

		while(rs.next()) {
			long serieId = rs.getLong(1);
			Serie s = SerieDataMapper.find(serieId);
			seriesCargadas.add(s);
		}

		rs.close();
		ps.close();
		ConnectionsPool.getInstance().closeConnection(conn);

		return seriesCargadas;
	}

	/**
	 * Metodo que carga las facturas de un usuario cuando se requieran
	 * @return Set con las facturas de un usuario
	 * @throws SQLException
	 */
	protected List<Facturacion> loadFacturas() throws SQLException{
		Connection conn = ConnectionsPool.getInstance().requestConnection();
		List<Facturacion> facturasCargadas = new LinkedList<Facturacion>();

		String query = "SELECT idFactura, fecha, precioTotal FROM Facturacion "
				+ "WHERE usuario = ?";

		PreparedStatement ps = conn.prepareStatement(query);
		ps.setLong(1, (int)this.getId());
		ResultSet rs = ps.executeQuery();

		while(rs.next()) {
			long idFactura = rs.getLong(1);
			Facturacion f = FacturacionDataMapper.findById(idFactura);
			facturasCargadas.add(f);
		}

		
		rs.close();
		ps.close();
		ConnectionsPool.getInstance().closeConnection(conn);

		return facturasCargadas;
	}

}
