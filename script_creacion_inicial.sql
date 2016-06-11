USE [GD1C2016]

GO
/** CREACION DEL ESQUEMA Y LAS TABLAS PRINCIPALES **/ 

CREATE SCHEMA [LOPEZ_Y_CIA] AUTHORIZATION [gd]
GO

CREATE SEQUENCE [LOPEZ_Y_CIA].[secuenciaCalif] START WITH 15185
CREATE TABLE [LOPEZ_Y_CIA].[Calificacion](
	[idCalificacion] [int] IDENTITY(1,1) NOT NULL,
	[codigo] INT DEFAULT NEXT VALUE FOR [LOPEZ_Y_CIA].[secuenciaCalif] NOT NULL,
	[cantEstrellas] [int] NOT NULL,
	[descripcion] [varchar](255) NULL,
	CONSTRAINT [PK_Calificacion] PRIMARY KEY CLUSTERED([idCalificacion] ASC)
) ON [PRIMARY]

CREATE TABLE [LOPEZ_Y_CIA].[Cliente](
	[dni] [int] NOT NULL,
	[tipoDocumento] [int] NOT NULL,
	[nombre] [varchar](255) NULL,
	[apellido] [varchar](255) NULL,
	[fechaNacimiento] [date] NULL,
	[perfilActivo] [bit] NOT NULL,
	[idUsuario] [int] NOT NULL,
	[fechaCreacion] [date] NULL,
	[comprasEfectuadas] [int] NULL,
	[comprasCalificadas] [int] NULL,
	CONSTRAINT [PK_Cliente_1] PRIMARY KEY CLUSTERED([idUsuario] ASC),
	CONSTRAINT [UK_Documento] UNIQUE ([dni],[tipoDocumento])
) ON [PRIMARY]

CREATE TABLE [LOPEZ_Y_CIA].[ComisionesParametrizables](
	[idComisionesParametrizables] [int] IDENTITY(1,1) NOT NULL,
	[nombreCorto] [varchar](10) NOT NULL,
	[nombre] [varchar](250) NOT NULL,
	[porcentaje] [numeric](18, 4) NOT NULL,
	CONSTRAINT [pk_idComisionesParametrizables] PRIMARY KEY CLUSTERED([idComisionesParametrizables] ASC)
) ON [PRIMARY]

CREATE TABLE [LOPEZ_Y_CIA].[CompraUsuario](
	[idCompraUsuario] [int] IDENTITY(1,1) NOT NULL,
	[idPublicacion] [int] NOT NULL,
	[idUsuario] [int] NOT NULL,
	[idCalificacion] [int] NULL,
	[fecha] [datetime] NULL,
	[compraCantidad] [int] NOT NULL
	CONSTRAINT [PK_CompraUsuario] PRIMARY KEY CLUSTERED([idCompraUsuario] ASC)
) ON [PRIMARY]

CREATE TABLE [LOPEZ_Y_CIA].[DatosBasicos](
	[idDatosBasicos] [int] IDENTITY(1,1) NOT NULL,
	[email] [varchar](255) NOT NULL,
	[domCalle] [varchar](255) NULL,
	[nroCalle] [int] NULL,
	[piso] [int] NULL,
	[depto] [varchar](50) NULL,
	[codPostal] [varchar](50) NULL,
	[localidad] [varchar](50) NULL,
	[ciudad] [varchar](50) NULL,
	CONSTRAINT [PK_DatosBasicos] PRIMARY KEY CLUSTERED([idDatosBasicos] ASC)
) ON [PRIMARY]

CREATE TABLE [LOPEZ_Y_CIA].[Empresa](
	[razonSocial] [varchar](50) NOT NULL UNIQUE,
	[cuit] [varchar](50) NOT NULL UNIQUE,
	[fechaCreacion] [date] NULL,
	[perfilActivo] [bit] NOT NULL,
	[idUsuario] [int] NOT NULL,
	[nombreContacto] [varchar](50) NULL,
	CONSTRAINT [PK_Empresa_1] PRIMARY KEY CLUSTERED([idUsuario] ASC)
) ON [PRIMARY]

CREATE TABLE [LOPEZ_Y_CIA].[EstadoPublicacion](
	[idEstadoPublicacion] [int] IDENTITY(1,1) NOT NULL,
	[nombre] [varchar](255) NOT NULL,
	[nombreCorto] [varchar](10) NULL, /*NO LO PEDIA EN NINGUN LADO ESTO*/
	CONSTRAINT [PK_EstadoPublicacion] PRIMARY KEY CLUSTERED([idEstadoPublicacion] ASC)
) ON [PRIMARY]

CREATE SEQUENCE [LOPEZ_Y_CIA].[secuenciaFactu] START WITH 121315
CREATE TABLE [LOPEZ_Y_CIA].[Factura](
	[idFactura] [int] IDENTITY(1,1) NOT NULL,
	[idPublicacion] [int] NOT NULL,
	[nroFactura] INT DEFAULT NEXT VALUE FOR [LOPEZ_Y_CIA].[secuenciaFactu] NOT NULL,
	[fecha] [datetime] NULL,
	[montoTotal] [numeric](18, 2) NOT NULL,
	[formaPagoDesc] [varchar](255) NULL,
	CONSTRAINT [PK_Factura] PRIMARY KEY CLUSTERED([idFactura] ASC)
) ON [PRIMARY]

CREATE TABLE [LOPEZ_Y_CIA].[Funciones](
	[idFunciones] [int] IDENTITY(1,1) NOT NULL,
	[nombre] [varchar](50) NOT NULL,
	[descripcion] [varchar](255) NULL,
	[activo] [bit] NOT NULL,
	CONSTRAINT [PK_Funciones] PRIMARY KEY CLUSTERED([idFunciones] ASC)
) ON [PRIMARY]

