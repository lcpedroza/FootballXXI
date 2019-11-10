use FootballXXI;

insert into Generos (Nombre) values('Masculino'),('Femenino'), ('Otro');

insert into Roles (Nombre, Codigo) values ('Administ', 'ADMIN'), ('Cajero', 'CAJ'), ('Vendedor', 'VEN');

insert into TiposDeDocumento (NombreLargo, NombreCorto) values ('C�dula de Ciudadan�a', 'C.C.'), 
('Tarjeta de Identidad', 'T.I.'), ('Pasaporte', 'PP.'), ('C�dula Extranger�a', 'C.E.');

insert into Personas (PrimerNombre, SegundoNombre, PrimerApellido, SegundoApellido, TiposDeDocumentoId,  
	NumeroDocumento, GeneroId) 
values ('Luis', 'Carlos', 'Pedroza', 'Pineda', 1, '1079935561',1);

insert into Empleados ( Email, Celular, Clave, NombreUsuario, Profesion, FechaNac, Dirreccion, RolId) 
values ('luisk301374@gmail.com', '3004255615', 'lmuairsy001993', 'luisk', 'Ingeniero de Sistemas', '1993-05-17', 
'Cra 53A #128B - 14', 2);

insert into Tallas(NombreLargo, NombreCorto) 
values ('Large', 'L'), ('Medio', 'M'), ('Small', 'S'), ('10', '10'), ('6', '6'), ('4', '4');

insert into Ligas(Ligas) values ('Champions League'), ('Copa Am�rica'), ('Eurocopa'), ('Liga �guila'), 
	('Liga Brasile�a');

insert into Camisetas(NombreEquipo, LigaId)
values ('Atlanta', 1), ('Atl�tico', 1), ('Barcelona', 1), ('Bayer Munchen', 1), ('Benfica', 1)
, ('Chelsea', 1), ('Dormund', 1), ('Galatasaray', 1), ('Internazionale', 1), ('Juventus', 1)
, ('Leverkusen', 1), ('Liverpool', 1), ('Lyon', 1), ('Manchester City', 1), ('Napoli', 1)
, ('Paris Saint German', 1), ('Real Madrid', 1), ('Tottenham', 1), ('Valencia', 1), ('Zenit', 1)
, ('Brasil', 2), ('Bolivia', 2), ('Venezuela', 2), ('Per�', 2), ('Argentina', 2), ('Colombia', 2)
, ('Paraguay', 2), ('Qatar', 2), ('Urugay', 2), ('Ecuador', 2), ('Jap�n', 2), ('Chile', 2)
, ('Francia', 3), ('Espa�a', 3),('Alemania', 3), ('Inglaterra', 3),('Portugal', 3), ('B�lgica', 3)
, ('Italia', 3), ('Rusia', 3), ('Suiza', 3), ('Austria', 3), ('Croacia', 3), ('Ucrania', 3)
, ('R Checa', 3), ('Suecia', 3), ('Polonia', 3), ('Rumania', 3), ('Eslovaquia', 3), ('Hungr�a', 3)
, ('Turqu�a', 3), ('R Irlanda', 3), ('Islandia', 3), ('Gales', 3), ('Albania', 3), ('Irlanda del Norte', 3)
, ('Liones', 4), ('Chic�', 4), ('A Bucaramanga', 4), ('A Nacional', 4), ('Cali', 4), ('Am�rica', 4)
, ('Medell�n', 4), ('Jaguares', 4), ('Equidad', 4), ('Tolima', 4), ('D Pasto', 4), ('Patriotas', 4)
, ('Once caldas', 4), ('Alianza Petrolera', 4), ('Millonarios', 4), ('Junior', 4), ('�guilas Doradas', 4), ('A Hu�la', 4), ('Santaf�', 4), ('Uni�n Magdalena', 4)
, ('Chapecoense', 5), ('Corinthians', 5), ('Curitiba', 5), ('Cruzeiro', 5), ('Bah�a', 5), ('Flamengo', 5), ('Fluminense', 5), ('Palmeiras', 5)
, ('Santos', 5), ('Sao Paulo', 5), ('Sport Recife', 5), ('Am�rica Mineiro', 5), ('Cear�', 5), ('Atl�tico Go', 5), ('Icasa', 5), ('Vit�ria', 5);


select * from Roles;
select * from Generos;
select * from TiposDeDocumento;
select * from Personas;
select * from Empleados;
select * from Ligas;
select * from Tallas;
select * from TallasCamiseta;

insert into TallasCamiseta(TallaId, CamisetaId, GeneroId, Cantidad)
select t.Id, c.Id, g.Id, 10
from Tallas as t,
Camisetas as c,
Generos as g
where g.Id != 3;