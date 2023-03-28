namespace WindowsFormsApp1
{
    partial class Etudiant
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
            System.Windows.Forms.Label code_inscriptionLabel;
            System.Windows.Forms.Label emailLabel;
            System.Windows.Forms.Label filiereLabel;
            System.Windows.Forms.Label nomLabel;
            System.Windows.Forms.Label prenomLabel;
            System.Windows.Forms.Label telephoneLabel;
            System.Windows.Forms.Label groupeLabel;
            this.code_inscriptionTextBox = new System.Windows.Forms.TextBox();
            this.etudiantBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.emailTextBox = new System.Windows.Forms.TextBox();
            this.filiereTextBox = new System.Windows.Forms.TextBox();
            this.nomTextBox = new System.Windows.Forms.TextBox();
            this.prenomTextBox = new System.Windows.Forms.TextBox();
            this.telephoneTextBox = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.groupeTextBox = new System.Windows.Forms.TextBox();
            this.etudiantDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            code_inscriptionLabel = new System.Windows.Forms.Label();
            emailLabel = new System.Windows.Forms.Label();
            filiereLabel = new System.Windows.Forms.Label();
            nomLabel = new System.Windows.Forms.Label();
            prenomLabel = new System.Windows.Forms.Label();
            telephoneLabel = new System.Windows.Forms.Label();
            groupeLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.etudiantBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.etudiantDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // code_inscriptionLabel
            // 
            code_inscriptionLabel.AutoSize = true;
            code_inscriptionLabel.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            code_inscriptionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            code_inscriptionLabel.ForeColor = System.Drawing.Color.White;
            code_inscriptionLabel.Location = new System.Drawing.Point(74, 325);
            code_inscriptionLabel.Name = "code_inscriptionLabel";
            code_inscriptionLabel.Size = new System.Drawing.Size(123, 16);
            code_inscriptionLabel.TabIndex = 2;
            code_inscriptionLabel.Text = "Code inscription:";
            code_inscriptionLabel.Click += new System.EventHandler(this.code_inscriptionLabel_Click);
            // 
            // emailLabel
            // 
            emailLabel.AutoSize = true;
            emailLabel.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            emailLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            emailLabel.ForeColor = System.Drawing.Color.White;
            emailLabel.Location = new System.Drawing.Point(73, 135);
            emailLabel.Name = "emailLabel";
            emailLabel.Size = new System.Drawing.Size(50, 16);
            emailLabel.TabIndex = 3;
            emailLabel.Text = "Email:";
            // 
            // filiereLabel
            // 
            filiereLabel.AutoSize = true;
            filiereLabel.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            filiereLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            filiereLabel.ForeColor = System.Drawing.Color.White;
            filiereLabel.Location = new System.Drawing.Point(72, 261);
            filiereLabel.Name = "filiereLabel";
            filiereLabel.Size = new System.Drawing.Size(55, 16);
            filiereLabel.TabIndex = 5;
            filiereLabel.Text = "Filiere:";
            // 
            // nomLabel
            // 
            nomLabel.AutoSize = true;
            nomLabel.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            nomLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            nomLabel.ForeColor = System.Drawing.Color.White;
            nomLabel.Location = new System.Drawing.Point(70, 9);
            nomLabel.Name = "nomLabel";
            nomLabel.Size = new System.Drawing.Size(43, 16);
            nomLabel.TabIndex = 9;
            nomLabel.Text = "Nom:";
            // 
            // prenomLabel
            // 
            prenomLabel.AutoSize = true;
            prenomLabel.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            prenomLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            prenomLabel.ForeColor = System.Drawing.Color.White;
            prenomLabel.Location = new System.Drawing.Point(71, 72);
            prenomLabel.Name = "prenomLabel";
            prenomLabel.Size = new System.Drawing.Size(64, 16);
            prenomLabel.TabIndex = 11;
            prenomLabel.Text = "Prenom:";
            // 
            // telephoneLabel
            // 
            telephoneLabel.AutoSize = true;
            telephoneLabel.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            telephoneLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            telephoneLabel.ForeColor = System.Drawing.Color.White;
            telephoneLabel.Location = new System.Drawing.Point(70, 197);
            telephoneLabel.Name = "telephoneLabel";
            telephoneLabel.Size = new System.Drawing.Size(86, 16);
            telephoneLabel.TabIndex = 13;
            telephoneLabel.Text = "Telephone:";
            // 
            // groupeLabel
            // 
            groupeLabel.AutoSize = true;
            groupeLabel.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            groupeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            groupeLabel.ForeColor = System.Drawing.Color.White;
            groupeLabel.Location = new System.Drawing.Point(74, 389);
            groupeLabel.Name = "groupeLabel";
            groupeLabel.Size = new System.Drawing.Size(62, 16);
            groupeLabel.TabIndex = 18;
            groupeLabel.Text = "Groupe:";
            // 
            // code_inscriptionTextBox
            // 
            this.code_inscriptionTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.etudiantBindingSource, "Code_inscription", true));
            this.code_inscriptionTextBox.Location = new System.Drawing.Point(76, 344);
            this.code_inscriptionTextBox.Multiline = true;
            this.code_inscriptionTextBox.Name = "code_inscriptionTextBox";
            this.code_inscriptionTextBox.Size = new System.Drawing.Size(209, 42);
            this.code_inscriptionTextBox.TabIndex = 3;
            this.code_inscriptionTextBox.TextChanged += new System.EventHandler(this.code_inscriptionTextBox_TextChanged);
            // 
            // etudiantBindingSource
            // 
            this.etudiantBindingSource.DataSource = typeof(Models2.Etudiant);
            // 
            // emailTextBox
            // 
            this.emailTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.etudiantBindingSource, "Email", true));
            this.emailTextBox.Location = new System.Drawing.Point(73, 154);
            this.emailTextBox.Multiline = true;
            this.emailTextBox.Name = "emailTextBox";
            this.emailTextBox.Size = new System.Drawing.Size(209, 42);
            this.emailTextBox.TabIndex = 4;
            // 
            // filiereTextBox
            // 
            this.filiereTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.etudiantBindingSource, "Filiere", true));
            this.filiereTextBox.Location = new System.Drawing.Point(76, 280);
            this.filiereTextBox.Multiline = true;
            this.filiereTextBox.Name = "filiereTextBox";
            this.filiereTextBox.Size = new System.Drawing.Size(209, 42);
            this.filiereTextBox.TabIndex = 6;
            // 
            // nomTextBox
            // 
            this.nomTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.etudiantBindingSource, "Nom", true));
            this.nomTextBox.Location = new System.Drawing.Point(73, 27);
            this.nomTextBox.Multiline = true;
            this.nomTextBox.Name = "nomTextBox";
            this.nomTextBox.Size = new System.Drawing.Size(209, 42);
            this.nomTextBox.TabIndex = 10;
            // 
            // prenomTextBox
            // 
            this.prenomTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.etudiantBindingSource, "Prenom", true));
            this.prenomTextBox.Location = new System.Drawing.Point(73, 91);
            this.prenomTextBox.Multiline = true;
            this.prenomTextBox.Name = "prenomTextBox";
            this.prenomTextBox.Size = new System.Drawing.Size(209, 42);
            this.prenomTextBox.TabIndex = 12;
            // 
            // telephoneTextBox
            // 
            this.telephoneTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.etudiantBindingSource, "Telephone", true));
            this.telephoneTextBox.Location = new System.Drawing.Point(72, 217);
            this.telephoneTextBox.Multiline = true;
            this.telephoneTextBox.Name = "telephoneTextBox";
            this.telephoneTextBox.Size = new System.Drawing.Size(209, 42);
            this.telephoneTextBox.TabIndex = 14;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(205)))), ((int)(((byte)(196)))));
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(669, 27);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(163, 40);
            this.button2.TabIndex = 16;
            this.button2.Text = "Ajouter";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(107)))), ((int)(((byte)(107)))));
            this.button3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.Location = new System.Drawing.Point(669, 90);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(163, 40);
            this.button3.TabIndex = 17;
            this.button3.Text = "Supprimer";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(125)))), ((int)(((byte)(170)))));
            this.button4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.Color.White;
            this.button4.Location = new System.Drawing.Point(669, 153);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(163, 40);
            this.button4.TabIndex = 18;
            this.button4.Text = "Mis à jour";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // groupeTextBox
            // 
            this.groupeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.etudiantBindingSource, "Groupe", true));
            this.groupeTextBox.Location = new System.Drawing.Point(76, 408);
            this.groupeTextBox.Multiline = true;
            this.groupeTextBox.Name = "groupeTextBox";
            this.groupeTextBox.Size = new System.Drawing.Size(209, 42);
            this.groupeTextBox.TabIndex = 19;
            // 
            // etudiantDataGridView
            // 
            this.etudiantDataGridView.AutoGenerateColumns = false;
            this.etudiantDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.etudiantDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn9});
            this.etudiantDataGridView.DataSource = this.etudiantBindingSource;
            this.etudiantDataGridView.Location = new System.Drawing.Point(72, 507);
            this.etudiantDataGridView.Name = "etudiantDataGridView";
            this.etudiantDataGridView.RowHeadersWidth = 51;
            this.etudiantDataGridView.RowTemplate.Height = 24;
            this.etudiantDataGridView.Size = new System.Drawing.Size(1053, 220);
            this.etudiantDataGridView.TabIndex = 19;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Nom";
            this.dataGridViewTextBoxColumn1.HeaderText = "Nom";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Width = 125;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Prenom";
            this.dataGridViewTextBoxColumn2.HeaderText = "Prenom";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 125;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Email";
            this.dataGridViewTextBoxColumn3.HeaderText = "Email";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 125;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Telephone";
            this.dataGridViewTextBoxColumn4.HeaderText = "Telephone";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.Width = 125;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Filiere";
            this.dataGridViewTextBoxColumn5.HeaderText = "Filiere";
            this.dataGridViewTextBoxColumn5.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.Width = 125;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "Code_inscription";
            this.dataGridViewTextBoxColumn6.HeaderText = "Code_inscription";
            this.dataGridViewTextBoxColumn6.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.Width = 125;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "Id_etudiant";
            this.dataGridViewTextBoxColumn7.HeaderText = "Id_etudiant";
            this.dataGridViewTextBoxColumn7.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.Width = 125;
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "Groupe";
            this.dataGridViewTextBoxColumn9.HeaderText = "Groupe";
            this.dataGridViewTextBoxColumn9.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            this.dataGridViewTextBoxColumn9.Width = 125;
            // 
            // Etudiant
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::WindowsFormsApp1.Properties.Resources.istockphoto_543350202_612x6121;
            this.ClientSize = new System.Drawing.Size(1248, 871);
            this.Controls.Add(this.etudiantDataGridView);
            this.Controls.Add(groupeLabel);
            this.Controls.Add(this.groupeTextBox);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(telephoneLabel);
            this.Controls.Add(this.telephoneTextBox);
            this.Controls.Add(prenomLabel);
            this.Controls.Add(this.prenomTextBox);
            this.Controls.Add(nomLabel);
            this.Controls.Add(this.nomTextBox);
            this.Controls.Add(filiereLabel);
            this.Controls.Add(this.filiereTextBox);
            this.Controls.Add(emailLabel);
            this.Controls.Add(this.emailTextBox);
            this.Controls.Add(code_inscriptionLabel);
            this.Controls.Add(this.code_inscriptionTextBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Etudiant";
            this.Text = "Client";
            this.Load += new System.EventHandler(this.Client_Load);
            ((System.ComponentModel.ISupportInitialize)(this.etudiantBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.etudiantDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource etudiantBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.TextBox code_inscriptionTextBox;
        private System.Windows.Forms.TextBox emailTextBox;
        private System.Windows.Forms.TextBox filiereTextBox;
        private System.Windows.Forms.TextBox nomTextBox;
        private System.Windows.Forms.TextBox prenomTextBox;
        private System.Windows.Forms.TextBox telephoneTextBox;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.TextBox groupeTextBox;
        private System.Windows.Forms.DataGridView etudiantDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
    }
}