Nom du jeu : Capsule Trigger
Developpé par : Jean Durand
Inspiré de : Johnny Trigger
Temps pour la réalisation : 5h


Points qui ont posé des difficultées : 
  - La physique et le ralenti :
Pour faire le ralenti j'ai utilisé Time.timescale et Time.fixedDeltaTime
Le problème est que la phyisque a totalement changé : les sauts était beaucoup moins longs
Pour résoudre ça j'ai utilisé le ForceMode.Impulse dans mes AddForce.
J'avais déja utilisé séparément les AddForce et le changement du temps avec Time.timeScale mais jamais combiné les deux donc
je ne saivais pas que ce problème existait


Points que je pense pouvoir améliorer :
  - Limiter a un nombre de balles (oui, sans cette limitation, le jeu est très facile)
  - Ajouter des checkpoints entre les sauts

  
Ce que je ferais si je devais pousser projet un cran plus loin :
  - Ajouter d'autres fonctionnalitées comme dans le jeu existant (Barils explosifs, Civils, Autres armes...)
  - Ajouter un menu pour jouer, changer des option, choisir un niveau...
  - Ajouter des vrais graphismes
  - Faire des sauts de hauteur différents


Ce que j'en ai pensé :
  - C'était un projet plaisant à réaliser
  - Le résultat me satisfait pour 5h de réalisation

Mes commentaires :
  - J'ai essayé de faire en sorte que la création de nouveaux niveaux soit facilitée avec les préfabs