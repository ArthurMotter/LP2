namespace Triangulo
{
    partial class Form1
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
            this.lblA = new System.Windows.Forms.Label();
            this.lblB = new System.Windows.Forms.Label();
            this.lblC = new System.Windows.Forms.Label();
            this.txtbxA = new System.Windows.Forms.TextBox();
            this.txtbxB = new System.Windows.Forms.TextBox();
            this.txtbxC = new System.Windows.Forms.TextBox();
            this.CalcTriangulo = new System.Windows.Forms.Button();
            this.Limpar = new System.Windows.Forms.Button();
            this.Fechar = new System.Windows.Forms.Button();
            this.lblTriangulo = new System.Windows.Forms.Label();
            this.txtbxTipo = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblA
            // 
            this.lblA.AutoSize = true;
            this.lblA.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblA.Location = new System.Drawing.Point(120, 37);
            this.lblA.Name = "lblA";
            this.lblA.Size = new System.Drawing.Size(74, 25);
            this.lblA.TabIndex = 0;
            this.lblA.Text = "Valor1";
            // 
            // lblB
            // 
            this.lblB.AutoSize = true;
            this.lblB.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblB.Location = new System.Drawing.Point(120, 87);
            this.lblB.Name = "lblB";
            this.lblB.Size = new System.Drawing.Size(74, 25);
            this.lblB.TabIndex = 1;
            this.lblB.Text = "Valor2";
            // 
            // lblC
            // 
            this.lblC.AutoSize = true;
            this.lblC.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblC.Location = new System.Drawing.Point(120, 137);
            this.lblC.Name = "lblC";
            this.lblC.Size = new System.Drawing.Size(74, 25);
            this.lblC.TabIndex = 2;
            this.lblC.Text = "Valor3";
            // 
            // txtbxA
            // 
            this.txtbxA.Location = new System.Drawing.Point(200, 37);
            this.txtbxA.Name = "txtbxA";
            this.txtbxA.Size = new System.Drawing.Size(132, 20);
            this.txtbxA.TabIndex = 3;
            this.txtbxA.Validated += new System.EventHandler(this.TxtbxA_Validated);
            // 
            // txtbxB
            // 
            this.txtbxB.Location = new System.Drawing.Point(200, 92);
            this.txtbxB.Name = "txtbxB";
            this.txtbxB.Size = new System.Drawing.Size(132, 20);
            this.txtbxB.TabIndex = 4;
            this.txtbxB.Validated += new System.EventHandler(this.TxtbxB_Validated);
            // 
            // txtbxC
            // 
            this.txtbxC.Location = new System.Drawing.Point(200, 142);
            this.txtbxC.Name = "txtbxC";
            this.txtbxC.Size = new System.Drawing.Size(132, 20);
            this.txtbxC.TabIndex = 5;
            this.txtbxC.Validated += new System.EventHandler(this.TxtbxC_Validated);
            // 
            // CalcTriangulo
            // 
            this.CalcTriangulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CalcTriangulo.Location = new System.Drawing.Point(123, 349);
            this.CalcTriangulo.Name = "CalcTriangulo";
            this.CalcTriangulo.Size = new System.Drawing.Size(102, 64);
            this.CalcTriangulo.TabIndex = 6;
            this.CalcTriangulo.Text = "Calcular";
            this.CalcTriangulo.UseVisualStyleBackColor = true;
            this.CalcTriangulo.Click += new System.EventHandler(this.CalcTriangulo_Click);
            // 
            // Limpar
            // 
            this.Limpar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Limpar.Location = new System.Drawing.Point(335, 349);
            this.Limpar.Name = "Limpar";
            this.Limpar.Size = new System.Drawing.Size(102, 64);
            this.Limpar.TabIndex = 7;
            this.Limpar.Text = "Limpar";
            this.Limpar.UseVisualStyleBackColor = true;
            this.Limpar.Click += new System.EventHandler(this.Limpar_Click);
            // 
            // Fechar
            // 
            this.Fechar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Fechar.Location = new System.Drawing.Point(566, 349);
            this.Fechar.Name = "Fechar";
            this.Fechar.Size = new System.Drawing.Size(102, 64);
            this.Fechar.TabIndex = 8;
            this.Fechar.Text = "Fechar";
            this.Fechar.UseVisualStyleBackColor = true;
            this.Fechar.Click += new System.EventHandler(this.Fechar_Click);
            // 
            // lblTriangulo
            // 
            this.lblTriangulo.AutoSize = true;
            this.lblTriangulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTriangulo.Location = new System.Drawing.Point(123, 227);
            this.lblTriangulo.Name = "lblTriangulo";
            this.lblTriangulo.Size = new System.Drawing.Size(54, 25);
            this.lblTriangulo.TabIndex = 9;
            this.lblTriangulo.Text = "Tipo";
            // 
            // txtbxTipo
            // 
            this.txtbxTipo.Location = new System.Drawing.Point(183, 233);
            this.txtbxTipo.Name = "txtbxTipo";
            this.txtbxTipo.ReadOnly = true;
            this.txtbxTipo.Size = new System.Drawing.Size(149, 20);
            this.txtbxTipo.TabIndex = 10;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtbxTipo);
            this.Controls.Add(this.lblTriangulo);
            this.Controls.Add(this.Fechar);
            this.Controls.Add(this.Limpar);
            this.Controls.Add(this.CalcTriangulo);
            this.Controls.Add(this.txtbxC);
            this.Controls.Add(this.txtbxB);
            this.Controls.Add(this.txtbxA);
            this.Controls.Add(this.lblC);
            this.Controls.Add(this.lblB);
            this.Controls.Add(this.lblA);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblA;
        private System.Windows.Forms.Label lblB;
        private System.Windows.Forms.Label lblC;
        private System.Windows.Forms.TextBox txtbxA;
        private System.Windows.Forms.TextBox txtbxB;
        private System.Windows.Forms.TextBox txtbxC;
        private System.Windows.Forms.Button CalcTriangulo;
        private System.Windows.Forms.Button Limpar;
        private System.Windows.Forms.Button Fechar;
        private System.Windows.Forms.Label lblTriangulo;
        private System.Windows.Forms.TextBox txtbxTipo;
    }
}

