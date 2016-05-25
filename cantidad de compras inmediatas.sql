select Cli_Nombre , sum(compra_cantidad) as Cantidad
from gd_esquema.Maestra
where Compra_Cantidad is not null
group by Cli_Nombre 
order by 1