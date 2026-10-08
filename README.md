# Meowtroid

Videojuego educativo de aventura desarrollado por **StarPaw Games**, en el que el jugador controla a un gato llamado Michi que deberá atravesar un bosque, superar obstáculos, evitar o derrotar enemigos y responder preguntas para completar el nivel.
![VG](Videogame.png)

---

## Documento de Diseño

### Información general

| Concepto                 | Descripción                   |
| ------------------------ | ----------------------------- |
| **Título del juego**     | Meowtroid                     |
| **Estudio / Creadores**  | StarPaw Games                 |
| **Género**               | Aventura, educativo , plataforma|
| **Plataforma**           | Windows 7 en adelante y macOS |
| **Motor de desarrollo**  | Unity                         |
| **Público meta**         | Público general               |
| **Cámara**               | Tercera persona               |
| **Periféricos**          | Teclado o mouse               |
| **Fecha de inicio**      | 07/08/2023                    |
| **Fecha de terminación** | 22/10/2023                    |
| **Presupuesto**          | No aplica                     |

---

## Sinopsis de Jugabilidad

El jugador deberá superar diferentes obstáculos, derrotar o esquivar a los enemigos que aparecen a lo largo del nivel y responder preguntas para poder avanzar y completar exitosamente el nivel.

## Sinopsis de Contenido

### Historia

Michi, un pequeño gato, se perdió en un misterioso bosque. Para poder encontrar el camino de regreso, deberá recorrer el bosque, superar los obstáculos y contestar correctamente las preguntas que se encuentran en los cofres distribuidos a lo largo del nivel.

### Personaje principal

* **Gato Michi**

### Enemigos

* Bola de pinchos
* Tronco
* Murciélago
* Pájaro
* Abeja
* Planta lanza chícharos
* Bloque punzante
* Hongo

### Objetivo

Contestar correctamente las preguntas de los cofres para lograr superar el nivel.

---

## Categoría

Meowtroid comparte algunas características con juegos de plataformas como **Mario Bros**, principalmente en la forma de avanzar por el escenario, superar obstáculos y enfrentarse a diferentes enemigos.

La principal diferencia es que **Meowtroid incorpora un componente educativo**, ya que el jugador debe responder preguntas para poder completar el nivel.

---

## Visión General del Juego

Meowtroid está dirigido a un público general y combina elementos de aventura y plataformas con preguntas relacionadas con conocimientos de matemáticas y computación.

El juego busca ofrecer un reto mediante la combinación de:

* Exploración.
* Plataformas.
* Enemigos.
* Obstáculos.
* Preguntas educativas.
* Progresión a través del nivel.

El jugador deberá demostrar tanto habilidad para superar los obstáculos como conocimientos para responder correctamente las preguntas de los cofres.

---

# Mecánica del Juego

## Acciones del jugador

El jugador deberá:

1. Mover al personaje por el escenario.
2. Saltar entre plataformas.
3. Evitar o derrotar enemigos.
4. Explorar el nivel.
5. Encontrar los cofres.
6. Responder las preguntas.
7. Contestar todos los cofres necesarios para completar el nivel.

### Controles

| Tecla   | Acción                        |
| ------- | ----------------------------- |
| A       | Movimiento hacia la izquierda |
| D       | Movimiento hacia la derecha   |
| ESPACIO | Saltar                        |
| E       | Interactuar                   |

### Puntaje y progreso

El juego mostrará la cantidad de cofres disponibles en el nivel y la cantidad de cofres que ya han sido contestados.

El juego no cuenta con sistema de guardado o carga. El nivel deberá comenzar y finalizar dentro de la misma partida.

---

# Interfaces

