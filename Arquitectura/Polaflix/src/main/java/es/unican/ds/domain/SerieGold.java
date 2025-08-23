package es.unican.ds.domain;

/**
 * Clase SerieGold
 * @author Adrian Garcia Cubas
 *
 */
public class SerieGold extends Serie{

	//ATRIBUTOS
	
	private final double PRECIO = 1.50;
	
	//CONSTRUCTOR
	
	public SerieGold(String nombre, String sinopsis) {
		super(nombre, sinopsis);
	}
	
	//GETTERS
	
	@Override
	public double getPrecio() {
		return PRECIO;
	}
}
