# Desarrollo y diseño de Videojuegos en Unity
Este es un repositorio dedicado a mis proyectos de Unity y desarrollo de videojuegos, los proyectos están ordenados por orden de complejidad y evolución técnica:

## 🛠️ Principales Programas y Herramientas

- Unity
- C# en Visual Studio Code
- GitHub Copilot
- Tiled (Editor de niveles flexible)

## Índice:

- Proyecto 1: Prototipo de IA Básica y Persecución en Unity3D.
- Proyecto 2: Sidescroller de Zombies con patrullaje y mecánicas de combate y sigilo en Unity2D.
- Proyecto 3: Los Ecos de la Humanidad (Prototype Vertical Slice 2D Sidescroller).

# 🎮 Proyecto 1: Prototipo de IA Básica y Persecución en Unity3D 🧠.

## 📜 Descripción:
Este proyecto es una prueba técnica y básica que mezcla las tecnologías de NavMesh (tecnología de navegación definida), con la tecnología de detección de Raycast y una maquina de estados finita en el objeto FSM.
El proyecto consiste en un cilindro que patrulla por una ruta establecida en un mapa con obstáculos y persigue al jugador cuando lo detecta con su Raycast, cambiando su estado interno de patrulla a persecución.

El *Finite State Machine* es una de las tecnologías mas recurrentes en el mundo de los videojuegos, consiste en un array que recoge los distintos estados en forma de métodos que recogen las acciones del objeto en función del estado actual, aunque las empresas usan versiones mucho más avanzadas en videojuegos famosos como The Last of Us, esta es una buena base técnica e interesante que sirve de ejemplo para comprender como funcionan internamente estos juegos.

## 🚀 Características

- Patrulla con NavMesh y ruta predefinida.
- Detección por Raycast
- Persecución del jugador
- Evasión de obstáculos

## 🎥 Gameplay

[No disponible por el momento]

## 🛠️ Tecnologías

- NavMesh
- Raycast
- FSM ()

# 🎮 Proyecto 2: Sidescroller de Zombies con patrullaje y mecánicas de combate y sigilo en Unity2D.

## 📜 Descripción:
Este es un proyecto 2D más completo y jugable ambientado en una ciudad en ruinas y medio consumida por la naturaleza, consta de un nivel con zombies que patrullan de manera aleatoria y natural a lo largo del mapa, los zombis pueden detectar al jugador si lo ven, si dispara cerca de ellos o si un zombi detecta al jugador los cercanos serán alertados añadiendo así una capa de interacción, realismo e inmersión.

El jugador puede atacarlos disparándoles, atacandoles cuerpo a cuerpo o atacandoles por la espalda cuerpo a cuerpo si no es detectado, lo que acaba con el zombie al instante y compensa el riesgo y la estrategia, el jugador tambien puede esconderse en objetos y entre la hierba que esta colocada a lo largo del nivel lo que le permite planificar estrategias de sigilo o pasar por una zona sin ser visto, cuando el jugador dispara o recibe daño, la información de la munición y la salud se recoge y se muestra en el HUD, el jugador debera de recoger munición de las respectivas cajas que hay repartidas y también se curará con botiquines igualmente repartidos.

## 🚀 Características

- Patrullaje aleatorio y orgánico
- Detección por Raycast
- Persecución del jugador
- Sincronización entre zombies
- Sistema básico de loot
- Sistema de escondites
- Sistema de combate sencillo y disparos
- Gestion de salud y munición
- Diseño y creacion básico de nivel con tilemaps

## 🎥 Gameplay

