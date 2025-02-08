# 🧮 Calculatrice en C#

Bienvenue dans l'application **Calculatrice** en C# développée avec Windows Forms ! 🎉 Cette application vous permet de réaliser des calculs simples et avancés, de gérer une mémoire de calcul, et d'utiliser un clavier virtuel et physique pour interagir avec l'interface. 💻

## Fonctionnalités principales ✨

- **Calculs de base** : Addition, soustraction, multiplication, division, et modulo.
- **Calculs avancés** : Pourcentage (%) et changement de signe.
- **Gestion de la mémoire** : Ajouter, soustraire, rappeler et effacer une valeur mémorisée.
- **Clavier virtuel et clavier physique** : Vous pouvez utiliser les boutons à l'écran ou les touches du clavier pour effectuer des calculs.
- **Affichage dynamique** : L'expression courante est affichée en temps réel, et le résultat final est calculé lorsque vous appuyez sur le bouton égal (=) ou la touche `Enter`.

### Prérequis

- Visual Studio 2019 ou une version ultérieure.
- .NET Framework 4.7.2 ou une version supérieure.

### 🛠 Étapes d'installation

1. Clonez ou téléchargez le projet sur votre machine locale.

   ```bash
   git clone https://github.com/MarouaHattab/Csharp.git/Calculatrice
    ```
2. Ouvrez le projet dans Visual Studio.

3. Compilez le projet pour générer l'exécutable.

4. Lancez l'application.

### 🚀 Utilisation

- Saisie de nombres et opérateurs ➕
- Cliquez sur les boutons 0-9 pour entrer des nombres.
- Cliquez sur les boutons des opérateurs +, -, *, / pour effectuer des opérations.
- C pour effacer l'expression.
- Backspace pour supprimer le dernier caractère.
- . pour ajouter un point décimal.
- = ou Enter pour calculer le résultat.

### Exemple de calcul 🔢
1. Entrez 2, puis appuyez sur +.
2. Entrez 3, puis appuyez sur =.
**Le résultat 5 sera affiché dans la zone d'affichage. 🎉**
### Calcul de pourcentage 💯
1. Entrez 50, puis appuyez sur %.
**Le résultat 0.5 sera affiché (50% de 100).**
### Gestion de la mémoire 💾
1. Entrez un nombre, par exemple 10, puis appuyez sur M+ pour ajouter ce nombre à la mémoire.
2. Entrez un autre nombre, par exemple 5, puis appuyez sur M+ pour ajouter ce nombre à la mémoire.
3. Appuyez sur MR pour rappeler la mémoire, et le résultat 15 sera affiché.

## Affichage de la sortie de l'application 🖥 ##
Lorsque vous effectuez un calcul, le résultat est affiché dans la zone de texte txtAffichage. Voici un exemple visuel de l'affichage de l'application après un calcul de base.


Sur l'image ci-dessus :

![output](/img/output.png)


L'expression courante est affichée en haut.
Le résultat du calcul est montré dans la même zone après avoir appuyé sur = ou Enter.

### 💡 Gestion des erreurs
L'application gère les erreurs de manière à éviter des calculs invalides :

**Division par zéro** : Un message d'erreur est affiché si une division par zéro est tentée.
**Expression invalide** : Si l'expression est incorrecte ou contient des caractères invalides, un message d'erreur est affiché.

