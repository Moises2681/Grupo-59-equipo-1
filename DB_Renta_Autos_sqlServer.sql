CREATE TABLE [usuario] (
  [usu_id] int PRIMARY KEY NOT NULL IDENTITY(1, 1),
  [usu_cedula] varchar(10),
  [usu_nombre] varchar(20),
  [usu_apellidos] varchar(20),
  [usu_direccion] varchar(50),
  [usu_telefono] varchar(20),
  [usu_correo] varchar(50)
)
GO

CREATE TABLE [alquiler] (
  [alq_id] int PRIMARY KEY NOT NULL IDENTITY(1, 1),
  [alq_usuario] int,
  [alq_disponible] int,
  [alq_vehiculo] int,
  [alq_codigo] varchar(10),
  [alq_fecha_inicio] varchar(10),
  [alq_fecha_fin] varchar(10),
  [alq_lugar_entrega] varchar(20),
  [alq_lugar_recogida] varchar(20),
  [alq_estadoRecepcionVehiculo] int,
  [alq_forPago] int
)
GO

CREATE TABLE [estadoAlquiler] (
  [estAlq_id] int PRIMARY KEY NOT NULL IDENTITY(1, 1),
  [estAlq_estado] varchar(20)
)
GO

CREATE TABLE [vehiculo] (
  [veh_id] int PRIMARY KEY NOT NULL IDENTITY(1, 1),
  [veh_placa] varchar(20),
  [veh_marca] int,
  [veh_modelo] varchar(20),
  [veh_capacidad] varchar(20),
  [veh_color] varchar(20),
  [veh_tipoCaja] int,
  [veh_tipoCombustible] int,
  [veh_hojaVida] int
)
GO

CREATE TABLE [marca] (
  [mar_id] int PRIMARY KEY NOT NULL IDENTITY(1, 1),
  [mar_marca] varchar(20)
)
GO

CREATE TABLE [tipoCaja] (
  [tipCaj_id] int PRIMARY KEY NOT NULL IDENTITY(1, 1),
  [tipCaj_marca] varchar(20)
)
GO

CREATE TABLE [tipoCombustible] (
  [tipCom_id] int PRIMARY KEY NOT NULL IDENTITY(1, 1),
  [tipCom_combustible] varchar(20)
)
GO

CREATE TABLE [hojaVida] (
  [hojVid_id] int PRIMARY KEY NOT NULL IDENTITY(1, 1),
  [hojVid_nombre] varchar(20),
  [hojVid_fechaTecno] date,
  [hojVid_fechaSoat] date
)
GO

CREATE TABLE [estadoEntrega] (
  [estEnt_id] int PRIMARY KEY NOT NULL IDENTITY(1, 1),
  [estEnt_estadoEntrega] varchar(20)
)
GO

CREATE TABLE [formaPago] (
  [forPag_id] int PRIMARY KEY NOT NULL IDENTITY(1, 1),
  [forPag_nombre] varchar(20)
)
GO

ALTER TABLE [alquiler] ADD FOREIGN KEY ([alq_usuario]) REFERENCES [usuario] ([usu_id])
GO

ALTER TABLE [alquiler] ADD FOREIGN KEY ([alq_disponible]) REFERENCES [estadoAlquiler] ([estAlq_id])
GO

ALTER TABLE [alquiler] ADD FOREIGN KEY ([alq_vehiculo]) REFERENCES [vehiculo] ([veh_id])
GO

ALTER TABLE [vehiculo] ADD FOREIGN KEY ([veh_marca]) REFERENCES [marca] ([mar_id])
GO

ALTER TABLE [vehiculo] ADD FOREIGN KEY ([veh_tipoCaja]) REFERENCES [tipoCaja] ([tipCaj_id])
GO

ALTER TABLE [vehiculo] ADD FOREIGN KEY ([veh_tipoCombustible]) REFERENCES [tipoCombustible] ([tipCom_id])
GO

ALTER TABLE [alquiler] ADD FOREIGN KEY ([alq_estadoRecepcionVehiculo]) REFERENCES [estadoEntrega] ([estEnt_id])
GO

ALTER TABLE [alquiler] ADD FOREIGN KEY ([alq_forPago]) REFERENCES [formaPago] ([forPag_id])
GO

ALTER TABLE [vehiculo] ADD FOREIGN KEY ([veh_hojaVida]) REFERENCES [hojaVida] ([hojVid_id])
GO
