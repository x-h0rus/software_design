package es.unican.ds.datamappers;

import java.sql.Connection;
import java.sql.PreparedStatement;
import java.sql.ResultSet;
import java.sql.SQLException;
import java.util.Collections;
import java.util.LinkedList;
import java.util.List;

import es.unican.ds.connectionpool.ConnectionsPool;
import es.unican.ds.domain.CapitulosVistos;
import es.unican.ds.domain.CuentaBancaria;
import es.unican.ds.domain.Facturacion;
import es.unican.ds.domain.Serie;
import es.unican.ds.domain.Usuario;
import es.unican.ds.idgenerator.UsuarioIdGenerator;
import es.unican.proxys.UsuarioProxy;

/**
 * DataMapper de la clase Usuario
 * @author Adrian Garcia Cubas
 *
 */
public class UsuarioDataMapper {

	/**
	 * Metodo para anhadir un usuario y sus listas a la base de datos
	 * @param u usuario a añadir
	 * @throws SQLException
	 */
	public static void add(Usuario u) throws SQLException {
		Connection conn = ConnectionsPool.getInstance().requestConnection();

		addUsuario(conn, u);

		addSeriesEmpezadas(conn, u);

		addSeriesPendientes(conn, u);

		addSeriesTerminadas(conn, u);

		addFacturas(conn, u);

		//addUltimoCapituloVisto(conn, u);

		//addCapitulosVistos(conn, u);
		
		ConnectionsPool.getInstance().closeConnection(conn);
	}

	/**
	 * Metodo para eliminar un usuario de la base de datos
	 * @param u usuario a eliminar de la base de datos
	 * @throws SQLException
	 */
	public static void remove(Usuario u) throws SQLException {
		Connection conn = ConnectionsPool.getInstance().requestConnection();

		String query;
		PreparedStatement ps;

		query = "DELETE FROM Usuario WHERE idUsuario = ?";

		ps = conn.prepareStatement(query);

		ps.setLong(1,  u.getId());

		ps.executeQuery();

		ConnectionsPool.getInstance().closeConnection(conn);
		
		//TODO: Borrar cuenta bancaria
	}

	/**
	 * Metodo para encontrar un usuario por ID en la base de datos
	 * @param id identificador del usuario en la base de datos
	 * @return Objeto usuario
	 * @throws SQLException
	 */
	public static UsuarioProxy findById(long id) throws SQLException{
		Connection conn = ConnectionsPool.getInstance().requestConnection();

		String query = "SELECT idUsuario, nombreUsuario, contrasenha FROM Usuario WHERE idUsuario=?";

		PreparedStatement ps = null;
		ps = conn.prepareStatement(query);
		ps.setLong(1, id);
		ResultSet rs1 = ps.executeQuery();

		rs1.next();
		
		query = "SELECT iban FROM CuentaBancaria WHERE usuario = ?";
		
		ps = conn.prepareStatement(query);
		ps.setLong(1, id);
		ResultSet rs2 = ps.executeQuery();

		rs2.next();
		
		UsuarioProxy user = row2Usuario(rs1, rs2);

		ConnectionsPool.getInstance().closeConnection(conn);
		
		return user;
	}
	
	/**
	 * Metodo que retorna todas los usuarios de la base de datos
	 * @return Set con los usuarios de la base de datos
	 * @throws SQLException
	 */
	public static List<UsuarioProxy> findAll() throws SQLException {
		Connection conn = ConnectionsPool.getInstance().requestConnection();

		List<UsuarioProxy> usuarios = new LinkedList<UsuarioProxy>();
		
		String query = "SELECT idUsuario, nombreUsuario, contrasenha FROM Usuario";

		PreparedStatement ps = null;
		ps = conn.prepareStatement(query);
		ResultSet rs1 = ps.executeQuery();

		query = "SELECT iban FROM CuentaBancaria";
		
		ps = conn.prepareStatement(query);
		ResultSet rs2 = ps.executeQuery();
		
		while(rs1.next() && rs2.next()) {
			usuarios.add(row2Usuario(rs1, rs2));
		}
		
		ConnectionsPool.getInstance().closeConnection(conn);
		
		Collections.sort(usuarios);
		return usuarios;
	}


	//METODOS AUXILIARES

