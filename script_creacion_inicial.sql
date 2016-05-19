USE [GD1C2016]

GO
CREATE SCHEMA [LOPEZ_Y_CIA] AUTHORIZATION [gd]

GO
CREATE TABLE [LOPEZ_Y_CIA].[Calificacion](
	[idCalificacion] [int] IDENTITY(1,1) NOT NULL,
	[codigo] [numeric](18, 0) NULL,
	[cantEstrellas] [numeric](18, 0) NULL,
	[descripcion] [nvarchar](255) NULL,
	CONSTRAINT [PK_Calificacion] PRIMARY KEY CLUSTERED([idCalificacion] ASC) ON [PRIMARY]
) ON [PRIMARY]

GO
CREATE TABLE [LOPEZ_Y_CIA].[Cliente](
	[dni] [numeric](18, 0) NOT NULL,
	[tipoDocumento] [int] NOT NULL,
	[nombre] [nvarchar](255) NULL,
	[apellido] [nvarchar](255) NULL,
	[fechaNacimiento] [date] NULL,
	[perfilActivo] [bit] NOT NULL,
	[idUsuario] [int] NOT NULL,
	[fechaCreacion] [date] NULL,
	[comprasEfectuadas] [int] NULL,
	[comprasCalificadas] [int] NULL,
	CONSTRAINT [PK_Cliente_1] PRIMARY KEY CLUSTERED([idUsuario] ASC) ON [PRIMARY],
	CONSTRAINT [UK_Documento] UNIQUE ([dni],[tipoDocumento])
) ON [PRIMARY]

GO
CREATE TABLE [LOPEZ_Y_CIA].[ComisionesParametrizables](
	[idComisionesParametrizables] [int] IDENTITY(1,1) NOT NULL,
	[nombreCorto] [nchar](10) NOT NULL,
	[nombre] [nvarchar](250) NOT NULL,
	[porcentaje] [numeric](18, 2) NOT NULL,
	CONSTRAINT [pk_idComisionesParametrizables] PRIMARY KEY CLUSTERED([idComisionesParametrizables] ASC) ON [PRIMARY]
) ON [PRIMARY]

GO
CREATE TABLE [LOPEZ_Y_CIA].[CompraUsuario](
	[idCompraUsuario] [int] IDENTITY(1,1) NOT NULL,
	[idFactura] [int] NOT NULL UNIQUE,
	[idUsuario] [int] NOT NULL,
	[idCalificacion] [int] NULL,
	CONSTRAINT [PK_CompraUsuario] PRIMARY KEY CLUSTERED([idCompraUsuario] ASC) ON [PRIMARY]
) ON [PRIMARY]

GO
CREATE TABLE [LOPEZ_Y_CIA].[DatosBasicos](
	[idDatosBasicos] [int] IDENTITY(1,1) NOT NULL,
	[email] [nvarchar](255) NULL,
	[domCalle] [nvarchar](255) NULL,
	[nroCalle] [nvarchar](255) NULL,
	[piso] [numeric](18, 0) NULL,
	[depto] [numeric](18, 0) NULL,
	[codPostal] [nvarchar](50) NULL,
	[localidad] [nvarchar](50) NULL,
	[ciudad] [nvarchar](50) NULL,
	CONSTRAINT [PK_DatosBasicos] PRIMARY KEY CLUSTERED([idDatosBasicos] ASC) ON [PRIMARY]
) ON [PRIMARY]

GO
CREATE TABLE [LOPEZ_Y_CIA].[Empresa](
	[razonSocial] [nvarchar](50) NOT NULL UNIQUE,
	[cuit] [nvarchar](50) NOT NULL UNIQUE,
	[fechaCreacion] [date] NULL,
	[perfilActivo] [int] NOT NULL,
	[idUsuario] [int] NOT NULL,
	[nombreContacto] [nvarchar](50) NULL,
	CONSTRAINT [PK_Empresa_1] PRIMARY KEY CLUSTERED([idUsuario] ASC) ON [PRIMARY]
) ON [PRIMARY]

