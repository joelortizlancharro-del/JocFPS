# 03_entorn_i_prototip

---

## 🧰 IDE utilitzat i configuració bàsica

El projecte s’ha desenvolupat amb **Unity** com a motor de videojocs.

Sistema operatiu: Windows

Configuració inicial del projecte:
- Creació del projecte Unity FPS
- Configuració de la càmera en primera persona
- Preparació de l’escena inicial

---

## ⚙️ Decisions inicials d’implementació

S’han pres les següents decisions per al desenvolupament del joc:

- El joc serà en **primera persona (FPS)**
- El moviment del jugador es farà amb **WASD**
- El sistema de dispar serà amb **projectils físics**
- La càmera estarà vinculada al jugador per simular la visió FPS
- El joc utilitzarà una arquitectura basada en components de Unity

---

## 🎮 Estat actual del prototip

En aquest moment:

- El projecte s’inicia correctament ✔
- La càmera FPS està creada ✔
- El moviment del jugador està implementat de forma parcial ✔
- Encara no hi ha interacció amb objectes ❌
- No hi ha sistema de dispar ❌
- No hi ha enemics ni puntuació ❌

El prototip està en fase inicial però funcional a nivell de moviment bàsic.

---

## 🔁 Bucle de joc (implementació inicial)

Actualment el bucle del joc és molt bàsic:

1. Inici del joc
2. El jugador es pot moure amb WASD
3. La càmera segueix el jugador
4. El joc continua en execució sense interaccions avançades

Aquest bucle s’anirà ampliant en les següents fases amb:
- dispar
- enemics
- puntuació
- temporitzador

---

## 🧪 Decisions tècniques

- S’utilitza Unity per la seva facilitat en FPS
- Es farà ús de física per als projectils
- El control del jugador es basa en el sistema de inputs de Unity
- L’arquitectura serà modular (Player, Weapon, GameManager)

---

## 📸 Evidències visuals

Actualment no es disposa de captures del projecte, ja que el prototip es troba en fase inicial de desenvolupament.

---

## 🔁 Control de versions (GitHub)

En aquesta fase encara no s’han realitzat commits en el repositori de GitHub.

El control de versions s’iniciarà en la següent iteració del desenvolupament, quan el prototip sigui més estable i funcional.

---

## 🚀 Objectiu de la fase

Aquesta fase té com a objectiu crear la base funcional del joc:

- moviment del jugador
- càmera FPS
- estructura inicial del projecte

A partir d’aquí es començarà a afegir interacció i mecàniques de joc.