# Challenge – Saisie d’usines, quantités et produits (C#)

## Description

Ce projet est une application console en C# qui permet de saisir des informations liées à plusieurs usines (ou villes) :

- la liste des villes/usines
- le nombre de produits fabriqués dans chaque ville
- le nom des produits fabriqués

Le programme stocke les données dans des tableaux, puis affiche un récapitulatif à la fin.

---

## Fonctionnement

1. L’utilisateur saisit le nombre d’usines (villes) à enregistrer.
2. Le programme demande ensuite le nom de chaque ville.
3. Pour chaque ville, l’utilisateur saisit le nombre de produits fabriqués.
4. Le programme calcule le total de produits (toutes villes confondues).
5. Il demande ensuite de saisir le nom de chaque produit, en fonction des quantités indiquées par ville.
6. Enfin, il affiche trois lignes :
   - le tableau des villes
   - le tableau des quantités par ville
   - le tableau de tous les produits saisis

Remarque : si une ville a `0` produit, le programme place `"0"` dans le tableau des produits.

---

## Technologies utilisées

- Langage : C#
- Framework : .NET
- Type d’application : Application console
- IDE conseillé : Visual Studio 2022

---

## Prérequis

- Windows
- Visual Studio 2022 installé
- .NET SDK compatible

---

## Exécution

1. Ouvrir le projet dans Visual Studio 2022
2. Lancer l’application :
   - F5 (avec débogage)
   - ou Ctrl + F5 (sans débogage)

---

## Exemple d’utilisation

- Nombre d’usines : 2
- Villes : PARIS, LYON
- Quantités : 2 pour PARIS, 1 pour LYON
- Produits : VIS, ECROU, BOULON

Sortie (exemple) :

- `[ PARIS ] [ LYON ]`
- `[ 2 ] [ 1 ]`
- `[ VIS ] [ ECROU ] [ BOULON ]`

---

## Structure (typique)

Program.cs

## Auteur

Karadag Nissa

---

## Licence

Projet pédagogique / exercice. 
Licence MIT 
