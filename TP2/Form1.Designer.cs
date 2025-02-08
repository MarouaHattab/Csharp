namespace TP2
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            labelNom = new Label();
            textBoxNom = new TextBox();
            labelMessage = new Label();
            buttonAfficher = new Button();
            radioButtonM = new RadioButton();
            radioButtonF = new RadioButton();
            groupBox1 = new GroupBox();
            checkBox2 = new CheckBox();
            checkBox1 = new CheckBox();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // labelNom
            // 
            labelNom.AutoSize = true;
            labelNom.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelNom.Location = new Point(56, 17);
            labelNom.Name = "labelNom";
            labelNom.Size = new Size(65, 28);
            labelNom.TabIndex = 0;
            labelNom.Text = "Nom :";
            labelNom.Click += label1_Click;
            // 
            // textBoxNom
            // 
            textBoxNom.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBoxNom.Location = new Point(148, 16);
            textBoxNom.Name = "textBoxNom";
            textBoxNom.Size = new Size(191, 34);
            textBoxNom.TabIndex = 1;
            textBoxNom.TextChanged += textBoxNom_TextChanged;
            // 
            // labelMessage
            // 
            labelMessage.AutoSize = true;
            labelMessage.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelMessage.ForeColor = SystemColors.MenuHighlight;
            labelMessage.Location = new Point(164, 86);
            labelMessage.Name = "labelMessage";
            labelMessage.Size = new Size(0, 28);
            labelMessage.TabIndex = 3;
            labelMessage.Click += label2_Click;
            // 
            // buttonAfficher
            // 
            buttonAfficher.Location = new Point(414, 16);
            buttonAfficher.Name = "buttonAfficher";
            buttonAfficher.Size = new Size(128, 34);
            buttonAfficher.TabIndex = 4;
            buttonAfficher.Text = "Afficher";
            buttonAfficher.UseVisualStyleBackColor = true;
            buttonAfficher.Click += buttonAfficher_Click_1;
            // 
            // radioButtonM
            // 
            radioButtonM.AutoSize = true;
            radioButtonM.Location = new Point(290, 42);
            radioButtonM.Name = "radioButtonM";
            radioButtonM.Size = new Size(88, 24);
            radioButtonM.TabIndex = 5;
            radioButtonM.TabStop = true;
            radioButtonM.Text = "Masculin";
            radioButtonM.UseVisualStyleBackColor = true;
            // 
            // radioButtonF
            // 
            radioButtonF.AutoSize = true;
            radioButtonF.Location = new Point(69, 42);
            radioButtonF.Name = "radioButtonF";
            radioButtonF.Size = new Size(82, 24);
            radioButtonF.TabIndex = 6;
            radioButtonF.TabStop = true;
            radioButtonF.Text = "Feminin";
            radioButtonF.UseVisualStyleBackColor = true;
            radioButtonF.CheckedChanged += radioButton2_CheckedChanged;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(checkBox2);
            groupBox1.Controls.Add(checkBox1);
            groupBox1.Controls.Add(radioButtonF);
            groupBox1.Controls.Add(radioButtonM);
            groupBox1.Location = new Point(56, 115);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(474, 128);
            groupBox1.TabIndex = 7;
            groupBox1.TabStop = false;
            groupBox1.Text = "Genre";
            // 
            // checkBox2
            // 
            checkBox2.AutoSize = true;
            checkBox2.Location = new Point(277, 88);
            checkBox2.Name = "checkBox2";
            checkBox2.Size = new Size(89, 24);
            checkBox2.TabIndex = 8;
            checkBox2.Text = "Option 2";
            checkBox2.UseVisualStyleBackColor = true;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(60, 88);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(89, 24);
            checkBox1.TabIndex = 7;
            checkBox1.Text = "Option 2";
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(groupBox1);
            Controls.Add(buttonAfficher);
            Controls.Add(labelMessage);
            Controls.Add(textBoxNom);
            Controls.Add(labelNom);
            Name = "Form1";
            Text = "Activite1";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelNom;
        private TextBox textBoxNom;
        private Label labelMessage;
        private Button buttonAfficher;
        private RadioButton radioButtonM;
        private RadioButton radioButtonF;
        private GroupBox groupBox1;
        private CheckBox checkBox2;
        private CheckBox checkBox1;
    }
}
