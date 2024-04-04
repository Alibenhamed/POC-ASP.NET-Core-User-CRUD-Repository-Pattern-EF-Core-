# POC-ASP.NET-Core-User-CRUD-Repository-Pattern-EF-Core

Ce projet est une démonstration (Proof of Concept) d'une API CRUD (Create, Read, Update, Delete) pour la gestion des utilisateurs, développée en utilisant ASP.NET Core, le modèle de conception Repository Pattern et Entity Framework Core (EF Core).

Fonctionnalités
- CRUD pour les utilisateurs : L'API fournit des endpoints permettant de créer, lire, mettre à jour et supprimer des utilisateurs dans une base de données.
- Modèle Repository Pattern : Utilisation du modèle de conception Repository Pattern pour abstraire la logique d'accès aux données et rendre l'application plus modulaire et testable.
- EF Core : Utilisation d'Entity Framework Core comme ORM (Object-Relational Mapping) pour interagir avec la base de données.
- Swagger/OpenAPI : Intégration de Swagger pour la documentation et l'exploration interactive des API.

Structure du projet
Le projet est organisé comme suit :

UserAPI : Projet principal de l'API ASP.NET Core.
- Controllers : Contient les contrôleurs API pour gérer les requêtes HTTP.
- Models : Définit les modèles de données pour les utilisateurs.
- Services : Contient les services pour la logique métier de gestion des utilisateurs.
- Repositories : Implémente le modèle Repository Pattern pour l'accès aux données.
- UserAPI.DAL : Projet pour l'accès aux données avec EF Core.
- Entities : Contient les entités de base de données (classes modèles EF Core).
- Migrations : Contient les migrations EF Core pour la gestion de la base de données.
- DbContext : Classe DbContext pour la configuration d'EF Core.

UserAPI.BLL : Projet pour la logique métier.
- Interfaces : Définit les interfaces des services et des repositories.
- Implementations : Implémente les services et les repositories.
- UserAPI.Tests : Projet de tests unitaires.

Prérequis :
.NET 6 SDK
-SQL Server 

Configuration : 
- Cloner ce dépôt.
- Ouvrir le projet dans un environnement de développement compatible avec .NET 6.
- Configurer la chaîne de connexion à la base de données dans appsettings.json du projet UserAPI.DAL.
- Exécuter les migrations EF Core pour créer la base de données : dotnet ef database update depuis le répertoire racine du projet.

Utilisation :
- Lancer l'application.
- Accéder à l'URL https://localhost:{PORT}/swagger pour explorer les API avec Swagger.
