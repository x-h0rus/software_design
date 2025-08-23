package es.unican.ds.domain;


/**
 * Clase persona
 * @author Adrian Garcia Cubas
 *
 */
public class Persona {
	
	//ATRIBUTOS
	
	private String nombre;
	private TipoPersona tipoPersona;
	
	//CONSTRUCTOR
	
	public Persona(String nombre, TipoPersona tipoPersona) {
		this.nombre = nombre;
		this.tipoPersona = tipoPersona;
	}
	
	//GETTERS
	
	public String getTitulo() {
		return nombre;
	}

	public TipoPersona getTipoPersona() {
		return tipoPersona;
	}
}
