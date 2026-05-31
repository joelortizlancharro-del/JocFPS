# 02_model_del_joc

---

## 1. Components principals del joc

El joc és un FPS en primera persona amb els següents components:

- Sistema de dispar
- Objectius (enemics)
- Sistema de puntuació
- Temporitzador (temps limitat)
- Sistema de nivells

---

## 2. Entitats identificades

Les entitats principals del sistema són:

- Player (Jugador)
- EnemyTarget (Enemic)
- Weapon (Arma)
- GameManager
- Level
- Timer
- Item

---

## 3. Atributs clau de cada entitat

**Player**
- health : int
- score : int
- weapon : Weapon

**EnemyTarget**
- points : int
- isActive : boolean

**Weapon**
- damage : int
- fireRate : float

**GameManager**
- currentLevel : int
- timeLeft : int

**Level**
- levelNumber : int
- requiredScore : int

**Timer**
- timeRemaining : int

**Item**
- type : String

---

## 4. Accions, mètodes o funcions principals

**Player**
- shoot()

**EnemyTarget**
- hit()
- respawn()

**Weapon**
- fire()

**GameManager**
- startGame()
- updateGame()
- endGame()

**Level**
- startLevel()
- checkWin()

**Timer**
- start()
- update()

**Item**
- applyEffect()

---

## 5. Explicació del diagrama de classes

El diagrama de classes representa l’estructura del sistema i la relació entre les diferents entitats del joc.

El Player interactua amb:
- Weapon per disparar
- EnemyTarget per eliminar objectius
- Item per obtenir millores

El GameManager controla el flux del joc i gestiona:
- Player
- Level
- Timer

El Level defineix la dificultat i els objectius a assolir.

Aquest disseny permet separar responsabilitats i facilita la implementació posterior del joc.

---

## 6. Explicació del diagrama de comportament

El diagrama de comportament representa el bucle principal del joc.

Flux del joc:
1. Inici del joc
2. Inici del nivell
3. Aparició d’enemics
4. El jugador dispara
5. Es comproven els impactes
6. S’actualitza la puntuació
7. Es comprova el temps

Final:
- Si s’assoleix la puntuació → es passa de nivell
- Si s’acaba el temps → derrota

Aquest procés es repeteix fins completar el joc o perdre.

---

## 7. Correspondència entre diagrames i codi futur

Cada classe del diagrama es convertirà en una classe en codi (Java o Unity C#).

- Atributs → variables
- Mètodes → funcions
- Relacions → referències entre objectes

Exemple:
- Player tindrà una referència a Weapon
- GameManager controlarà el bucle principal amb un loop

---

## 8. Estructura inicial del repositori

FPS-Target-Shooter/

- Assets/
  - Scripts/
  - Scenes/
  - Prefabs/

- Fase2/
  - README.md
  - 02_model_del_joc.md
  - diagrames/
    - diagrama_classes.png
    - diagrama_comportament.png

- README.md

Aquesta estructura permet una organització clara del projecte i separa el codi de la documentació.

---

## 9. Primer commit i README inicial

El repositori ha estat inicialitzat a GitHub.

El primer commit inclou:
- README.md amb la descripció del projecte
- Estructura inicial de carpetes

Aquest commit representa el punt d’inici del desenvolupament del joc.