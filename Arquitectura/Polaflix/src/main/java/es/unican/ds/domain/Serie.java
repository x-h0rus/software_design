package es.unican.ds.domain;

import java.util.Collections;
import java.util.HashSet;
import java.util.LinkedList;
import java.util.List;
import java.util.Set;
/**
 * Clase serie.
 * @author Adrian Garcia Cubas
 */
public class Serie {

	//ATRIBUTOS
	
	private long id;
	private String titulo;
	private double precio;
	private String sinopsis;
	
	protected List<Temporada> temporadas = new LinkedList<Temporada>();
	protected Set<Persona> personas = new HashSet<Persona>();
	
	//CONSTRUCTOR
	
	public Serie(String titulo, String sinopsis) {
		this.titulo = titulo;
		this.sinopsis = sinopsis;
	}
	
	//GETTERS
	
	public long getId() {
		return id;
	}
	
	public String getTitulo() {
		return titulo;
	}

	public String getSinopsis() {
		return sinopsis;
	}

	public double getPrecio() {
		return precio;
	}
	
	public Set<Persona> getPersonas() {
		return personas;
	}

	public List<Temporada> getTemporadas() {
		Collections.sort(temporadas);
		return temporadas;
	}
	
	//SETTERS
	
	public void setId(long id) {
		this.id = id;
	}

	public void setTitulo(String titulo) {
		this.titulo = titulo;
	}

	public void setPrecio(double precio) {
		this.precio = 0;
	}
	
	public void setSinopsis(String sinopsis) {
		this.sinopsis = sinopsis;
	}

	//METODOS AUXILIARES
	
	@Override
	public String toString() {
		return "\nSerie [id=" + this.getId() + ", titulo=" + this.getTitulo() 
		+ ", precio=" + this.getPrecio() + ", sinopsis=" + this.getSinopsis()
				+ "]\n";
	}	
	
	
}
