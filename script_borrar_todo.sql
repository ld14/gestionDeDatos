DECLARE @sql NVARCHAR(MAX) = '';

SELECT @sql += N'
ALTER TABLE ' + QUOTENAME(OBJECT_SCHEMA_NAME(parent_object_id))
    + '.' + QUOTENAME(OBJECT_NAME(parent_object_id)) + 
    ' DROP CONSTRAINT ' + QUOTENAME(name) + ';'
FROM sys.foreign_keys;

SET @sql += N'
';

SELECT @sql += N'
DROP TABLE [' + TABLE_SCHEMA + '].['+ TABLE_NAME + ']' + ';'
FROM   INFORMATION_SCHEMA.TABLES
WHERE  TABLE_TYPE = 'BASE TABLE' and TABLE_SCHEMA = 'LOPEZ_Y_CIA';

SET @sql += N'

DROP SEQUENCE [LOPEZ_Y_CIA].[secuenciaCalif];
DROP SEQUENCE [LOPEZ_Y_CIA].[secuenciaVisib];
DROP SEQUENCE [LOPEZ_Y_CIA].[secuenciaFactu];
DROP SEQUENCE [LOPEZ_Y_CIA].[secuenciaPubli];

DROP VIEW [LOPEZ_Y_CIA].[BusquedaDePublicacion];
DROP VIEW [LOPEZ_Y_CIA].[EstadisticaVendedores];
DROP VIEW [LOPEZ_Y_CIA].[EstadisticaCompradores];
DROP VIEW [LOPEZ_Y_CIA].[SubastaCompraDelSistema];
DROP VIEW [LOPEZ_Y_CIA].[getCodigo];
DROP VIEW [LOPEZ_Y_CIA].[getCodigoCalif];
DROP VIEW [LOPEZ_Y_CIA].[estadisticaMaximos];
DROP VIEW [LOPEZ_Y_CIA].[SinCalificar];
DROP VIEW [LOPEZ_Y_CIA].[SoloSubastas];

DROP SCHEMA [LOPEZ_Y_CIA];'

PRINT @sql;
EXEC sp_executesql @sql;
