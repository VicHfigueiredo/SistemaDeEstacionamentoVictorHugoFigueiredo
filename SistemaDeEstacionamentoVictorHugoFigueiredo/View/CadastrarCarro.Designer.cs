
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
            this.lblTituloCar = new System.Windows.Forms.Label();
            this.lblNomeCar = new System.Windows.Forms.Label();
            this.lblCorCar = new System.Windows.Forms.Label();
            this.lblMarcaCar = new System.Windows.Forms.Label();
            this.lblPlacaCar = new System.Windows.Forms.Label();
            this.tbxNomeCar = new System.Windows.Forms.TextBox();
            this.tbxCorCar = new System.Windows.Forms.TextBox();
            this.tbxMarcaCar = new System.Windows.Forms.TextBox();
            this.tbxPlacaCar = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblTituloCar
            // 
            this.lblTituloCar.AutoSize = true;
            this.lblTituloCar.Location = new System.Drawing.Point(347, 38);
            this.lblTituloCar.Name = "lblTituloCar";
            this.lblTituloCar.Size = new System.Drawing.Size(130, 15);
            this.lblTituloCar.TabIndex = 0;
            this.lblTituloCar.Text = "Cadastre seu carro aqui";
            // 
            // lblNomeCar
            // 
            this.lblNomeCar.AutoSize = true;
            this.lblNomeCar.Location = new System.Drawing.Point(105, 82);
            this.lblNomeCar.Name = "lblNomeCar";
            this.lblNomeCar.Size = new System.Drawing.Size(43, 15);
            this.lblNomeCar.TabIndex = 1;
            this.lblNomeCar.Text = "Nome:";
            // 
            // lblCorCar
            // 
            this.lblCorCar.AutoSize = true;
            this.lblCorCar.Location = new System.Drawing.Point(105, 140);
            this.lblCorCar.Name = "lblCorCar";
            this.lblCorCar.Size = new System.Drawing.Size(29, 15);
            this.lblCorCar.TabIndex = 2;
            this.lblCorCar.Text = "Cor:";
            // 
            // lblMarcaCar
            // 
            this.lblMarcaCar.AutoSize = true;
            this.lblMarcaCar.Location = new System.Drawing.Point(105, 200);
            this.lblMarcaCar.Name = "lblMarcaCar";
            this.lblMarcaCar.Size = new System.Drawing.Size(43, 15);
            this.lblMarcaCar.TabIndex = 3;
            this.lblMarcaCar.Text = "Marca:";
            // 
            // lblPlacaCar
            // 
            this.lblPlacaCar.AutoSize = true;
            this.lblPlacaCar.Location = new System.Drawing.Point(105, 251);
            this.lblPlacaCar.Name = "lblPlacaCar";
            this.lblPlacaCar.Size = new System.Drawing.Size(38, 15);
            this.lblPlacaCar.TabIndex = 4;
            this.lblPlacaCar.Text = "Placa:";
            // 
            // tbxNomeCar
            // 
            this.tbxNomeCar.Location = new System.Drawing.Point(172, 82);
            this.tbxNomeCar.Name = "tbxNomeCar";
            this.tbxNomeCar.Size = new System.Drawing.Size(100, 23);
            this.tbxNomeCar.TabIndex = 5;
            // 
            // tbxCorCar
            // 
            this.tbxCorCar.Location = new System.Drawing.Point(172, 140);
            this.tbxCorCar.Name = "tbxCorCar";
            this.tbxCorCar.Size = new System.Drawing.Size(100, 23);
            this.tbxCorCar.TabIndex = 6;
            // 
            // tbxMarcaCar
            // 
            this.tbxMarcaCar.Location = new System.Drawing.Point(172, 200);
            this.tbxMarcaCar.Name = "tbxMarcaCar";
            this.tbxMarcaCar.Size = new System.Drawing.Size(100, 23);
            this.tbxMarcaCar.TabIndex = 7;
            // 
            // tbxPlacaCar
            // 
            this.tbxPlacaCar.Location = new System.Drawing.Point(172, 251);
            this.tbxPlacaCar.Name = "tbxPlacaCar";
            this.tbxPlacaCar.Size = new System.Drawing.Size(100, 23);
            this.tbxPlacaCar.TabIndex = 8;
            // 
            // CadastrarCarro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tbxPlacaCar);
            this.Controls.Add(this.tbxMarcaCar);
            this.Controls.Add(this.tbxCorCar);
            this.Controls.Add(this.tbxNomeCar);
            this.Controls.Add(this.lblPlacaCar);
            this.Controls.Add(this.lblMarcaCar);
            this.Controls.Add(this.lblCorCar);
            this.Controls.Add(this.lblNomeCar);
            this.Controls.Add(this.lblTituloCar);
            this.Name = "CadastrarCarro";
            this.Text = "CadastrarCarro";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTituloCar;
        private System.Windows.Forms.Label lblNomeCar;
        private System.Windows.Forms.Label lblCorCar;
        private System.Windows.Forms.Label lblMarcaCar;
        private System.Windows.Forms.Label lblPlacaCar;
        private System.Windows.Forms.TextBox tbxNomeCar;
        private System.Windows.Forms.TextBox tbxCorCar;
        private System.Windows.Forms.TextBox tbxMarcaCar;
        private System.Windows.Forms.TextBox tbxPlacaCar;
    }
}