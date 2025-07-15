✅ 1. 🔧 Configuration de base du projet
🔹 Initialisation

    Crée un projet via :

dotnet new webapi -n MonApi

    Configure le projet dans Program.cs (routing, services, etc.)

🔹 Connexion à la base de données

    Utilise Entity Framework Core

    Configure ta connection string dans appsettings.json

    Ajoute un DbContext dédié (AppDbContext)

    Fais une migration :

dotnet ef migrations add InitialCreate
dotnet ef database update

✅ 2. 📦 Structure propre du code
🔹 Dossiers recommandés :

/Models         → Entités EF (User, Classe, etc.)
/DTOs           → Objets de transfert (UserDTO, ClasseDTO)
/Mappers        → Conversion Entité ⇄ DTO
/Endpoints      → Routes regroupées par domaine
/Data           → DbContext

🔹 DTO obligatoire !

Ne retourne jamais directement les entités EF dans les controllers.
➡️ Utilise des DTOs (ex : UserReadDTO, UserCreateDTO)
➡️ Les entités EF représentent ta BDD, pas ton API publique.
✅ 3. ♻️ Architecture et dépendances
🔹 “Pas de dépendance inverse entre Web et Core”

    Ton domaine (Core) ne doit jamais référencer le projet Web/API

    API → App → Infrastructure
    Mais jamais l'inverse

🔹 Principe général :

    Controllers/Endpoints = couche d’exposition

    Services = logique métier (optionnel pour petits projets)

    DbContext = accès données

✅ 4. 🔐 Authentification avec JWT

    Implémente un système d’authentification avec JWT (pour éviter de tout exposer)

    Ne stocke jamais les mots de passe en clair

    Tu peux utiliser :

        Microsoft.AspNetCore.Authentication.JwtBearer

        System.IdentityModel.Tokens.Jwt

✅ 5. 🌐 Routing (Minimal API ou Controllers)
Si tu fais du Minimal API :

    Crée des fichiers par domaine dans /Endpoints (ex: UserEndpoints.cs)

    Dans Program.cs :

app.MapUserEndpoints();

✅ 6. 🛠️ Gestion Git
📌 Bonnes pratiques :

    Pas de push direct sur main
    ➡️ Toujours passer par des Pull Requests (PRs)

    PRs courtes, claires, avec description
    ➡️ Privilégie une fonctionnalité par PR

    Code review = échange constructif
    ➡️ Pas une compétition, on s’entraide

✅ 7. 🧪 Tests & maintenance

    Ajoute des logs (ex : ILogger) pour traquer les erreurs

    Évite le code dupliqué

    Documente les routes avec Swagger (déjà intégré dans WebAPI)

✅ 8. 🧘‍♂️ Bonus bonnes pratiques

    Sépare bien lecture/écriture (DTO différents)

    Utilise async/await pour toutes les opérations I/O

    Valide les entrées utilisateur (ex: [Required], [EmailAddress])

    Utilise les migrations EF pour gérer ton schéma

🧩 To-Do list résumé pour ton projet
Étape	À faire
✅ Initialiser projet	dotnet new webapi
✅ Configurer BDD	EF Core + connection string
✅ Créer entités & DbContext	User, Classe, etc.
✅ Créer DTOs	UserReadDTO, UserCreateDTO, etc.
✅ Créer mappers	UserMapper.cs, etc.
✅ Créer endpoints	/api/users, /api/classes, etc.
✅ Utiliser JWT	Sécuriser les endpoints
✅ Suivre les conventions Git	PRs claires, pas de push direct sur main
✅ Swagger	Tester les routes
