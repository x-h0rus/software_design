package es.unican.ds.dto;

import java.util.LinkedList;
import java.util.List;

/**
 * DTO de la clase Factura para la Figura 4
 * @author Adrian Garcia Cubas
 *
 */
public class FacturaFigura4Dto {
	
	//ATRIBUTOS
	
	private String fecha;
	
	protected List<VisualizacionFigura4Dto> visualizaciones = new LinkedList<VisualizacionFigura4Dto>();

	//GETTERS
	
	public String getFecha() {
		return fecha;
	}

	public List<VisualizacionFigura4Dto> getVisualizaciones() {
		return visualizaciones;
	}

	//SETTERS
	
	public void setFecha(String fecha) {
		this.fecha = fecha;
	}

	
}
