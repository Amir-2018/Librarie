namespace WindowsFormsApp1
{
    partial class Livre
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label telephoneLabel;
            System.Windows.Forms.Label prenomLabel;
            System.Windows.Forms.Label nomLabel;
            System.Windows.Forms.Label groupePropLabel;
            System.Windows.Forms.Label filiereLabel;
            System.Windows.Forms.Label emailLabel;
            System.Windows.Forms.Label code_inscriptionLabel;
            System.Windows.Forms.Label titreLabel;
            System.Windows.Forms.Label auteurLabel;
            System.Windows.Forms.Label nbpagesLabel;
            System.Windows.Forms.Label nbchapitreLabel;
            System.Windows.Forms.Label date_editionLabel;
            System.Windows.Forms.Label prixLabel;
            System.Windows.Forms.Label categoryLabel;
            this.button1 = new System.Windows.Forms.Button();
            this.prenomTextBox = new System.Windows.Forms.TextBox();
            this.nomTextBox = new System.Windows.Forms.TextBox();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.titreTextBox = new System.Windows.Forms.TextBox();
            this.auteurTextBox = new System.Windows.Forms.TextBox();
            this.nbpagesTextBox = new System.Windows.Forms.TextBox();
            this.nbchapitreTextBox = new System.Windows.Forms.TextBox();
            this.date_editionDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.prixTextBox = new System.Windows.Forms.TextBox();
            this.categoryTextBox = new System.Windows.Forms.TextBox();
            this.livreDataGridView = new System.Windows.Forms.DataGridView();
            this.etudiant_GroupeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.livreBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.etudiantBindingSource = new System.Windows.Forms.BindingSource(this.components);
            telephoneLabel = new System.Windows.Forms.Label();
            prenomLabel = new System.Windows.Forms.Label();
            nomLabel = new System.Windows.Forms.Label();
            groupePropLabel = new System.Windows.Forms.Label();
            filiereLabel = new System.Windows.Forms.Label();
            emailLabel = new System.Windows.Forms.Label();
            code_inscriptionLabel = new System.Windows.Forms.Label();
            titreLabel = new System.Windows.Forms.Label();
            auteurLabel = new System.Windows.Forms.Label();
            nbpagesLabel = new System.Windows.Forms.Label();
            nbchapitreLabel = new System.Windows.Forms.Label();
            date_editionLabel = new System.Windows.Forms.Label();
            prixLabel = new System.Windows.Forms.Label();
            categoryLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.livreDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.etudiant_GroupeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.livreBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.etudiantBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // telephoneLabel
            // 
            telephoneLabel.AutoSize = true;
            telephoneLabel.Location = new System.Drawing.Point(-140, 67);
            telephoneLabel.Name = "telephoneLabel";
            telephoneLabel.Size = new System.Drawing.Size(76, 16);
            telephoneLabel.TabIndex = 32;
            telephoneLabel.Text = "Telephone:";
            // 
            // prenomLabel
            // 
            prenomLabel.AutoSize = true;
            prenomLabel.Location = new System.Drawing.Point(-140, -61);
            prenomLabel.Name = "prenomLabel";
            prenomLabel.Size = new System.Drawing.Size(57, 16);
            prenomLabel.TabIndex = 30;
            prenomLabel.Text = "Prenom:";
            // 
            // nomLabel
            // 
            nomLabel.AutoSize = true;
            nomLabel.Location = new System.Drawing.Point(-141, -124);
            nomLabel.Name = "nomLabel";
            nomLabel.Size = new System.Drawing.Size(39, 16);
            nomLabel.TabIndex = 28;
            nomLabel.Text = "Nom:";
            // 
            // groupePropLabel
            // 
            groupePropLabel.AutoSize = true;
            groupePropLabel.Location = new System.Drawing.Point(-141, 196);
            groupePropLabel.Name = "groupePropLabel";
            groupePropLabel.Size = new System.Drawing.Size(87, 16);
            groupePropLabel.TabIndex = 26;
            groupePropLabel.Text = "Groupe Prop:";
            // 
            // filiereLabel
            // 
            filiereLabel.AutoSize = true;
            filiereLabel.Location = new System.Drawing.Point(-141, 132);
            filiereLabel.Name = "filiereLabel";
            filiereLabel.Size = new System.Drawing.Size(47, 16);
            filiereLabel.TabIndex = 24;
            filiereLabel.Text = "Filiere:";
            // 
            // emailLabel
            // 
            emailLabel.AutoSize = true;
            emailLabel.Location = new System.Drawing.Point(-140, 260);
            emailLabel.Name = "emailLabel";
            emailLabel.Size = new System.Drawing.Size(44, 16);
            emailLabel.TabIndex = 21;
            emailLabel.Text = "Email:";
            // 
            // code_inscriptionLabel
            // 
            code_inscriptionLabel.AutoSize = true;
            code_inscriptionLabel.Location = new System.Drawing.Point(-140, 3);
            code_inscriptionLabel.Name = "code_inscriptionLabel";
            code_inscriptionLabel.Size = new System.Drawing.Size(106, 16);
            code_inscriptionLabel.TabIndex = 20;
            code_inscriptionLabel.Text = "Code inscription:";
            // 
            // titreLabel
            // 
            titreLabel.AutoSize = true;
            titreLabel.Location = new System.Drawing.Point(66, 9);
            titreLabel.Name = "titreLabel";
            titreLabel.Size = new System.Drawing.Size(37, 16);
            titreLabel.TabIndex = 38;
            titreLabel.Text = "Titre:";
            // 
            // auteurLabel
            // 
            auteurLabel.AutoSize = true;
            auteurLabel.Location = new System.Drawing.Point(66, 76);
            auteurLabel.Name = "auteurLabel";
            auteurLabel.Size = new System.Drawing.Size(48, 16);
            auteurLabel.TabIndex = 39;
            auteurLabel.Text = "Auteur:";
            // 
            // nbpagesLabel
            // 
            nbpagesLabel.AutoSize = true;
            nbpagesLabel.Location = new System.Drawing.Point(66, 140);
            nbpagesLabel.Name = "nbpagesLabel";
            nbpagesLabel.Size = new System.Drawing.Size(67, 16);
            nbpagesLabel.TabIndex = 40;
            nbpagesLabel.Text = "Nbpages:";
            // 
            // nbchapitreLabel
            // 
            nbchapitreLabel.AutoSize = true;
            nbchapitreLabel.Location = new System.Drawing.Point(66, 204);
            nbchapitreLabel.Name = "nbchapitreLabel";
            nbchapitreLabel.Size = new System.Drawing.Size(76, 16);
            nbchapitreLabel.TabIndex = 41;
            nbchapitreLabel.Text = "Nbchapitre:";
            // 
            // date_editionLabel
            // 
            date_editionLabel.AutoSize = true;
            date_editionLabel.Location = new System.Drawing.Point(66, 271);
            date_editionLabel.Name = "date_editionLabel";
            date_editionLabel.Size = new System.Drawing.Size(82, 16);
            date_editionLabel.TabIndex = 42;
            date_editionLabel.Text = "Date edition:";
            date_editionLabel.Click += new System.EventHandler(this.date_editionLabel_Click);
            // 
            // prixLabel
            // 
            prixLabel.AutoSize = true;
            prixLabel.Location = new System.Drawing.Point(66, 315);
            prixLabel.Name = "prixLabel";
            prixLabel.Size = new System.Drawing.Size(32, 16);
            prixLabel.TabIndex = 43;
            prixLabel.Text = "Prix:";
            // 
            // categoryLabel
            // 
            categoryLabel.AutoSize = true;
            categoryLabel.Location = new System.Drawing.Point(68, 379);
            categoryLabel.Name = "categoryLabel";
            categoryLabel.Size = new System.Drawing.Size(65, 16);
            categoryLabel.TabIndex = 44;
            categoryLabel.Text = "Category:";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(205)))), ((int)(((byte)(196)))));
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(459, -106);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(163, 40);
            this.button1.TabIndex = 34;
            this.button1.Text = "Nouveau";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // prenomTextBox
            // 
            this.prenomTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.etudiantBindingSource, "Prenom", true));
            this.prenomTextBox.Location = new System.Drawing.Point(-138, -42);
            this.prenomTextBox.Multiline = true;
            this.prenomTextBox.Name = "prenomTextBox";
            this.prenomTextBox.Size = new System.Drawing.Size(209, 42);
            this.prenomTextBox.TabIndex = 31;
            // 
            // nomTextBox
            // 
            this.nomTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.etudiantBindingSource, "Nom", true));
            this.nomTextBox.Location = new System.Drawing.Point(-138, -106);
            this.nomTextBox.Multiline = true;
            this.nomTextBox.Name = "nomTextBox";
            this.nomTextBox.Size = new System.Drawing.Size(209, 42);
            this.nomTextBox.TabIndex = 29;
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(125)))), ((int)(((byte)(170)))));
            this.button4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.Color.White;
            this.button4.Location = new System.Drawing.Point(719, 252);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(163, 40);
            this.button4.TabIndex = 38;
            this.button4.Text = "Mis à jour";
            this.button4.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(107)))), ((int)(((byte)(107)))));
            this.button3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.Location = new System.Drawing.Point(719, 189);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(163, 40);
            this.button3.TabIndex = 37;
            this.button3.Text = "Supprimer";
            this.button3.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(47)))), ((int)(((byte)(54)))));
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(719, 126);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(163, 40);
            this.button2.TabIndex = 36;
            this.button2.Text = "Ajouter";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(205)))), ((int)(((byte)(196)))));
            this.button5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button5.FlatAppearance.BorderSize = 0;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.ForeColor = System.Drawing.Color.White;
            this.button5.Location = new System.Drawing.Point(719, 62);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(163, 40);
            this.button5.TabIndex = 35;
            this.button5.Text = "Nouveau";
            this.button5.UseVisualStyleBackColor = false;
            // 
            // titreTextBox
            // 
            this.titreTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.livreBindingSource, "Titre", true));
            this.titreTextBox.Location = new System.Drawing.Point(69, 28);
            this.titreTextBox.Multiline = true;
            this.titreTextBox.Name = "titreTextBox";
            this.titreTextBox.Size = new System.Drawing.Size(209, 42);
            this.titreTextBox.TabIndex = 39;
            // 
            // auteurTextBox
            // 
            this.auteurTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.livreBindingSource, "Auteur", true));
            this.auteurTextBox.Location = new System.Drawing.Point(69, 95);
            this.auteurTextBox.Multiline = true;
            this.auteurTextBox.Name = "auteurTextBox";
            this.auteurTextBox.Size = new System.Drawing.Size(209, 42);
            this.auteurTextBox.TabIndex = 40;
            // 
            // nbpagesTextBox
            // 
            this.nbpagesTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.livreBindingSource, "Nbpages", true));
            this.nbpagesTextBox.Location = new System.Drawing.Point(69, 159);
            this.nbpagesTextBox.Multiline = true;
            this.nbpagesTextBox.Name = "nbpagesTextBox";
            this.nbpagesTextBox.Size = new System.Drawing.Size(209, 42);
            this.nbpagesTextBox.TabIndex = 41;
            // 
            // nbchapitreTextBox
            // 
            this.nbchapitreTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.livreBindingSource, "Nbchapitre", true));
            this.nbchapitreTextBox.Location = new System.Drawing.Point(69, 226);
            this.nbchapitreTextBox.Multiline = true;
            this.nbchapitreTextBox.Name = "nbchapitreTextBox";
            this.nbchapitreTextBox.Size = new System.Drawing.Size(209, 42);
            this.nbchapitreTextBox.TabIndex = 42;
            // 
            // date_editionDateTimePicker
            // 
            this.date_editionDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.livreBindingSource, "Date_edition", true));
            this.date_editionDateTimePicker.Location = new System.Drawing.Point(69, 290);
            this.date_editionDateTimePicker.Name = "date_editionDateTimePicker";
            this.date_editionDateTimePicker.Size = new System.Drawing.Size(209, 22);
            this.date_editionDateTimePicker.TabIndex = 43;
            this.date_editionDateTimePicker.ValueChanged += new System.EventHandler(this.date_editionDateTimePicker_ValueChanged);
            // 
            // prixTextBox
            // 
            this.prixTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.livreBindingSource, "Prix", true));
            this.prixTextBox.Location = new System.Drawing.Point(69, 334);
            this.prixTextBox.Multiline = true;
            this.prixTextBox.Name = "prixTextBox";
            this.prixTextBox.Size = new System.Drawing.Size(209, 42);
            this.prixTextBox.TabIndex = 44;
            // 
            // categoryTextBox
            // 
            this.categoryTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.livreBindingSource, "Category", true));
            this.categoryTextBox.Location = new System.Drawing.Point(69, 398);
            this.categoryTextBox.Multiline = true;
            this.categoryTextBox.Name = "categoryTextBox";
            this.categoryTextBox.Size = new System.Drawing.Size(209, 42);
            this.categoryTextBox.TabIndex = 45;
            // 
            // livreDataGridView
            // 
            this.livreDataGridView.AutoGenerateColumns = false;
            this.livreDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.livreDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8});
            this.livreDataGridView.DataSource = this.livreBindingSource;
            this.livreDataGridView.Location = new System.Drawing.Point(69, 468);
            this.livreDataGridView.Name = "livreDataGridView";
            this.livreDataGridView.RowHeadersWidth = 51;
            this.livreDataGridView.RowTemplate.Height = 24;
            this.livreDataGridView.Size = new System.Drawing.Size(1052, 220);
            this.livreDataGridView.TabIndex = 45;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Id_livre";
            this.dataGridViewTextBoxColumn1.HeaderText = "Id_livre";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Width = 125;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Titre";
            this.dataGridViewTextBoxColumn2.HeaderText = "Titre";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 125;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Auteur";
            this.dataGridViewTextBoxColumn3.HeaderText = "Auteur";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 125;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Nbpages";
            this.dataGridViewTextBoxColumn4.HeaderText = "Nbpages";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.Width = 125;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Nbchapitre";
            this.dataGridViewTextBoxColumn5.HeaderText = "Nbchapitre";
            this.dataGridViewTextBoxColumn5.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.Width = 125;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "Date_edition";
            this.dataGridViewTextBoxColumn6.HeaderText = "Date_edition";
            this.dataGridViewTextBoxColumn6.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.Width = 125;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "Prix";
            this.dataGridViewTextBoxColumn7.HeaderText = "Prix";
            this.dataGridViewTextBoxColumn7.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.Width = 125;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "Category";
            this.dataGridViewTextBoxColumn8.HeaderText = "Category";
            this.dataGridViewTextBoxColumn8.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.Width = 125;
            // 
            // livreBindingSource
            // 
            this.livreBindingSource.DataSource = typeof(Models2.Livre);
            // 
            // etudiantBindingSource
            // 
            this.etudiantBindingSource.DataSource = typeof(Models2.Etudiant);
            // 
            // Livre
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1248, 803);
            this.Controls.Add(this.livreDataGridView);
            this.Controls.Add(categoryLabel);
            this.Controls.Add(this.categoryTextBox);
            this.Controls.Add(prixLabel);
            this.Controls.Add(this.prixTextBox);
            this.Controls.Add(date_editionLabel);
            this.Controls.Add(this.date_editionDateTimePicker);
            this.Controls.Add(nbchapitreLabel);
            this.Controls.Add(this.nbchapitreTextBox);
            this.Controls.Add(nbpagesLabel);
            this.Controls.Add(this.nbpagesTextBox);
            this.Controls.Add(auteurLabel);
            this.Controls.Add(this.auteurTextBox);
            this.Controls.Add(titreLabel);
            this.Controls.Add(this.titreTextBox);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button1);
            this.Controls.Add(telephoneLabel);
            this.Controls.Add(prenomLabel);
            this.Controls.Add(this.prenomTextBox);
            this.Controls.Add(nomLabel);
            this.Controls.Add(this.nomTextBox);
            this.Controls.Add(groupePropLabel);
            this.Controls.Add(filiereLabel);
            this.Controls.Add(emailLabel);
            this.Controls.Add(code_inscriptionLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Livre";
            this.Text = "Livre";
            this.Load += new System.EventHandler(this.Livre_Load);
            ((System.ComponentModel.ISupportInitialize)(this.livreDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.etudiant_GroupeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.livreBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.etudiantBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.BindingSource etudiantBindingSource;
        private System.Windows.Forms.TextBox prenomTextBox;
        private System.Windows.Forms.TextBox nomTextBox;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.BindingSource livreBindingSource;
        private System.Windows.Forms.TextBox titreTextBox;
        private System.Windows.Forms.TextBox auteurTextBox;
        private System.Windows.Forms.TextBox nbpagesTextBox;
        private System.Windows.Forms.TextBox nbchapitreTextBox;
        private System.Windows.Forms.DateTimePicker date_editionDateTimePicker;
        private System.Windows.Forms.TextBox prixTextBox;
        private System.Windows.Forms.TextBox categoryTextBox;
        private System.Windows.Forms.DataGridView livreDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.BindingSource etudiant_GroupeBindingSource;
    }
}