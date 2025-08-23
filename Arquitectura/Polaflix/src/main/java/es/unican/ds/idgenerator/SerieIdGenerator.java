package es.unican.ds.idgenerator;


/**
 * Clase que genera un identificador unico universal e inmutable para las series
 * @author Adrian Garcia Cubas
 *
 */
public class SerieIdGenerator {
	
	private static long incrementado = 1;
	
	/**
	 * Metodo estatico que retorna un identificador unico universal e inmutable para las series
	 * @return identificador de la serie
	 */
	public static long getId() {		
		return incrementado++;
	}
}
