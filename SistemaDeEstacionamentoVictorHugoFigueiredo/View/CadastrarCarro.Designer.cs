
namespace SistemaDeEstacionamentoVictorHugoFigueiredo.View
{
    partial class CadastrarCarro
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CadastrarCarro));
            this.lblTituloCar = new System.Windows.Forms.Label();
            this.lblNomeCar = new System.Windows.Forms.Label();
            this.lblCorCar = new System.Windows.Forms.Label();
            this.lblMarcaCar = new System.Windows.Forms.Label();
            this.lblPlacaCar = new System.Windows.Forms.Label();
            this.tbxPlacaCar = new System.Windows.Forms.TextBox();
            this.btnCadastrarCarro = new System.Windows.Forms.Button();
            this.tbxCorCar = new System.Windows.Forms.ComboBox();
            this.tbxMarcaCar = new System.Windows.Forms.ComboBox();
            this.tbxNomeCar = new System.Windows.Forms.ComboBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTituloCar
            // 
            this.lblTituloCar.AutoSize = true;
            this.lblTituloCar.Font = new System.Drawing.Font("Segoe UI Semibold", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTituloCar.Location = new System.Drawing.Point(184, 21);
            this.lblTituloCar.Name = "lblTituloCar";
            this.lblTituloCar.Size = new System.Drawing.Size(224, 28);
            this.lblTituloCar.TabIndex = 0;
            this.lblTituloCar.Text = "Cadastre seu carro aqui";
            // 
            // lblNomeCar
            // 
            this.lblNomeCar.AutoSize = true;
            this.lblNomeCar.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblNomeCar.Location = new System.Drawing.Point(140, 150);
            this.lblNomeCar.Name = "lblNomeCar";
            this.lblNomeCar.Size = new System.Drawing.Size(106, 17);
            this.lblNomeCar.TabIndex = 1;
            this.lblNomeCar.Text = "Nome do carro :";
            // 
            // lblCorCar
            // 
            this.lblCorCar.AutoSize = true;
            this.lblCorCar.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblCorCar.Location = new System.Drawing.Point(135, 203);
            this.lblCorCar.Name = "lblCorCar";
            this.lblCorCar.Size = new System.Drawing.Size(32, 17);
            this.lblCorCar.TabIndex = 2;
            this.lblCorCar.Text = "Cor:";
            // 
            // lblMarcaCar
            // 
            this.lblMarcaCar.AutoSize = true;
            this.lblMarcaCar.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblMarcaCar.Location = new System.Drawing.Point(135, 260);
            this.lblMarcaCar.Name = "lblMarcaCar";
            this.lblMarcaCar.Size = new System.Drawing.Size(48, 17);
            this.lblMarcaCar.TabIndex = 3;
            this.lblMarcaCar.Text = "Marca:";
            // 
            // lblPlacaCar
            // 
            this.lblPlacaCar.AutoSize = true;
            this.lblPlacaCar.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblPlacaCar.Location = new System.Drawing.Point(135, 310);
            this.lblPlacaCar.Name = "lblPlacaCar";
            this.lblPlacaCar.Size = new System.Drawing.Size(41, 17);
            this.lblPlacaCar.TabIndex = 4;
            this.lblPlacaCar.Text = "Placa:";
            // 
            // tbxPlacaCar
            // 
            this.tbxPlacaCar.Location = new System.Drawing.Point(184, 307);
            this.tbxPlacaCar.Name = "tbxPlacaCar";
            this.tbxPlacaCar.Size = new System.Drawing.Size(121, 23);
            this.tbxPlacaCar.TabIndex = 8;
            // 
            // btnCadastrarCarro
            // 
            this.btnCadastrarCarro.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnCadastrarCarro.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnCadastrarCarro.Location = new System.Drawing.Point(379, 302);
            this.btnCadastrarCarro.Name = "btnCadastrarCarro";
            this.btnCadastrarCarro.Size = new System.Drawing.Size(131, 38);
            this.btnCadastrarCarro.TabIndex = 9;
            this.btnCadastrarCarro.Text = "Cadastrar";
            this.btnCadastrarCarro.UseVisualStyleBackColor = false;
            this.btnCadastrarCarro.Click += new System.EventHandler(this.btnCadastrarCarro_Click);
            // 
            // tbxCorCar
            // 
            this.tbxCorCar.FormattingEnabled = true;
            this.tbxCorCar.Items.AddRange(new object[] {
            "Branco",
            "Preto",
            "Prata",
            "Azul"});
            this.tbxCorCar.Location = new System.Drawing.Point(184, 197);
            this.tbxCorCar.Name = "tbxCorCar";
            this.tbxCorCar.Size = new System.Drawing.Size(121, 23);
            this.tbxCorCar.TabIndex = 10;
            // 
            // tbxMarcaCar
            // 
            this.tbxMarcaCar.FormattingEnabled = true;
            this.tbxMarcaCar.Items.AddRange(new object[] {
            "Nisan",
            "Toyota",
            "Chevrolet"});
            this.tbxMarcaCar.Location = new System.Drawing.Point(184, 260);
            this.tbxMarcaCar.Name = "tbxMarcaCar";
            this.tbxMarcaCar.Size = new System.Drawing.Size(121, 23);
            this.tbxMarcaCar.TabIndex = 11;
            // 
            // tbxNomeCar
            // 
            this.tbxNomeCar.FormattingEnabled = true;
            this.tbxNomeCar.Items.AddRange(new object[] {
            "Uno",
            "FordK",
            "Savero"});
            this.tbxNomeCar.Location = new System.Drawing.Point(252, 149);
            this.tbxNomeCar.Name = "tbxNomeCar";
            this.tbxNomeCar.Size = new System.Drawing.Size(121, 23);
            this.tbxNomeCar.TabIndex = 12;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(26, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(65, 63);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
            // 
            // CadastrarCarro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(573, 424);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.tbxNomeCar);
            this.Controls.Add(this.tbxMarcaCar);
            this.Controls.Add(this.tbxCorCar);
            this.Controls.Add(this.btnCadastrarCarro);
            this.Controls.Add(this.tbxPlacaCar);
            this.Controls.Add(this.lblPlacaCar);
            this.Controls.Add(this.lblMarcaCar);
            this.Controls.Add(this.lblCorCar);
            this.Controls.Add(this.lblNomeCar);
            this.Controls.Add(this.lblTituloCar);
            this.KeyPreview = true;
            this.Name = "CadastrarCarro";
            this.Text = "CadastrarCarro";
            this.Load += new System.EventHandler(this.CadastrarCarro_Load);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.CadastrarCarro_KeyPress);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTituloCar;
        private System.Windows.Forms.Label lblNomeCar;
        private System.Windows.Forms.Label lblCorCar;
        private System.Windows.Forms.Label lblMarcaCar;
        private System.Windows.Forms.Label lblPlacaCar;
        private System.Windows.Forms.TextBox tbxPlacaCar;
        private System.Windows.Forms.Button btnCadastrarCarro;
        private System.Windows.Forms.ComboBox tbxCorCar;
        private System.Windows.Forms.ComboBox tbxMarcaCar;
        private System.Windows.Forms.ComboBox tbxNomeCar;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}