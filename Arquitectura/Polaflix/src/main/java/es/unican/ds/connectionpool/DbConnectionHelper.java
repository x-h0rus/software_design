package es.unican.ds.connectionpool;

import java.util.Properties;
import java.sql.Connection;
import java.sql.DriverManager;
import java.sql.SQLException;
import java.util.TimeZone;

/**
 * Clase proporcionada por los docentes para crear una conexion con 
 * la base de datos.
 * @author Profesores de DS
 *
 */
public class DbConnectionHelper {

	/**
	 * Usuario de la base de datos.
	 */
	protected static String username = "sa";
	/**
	 * Contrasenha de la base de datos.
	 */
	protected static String password = "";
	/**
	 * Url de la base de datos
	 */
	protected static String databaseUrl = "jdbc:h2:mem:polaflix";
		
	/**
	 * Metodo que modifica el usuario de la base de datos
	 * @param username nuevo usuario
	 */
	public static void setUsername(String username) {
		DbConnectionHelper.username = username;
	}

	/**
	 * Metodo que modifica la contrasenha de la base de datos
	 * @param password nueva contrasenha de la base de datos
	 */
	public static void setPassword(String password) {
		DbConnectionHelper.password = password;
	}

	/**
	 * Metodo que modifica la URL de la base de datos
	 * @param connectionUrl nueva URL de la base de datos
	 */
	public static void setConnectionUrl(String connectionUrl) {
		DbConnectionHelper.databaseUrl = connectionUrl;
	}
	
	/**
	 * Metodo que crea una conexion con la base de datos
	 * @return conexion con la base de datos
	 * @throws SQLException
	 */
	public static Connection createConnection() throws SQLException {
		
		TimeZone timeZone = TimeZone.getTimeZone("GMT+1:00");
		TimeZone.setDefault(timeZone);
		
		Properties connectionProps = new Properties();
		connectionProps.put("user", username);
		connectionProps.put("password", password);
		connectionProps.put("serverTimezone","UTC");
		
		return DriverManager.getConnection(databaseUrl, connectionProps); 

	}

}