CREATE TABLE [LOPEZ_Y_CIA].[ItemFactura](
	[idItemFactura] [int] IDENTITY(1,1) NOT NULL,
	[idFactura] [int] NOT NULL,
	[cantidad] [int] NOT NULL,
	[monto] [numeric](18, 2) NOT NULL,
	CONSTRAINT [PK_ItemFactura] PRIMARY KEY CLUSTERED([idItemFactura] ASC)
) ON [PRIMARY]

CREATE TABLE [LOPEZ_Y_CIA].[OfertaSubasta](
	[idOfertaSubasta] [int] IDENTITY(1,1) NOT NULL,
	[idPublicacion] [int] NOT NULL,
	[idUsuario] [int] NOT NULL,
	[monto] [numeric](18, 2) NOT NULL,
	[fecha] [datetime] NOT NULL,
	[adjudicada] [bit] NOT NULL,
	CONSTRAINT [PK_OfertaSubasta] PRIMARY KEY CLUSTERED([idOfertaSubasta] ASC)
) ON [PRIMARY]

CREATE TABLE [LOPEZ_Y_CIA].[Preguntas](
	[idPreguntas] [int] IDENTITY(1,1) NOT NULL,
	[idUsuario] [int] NOT NULL,
	[descripcion] [text] NULL,
	[idPublicacion] [int] NOT NULL,
	CONSTRAINT [PK_Preguntas] PRIMARY KEY CLUSTERED([idPreguntas] ASC)
) ON [PRIMARY]

CREATE TABLE [LOPEZ_Y_CIA].[Publicacion](
	[idPublicacion] [int] IDENTITY(1,1) NOT NULL,
	[idEstadoPublicacion] [int] NOT NULL,
	[idVisibilidad] [int] NOT NULL,
	[codigoPublicacion] [int] NULL,
	[descripcion] [varchar](255) NULL,
	[fechaCreacion] [date] NOT NULL,
	[fechaVencimiento] [date] NULL,
	[stock] [int] NULL,
	[preguntasSN] [bit] NULL,
	[envioSN] [bit] NULL,
	[idUsuario] [int] NOT NULL,
	CONSTRAINT [PK_Publicacion] PRIMARY KEY CLUSTERED([idPublicacion] ASC),
	CONSTRAINT [Rango_fechaVencimiento] CHECK ([fechaVencimiento] >= [fechaCreacion])
) ON [PRIMARY]

CREATE TABLE [LOPEZ_Y_CIA].[PublicacionNormal](
	[idPublicacion] [int] NOT NULL,
	[precioPorUnidad] [numeric](18, 2) NOT NULL,
	CONSTRAINT [PK_PublicacionNormal_1] PRIMARY KEY CLUSTERED([idPublicacion] ASC)
) ON [PRIMARY]

CREATE TABLE [LOPEZ_Y_CIA].[PublicacionSubasta](
	[valorInicialVenta] [numeric](18, 2) NOT NULL,
	[idPublicacion] [int] NOT NULL,
	[valorActual] [numeric](18, 2) NOT NULL,
	CONSTRAINT [PK_PublicacionSubasta_1] PRIMARY KEY CLUSTERED([idPublicacion] ASC)
) ON [PRIMARY]

CREATE TABLE [LOPEZ_Y_CIA].[Rol](
	[idRol] [int] IDENTITY(1,1) NOT NULL,
	[nombre] [varchar](20) NOT NULL,
	[activo] [bit] NOT NULL,
	CONSTRAINT [PK_Rol] PRIMARY KEY CLUSTERED([idRol] ASC)
) ON [PRIMARY]

CREATE TABLE [LOPEZ_Y_CIA].[RolFunciones](
	[idRol] [int] NOT NULL,
	[idFunciones] [int] NOT NULL
) ON [PRIMARY]

CREATE TABLE [LOPEZ_Y_CIA].[RolUsuario](
	[idRol] [int] NOT NULL,
	[idUsuario] [int] NOT NULL,
	[activo] [bit] NULL
) ON [PRIMARY]

CREATE TABLE [LOPEZ_Y_CIA].[Rubro](
	[idRubro] [int] IDENTITY(1,1) NOT NULL,
	[codigo] [nchar](5) NULL,
	[nombreCorto] [varchar](10) NULL,
	[descripcion] [varchar](255) NULL,
	CONSTRAINT [PK_Rubro] PRIMARY KEY CLUSTERED([idRubro] ASC)
) ON [PRIMARY]

CREATE TABLE [LOPEZ_Y_CIA].[RubroPublicacion](
	[idPublicacion] [int] NOT NULL,
	[idRubro] [int] NOT NULL
) ON [PRIMARY]

CREATE TABLE [LOPEZ_Y_CIA].[Usuario](
	[idUsuario] [int] IDENTITY(1,1) NOT NULL,
	[userName] [varchar](50) NOT NULL UNIQUE,
	[password] [varchar](255) NOT NULL,
	[activoUsuario] [bit] NOT NULL,
	[intentosFallidos] [int] NULL,
	[publicacionGratis] [bit] NULL,
	[cantidadEstrellas] [int] NULL,
	[cantidadVentas] [int] NULL,
	[idDatosBasicos] [int] NULL,
	CONSTRAINT [PK_Usuario_1] PRIMARY KEY CLUSTERED([idUsuario] ASC)
) ON [PRIMARY]

