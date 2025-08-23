package es.unican.ds.datamappers;

import java.sql.Connection;
import java.sql.PreparedStatement;
import java.sql.ResultSet;
import java.sql.SQLException;

import es.unican.ds.connectionpool.ConnectionsPool;
import es.unican.ds.domain.Facturacion;
import es.unican.ds.idgenerator.FacturacionIdGenerator;

/**
 * Data Mapper de la Clase Facturacion
 * @author Adrian Garcia Cubas
 */
public class FacturacionDataMapper {

	/**
	 * Metodo para anhadir una factura a la base de datos
	 * @param f factura a anhadir
	 * @param idUsuario idUsuario al que asociar la factura
	 * @throws SQLException
	 */
	public static void add(Facturacion f, long idUsuario) throws SQLException {
		Connection conn = ConnectionsPool.getInstance().requestConnection();
		String query = "INSERT INTO Facturacion VALUES ?,?,?,?,?";
		
		PreparedStatement ps = null;

		ps = conn.prepareStatement(query);

		ps.setLong(1, (int)FacturacionIdGenerator.getId());
		ps.setString(2, f.getFecha());
		ps.setDouble(3, f.getPrecioTotal());
		ps.setString(4, f.getClass().getName());
		ps.setLong(5, (int)idUsuario);

		ps.executeQuery();
		ConnectionsPool.getInstance().closeConnection(conn);
	}

	/**
	 * Metodo para encontrar una factura en la base de datos
	 * @param id identificador de la factura
	 * @return factura factura encontrada en la base de datos
	 * @throws SQLException
	 */
	public static Facturacion findById(long id) throws SQLException{

		Connection conn = ConnectionsPool.getInstance().requestConnection();

		String query = "SELECT idFactura, fecha, precioTotal FROM Facturacion WHERE idFactura=?";

		PreparedStatement ps = null;
		ps = conn.prepareStatement(query);
		ps.setLong(1, (int)id);
		ResultSet rs = ps.executeQuery();

		rs.next();

		Facturacion factura = row2Factura(rs);
		
		ConnectionsPool.getInstance().closeConnection(conn);

		return factura;
	}

	/**
	 * Metodo que transforma las filas de la base de datos en una factura
	 * @param rs resultado de la busqueda en la base de datos
	 * @return objeto Factura
	 * @throws SQLException
	 */
	private static Facturacion row2Factura(ResultSet rs) throws SQLException {

		long idFactura = rs.getLong(1);
		String fecha = rs.getString(2);
		double precioTotal = rs.getDouble(3);

		Facturacion factura = new Facturacion();
		factura.setId(idFactura);
		factura.setFecha(fecha);
		factura.setPrecioTotal(precioTotal);

		return factura;
	}
}
