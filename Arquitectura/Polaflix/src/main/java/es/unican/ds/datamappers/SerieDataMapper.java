package es.unican.ds.datamappers;

import java.sql.Connection;
import java.sql.PreparedStatement;
import java.sql.ResultSet;
import java.sql.SQLException;
import java.util.HashSet;
import java.util.Set;

import es.unican.ds.connectionpool.ConnectionsPool;
import es.unican.ds.domain.Serie;
import es.unican.ds.domain.SerieEstandar;
import es.unican.ds.domain.SerieGold;
import es.unican.ds.domain.SerieSilver;
import es.unican.ds.idgenerator.SerieIdGenerator;

/**
 * Data Mapper de la clase Serie
 * @author Adrian Garcia Cubas
 *
 */
public class SerieDataMapper {
	
	/**
	 * Metodo que anhade una serie a la base de datos.
	 * @param s serie a introducir en la BBDD
	 * @throws SQLException
	 */
	public static void add(Serie s) throws SQLException {
		Connection conn = ConnectionsPool.getInstance().requestConnection();
		
		String query = "INSERT INTO Serie VALUES (?,?,?,?,?)";
		
		PreparedStatement ps = conn.prepareStatement(query);
		
		ps.setLong(1, (int)SerieIdGenerator.getId());
		ps.setString(2, s.getTitulo());
		ps.setDouble(3, s.getPrecio());
		ps.setString(4, s.getSinopsis());
		
		//El toString devuelve class es.unican.ds.domain.SerieEstandar o Gold o Silver
		ps.setString(5, s.getClass().toString().split("\\.")[4]);
		//El '.' es un metacaracter, por lo que para me lo cojo como corte 
		//Tengo que poner \\.
		
		ps.execute();
		
		ConnectionsPool.getInstance().closeConnection(conn);
	}
	
	/**
	 * Metodo estatico para encontrar una serie en la base de datos.
	 * @param id identificador de la serie en la base de datos
	 * @return serie encontrada en la base de datos
	 * @throws SQLException
	 */
	public static Serie find(long id) throws SQLException {

		Connection conn = ConnectionsPool.getInstance().requestConnection();

		String query = "SELECT idSerie, titulo, sinopsis, tipoSerie FROM Serie WHERE idSerie=?";

		PreparedStatement ps = null;
		ps = conn.prepareStatement(query);
		ps.setLong(1, id);
		ResultSet rs = ps.executeQuery();

		rs.next();
		Serie s = row2Serie(rs);

		ConnectionsPool.getInstance().closeConnection(conn);

		return s;
	}  

	/**
	 * Metodo que retorna todas las series de la base de datos
	 * @return Set con las series de la base de datos
	 * @throws SQLException
	 */
	public static Set<Serie> findAll() throws SQLException {
		Connection conn = ConnectionsPool.getInstance().requestConnection();

		Set<Serie> series = new HashSet<Serie>();
		
		String query = "SELECT idSerie, titulo, sinopsis, tipoSerie FROM Serie";
 
		PreparedStatement ps = conn.prepareStatement(query);
		ResultSet rs = ps.executeQuery();
		
		
		while(rs.next()) {
			series.add(row2Serie(rs));
		}
		
		ConnectionsPool.getInstance().closeConnection(conn);

		return series;
	}
	
	/**
	 * Metodo estatico para eliminar una serie de la base de datos
	 * @param s serie que eliminar
	 * @throws SQLException
	 */
	public static void remove(Serie s) throws SQLException {
		Connection conn = ConnectionsPool.getInstance().requestConnection();

		String query;
		PreparedStatement ps;

		query = "DELETE FROM Serie WHERE idSerie = ?";

		ps = conn.prepareStatement(query);

		ps.setLong(1,  s.getId());

		ps.executeQuery();

		ConnectionsPool.getInstance().closeConnection(conn);

		//TODO: Borrar cuenta bancaria

	}
	
	/**
	 * Metodo que transforma las filas de la base de datos en una serie
	 * @param rs resultado de la busqueda en la base de datos
	 * @return objeto Serie
	 * @throws SQLException
	 */
	private static Serie row2Serie(ResultSet rs) throws SQLException {

		long id = rs.getLong(1);
		String titulo = rs.getString(2);
		String sinopsis = rs.getString(3);
		String tipoSerie = rs.getString(4);
		
		Serie s = null;
		
		if(tipoSerie.equals("SerieEstandar")) {
			s = new SerieEstandar(titulo, sinopsis);
		} else if(tipoSerie.equals("SerieGold")) {
			s = new SerieGold(titulo, sinopsis);
		} else if (tipoSerie.equals("SerieSilver")) {
			s = new SerieSilver(titulo, sinopsis);
		}

		s.setId(id);
		
		return s;
	}
	
	
}
