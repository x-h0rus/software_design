package es.unican.ds.repositories;

import java.sql.SQLException;
import java.util.Set;

import es.unican.ds.datamappers.SerieDataMapper;
import es.unican.ds.domain.Serie;

/**
 * Repositorio de la clase Serie
 * @author Adrian Garcia Cubas
 *
 */
public class SerieRepository {

	public static void add(Serie s) throws SQLException {
		SerieDataMapper.add(s);
	}
	
	public static Serie find(long id) throws SQLException {
		return SerieDataMapper.find(id);
	}
	
	public static Set<Serie> findAll() throws SQLException {
		return SerieDataMapper.findAll();
	}
	
	public static void remove(Serie s) throws SQLException {
		SerieDataMapper.remove(s);
	}
	
}
