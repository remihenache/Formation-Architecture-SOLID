# Exercice sur le Principe de Responsabilité Unique (SRP)

## Contexte
Vous avez une classe `Employee` dans une application de paie. Cette classe contient trois méthodes : `CalculatePay()`, `ReportHours()`, et `Save()`. Cette classe viole le Principe de Responsabilité Unique (SRP) car elle sert différents acteurs : le département comptable, les ressources humaines et les administrateurs de base de données. Les méthodes partagent un algorithme commun `RegularHours()`, ce qui a causé des problèmes en raison d'un changement dans son implémentation affectant plusieurs fonctionnalités.

## Tâche
Votre tâche est de refactoriser la classe `Employee` pour qu'elle adhère au SRP. Assurez-vous que chaque acteur ait ses besoins servis par des classes séparées pour éviter la duplication accidentelle des responsabilités et les problèmes qu'elle cause.

### Étapes
1. Identifiez les responsabilités qui doivent être séparées.
2. Créez de nouvelles classes qui encapsulent ces responsabilités.
3. Assurez-vous que les changements dans une classe n'affectent pas les fonctionnalités des autres.
4. Bonus : Proposez une manière de gérer des fonctionnalités partagées comme `RegularHours()` d'une manière qui respecte le SRP.
