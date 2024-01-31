# Exercice sur le Principe Ouvert/Fermé (OCP)

## Contexte
Vous avez une classe `FinancialSummary` qui affiche un résumé financier. 
Actuellement, elle ne fait que présenter les données sur une page web, mais l'objectif est de la rendre extensible pour supporter différents formats de présentation (comme l'affichage web, le rapport imprimé, etc.) sans modifier le code existant.

## Tâche
Votre mission est de refactoriser la classe `FinancialSummary` pour qu'elle suive le Principe Ouvert/Fermé. La classe devrait être extensible pour supporter différents formats de présentation des données financières, tout en évitant la modification du code existant.

### Étapes
1. Séparer le fournisseur de données (`DataProvider`) et l'afficheur de données (`DataDisplayer`).
2. Créer une interface ou une classe abstraite pour la présentation des données financières.
3. Implémenter cette interface dans des classes séparées pour chaque format de présentation (par exemple, `WebFinancialSummary`, `PrintFinancialSummary`).
4. Utiliser un patron de stratégie ou une approche similaire pour choisir dynamiquement le format de présentation.
