package es.unican.ds.runner;

import java.io.FileNotFoundException;
import java.io.FileReader;
import java.sql.Connection;
import java.sql.SQLException;

import org.h2.tools.RunScript;

import es.unican.ds.connectionpool.ConnectionsPool;

import es.unican.ds.domain.CuentaBancaria;
import es.unican.ds.domain.Serie;
import es.unican.ds.domain.SerieGold;
import es.unican.ds.domain.SerieSilver;
import es.unican.ds.repositories.SerieRepository;
import es.unican.ds.repositories.UsuarioRepository;
import es.unican.proxys.UsuarioProxy;

public class Runner {

	public static void main(String[] args) throws FileNotFoundException, SQLException {
		initialiseDatabase();
		
		//COMPROBAMOS QUE LAS SERIES INICIALES DE LA BASE DE DATOS ESTAN (meto series para comprobar que el find saca todas bien)
		System.out.println("Comprobamos que nos muestra todas las series insertadas en la BBDD manualmente, mas las anhadidas s's desde codigo");
		System.out.println("----------------------------------------------------------------------------------------------------------------");

		//METEMOS 2 SERIES PARA COMPROBAR QUE FUNCIONA EL GENERADOR DE IDS
		Serie s1 = new SerieSilver("Simpson", "Espectacular serie");
		SerieRepository.add(s1);
		Serie s2 = new SerieGold("Los Serrano", "Obra maestra");
		SerieRepository.add(s2);

		//COMPROBAMOS QUE SE HA ANHADIDO LA NUEVA SERIE
		System.out.println(SerieRepository.findAll());
		
		System.out.println("----------------------------------------------------------------------------------------------------------------");
		
		//COMPROBAMOS QUE LOS USUARIOS INICIALES ESTANEN LA ABSE DE DATOS
		System.out.println("Comprobamos que nos muestra todos los usuarios insertados en la BBDD manualmente, mas los anhadido u's desde codigo");
		System.out.println("----------------------------------------------------------------------------------------------------------------");
		
		//METEMOS DOS PARA COMPROBAR QUE EL GENERADOR DE IDS FUNCIONA BIEN
		UsuarioProxy u1 = new UsuarioProxy("El pepe", "Elpepe", new CuentaBancaria("ES122142465546546546"));
		UsuarioRepository.add(u1);
		UsuarioProxy u2 = new UsuarioProxy("El manolo", "Elmanolo", new CuentaBancaria("ES122142465544521546"));
		UsuarioRepository.add(u2);
		
		System.out.println(UsuarioRepository.findAll());

		System.out.println("----------------------------------------------------------------------------------------------------------------");

		
		//AL CREAR UN USARIO PROXY AL MOSTRARLO, NO TIENE NINGUNA LISTA CARGADA, CARGAMOS LISTAS DEL PRIMER USUARIO
		UsuarioProxy elPepe = UsuarioRepository.findById(1);
		elPepe.getSeriesEmpezadas();
		
		System.out.println(elPepe);
	}

	private static void initialiseDatabase() throws SQLException, FileNotFoundException {

		System.out.println("Inicializando la base de datos.");

		Connection conn = ConnectionsPool.getInstance().requestConnection();
		System.out.println("Conexion a la base de datos creada.");
		System.out.println("Creando tablas.");

		RunScript.execute(conn, new FileReader("src/main/resources/database/createDatabase.sql"));

		System.out.println("Tablas creadas.");
		System.out.println("Rellenando la base de datos.");

		RunScript.execute(conn, new FileReader("src/main/resources/database/feedDatabase.sql"));

		System.out.println("Base datos inicializada.");
		System.out.println();

	}
}