| # | Pantalla      | Descripción                                                                                               | Acción que la invoca                                         |
| - | ------------- | --------------------------------------------------------------------------------------------------------- | ------------------------------------------------------------ |
| 1 | Inicio        | Permite acceder a las diferentes opciones del juego: jugar, configuración, selección de nivel y créditos. | Entrar al juego, configurar el juego o seleccionar un nivel. |
| 2 | Configuración | Permite modificar controles y ajustar opciones de audio.                                                  | Ajustar audio o modificar teclas.                            |
| 3 | Niveles       | Muestra los diferentes niveles disponibles para que el jugador seleccione uno.                            | Seleccionar un nivel.                                        |
| 4 | Pausa         | Permite detener temporalmente el juego y acceder a opciones como audio, reinicio o salida.                | Pausar, reanudar, ajustar audio o reiniciar.                 |
| 5 | Final         | Se muestra al terminar un nivel y permite salir, volver a jugar o continuar.                              | Terminar el nivel.                                           |
| 6 | Créditos      | Muestra información sobre los participantes en la creación del proyecto.                                  | Seleccionar la opción de créditos.                           |

---

# Niveles

## Nivel 1 — Bosque

### Descripción

El escenario principal es un bosque en el que el jugador deberá enfrentarse a diferentes enemigos y obstáculos.

Michi tendrá que saltar entre plataformas, evitar o derrotar enemigos y avanzar por el escenario hasta completar los objetivos del nivel.

### Objetivo

Contestar las preguntas de los cofres distribuidos a lo largo del nivel.

### Progreso

Una vez terminado el nivel, el jugador será dirigido nuevamente al menú principal.

### Enemigos

* Bola de pinchos
* Tronco
* Murciélago
* Pájaro
* Abeja
* Planta lanza chícharos
* Bloque punzante
* Hongo

### Personajes adicionales

No existen personajes adicionales.

### Música

Música repetitiva durante:

* Menú principal.
* Partida.

### Efectos de sonido

No hay efectos de sonido.

---

# Personajes

## Gato Michi

| Característica  | Descripción                                               |
| --------------- | --------------------------------------------------------- |
| **Concepto**    | Michi es un gato que se perdió en el bosque. Para poder superar el nivel deberá demostrar los conocimientos y habilidades necesarios para enfrentarse a los obstáculos y responder correctamente las preguntas.|
| **Encuentro**   | Michi aparece en: - Menú de selección de nivel. - Inicio del nivel.|
| **Habilidades** | - Saltar. - Hacer daño a los enemigos al saltar sobre ellos.|
| **Armas**       | No tiene ítems. |
| **Ítems**       | Ninguno.|
| **Personaje jugable**| Sí. Michi es el personaje controlado directamente por el jugador.|

---

# Enemigos

## Hongo

| Característica  | Descripción                                               |
| --------------- | --------------------------------------------------------- |
| **Concepto**    | Hongo del bosque que simplemente camina por su hábitat.   |
| **Encuentro**   | Aparece al iniciar el nivel.                              |
| **Habilidades** | Caminar.                                                  |
| **Armas**       | Su cuerpo es tóxico para los felinos; su cabeza no lo es. |
| **Ítems**       | Ninguno.                                                  |

---

## Bola de Pinchos

| Característica  | Descripción                                                                   |
| --------------- | ----------------------------------------------------------------------------- |
| **Concepto**    | Una bola de pinchos que se encuentra en el bosque. Nadie sabe cómo llegó ahí. |
| **Encuentro**   | Aparece cuando el jugador comienza el nivel.                                  |
| **Habilidades** | Gira alrededor de un cubo amarillo.                                           |
| **Armas**       | Toda la bola de pinchos funciona como arma.                                   |
| **Ítems**       | Ninguno.                                                                      |

---

## Tronco

| Característica  | Descripción                                                 |
| --------------- | ----------------------------------------------------------- |
| **Concepto**    | Un tronco del bosque que, inexplicablemente, puede caminar. |
| **Encuentro**   | Aparece al comenzar el nivel.                               |
| **Habilidades** | Caminar.                                                    |
| **Armas**       | Hace daño al jugador al tocarlo.                            |
| **Derrota**     | Muere cuando el jugador cae sobre él.                       |
| **Ítems**       | Ninguno.                                                    |

