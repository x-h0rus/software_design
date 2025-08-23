package es.unican.ds.dto;

import java.sql.SQLException;

import es.unican.ds.domain.Facturacion;
import es.unican.ds.domain.Usuario;
import es.unican.ds.domain.Visualizacion;

/**
 * Assembler de la Figura 4 entre Usuario y Factura
 * @author Adrian Garcia Cubas
 *
 */
public class UsuarioFigura4DtoAssembler {
	
	/**
	 * Metodo que anhade a la DTO de una Usuario las facturas de la misma
	 * @param u Usuario del que se quieren obtener las facturas
	 * @return DTO de usuario para la figura 4
	 * @throws SQLException
	 */
	public UsuarioFigura4Dto paginaFacturasDto(Usuario u) throws SQLException {

		UsuarioFigura4Dto result = new UsuarioFigura4Dto();

		result.setNombreUsuario(u.getNombreUsuario());

		FacturaFigura4Dto ff4;
		VisualizacionFigura4Dto vf4;
		
		
		for(Facturacion f : u.getFacturas()) {
			ff4 = new FacturaFigura4Dto();
			ff4.setFecha(f.getFecha());
			
			for(Visualizacion v : f.getVisualizaciones()) {
				vf4 = new VisualizacionFigura4Dto();
				
				vf4.setSerie(v.getSerie().getTitulo());
				vf4.setFecha(v.getFecha());
				vf4.setTemporada(v.getTemporada());
				vf4.setCapitulo(v.getCapitulo());
				vf4.setPrecio(v.getPrecio());
				
				ff4.visualizaciones.add(vf4);
			}
			
			result.facturas.add(ff4);
		}
		
		return result;
	}
}
