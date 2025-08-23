package es.unican.ds.domain;

import java.sql.SQLException;
import java.util.Collections;
import java.util.HashSet;
import java.util.LinkedList;
import java.util.List;
import java.util.Set;


/**
 * Clase usuario.
 * 
 * Implementa la interfaz comparable, para poder ordenarlos alfabeticamente por nombre de usuario
 * 
 * @author Adrian Garcia Cubas
 */
public class Usuario implements Comparable<Usuario>{
 
	//ATRIBUTOS
	
	private long id;
	private String nombreUsuario;
	private String contrasenha;
	private CuentaBancaria cuentaBancaria;
	private UltimoCapituloVisto ulitmoCapituloVisto;
	
	protected Set<Serie> seriesEmpezadas = new HashSet<Serie>();
	protected Set<Serie> seriesPendientes = new HashSet<Serie>();
	protected Set<Serie> seriesTerminadas = new HashSet<Serie>();
	protected List<Facturacion> facturas = new LinkedList<Facturacion>();
	protected List<CapitulosVistos> capitulosVistos = new LinkedList<CapitulosVistos>();
	
	//CONSTRUCTOR
	
	public Usuario(String nombre, String contrasenha, CuentaBancaria cuenta) {
		this.nombreUsuario = nombre;
		this.contrasenha = contrasenha;
		this.cuentaBancaria = cuenta;
	}
	
	//GETTERS
	
	public long getId() {
		return id;
	}
	
	public String getNombreUsuario() {
		return nombreUsuario;
	}

	public String getContrasenha() {
		return contrasenha;
	}

	public CuentaBancaria getCuentaBancaria() {
		return cuentaBancaria;	
	}
	
	public UltimoCapituloVisto getUlitmoCapituloVisto() {
		return ulitmoCapituloVisto;
	}
	
	public Set<Serie> getSeriesEmpezadas() throws SQLException{
		return seriesEmpezadas;
	}

	public Set<Serie> getSeriesPendientes() throws SQLException{
		return seriesPendientes;
	}

	public Set<Serie> getSeriesTerminadas() throws SQLException{
		return seriesTerminadas;
	}

	public List<Facturacion> getFacturas() throws SQLException{
		Collections.sort(facturas);
		return facturas;
	}

	public List<CapitulosVistos> getCapitulosVistos() throws SQLException{
		return capitulosVistos;
	}

	//SETTERS
	
	public void setId(long id) {
		this.id = id;
	}

	public void setTitulo(String nombre) {
		this.nombreUsuario = nombre;
	}

	public void setContrasenha(String contrasenha) {
		this.contrasenha = contrasenha;
	}

	public void setCuentaBancaria(CuentaBancaria cuentaBancaria) {
		this.cuentaBancaria = cuentaBancaria;
	}

	public void setSeriesEmpezadas(Set<Serie> seriesEmpezadas) {
		this.seriesEmpezadas = seriesEmpezadas;
	}

	public void setSeriesPendientes(Set<Serie> seriesPendientes) {
		this.seriesPendientes = seriesPendientes;
	}

	public void setSeriesTerminadas(Set<Serie> seriesTerminadas) {
		this.seriesTerminadas = seriesTerminadas;
	}

	public void setUlitmoCapituloVisto(UltimoCapituloVisto ulitmoCapituloVisto) {
		this.ulitmoCapituloVisto = ulitmoCapituloVisto;
	}

	public void setCapitulosVistos(List<CapitulosVistos> capitulosVistos) {
		this.capitulosVistos = capitulosVistos;
	}

	public void setFacturas(List<Facturacion> facturas) {
		this.facturas = facturas;
	}
	
	//METODOS AUXILIARES

	@Override
	public String toString() {
		try {
			return "Usuario [id=" + id + ", nombreUsuario=" + getNombreUsuario() + ", contrasenha=" + getContrasenha()
					+ ", CuentaBancaria=" + getCuentaBancaria() + ", ulitmoCapituloVisto=" + getUlitmoCapituloVisto()
					+ "\n\tseriesEmpezadas=" + getSeriesEmpezadas()  + "\n\tseriesPendientes=" + getSeriesPendientes()
					+ "\n\tseriesTerminadas=" + getSeriesTerminadas() + "\n\tfacturas=" + getFacturas() + "\n\tcapitulosVistos="
					+ getCapitulosVistos() + "]\n";
		} catch (SQLException e) {
			e.printStackTrace();
			return null;
		}
	}

	/**
	 * Metodo que compara dos usuarios por su nombre de usuario, ordena alfabeticamente (A-Z)
	 */
	public int compareTo(Usuario o) {
		return this.getNombreUsuario().compareToIgnoreCase(o.getNombreUsuario());
	}

	
	
}
