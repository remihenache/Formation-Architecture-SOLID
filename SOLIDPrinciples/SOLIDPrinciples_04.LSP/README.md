# Exercice sur le Principe de Substitution de Liskov (LSP)

## Contexte
L'exercice implique la création d'une classe `FixedTermDepositAccount` dans le cadre d'une application bancaire, en suivant le Principe de Substitution de Liskov (LSP). Cependant, la banque ne veut pas autoriser les retraits pour les comptes de dépôt à terme.

## Tâche
Votre objectif est de développer une nouvelle sous-classe `FixedTermDepositAccount` qui étend la classe de base `Account`. Cette nouvelle classe doit respecter les comportements définis dans la classe `Account` pour respecter le LSP.

### Étapes
1. Examinez les classes existantes `Account`, `SavingsAccount` et `CurrentAccount`.
2. Créez la classe `FixedTermDepositAccount` avec des implémentations appropriées pour les méthodes `Deposit` et `Withdraw`.
3. Assurez-vous que `FixedTermDepositAccount` est substituable à `Account` sans altérer le comportement attendu.
