package es.unican.ds.domain;

/**
 * Serie Silver
 * @author Adrian Garcia Cubas
 *
 */
public class SerieSilver extends Serie{

	//ATRIBUTOS
	
	private final double PRECIO = 0.75;
	
	//CONSTRUCTOR
	
	public SerieSilver(String nombre, String sinopsis) {
		super(nombre, sinopsis);
	}
	
	//GETTERS
	
	@Override
	public double getPrecio() {
		return PRECIO;
	}
}
