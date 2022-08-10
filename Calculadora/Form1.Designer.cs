namespace Calculadora
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
            this.buttonCalc = new System.Windows.Forms.Button();
            this.buttonClear = new System.Windows.Forms.Button();
            this.labelTitle = new System.Windows.Forms.Label();
            this.mtbPeso = new System.Windows.Forms.TextBox();
            this.mtbAltura = new System.Windows.Forms.TextBox();
            this.labelPeso = new System.Windows.Forms.Label();
            this.labelAltura = new System.Windows.Forms.Label();
            this.labelKg = new System.Windows.Forms.Label();
            this.labelCm = new System.Windows.Forms.Label();
            this.labelResult = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonCalc
            // 
            this.buttonCalc.Location = new System.Drawing.Point(337, 243);
            this.buttonCalc.Name = "buttonCalc";
            this.buttonCalc.Size = new System.Drawing.Size(75, 23);
            this.buttonCalc.TabIndex = 0;
            this.buttonCalc.Text = "Calcular";
            this.buttonCalc.UseVisualStyleBackColor = true;
            this.buttonCalc.Click += new System.EventHandler(this.buttonCalc_Click);
            // 
            // buttonClear
            // 
            this.buttonClear.Location = new System.Drawing.Point(488, 243);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(75, 23);
            this.buttonClear.TabIndex = 1;
            this.buttonClear.Text = "Limpar";
            this.buttonClear.UseVisualStyleBackColor = true;
            this.buttonClear.Click += new System.EventHandler(this.buttonClear_Click);
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Location = new System.Drawing.Point(364, 98);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(148, 15);
            this.labelTitle.TabIndex = 2;
            this.labelTitle.Text = "Sistema de Cálculo de IMC";
            // 
            // mtbPeso
            // 
            this.mtbPeso.Location = new System.Drawing.Point(294, 136);
            this.mtbPeso.Name = "mtbPeso";
            this.mtbPeso.Size = new System.Drawing.Size(296, 23);
            this.mtbPeso.TabIndex = 3;
            // 
            // mtbAltura
            // 
            this.mtbAltura.Location = new System.Drawing.Point(294, 191);
            this.mtbAltura.Name = "mtbAltura";
            this.mtbAltura.Size = new System.Drawing.Size(296, 23);
            this.mtbAltura.TabIndex = 4;
            // 
            // labelPeso
            // 
            this.labelPeso.AutoSize = true;
            this.labelPeso.Location = new System.Drawing.Point(243, 139);
            this.labelPeso.Name = "labelPeso";
            this.labelPeso.Size = new System.Drawing.Size(38, 15);
            this.labelPeso.TabIndex = 5;
            this.labelPeso.Text = "Peso :";
            // 
            // labelAltura
            // 
            this.labelAltura.AutoSize = true;
            this.labelAltura.Location = new System.Drawing.Point(243, 199);
            this.labelAltura.Name = "labelAltura";
            this.labelAltura.Size = new System.Drawing.Size(45, 15);
            this.labelAltura.TabIndex = 6;
            this.labelAltura.Text = "Altura :";
            // 
            // labelKg
            // 
            this.labelKg.AutoSize = true;
            this.labelKg.Location = new System.Drawing.Point(593, 139);
            this.labelKg.Name = "labelKg";
            this.labelKg.Size = new System.Drawing.Size(21, 15);
            this.labelKg.TabIndex = 7;
            this.labelKg.Text = "Kg";
            // 
            // labelCm
            // 
            this.labelCm.AutoSize = true;
            this.labelCm.Location = new System.Drawing.Point(593, 194);
            this.labelCm.Name = "labelCm";
            this.labelCm.Size = new System.Drawing.Size(24, 15);
            this.labelCm.TabIndex = 8;
            this.labelCm.Text = "cm";
            // 
            // labelResult
            // 
            this.labelResult.AutoSize = true;
            this.labelResult.Location = new System.Drawing.Point(591, 352);
            this.labelResult.Name = "labelResult";
            this.labelResult.Size = new System.Drawing.Size(59, 15);
            this.labelResult.TabIndex = 9;
            this.labelResult.Text = "Resultado";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(387, 33);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 50);
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.labelResult);
            this.Controls.Add(this.labelCm);
            this.Controls.Add(this.labelKg);
            this.Controls.Add(this.labelAltura);
            this.Controls.Add(this.labelPeso);
            this.Controls.Add(this.mtbAltura);
            this.Controls.Add(this.mtbPeso);
            this.Controls.Add(this.labelTitle);
            this.Controls.Add(this.buttonClear);
            this.Controls.Add(this.buttonCalc);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button buttonCalc;
        private Button buttonClear;
        private Label labelTitle;
        private TextBox mtbPeso;
        private TextBox mtbAltura;
        private Label labelPeso;
        private Label labelAltura;
        private Label labelKg;
        private Label labelCm;
        private Label labelResult;
        private PictureBox pictureBox1;
    }
}