---

## Bloque Punzante

| Característica  | Descripción                                                        |
| --------------- | ------------------------------------------------------------------ |
| **Concepto**    | Bloque de madera cubierto de picos.                                |
| **Encuentro**   | Aparece cuando el jugador comienza el nivel.                       |
| **Habilidades** | Se mueve horizontalmente de un lado a otro.                        |
| **Armas**       | Tiene pinchos en todos sus lados y causa daño al tocar al jugador. |
| **Ítems**       | Ninguno.                                                           |

---

## Abeja

| Característica  | Descripción                                                        |
| --------------- | ------------------------------------------------------------------ |
| **Concepto**    | Abeja agresiva de los bosques de China que defiende su territorio. |
| **Encuentro**   | Aparece cuando el jugador inicia el nivel.                         |
| **Habilidades** | Vuela horizontalmente.                                             |
| **Armas**       | Aguijón que causa daño al jugador.                                 |
| **Ítems**       | Ninguno.                                                           |

---

## Murciélago

| Característica  | Descripción                                         |
| --------------- | --------------------------------------------------- |
| **Concepto**    | Murciélago que habita las áreas finales del bosque. |
| **Encuentro**   | Aparece durante el nivel.                           |
| **Habilidades** | Vuela siguiendo una trayectoria predefinida.        |
| **Armas**       | No tiene.                                           |
| **Ítems**       | No tiene.                                           |

---

## Pájaro

| Característica  | Descripción                                     |
| --------------- | ----------------------------------------------- |
| **Concepto**    | Pájaro que habita las áreas finales del bosque. |
| **Encuentro**   | Aparece durante el nivel.                       |
| **Habilidades** | Vuela siguiendo una trayectoria predefinida.    |
| **Armas**       | No tiene.                                       |
| **Ítems**       | No tiene.                                       |

---

## Planta Lanza Chícharos

| Característica  | Descripción                                                                         |
| --------------- | ----------------------------------------------------------------------------------- |
| **Concepto**    | Planta lanzadora de chícharos que ha vivido en el bosque desde que era una semilla. |
| **Encuentro**   | Aparece durante el nivel.                                                           |
| **Habilidades** | Dispara chícharos horizontalmente hacia la dirección en la que está mirando.        |
| **Armas**       | No tiene.                                                                           |
| **Ítems**       | No tiene.                                                                           |

---

# Guión

El videojuego no cuenta con diálogos ni un guión narrativo.

---

# Logros

El videojuego no cuenta con un sistema de logros.

---

# Códigos Secretos

El videojuego no cuenta con códigos secretos.

---

# Tecnología

### Software

* **Unity** — Motor utilizado para la creación del videojuego.

### Hardware / Plataformas

* Windows 7 en adelante.
* macOS.

---

# Licencia y Propiedad Intelectual

El videojuego no está inspirado directamente en ningún libro o película.

El concepto tiene potencial para convertirse en una franquicia mediante una segunda parte o nuevos juegos que utilicen a los mismos personajes con diferentes temáticas.

---

# Detalles de Producción

| Concepto                 | Información   |
| ------------------------ | ------------- |
| **Fecha de inicio**      | 07/08/2023    |
| **Fecha de terminación** | 22/10/2023    |
| **Presupuesto**          | No aplica     |
| **Estudio**              | StarPaw Games |

---

# Bibliografía

Morales, G., Nava, C., Fernández, L. y Rey, M. (2010). *Proceso de desarrollo para videojuegos*. **CULCyT: Cultura Científica y Tecnológica, 7**(36-37), 25-39.

[Dialnet — Proceso de desarrollo para videojuegos](https://dialnet.unirioja.es/servlet/articulo?codigo=3238114)
