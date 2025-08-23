package es.unican.ds.repositories;

import java.sql.SQLException;
import java.util.List;

import es.unican.ds.datamappers.UsuarioDataMapper;
import es.unican.ds.domain.Usuario;
import es.unican.proxys.UsuarioProxy;

/**
 * Repositorio de la clase usuario
 * @author Adrina Garcia Cubas
 *
 */
public class UsuarioRepository {

	/**
	 * Metodo que guarda un usuario en la base de datos
	 * @param u
	 * @throws SQLException
	 */
	public static void add(Usuario u) throws SQLException {
		UsuarioDataMapper.add(u);
	}

	/**
	 * Metodo que encuentra un usuario segun su identificador
	 * @param id identificador del usuario
	 * @return usuario encontrado
	 * @throws SQLException
	 */
	public static UsuarioProxy findById(long id) throws SQLException {
		return UsuarioDataMapper.findById(id);
	}

	public static List<UsuarioProxy> findAll() throws SQLException{
		return UsuarioDataMapper.findAll();
	}
	
	/**
	 * Metodo que elimina un usuario de la base de datos
	 * @param u usuario que se quiere elminar
	 * @throws SQLException
	 */
	public static void remove(Usuario u) throws SQLException {
		UsuarioDataMapper.remove(u);
	}	
}
