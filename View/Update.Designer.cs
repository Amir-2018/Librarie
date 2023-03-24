namespace View
{
    partial class Update
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
            this.nom = new System.Windows.Forms.TextBox();
            this.lastname = new System.Windows.Forms.TextBox();
            this.email = new System.Windows.Forms.TextBox();
            this.tel = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.upNum = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // nom
            // 
            this.nom.Location = new System.Drawing.Point(104, 69);
            this.nom.Name = "nom";
            this.nom.Size = new System.Drawing.Size(287, 27);
            this.nom.TabIndex = 9;
            // 
            // lastname
            // 
            this.lastname.Location = new System.Drawing.Point(104, 130);
            this.lastname.Name = "lastname";
            this.lastname.Size = new System.Drawing.Size(287, 27);
            this.lastname.TabIndex = 10;
            // 
            // email
            // 
            this.email.Location = new System.Drawing.Point(104, 195);
            this.email.Name = "email";
            this.email.Size = new System.Drawing.Size(287, 27);
            this.email.TabIndex = 11;
            // 
            // tel
            // 
            this.tel.Location = new System.Drawing.Point(104, 256);
            this.tel.Name = "tel";
            this.tel.Size = new System.Drawing.Size(287, 27);
            this.tel.TabIndex = 12;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(186)))), ((int)(((byte)(63)))), ((int)(((byte)(73)))));
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button1.Location = new System.Drawing.Point(104, 317);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(287, 48);
            this.button1.TabIndex = 13;
            this.button1.Text = "Update";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // upNum
            // 
            this.upNum.AccessibleName = "";
            this.upNum.AutoSize = true;
            this.upNum.Location = new System.Drawing.Point(451, 39);
            this.upNum.Name = "upNum";
            this.upNum.Size = new System.Drawing.Size(50, 20);
            this.upNum.TabIndex = 14;
            this.upNum.Text = "label1";
            this.upNum.Click += new System.EventHandler(this.upNum_Click);
            // 
            // Update
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(535, 413);
            this.Controls.Add(this.upNum);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tel);
            this.Controls.Add(this.email);
            this.Controls.Add(this.lastname);
            this.Controls.Add(this.nom);
            this.Name = "Update";
            this.Text = "Update";
            this.Load += new System.EventHandler(this.Update_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox nom;
        private TextBox lastname;
        private TextBox email;
        private TextBox tel;
        private Button button1;
        private Label upNum;
    }
}