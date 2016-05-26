USE [GD1C2016]

GO
/** CREACION DEL ESQUEMA Y LAS TABLAS PRINCIPALES **/ 

CREATE SCHEMA [LOPEZ_Y_CIA] AUTHORIZATION [gd]

CREATE TABLE [LOPEZ_Y_CIA].[Calificacion](
	[idCalificacion] [int] IDENTITY(1,1) NOT NULL,
	[codigo] [numeric](18, 0) NULL, /**/
	[cantEstrellas] [numeric](18, 0) NOT NULL,
	[descripcion] [nvarchar](255) NULL,
	CONSTRAINT [PK_Calificacion] PRIMARY KEY CLUSTERED([idCalificacion] ASC) ON [PRIMARY]
) ON [PRIMARY]

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

CREATE TABLE [LOPEZ_Y_CIA].[ComisionesParametrizables](
	[idComisionesParametrizables] [int] IDENTITY(1,1) NOT NULL,
	[nombreCorto] [nchar](10) NOT NULL,
	[nombre] [nvarchar](250) NOT NULL,
	[porcentaje] [numeric](18, 2) NOT NULL,
	CONSTRAINT [pk_idComisionesParametrizables] PRIMARY KEY CLUSTERED([idComisionesParametrizables] ASC) ON [PRIMARY]
) ON [PRIMARY]

CREATE TABLE [LOPEZ_Y_CIA].[CompraUsuario](
	[idCompraUsuario] [int] IDENTITY(1,1) NOT NULL,
	[idFactura] [int] NOT NULL UNIQUE,
	[idUsuario] [int] NOT NULL,
	[idCalificacion] [int] NULL,
	CONSTRAINT [PK_CompraUsuario] PRIMARY KEY CLUSTERED([idCompraUsuario] ASC) ON [PRIMARY]
) ON [PRIMARY]

CREATE TABLE [LOPEZ_Y_CIA].[DatosBasicos](
	[idDatosBasicos] [int] IDENTITY(1,1) NOT NULL,
	[email] [nvarchar](255) NOT NULL,
	[domCalle] [nvarchar](255) NULL,
	[nroCalle] [numeric](18, 0) NULL,
	[piso] [numeric](18, 0) NULL,
	[depto] [nvarchar](50) NULL,
	[codPostal] [nvarchar](50) NULL,
	[localidad] [nvarchar](50) NULL,
	[ciudad] [nvarchar](50) NULL,
	CONSTRAINT [PK_DatosBasicos] PRIMARY KEY CLUSTERED([idDatosBasicos] ASC) ON [PRIMARY]
) ON [PRIMARY]

CREATE TABLE [LOPEZ_Y_CIA].[Empresa](
	[razonSocial] [nvarchar](50) NOT NULL UNIQUE,
	[cuit] [nvarchar](50) NOT NULL UNIQUE,
	[fechaCreacion] [date] NULL,
	[perfilActivo] [int] NOT NULL,
	[idUsuario] [int] NOT NULL,
	[nombreContacto] [nvarchar](50) NULL,
	CONSTRAINT [PK_Empresa_1] PRIMARY KEY CLUSTERED([idUsuario] ASC) ON [PRIMARY]
) ON [PRIMARY]

CREATE TABLE [LOPEZ_Y_CIA].[EstadoPublicacion](
	[idEstadoPublicacion] [int] IDENTITY(1,1) NOT NULL,
	[nombre] [nvarchar](255) NOT NULL,
	[nombreCorto] [nchar](10) NULL, /**/
	CONSTRAINT [PK_EstadoPublicacion] PRIMARY KEY CLUSTERED([idEstadoPublicacion] ASC) ON [PRIMARY]
) ON [PRIMARY]

CREATE TABLE [LOPEZ_Y_CIA].[Factura](
	[idFactura] [int] IDENTITY(1,1) NOT NULL,
	[idPublicacion] [int] NOT NULL,
	[nroFactura] [numeric](18, 0) NOT NULL UNIQUE,
	[fecha] [datetime] NULL,
	[montoTotal] [numeric](18, 2) NOT NULL,
	[formaPagoDesc] [nvarchar](255) NULL,
	CONSTRAINT [PK_Factura] PRIMARY KEY CLUSTERED([idFactura] ASC) ON [PRIMARY]
) ON [PRIMARY]

