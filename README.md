# Notas de la versión 1.2

Se agregaron las secuencias para algunos campos autoincrementales <br />
Se corrigio compraUsuario como fue solicitado <br />
Se termino de cargar el 100% de la Tabla Maestra <br />
Se encriptaron las contraseñas para todos los usuarios con SHA-256 <br />
Se hicieron transacciones para la incorporacion de algunos datos que quedaron afuera

-----------------------

### Temas que faltan tratar:

 - Definir que fecha de creacion le pongo a los clientes ya importados
 - Cargar todas las funciones que va a tener la aplicacion y setear las funciones por rol
 - Ver si definimos codigos para los Rubros
 - Realizar un Trigger para insertar publicaciones nuevas (codigo autoincremental)
 - Determinar si implementamos un JOB para que el motor de base de datos actualize todos los dias aquellas publicaciones ya vencidas y las pase a finalizadas o dejamos que de eso se encargue la aplicacion.

