namespace formulaire_bibliotheque
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
            this.btnNouveau = new System.Windows.Forms.Button();
            this.btnModifier = new System.Windows.Forms.Button();
            this.btnsupprimer = new System.Windows.Forms.Button();
            this.btnConfirmer = new System.Windows.Forms.Button();
            this.textBoxNom = new System.Windows.Forms.TextBox();
            this.textBoxPrix = new System.Windows.Forms.TextBox();
            this.btnAnnuler = new System.Windows.Forms.Button();
            this.dataGridViewBd = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblprix = new System.Windows.Forms.Label();
            this.lblnom = new System.Windows.Forms.Label();
            this.lblref = new System.Windows.Forms.Label();
            this.comboBoxReference = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBd)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnNouveau
            // 
            this.btnNouveau.Location = new System.Drawing.Point(86, 204);
            this.btnNouveau.Name = "btnNouveau";
            this.btnNouveau.Size = new System.Drawing.Size(75, 23);
            this.btnNouveau.TabIndex = 1;
            this.btnNouveau.Text = "Nouveau";
            this.btnNouveau.UseVisualStyleBackColor = true;
            this.btnNouveau.Click += new System.EventHandler(this.btnNouveau_Click);
            // 
            // btnModifier
            // 
            this.btnModifier.Location = new System.Drawing.Point(197, 204);
            this.btnModifier.Name = "btnModifier";
            this.btnModifier.Size = new System.Drawing.Size(75, 23);
            this.btnModifier.TabIndex = 2;
            this.btnModifier.Text = "Modifier";
            this.btnModifier.UseVisualStyleBackColor = true;
            this.btnModifier.Click += new System.EventHandler(this.btnModifier_Click);
            // 
            // btnsupprimer
            // 
            this.btnsupprimer.Location = new System.Drawing.Point(293, 204);
            this.btnsupprimer.Name = "btnsupprimer";
            this.btnsupprimer.Size = new System.Drawing.Size(75, 23);
            this.btnsupprimer.TabIndex = 3;
            this.btnsupprimer.Text = "supprimer";
            this.btnsupprimer.UseVisualStyleBackColor = true;
            this.btnsupprimer.Click += new System.EventHandler(this.btnsupprimer_Click);
            // 
            // btnConfirmer
            // 
            this.btnConfirmer.Location = new System.Drawing.Point(403, 204);
            this.btnConfirmer.Name = "btnConfirmer";
            this.btnConfirmer.Size = new System.Drawing.Size(75, 23);
            this.btnConfirmer.TabIndex = 4;
            this.btnConfirmer.Text = "Confirmer";
            this.btnConfirmer.UseVisualStyleBackColor = true;
            this.btnConfirmer.Click += new System.EventHandler(this.btnConfirmer_Click);
            // 
            // textBoxNom
            // 
            this.textBoxNom.Location = new System.Drawing.Point(135, 61);
            this.textBoxNom.Name = "textBoxNom";
            this.textBoxNom.PlaceholderText = "Nom  de livre";
            this.textBoxNom.Size = new System.Drawing.Size(316, 23);
            this.textBoxNom.TabIndex = 5;
            // 
            // textBoxPrix
            // 
            this.textBoxPrix.Location = new System.Drawing.Point(135, 99);
            this.textBoxPrix.Name = "textBoxPrix";
            this.textBoxPrix.PlaceholderText = "Prix de livre";
            this.textBoxPrix.Size = new System.Drawing.Size(316, 23);
            this.textBoxPrix.TabIndex = 6;
            // 
            // btnAnnuler
            // 
            this.btnAnnuler.Location = new System.Drawing.Point(517, 204);
            this.btnAnnuler.Name = "btnAnnuler";
            this.btnAnnuler.Size = new System.Drawing.Size(75, 23);
            this.btnAnnuler.TabIndex = 7;
            this.btnAnnuler.Text = "Annuler";
            this.btnAnnuler.UseVisualStyleBackColor = true;
            // 
            // dataGridViewBd
            // 
            this.dataGridViewBd.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewBd.Location = new System.Drawing.Point(49, 252);
            this.dataGridViewBd.Name = "dataGridViewBd";
            this.dataGridViewBd.RowTemplate.Height = 25;
            this.dataGridViewBd.Size = new System.Drawing.Size(622, 100);
            this.dataGridViewBd.TabIndex = 8;
            this.dataGridViewBd.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewBd_CellContentClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblprix);
            this.groupBox1.Controls.Add(this.lblnom);
            this.groupBox1.Controls.Add(this.lblref);
            this.groupBox1.Controls.Add(this.comboBoxReference);
            this.groupBox1.Controls.Add(this.textBoxNom);
            this.groupBox1.Controls.Add(this.textBoxPrix);
            this.groupBox1.Location = new System.Drawing.Point(49, 34);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(622, 164);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // lblprix
            // 
            this.lblprix.Location = new System.Drawing.Point(51, 102);
            this.lblprix.Name = "lblprix";
            this.lblprix.Size = new System.Drawing.Size(78, 20);
            this.lblprix.TabIndex = 10;
            this.lblprix.Text = "Prix";
            this.lblprix.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblnom
            // 
            this.lblnom.AutoSize = true;
            this.lblnom.Location = new System.Drawing.Point(51, 64);
            this.lblnom.Name = "lblnom";
            this.lblnom.Size = new System.Drawing.Size(75, 15);
            this.lblnom.TabIndex = 9;
            this.lblnom.Text = "Nom de livre";
            this.lblnom.Click += new System.EventHandler(this.lblnom_Click);
            // 
            // lblref
            // 
            this.lblref.AutoSize = true;
            this.lblref.Location = new System.Drawing.Point(51, 38);
            this.lblref.Name = "lblref";
            this.lblref.Size = new System.Drawing.Size(59, 15);
            this.lblref.TabIndex = 8;
            this.lblref.Text = "Reference";
            // 
            // comboBoxReference
            // 
            this.comboBoxReference.FormattingEnabled = true;
            this.comboBoxReference.Location = new System.Drawing.Point(135, 35);
            this.comboBoxReference.Name = "comboBoxReference";
            this.comboBoxReference.Size = new System.Drawing.Size(317, 23);
            this.comboBoxReference.TabIndex = 7;
            this.comboBoxReference.SelectedIndexChanged += new System.EventHandler(this.comboBoxReference_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(725, 379);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataGridViewBd);
            this.Controls.Add(this.btnAnnuler);
            this.Controls.Add(this.btnConfirmer);
            this.Controls.Add(this.btnsupprimer);
            this.Controls.Add(this.btnModifier);
            this.Controls.Add(this.btnNouveau);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBd)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private Button btnNouveau;
        private Button btnModifier;
        private Button btnsupprimer;
        private Button btnConfirmer;
        private TextBox textBoxNom;
        private TextBox textBoxPrix;
        private Button btnAnnuler;
        private DataGridView dataGridViewBd;
        private GroupBox groupBox1;
        private Label lblprix;
        private Label lblnom;
        private Label lblref;
        private ComboBox comboBoxReference;
    }
}