CREATE SEQUENCE [LOPEZ_Y_CIA].[secuenciaVisib] START WITH 10002
CREATE TABLE [LOPEZ_Y_CIA].[Visibilidad](
	[idVisibilidad] [int] IDENTITY(1,1) NOT NULL,
	[codigoVisibilidad] INT DEFAULT NEXT VALUE FOR [LOPEZ_Y_CIA].[secuenciaVisib] NOT NULL,
	[nombreVisibilidad] [varchar](50) NULL,
	[costo] [numeric](18, 2) NOT NULL,
	[porcentaje] [numeric](5, 4) NOT NULL,
	CONSTRAINT [PK_Visibilidad] PRIMARY KEY CLUSTERED([idVisibilidad] ASC),
	CONSTRAINT [Rango_Porcentaje] CHECK ([porcentaje] <= 1 AND [porcentaje] >= 0)
) ON [PRIMARY]

CREATE TABLE [LOPEZ_Y_CIA].[workflowEstados](
	[idWorkflowEstados] [int] IDENTITY(1,1) NOT NULL,
	[idEstadoInicial] [int] NOT NULL,
	[idEstadoFinal] [int] NOT NULL,
	[activo] [bit] NOT NULL
) ON [PRIMARY]


GO
/** SETEANDO LAS FK **/ 

ALTER TABLE [LOPEZ_Y_CIA].[Cliente] WITH CHECK ADD
	CONSTRAINT [FK_Cliente_Usuario] FOREIGN KEY([idUsuario]) REFERENCES [LOPEZ_Y_CIA].[Usuario] ([idUsuario])
ALTER TABLE [LOPEZ_Y_CIA].[Cliente] CHECK CONSTRAINT [FK_Cliente_Usuario]

ALTER TABLE [LOPEZ_Y_CIA].[CompraUsuario] WITH CHECK ADD
	CONSTRAINT [FK_CompraUsuario_Calificacion] FOREIGN KEY([idCalificacion]) REFERENCES [LOPEZ_Y_CIA].[Calificacion] ([idCalificacion])
ALTER TABLE [LOPEZ_Y_CIA].[CompraUsuario] CHECK CONSTRAINT [FK_CompraUsuario_Calificacion]

ALTER TABLE [LOPEZ_Y_CIA].[CompraUsuario] WITH CHECK ADD
	CONSTRAINT [FK_CompraUsuario_Publicacion] FOREIGN KEY([idPublicacion]) REFERENCES [LOPEZ_Y_CIA].[Publicacion] ([idPublicacion])
ALTER TABLE [LOPEZ_Y_CIA].[CompraUsuario] CHECK CONSTRAINT [FK_CompraUsuario_Publicacion]

ALTER TABLE [LOPEZ_Y_CIA].[CompraUsuario] WITH CHECK ADD
	CONSTRAINT [FK_CompraUsuario_Usuario] FOREIGN KEY([idUsuario]) REFERENCES [LOPEZ_Y_CIA].[Usuario] ([idUsuario])
ALTER TABLE [LOPEZ_Y_CIA].[CompraUsuario] CHECK CONSTRAINT [FK_CompraUsuario_Usuario]

ALTER TABLE [LOPEZ_Y_CIA].[Empresa] WITH CHECK ADD
	CONSTRAINT [FK_Empresa_Usuario] FOREIGN KEY([idUsuario]) REFERENCES [LOPEZ_Y_CIA].[Usuario] ([idUsuario])
ALTER TABLE [LOPEZ_Y_CIA].[Empresa] CHECK CONSTRAINT [FK_Empresa_Usuario]

ALTER TABLE [LOPEZ_Y_CIA].[Factura] WITH CHECK ADD
	CONSTRAINT [FK_Factura_Publicacion] FOREIGN KEY([idPublicacion]) REFERENCES [LOPEZ_Y_CIA].[Publicacion] ([idPublicacion])
ALTER TABLE [LOPEZ_Y_CIA].[Factura] CHECK CONSTRAINT [FK_Factura_Publicacion]

ALTER TABLE [LOPEZ_Y_CIA].[ItemFactura] WITH CHECK ADD
	CONSTRAINT [FK_ItemFactura_Factura] FOREIGN KEY([idFactura]) REFERENCES [LOPEZ_Y_CIA].[Factura] ([idFactura])
ALTER TABLE [LOPEZ_Y_CIA].[ItemFactura] CHECK CONSTRAINT [FK_ItemFactura_Factura]

ALTER TABLE [LOPEZ_Y_CIA].[OfertaSubasta] WITH CHECK ADD
	CONSTRAINT [FK_OfertaSubasta_PublicacionSubasta] FOREIGN KEY([idPublicacion]) REFERENCES [LOPEZ_Y_CIA].[PublicacionSubasta] ([idPublicacion])
ALTER TABLE [LOPEZ_Y_CIA].[OfertaSubasta] CHECK CONSTRAINT [FK_OfertaSubasta_PublicacionSubasta]

ALTER TABLE [LOPEZ_Y_CIA].[OfertaSubasta] WITH CHECK ADD
	CONSTRAINT [FK_OfertaSubasta_Usuario] FOREIGN KEY([idUsuario]) REFERENCES [LOPEZ_Y_CIA].[Usuario] ([idUsuario])
ALTER TABLE [LOPEZ_Y_CIA].[OfertaSubasta] CHECK CONSTRAINT [FK_OfertaSubasta_Usuario]

ALTER TABLE [LOPEZ_Y_CIA].[Preguntas] WITH CHECK ADD
	CONSTRAINT [FK_Preguntas_Publicacion] FOREIGN KEY([idPublicacion]) REFERENCES [LOPEZ_Y_CIA].[Publicacion] ([idPublicacion])
ALTER TABLE [LOPEZ_Y_CIA].[Preguntas] CHECK CONSTRAINT [FK_Preguntas_Publicacion]

