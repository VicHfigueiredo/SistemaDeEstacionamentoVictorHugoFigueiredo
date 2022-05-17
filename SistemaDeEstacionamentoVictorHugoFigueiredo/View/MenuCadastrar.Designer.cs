
namespace SistemaDeEstacionamentoVictorHugoFigueiredo.View
{
    partial class MenuCadastrar
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
            this.lblNomeCli = new System.Windows.Forms.Label();
            this.lblCelCli = new System.Windows.Forms.Label();
            this.lblEmailCli = new System.Windows.Forms.Label();
            this.lblCpfCli = new System.Windows.Forms.Label();
            this.lblTituloCli = new System.Windows.Forms.Label();
            this.tbxNomeCli = new System.Windows.Forms.TextBox();
            this.tbxCelCli = new System.Windows.Forms.TextBox();
            this.tbxEmailCli = new System.Windows.Forms.TextBox();
            this.tbxCpfCli = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblNomeCli
            // 
            this.lblNomeCli.AutoSize = true;
            this.lblNomeCli.Location = new System.Drawing.Point(85, 63);
            this.lblNomeCli.Name = "lblNomeCli";
            this.lblNomeCli.Size = new System.Drawing.Size(43, 15);
            this.lblNomeCli.TabIndex = 0;
            this.lblNomeCli.Text = "Nome:";
            // 
            // lblCelCli
            // 
            this.lblCelCli.AutoSize = true;
            this.lblCelCli.Location = new System.Drawing.Point(85, 116);
            this.lblCelCli.Name = "lblCelCli";
            this.lblCelCli.Size = new System.Drawing.Size(47, 15);
            this.lblCelCli.TabIndex = 1;
            this.lblCelCli.Text = "Celular:";
            // 
            // lblEmailCli
            // 
            this.lblEmailCli.AutoSize = true;
            this.lblEmailCli.Location = new System.Drawing.Point(85, 167);
            this.lblEmailCli.Name = "lblEmailCli";
            this.lblEmailCli.Size = new System.Drawing.Size(39, 15);
            this.lblEmailCli.TabIndex = 2;
            this.lblEmailCli.Text = "Email:";
            // 
            // lblCpfCli
            // 
            this.lblCpfCli.AutoSize = true;
            this.lblCpfCli.Location = new System.Drawing.Point(85, 219);
            this.lblCpfCli.Name = "lblCpfCli";
            this.lblCpfCli.Size = new System.Drawing.Size(31, 15);
            this.lblCpfCli.TabIndex = 3;
            this.lblCpfCli.Text = "CPF:";
            // 
            // lblTituloCli
            // 
            this.lblTituloCli.AutoSize = true;
            this.lblTituloCli.Location = new System.Drawing.Point(326, 23);
            this.lblTituloCli.Name = "lblTituloCli";
            this.lblTituloCli.Size = new System.Drawing.Size(97, 15);
            this.lblTituloCli.TabIndex = 4;
            this.lblTituloCli.Text = "Cadastre-se Aqui";
            // 
            // tbxNomeCli
            // 
            this.tbxNomeCli.Location = new System.Drawing.Point(161, 63);
            this.tbxNomeCli.Name = "tbxNomeCli";
            this.tbxNomeCli.Size = new System.Drawing.Size(191, 23);
            this.tbxNomeCli.TabIndex = 5;
            this.tbxNomeCli.TextChanged += new System.EventHandler(this.tbxNomeCli_TextChanged);
            // 
            // tbxCelCli
            // 
            this.tbxCelCli.Location = new System.Drawing.Point(161, 116);
            this.tbxCelCli.Name = "tbxCelCli";
            this.tbxCelCli.Size = new System.Drawing.Size(191, 23);
            this.tbxCelCli.TabIndex = 6;
            // 
            // tbxEmailCli
            // 
            this.tbxEmailCli.Location = new System.Drawing.Point(161, 167);
            this.tbxEmailCli.Name = "tbxEmailCli";
            this.tbxEmailCli.Size = new System.Drawing.Size(191, 23);
            this.tbxEmailCli.TabIndex = 7;
            // 
            // tbxCpfCli
            // 
            this.tbxCpfCli.Location = new System.Drawing.Point(161, 219);
            this.tbxCpfCli.Name = "tbxCpfCli";
            this.tbxCpfCli.Size = new System.Drawing.Size(191, 23);
            this.tbxCpfCli.TabIndex = 8;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(478, 291);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 9;
            this.button1.Text = "Cadastrar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // MenuCadastrar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tbxCpfCli);
            this.Controls.Add(this.tbxEmailCli);
            this.Controls.Add(this.tbxCelCli);
            this.Controls.Add(this.tbxNomeCli);
            this.Controls.Add(this.lblTituloCli);
            this.Controls.Add(this.lblCpfCli);
            this.Controls.Add(this.lblEmailCli);
            this.Controls.Add(this.lblCelCli);
            this.Controls.Add(this.lblNomeCli);
            this.Name = "MenuCadastrar";
            this.Text = "MenuCadastrar";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNomeCli;
        private System.Windows.Forms.Label lblCelCli;
        private System.Windows.Forms.Label lblEmailCli;
        private System.Windows.Forms.Label lblCpfCli;
        private System.Windows.Forms.Label lblTituloCli;
        private System.Windows.Forms.TextBox tbxNomeCli;
        private System.Windows.Forms.TextBox tbxCelCli;
        private System.Windows.Forms.TextBox tbxEmailCli;
        private System.Windows.Forms.TextBox tbxCpfCli;
        private System.Windows.Forms.Button button1;
    }
}