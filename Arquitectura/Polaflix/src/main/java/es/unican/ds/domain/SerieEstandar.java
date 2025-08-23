package es.unican.ds.domain;

/**
 * Clase SerieEstandar
 * @author Adrian Garcia Cubas
 *
 */
public class SerieEstandar extends Serie{

	//ATRIBUTOS
	
	private final double PRECIO = 0.50;
	
	//CONSTRUCTOR
	
	public SerieEstandar(String nombre, String sinopsis) {
		super(nombre, sinopsis);
	}
	
	//GETTERS
	
	@Override
	public double getPrecio() {
		return PRECIO;
	}	
}
