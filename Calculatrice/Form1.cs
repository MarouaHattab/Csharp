using System;
using System.Linq;
using System.Windows.Forms;

namespace Calculatrice
{
    public partial class Form1 : Form
    {
        // Variables de mémoire et d'état
        private double memoryValue = 0;  // Valeur stockée en mémoire
        private bool isMemorySet = false;  // Indique si la mémoire contient une valeur
        private bool isNewNumber = true;  // Détermine si un nouveau nombre est saisi
        private string currentExpression = "";  // Expression mathématique en cours

        // Constructeur du formulaire
        public Form1()
        {
            InitializeComponent();
            RegisterEventHandlers();  // Enregistre les gestionnaires d'événements pour les boutons
            labelM.Visible = false;  // Cache le label M initialement (utilisé pour indiquer la mémoire)
        }

        // Méthode pour enregistrer tous les gestionnaires d'événements pour les boutons
        private void RegisterEventHandlers()
        {
            // Enregistrement des événements pour les boutons de chiffres
            btn0.Click += (s, e) => NumberButton_Click("0");
            btn1.Click += (s, e) => NumberButton_Click("1");
            btn2.Click += (s, e) => NumberButton_Click("2");
            btn3.Click += (s, e) => NumberButton_Click("3");
            btn4.Click += (s, e) => NumberButton_Click("4");
            btn5.Click += (s, e) => NumberButton_Click("5");
            btn6.Click += (s, e) => NumberButton_Click("6");
            btn7.Click += (s, e) => NumberButton_Click("7");
            btn8.Click += (s, e) => NumberButton_Click("8");
            btn9.Click += (s, e) => NumberButton_Click("9");

            // Enregistrement des événements pour les boutons d'opérateurs
            btnPlus.Click += (s, e) => OperatorButton_Click("+");
            btnMoins.Click += (s, e) => OperatorButton_Click("-");
            btnMultiplier.Click += (s, e) => OperatorButton_Click("*");
            btnDivision.Click += (s, e) => OperatorButton_Click("/");
            btnModulo.Click += (s, e) => PercentButton_Click();
            btnPoint.Click += (s, e) => DecimalButton_Click();
            btnPlusMoin.Click += (s, e) => SignChangeButton_Click();

            // Enregistrement des événements pour les boutons de contrôles
            btnC.Click += (s, e) => ClearButton_Click();
            btnBack.Click += (s, e) => BackspaceButton_Click();
            btnEgale.Click += (s, e) => EqualsButton_Click();

            // Enregistrement des événements pour les boutons de mémoire
            btnMplus.Click += (s, e) => MemoryAdd_Click();
            btnMmoin.Click += (s, e) => MemorySubtract_Click();
            btnMR.Click += (s, e) => MemoryRecall_Click();
            btnMC.Click += (s, e) => MemoryClear_Click();

            // Permet de gérer les entrées clavier
            this.KeyPreview = true;  // Active la gestion des touches avant l'édition du texte
            this.KeyPress += Form1_KeyPress;
        }

        // Gestionnaire d'événements pour les boutons numériques
        private void NumberButton_Click(string number)
        {
            if (isNewNumber)
            {
                currentExpression = number;  // Si c'est un nouveau nombre, on le définit
                isNewNumber = false;  // Indique que ce n'est plus un nouveau nombre
            }
            else
            {
                currentExpression += number;  // Ajoute le chiffre à l'expression en cours
            }
            UpdateDisplay();  // Met à jour l'affichage
        }

        // Gestionnaire d'événements pour le bouton décimal
        private void DecimalButton_Click()
        {
            if (CanAddDecimal())  // Vérifie si un point peut être ajouté
            {
                if (isNewNumber)
                {
                    currentExpression = "0.";  // Si c'est un nouveau nombre, commence par "0."
                    isNewNumber = false;
                }
                else
                {
                    currentExpression += ".";  // Sinon, ajoute simplement le point
                }
                UpdateDisplay();
            }
        }

        // Méthode pour vérifier si un point peut être ajouté à l'expression en cours
        private bool CanAddDecimal()
        {
            var parts = currentExpression.Split(new[] { '+', '-', '*', '/' });
            return !parts.Last().Contains(".");  // Vérifie que la dernière partie de l'expression ne contient pas déjà un point
        }

        // Gestionnaire d'événements pour les boutons opérateurs
        private void OperatorButton_Click(string op)
        {
            if (currentExpression.Length == 0) return;  // Ne fait rien si l'expression est vide

            char lastChar = currentExpression[^1];  // Récupère le dernier caractère de l'expression
            if ("+-*/".Contains(lastChar.ToString()))
            {
                currentExpression = currentExpression[0..^1] + op;  // Remplace l'opérateur si c'est déjà un opérateur
            }
            else
            {
                currentExpression += op;  // Sinon, ajoute l'opérateur à la fin
                isNewNumber = false;
            }
            UpdateDisplay();  // Met à jour l'affichage
        }

        // Gestionnaire d'événements pour le bouton égal
        private void EqualsButton_Click()
        {
            if (string.IsNullOrEmpty(currentExpression)) return;  // Vérifie si l'expression est vide

            if (HasDivisionByZero() || !IsValidExpression())
            {
                ShowError("Expression invalide ou division par zéro");
                ClearButton_Click();  // Efface l'expression si erreur
                return;
            }

            var result = EvaluateExpression();  // Évalue l'expression
            if (double.IsInfinity(result) || double.IsNaN(result))  // Vérifie si le résultat est valide
            {
                ShowError("Résultat non valide");
                ClearButton_Click();
                return;
            }

            currentExpression = result.ToString();  // Met à jour l'expression avec le résultat
            isNewNumber = true;
            UpdateDisplay();  // Met à jour l'affichage
        }

