package es.unican.ds.business;

import java.sql.SQLException;

import es.unican.ds.domain.Serie;
import es.unican.ds.domain.Usuario;
import es.unican.ds.repositories.SerieRepository;
import es.unican.ds.repositories.UsuarioRepository;

/**
 * Clase usuario de la capa de negocio
 * @author Adrian Garcia Cubas
 *
 */
public class UsuarioBusiness {

	/**
	 * Metod que agrega una serie al espacio del usuario
	 * @param idSerie identificador de la serie a introducir en el espacio del usuario
	 * @param idUsuario identificador del usuario alq eu introducir la serie
	 * @param tipoEspacio Estado de la serie que se agrega
	 * @throws SQLException
	 */
	public void agregarSerie(long idSerie, long idUsuario, String tipoEspacio) throws SQLException {
		
		Serie s = SerieRepository.find(idSerie);
		Usuario u = UsuarioRepository.findById(idUsuario);
		
		if(tipoEspacio.equals("Empezadas")) {
			u.getSeriesEmpezadas().add(s);
		}
		else if(tipoEspacio.equals("Pendientes")) {
			u.getSeriesPendientes().add(s);
		} else if(tipoEspacio.equals("Terminadas")){
			u.getSeriesTerminadas().add(s);
		} else {
			throw new IllegalArgumentException();
		}
	}
}