GO
CREATE TABLE [LOPEZ_Y_CIA].[EstadoPublicacion](
	[idEstadoPublicacion] [int] IDENTITY(1,1) NOT NULL,
	[nombre] [nvarchar](255) NULL,
	[nombreCorto] [nchar](10) NULL,
	CONSTRAINT [PK_EstadoPublicacion] PRIMARY KEY CLUSTERED([idEstadoPublicacion] ASC) ON [PRIMARY]
) ON [PRIMARY]

GO
CREATE TABLE [LOPEZ_Y_CIA].[Factura](
	[idFactura] [int] IDENTITY(1,1) NOT NULL,
	[idPublicacion] [int] NOT NULL,
	[nroFactura] [numeric](18, 0) NULL UNIQUE,
	[fecha] [datetime] NULL,
	[montoTotal] [numeric](18, 2) NULL,
	[formaPagoDesc] [nvarchar](255) NULL,
	CONSTRAINT [PK_Factura] PRIMARY KEY CLUSTERED([idFactura] ASC) ON [PRIMARY]
) ON [PRIMARY]

GO
CREATE TABLE [LOPEZ_Y_CIA].[Funciones](
	[idFunciones] [int] IDENTITY(1,1) NOT NULL,
	[nombre] [char](10) NOT NULL,
	[descripcion] [char](100) NULL,
	[activo] [bit] NOT NULL,
	CONSTRAINT [PK_Funciones] PRIMARY KEY CLUSTERED([idFunciones] ASC) ON [PRIMARY]
) ON [PRIMARY]

GO
CREATE TABLE [LOPEZ_Y_CIA].[ItemFactura](
	[idItemFactura] [int] IDENTITY(1,1) NOT NULL,
	[idFactura] [int] NOT NULL,
	[cantidad] [numeric](18, 0) NULL,
	[monto] [numeric](18, 2) NULL,
	CONSTRAINT [PK_ItemFactura] PRIMARY KEY CLUSTERED([idItemFactura] ASC) ON [PRIMARY]
) ON [PRIMARY]

GO
CREATE TABLE [LOPEZ_Y_CIA].[OfertaSubasta](
	[idOfertaSubasta] [int] IDENTITY(1,1) NOT NULL,
	[idPublicacion] [int] NOT NULL,
	[idUsuario] [int] NOT NULL,
	[monto] [numeric](18, 2) NULL,
	[fecha] [datetime] NOT NULL,
	[adjudicada] [bit] NOT NULL,
	CONSTRAINT [PK_OfertaSubasta] PRIMARY KEY CLUSTERED([idOfertaSubasta] ASC) ON [PRIMARY]
) ON [PRIMARY]

GO
CREATE TABLE [LOPEZ_Y_CIA].[Preguntas](
	[idPreguntas] [int] IDENTITY(1,1) NOT NULL,
	[idUsuario] [int] NOT NULL,
	[descripcion] [text] NULL,
	[idPublicacion] [int] NOT NULL,
	CONSTRAINT [PK_Preguntas] PRIMARY KEY CLUSTERED([idPreguntas] ASC) ON [PRIMARY]
) ON [PRIMARY]

GO
CREATE TABLE [LOPEZ_Y_CIA].[Publicacion](
	[idPublicacion] [int] IDENTITY(1,1) NOT NULL,
	[idEstadoPublicacion] [int] NOT NULL,
	[idVisibilidad] [int] NOT NULL,
	[codigoPublicacion] [numeric](18, 0) NULL,
	[descripcion] [nvarchar](255) NULL,
	[fechaCreacion] [date] NULL,
	[fechaVencimiento] [date] NULL,
	[stock] [numeric](18, 0) NULL,
	[preguntasSN] [bit] NULL,
	[envioSN] [bit] NULL,
	[idUsuario] [int] NOT NULL,
	CONSTRAINT [PK_Publicacion] PRIMARY KEY CLUSTERED([idPublicacion] ASC) ON [PRIMARY]
) ON [PRIMARY]

