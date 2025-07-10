# SQL Cheatsheet

## 📋 Requêtes de base

### SELECT - Sélectionner des données
```sql
-- Sélectionner des colonnes spécifiques
SELECT colonne1, colonne2 FROM table;

-- Sélectionner toutes les colonnes (*)
SELECT * FROM table WHERE condition;

-- Exemple concret
SELECT nom, email FROM users WHERE age > 18;  -- Récupère nom et email des utilisateurs majeurs
```

### INSERT - Insérer des données
```sql
-- Insérer une nouvelle ligne en spécifiant les colonnes
INSERT INTO table (col1, col2) VALUES (val1, val2);

-- Exemple concret
INSERT INTO users (nom, email, age) VALUES ('Marie', 'marie@email.com', 25);  -- Ajoute un nouvel utilisateur
```

### UPDATE - Modifier des données
```sql
-- Modifier une ou plusieurs colonnes selon une condition
UPDATE table SET colonne = nouvelle_valeur WHERE condition;

-- Exemple concret
UPDATE users SET age = 26 WHERE nom = 'Marie';  -- Change l'âge de Marie à 26
```

### DELETE - Supprimer des données
```sql
-- Supprimer des lignes selon une condition
DELETE FROM table WHERE condition;

-- Exemple concret
DELETE FROM users WHERE age < 18;  -- Supprime tous les utilisateurs mineurs
```

## 🔍 Filtres et conditions

### WHERE - Conditions
```sql
-- Condition simple
WHERE age > 18                            -- Utilisateurs majeurs

-- Conditions multiples avec AND/OR
WHERE nom = 'Jean' AND ville = 'Paris'    -- Jean ET habite Paris
WHERE age < 18 OR age > 65               -- Mineurs OU seniors

-- Plage de valeurs
WHERE age BETWEEN 20 AND 30              -- Entre 20 et 30 ans inclus

-- Liste de valeurs
WHERE ville IN ('Paris', 'Lyon', 'Marseille')  -- Habite dans une de ces villes
```

### LIKE - Recherche avec caractères génériques
```sql
-- % représente n'importe quelle suite de caractères
WHERE nom LIKE 'Jean%'                    -- Commence par Jean (Jean, Jeanne, etc.)
WHERE email LIKE '%@gmail.com'            -- Finit par @gmail.com
WHERE nom LIKE '%marie%'                  -- Contient marie quelque part

-- _ représente exactement un caractère
WHERE nom LIKE '_ean'                     -- 4 lettres finissant par ean (Jean, Sean, etc.)
```

### NULL
```sql
-- Vérifier si une valeur est vide
WHERE colonne IS NULL                     -- Colonne vide
WHERE colonne IS NOT NULL                 -- Colonne pas vide

-- Attention : ne pas utiliser = NULL ou != NULL
```

## 🔗 Jointures

### INNER JOIN - Intersection
```sql
-- Récupère seulement les lignes qui correspondent dans les deux tables
SELECT u.nom, c.total 
FROM users u 
INNER JOIN commandes c ON u.id = c.user_id;  -- Seuls les users qui ont des commandes
```

### LEFT JOIN - Tous les éléments de gauche
```sql
-- Récupère tous les utilisateurs, même ceux sans commandes
SELECT u.nom, c.total 
FROM users u 
LEFT JOIN commandes c ON u.id = c.user_id;   -- Tous les users + leurs commandes (si elles existent)
```

### RIGHT JOIN - Tous les éléments de droite
```sql
-- Récupère toutes les commandes, même celles sans utilisateur valide
SELECT u.nom, c.total 
FROM users u 
RIGHT JOIN commandes c ON u.id = c.user_id;  -- Toutes les commandes + leurs users (si ils existent)
```

## 🔢 Fonctions d'agrégation

### Fonctions de base
```sql
-- Compter le nombre de lignes
SELECT COUNT(*) FROM table;               -- Compte toutes les lignes
SELECT COUNT(colonne) FROM table;         -- Compte les lignes non-NULL de cette colonne

-- Calculer des totaux et moyennes
SELECT SUM(prix) FROM produits;           -- Somme de tous les prix
SELECT AVG(age) FROM users;               -- Âge moyen des utilisateurs
SELECT MAX(prix) FROM produits;           -- Prix le plus élevé
SELECT MIN(prix) FROM produits;           -- Prix le plus bas
```

### GROUP BY - Regroupement
```sql
-- Regrouper par ville pour compter les utilisateurs de chaque ville
SELECT ville, COUNT(*) 
FROM users 
GROUP BY ville;

-- Filtrer les groupes avec HAVING (comme WHERE mais pour les groupes)
SELECT ville, COUNT(*) 
FROM users 
GROUP BY ville 
HAVING COUNT(*) > 5;                      -- Seulement les villes avec plus de 5 utilisateurs
```

