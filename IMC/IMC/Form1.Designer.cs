namespace IMC
{
    partial class Form1
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
            this.lblPeso = new System.Windows.Forms.Label();
            this.lblAltura = new System.Windows.Forms.Label();
            this.lblIMC = new System.Windows.Forms.Label();
            this.txtBxPeso = new System.Windows.Forms.TextBox();
            this.txtBxAltura = new System.Windows.Forms.TextBox();
            this.txtBxIMC = new System.Windows.Forms.TextBox();
            this.btnCalc = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnFechar = new System.Windows.Forms.Button();
            this.fileSystemWatcher1 = new System.IO.FileSystemWatcher();
            this.lblClassif = new System.Windows.Forms.Label();
            this.lblObesidade = new System.Windows.Forms.Label();
            this.txtBxClassific = new System.Windows.Forms.TextBox();
            this.txtBxObesidade = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblPeso
            // 
            this.lblPeso.AutoSize = true;
            this.lblPeso.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPeso.Location = new System.Drawing.Point(43, 79);
            this.lblPeso.Name = "lblPeso";
            this.lblPeso.Size = new System.Drawing.Size(61, 25);
            this.lblPeso.TabIndex = 0;
            this.lblPeso.Text = "Peso";
            // 
            // lblAltura
            // 
            this.lblAltura.AutoSize = true;
            this.lblAltura.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAltura.Location = new System.Drawing.Point(43, 147);
            this.lblAltura.Name = "lblAltura";
            this.lblAltura.Size = new System.Drawing.Size(68, 25);
            this.lblAltura.TabIndex = 1;
            this.lblAltura.Text = "Altura";
            // 
            // lblIMC
            // 
            this.lblIMC.AutoSize = true;
            this.lblIMC.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIMC.Location = new System.Drawing.Point(43, 214);
            this.lblIMC.Name = "lblIMC";
            this.lblIMC.Size = new System.Drawing.Size(50, 25);
            this.lblIMC.TabIndex = 2;
            this.lblIMC.Text = "IMC";
            // 
            // txtBxPeso
            // 
            this.txtBxPeso.Location = new System.Drawing.Point(110, 79);
            this.txtBxPeso.Name = "txtBxPeso";
            this.txtBxPeso.Size = new System.Drawing.Size(342, 20);
            this.txtBxPeso.TabIndex = 3;
            this.txtBxPeso.Validated += new System.EventHandler(this.txtBxPeso_Validated);
            // 
            // txtBxAltura
            // 
            this.txtBxAltura.Location = new System.Drawing.Point(117, 152);
            this.txtBxAltura.Name = "txtBxAltura";
            this.txtBxAltura.Size = new System.Drawing.Size(335, 20);
            this.txtBxAltura.TabIndex = 4;
            this.txtBxAltura.Validated += new System.EventHandler(this.txtBxAltura_Validated);
            // 
            // txtBxIMC
            // 
            this.txtBxIMC.Location = new System.Drawing.Point(99, 214);
            this.txtBxIMC.Name = "txtBxIMC";
            this.txtBxIMC.ReadOnly = true;
            this.txtBxIMC.Size = new System.Drawing.Size(353, 20);
            this.txtBxIMC.TabIndex = 5;
            // 
            // btnCalc
            // 
            this.btnCalc.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalc.Location = new System.Drawing.Point(152, 295);
            this.btnCalc.Name = "btnCalc";
            this.btnCalc.Size = new System.Drawing.Size(116, 79);
            this.btnCalc.TabIndex = 6;
            this.btnCalc.Text = "Calcular";
            this.btnCalc.UseVisualStyleBackColor = true;
            this.btnCalc.Click += new System.EventHandler(this.btnCalc_Click);
            // 
            // btnLimpar
            // 
            this.btnLimpar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpar.Location = new System.Drawing.Point(336, 295);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(116, 79);
            this.btnLimpar.TabIndex = 7;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // btnFechar
            // 
            this.btnFechar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFechar.Location = new System.Drawing.Point(530, 295);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(112, 79);
            this.btnFechar.TabIndex = 8;
            this.btnFechar.Text = "fechar";
            this.btnFechar.UseVisualStyleBackColor = true;
            this.btnFechar.Click += new System.EventHandler(this.btnFechar_Click);
            // 
            // fileSystemWatcher1
            // 
            this.fileSystemWatcher1.EnableRaisingEvents = true;
            this.fileSystemWatcher1.SynchronizingObject = this;
            // 
            // lblClassif
            // 
            this.lblClassif.AutoSize = true;
            this.lblClassif.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClassif.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblClassif.Location = new System.Drawing.Point(524, 79);
            this.lblClassif.Name = "lblClassif";
            this.lblClassif.Size = new System.Drawing.Size(118, 24);
            this.lblClassif.TabIndex = 9;
            this.lblClassif.Text = "Classificação";
            // 
            // lblObesidade
            // 
            this.lblObesidade.AutoSize = true;
            this.lblObesidade.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblObesidade.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblObesidade.Location = new System.Drawing.Point(524, 156);
            this.lblObesidade.Name = "lblObesidade";
            this.lblObesidade.Size = new System.Drawing.Size(103, 24);
            this.lblObesidade.TabIndex = 10;
            this.lblObesidade.Text = "Obesidade";
            // 
            // txtBxClassific
            // 
            this.txtBxClassific.Location = new System.Drawing.Point(527, 116);
            this.txtBxClassific.Name = "txtBxClassific";
            this.txtBxClassific.ReadOnly = true;
            this.txtBxClassific.Size = new System.Drawing.Size(174, 20);
            this.txtBxClassific.TabIndex = 11;
            // 
            // txtBxObesidade
            // 
            this.txtBxObesidade.Location = new System.Drawing.Point(527, 200);
            this.txtBxObesidade.Name = "txtBxObesidade";
            this.txtBxObesidade.ReadOnly = true;
            this.txtBxObesidade.Size = new System.Drawing.Size(174, 20);
            this.txtBxObesidade.TabIndex = 12;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtBxObesidade);
            this.Controls.Add(this.txtBxClassific);
            this.Controls.Add(this.lblObesidade);
            this.Controls.Add(this.lblClassif);
            this.Controls.Add(this.btnFechar);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.btnCalc);
            this.Controls.Add(this.txtBxIMC);
            this.Controls.Add(this.txtBxAltura);
            this.Controls.Add(this.txtBxPeso);
            this.Controls.Add(this.lblIMC);
            this.Controls.Add(this.lblAltura);
            this.Controls.Add(this.lblPeso);
            this.Name = "Form1";
            this.Text = "Calculador de IMC";
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblPeso;
        private System.Windows.Forms.Label lblAltura;
        private System.Windows.Forms.Label lblIMC;
        private System.Windows.Forms.TextBox txtBxPeso;
        private System.Windows.Forms.TextBox txtBxAltura;
        private System.Windows.Forms.TextBox txtBxIMC;
        private System.Windows.Forms.Button btnCalc;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Button btnFechar;
        private System.IO.FileSystemWatcher fileSystemWatcher1;
        private System.Windows.Forms.Label lblObesidade;
        private System.Windows.Forms.Label lblClassif;
        private System.Windows.Forms.TextBox txtBxObesidade;
        private System.Windows.Forms.TextBox txtBxClassific;
    }
}