        // Vérifie s'il y a une division par zéro dans l'expression
        private bool HasDivisionByZero()
        {
            return currentExpression.Split('/').Skip(1).Any(part => IsZero(part.Trim()));  // Vérifie si l'une des divisions contient zéro
        }

        // Vérifie si une chaîne représente le nombre zéro
        private bool IsZero(string number)
        {
            return double.TryParse(number, out double value) && Math.Abs(value) < double.Epsilon;
        }

        // Vérifie si l'expression est valide
        private bool IsValidExpression()
        {
            var validChars = "0123456789+-*/. ";
            return currentExpression.All(c => validChars.Contains(c)) &&
                   currentExpression.Count(c => "+-*/".Contains(c.ToString())) > 0;  // Vérifie les caractères valides et la présence d'opérateurs
        }

        // Évalue l'expression mathématique
        private double EvaluateExpression()
        {
            var parts = currentExpression.Split(new[] { '+', '-', '*', '/' });
            if (parts.Length != 2) return 0;

            if (!double.TryParse(parts[0], out double num1) ||
                !double.TryParse(parts[1], out double num2))
            {
                return 0;
            }

            char op = currentExpression.FirstOrDefault(c => "+-*/".Contains(c.ToString()));
            switch (op)
            {
                case '+': return num1 + num2;
                case '-': return num1 - num2;
                case '*': return num1 * num2;
                case '/': return num2 == 0 ? double.NaN : num1 / num2;
                default: return 0;
            }
        }

        // Met à jour l'affichage du résultat dans le textbox
        private void UpdateDisplay()
        {
            txtAffichage.Text = currentExpression;
        }

        // Gestionnaire du bouton C pour effacer l'expression
        private void ClearButton_Click()
        {
            currentExpression = "";
            isNewNumber = true;
            UpdateDisplay();
        }

        // Gestionnaire du bouton de suppression (backspace)
        private void BackspaceButton_Click()
        {
            if (currentExpression.Length > 0)
            {
                currentExpression = currentExpression[0..^1];  // Supprime le dernier caractère
                if (currentExpression.Length == 0) isNewNumber = true;
                UpdateDisplay();
            }
        }

        // Gestionnaire du bouton pour le pourcentage
        private void PercentButton_Click()
        {
            if (!string.IsNullOrEmpty(currentExpression) && IsValidNumber(currentExpression))
            {
                double number = double.Parse(currentExpression);
                currentExpression = (number / 100).ToString();
                UpdateDisplay();
            }
        }

        // Gestionnaire pour changer le signe du nombre
        private void SignChangeButton_Click()
        {
            if (!string.IsNullOrEmpty(currentExpression) && currentExpression != "0" && IsValidNumber(currentExpression))
            {
                double number = double.Parse(currentExpression);
                currentExpression = (-number).ToString();
                UpdateDisplay();
            }
        }

        // Méthodes pour la gestion de la mémoire
        private void MemoryAdd_Click()
        {
            if (IsValidNumber(currentExpression))
            {
                memoryValue += double.Parse(currentExpression);
                isMemorySet = true;
                labelM.Visible = true;  // Affiche l'indicateur de mémoire
            }
            else
            {
                ShowError("Valeur invalide pour la mémoire");
            }
        }

        private void MemorySubtract_Click()
        {
            if (IsValidNumber(currentExpression))
            {
                memoryValue -= double.Parse(currentExpression);
                isMemorySet = true;
                labelM.Visible = true;
            }
            else
            {
                ShowError("Valeur invalide pour la mémoire");
            }
        }

        private void MemoryRecall_Click()
        {
            if (isMemorySet)
            {
                currentExpression = memoryValue.ToString();
                UpdateDisplay();
                isNewNumber = true;
            }
        }

        private void MemoryClear_Click()
        {
            memoryValue = 0;
            isMemorySet = false;
            labelM.Visible = false;
        }

        // Vérifie si l'entrée est un nombre valide
        private bool IsValidNumber(string input)
        {
            return double.TryParse(input, out _);
        }

        // Affiche un message d'erreur
        private void ShowError(string message)
        {
            txtAffichage.Text = "Erreur";
            MessageBox.Show(message, "Erreur",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        // Gère les entrées clavier
        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!IsAllowedKey(e.KeyChar))
            {
                e.Handled = true;
                return;
            }

            switch (e.KeyChar)
            {
                case var c when char.IsDigit(c):
                    NumberButton_Click(c.ToString());
                    break;
                case '+':
                case '-':
                case '*':
                case '/':
                    OperatorButton_Click(e.KeyChar.ToString());
                    break;
                case '.':
                case ',':
                    DecimalButton_Click();
                    break;
                case (char)13: // Enter
                    EqualsButton_Click();
                    break;
                case (char)8: // Backspace
                    BackspaceButton_Click();
                    break;
                default:
                    e.Handled = true;
                    break;
            }
        }

        // Vérifie si la touche appuyée est autorisée
        private bool IsAllowedKey(char key)
        {
            return char.IsDigit(key) ||
                   "+-*/.,".Contains(key) ||
                   key == (char)Keys.Back ||
                   key == (char)Keys.Enter;
        }
        private void txtAffichage_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}
