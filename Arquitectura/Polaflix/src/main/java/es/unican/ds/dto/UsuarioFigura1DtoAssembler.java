package es.unican.ds.dto;

import java.sql.SQLException;

import es.unican.ds.domain.Serie;
import es.unican.ds.domain.Usuario;

/**
 * Assembler de la figura 1 entre Usuario y Serie
 * @author Adrian Garcia Cubas
 *
 */
public class UsuarioFigura1DtoAssembler {
	
	/**
	 * Metodo que anhade a la DTO de un usuario las series empezadas, pendientes y terminadas que tiene
	 * @param u usuario del que se quieren obtener las series
	 * @return DTO del usuario para la figura 1
	 * @throws SQLException
	 */
	public UsuarioFigura1Dto paginaPrincipalDto(Usuario u) throws SQLException {
		
		UsuarioFigura1Dto result = new UsuarioFigura1Dto();
		
		result.setNombreUsuario(u.getNombreUsuario());
		
		SerieFigura1Dto sf1;
		
		for(Serie s : u.getSeriesEmpezadas()) {
			sf1 = new SerieFigura1Dto();
			sf1.setTitulo(s.getTitulo());
			result.seriesEmpezadas.add(sf1);
		}
		
		for(Serie s : u.getSeriesPendientes()) {
			sf1 = new SerieFigura1Dto();
			sf1.setTitulo(s.getTitulo());
			result.seriesPendientes.add(sf1);
		}
		
		for(Serie s : u.getSeriesTerminadas()) {
			sf1 = new SerieFigura1Dto();
			sf1.setTitulo(s.getTitulo());
			result.seriesTerminadas.add(sf1);
		}
		
		return result;
	}

}
