
namespace SistemaDeEstacionamentoVictorHugoFigueiredo.View
{
    partial class Ticket
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Ticket));
            this.lblTituloT = new System.Windows.Forms.Label();
            this.lblNomeT = new System.Windows.Forms.Label();
            this.lblDataT = new System.Windows.Forms.Label();
            this.lblPlacaT = new System.Windows.Forms.Label();
            this.lblCorT = new System.Windows.Forms.Label();
            this.btnCadastroT = new System.Windows.Forms.Button();
            this.tbxPlacaT = new System.Windows.Forms.TextBox();
            this.tbxCorT = new System.Windows.Forms.ComboBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tbxNomeT = new System.Windows.Forms.ComboBox();
            this.tbxDataT = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTituloT
            // 
            this.lblTituloT.AutoSize = true;
            this.lblTituloT.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTituloT.Location = new System.Drawing.Point(172, 19);
            this.lblTituloT.Name = "lblTituloT";
            this.lblTituloT.Size = new System.Drawing.Size(232, 25);
            this.lblTituloT.TabIndex = 0;
            this.lblTituloT.Text = "Ticket do estacionamento";
            // 
            // lblNomeT
            // 
            this.lblNomeT.AutoSize = true;
            this.lblNomeT.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblNomeT.Location = new System.Drawing.Point(109, 119);
            this.lblNomeT.Name = "lblNomeT";
            this.lblNomeT.Size = new System.Drawing.Size(47, 17);
            this.lblNomeT.TabIndex = 1;
            this.lblNomeT.Text = "Nome:";
            // 
            // lblDataT
            // 
            this.lblDataT.AutoSize = true;
            this.lblDataT.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblDataT.Location = new System.Drawing.Point(109, 176);
            this.lblDataT.Name = "lblDataT";
            this.lblDataT.Size = new System.Drawing.Size(38, 17);
            this.lblDataT.TabIndex = 2;
            this.lblDataT.Text = "Data:";
            // 
            // lblPlacaT
            // 
            this.lblPlacaT.AutoSize = true;
            this.lblPlacaT.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblPlacaT.Location = new System.Drawing.Point(109, 232);
            this.lblPlacaT.Name = "lblPlacaT";
            this.lblPlacaT.Size = new System.Drawing.Size(96, 17);
            this.lblPlacaT.TabIndex = 3;
            this.lblPlacaT.Text = "Placa do carro:";
            // 
            // lblCorT
            // 
            this.lblCorT.AutoSize = true;
            this.lblCorT.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblCorT.Location = new System.Drawing.Point(109, 289);
            this.lblCorT.Name = "lblCorT";
            this.lblCorT.Size = new System.Drawing.Size(32, 17);
            this.lblCorT.TabIndex = 4;
            this.lblCorT.Text = "Cor:";
            // 
            // btnCadastroT
            // 
            this.btnCadastroT.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnCadastroT.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnCadastroT.Location = new System.Drawing.Point(421, 335);
            this.btnCadastroT.Name = "btnCadastroT";
            this.btnCadastroT.Size = new System.Drawing.Size(135, 35);
            this.btnCadastroT.TabIndex = 5;
            this.btnCadastroT.Text = "Gerar Ticket";
            this.btnCadastroT.UseVisualStyleBackColor = false;
            this.btnCadastroT.Click += new System.EventHandler(this.btnCadastroT_Click);
            // 
            // tbxPlacaT
            // 
            this.tbxPlacaT.Location = new System.Drawing.Point(211, 231);
            this.tbxPlacaT.Name = "tbxPlacaT";
            this.tbxPlacaT.Size = new System.Drawing.Size(119, 23);
            this.tbxPlacaT.TabIndex = 8;
            // 
            // tbxCorT
            // 
            this.tbxCorT.FormattingEnabled = true;
            this.tbxCorT.Items.AddRange(new object[] {
            "Branco",
            "Preto",
            "Prata",
            "Azul"});
            this.tbxCorT.Location = new System.Drawing.Point(162, 289);
            this.tbxCorT.Name = "tbxCorT";
            this.tbxCorT.Size = new System.Drawing.Size(168, 23);
            this.tbxCorT.TabIndex = 10;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(25, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(65, 63);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // tbxNomeT
            // 
            this.tbxNomeT.FormattingEnabled = true;
            this.tbxNomeT.Items.AddRange(new object[] {
            "Uno",
            "FordK",
            "Savero"});
            this.tbxNomeT.Location = new System.Drawing.Point(172, 118);
            this.tbxNomeT.Name = "tbxNomeT";
            this.tbxNomeT.Size = new System.Drawing.Size(128, 23);
            this.tbxNomeT.TabIndex = 12;
            // 
            // tbxDataT
            // 
            this.tbxDataT.Location = new System.Drawing.Point(162, 176);
            this.tbxDataT.Name = "tbxDataT";
            this.tbxDataT.Size = new System.Drawing.Size(116, 23);
            this.tbxDataT.TabIndex = 7;
            // 
            // Ticket
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(585, 402);
            this.Controls.Add(this.tbxNomeT);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.tbxCorT);
            this.Controls.Add(this.tbxPlacaT);
            this.Controls.Add(this.tbxDataT);
            this.Controls.Add(this.btnCadastroT);
            this.Controls.Add(this.lblCorT);
            this.Controls.Add(this.lblPlacaT);
            this.Controls.Add(this.lblDataT);
            this.Controls.Add(this.lblNomeT);
            this.Controls.Add(this.lblTituloT);
            this.KeyPreview = true;
            this.Name = "Ticket";
            this.Text = "Ticket";
            this.Load += new System.EventHandler(this.Ticket_Load);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Ticket_KeyPress);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTituloT;
        private System.Windows.Forms.Label lblNomeT;
        private System.Windows.Forms.Label lblDataT;
        private System.Windows.Forms.Label lblPlacaT;
        private System.Windows.Forms.Label lblCorT;
        private System.Windows.Forms.Button btnCadastroT;
        private System.Windows.Forms.TextBox tbxPlacaT;
        private System.Windows.Forms.ComboBox tbxCorT;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ComboBox tbxNomeT;
        private System.Windows.Forms.TextBox tbxDataT;
    }
}