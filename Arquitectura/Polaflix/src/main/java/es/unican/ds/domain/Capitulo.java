package es.unican.ds.domain;

/**
 * Clase capitulo.
 * @author Adrian Garcia Cubas
 *
 */
public class Capitulo implements Comparable<Capitulo>{

	//ATRIBUTOS
	
	private int numeroCapitulo;
	private String titulo;
	private Boolean visto;
	private String enlace;
	
	//CONSTRUCTOR
	
	public Capitulo(int numCapitulo, String titulo, String enlace) {
		this.numeroCapitulo = numCapitulo;
		this.titulo = titulo;
		this.visto = false;
		this.enlace = enlace;
	}

	//GETTERS
	
	public int getNumeroCapitulo() {
		return numeroCapitulo;
	}

	public String getTitulo() {
		return titulo;
	}

	public Boolean getVisto() {
		return visto;
	}

	public String getEnlace() {
		return enlace;
	}

	//SETTERS
	public void setNumeroCapitulo(int numeroCapitulo) {
		this.numeroCapitulo = numeroCapitulo;
	}

	public void setTitulo(String titulo) {
		this.titulo = titulo;
	}

	public void setVisto(Boolean visto) {
		this.visto = visto;
	}

	public void setEnlace(String enlace) {
		this.enlace = enlace;
	}

	
	//METODOS AUZILIARES
	
	/**
	 * Metodo que compara dos capitulos segun su numero de capitulo. Ordena los capiptulos de menor a mayor
	 */
	public int compareTo(Capitulo o) {
		if(this.getNumeroCapitulo() < o.getNumeroCapitulo()) {
			return -1;
		} else {
			return 1;
		}
	}
	
	
}