CREATE TABLE [LOPEZ_Y_CIA].[Funciones]( /**/
	[idFunciones] [int] IDENTITY(1,1) NOT NULL,
	[nombre] [char](10) NOT NULL,
	[descripcion] [char](100) NULL,
	[activo] [bit] NOT NULL,
	CONSTRAINT [PK_Funciones] PRIMARY KEY CLUSTERED([idFunciones] ASC) ON [PRIMARY]
) ON [PRIMARY]

CREATE TABLE [LOPEZ_Y_CIA].[ItemFactura](
	[idItemFactura] [int] IDENTITY(1,1) NOT NULL,
	[idFactura] [int] NOT NULL,
	[cantidad] [numeric](18, 0) NOT NULL,
	[monto] [numeric](18, 2) NOT NULL,
	CONSTRAINT [PK_ItemFactura] PRIMARY KEY CLUSTERED([idItemFactura] ASC) ON [PRIMARY]
) ON [PRIMARY]

CREATE TABLE [LOPEZ_Y_CIA].[OfertaSubasta](
	[idOfertaSubasta] [int] IDENTITY(1,1) NOT NULL,
	[idPublicacion] [int] NOT NULL,
	[idUsuario] [int] NOT NULL,
	[monto] [numeric](18, 2) NOT NULL,
	[fecha] [datetime] NOT NULL,
	[adjudicada] [bit] NOT NULL,
	CONSTRAINT [PK_OfertaSubasta] PRIMARY KEY CLUSTERED([idOfertaSubasta] ASC) ON [PRIMARY]
) ON [PRIMARY]

CREATE TABLE [LOPEZ_Y_CIA].[Preguntas](
	[idPreguntas] [int] IDENTITY(1,1) NOT NULL,
	[idUsuario] [int] NOT NULL,
	[descripcion] [text] NULL,
	[idPublicacion] [int] NOT NULL,
	CONSTRAINT [PK_Preguntas] PRIMARY KEY CLUSTERED([idPreguntas] ASC) ON [PRIMARY]
) ON [PRIMARY]

CREATE TABLE [LOPEZ_Y_CIA].[Publicacion](
	[idPublicacion] [int] IDENTITY(1,1) NOT NULL,
	[idEstadoPublicacion] [int] NOT NULL,
	[idVisibilidad] [int] NOT NULL,
	[codigoPublicacion] [numeric](18, 0) NULL, /**/
	[descripcion] [nvarchar](255) NULL,
	[fechaCreacion] [date] NOT NULL,
	[fechaVencimiento] [date] NULL,
	[stock] [numeric](18, 0) NULL,
	[preguntasSN] [bit] NULL,
	[envioSN] [bit] NULL,
	[idUsuario] [int] NOT NULL,
	CONSTRAINT [PK_Publicacion] PRIMARY KEY CLUSTERED([idPublicacion] ASC) ON [PRIMARY]
) ON [PRIMARY]

CREATE TABLE [LOPEZ_Y_CIA].[PublicacionNormal](
	[idPublicacion] [int] NOT NULL,
	[precioPorUnidad] [numeric](18, 2) NOT NULL,
	CONSTRAINT [PK_PublicacionNormal_1] PRIMARY KEY CLUSTERED([idPublicacion] ASC) ON [PRIMARY]
) ON [PRIMARY]

CREATE TABLE [LOPEZ_Y_CIA].[PublicacionSubasta](
	[valorInicialVenta] [numeric](18, 2) NOT NULL,
	[idPublicacion] [int] NOT NULL,
	[valorActual] [numeric](18, 2) NOT NULL,
	CONSTRAINT [PK_PublicacionSubasta_1] PRIMARY KEY CLUSTERED([idPublicacion] ASC) ON [PRIMARY]
) ON [PRIMARY]

CREATE TABLE [LOPEZ_Y_CIA].[Rol](
	[idRol] [int] IDENTITY(1,1) NOT NULL,
	[nombre] [char](10) NOT NULL,
	[activo] [bit] NOT NULL,
	CONSTRAINT [PK_Rol] PRIMARY KEY CLUSTERED([idRol] ASC) ON [PRIMARY]
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
	[codigo] [nchar](5) NULL UNIQUE, /**/
	[nombreCorto] [nvarchar](8) NULL, /**/
	[descripcion] [nvarchar](255) NULL,
	CONSTRAINT [PK_Rubro] PRIMARY KEY CLUSTERED([idRubro] ASC) ON [PRIMARY]
) ON [PRIMARY]

