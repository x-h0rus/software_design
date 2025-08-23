package es.unican.ds.domain;

public class CapitulosVistos {
	
	//ATRIBUTOS
	
	private Serie serie;
	private boolean capitulosVistos[][]; //BLOB
	
	//GETTERS
	
	public Serie getSerie() {
		return serie;
	}

	public boolean[][] getCapitulosVistos() {
		return capitulosVistos;
	}
	
	//SETTERS
	
	public void setSerie(Serie serie) {
		this.serie = serie;
	}

	public void setCapitulosVistos(boolean[][] capitulosVistos) {
		this.capitulosVistos = capitulosVistos;
	}
	
	
	
	
}