ALTER TABLE [LOPEZ_Y_CIA].[Preguntas] WITH CHECK ADD
	CONSTRAINT [FK_Preguntas_Usuario] FOREIGN KEY([idUsuario]) REFERENCES [LOPEZ_Y_CIA].[Usuario] ([idUsuario])
ALTER TABLE [LOPEZ_Y_CIA].[Preguntas] CHECK CONSTRAINT [FK_Preguntas_Usuario]

ALTER TABLE [LOPEZ_Y_CIA].[Publicacion] WITH CHECK ADD
	CONSTRAINT [FK_Publicacion_EstadoPublicacion] FOREIGN KEY([idEstadoPublicacion]) REFERENCES [LOPEZ_Y_CIA].[EstadoPublicacion] ([idEstadoPublicacion])
ALTER TABLE [LOPEZ_Y_CIA].[Publicacion] CHECK CONSTRAINT [FK_Publicacion_EstadoPublicacion]

ALTER TABLE [LOPEZ_Y_CIA].[Publicacion] WITH CHECK ADD
	CONSTRAINT [FK_Publicacion_Usuario] FOREIGN KEY([idUsuario]) REFERENCES [LOPEZ_Y_CIA].[Usuario] ([idUsuario])
ALTER TABLE [LOPEZ_Y_CIA].[Publicacion] CHECK CONSTRAINT [FK_Publicacion_Usuario]

ALTER TABLE [LOPEZ_Y_CIA].[Publicacion] WITH CHECK ADD
	CONSTRAINT [FK_Publicacion_Visibilidad] FOREIGN KEY([idVisibilidad]) REFERENCES [LOPEZ_Y_CIA].[Visibilidad] ([idVisibilidad])
ALTER TABLE [LOPEZ_Y_CIA].[Publicacion] CHECK CONSTRAINT [FK_Publicacion_Visibilidad]

ALTER TABLE [LOPEZ_Y_CIA].[PublicacionNormal] WITH CHECK ADD
	CONSTRAINT [FK_PublicacionNormal_Publicacion] FOREIGN KEY([idPublicacion]) REFERENCES [LOPEZ_Y_CIA].[Publicacion] ([idPublicacion])
ALTER TABLE [LOPEZ_Y_CIA].[PublicacionNormal] CHECK CONSTRAINT [FK_PublicacionNormal_Publicacion]

ALTER TABLE [LOPEZ_Y_CIA].[PublicacionSubasta] WITH CHECK ADD
	CONSTRAINT [FK_PublicacionSubasta_Publicacion] FOREIGN KEY([idPublicacion]) REFERENCES [LOPEZ_Y_CIA].[Publicacion] ([idPublicacion])
ALTER TABLE [LOPEZ_Y_CIA].[PublicacionSubasta] CHECK CONSTRAINT [FK_PublicacionSubasta_Publicacion]

ALTER TABLE [LOPEZ_Y_CIA].[RolFunciones] WITH CHECK ADD
	CONSTRAINT [FK_RolFunciones_Funciones] FOREIGN KEY([idFunciones]) REFERENCES [LOPEZ_Y_CIA].[Funciones] ([idFunciones])
ALTER TABLE [LOPEZ_Y_CIA].[RolFunciones] CHECK CONSTRAINT [FK_RolFunciones_Funciones]

ALTER TABLE [LOPEZ_Y_CIA].[RolFunciones] WITH CHECK ADD
	CONSTRAINT [FK_RolFunciones_Rol] FOREIGN KEY([idRol]) REFERENCES [LOPEZ_Y_CIA].[Rol] ([idRol])
ALTER TABLE [LOPEZ_Y_CIA].[RolFunciones] CHECK CONSTRAINT [FK_RolFunciones_Rol]

ALTER TABLE [LOPEZ_Y_CIA].[RolUsuario] WITH CHECK ADD
	CONSTRAINT [FK_RolUsuario_Rol] FOREIGN KEY([idRol]) REFERENCES [LOPEZ_Y_CIA].[Rol] ([idRol])
ALTER TABLE [LOPEZ_Y_CIA].[RolUsuario] CHECK CONSTRAINT [FK_RolUsuario_Rol]

ALTER TABLE [LOPEZ_Y_CIA].[RolUsuario] WITH CHECK ADD
	CONSTRAINT [FK_RolUsuario_Usuario] FOREIGN KEY([idUsuario]) REFERENCES [LOPEZ_Y_CIA].[Usuario] ([idUsuario])
ALTER TABLE [LOPEZ_Y_CIA].[RolUsuario] CHECK CONSTRAINT [FK_RolUsuario_Usuario]

ALTER TABLE [LOPEZ_Y_CIA].[RubroPublicacion] WITH CHECK ADD
	CONSTRAINT [FK_RubroPublicacion_Publicacion] FOREIGN KEY([idPublicacion]) REFERENCES [LOPEZ_Y_CIA].[Publicacion] ([idPublicacion])
ALTER TABLE [LOPEZ_Y_CIA].[RubroPublicacion] CHECK CONSTRAINT [FK_RubroPublicacion_Publicacion]

ALTER TABLE [LOPEZ_Y_CIA].[RubroPublicacion] WITH CHECK ADD
	CONSTRAINT [FK_RubroPublicacion_Rubro] FOREIGN KEY([idRubro]) REFERENCES [LOPEZ_Y_CIA].[Rubro] ([idRubro])
ALTER TABLE [LOPEZ_Y_CIA].[RubroPublicacion] CHECK CONSTRAINT [FK_RubroPublicacion_Rubro]

ALTER TABLE [LOPEZ_Y_CIA].[Usuario] WITH CHECK ADD
	CONSTRAINT [FK_Usuario_DatosBasicos] FOREIGN KEY([idDatosBasicos]) REFERENCES [LOPEZ_Y_CIA].[DatosBasicos] ([idDatosBasicos])
