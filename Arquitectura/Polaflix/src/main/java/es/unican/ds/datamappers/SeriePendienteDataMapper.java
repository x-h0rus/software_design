package es.unican.ds.datamappers;

import java.sql.Connection;
import java.sql.PreparedStatement;
import java.sql.SQLException;

import es.unican.ds.connectionpool.ConnectionsPool;
import es.unican.ds.domain.Serie;

public class SeriePendienteDataMapper {
	
	/**
	 * Metodo estatico para anhadirle al usuario una serie que tiene pendiente
	 * @param idSerie identificador de la serie que tiene pendiente el usuario
	 * @param idUsuario usuario que tiene pendiente la serie
	 * @throws SQLException
	 */
	public static void add(long idSerie, long idUsuario) throws SQLException {
		
		Connection conn = ConnectionsPool.getInstance().requestConnection();
		
		String query = "INSERT INTO SeriesPendientes VALUES (?,?)";
		
		PreparedStatement ps = null;
		ps = conn.prepareStatement(query);
		
		ps.setLong(1, idSerie);
		ps.setLong(2, idUsuario);
		
		ps.executeQuery();
		
		ConnectionsPool.getInstance().closeConnection(conn);
	}
	
	/**
	 * Metodo estatico que llamar al Data Mapper de de Serie
	 * @param idSerie identificador de la serie a encontrar
	 * @return serie encontrada
	 * @throws SQLException
	 */
	public static Serie find(long idSerie) throws SQLException {
		return SerieDataMapper.find(idSerie);
	}
}
