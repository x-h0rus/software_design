package es.unican.ds.dto;

import java.util.HashSet;
import java.util.Set;

//import es.unican.ds.domain.Serie;

/**
 * DTO de la clase Usuario para la Figura 1
 * @author Adrian Garcia Cubas
 *
 */
public class UsuarioFigura1Dto {
	
	//ATRIBUTOS
	
	private String nombreUsuario;
	
	protected Set<SerieFigura1Dto> seriesEmpezadas = new HashSet<SerieFigura1Dto>();
	protected Set<SerieFigura1Dto> seriesPendientes = new HashSet<SerieFigura1Dto>();
	protected Set<SerieFigura1Dto> seriesTerminadas = new HashSet<SerieFigura1Dto>();

	//GETTERS
	
	public String getNombreUsuario() {
		return nombreUsuario;
	}
	
	public Set<SerieFigura1Dto> getSeriesEmpezadas() {
		return seriesEmpezadas;
	}
	
	public Set<SerieFigura1Dto> getSeriesPendientes() {
		return seriesPendientes;
	}
	
	public Set<SerieFigura1Dto> getSeriesTerminadas() {
		return seriesTerminadas;
	}
	
	//SETTERS
	
	public void setNombreUsuario(String nombre) {
		this.nombreUsuario = nombre;
	}
}
