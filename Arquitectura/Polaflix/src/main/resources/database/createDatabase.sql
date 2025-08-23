CREATE TABLE Serie (
  		idSerie INT NOT NULL,
		titulo VARCHAR(30) NOT NULL,
		precio DECIMAL(3,2) NOT NULL,
  		sinopsis VARCHAR(100) NOT NULL,
		tipoSerie VARCHAR(20) NOT NULL, -- Single table inheritance

		PRIMARY KEY (idSerie)
	);

---------------------------------------------------------------------------------------------------------------

CREATE TABLE Temporada (
		numeroTemporada INT NOT NULL,
  		serie INT NOT NULL,

		PRIMARY KEY (numeroTemporada, serie),
		FOREIGN KEY (serie) REFERENCES Serie (idSerie) ON DELETE CASCADE
	);

---------------------------------------------------------------------------------------------------------------

CREATE TABLE Capitulo (
		numeroCapitulo INT NOT NULL,
		titulo VARCHAR(30) NOT NULL,
        visto CHAR(1) NOT NULL,
        enlace VARCHAR(40) NOT NULL,
        temporada INT NOT NULL,

		PRIMARY KEY (numeroCapitulo, temporada),
		FOREIGN KEY (temporada) REFERENCES Temporada (numeroTemporada) ON DELETE CASCADE
	);

---------------------------------------------------------------------------------------------------------------

CREATE TABLE Usuario (
		idUsuario INT NOT NULL,
		nombreUsuario VARCHAR(20) NOT NULL,
		contrasenha VARCHAR(30) NOT NULL,

		PRIMARY KEY (idUsuario),
	);

----------------------------------------------------------------------------------------------------------------

CREATE TABLE CuentaBancaria (
		iban VARCHAR(34) NOT NULL,
		usuario INT NOT NULL,

		PRIMARY KEY (iban),
		FOREIGN KEY (usuario) REFERENCES Usuario (idUsuario) ON DELETE CASCADE
	);
	
	
---------------------------------------------------------------------------------------------------------------

CREATE TABLE SeriesEmpezadas (
		serie INT NOT NULL,
		usuario INT NOT NULL,
		
		PRIMARY KEY (serie, usuario),
		FOREIGN KEY (serie) REFERENCES Serie (idSerie),
		FOREIGN KEY (usuario) REFERENCES Usuario (idUsuario) ON DELETE CASCADE
	);

---------------------------------------------------------------------------------------------------------------

CREATE TABLE SeriesPendientes (
		serie INT NOT NULL,
		usuario INT NOT NULL,
		
		PRIMARY KEY (serie, usuario),
		FOREIGN KEY (serie) REFERENCES Serie (idSerie),
		FOREIGN KEY (usuario) REFERENCES Usuario (idUsuario) ON DELETE CASCADE
	);

---------------------------------------------------------------------------------------------------------------

CREATE TABLE SeriesTerminadas (
		serie INT NOT NULL,
		usuario INT NOT NULL,
		
		PRIMARY KEY (serie, usuario),
		FOREIGN KEY (serie) REFERENCES Serie (idSerie),
		FOREIGN KEY (usuario) REFERENCES Usuario (idUsuario) ON DELETE CASCADE
	);

---------------------------------------------------------------------------------------------------------------


CREATE TABLE Persona (
		nombre VARCHAR(30) NOT NULL,
		tipoPersona VARCHAR(20) NOT NULL,
		serie INT NOT NULL, 

		PRIMARY KEY (nombre, tipoPersona, serie),
		FOREIGN KEY (serie) REFERENCES Serie (idSerie) ON DELETE CASCADE
	);

----------------------------------------------------------------------------------------------------------------

CREATE TABLE CapitulosVistos (
		serie INT NOT NULL,
		temporada INT NOT NULL,
		capitulo INT NOT NULL,
		usuario INT NOT NULL,

		PRIMARY KEY (serie, temporada, capitulo, usuario),
		FOREIGN KEY (serie) REFERENCES Serie (idSerie),
		FOREIGN KEY (usuario) REFERENCES Usuario (idUsuario) ON DELETE CASCADE-- Asociation Table MApping
	);

----------------------------------------------------------------------------------------------------------------

CREATE TABLE UltimoCapituloVisto (
		serie INT NOT NULL,
		temporada INT NOT NULL,
		capitulo INT NOT NULL,
		usuario INT NOT NULL,

		PRIMARY KEY (serie, temporada, capitulo, usuario),
		FOREIGN KEY (serie) REFERENCES Serie (idSerie),
		FOREIGN KEY (usuario) REFERENCES Usuario (idUsuario) ON DELETE CASCADE-- Asociation Table Mapping
	);

----------------------------------------------------------------------------------------------------------------

CREATE TABLE Facturacion (
		idFactura INT NOT NULL,
		fecha CHAR(10) NOT NULL,
		precioTotal DECIMAL(5,2) NOT NULL,
		tipoFacturacion VARCHAR(22) NOT NULL,
		usuario INT NOT NULL,


		PRIMARY KEY (idFactura),
		FOREIGN KEY (usuario) REFERENCES Usuario (idUsuario) ON DELETE CASCADE
	);

-----------------------------------------------------------------------------------------------------------------

CREATE TABLE Visualizacion (
		idVisualizacion INT NOT NULL,
		fecha CHAR(10) NOT NULL,
		temporada INT NOT NULL,
		capitulo INT NOT NULL,
		serie INT NOT NULL,
		factura INT NOT NULL,

		PRIMARY KEY (idVisualizacion),
		FOREIGN KEY (serie) REFERENCES Serie (idSerie), 
		FOREIGN KEY (factura) REFERENCES Facturacion (idFactura)
	);
-----------------------------------------------------------------------------------------------------------------

