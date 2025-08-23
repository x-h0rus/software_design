package es.unican.ds.idgenerator;

/**
 * Clase que genera un identificador unico universal e inmutable para los usuarios
 * @author Adrian Garcia Cubas
 *
 */
public class UsuarioIdGenerator {
	
	private static long incrementado = 1;
	
	/**
	 * Metodo estatico que retorna un identificador unico universal e inmutable para los usuarios
	 * @return identificador del usuario
	 */
	public static long getId() {
		return incrementado++;
	}
}
