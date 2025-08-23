package es.unican.ds.domain;

import java.util.Collections;
import java.util.LinkedList;
import java.util.List;

/**
 * Clase Temporada
 * @author Adrian Garcia Cubas
 *
 */
public class Temporada implements Comparable<Temporada>{
	
	//ATRIBUTOS
	
	private int numeroTemporada;
	private List<Capitulo> capitulos = new LinkedList<Capitulo>();
	
	//CONSTRUCTOR
	
	public Temporada(int numeroTemporada) {
		this.numeroTemporada = numeroTemporada;
	}
	
	//GETTERS
	
	public int getNumeroTemporada() {
		return numeroTemporada;
	}

	public List<Capitulo> getCapitulos() {
		Collections.sort(capitulos);
		return capitulos;
	}

	/**
	 * Metodo que compara dos temporadas por su numero de temporada. Ordena las temporadas de menor a mayor
	 */
	public int compareTo(Temporada o) {
		if(this.getNumeroTemporada() < o.getNumeroTemporada()) {
			return -1;
		} else {
			return 1;
		}
	}
}
