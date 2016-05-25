select T2.Cli_Nombre, count (T2.Publicacion_Cod)
from (
	select Publicacion_Cod, max(oferta_monto) as 'max'
	from gd_esquema.Maestra
	where Publicacion_Tipo='Subasta'
	group by Publicacion_Cod
	) T1

inner join gd_esquema.Maestra as T2 on T1.Publicacion_Cod=T2.Publicacion_Cod and T2.Oferta_Monto =T1.max
where T2.Cli_Nombre is not null
group by T2.Cli_Nombre
order by 1

