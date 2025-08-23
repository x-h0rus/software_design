package es.unican.ds.idgenerator;


/**
 * Clase que genera un identificador unico universal e inmutable para las facturas
 * @author Adrian Garcia Cubas
 *
 */
public class FacturacionIdGenerator {
	
	private static long incrementado = 1;
	
	/**
	 * Metodo estatico que retorna un identificador unico universal e inmutable para las facturas
	 * @return identificador de la factura
	 */
	public static long getId() {
		return incrementado++;
	}
}