ALTER TABLE [LOPEZ_Y_CIA].[Usuario] CHECK CONSTRAINT [FK_Usuario_DatosBasicos]

ALTER TABLE [LOPEZ_Y_CIA].[workflowEstados] WITH CHECK ADD
	CONSTRAINT [FK_workflowEstados_EstadoPublicacion_final] FOREIGN KEY([idEstadoFinal]) REFERENCES [LOPEZ_Y_CIA].[EstadoPublicacion] ([idEstadoPublicacion])
ALTER TABLE [LOPEZ_Y_CIA].[workflowEstados] CHECK CONSTRAINT [FK_workflowEstados_EstadoPublicacion_final]

ALTER TABLE [LOPEZ_Y_CIA].[workflowEstados] WITH CHECK ADD
	CONSTRAINT [FK_workflowEstados_EstadoPublicacion_inicial] FOREIGN KEY([idEstadoInicial]) REFERENCES [LOPEZ_Y_CIA].[EstadoPublicacion] ([idEstadoPublicacion])
ALTER TABLE [LOPEZ_Y_CIA].[workflowEstados] CHECK CONSTRAINT [FK_workflowEstados_EstadoPublicacion_inicial]


GO
/** MIGRACION **/

INSERT INTO [LOPEZ_Y_CIA].[DatosBasicos] (email, domCalle, nroCalle, piso, depto, codPostal)
SELECT
	Cli_Mail,
	Cli_Dom_Calle,
	Cli_Nro_Calle,
	Cli_Piso,
	Cli_Depto,
	Cli_Cod_Postal
FROM [gd_esquema].[Maestra]
WHERE Cli_Dni IS NOT NULL
GROUP BY
	Cli_Dni,
	Cli_Mail,
	Cli_Dom_Calle,
	Cli_Nro_Calle,
	Cli_Piso,
	Cli_Depto,
	Cli_Cod_Postal
UNION
SELECT
	Publ_Empresa_Mail,
	Publ_Empresa_Dom_Calle,
	Publ_Empresa_Nro_Calle,
	Publ_Empresa_Piso,
	Publ_Empresa_Depto,
	Publ_Empresa_Cod_Postal
FROM [gd_esquema].[Maestra]
WHERE Publ_Empresa_Cuit IS NOT NULL
GROUP BY
	Publ_Empresa_Cuit,
	Publ_Empresa_Mail,
	Publ_Empresa_Dom_Calle,
	Publ_Empresa_Nro_Calle,
	Publ_Empresa_Piso,
	Publ_Empresa_Depto,
	Publ_Empresa_Cod_Postal

PRINT 'TABLA: DatosBasicos'

--

DECLARE @aux int = 1
DECLARE @psw nvarchar(255) = N'688787d8ff144c502c7f5cffaafe2cc588d86079f9de88304c26b0cb99ce91c6'
DECLARE @sqlcmd nvarchar(MAX) = N'INSERT INTO [LOPEZ_Y_CIA].[Usuario] (userName, password, activoUsuario, intentosFallidos, publicacionGratis, idDatosBasicos) VALUES' + CHAR(13)

SET @sqlcmd += N'(''u' + CAST(@aux as nvarchar(3)) + N''', ''' + @psw + N''', 1, 0, 0, ' + CAST(@aux as nvarchar(3)) + N')'

WHILE (@aux < 95)
BEGIN
	SET @aux += 1
	SET @sqlcmd += N',' + CHAR(13) + N'(''u' + CAST(@aux as nvarchar(3)) + N''', ''' + @psw + N''', 1, 0, 0, ' + CAST(@aux as nvarchar(3)) + N')'
END

EXEC sp_executesql @sqlcmd
PRINT 'TABLA: Usuario'

--

INSERT INTO [LOPEZ_Y_CIA].[Cliente] (idUsuario, dni, nombre, apellido, fechaNacimiento, tipoDocumento, perfilActivo)
SELECT
	idUsuario,
	Cli_Dni,
	Cli_Nombre,
	Cli_Apeliido,
	Cli_Fecha_Nac,
	1 AS tipoDocumento,
	1 AS perfilActivo
FROM (
    SELECT
		ROW_NUMBER() OVER (ORDER BY Cli_Dni) AS idUsuario,
		Cli_Dni,
		Cli_Nombre,
		Cli_Apeliido,
		Cli_Fecha_Nac
	FROM [gd_esquema].[Maestra]
	WHERE Cli_Dni IS NOT NULL
	GROUP BY
		Cli_Dni,
		Cli_Nombre,
		Cli_Apeliido,
		Cli_Fecha_Nac
) T1

PRINT 'TABLA: Cliente'

--

INSERT INTO [LOPEZ_Y_CIA].[Empresa] (idUsuario, cuit, razonSocial, fechaCreacion, perfilActivo)
SELECT
	idUsuario,
	Publ_Empresa_Cuit,
	Publ_Empresa_Razon_Social,
	Publ_Empresa_Fecha_Creacion,
	1 AS perfilActivo
FROM (
    SELECT
		(ROW_NUMBER() OVER (ORDER BY Publ_Empresa_Cuit)) + 28 AS idUsuario,
		Publ_Empresa_Cuit,
		Publ_Empresa_Razon_Social,
		Publ_Empresa_Fecha_Creacion
	FROM [gd_esquema].[Maestra]
	WHERE Publ_Empresa_Cuit IS NOT NULL
	GROUP BY
		Publ_Empresa_Cuit,
		Publ_Empresa_Razon_Social,
		Publ_Empresa_Fecha_Creacion
) T1

