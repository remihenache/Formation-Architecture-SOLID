# Exercice sur le Principe de Responsabilité Unique (SRP)

## Contexte
Vous avez une classe `BikeSalesManager` dans une application de vente de vélos. Cette classe gère actuellement l'ensemble du processus de vente, y compris le calcul du coût total, la mise à jour de l'inventaire et la génération de factures. Cette conception viole le Principe de Responsabilité Unique (SRP).

## Tâche
Votre mission est de refactoriser la classe `BikeSalesManager` pour qu'elle respecte le SRP. Chaque fonctionnalité (calcul du coût, gestion de l'inventaire, génération de factures) devrait être gérée par une classe distincte.

### Étapes
1. Identifier les différentes responsabilités dans la classe `BikeSalesManager`.
2. Créer des classes séparées pour chaque responsabilité :
    - `BikeCostCalculator` pour le calcul du coût.
    - `InventoryManager` pour la gestion de l'inventaire.
    - `InvoiceGenerator` pour la génération de factures.
3. Refactoriser le code pour utiliser ces nouvelles classes dans le processus de vente.
