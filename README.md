# Desarrollo y diseño de Videojuegos en Unity
Este es un repositorio dedicado a los proyectos de Unity y desarrollo de videojuegos

## 🛠️ Programas y Herramientas

- Unity
- C#
- GitHub Copilot
- Tiled (Editor de niveles flexible)

# 🎮 Proyecto 1: Prototipo de IA Básica y Persecución en Unity3D.

## 📜 Descripción:
Este proyecto es una prueba técnica y básica que mezca las tecnologías de NavMesh (tecnología de navegación definida), con la tecnología de detección de Raycast y una maquina de estados finito en el objeto FSM.
El proyecto consiste en un cilindro que patrulla por una ruta establecida en un mapa con obstáculos y persigue al jugador cuando lo detecta con su Raycast, cambiando su estado interno de patrulla a persecución.

El *Finite State Machine* es una de las tecnologías mas recurrentes en el mundo de los videojuegos, consiste en un array que recoge los distintos estados en forma de métodos que recogen las acciones del objeto en función del estado actual, aunque las empresas usan versiones mucho más avanzadas en videojuegos famosos como The Last of Us, esta es una buena base técnica de ejemplo para comprender como funcionan internamente estos juegos.

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
Este es un proyecto 2D más completo y jugable, consta de un nivel con zombies que patrullan de manera aleatoria y natural a lo largo del mapa, los zombis pueden detectar al jugador si lo ven, si dispara cerca de ellos o si un zombi detecta al jugador, los cercanos también lo perseguiran añadiendo así una capa de interacción, realismo e inmersión.

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

[No disponible por el momento]

## 🛠️ Tecnologías

- Raycast
- URP --> Shader(Universal Render Pipeline)

# 🎮 Proyecto 3: Nuevo sidescroller en Unity2D.

## 📜 Descripción:
Este proyecto es nuevo y pretende al menos ser una mejora tanto interna como jugablemente del anterior, mejorando la organización tanto del proyecto como de los scripts y mejorando el *game feel* mediante técnicas de *game juice* (coyote time, input buffer, etc.), además realizaré un GDD (game design document) y contaré con el programa *tiled* para ayudarme realizar un mejor diseño de nivel.

## 🚀 Características

- Aun no hay características destacables

## 🎥 Gameplay

[No disponible por el momento]

## 🛠️ Tecnologías

- Raycast
- URP --> Shader(Universal Render Pipeline)
- Tiled

# 🧠 Aprendizajes Finales Claves

- Implementación de IA basada en FSM.
- Uso eficiente de Raycast para detección.
- Comunicación entre clases y eventos.
- Mejora del game feel con técnicas de input buffer y coyote time (entre otros).
- Organización de scripts mediante programación modular (Scripts de movimiento básico, ataque, inventario, etc.)
