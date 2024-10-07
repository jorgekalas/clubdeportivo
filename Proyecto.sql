CREATE DATABASE Proyecto;
USE Proyecto;

CREATE TABLE Cliente (
    id INT AUTO_INCREMENT PRIMARY KEY,
    nombre VARCHAR(100) NOT NULL,
    apellido VARCHAR(100) NOT NULL,
    tipoDocumento VARCHAR(50) NOT NULL,
    numeroDocumento VARCHAR(50) UNIQUE NOT NULL, -- Este campo se usará para identificar al cliente
    socio BOOLEAN NOT NULL,
    carnet VARCHAR(50) UNIQUE, -- Este campo se usará como "contraseña"
    cuotaVencimiento DATE,
    fichaMedica TEXT,
    fechaRegistro DATETIME DEFAULT CURRENT_TIMESTAMP
);


CREATE TABLE Cuota (
    id INT AUTO_INCREMENT PRIMARY KEY,
    clienteId INT NOT NULL,
    monto DECIMAL(10, 2) NOT NULL,
    fechaPago DATE NOT NULL,
    fechaVencimiento DATE NOT NULL,
    formaPago ENUM('efectivo', 'tarjeta') NOT NULL,
    promocion BOOLEAN DEFAULT FALSE,
    FOREIGN KEY (clienteId) REFERENCES Cliente(id) ON DELETE CASCADE
);

CREATE TABLE Actividad (
    id INT AUTO_INCREMENT PRIMARY KEY,
    nombreActividad VARCHAR(100) NOT NULL,
    tipo ENUM('socios', 'no socios') NOT NULL,
    profesor VARCHAR(100),
    horario VARCHAR(50),
    salonGeneral BOOLEAN,
    costoNoSocio DECIMAL(10, 2) NOT NULL
);

CREATE TABLE Profesional (
    id INT AUTO_INCREMENT PRIMARY KEY,
    nombre VARCHAR(100) NOT NULL,
    apellido VARCHAR(100) NOT NULL,
    tipo ENUM('profesor', 'nutricionista') NOT NULL,
    titular BOOLEAN,
    suplente BOOLEAN,
    planillaAsistencia TEXT
);

CREATE TABLE Inscripcion (
    id INT AUTO_INCREMENT PRIMARY KEY,
    clienteId INT NOT NULL,
    fechaInscripcion DATETIME DEFAULT CURRENT_TIMESTAMP,
    estado ENUM('activo', 'inactivo') NOT NULL,
    aptitudFisica BOOLEAN NOT NULL,
    FOREIGN KEY (clienteId) REFERENCES Cliente(id) ON DELETE CASCADE
);


CREATE TABLE ClienteActividad (
    id INT AUTO_INCREMENT PRIMARY KEY,
    clienteId INT NOT NULL,
    actividadId INT NOT NULL,
    fechaParticipacion DATE NOT NULL,
    FOREIGN KEY (clienteId) REFERENCES Cliente(id) ON DELETE CASCADE,
    FOREIGN KEY (actividadId) REFERENCES Actividad(id) ON DELETE CASCADE
);


#Procedimiento almacenado para el Login

DELIMITER //

CREATE PROCEDURE IngresoLogin(IN numeroDocumento VARCHAR(50), IN carnet VARCHAR(50))
BEGIN
    SELECT *
    FROM Cliente
    WHERE Cliente.numeroDocumento = numeroDocumento
    AND Cliente.carnet = carnet
    AND Cliente.socio = 1; -- Solo permite ingresar a los clientes que son socios
END //

DELIMITER ;

#Procedimiento almacenado para el registro de un nuevo usuario

DELIMITER //

CREATE PROCEDURE NuevoCliente(
    IN IN_Nombre VARCHAR(100),
    IN IN_Apellido VARCHAR(100),
    IN IN_TipoDocumento VARCHAR(50),
    IN IN_NumeroDocumento VARCHAR(50),
    IN IN_Socio BOOLEAN,
    IN IN_Carnet VARCHAR(50),
    OUT rta INT
)
BEGIN
    DECLARE existe INT DEFAULT 0;
    
    -- Verificar si el cliente ya existe usando el parámetro correctamente
    SET existe = (SELECT COUNT(*) FROM Cliente WHERE NumeroDocumento = IN_NumeroDocumento);

    IF existe = 0 THEN
        -- Insertar el nuevo cliente
        INSERT INTO Cliente (nombre, apellido, tipoDocumento, numeroDocumento, socio, carnet, cuotaVencimiento)
        VALUES (IN_Nombre, IN_Apellido, IN_TipoDocumento, IN_NumeroDocumento, IN_Socio, IN_Carnet, NULL);
        SET rta = LAST_INSERT_ID(); -- Retorna el ID del cliente recién creado
    ELSE
        SET rta = 1; -- Si el cliente ya existe, retornamos 1
    END IF;

END //

DELIMITER ;




#Inserción de datos de prueba

INSERT INTO Cliente (nombre, apellido, tipoDocumento, numeroDocumento, socio, carnet, cuotaVencimiento, fichaMedica)
VALUES ('Juan', 'Pérez', 'DNI', '12345678', TRUE, 'CARNET123', '2024-12-31', 'Ficha médica de Juan');

INSERT INTO Inscripcion (clienteId, estado, aptitudFisica)
VALUES (1, 'activo', TRUE);

SELECT * from cliente;