GO
CREATE TABLE [LOPEZ_Y_CIA].[PublicacionNormal](
	[idPublicacion] [int] NOT NULL,
	[precioPorUnidad] [numeric](18, 2) NOT NULL,
	CONSTRAINT [PK_PublicacionNormal_1] PRIMARY KEY CLUSTERED([idPublicacion] ASC) ON [PRIMARY]
) ON [PRIMARY]

GO
CREATE TABLE [LOPEZ_Y_CIA].[PublicacionSubasta](
	[valorInicialVenta] [numeric](18, 2) NOT NULL,
	[idPublicacion] [int] NOT NULL,
	[valorActual] [numeric](18, 2) NULL,
	CONSTRAINT [PK_PublicacionSubasta_1] PRIMARY KEY CLUSTERED([idPublicacion] ASC) ON [PRIMARY]
) ON [PRIMARY]

GO
CREATE TABLE [LOPEZ_Y_CIA].[Rol](
	[idRol] [int] IDENTITY(1,1) NOT NULL,
	[nombre] [char](10) NOT NULL,
	[activo] [bit] NOT NULL,
	CONSTRAINT [PK_Rol] PRIMARY KEY CLUSTERED([idRol] ASC) ON [PRIMARY]
) ON [PRIMARY]

GO
CREATE TABLE [LOPEZ_Y_CIA].[RolFunciones](
	[idRol] [int] NOT NULL,
	[idFunciones] [int] NOT NULL
) ON [PRIMARY]

GO
CREATE TABLE [LOPEZ_Y_CIA].[RolUsuario](
	[idRol] [int] NOT NULL,
	[idUsuario] [int] NOT NULL,
	[activo] [bit] NULL
) ON [PRIMARY]

GO
CREATE TABLE [LOPEZ_Y_CIA].[Rubro](
	[idRubro] [int] IDENTITY(1,1) NOT NULL,
	[codigo] [nchar](5) NULL UNIQUE,
	[nombreCorto] [nvarchar](8) NULL,
	[descripcion] [nvarchar](255) NULL,
	CONSTRAINT [PK_Rubro] PRIMARY KEY CLUSTERED([idRubro] ASC) ON [PRIMARY]
) ON [PRIMARY]

GO
CREATE TABLE [LOPEZ_Y_CIA].[RubroPublicacion](
	[idPublicacion] [int] NOT NULL,
	[idRubro] [int] NOT NULL
) ON [PRIMARY]

GO
CREATE TABLE [LOPEZ_Y_CIA].[Usuario](
	[idUsuario] [int] IDENTITY(1,1) NOT NULL,
	[userName] [nvarchar](50) NOT NULL UNIQUE,
	[password] [nvarchar](257) NOT NULL,
	[activoUsuario] [bit] NOT NULL,
	[intentosFallidos] [numeric](3, 0) NOT NULL,
	[publicacionGratis] [bit] NULL,
	[cantidadEstrellas] [int] NULL,
	[cantidadVentas] [int] NULL,
	[idDatosBasicos] [int] NULL,
	CONSTRAINT [PK_Usuario_1] PRIMARY KEY CLUSTERED([idUsuario] ASC) ON [PRIMARY]
) ON [PRIMARY]

GO
CREATE TABLE [LOPEZ_Y_CIA].[Visibilidad](
	[idVisibilidad] [int] IDENTITY(1,1) NOT NULL,
	[costo] [numeric](18, 0) NULL,
	[nombreVisibilidad] [nvarchar](50) NULL,
	CONSTRAINT [PK_Visibilidad] PRIMARY KEY CLUSTERED([idVisibilidad] ASC) ON [PRIMARY]
) ON [PRIMARY]

GO
CREATE TABLE [LOPEZ_Y_CIA].[workflowEstados](
	[idWorkflowEstados] [int] IDENTITY(1,1) NOT NULL,
	[idEstadoInicial] [int] NOT NULL,
	[idEstadoFinal] [int] NOT NULL,
	[activo] [bit] NOT NULL
) ON [PRIMARY]

