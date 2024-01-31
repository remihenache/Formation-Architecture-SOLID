# Exercice sur le Principe d'Inversion des Dépendances (DIP)

## Contexte
Cet exercice consiste à refactoriser un code C# pour un système de traitement de commandes. Le code actuel viole le Principe d'Inversion des Dépendances en dépendant directement des implémentations concrètes des services.

## Tâche
Votre objectif est de modifier le système de traitement de commandes pour qu'il respecte le Principe d'Inversion des Dépendances.

### Étapes
1. Analysez le code initial impliquant `OrderProcessingService`, `InventoryService`, `PaymentService` et `ShippingService`.
2. Créez des interfaces pour chaque service (par exemple, `IInventoryService`, `IPaymentService`, `IShippingService`).
3. Adaptez ces services pour qu'ils implémentent leurs interfaces respectives.
4. Modifiez `OrderProcessingService` pour qu'il dépende de ces interfaces et non des implémentations concrètes.
5. Implémentez l'injection de dépendances dans `OrderProcessingService` pour injecter ces services.

### Défi Bonus
- Concevez `OrderProcessingService` pour qu'il soit testable, en utilisant des implémentations fictives (mocks) des services.
