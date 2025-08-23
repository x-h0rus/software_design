package es.unican.ds.dto;

import java.util.LinkedList;
import java.util.List;


/**
 * DTO de la clase Usuario para la figura 4
 * @author Adrian Garcia Cubas
 *
 */
public class UsuarioFigura4Dto {
	
	//ATRIBUTOS
	
	private String nombreUsuario;
	
	protected List<FacturaFigura4Dto> facturas = new LinkedList<FacturaFigura4Dto>();

	//GETTERS
	
	public String getNombreUsuario() {
		return nombreUsuario;
	}

	public List<FacturaFigura4Dto> getFacturas() {
		return facturas;
	}

	//SETTERS
	
	public void setNombreUsuario(String nombreUsuario) {
		this.nombreUsuario = nombreUsuario;
	}
}
