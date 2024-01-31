# Exercice sur le Principe de Ségrégation des Interfaces (ISP)

## Contexte
L'exercice implique la refactorisation d'un code C# pour respecter le Principe de Ségrégation des Interfaces (ISP). Le code actuel viole ISP en obligeant les classes `Developer` et `TeamLead` à implémenter des méthodes inutiles pour leur rôle.

## Tâche
Votre objectif est de refactoriser le code pour séparer l'interface `IWork` en interfaces plus petites et spécifiques à chaque rôle.

### Étapes
1. Analysez le code initial avec l'interface `IWork` et ses implémenteurs.
2. Créez des interfaces distinctes pour chaque groupe de responsabilités : codage, test, conception architecturale et gestion d'équipe.
3. Refactorisez les classes `Developer` et `TeamLead` pour qu'elles implémentent uniquement les interfaces qui sont pertinentes pour leur rôle.
