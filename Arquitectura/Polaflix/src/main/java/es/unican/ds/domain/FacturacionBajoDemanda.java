package es.unican.ds.domain;

/**
 * Clase Facturacion
 * @author Adrian Garcia Cubas
 *
 */
public class FacturacionBajoDemanda extends Facturacion{
	
	//GETTERS

	@Override
	public double getPrecioTotal() {
		double precioTotal = 0;
		for(Visualizacion v : visualizaciones) {
			precioTotal += v.getPrecio();
		}
		return precioTotal;
	}

	//SETTERS
	
	@Override
	public void setPrecioTotal(double precioTotal) {
		super.setPrecioTotal(precioTotal);
	}
}