PRINT 'TABLA: Empresa'

--

INSERT INTO [LOPEZ_Y_CIA].[EstadoPublicacion] (nombre, nombreCorto) VALUES
	('Borrador', NULL),
	('Activa', NULL),
	('Pausada', NULL),
	('Finalizada', NULL),
	('Inicial', 'init')

PRINT 'TABLA: EstadoPublicacion'

--

INSERT INTO [LOPEZ_Y_CIA].[workflowEstados] (idEstadoInicial, idEstadoFinal, activo) VALUES
	(5,1,1),
	(5,2,1),
	(1,1,1),
	(1,2,1),
	(2,2,1),
	(2,3,1),
	(2,4,1),
	(3,3,1),
	(3,2,1)

PRINT 'TABLA: workflowEstados'

--

INSERT INTO [LOPEZ_Y_CIA].[Visibilidad] (nombreVisibilidad, costo, porcentaje)
SELECT
	Publicacion_Visibilidad_Desc,
	Publicacion_Visibilidad_Precio,
	Publicacion_Visibilidad_Porcentaje
FROM [gd_esquema].[Maestra]
GROUP BY
	Publicacion_Visibilidad_Cod,
	Publicacion_Visibilidad_Desc,
	Publicacion_Visibilidad_Precio,
	Publicacion_Visibilidad_Porcentaje
ORDER BY Publicacion_Visibilidad_Cod ASC

PRINT 'TABLA: Visibilidad'

--

INSERT INTO [LOPEZ_Y_CIA].[Publicacion] (codigoPublicacion, idEstadoPublicacion, idVisibilidad, descripcion, fechaCreacion, fechaVencimiento, stock, idUsuario)
SELECT
	T1.Publicacion_Cod,
	1 AS idEstadoPublicacion,
	T3.idVisibilidad,
	T1.Publicacion_Descripcion,
	T1.Publicacion_Fecha,
	T1.Publicacion_Fecha_Venc,
	T1.Publicacion_Stock,
	T2.idUsuario
FROM 
	(SELECT
		Publ_Empresa_Cuit,
		Publicacion_Cod,
		Publicacion_Visibilidad_Cod,
		Publicacion_Descripcion,
		Publicacion_Fecha,
		Publicacion_Fecha_Venc,
		Publicacion_Stock
	FROM [gd_esquema].[Maestra]
	WHERE Publicacion_Cod IS NOT NULL
	GROUP BY
		Publicacion_Cod,
		Publicacion_Visibilidad_Cod,
		Publicacion_Descripcion,
		Publicacion_Fecha,
		Publicacion_Fecha_Venc,
		Publicacion_Stock,
		Publ_Empresa_Cuit) T1
INNER JOIN [LOPEZ_Y_CIA].[Empresa] AS T2 ON T1.Publ_Empresa_Cuit = T2.cuit
INNER JOIN [LOPEZ_Y_CIA].[Visibilidad] AS T3 ON T3.codigoVisibilidad = T1.Publicacion_Visibilidad_Cod
UNION
SELECT
	T1.Publicacion_Cod,
	1 AS idEstadoPublicacion,
	T3.idVisibilidad,
	T1.Publicacion_Descripcion,
	T1.Publicacion_Fecha,
	T1.Publicacion_Fecha_Venc,
	T1.Publicacion_Stock,
	T2.idUsuario
FROM 
	(SELECT
		Publ_Cli_Dni,
		Publicacion_Cod,
		Publicacion_Visibilidad_Cod,
		Publicacion_Descripcion,
		Publicacion_Fecha,
		Publicacion_Fecha_Venc,
		Publicacion_Stock
	FROM [gd_esquema].[Maestra]
	WHERE Publicacion_Cod IS NOT NULL
	GROUP BY
		Publicacion_Cod,
		Publicacion_Visibilidad_Cod,
		Publicacion_Descripcion,
		Publicacion_Fecha,
		Publicacion_Fecha_Venc,
		Publicacion_Stock,
		Publ_Cli_Dni) T1
INNER JOIN [LOPEZ_Y_CIA].[Cliente] AS T2 ON T1.Publ_Cli_Dni = T2.dni
INNER JOIN [LOPEZ_Y_CIA].[Visibilidad] AS T3 ON T3.codigoVisibilidad = T1.Publicacion_Visibilidad_Cod
ORDER BY 1 ASC

PRINT 'TABLA: Publicacion'

--

INSERT INTO [LOPEZ_Y_CIA].[Rubro] (descripcion)
SELECT Publicacion_Rubro_Descripcion 
FROM [gd_esquema].[Maestra]
WHERE Publicacion_Rubro_Descripcion IS NOT NULL
GROUP BY Publicacion_Rubro_Descripcion
ORDER BY 1 ASC

PRINT 'TABLA: Rubro'

--

INSERT INTO [LOPEZ_Y_CIA].[Calificacion] (cantEstrellas)
SELECT Calificacion_Cant_Estrellas 
FROM [gd_esquema].[Maestra]
WHERE Calificacion_Codigo IS NOT NULL
ORDER BY Calificacion_Codigo ASC

PRINT 'TABLA: Calificacion'

--

INSERT INTO [LOPEZ_Y_CIA].[Rol] (nombre, activo) VALUES
	('Cliente', 1),
	('Empresa', 1),
	('Admin', 1)

PRINT 'TABLA: Rol'

--

INSERT INTO [LOPEZ_Y_CIA].[PublicacionNormal] (idPublicacion, precioPorUnidad)
SELECT
	B.idPublicacion,
	A.Publicacion_Precio
