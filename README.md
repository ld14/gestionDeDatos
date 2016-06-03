# Notas de la versión 1.0

Ya terminé con el núcleo del script T-SQL, se han migrado el 99% de los datos de la tabla maestra.
Ahora voy a proceder con el refactoring del código.

-----------------------

A continuación dejo los puntos que quedaron fuera del alcanze de la versión 1.0, los cuales deberán tratarse a la brevedad:

Cliente:
 - comprasEfectuadas
 - comprasCalificadas

Usuario:
 - cantidadEstrellas
 - cantidadVentas

Funciones:
 - Cargar todas las funciones

RolFunciones:
 - Cargar todas las funciones por rol

CompraUsuario:
 - Ver el tema de las compras y cargarlas

Rubro:
 - Ver como completar el campo nombreCorto

ComisionesParametrizables:
 - No entiendo

WorkflowEstados:
 - Definir todos los posibles cambios de estados


  
Triggers y Tareas Programadas
-----------------------------
 - No se muy bien como se va a implementar esto, por ahora investigar como hacer que SQL tome la fecha y actualize
 el estadoPublicacion de aquellas que hallan vencido.

