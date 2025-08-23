package es.unican.ds.connectionpool;

import java.sql.Connection;
import java.sql.SQLException;
import java.util.LinkedList;
import java.util.Queue;

/**
 * Clase ConnectionsPool en la que creamos el pool de conexiones disponibles.
 * @author Adrian García Cubas
 *
 */
public class ConnectionsPool {

	private int maxConnections = 5;

	private Queue<Connection> conectionsQueue = new LinkedList<Connection>();

	protected static ConnectionsPool theInstance = null;

	/**
	 * Metodo estatico para obtener la instancia del pool de conexiones.
	 * @return theInstance la instancia
	 */
	public static ConnectionsPool getInstance() {
		if (theInstance == null) {
			theInstance = new ConnectionsPool();
		}
		return theInstance;
	}

	/**
	 * Constructor del pool de conexiones.
	 */
	protected ConnectionsPool() {
		feedPool();
	}

	/**
	 * Metodo que solicita una conexion al pool, si no hay conexiones, se crean mas.
	 * @return Conexion del pull de conexiones
	 */
	public Connection requestConnection() {
		if(conectionsQueue.isEmpty()) {
			feedPool();
		}
		return conectionsQueue.poll();
	}

	/**
	 * Metodo que devuelve una conexion al pool, o la cierra en caso de que este este lleno 
	 * @param c Conexion que se quiere retornar al pool
	 */
	public void closeConnection(Connection c) {
		
		if(conectionsQueue.size() < maxConnections) {
			conectionsQueue.add(c);
		} else {
			try {
				c.close();
			} catch (SQLException e) {
				System.out.println("No se ha podido cerrar la conexion");
			}
		}
	}
	
	/**
	 * Metodo que rellena el pool con conexiones nuevas
	 */
	private void feedPool() {
		for(int i = 0; i < maxConnections; i++) {
			try {
				conectionsQueue.add(DbConnectionHelper.createConnection());
			} catch (SQLException e) {
				e.printStackTrace();
				System.out.println("No se ha podido crear la conexion");
			}
		}
	}

}
