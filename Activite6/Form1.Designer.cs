﻿namespace Activite6
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
            tableLayoutPanel1 = new TableLayoutPanel();
            pictureBox1 = new PictureBox();
            checkBox1 = new CheckBox();
            flowLayoutPanel1 = new FlowLayoutPanel();
            showButton = new Button();
            clearButton = new Button();
            backgroundButton = new Button();
            closeButton = new Button();
            openFileDialog1 = new OpenFileDialog();
            colorDialog1 = new ColorDialog();
            tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            flowLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 15F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 85F));
            tableLayoutPanel1.Controls.Add(pictureBox1, 0, 0);
            tableLayoutPanel1.Controls.Add(checkBox1, 0, 1);
            tableLayoutPanel1.Controls.Add(flowLayoutPanel1, 1, 1);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 90F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            tableLayoutPanel1.Size = new Size(1136, 541);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            pictureBox1.BorderStyle = BorderStyle.Fixed3D;
            tableLayoutPanel1.SetColumnSpan(pictureBox1, 2);
            pictureBox1.Dock = DockStyle.Fill;
            pictureBox1.Location = new Point(3, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(1130, 480);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(3, 489);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(66, 24);
            checkBox1.TabIndex = 1;
            checkBox1.Text = "Etirer";
            checkBox1.UseVisualStyleBackColor = true;
            checkBox1.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.AutoSize = true;
            flowLayoutPanel1.Controls.Add(showButton);
            flowLayoutPanel1.Controls.Add(clearButton);
            flowLayoutPanel1.Controls.Add(backgroundButton);
            flowLayoutPanel1.Controls.Add(closeButton);
            flowLayoutPanel1.Dock = DockStyle.Fill;
            flowLayoutPanel1.FlowDirection = FlowDirection.RightToLeft;
            flowLayoutPanel1.Location = new Point(173, 489);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(960, 49);
            flowLayoutPanel1.TabIndex = 2;
            // 
            // showButton
            // 
            showButton.AutoSize = true;
            showButton.Location = new Point(788, 3);
            showButton.Name = "showButton";
            showButton.Size = new Size(169, 37);
            showButton.TabIndex = 0;
            showButton.Text = "Afficher une image";
            showButton.UseVisualStyleBackColor = true;
            showButton.Click += showButton_Click;
            // 
            // clearButton
            // 
            clearButton.AutoSize = true;
            clearButton.Location = new Point(625, 3);
            clearButton.Name = "clearButton";
            clearButton.Size = new Size(157, 37);
            clearButton.TabIndex = 1;
            clearButton.Text = "Effacer l'image";
            clearButton.UseVisualStyleBackColor = true;
            clearButton.Click += button2_Click;
            // 
            // backgroundButton
            // 
            backgroundButton.AutoSize = true;
            backgroundButton.Location = new Point(456, 3);
            backgroundButton.Name = "backgroundButton";
            backgroundButton.Size = new Size(163, 37);
            backgroundButton.TabIndex = 2;
            backgroundButton.Text = "Définir la couleur";
            backgroundButton.UseVisualStyleBackColor = true;
            backgroundButton.Click += backgroundButton_Click;
            // 
            // closeButton
            // 
            closeButton.AutoSize = true;
            closeButton.Location = new Point(344, 3);
            closeButton.Name = "closeButton";
            closeButton.Size = new Size(106, 37);
            closeButton.TabIndex = 3;
            closeButton.Text = "Fermer";
            closeButton.UseVisualStyleBackColor = true;
            closeButton.Click += closeButton_Click;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            openFileDialog1.Filter = "(*.jpg)|*.jpg|(*.png)|*.png";
            openFileDialog1.Title = "\"Sélectionner un fichier image";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1136, 541);
            Controls.Add(tableLayoutPanel1);
            Name = "Form1";
            Text = "Picture Viewer";
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            flowLayoutPanel1.ResumeLayout(false);
            flowLayoutPanel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private PictureBox pictureBox1;
        private CheckBox checkBox1;
        private FlowLayoutPanel flowLayoutPanel1;
        private Button showButton;
        private Button clearButton;
        private Button backgroundButton;
        private Button closeButton;
        private OpenFileDialog openFileDialog1;
        private ColorDialog colorDialog1;
    }
}
