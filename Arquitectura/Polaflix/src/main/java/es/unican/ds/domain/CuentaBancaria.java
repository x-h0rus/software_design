package es.unican.ds.domain;

/**
 * Clase Cuenta Bancaria
 * @author Adrian Garcia Cubas
 *
 */
public class CuentaBancaria {
	
	//ATRIBUTOS
	
	private String iban;
	
	//CONSTRUCTOR
	
	public CuentaBancaria(String iban) {
		this.iban = iban;
	}
	
	//GETTERS
	
	public String getIban() {
		return iban;
	}

	//METODOS AUXILIARES
	
	@Override
	public String toString() {
		return getIban();
	}
	
	
}
