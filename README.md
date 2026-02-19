# Desarrollo y diseño de Videojuegos en Unity
Este es un repositorio dedicado a mis proyectos de Unity y desarrollo de videojuegos, los proyectos están ordenados por orden de complejidad:

## 🛠️ Principales Programas y Herramientas

- Unity
- C# en Visual Studio Code
- GitHub Copilot
- Tiled (Editor de niveles flexible)

## Índice:

- Proyecto 1: Prototipo de IA Básica y Persecución en Unity3D.
- Proyecto 2: Sidescroller de Zombies con patrullaje y mecánicas de combate y sigilo en Unity2D.
- Proyecto 3: Nuevo sidescroller en Unity2D.

# 🎮 Proyecto 1: Prototipo de IA Básica y Persecución en Unity3D 🧠.

## 📜 Descripción:
Este proyecto es una prueba técnica y básica que mezca las tecnologías de NavMesh (tecnología de navegación definida), con la tecnología de detección de Raycast y una maquina de estados finito en el objeto FSM.
El proyecto consiste en un cilindro que patrulla por una ruta establecida en un mapa con obstáculos y persigue al jugador cuando lo detecta con su Raycast, cambiando su estado interno de patrulla a persecución.

El *Finite State Machine* es una de las tecnologías mas recurrentes en el mundo de los videojuegos, consiste en un array que recoge los distintos estados en forma de métodos que recogen las acciones del objeto en función del estado actual, aunque las empresas usan versiones mucho más avanzadas en videojuegos famosos como The Last of Us, esta es una buena base técnica e interesante que sirve de ejemplo para comprender como funcionan internamente estos juegos.

## 🚀 Características

- Patrulla con NavMesh y ruta predefinida.
- Detección por Raycast
- Persecución del jugador
- Evación de obstáculos

## 🎥 Gameplay

[No disponible por el momento]

## 🛠️ Tecnologías

- NavMesh
- Raycast
- FSM ()

# 🎮 Proyecto 2: Sidescroller de Zombies con patrullaje y mecánicas de combate y sigilo en Unity2D.

## 📜 Descripción:
Este es un proyecto 2D más completo y jugable ambientado en una ciudad en ruinas y medio consumida por la naturaleza, consta de un nivel con zombies que patrullan de manera aleatoria y natural a lo largo del mapa, los zombis pueden detectar al jugador si lo ven, si dispara cerca de ellos o si un zombi detecta al jugador los cercanos serán alertados añadiendo así una capa de interacción, realismo e inmersión.

El jugador puede atacarlos disparandoles, atacandoles cuerpo a cuerpo o atacandoles por la espalda cuerpo a cuerpo si no es detectado, lo que acaba con el zombie al instante y compensa el riesgo y la estrategia, el jugador tambien puede esconderse en objetos y entre la hierba que esta colocada a lo largo del nivel lo que le permite planificar estrategias de sigilo o pasar por una zona sin ser visto, cuando el jugador dispara o recibe daño, la información de la munición y la salud se recoge y se muestra en el HUD, el jugador debera de recoger munición de las respectivas cajas que hay repartidas y también se curará con botiquines igualmente repartidos.

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
- Elementos de HUD, botones, notificaciones, salud, etc.

## 🎥 Gameplay

[No disponible por el momento]

# GDD Completo: Los Ecos de la Humanidad (Prototype Vertical Slice 2D).

## Idea general de Juego:
Nombre: Los Ecos de la Humanidad

## Idea original:
*Pienso en antiguas naves espaciales inmensas e imponentes en ruinas, medio inundadas en una vasta playa, con sonidos fuertes de viento, algún que otro eco y un tiempo muy nublado o casi lluvioso con cierta atmósfera de terror, naves crujiendo que podrían desguazar en cualquier momento.* - No modificar -

Tono grisáceo y oscuro.

Este juego será un vertical slice 2D Sidescroller sencillo pero ambientado en la idea de juego “Ecos de la humanidad” reutilizando el contexto como base para el diseño y futuros proyectos.

Transmite: Curiosidad, Tragedia, Drama, Misterio, Opresión.

*De todo esto se intentará adaptar solo lo que sea posible*

## Mecánicas y jugabilidad:

Vertical Slice 2D Sidescroller

- Protector de Oxígeno, La nave contará con zonas no habitables, el jugador tendrá que rellenar su medidor de protección para pasar y continuar su aventura.
- Plataformas y obstáculos sencillo
- Escaleras.
- Droides patrullas de seguridad.

## Diseño de Nivel:

Duración 10-15 mins, máximo 20.

El juego debe ser más opresivo que difícil, que haya que detenerse un poco pero nada excesivo.

Para mantener la estética, es importante que en el sprite del jugador no esté armado ni cuente con ninguna defensa.

El objetivo del jugador en el Vertical Slice es salir de la cápsula, el jugador aparecerá y a partir del spawn, tras un pequeño plataformeo conseguirá la máscara de oxígeno para pasar por una zona antes imposible en donde encontrará el primer eco del archivo, después tendrá que evitar a unos droides de seguridad y encontrar un botón para abrir la segunda puerta, en la última puerta se mezclarán unas zonas de peligro con un par de droides y un interruptor que abra la puerta y a la vez muestre el fin del pasillo para terminar, tras esto el vertical slice terminará con la posibilidad de hacer una pequeña cinemática silenciosa en la que la cámara se aleje para admirar las ruinas en la playa y acabar ahí.

Se podrán ubicar ecos (coleccionables) del archivo de la humanidad en ubicaciones escondidas a lo largo del juego, al acabar el juego se mostrará la puntuación o porcentaje obtenido, cuando el jugador se acerque a uno de estos coleccionable será guiado a estos por el sonido de ecos humanos.