FROM [gd_esquema].[Maestra] AS A
INNER JOIN [LOPEZ_Y_CIA].[Publicacion] AS B ON A.Publicacion_Cod = B.codigoPublicacion
WHERE A.Publicacion_Tipo LIKE 'C%'
GROUP BY
	B.idPublicacion,
	A.Publicacion_Precio
ORDER BY 1

PRINT 'TABLA: PublicacionNormal'

--

INSERT INTO [LOPEZ_Y_CIA].[PublicacionSubasta] (valorInicialVenta, idPublicacion, valorActual)
SELECT
	A.Publicacion_Precio,
	B.idPublicacion,
	A.Publicacion_Precio + MAX(A.Oferta_Monto) [actual]
FROM [gd_esquema].[Maestra] AS A
INNER JOIN [LOPEZ_Y_CIA].Publicacion AS B ON A.Publicacion_Cod = B.codigoPublicacion
WHERE A.Publicacion_Tipo LIKE 'S%'
GROUP BY B.idPublicacion, A.Publicacion_Precio
ORDER BY 2

PRINT 'TABLA: PublicacionSubasta'

--

INSERT INTO [LOPEZ_Y_CIA].[OfertaSubasta] (idPublicacion, idUsuario, monto, fecha, adjudicada)
SELECT
	B.idPublicacion,
	C.idUsuario,
	A.Oferta_Monto,
	A.Oferta_Fecha,
	CASE 
		WHEN A.Oferta_Monto + A.Publicacion_Precio = D.valorActual 
		THEN 1
		ELSE 0
    END AS adjudicada
FROM [gd_esquema].[Maestra] AS A
INNER JOIN [LOPEZ_Y_CIA].[Publicacion] AS B ON A.Publicacion_Cod = B.codigoPublicacion
INNER JOIN [LOPEZ_Y_CIA].[Cliente] AS C ON A.Cli_Dni = C.dni
INNER JOIN [LOPEZ_Y_CIA].[PublicacionSubasta] AS D ON B.idPublicacion = D.idPublicacion
WHERE Publicacion_Tipo LIKE 'S%' AND Oferta_Fecha IS NOT NULL
GROUP BY
	B.idPublicacion,
	C.idUsuario,
	A.Oferta_Monto,
	A.Oferta_Fecha,
	A.Publicacion_Precio,
	D.valorActual
ORDER BY B.idPublicacion ASC, A.Oferta_Monto ASC

PRINT 'TABLA: OfertaSubasta'

--

INSERT INTO [LOPEZ_Y_CIA].[Factura] (idPublicacion, fecha, montoTotal, formaPagoDesc)
SELECT
	B.idPublicacion,
	A.Factura_Fecha,
	A.Factura_Total,
	A.Forma_Pago_Desc
FROM [gd_esquema].[Maestra] AS A
INNER JOIN [LOPEZ_Y_CIA].[Publicacion] AS B ON A.Publicacion_Cod = B.codigoPublicacion
WHERE A.Factura_Nro IS NOT NULL
GROUP BY
	B.idPublicacion,
	A.Factura_Nro,
	A.Factura_Fecha,
	A.Factura_Total,
	A.Forma_Pago_Desc
ORDER BY A.Factura_Nro

PRINT 'TABLA: Factura'

--

INSERT INTO [LOPEZ_Y_CIA].[ItemFactura] (idFactura, cantidad, monto)
SELECT
	B.idFactura,
	A.Item_Factura_Cantidad,
	A.Item_Factura_Monto
FROM [gd_esquema].[Maestra] AS A
INNER JOIN [LOPEZ_Y_CIA].[Factura] AS B ON A.Factura_Nro = B.nroFactura
ORDER BY 1

PRINT 'TABLA: ItemFactura'

--

INSERT INTO [LOPEZ_Y_CIA].[RolUsuario] (idRol, idUsuario, activo)
SELECT
	1 [rol],
	A.idUsuario,
	1 [activo]
FROM [LOPEZ_Y_CIA].[Usuario] AS A
INNER JOIN [LOPEZ_Y_CIA].[Cliente] AS B ON A.idUsuario = B.idUsuario
UNION
SELECT
	2 [rol],
	A.idUsuario,
	1 [activo]
FROM [LOPEZ_Y_CIA].[Usuario] AS A
INNER JOIN [LOPEZ_Y_CIA].[Empresa] AS B ON A.idUsuario = B.idUsuario

PRINT 'TABLA: RolUsuario'

--

INSERT INTO [LOPEZ_Y_CIA].[RubroPublicacion] (idPublicacion, idRubro)
SELECT
	B.idPublicacion,
	C.idRubro
FROM [gd_esquema].[Maestra] AS A
INNER JOIN [LOPEZ_Y_CIA].[Publicacion] AS B ON B.codigoPublicacion = A.Publicacion_Cod
INNER JOIN [LOPEZ_Y_CIA].[Rubro] AS C ON C.descripcion = A.Publicacion_Rubro_Descripcion
GROUP BY
	B.idPublicacion,
	C.idRubro
ORDER BY 1

PRINT 'TABLA: RubroPublicacion'

--

INSERT INTO [LOPEZ_Y_CIA].[CompraUsuario] (idPublicacion, idUsuario, idCalificacion, fecha, compraCantidad)
SELECT
	B.idPublicacion,
	D.idUsuario,
	E.idCalificacion,
	A.Compra_Fecha,
	A.Compra_Cantidad
FROM [gd_esquema].[Maestra] AS A
INNER JOIN [LOPEZ_Y_CIA].[Publicacion] AS B ON A.Publicacion_Cod = B.codigoPublicacion
INNER JOIN [LOPEZ_Y_CIA].[Cliente] AS D ON D.dni = A.Cli_Dni
INNER JOIN [LOPEZ_Y_CIA].[Calificacion] AS E ON E.codigo = A.Calificacion_Codigo
WHERE Compra_Cantidad IS NOT NULL
ORDER BY 1

