# Incidències del projecte

Aquest document recull els principals problemes trobats durant el desenvolupament del joc FPS Target Shooter i com s’han solucionat.

---

## Problema 1 - Direcció de les bales incorrecta
- **Descripció:** Les bales no sortien en la direcció correcta.
- **Causa:** Orientació incorrecta del prefab i rotació del spawn.
- **Solució:** Ajust de la rotació del prefab i del punt de disparo.

---

## Problema 2 - Les dianes no es detectaven
- **Descripció:** Les bales impactaven però no destruïen les dianes.
- **Causa:** Configuració incorrecta de colliders i triggers.
- **Solució:** Activar `Is Trigger` i afegir `Rigidbody` correctament.

---

## Problema 3 - Col·lisions inconsistents
- **Descripció:** Algunes col·lisions funcionaven i altres no.
- **Causa:** Diferents configuracions entre prefabs.
- **Solució:** Unificar configuració de colliders en tots els objectes.

---

## Problema 4 - Prefabs importats
- **Descripció:** Materials i objectes importats no es mostraven correctament.
- **Causa:** Materials no assignats després de la importació.
- **Solució:** Reassignació manual dels materials al prefab.

---

## Problema 5 - Sistema de puntuació inicial
- **Descripció:** El score no augmentava correctament al principi.
- **Causa:** Error en la connexió entre diana i ScoreManager.
- **Solució:** Implementació d’un `ScoreManager` amb accés global (singleton).

---

## Conclusió
Les incidències s’han resolt mitjançant proves, depuració i ajustos dins de Unity, millorant el funcionament general del joc.