Ecos recuperados: (número de ecos coleccionados);

 Los droides serán unos enemigos con los que el jugador deberá pasar sigilosamente escondiéndose y decidiendo cuándo avanzar entre obstáculos, si es detectado será perseguido y atacado.

Las zonas con droides se basarán en el sistema de sigilo probado de mi anterior proyecto “Your Last Breath” donde el jugador se podía esconder y los zombis patrullaban de manera natural y aleatoria.

El jugador no puede defenderse, debe resaltarse la soledad y vulnerabilidad ante el entorno

## Contexto:

El contexto es extenso pensado para cubrir futuros proyectos, en el vertical slice solo se podra ver la cima del ice-berg, en futuros proyectos más grandes se podrá conocer más en el propio juego.

En un futuro muy lejano, la tecnología avanzó significativamente pero el calentamiento global sumado a las constantes guerras hicieron el planeta completamente inhabitable, las ciudades se llenaron de basura y temperaturas extremas, dando un ambiente post apocalíptico, a la par la manipulación se volvió extrema por culpa del desarrollo de las redes sociales y el contenido rápido, la necesidad de encontrar un nuevo hogar era protagonista en todos lados.

En aquella era existía la empresa tecnológica más avanzada del mundo Preservation Technologies, responsable de los principales avances por un siglo, hasta el momento cuidaba de las personas con las tecnologías futuristas imposibles más revolucionarias, como sistemas de cultivo y energía limpia infinita, sin embargo estás tecnologías llegaron demasiado tarde para evitar las consecuencias del calentamiento.

Tras mucha investigación teorizaron que la humanidad en exceso era un problema para el planeta, y que jamás se iba a recuperar si no se hacía un sacrificio, ellos con su tecnología avanzada le devolverán la vida que alguna vez tuvo.

Se llevaron a la mitad de la humanidad, les dijeron que el planeta necesita un descanso y les prometieron que volverían, se subieron a unas naves que tardaron décadas en construirse y estas contaban con los sistemas infinitos pensados para la vida indefinida ahí, la energía provenía de un reactor-generador, diseñadas para el caso de desastre planetario y no encontrar planeta habitable.

Sin embargo las naves estaban saboteadas antes del despegue y como parte del plan, estaban pensadas para que la humanidad no pudiera volver jamás y acabaran varadas en un planeta desértico-oceánico muy lejano en otra galaxia, en donde los últimos resquicios de la humanidad sobrevivieron durante miles de años, gracias a los sistemas infinitos, pero el paso del tiempo y la meteorología extrema del lugar degradó lentamente estos sistemas y era imposible hacerles un mantenimiento, los reactores de las naves estaban gravemente dañados por el impacto, por ello al final los últimos supervivientes no aguantaron más.

Un vasto planeta con inmensas playas donde residen los ecos de la humanidad junto a las tormentas y las ruidosas olas que se quejan de los escombros que robarán su espacio para siempre.(Aquí es donde ocurre el juego)

La empresa gracias a su tecnología, logró restaurar parcialmente el planeta viviendo durante muchos años más en una tierra que aunque viva, las ciudades extrañaban a sus habitantes. Con el paso del tiempo el planeta se volvió igualmente inhabitable y acabó con la otra mitad que quedaba allí, junto con la empresa.

El personaje del jugador es alguien que fue sometido a criogenización en una cápsula altamente protegida dentro de las naves desde poco antes del despegue de estas con el cometido de hacerle reunir las memorias humanas y brindarles un homenaje digno cuando se extingan. Antes del impacto la cápsula fue expulsada y aterrizó de manera segura en la lejanía, al detectar que la vida se había extinguido decidió que era el momento de devolver a quien aguardaban, nuestro triste protagonista no tiene más remedio que reunir toda la historia en el “Archivo de la Humanidad”, todas las memorias, historia, culturas y conocimientos de la humanidad y enterrarlo a modo de homenaje y funeral digno a las personas.
El archivo de la humanidad está esparcido entre los restos de las naves, son todos aquellos utensilios de los humanos que revelan una breve parte de su historia, al final el jugador deberá averiguar la localización de otra de las naves. El objetivo final es reunir la mayor cantidad de objetos cotidianos posibles y encontrar la ubicación del resto de naves.

## Frases de IA:

“Si alguien queda vivo… encuentra el Archivo.
La humanidad no debe desaparecer del todo.”

“Monumentos muertos a una mentira colosal.”

“Ecos es una experiencia narrativa en primera persona donde el jugador explora los restos de naves colosales varadas en un planeta oceánico.
Su objetivo es recuperar el Registro Final de la Humanidad y enterrarlo para preservar su legado tras la extinción.”

## Recursos:

Low rumbles (vibración grave constante)
https://www.youtube.com/@dalesnale 

## 🛠️ Tecnologías

- Raycast
- URP --> Shader(Universal Render Pipeline)
- Tiled

# 🧠 Aprendizajes Finales Claves

- Implementación de IA básica basada en FSM.
- Implementación de mecanicas.
- Uso eficiente de Raycast para detección.
- Uso de complementos de colisión, física y gravedad.
- Trabajo con materiales e iluminación con shaders.
- Comunicación entre clases y eventos.
- Mejora del game feel con técnicas de input buffer y coyote time (entre otros).
- Organización de scripts mediante programación modular (Scripts de movimiento básico, ataque, inventario, etc.).
- Creación y uso de tiles para creacion de niveles.
- Diseño de niveles y documentos de diseño.
