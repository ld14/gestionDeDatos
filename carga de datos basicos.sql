select Cli_Mail,Cli_Dom_Calle, Cli_Nro_Calle, Cli_Piso, Cli_Depto, Cli_Cod_Postal
from gd_esquema.Maestra
where Cli_Dni is not null
group by Cli_Mail,Cli_Dom_Calle, Cli_Nro_Calle, Cli_Piso, Cli_Depto, Cli_Cod_Postal, Cli_Dni
order by Cli_Dni