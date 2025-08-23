package es.unican.ds.domain;

import java.sql.Date;
import java.time.LocalDate;
import java.util.ArrayList;
import java.util.List;

/**
 * Clase facturacion.
 * @author Adrian Garcia Cubas
 *
 */
public class Facturacion implements Comparable<Facturacion>{
	
	//ATRIBUTOS
	
	private long id;
	private String fecha;
	private double precioTotal;
	
	protected List<Visualizacion> visualizaciones = new ArrayList<Visualizacion>();

	//CONSTRUCTOR
	
	public Facturacion() {
		this.fecha = Date.valueOf(LocalDate.now()).toString(); //Asumimos que un servicio crea las facturas, para el dia que se emiten
	}
	
	//GETTERS
	
	public long getId() {
		return id;
	}
	public String getFecha() {
		return fecha;
	}
	public double getPrecioTotal() {
		return precioTotal;
	}
	
	public List<Visualizacion> getVisualizaciones() {
		return visualizaciones;
	}
	//SETTERS
	
	public void setId(long id) {
		this.id = id;
	}
	public void setFecha(String fecha) {
		this.fecha = fecha;
	}
	public void setPrecioTotal(double precioTotal) {
		this.precioTotal = precioTotal;
	}

	//METODOS AUXILIARES
	
	@Override
	public String toString() {
		return "\n\t\tid=" + getId() + ", fecha=" + getFecha() + ", precioTotal=" + getPrecioTotal() + ", visualizaciones="
				+ getVisualizaciones();
	}

	public int compareTo(Facturacion o) {
		if(this.getId() < o.getId()) {
			return -1;
		} else {
			return 1;
		}
	}
	
	
}
