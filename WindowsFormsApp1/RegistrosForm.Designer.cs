
namespace WindowsFormsApp1
{
    partial class RegistrosForm
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtfullName = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.fullNameWarning = new System.Windows.Forms.Label();
            this.emailWarning = new System.Windows.Forms.Label();
            this.senhaWarning = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtfullName
            // 
            this.txtfullName.Location = new System.Drawing.Point(29, 58);
            this.txtfullName.Name = "txtfullName";
            this.txtfullName.Size = new System.Drawing.Size(387, 20);
            this.txtfullName.TabIndex = 0;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(29, 145);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(387, 20);
            this.txtEmail.TabIndex = 1;
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(29, 230);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(387, 20);
            this.txtPassword.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(319, 267);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(97, 31);
            this.button1.TabIndex = 3;
            this.button1.Text = "Registrar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(191, 267);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(97, 31);
            this.button2.TabIndex = 4;
            this.button2.Text = "Cancelar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Nome Completo";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 120);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Email";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(26, 205);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Senha";
            // 
            // fullNameWarning
            // 
            this.fullNameWarning.AutoSize = true;
            this.fullNameWarning.ForeColor = System.Drawing.Color.Red;
            this.fullNameWarning.Location = new System.Drawing.Point(26, 81);
            this.fullNameWarning.Name = "fullNameWarning";
            this.fullNameWarning.Size = new System.Drawing.Size(97, 13);
            this.fullNameWarning.TabIndex = 8;
            this.fullNameWarning.Text = "Preencha o campo";
            this.fullNameWarning.Visible = false;
            // 
            // emailWarning
            // 
            this.emailWarning.AutoSize = true;
            this.emailWarning.ForeColor = System.Drawing.Color.Red;
            this.emailWarning.Location = new System.Drawing.Point(26, 168);
            this.emailWarning.Name = "emailWarning";
            this.emailWarning.Size = new System.Drawing.Size(97, 13);
            this.emailWarning.TabIndex = 9;
            this.emailWarning.Text = "Preencha o campo";
            this.emailWarning.Visible = false;
            // 
            // senhaWarning
            // 
            this.senhaWarning.AutoSize = true;
            this.senhaWarning.ForeColor = System.Drawing.Color.Red;
            this.senhaWarning.Location = new System.Drawing.Point(26, 253);
            this.senhaWarning.Name = "senhaWarning";
            this.senhaWarning.Size = new System.Drawing.Size(97, 13);
            this.senhaWarning.TabIndex = 10;
            this.senhaWarning.Text = "Preencha o campo";
            this.senhaWarning.Visible = false;
            this.senhaWarning.Click += new System.EventHandler(this.label6_Click);
            // 
            // RegistrosForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(450, 310);
            this.Controls.Add(this.senhaWarning);
            this.Controls.Add(this.emailWarning);
            this.Controls.Add(this.fullNameWarning);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtfullName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "RegistrosForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtfullName;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label fullNameWarning;
        private System.Windows.Forms.Label emailWarning;
        private System.Windows.Forms.Label senhaWarning;
    }
}

