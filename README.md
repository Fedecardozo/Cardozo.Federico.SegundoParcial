#  <img src="FormTruco/Resources/jugando-a-las-cartas (1).png" width="40" height="40">  Trucazo   
## Parcial 2 de Laboratorio 2 juego del truco


#### Presentación:

Me presento, soy Federico Cardozo tengo 24 años, estoy estudiando programación en la UTN FRA. Actualmente estoy cursando el segundo cuatrimestre
en el cual para su aprobación hago este proyecto. En el cual como expierencia se me hizo muy completo para seguir aprendiendo y seguir perfeccionandome
profesionalmente, fue un desafio que me llevo bastante tiempo desarrollar pero en cual me diverti y aprendi nuevas herramientas.

#### Aplicación: 
La aplicación simula partidas en tiempo real. Es decir, el usuario que corra la aplicación puede crear salas de juego donde se jugarán las partidas de forma simultánea.
Mientras las partidas se están jugando, el usuario de la aplicación puede consultar en cada una de ellas.
Son solos 4 manos, que se puede extender si el jugador lo desea.

##### La aplicación hace que un usuario pueda realizar las siguientes acciones:
* Se pueda loguear con su usuario y contraseña
* Ver el historial de salas creadas
* Crear salas
* Jugar partidas de truco                       
* De cada sala ver las partidas en curso, quien las creo. 
* Tambien ver las partidas de las que ya no en curso
* Consultar datos estadisticos. Como por ejemplo el jugador mas ganador.
* Crear nuevos usuarios.

## Diagrama de clases

![Diagrama](https://user-images.githubusercontent.com/47437164/206135413-14d1576f-f63b-4498-8f90-5068b7ce61f6.png)

## Partidas de trucos

![image](https://user-images.githubusercontent.com/47437164/206141466-05dc0433-76ff-4b45-b776-3a6eb68a9124.png)

## Temas aplicados

### Excepciones
Lo utilize para el manejo de archivos, base de datos y posibles lugares donde la aplicación puede romper en tiempo de ejecución.

###  Tipos genéricos
Lo aplique en la serialización de archivos y en metodos de la base de datos. Ya que al manejar distintos tipos de datos 
era más conveniente el uso de generics.

### Interfaces
Los use en la clase Resultado, Usuario, Sala. Ya que ahi hago manejo de las base de datos, entonces podian aplicar los metodos de la interfaz.

###  Archivos/Serialización
Lo use para cargar una colección de cartas para el mazo de cartas y tambien serialize la clase usuario y sala.

### Base de datos y SQL
Lo use para manejar guardar usuarios, salas, y resultados. Sala contiene las foreign key de usuarios y resultados. 
De esta manera se me hace más facil mantener las relación entre las clases y manejar los datos de las mismas.

### Conexión a bases de datos
Cree una clase especial que se encarga de la conexión a la base de datos y el manejo de la misma.

### Delegados y expresiones lambda
La use en varios lugares del codigo, para comunicarme entre formularios, manejar hilos, enventos y metodos propios.

### Programación multi-hilo y concurrencia
En el formulario del Truco muestro lo que se va cantando y quienes van ganando por ronda a través de hilos.
En el formulario principal muestro la fecha actual con la hora actual todo el tiempo en un hilo secundario.
También lo ulitice para jugar las partidas de truco. 

### Eventos
Lo aplique para mantener actualizados los dataGrid cada vez que se haga alguna modificación o insersión a la base de datos.


## Cuentas para loguearse
1. **Primer usuario** 
    - **Usuario:** *fede*
    - **Contraseña:** *1234*
2. **Segundo usuario** 
    - **Usuario:** *maxi*
    - **Contraseña:** *1234*
3. **Tercer usuario**
    - **Usuario:** *lea*
    - **Contraseña:** *1234*
4. **Cuarto usuario**
    - **Usuario:** *facu*
    - **Contraseña:** *1234*

Entre otras cuentas...