CREATE TABLE [LOPEZ_Y_CIA].[RubroPublicacion](
	[idPublicacion] [int] NOT NULL,
	[idRubro] [int] NOT NULL
) ON [PRIMARY]

CREATE TABLE [LOPEZ_Y_CIA].[Usuario](
	[idUsuario] [int] IDENTITY(1,1) NOT NULL,
	[userName] [nvarchar](50) NOT NULL UNIQUE,
	[password] [nvarchar](257) NOT NULL,
	[activoUsuario] [bit] NOT NULL,
	[intentosFallidos] [numeric](3, 0) NOT NULL,
	[publicacionGratis] [bit] NULL,
	[cantidadEstrellas] [int] NULL,
	[cantidadVentas] [int] NULL,
	[idDatosBasicos] [int] NOT NULL,
	CONSTRAINT [PK_Usuario_1] PRIMARY KEY CLUSTERED([idUsuario] ASC) ON [PRIMARY]
) ON [PRIMARY]

CREATE TABLE [LOPEZ_Y_CIA].[Visibilidad](
	[idVisibilidad] [int] IDENTITY(1,1) NOT NULL,
	[codigoVisibilidad] [numeric](18,0) NOT NULL, /**/
	[nombreVisibilidad] [nvarchar](50) NULL,
	[costo] [numeric](18, 2) NOT NULL,
	[porcentaje] [numeric](18, 2) NOT NULL,
	CONSTRAINT [PK_Visibilidad] PRIMARY KEY CLUSTERED([idVisibilidad] ASC) ON [PRIMARY]
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
	CONSTRAINT [FK_CompraUsuario_Factura] FOREIGN KEY([idFactura]) REFERENCES [LOPEZ_Y_CIA].[Factura] ([idFactura])
ALTER TABLE [LOPEZ_Y_CIA].[CompraUsuario] CHECK CONSTRAINT [FK_CompraUsuario_Factura]

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

insert into LOPEZ_Y_CIA.DatosBasicos(email, domCalle, nroCalle, piso, depto, codPostal)
select Cli_Mail, Cli_Dom_Calle, Cli_Nro_Calle, Cli_Piso, Cli_Depto, Cli_Cod_Postal
from gd_esquema.Maestra
where Cli_Dni is not null
group by Cli_Dni, Cli_Mail, Cli_Dom_Calle, Cli_Nro_Calle, Cli_Piso, Cli_Depto, Cli_Cod_Postal

insert into LOPEZ_Y_CIA.DatosBasicos(email, domCalle, nroCalle, piso, depto, codPostal)
select Publ_Empresa_Mail, Publ_Empresa_Dom_Calle, Publ_Empresa_Nro_Calle, Publ_Empresa_Piso, Publ_Empresa_Depto, Publ_Empresa_Cod_Postal
from gd_esquema.Maestra
where Publ_Empresa_Cuit is not null
group by Publ_Empresa_Cuit, Publ_Empresa_Mail, Publ_Empresa_Dom_Calle, Publ_Empresa_Nro_Calle, Publ_Empresa_Piso, Publ_Empresa_Depto, Publ_Empresa_Cod_Postal

insert into LOPEZ_Y_CIA.Usuario(userName, password, activoUsuario, intentosFallidos, idDatosBasicos)
values ('u1', 'asd', 1, 0, 1)
insert into LOPEZ_Y_CIA.Usuario(userName, password, activoUsuario, intentosFallidos, idDatosBasicos)
values ('u2', 'asd', 1, 0, 2)
insert into LOPEZ_Y_CIA.Usuario(userName, password, activoUsuario, intentosFallidos, idDatosBasicos)
values ('u3', 'asd', 1, 0, 3)
insert into LOPEZ_Y_CIA.Usuario(userName, password, activoUsuario, intentosFallidos, idDatosBasicos)
values ('u4', 'asd', 1, 0, 4)
insert into LOPEZ_Y_CIA.Usuario(userName, password, activoUsuario, intentosFallidos, idDatosBasicos)
values ('u5', 'asd', 1, 0, 5)
insert into LOPEZ_Y_CIA.Usuario(userName, password, activoUsuario, intentosFallidos, idDatosBasicos)
values ('u6', 'asd', 1, 0, 6)
insert into LOPEZ_Y_CIA.Usuario(userName, password, activoUsuario, intentosFallidos, idDatosBasicos)
values ('u7', 'asd', 1, 0, 7)
insert into LOPEZ_Y_CIA.Usuario(userName, password, activoUsuario, intentosFallidos, idDatosBasicos)
values ('u8', 'asd', 1, 0, 8)
insert into LOPEZ_Y_CIA.Usuario(userName, password, activoUsuario, intentosFallidos, idDatosBasicos)
values ('u9', 'asd', 1, 0, 9)
insert into LOPEZ_Y_CIA.Usuario(userName, password, activoUsuario, intentosFallidos, idDatosBasicos)
values ('u10', 'asd', 1, 0, 10)
insert into LOPEZ_Y_CIA.Usuario(userName, password, activoUsuario, intentosFallidos, idDatosBasicos)
values ('u11', 'asd', 1, 0, 11)
insert into LOPEZ_Y_CIA.Usuario(userName, password, activoUsuario, intentosFallidos, idDatosBasicos)
values ('u12', 'asd', 1, 0, 12)
insert into LOPEZ_Y_CIA.Usuario(userName, password, activoUsuario, intentosFallidos, idDatosBasicos)
values ('u13', 'asd', 1, 0, 13)
insert into LOPEZ_Y_CIA.Usuario(userName, password, activoUsuario, intentosFallidos, idDatosBasicos)
values ('u14', 'asd', 1, 0, 14)
insert into LOPEZ_Y_CIA.Usuario(userName, password, activoUsuario, intentosFallidos, idDatosBasicos)
values ('u15', 'asd', 1, 0, 15)
insert into LOPEZ_Y_CIA.Usuario(userName, password, activoUsuario, intentosFallidos, idDatosBasicos)
values ('u16', 'asd', 1, 0, 16)
insert into LOPEZ_Y_CIA.Usuario(userName, password, activoUsuario, intentosFallidos, idDatosBasicos)
values ('u17', 'asd', 1, 0, 17)
insert into LOPEZ_Y_CIA.Usuario(userName, password, activoUsuario, intentosFallidos, idDatosBasicos)
values ('u18', 'asd', 1, 0, 18)
insert into LOPEZ_Y_CIA.Usuario(userName, password, activoUsuario, intentosFallidos, idDatosBasicos)
values ('u19', 'asd', 1, 0, 19)
insert into LOPEZ_Y_CIA.Usuario(userName, password, activoUsuario, intentosFallidos, idDatosBasicos)
values ('u20', 'asd', 1, 0, 20)
insert into LOPEZ_Y_CIA.Usuario(userName, password, activoUsuario, intentosFallidos, idDatosBasicos)
values ('u21', 'asd', 1, 0, 21)
insert into LOPEZ_Y_CIA.Usuario(userName, password, activoUsuario, intentosFallidos, idDatosBasicos)
values ('u22', 'asd', 1, 0, 22)
insert into LOPEZ_Y_CIA.Usuario(userName, password, activoUsuario, intentosFallidos, idDatosBasicos)
values ('u23', 'asd', 1, 0, 23)
insert into LOPEZ_Y_CIA.Usuario(userName, password, activoUsuario, intentosFallidos, idDatosBasicos)
values ('u24', 'asd', 1, 0, 24)
insert into LOPEZ_Y_CIA.Usuario(userName, password, activoUsuario, intentosFallidos, idDatosBasicos)
values ('u25', 'asd', 1, 0, 25)
insert into LOPEZ_Y_CIA.Usuario(userName, password, activoUsuario, intentosFallidos, idDatosBasicos)
values ('u26', 'asd', 1, 0, 26)
insert into LOPEZ_Y_CIA.Usuario(userName, password, activoUsuario, intentosFallidos, idDatosBasicos)
values ('u27', 'asd', 1, 0, 27)
insert into LOPEZ_Y_CIA.Usuario(userName, password, activoUsuario, intentosFallidos, idDatosBasicos)
values ('u28', 'asd', 1, 0, 28)
insert into LOPEZ_Y_CIA.Usuario(userName, password, activoUsuario, intentosFallidos, idDatosBasicos)
values ('u29', 'asd', 1, 0, 29)
insert into LOPEZ_Y_CIA.Usuario(userName, password, activoUsuario, intentosFallidos, idDatosBasicos)
values ('u30', 'asd', 1, 0, 30)
insert into LOPEZ_Y_CIA.Usuario(userName, password, activoUsuario, intentosFallidos, idDatosBasicos)
values ('u31', 'asd', 1, 0, 31)
insert into LOPEZ_Y_CIA.Usuario(userName, password, activoUsuario, intentosFallidos, idDatosBasicos)
values ('u32', 'asd', 1, 0, 32)
insert into LOPEZ_Y_CIA.Usuario(userName, password, activoUsuario, intentosFallidos, idDatosBasicos)
values ('u33', 'asd', 1, 0, 33)
insert into LOPEZ_Y_CIA.Usuario(userName, password, activoUsuario, intentosFallidos, idDatosBasicos)
values ('u34', 'asd', 1, 0, 34)
insert into LOPEZ_Y_CIA.Usuario(userName, password, activoUsuario, intentosFallidos, idDatosBasicos)
values ('u35', 'asd', 1, 0, 35)
insert into LOPEZ_Y_CIA.Usuario(userName, password, activoUsuario, intentosFallidos, idDatosBasicos)
values ('u36', 'asd', 1, 0, 36)
insert into LOPEZ_Y_CIA.Usuario(userName, password, activoUsuario, intentosFallidos, idDatosBasicos)
values ('u37', 'asd', 1, 0, 37)
insert into LOPEZ_Y_CIA.Usuario(userName, password, activoUsuario, intentosFallidos, idDatosBasicos)
values ('u38', 'asd', 1, 0, 38)
insert into LOPEZ_Y_CIA.Usuario(userName, password, activoUsuario, intentosFallidos, idDatosBasicos)
values ('u39', 'asd', 1, 0, 39)
insert into LOPEZ_Y_CIA.Usuario(userName, password, activoUsuario, intentosFallidos, idDatosBasicos)
values ('u40', 'asd', 1, 0, 40)
insert into LOPEZ_Y_CIA.Usuario(userName, password, activoUsuario, intentosFallidos, idDatosBasicos)
values ('u41', 'asd', 1, 0, 41)
insert into LOPEZ_Y_CIA.Usuario(userName, password, activoUsuario, intentosFallidos, idDatosBasicos)
values ('u42', 'asd', 1, 0, 42)
insert into LOPEZ_Y_CIA.Usuario(userName, password, activoUsuario, intentosFallidos, idDatosBasicos)
values ('u43', 'asd', 1, 0, 43)
insert into LOPEZ_Y_CIA.Usuario(userName, password, activoUsuario, intentosFallidos, idDatosBasicos)
values ('u44', 'asd', 1, 0, 44)
insert into LOPEZ_Y_CIA.Usuario(userName, password, activoUsuario, intentosFallidos, idDatosBasicos)
values ('u45', 'asd', 1, 0, 45)
insert into LOPEZ_Y_CIA.Usuario(userName, password, activoUsuario, intentosFallidos, idDatosBasicos)
values ('u46', 'asd', 1, 0, 46)
insert into LOPEZ_Y_CIA.Usuario(userName, password, activoUsuario, intentosFallidos, idDatosBasicos)
values ('u47', 'asd', 1, 0, 47)
insert into LOPEZ_Y_CIA.Usuario(userName, password, activoUsuario, intentosFallidos, idDatosBasicos)
values ('u48', 'asd', 1, 0, 48)
insert into LOPEZ_Y_CIA.Usuario(userName, password, activoUsuario, intentosFallidos, idDatosBasicos)
values ('u49', 'asd', 1, 0, 49)
insert into LOPEZ_Y_CIA.Usuario(userName, password, activoUsuario, intentosFallidos, idDatosBasicos)
values ('u50', 'asd', 1, 0, 50)
insert into LOPEZ_Y_CIA.Usuario(userName, password, activoUsuario, intentosFallidos, idDatosBasicos)
values ('u51', 'asd', 1, 0, 51)
insert into LOPEZ_Y_CIA.Usuario(userName, password, activoUsuario, intentosFallidos, idDatosBasicos)
values ('u52', 'asd', 1, 0, 52)
insert into LOPEZ_Y_CIA.Usuario(userName, password, activoUsuario, intentosFallidos, idDatosBasicos)
values ('u53', 'asd', 1, 0, 53)
insert into LOPEZ_Y_CIA.Usuario(userName, password, activoUsuario, intentosFallidos, idDatosBasicos)
values ('u54', 'asd', 1, 0, 54)
insert into LOPEZ_Y_CIA.Usuario(userName, password, activoUsuario, intentosFallidos, idDatosBasicos)
values ('u55', 'asd', 1, 0, 55)
insert into LOPEZ_Y_CIA.Usuario(userName, password, activoUsuario, intentosFallidos, idDatosBasicos)
values ('u56', 'asd', 1, 0, 56)
insert into LOPEZ_Y_CIA.Usuario(userName, password, activoUsuario, intentosFallidos, idDatosBasicos)
values ('u57', 'asd', 1, 0, 57)
insert into LOPEZ_Y_CIA.Usuario(userName, password, activoUsuario, intentosFallidos, idDatosBasicos)
values ('u58', 'asd', 1, 0, 58)
insert into LOPEZ_Y_CIA.Usuario(userName, password, activoUsuario, intentosFallidos, idDatosBasicos)
values ('u59', 'asd', 1, 0, 59)
insert into LOPEZ_Y_CIA.Usuario(userName, password, activoUsuario, intentosFallidos, idDatosBasicos)
values ('u60', 'asd', 1, 0, 60)
insert into LOPEZ_Y_CIA.Usuario(userName, password, activoUsuario, intentosFallidos, idDatosBasicos)
values ('u61', 'asd', 1, 0, 61)
insert into LOPEZ_Y_CIA.Usuario(userName, password, activoUsuario, intentosFallidos, idDatosBasicos)
values ('u62', 'asd', 1, 0, 62)
insert into LOPEZ_Y_CIA.Usuario(userName, password, activoUsuario, intentosFallidos, idDatosBasicos)
values ('u63', 'asd', 1, 0, 63)
insert into LOPEZ_Y_CIA.Usuario(userName, password, activoUsuario, intentosFallidos, idDatosBasicos)
values ('u64', 'asd', 1, 0, 64)
insert into LOPEZ_Y_CIA.Usuario(userName, password, activoUsuario, intentosFallidos, idDatosBasicos)
values ('u65', 'asd', 1, 0, 65)
insert into LOPEZ_Y_CIA.Usuario(userName, password, activoUsuario, intentosFallidos, idDatosBasicos)
values ('u66', 'asd', 1, 0, 66)
insert into LOPEZ_Y_CIA.Usuario(userName, password, activoUsuario, intentosFallidos, idDatosBasicos)
values ('u67', 'asd', 1, 0, 67)
insert into LOPEZ_Y_CIA.Usuario(userName, password, activoUsuario, intentosFallidos, idDatosBasicos)
values ('u68', 'asd', 1, 0, 68)
insert into LOPEZ_Y_CIA.Usuario(userName, password, activoUsuario, intentosFallidos, idDatosBasicos)
values ('u69', 'asd', 1, 0, 69)
insert into LOPEZ_Y_CIA.Usuario(userName, password, activoUsuario, intentosFallidos, idDatosBasicos)
values ('u70', 'asd', 1, 0, 70)
insert into LOPEZ_Y_CIA.Usuario(userName, password, activoUsuario, intentosFallidos, idDatosBasicos)
values ('u71', 'asd', 1, 0, 71)
insert into LOPEZ_Y_CIA.Usuario(userName, password, activoUsuario, intentosFallidos, idDatosBasicos)
values ('u72', 'asd', 1, 0, 72)
insert into LOPEZ_Y_CIA.Usuario(userName, password, activoUsuario, intentosFallidos, idDatosBasicos)
values ('u73', 'asd', 1, 0, 73)
insert into LOPEZ_Y_CIA.Usuario(userName, password, activoUsuario, intentosFallidos, idDatosBasicos)
values ('u74', 'asd', 1, 0, 74)
insert into LOPEZ_Y_CIA.Usuario(userName, password, activoUsuario, intentosFallidos, idDatosBasicos)
values ('u75', 'asd', 1, 0, 75)
insert into LOPEZ_Y_CIA.Usuario(userName, password, activoUsuario, intentosFallidos, idDatosBasicos)
values ('u76', 'asd', 1, 0, 76)
insert into LOPEZ_Y_CIA.Usuario(userName, password, activoUsuario, intentosFallidos, idDatosBasicos)
values ('u77', 'asd', 1, 0, 77)
insert into LOPEZ_Y_CIA.Usuario(userName, password, activoUsuario, intentosFallidos, idDatosBasicos)
values ('u78', 'asd', 1, 0, 78)
insert into LOPEZ_Y_CIA.Usuario(userName, password, activoUsuario, intentosFallidos, idDatosBasicos)
values ('u79', 'asd', 1, 0, 79)
insert into LOPEZ_Y_CIA.Usuario(userName, password, activoUsuario, intentosFallidos, idDatosBasicos)
values ('u80', 'asd', 1, 0, 80)
insert into LOPEZ_Y_CIA.Usuario(userName, password, activoUsuario, intentosFallidos, idDatosBasicos)
values ('u81', 'asd', 1, 0, 81)
insert into LOPEZ_Y_CIA.Usuario(userName, password, activoUsuario, intentosFallidos, idDatosBasicos)
values ('u82', 'asd', 1, 0, 82)
insert into LOPEZ_Y_CIA.Usuario(userName, password, activoUsuario, intentosFallidos, idDatosBasicos)
values ('u83', 'asd', 1, 0, 83)
insert into LOPEZ_Y_CIA.Usuario(userName, password, activoUsuario, intentosFallidos, idDatosBasicos)
values ('u84', 'asd', 1, 0, 84)
insert into LOPEZ_Y_CIA.Usuario(userName, password, activoUsuario, intentosFallidos, idDatosBasicos)
values ('u85', 'asd', 1, 0, 85)
insert into LOPEZ_Y_CIA.Usuario(userName, password, activoUsuario, intentosFallidos, idDatosBasicos)
values ('u86', 'asd', 1, 0, 86)
insert into LOPEZ_Y_CIA.Usuario(userName, password, activoUsuario, intentosFallidos, idDatosBasicos)
values ('u87', 'asd', 1, 0, 87)
insert into LOPEZ_Y_CIA.Usuario(userName, password, activoUsuario, intentosFallidos, idDatosBasicos)
values ('u88', 'asd', 1, 0, 88)
insert into LOPEZ_Y_CIA.Usuario(userName, password, activoUsuario, intentosFallidos, idDatosBasicos)
values ('u89', 'asd', 1, 0, 89)
insert into LOPEZ_Y_CIA.Usuario(userName, password, activoUsuario, intentosFallidos, idDatosBasicos)
values ('u90', 'asd', 1, 0, 90)
insert into LOPEZ_Y_CIA.Usuario(userName, password, activoUsuario, intentosFallidos, idDatosBasicos)
values ('u91', 'asd', 1, 0, 91)
insert into LOPEZ_Y_CIA.Usuario(userName, password, activoUsuario, intentosFallidos, idDatosBasicos)
values ('u92', 'asd', 1, 0, 92)
insert into LOPEZ_Y_CIA.Usuario(userName, password, activoUsuario, intentosFallidos, idDatosBasicos)
values ('u93', 'asd', 1, 0, 93)
insert into LOPEZ_Y_CIA.Usuario(userName, password, activoUsuario, intentosFallidos, idDatosBasicos)
values ('u94', 'asd', 1, 0, 94)
insert into LOPEZ_Y_CIA.Usuario(userName, password, activoUsuario, intentosFallidos, idDatosBasicos)
values ('u95', 'asd', 1, 0, 95)

insert into LOPEZ_Y_CIA.Cliente(idUsuario, dni, nombre, apellido, fechaNacimiento, tipoDocumento, perfilActivo)
select *, 1 as tipoDocumento, 1 as perfilActivo
from (
    SELECT
		ROW_NUMBER() OVER (ORDER BY Cli_Dni) AS idUsuario,
		Cli_Dni as dni,
		Cli_Nombre,
		Cli_Apeliido,
		Cli_Fecha_Nac
	FROM gd_esquema.Maestra
	where Cli_Dni is not null
	group by Cli_Dni, Cli_Nombre, Cli_Apeliido, Cli_Fecha_Nac
) T1
order by 1 asc

insert into LOPEZ_Y_CIA.Empresa(idUsuario, cuit, razonSocial, fechaCreacion, perfilActivo)
select *, 1 as perfilActivo
from (
    SELECT
		(ROW_NUMBER() OVER (ORDER BY Publ_Empresa_Cuit)) + 28 AS idUsuario,
		Publ_Empresa_Cuit,
		Publ_Empresa_Razon_Social,
		Publ_Empresa_Fecha_Creacion
	FROM gd_esquema.Maestra
	where Publ_Empresa_Cuit is not null
	group by Publ_Empresa_Cuit, Publ_Empresa_Razon_Social, Publ_Empresa_Fecha_Creacion
) T1
order by 1 asc

insert into LOPEZ_Y_CIA.EstadoPublicacion(nombre)
select Publicacion_Estado
from gd_esquema.Maestra
group by Publicacion_Estado

insert into LOPEZ_Y_CIA.Visibilidad(codigoVisibilidad, nombreVisibilidad, costo, porcentaje)
select Publicacion_Visibilidad_Cod, Publicacion_Visibilidad_Desc, Publicacion_Visibilidad_Precio, Publicacion_Visibilidad_Porcentaje
from gd_esquema.Maestra
group by Publicacion_Visibilidad_Cod, Publicacion_Visibilidad_Desc, Publicacion_Visibilidad_Precio, Publicacion_Visibilidad_Porcentaje
order by 1 asc

insert into LOPEZ_Y_CIA.Publicacion(idEstadoPublicacion, idVisibilidad, codigoPublicacion, descripcion, fechaCreacion, fechaVencimiento, stock, idUsuario)
select
	1 as idEstadoPublicacion,
	T3.idVisibilidad,
	T1.Publicacion_Cod,
	T1.Publicacion_Descripcion,
	T1.Publicacion_Fecha,
	T1.Publicacion_Fecha_Venc,
	T1.Publicacion_Stock,
	T2.idUsuario
from 
	(select
		Publ_Empresa_Cuit,
		Publicacion_Cod,
		Publicacion_Visibilidad_Cod,
		Publicacion_Descripcion,
		Publicacion_Fecha,
		Publicacion_Fecha_Venc,
		Publicacion_Stock
	from gd_esquema.Maestra
	where Publicacion_Cod is not null
	group by
		Publicacion_Cod,
		Publicacion_Visibilidad_Cod,
		Publicacion_Descripcion,
		Publicacion_Fecha,
		Publicacion_Fecha_Venc,
		Publicacion_Stock,
		Publ_Empresa_Cuit) T1
inner join LOPEZ_Y_CIA.Empresa as T2 on T1.Publ_Empresa_Cuit = T2.cuit
inner join LOPEZ_Y_CIA.Visibilidad as T3 on T3.codigoVisibilidad = T1.Publicacion_Visibilidad_Cod
order by 3 asc

insert into LOPEZ_Y_CIA.Publicacion(idEstadoPublicacion, idVisibilidad, codigoPublicacion, descripcion, fechaCreacion, fechaVencimiento, stock, idUsuario)
select
	1 as idEstadoPublicacion,
	T3.idVisibilidad,
	T1.Publicacion_Cod,
	T1.Publicacion_Descripcion,
	T1.Publicacion_Fecha,
	T1.Publicacion_Fecha_Venc,
	T1.Publicacion_Stock,
	T2.idUsuario
from 
	(select
		Publ_Cli_Dni,
		Publicacion_Cod,
		Publicacion_Visibilidad_Cod,
		Publicacion_Descripcion,
		Publicacion_Fecha,
		Publicacion_Fecha_Venc,
		Publicacion_Stock
	from gd_esquema.Maestra
	where Publicacion_Cod is not null
	group by
		Publicacion_Cod,
		Publicacion_Visibilidad_Cod,
		Publicacion_Descripcion,
		Publicacion_Fecha,
		Publicacion_Fecha_Venc,
		Publicacion_Stock,
		Publ_Cli_Dni) T1
inner join LOPEZ_Y_CIA.Cliente as T2 on T1.Publ_Cli_Dni = T2.dni
inner join LOPEZ_Y_CIA.Visibilidad as T3 on T3.codigoVisibilidad = T1.Publicacion_Visibilidad_Cod
order by 3 asc

GO
/** FIN DEL SCRIPT **/