PRINT 'TABLA: CompraUsuario'
PRINT CHAR(13) + '--------------------------------'

GO

/** TRANSACCIONES **/

BEGIN TRAN;
MERGE [LOPEZ_Y_CIA].[Usuario] AS T1
USING (
	SELECT
		B.idUsuario [id],
		SUM(A.Calificacion_Cant_Estrellas) [estrellas],
		COUNT(A.Compra_Cantidad) [ventas]
	FROM [gd_esquema].[Maestra] as A
	INNER JOIN [LOPEZ_Y_CIA].[Cliente] AS B ON A.Publ_Cli_Dni = B.dni
	WHERE A.Calificacion_Cant_Estrellas IS NOT NULL AND A.Publ_Cli_Dni IS NOT NULL
	GROUP BY B.idUsuario
	UNION
	SELECT
		B.idUsuario [id],
		SUM(A.Calificacion_Cant_Estrellas) [estrellas],
		COUNT(A.Compra_Cantidad) [ventas]
	FROM [gd_esquema].[Maestra] as A
	INNER JOIN [LOPEZ_Y_CIA].[Empresa] AS B ON A.Publ_Empresa_Cuit = B.cuit
	WHERE A.Calificacion_Cant_Estrellas IS NOT NULL AND A.Publ_Empresa_Cuit IS NOT NULL
	GROUP BY B.idUsuario
) T2
ON (T1.idUsuario = T2.id) 
WHEN MATCHED THEN UPDATE SET
	T1.cantidadEstrellas = T2.estrellas,
	T1.cantidadVentas = T2.ventas;
COMMIT TRAN;

PRINT 'UPDATE A TABLA: Usuario'

--

BEGIN TRAN;
MERGE [LOPEZ_Y_CIA].[Cliente] AS T1
USING (
	SELECT
		idUsuario,
		COUNT(idUsuario) [compras]
	FROM [LOPEZ_Y_CIA].[CompraUsuario]
	GROUP BY idUsuario
) T2
ON (T1.idUsuario = T2.idUsuario) 
WHEN MATCHED THEN UPDATE SET
	T1.comprasEfectuadas = T2.compras,
	T1.comprasCalificadas = T2.compras;
COMMIT TRAN;

PRINT 'UPDATE A TABLA: Cliente'

--

/* Seteando el codigo autoincremental desde el ultimo valor ingresado */
BEGIN TRAN;
CREATE SEQUENCE [LOPEZ_Y_CIA].[secuenciaPubli] START WITH 71079
ALTER TABLE [LOPEZ_Y_CIA].[Publicacion] ADD CONSTRAINT [Secuencia_Publicacion]
DEFAULT (NEXT VALUE FOR [LOPEZ_Y_CIA].[secuenciaPubli]) FOR [codigoPublicacion]
COMMIT TRAN;

GO

/** VISTAS Y OTROS **/

INSERT INTO [LOPEZ_Y_CIA].[Usuario] (userName, password, activoUsuario)
VALUES ('admin', '8c6976e5b5410415bde908bd4dee15dfb167a9c873fc4bb8a81f6f2ab448a918', 1)

Go
CREATE VIEW [LOPEZ_Y_CIA].[BusquedaDePublicacion] AS
	SELECT ROW_NUMBER() OVER(ORDER BY idPublicacion DESC) AS rowID, * 
	FROM (
		SELECT
			pub.idPublicacion,
			'Subasta' AS tipoPublicacion,
			pub.codigoPublicacion,
			pub.descripcion,
			pub.fechaCreacion,
			pub.fechaVencimiento,
			pubSub.valorActual AS precio,
			rubro.descripcion AS desRubro,
			visb.costo,
			pub.idUsuario
		FROM [LOPEZ_Y_CIA].[PublicacionSubasta] AS pubSub
		JOIN [LOPEZ_Y_CIA].[Publicacion] AS pub ON pubSub.idPublicacion = pub.idPublicacion
		JOIN [LOPEZ_Y_CIA].[Visibilidad] AS visb ON pub.idVisibilidad = visb.idVisibilidad 
		JOIN [LOPEZ_Y_CIA].[RubroPublicacion] AS rubropublic ON rubropublic.idPublicacion = pub.idPublicacion
		JOIN [LOPEZ_Y_CIA].[Rubro] AS rubro ON rubropublic.idRubro = rubro.idRubro
		WHERE pub.idEstadoPublicacion = 2
		UNION ALL
		SELECT
			pub.idPublicacion,
			'Compra Directa' AS tipoPublicacion,
			pub.codigoPublicacion,
			pub.descripcion,
			pub.fechaCreacion,
			pub.fechaVencimiento,
			pubNormal.precioPorUnidad AS precio,
			rubro.descripcion AS desRubro,
			visb.costo,
			pub.idUsuario
		FROM [LOPEZ_Y_CIA].[PublicacionNormal] AS pubNormal
		JOIN [LOPEZ_Y_CIA].[Publicacion] AS pub ON pubNormal.idPublicacion = pub.idPublicacion
		JOIN [LOPEZ_Y_CIA].[Visibilidad] AS visb ON pub.idVisibilidad = visb.idVisibilidad
		JOIN [LOPEZ_Y_CIA].[RubroPublicacion] AS rubropublic ON rubropublic.idPublicacion = pub.idPublicacion
		JOIN [LOPEZ_Y_CIA].[Rubro] AS rubro ON rubropublic.idRubro = rubro.idRubro
		WHERE pub.idEstadoPublicacion = 2
	) x

GO
/** FIN DEL SCRIPT **/
