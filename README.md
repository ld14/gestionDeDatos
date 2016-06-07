# Notas de la versión 1.1.1

Se ha mejorado el código para que este mas legible.
Se agruparon todas las inserciones por tabla y se detalla las tablas afectadas.
Se agregó las secuencias para código Visibilidad y Calificacion.
Se cambiaron algunos tipos de datos para mayor eficiencia.
Se insertaron el estado inicial y el workflow de estados.

-----------------------

A continuación dejo los puntos que quedaron fuera del alcanze de la versión 1.1.1, los cuales deberán tratarse a la brevedad:

Cliente:
 - fechaCreacion
 - comprasEfectuadas
 - comprasCalificadas

Funciones:
 - Cargar todas las funciones

RolFunciones:
 - Cargar todas las funciones por rol

Rubro:
 - codigo

RubroPublicacion:
 - Ordenar por id asc

Usuario:
 - Encriptar la contraseña con SHA-256

  
Triggers y Tareas Programadas
-----------------------------
 - No se muy bien como se va a implementar esto, por ahora investigar como hacer que SQL tome la fecha y actualize
 el estadoPublicacion de aquellas que hallan vencido. (JOB)

 - Hacer que cada nuevo insert a la tabla Publicacion genere un nuevo cógido que sea el anterior + 1.