## 📊 Tri et limitation

### ORDER BY - Trier
```sql
-- Tri par défaut : croissant (A-Z, 1-9)
SELECT * FROM users ORDER BY age;           -- Du plus jeune au plus âgé

-- Tri décroissant avec DESC
SELECT * FROM users ORDER BY age DESC;      -- Du plus âgé au plus jeune

-- Tri sur plusieurs colonnes
SELECT * FROM users ORDER BY nom, age DESC; -- D'abord par nom (A-Z), puis par âge (décroissant)
```

### LIMIT - Limiter les résultats
```sql
-- Récupérer seulement les 10 premiers résultats
SELECT * FROM users LIMIT 10;              

-- Pagination : sauter les 20 premiers, puis prendre 10
SELECT * FROM users LIMIT 10 OFFSET 20;    -- Résultats 21 à 30

-- Exemple pratique : top 5 des produits les plus chers
SELECT nom, prix FROM produits ORDER BY prix DESC LIMIT 5;
```

## 🏗️ Gestion des tables

### CREATE TABLE - Créer une table
```sql
CREATE TABLE users (
    id INT PRIMARY KEY,                     -- Clé primaire (unique, non vide)
    nom VARCHAR(50) NOT NULL,               -- Chaîne de 50 caractères max, obligatoire
    email VARCHAR(100) UNIQUE,              -- Email unique dans la table
    age INT,                                -- Age optionnel
    created_at TIMESTAMP DEFAULT CURRENT_TIMESTAMP  -- Date de création automatique
);
```

### ALTER TABLE - Modifier une table
```sql
-- Ajouter une nouvelle colonne
ALTER TABLE users ADD COLUMN telephone VARCHAR(20);

-- Supprimer une colonne
ALTER TABLE users DROP COLUMN age;

-- Modifier le type d'une colonne existante
ALTER TABLE users MODIFY COLUMN nom VARCHAR(100);
```

### DROP TABLE - Supprimer une table
```sql
-- Attention : supprime définitivement la table et toutes ses données !
DROP TABLE users;
```

## 📝 Types de données courants

- **INT** - Nombre entier
- **VARCHAR(n)** - Chaîne de caractères (max n caractères)
- **TEXT** - Texte long
- **DATE** - Date (YYYY-MM-DD)
- **TIMESTAMP** - Date et heure
- **BOOLEAN** - Vrai/Faux
- **DECIMAL(p,s)** - Nombre décimal (p chiffres, s après virgule)

## 🔑 Contraintes

```sql
PRIMARY KEY    -- Clé primaire
NOT NULL       -- Ne peut pas être vide
UNIQUE         -- Valeurs uniques
DEFAULT val    -- Valeur par défaut
CHECK (condition) -- Contrainte personnalisée
```

## 💡 Conseils pratiques

- Toujours terminer les requêtes par `;`
- Utiliser des alias pour simplifier : `SELECT u.nom FROM users u`
- Tester sur un petit échantillon avant de faire des modifications importantes
- Faire des sauvegardes avant les UPDATE/DELETE massifs
- Utiliser des index sur les colonnes souvent utilisées dans WHERE

## 🚀 Exemples pratiques

```sql
-- Trouver les utilisateurs actifs de Paris
SELECT nom, email 
FROM users 
WHERE ville = 'Paris' AND statut = 'actif';     -- Condition ET : doit habiter Paris ET être actif

-- Top 5 des produits les plus chers
SELECT nom, prix 
FROM produits 
ORDER BY prix DESC                               -- Trier par prix décroissant
LIMIT 5;                                        -- Prendre seulement les 5 premiers

-- Nombre de commandes par utilisateur (même ceux sans commandes)
SELECT u.nom, COUNT(c.id) as nb_commandes
FROM users u
LEFT JOIN commandes c ON u.id = c.user_id      -- LEFT JOIN pour inclure tous les users
GROUP BY u.id, u.nom;                          -- Regrouper par utilisateur

-- Utilisateurs qui ont commandé plus de 100€
SELECT u.nom, SUM(c.total) as total_depense
FROM users u
INNER JOIN commandes c ON u.id = c.user_id     -- INNER JOIN car on veut seulement ceux qui ont commandé
GROUP BY u.id, u.nom                           -- Regrouper par utilisateur
HAVING SUM(c.total) > 100;                     -- Filtrer les groupes : total > 100€

-- Produits jamais commandés
SELECT p.nom
FROM produits p
LEFT JOIN commandes_items ci ON p.id = ci.produit_id
WHERE ci.produit_id IS NULL;                   -- Pas de correspondance = jamais commandé
```