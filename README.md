# Desarrollo y diseño de Videojuegos en Unity
Este es un repositorio dedicado a mis proyectos de Unity y desarrollo de videojuegos

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

https://youtu.be/kur3Hj57bBY?feature=shared
[![](https://markdown-videos.deta.dev/youtube/NarBox1LkYc)](https://youtu.be/NarBox1LkYc)

## 🛠️ Tecnologías

- Raycast
- URP --> Shader(Universal Render Pipeline)

# 🎮 Proyecto 3: Nuevo Sidescroller en Unity2D.

## 📜 Descripción:
Este proyecto es muy reciente y todavía esta en primera fase de diseño y planificación, pero pretende al menos ser una mejora tanto interna como jugablemente del anterior, mejorando la organización tanto del proyecto como de los scripts y mejorando el *game feel* mediante técnicas de *game juice* (coyote time, input buffer, etc.), además realizaré un GDD (game design document) y contaré con el programa *tiled* para ayudarme realizar un mejor diseño de nivel.

El objetivo es realizar lo que se conoce como un *Vertical Slice* que consiste en un nivel o juego pequeño muy pulido y divertido en el que pueda aprender más cosas sobre el desarrollo y diseño.

## 🚀 Características

- Aun no hay características destacables

## 🎥 Gameplay

[No disponible por el momento]

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
- 
# Como Crear un Proyecto con Spring Framework 6 
Tutorial: https://youtu.be/NarBox1LkYc 

[![](https://markdown-videos.deta.dev/youtube/NarBox1LkYc)](https://youtu.be/NarBox1LkYc)




https://user-images.githubusercontent.com/11830789/231013254-14e5503e-db22-481a-bb44-e79b787cb550.mp4

