package es.unican.ds.domain;


/**
 * Clase para conocer el ulitmo capitulo visto por un usuario
 * @author Adrian Garcia Cubas
 *
 */
public class UltimoCapituloVisto {

	//ATRIBUTOS
	
	private Serie serie;
	private int temporada;
	private int capitulo;
	
	//CONSTRUCTOR
	
	public UltimoCapituloVisto(Serie serie, int temporada, int capitulo) {
		this.serie = serie;
		this.temporada = temporada;
		this.capitulo = capitulo;
	}

	//GETTERS
	
	public Serie getSerie() {
		return serie;
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

	public void setTemporada(int temporada) {
		this.temporada = temporada;
	}

	public void setCapitulo(int capitulo) {
		this.capitulo = capitulo;
	}
	
	
}
