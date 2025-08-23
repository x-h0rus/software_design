package es.unican.ds.dto;

/**
 * DTO de visualizacion para la figura 4
 * @author Adrian Garcia Cubas
 *
 */
public class VisualizacionFigura4Dto {
	
	//ATRIBUTOS
	
	private String tituloSerie;
	private String fecha;
	private double precio;
	private int temporada;
	private int capitulo;
	
	//GETTERS
	
	public String getTituloSerie() {
		return tituloSerie;
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
	
	public void setSerie(String tituloSerie) {
		this.tituloSerie = tituloSerie;
	}
	public void setFecha(String string) {
		this.fecha = string;
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