GO
ALTER TABLE [LOPEZ_Y_CIA].[Cliente] WITH CHECK ADD
	CONSTRAINT [FK_Cliente_Usuario] FOREIGN KEY([idUsuario]) REFERENCES [LOPEZ_Y_CIA].[Usuario] ([idUsuario])
GO
ALTER TABLE [LOPEZ_Y_CIA].[Cliente] CHECK CONSTRAINT [FK_Cliente_Usuario]

GO
ALTER TABLE [LOPEZ_Y_CIA].[CompraUsuario] WITH CHECK ADD
	CONSTRAINT [FK_CompraUsuario_Calificacion] FOREIGN KEY([idCalificacion]) REFERENCES [LOPEZ_Y_CIA].[Calificacion] ([idCalificacion])
GO
ALTER TABLE [LOPEZ_Y_CIA].[CompraUsuario] CHECK CONSTRAINT [FK_CompraUsuario_Calificacion]

GO
ALTER TABLE [LOPEZ_Y_CIA].[CompraUsuario] WITH CHECK ADD
	CONSTRAINT [FK_CompraUsuario_Factura] FOREIGN KEY([idFactura]) REFERENCES [LOPEZ_Y_CIA].[Factura] ([idFactura])
GO
ALTER TABLE [LOPEZ_Y_CIA].[CompraUsuario] CHECK CONSTRAINT [FK_CompraUsuario_Factura]

GO
ALTER TABLE [LOPEZ_Y_CIA].[CompraUsuario] WITH CHECK ADD
	CONSTRAINT [FK_CompraUsuario_Usuario] FOREIGN KEY([idUsuario]) REFERENCES [LOPEZ_Y_CIA].[Usuario] ([idUsuario])
GO
ALTER TABLE [LOPEZ_Y_CIA].[CompraUsuario] CHECK CONSTRAINT [FK_CompraUsuario_Usuario]

GO
ALTER TABLE [LOPEZ_Y_CIA].[Empresa] WITH CHECK ADD
	CONSTRAINT [FK_Empresa_Usuario] FOREIGN KEY([idUsuario]) REFERENCES [LOPEZ_Y_CIA].[Usuario] ([idUsuario])
GO
ALTER TABLE [LOPEZ_Y_CIA].[Empresa] CHECK CONSTRAINT [FK_Empresa_Usuario]

GO
ALTER TABLE [LOPEZ_Y_CIA].[Factura] WITH CHECK ADD
	CONSTRAINT [FK_Factura_Publicacion] FOREIGN KEY([idPublicacion]) REFERENCES [LOPEZ_Y_CIA].[Publicacion] ([idPublicacion])
GO
ALTER TABLE [LOPEZ_Y_CIA].[Factura] CHECK CONSTRAINT [FK_Factura_Publicacion]

GO
ALTER TABLE [LOPEZ_Y_CIA].[ItemFactura] WITH CHECK ADD
	CONSTRAINT [FK_ItemFactura_Factura] FOREIGN KEY([idFactura]) REFERENCES [LOPEZ_Y_CIA].[Factura] ([idFactura])
GO
ALTER TABLE [LOPEZ_Y_CIA].[ItemFactura] CHECK CONSTRAINT [FK_ItemFactura_Factura]

GO
ALTER TABLE [LOPEZ_Y_CIA].[OfertaSubasta] WITH CHECK ADD
	CONSTRAINT [FK_OfertaSubasta_PublicacionSubasta] FOREIGN KEY([idPublicacion]) REFERENCES [LOPEZ_Y_CIA].[PublicacionSubasta] ([idPublicacion])
GO
ALTER TABLE [LOPEZ_Y_CIA].[OfertaSubasta] CHECK CONSTRAINT [FK_OfertaSubasta_PublicacionSubasta]

GO
ALTER TABLE [LOPEZ_Y_CIA].[OfertaSubasta] WITH CHECK ADD
	CONSTRAINT [FK_OfertaSubasta_Usuario] FOREIGN KEY([idUsuario]) REFERENCES [LOPEZ_Y_CIA].[Usuario] ([idUsuario])
