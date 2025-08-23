package es.unican.ds.domain;

/**
 * Clase Visualizacion
 * @author Adrian Garcia Cubas
 *
 */
public class Visualizacion {
	
	//ATRIBUTOS
	
	private Serie serie;
	private String fecha; //Es String porque H2 no admite DATE
	private double precio;
	private int temporada;
	private int capitulo;
	
	//GETTERS
	
	public Serie getSerie() {
		return serie;
	}
	public String getFecha() {
		return fecha;
	}
	public double getPrecio() {
		return precio;
	}
	public int getTemporada() {
		return temporada;
	}
	public int getCapitulo() {
		return capitulo;
	}
	
	//SETTERS
	
	public void setSerie(Serie serie) {
		this.serie = serie;
	}
	public void setFecha(String fecha) {
		this.fecha = fecha;
	}
	public void setPrecio(double precio) {
		this.precio = precio;
	}
	public void setTemporada(int temporada) {
		this.temporada = temporada;
	}
	public void setCapitulo(int capitulo) {
		this.capitulo = capitulo;
	}
}