[![Como Crear un Proyecto con Spring Framework 6](https://img.youtube.com/vi/kur3Hj57bBY/0.jpg)](https://youtu.be/kur3Hj57bBY?feature=shared)

🔗 Enlace directo al video:  
https://youtu.be/kur3Hj57bBY?feature=shared

## 🛠️ Tecnologías

- Raycast
- URP --> Shader(Universal Render Pipeline)

# 🎮 Proyecto 3: Los Ecos de la Humanidad (Prototype Vertical Slice 2D Sidescroller).

## 📜 Descripción:
Este proyecto es reciente y todavía esta en fase temprana de desarrollo, pero será una mejora tanto técnica como jugablemente del anterior, mejoras en la organización tanto del proyecto como de los scripts y *game feel* mediante técnicas de *game juice* (coyote time, input buffer, etc.), además realizaré un GDD (game design document) y contaré con el programa *tiled* para ayudarme realizar un mejor diseño de nivel.

El objetivo es realizar lo que se conoce como un *Vertical Slice* que consiste en un nivel o juego pequeño muy pulido en el que pueda aprender más cosas sobre el desarrollo y diseño que pueda aplicar en futuros proyectos.

## 🚀 Características

- Triggers de daño y efectos ambientales.
- Elementos y animaciónes de HUD, botones, notificaciones, salud, etc.
- Efecto Parallax, movimiento realista de escenario y profundidad.

## 🎥 Gameplay

[No disponible por el momento]

# GDD: Los Ecos de la Humanidad (Prototype Vertical Slice 2D).

##Idea general de Juego:
Nombre: Los Ecos de la Humanidad

Idea original:
*Pienso en antiguas naves espaciales inmensas e imponentes en ruinas, medio inundadas en una vasta playa, con sonidos fuertes de viento, algún que otro eco y un tiempo muy nublado o casi lluvioso con cierta atmósfera de terror, naves crujiendo que podrían desguazar en cualquier momento.* - No modificar -

Tono grisáceo y oscuro.

Este juego será un vertical slice 2D Sidescroller sencillo pero ambientado en la idea de juego “Ecos de la humanidad” reutilizando el contexto como base para el diseño y futuros proyectos.

Transmite: Curiosidad, Tragedia, Drama, Misterio, Opresión.

*De todo esto se intentará adaptar solo lo que sea posible*

##Mecánicas y jugabilidad:

Vertical Slice 2D Sidescroller

Protector de Oxígeno, La nave contará con zonas no habitables, el jugador tendrá que rellenar su medidor de protección para pasar y continuar su aventura.
Plataformas y obstáculos sencillo
Escaleras.
Droides patrullas de seguridad.

##Diseño de Nivel:

Duración 10-15 mins, máximo 20.

El juego debe ser más opresivo que difícil, que haya que detenerse un poco pero nada excesivo.

Para mantener la estética, es importante que en el sprite del jugador no esté armado ni cuente con ninguna defensa.

El objetivo del jugador en el Vertical Slice es salir de la cápsula, el jugador aparecerá y a partir del spawn, tras un pequeño plataformeo conseguirá la máscara de oxígeno para pasar por una zona antes imposible en donde encontrará el primer eco del archivo, después tendrá que evitar a unos droides de seguridad y encontrar un botón para abrir la segunda puerta, mientras realiza esto ocurrirá un evento: las luces empezarán a parpadear y el escenario se preparará para un fuerte estruendo que hará a los droides detenerse y hará temblar la cámara, en la última puerta se mezclarán unas zonas de peligro con un par de droides y un interruptor que abra la puerta y a la vez muestre el fin del pasillo para terminar, tras esto el vertical slice terminará con la posibilidad de hacer una pequeña cinemática silenciosa en la que la cámara se aleje para admirar las ruinas en la playa y acabar ahí.

Se podrán ubicar ecos (coleccionables) del archivo de la humanidad en ubicaciones escondidas a lo largo del juego, al acabar el juego se mostrará la puntuación o porcentaje obtenido, cuando el jugador se acerque a uno de estos coleccionable será guiado a estos por el sonido de ecos humanos y contarán una breve historia en un menú.

La estética de las naves serán blanco y naranja, la estética de preservation technologies

Ecos recuperados: (número de ecos coleccionados);

Los droides serán unos enemigos con los que el jugador deberá pasar sigilosamente escondiéndose y decidiendo cuándo avanzar entre obstáculos, si es detectado será perseguido y atacado.

Las zonas con droides se basarán en el sistema de sigilo probado de mi anterior proyecto “Your Last Breath” donde el jugador se podía esconder y los zombis patrullaban de manera natural y aleatoria.

El jugador no puede defenderse, debe resaltarse la soledad y vulnerabilidad ante el entorno

##Contexto (Sólo de Base):
"En un futuro lejano, Preservation Technologies – gigante de avances por un siglo – vio la Tierra destruida por calentamiento, guerras y manipulación de redes/contenido rápido. Con gobiernos, decidieron sacrificar mitad humanidad para 'salvar' el planeta: engañaron a miles de millones para subir a naves eternas con reactores infinitos, prometiendo un nuevo hogar.
Saboteadas, se estrellaron en un planeta desértico-oceánico lejano. Supervivientes aguantaron milenios con sistemas infinitos, pero meteorología extrema y reactores dañados en impacto degradaron todo – al final, extinguidos.
Preservation restauró parcialmente Tierra, pero heridas profundas + arrogancia llevaron a su extinción.
El jugador, criogenizado es el 'gran enterrador', despierta para recolectar el 'Archivo de la Humanidad' – objetos cotidianos esparcidos revelando memorias – y enterrarlo como homenaje digno, averiguando otras naves."
El archivo de la humanidad está esparcido entre los restos de las grandes naves, son todos aquellos utensilios de los humanos que revelan una breve parte de su historia, al final el jugador deberá averiguar la localización de otra de las naves. El objetivo final es reunir la mayor cantidad de objetos cotidianos posibles y encontrar la ubicación del resto de naves.

Frases de IA:

“Si alguien queda vivo… encuentra el Archivo.
La humanidad no debe desaparecer del todo.”

“Monumentos muertos a una mentira colosal.”

“Ecos es una experiencia narrativa en primera persona donde el jugador explora los restos de naves colosales varadas en un planeta oceánico.
Su objetivo es recuperar el Registro Final de la Humanidad y enterrarlo para preservar su legado tras la extinción.”

Recursos:

Ecos, sonido de reloj y niños
https://freesound.org/people/DouglasJewett/sounds/178753/ 

Low rumbles (vibración grave constante)
https://www.youtube.com/@dalesnale 

Trueno
https://freesound.org/people/AdrianoAnjos/sounds/540365/

Viento
https://freesound.org/people/felix.blume/sounds/216892/ 


Imágenes:

Evolución del apartado visual.

## 🛠️ Tecnologías

- Raycast
- URP --> Shader(Universal Render Pipeline)
- Tiled

# 🧠 Aprendizajes Finales Claves

- Creación de elementos de HUD.
- Uso de Triggers y efectos ambientales.
- Implementación de IA básica basada en FSM.
- Sistema de estados desacoplado usando patrón State.
- Comunicación entre enemigos mediante eventos C#.
- Sistema de detección optimizado usando capas y máscara de colisión.
- Uso eficiente de Raycast para detección.
- Uso de complementos de colisión, física y gravedad.
- Trabajo con materiales e iluminación con shaders.
- Comunicación entre clases y eventos.
- Mejora del game feel con técnicas de input buffer y coyote time (entre otros).
- Organización de workflow y scripts mediante programación modular (Scripts de movimiento básico, ataque, inventario, etc.).
- Creación y uso de tiles y recursos para creacion de niveles.
- Diseño de niveles y documentos de diseño.