GO
ALTER TABLE [LOPEZ_Y_CIA].[OfertaSubasta] CHECK CONSTRAINT [FK_OfertaSubasta_Usuario]

GO
ALTER TABLE [LOPEZ_Y_CIA].[Preguntas] WITH CHECK ADD
	CONSTRAINT [FK_Preguntas_Publicacion] FOREIGN KEY([idPublicacion]) REFERENCES [LOPEZ_Y_CIA].[Publicacion] ([idPublicacion])
GO
ALTER TABLE [LOPEZ_Y_CIA].[Preguntas] CHECK CONSTRAINT [FK_Preguntas_Publicacion]

GO
ALTER TABLE [LOPEZ_Y_CIA].[Preguntas] WITH CHECK ADD
	CONSTRAINT [FK_Preguntas_Usuario] FOREIGN KEY([idUsuario]) REFERENCES [LOPEZ_Y_CIA].[Usuario] ([idUsuario])
GO
ALTER TABLE [LOPEZ_Y_CIA].[Preguntas] CHECK CONSTRAINT [FK_Preguntas_Usuario]

GO
ALTER TABLE [LOPEZ_Y_CIA].[Publicacion] WITH CHECK ADD
	CONSTRAINT [FK_Publicacion_EstadoPublicacion] FOREIGN KEY([idEstadoPublicacion]) REFERENCES [LOPEZ_Y_CIA].[EstadoPublicacion] ([idEstadoPublicacion])
GO
ALTER TABLE [LOPEZ_Y_CIA].[Publicacion] CHECK CONSTRAINT [FK_Publicacion_EstadoPublicacion]

GO
ALTER TABLE [LOPEZ_Y_CIA].[Publicacion] WITH CHECK ADD
	CONSTRAINT [FK_Publicacion_Usuario] FOREIGN KEY([idUsuario]) REFERENCES [LOPEZ_Y_CIA].[Usuario] ([idUsuario])
GO
ALTER TABLE [LOPEZ_Y_CIA].[Publicacion] CHECK CONSTRAINT [FK_Publicacion_Usuario]

GO
ALTER TABLE [LOPEZ_Y_CIA].[Publicacion] WITH CHECK ADD
	CONSTRAINT [FK_Publicacion_Visibilidad] FOREIGN KEY([idVisibilidad]) REFERENCES [LOPEZ_Y_CIA].[Visibilidad] ([idVisibilidad])
GO
ALTER TABLE [LOPEZ_Y_CIA].[Publicacion] CHECK CONSTRAINT [FK_Publicacion_Visibilidad]

GO
ALTER TABLE [LOPEZ_Y_CIA].[PublicacionNormal] WITH CHECK ADD
	CONSTRAINT [FK_PublicacionNormal_Publicacion] FOREIGN KEY([idPublicacion]) REFERENCES [LOPEZ_Y_CIA].[Publicacion] ([idPublicacion])
GO
ALTER TABLE [LOPEZ_Y_CIA].[PublicacionNormal] CHECK CONSTRAINT [FK_PublicacionNormal_Publicacion]

GO
ALTER TABLE [LOPEZ_Y_CIA].[PublicacionSubasta] WITH CHECK ADD
	CONSTRAINT [FK_PublicacionSubasta_Publicacion] FOREIGN KEY([idPublicacion]) REFERENCES [LOPEZ_Y_CIA].[Publicacion] ([idPublicacion])
GO
ALTER TABLE [LOPEZ_Y_CIA].[PublicacionSubasta] CHECK CONSTRAINT [FK_PublicacionSubasta_Publicacion]

GO
ALTER TABLE [LOPEZ_Y_CIA].[RolFunciones] WITH CHECK ADD
	CONSTRAINT [FK_RolFunciones_Funciones] FOREIGN KEY([idFunciones]) REFERENCES [LOPEZ_Y_CIA].[Funciones] ([idFunciones])
