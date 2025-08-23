package es.unican.ds.domain;


/**
 * Clase FacturacionCuotaFija
 * @author Adrian Garcia Cubas
 *
 */
public class FacturacionCuotaFija extends Facturacion{

	//ATRIBUTOS
	
	private final int PRECIOFIJO = 20;

	//GETTERS
	
	@Override
	public double getPrecioTotal() {
		return PRECIOFIJO;
	}


}
