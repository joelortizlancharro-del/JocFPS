# 🎯 FPS Target Shooter

---

## 1. Títol provisional del joc
FPS Target Shooter

---

## 2. Tipus de microvideojoc escollit
Videojoc FPS (First Person Shooter) de precisió amb temps limitat.

---

## 3. Objectiu del joc
Disparar als objectius dins d’un temps limitat per aconseguir la puntuació mínima i avançar de nivell.

---

## 4. Rol del jugador
El jugador controla un personatge en primera persona amb una arma per eliminar objectius.

---

## 5. Regles bàsiques
- Només es pot utilitzar l’arma principal
- Cada encert suma punts
- Hi ha un temps limitat per nivell
- Els objectius apareixen progressivament

---

## 6. Condicions de victòria i derrota
**Victòria:**
- Aconseguir la puntuació mínima abans que acabi el temps
- Completar els 3 nivells

**Derrota:**
- No arribar a la puntuació mínima dins del temps

---

## 7. Bucle principal del joc
1. Inici del nivell  
2. Aparició d’objectius  
3. El jugador dispara  
4. Actualització de puntuació  
5. Control del temps  
6. Fi del nivell  
7. Passar al següent nivell o reiniciar  

---

## 8. Repte principal i dificultat
El repte és la precisió i la velocitat de reacció.  
La dificultat augmenta a cada nivell.

---

## 9. Limitacions explícites
- Un sol tipus d’arma
- Moviment limitat del jugador
- IA simple dels objectius
- Escenaris estàtics

---

## 10. Riscos tècnics
- Errors en col·lisions
- Problemes amb el spawn d’objectius
- Desincronització del temps
- Rendiment amb molts objectes

---

## 11. Exploració amb IA

**Prompt 1:**
Com implementar un sistema de puntuació en un FPS?

**Resposta:**
Utilitzar una variable global `score` que s’incrementa quan el jugador encerta un objectiu.

**Prompt 2:**
Com fer spawn aleatori d’objectius?

**Resposta:**
Utilitzar punts de spawn i seleccionar-ne un aleatòriament amb una funció random.

---

## 12. Proposta final escollida
FPS senzill amb:
- 3 nivells
- sistema de puntuació
- temps limitat
- objectius dinàmics

---

## 13. Justificació de viabilitat
És un projecte viable perquè:
- Mecàniques simples
- Poc codi complex
- Es pot implementar fàcilment en Unity o Java
- Abast reduït i controlat

---

## 14. Mini pla de treball
- Crear moviment FPS
- Implementar sistema de dispar
- Afegir objectius
- Sistema de puntuació
- Sistema de temps
- Crear nivells
- Test final

---

## 15. Eines previstes i justificació
- Unity / Java → desenvolupament del joc  
- C# o Java → programació  
- GitHub → control de versions  
- Blender (opcional) → models simples  
- PlantUML → diagrames de classes  