GO
ALTER TABLE [LOPEZ_Y_CIA].[RolFunciones] CHECK CONSTRAINT [FK_RolFunciones_Funciones]

GO
ALTER TABLE [LOPEZ_Y_CIA].[RolFunciones] WITH CHECK ADD
	CONSTRAINT [FK_RolFunciones_Rol] FOREIGN KEY([idRol]) REFERENCES [LOPEZ_Y_CIA].[Rol] ([idRol])
GO
ALTER TABLE [LOPEZ_Y_CIA].[RolFunciones] CHECK CONSTRAINT [FK_RolFunciones_Rol]

GO
ALTER TABLE [LOPEZ_Y_CIA].[RolUsuario] WITH CHECK ADD
	CONSTRAINT [FK_RolUsuario_Rol] FOREIGN KEY([idRol]) REFERENCES [LOPEZ_Y_CIA].[Rol] ([idRol])
GO
ALTER TABLE [LOPEZ_Y_CIA].[RolUsuario] CHECK CONSTRAINT [FK_RolUsuario_Rol]

GO
ALTER TABLE [LOPEZ_Y_CIA].[RolUsuario] WITH CHECK ADD
	CONSTRAINT [FK_RolUsuario_Usuario] FOREIGN KEY([idUsuario]) REFERENCES [LOPEZ_Y_CIA].[Usuario] ([idUsuario])
GO
ALTER TABLE [LOPEZ_Y_CIA].[RolUsuario] CHECK CONSTRAINT [FK_RolUsuario_Usuario]

GO
ALTER TABLE [LOPEZ_Y_CIA].[RubroPublicacion] WITH CHECK ADD
	CONSTRAINT [FK_RubroPublicacion_Publicacion] FOREIGN KEY([idPublicacion]) REFERENCES [LOPEZ_Y_CIA].[Publicacion] ([idPublicacion])
GO
ALTER TABLE [LOPEZ_Y_CIA].[RubroPublicacion] CHECK CONSTRAINT [FK_RubroPublicacion_Publicacion]

GO
ALTER TABLE [LOPEZ_Y_CIA].[RubroPublicacion] WITH CHECK ADD
	CONSTRAINT [FK_RubroPublicacion_Rubro] FOREIGN KEY([idRubro]) REFERENCES [LOPEZ_Y_CIA].[Rubro] ([idRubro])
GO
ALTER TABLE [LOPEZ_Y_CIA].[RubroPublicacion] CHECK CONSTRAINT [FK_RubroPublicacion_Rubro]

GO
ALTER TABLE [LOPEZ_Y_CIA].[Usuario] WITH CHECK ADD
	CONSTRAINT [FK_Usuario_DatosBasicos] FOREIGN KEY([idDatosBasicos]) REFERENCES [LOPEZ_Y_CIA].[DatosBasicos] ([idDatosBasicos])
GO
ALTER TABLE [LOPEZ_Y_CIA].[Usuario] CHECK CONSTRAINT [FK_Usuario_DatosBasicos]

GO
ALTER TABLE [LOPEZ_Y_CIA].[workflowEstados] WITH CHECK ADD
	CONSTRAINT [FK_workflowEstados_EstadoPublicacion_final] FOREIGN KEY([idEstadoFinal]) REFERENCES [LOPEZ_Y_CIA].[EstadoPublicacion] ([idEstadoPublicacion])
GO
ALTER TABLE [LOPEZ_Y_CIA].[workflowEstados] CHECK CONSTRAINT [FK_workflowEstados_EstadoPublicacion_final]

GO
ALTER TABLE [LOPEZ_Y_CIA].[workflowEstados] WITH CHECK ADD
	CONSTRAINT [FK_workflowEstados_EstadoPublicacion_inicial] FOREIGN KEY([idEstadoInicial]) REFERENCES [LOPEZ_Y_CIA].[EstadoPublicacion] ([idEstadoPublicacion])
GO
ALTER TABLE [LOPEZ_Y_CIA].[workflowEstados] CHECK CONSTRAINT [FK_workflowEstados_EstadoPublicacion_inicial]
