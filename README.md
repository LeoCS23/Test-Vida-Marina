# Test-Vida-Marina
SCRIPTS BASE DE DATOS SQL EXPRESS

CREATE TABLE [dbo].[DETALLE_FACTURAS] (
    [id]             INT          IDENTITY (1, 1) NOT NULL,
    [facturaId]      INT          NOT NULL,
    [producto]       VARCHAR (50) NOT NULL,
    [cantidad]       INT          NOT NULL,
    [precioUnitario] DECIMAL (18) NOT NULL,
    PRIMARY KEY CLUSTERED ([id] ASC),
    FOREIGN KEY ([facturaId]) REFERENCES [dbo].[FACTURAS] ([id])
);

CREATE TABLE [dbo].[FACTURAS] (
    [id]      INT          IDENTITY (1, 1) NOT NULL,
    [cliente] VARCHAR (50) NOT NULL,
    [fecha]   DATETIME     NOT NULL,
    [total]   DECIMAL (18) NOT NULL,
    [activo]  BIT          NULL,
    PRIMARY KEY CLUSTERED ([id] ASC)
);

**Instalación**
 -los archivos no fueron subidos en despliegue, por tanto están funcionando en local
 -El motor de Base de datos fue SQL EXPRESS