	/**
	 * Metodo que anhade un usuario a la base de datos
	 * @param conn conexion con la base de datos
	 * @param u usuario a anhadir
	 * @throws SQLException
	 */
	private static void addUsuario(Connection conn, Usuario u) throws SQLException{
		String query;
		PreparedStatement ps;

		query = "INSERT INTO Usuario VALUES (?,?,?)";

		ps = conn.prepareStatement(query);

		long idUsuario = (int)UsuarioIdGenerator.getId();
		
		ps.setLong(1,  idUsuario);
		ps.setString(2, u.getNombreUsuario());
		ps.setString(3, u.getContrasenha());
		
		ps.execute();
		
		query = "INSERT INTO CuentaBancaria VALUES (?,?)";
		
		ps = conn.prepareStatement(query);
		
		ps.setString(1, u.getCuentaBancaria().getIban());
		ps.setLong(2, idUsuario);
		
		ps.execute();
	}

	/**
	 * Metodo para anhadir las series empezadas por el usuario a la base de datos
	 * @param conn conexion con la base de datos
	 * @param u usuario al que anhadirle las series
	 * @throws SQLException
	 */
	private static void addSeriesEmpezadas(Connection conn, Usuario u) throws SQLException{
		for(Serie s : u.getSeriesEmpezadas()) {
			SerieEmpezadaDataMapper.add(s.getId(), u.getId());
		}
	}

	/**
	 * Metodo para anhadir las series pendientes del usuario a la base de datos
	 * @param conn conexion con la base de datos
	 * @param u usuario al que anhadirle las series
	 * @throws SQLException
	 */
	private static void addSeriesPendientes(Connection conn, Usuario u) throws SQLException{
		for(Serie s : u.getSeriesPendientes()) {
			SeriePendienteDataMapper.add(s.getId(), u.getId());
		}
	}

	/**
	 * Metodo para anhadir las series terminadas por el usuario a la base de datos
	 * @param conn conexion con la base de datos
	 * @param u usuario al que anhadirle las series
	 * @throws SQLException
	 */
	private static void addSeriesTerminadas(Connection conn, Usuario u) throws SQLException{
		for(Serie s : u.getSeriesTerminadas()) {
			SerieTerminadaDataMapper.add(s.getId(), u.getId());
		}
	}

	/**
	 * Metodo para anhadir las facturas del usuario a la base de datos
	 * @param conn conexion a utilizar
	 * @param u Usuario al que anhadirle las facturas
	 * @throws SQLException
	 */
	private static void addFacturas(Connection conn, Usuario u) throws SQLException{

		for(Facturacion f : u.getFacturas()) {
			FacturacionDataMapper.add(f, u.getId());
		}

	}

	/**
	 * Metodo para anhadir los capitulos que el usuario a visto a la base de datos
	 * @param conn conexion con la base de datos
	 * @param u usuario usuario al que anhadirle los capitulos vistos
	 * @throws SQLException
	 */
	private static void addCapitulosVistos(Connection conn, Usuario u) throws SQLException{
		String query;
		PreparedStatement ps;

		for(CapitulosVistos cv : u.getCapitulosVistos()) {
			query = "INSERT INTO CapitulosVistos VALUES (?,?,?,?)";

			ps = conn.prepareStatement(query);

			ps.setLong(1, cv.getSerie().getId());
			//ps.setInt(2, );
			//ps.setInt(3, );
			ps.setLong(4, u.getId());


			ps.executeQuery();
		}
	}

	/**
	 * Metodo para anhadire el ultimo capitulo visto por el usuario a la base de datos
	 * @param conn conewxion con la base de datos
	 * @param u usuario al que anhadirle el ultimo capitulo visto
	 * @throws SQLException
	 */
	private static void addUltimoCapituloVisto(Connection conn, Usuario u) throws SQLException{
		String query;
		PreparedStatement ps;

		query = "INSERT INTO UltimoCapituloVisto VALUES (?,?,?,?)";

		ps = conn.prepareStatement(query);

		ps.setLong(1,  u.getUlitmoCapituloVisto().getSerie().getId());
		ps.setInt(2, u.getUlitmoCapituloVisto().getTemporada());
		ps.setInt(3, u.getUlitmoCapituloVisto().getCapitulo());
		ps.setLong(4, u.getId());

		ps.executeQuery();
	}


	/**
	 * Metodo que transforma las filas de la base de datos en un usuario
	 * @param rs resultado de la busqueda en la base de datos
	 * @return objeto Usuario
	 * @throws SQLException
	 */
	private static UsuarioProxy row2Usuario(ResultSet rs1, ResultSet rs2) throws SQLException {

		long id = rs1.getLong(1);
		String nombreUsuario = rs1.getString(2);
		String contrasenha = rs1.getString(3);
		String cuentaBancaria = rs2.getString(1);

		UsuarioProxy user = new UsuarioProxy(nombreUsuario, contrasenha, new CuentaBancaria(cuentaBancaria));
		user.setId(id);

		return user;
	}
}
