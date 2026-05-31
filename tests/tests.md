# Tests del joc FPS Target Shooter

Aquest document recull les proves realitzades durant el desenvolupament del joc per verificar el seu funcionament correcte.

---

## TEST 1 - Moviment del jugador
- Objectiu: comprovar el moviment amb WASD  
- Acció: moure el personatge per l’escenari  
- Resultat esperat: el jugador es mou correctament en totes direccions  
- Resultat real: correcte  

---

## TEST 2 - Càmera
- Objectiu: comprovar el control de la càmera amb el ratolí  
- Acció: moure el ratolí  
- Resultat esperat: la càmera gira correctament  
- Resultat real: correcte  

---

## TEST 3 - Sistema de disparo
- Objectiu: comprovar que el jugador pot disparar  
- Acció: fer clic esquerre  
- Resultat esperat: apareix una bala i es mou cap endavant  
- Resultat real: correcte  

---

## TEST 4 - Col·lisió amb dianes
- Objectiu: comprovar detecció de col·lisions  
- Acció: disparar a una diana  
- Resultat esperat: la diana desapareix i la bala també  
- Resultat real: correcte  

---

## TEST 5 - Sistema de puntuació
- Objectiu: comprovar que el score augmenta  
- Acció: encertar una diana  
- Resultat esperat: el score augmenta en 1 punt  
- Resultat real: correcte  

---

## TEST 6 - Temporitzador
- Objectiu: comprovar el sistema de temps  
- Acció: deixar passar el temps  
- Resultat esperat: el temps baixa fins a 0  
- Resultat real: correcte  

---

## TEST 7 - Condició de victòria
- Objectiu: comprovar la victòria del jugador  
- Acció: arribar a 3 punts  
- Resultat esperat: el joc mostra victòria i torna al menú principal  
- Resultat real: correcte  

---

## TEST 8 - Condició de derrota
- Objectiu: comprovar la derrota per temps  
- Acció: deixar que el temps arribi a 0 sense arribar a 3 punts  
- Resultat esperat: el jugador perd i torna al menú principal  
- Resultat real: correcte  

---

## Incidències trobades

- La bala no detectava correctament les dianes → solucionat ajustant colliders i triggers  
- Problemes amb la direcció del projectil → solucionado ajustant la rotació del prefab  
- Problemes inicials amb el sistema de col·lisions → corregit amb Rigidbody i configuració correcta de Unity  