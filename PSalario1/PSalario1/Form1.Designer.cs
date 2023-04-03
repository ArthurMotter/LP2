namespace PSalario1
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
            this.lblNomeFunc = new System.Windows.Forms.Label();
            this.lblSalBruto = new System.Windows.Forms.Label();
            this.lblNumFilhos = new System.Windows.Forms.Label();
            this.lblAliqINSS = new System.Windows.Forms.Label();
            this.lblAliqIRPF = new System.Windows.Forms.Label();
            this.lblSalFamil = new System.Windows.Forms.Label();
            this.lblSalLiq = new System.Windows.Forms.Label();
            this.lblDescINSS = new System.Windows.Forms.Label();
            this.lblDescIRPF = new System.Windows.Forms.Label();
            this.TxtBxNomFunc = new System.Windows.Forms.TextBox();
            this.txtBxSalBruto = new System.Windows.Forms.TextBox();
            this.txtBxAliqINSS = new System.Windows.Forms.TextBox();
            this.txtBxAliqIRPF = new System.Windows.Forms.TextBox();
            this.txtBxSalFamil = new System.Windows.Forms.TextBox();
            this.txtBxSalLiq = new System.Windows.Forms.TextBox();
            this.txtBxDescINSS = new System.Windows.Forms.TextBox();
            this.txtBxDescIRPF = new System.Windows.Forms.TextBox();
            this.btnCalc = new System.Windows.Forms.Button();
            this.NmUpDn = new System.Windows.Forms.NumericUpDown();
            this.gpBxSexo = new System.Windows.Forms.GroupBox();
            this.RbtnSexM = new System.Windows.Forms.RadioButton();
            this.RbtnSexF = new System.Windows.Forms.RadioButton();
            this.ckBxEstCivil = new System.Windows.Forms.CheckBox();
            this.lblDados = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.NmUpDn)).BeginInit();
            this.gpBxSexo.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblNomeFunc
            // 
            this.lblNomeFunc.AutoSize = true;
            this.lblNomeFunc.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomeFunc.Location = new System.Drawing.Point(12, 54);
            this.lblNomeFunc.Name = "lblNomeFunc";
            this.lblNomeFunc.Size = new System.Drawing.Size(187, 25);
            this.lblNomeFunc.TabIndex = 0;
            this.lblNomeFunc.Text = "Nome Funcionário";
            // 
            // lblSalBruto
            // 
            this.lblSalBruto.AutoSize = true;
            this.lblSalBruto.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSalBruto.Location = new System.Drawing.Point(12, 92);
            this.lblSalBruto.Name = "lblSalBruto";
            this.lblSalBruto.Size = new System.Drawing.Size(136, 25);
            this.lblSalBruto.TabIndex = 1;
            this.lblSalBruto.Text = "Salário Bruto";
            // 
            // lblNumFilhos
            // 
            this.lblNumFilhos.AutoSize = true;
            this.lblNumFilhos.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumFilhos.Location = new System.Drawing.Point(12, 132);
            this.lblNumFilhos.Name = "lblNumFilhos";
            this.lblNumFilhos.Size = new System.Drawing.Size(181, 25);
            this.lblNumFilhos.TabIndex = 2;
            this.lblNumFilhos.Text = "Número de Filhos";
            // 
            // lblAliqINSS
            // 
            this.lblAliqINSS.AutoSize = true;
            this.lblAliqINSS.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAliqINSS.Location = new System.Drawing.Point(19, 280);
            this.lblAliqINSS.Name = "lblAliqINSS";
            this.lblAliqINSS.Size = new System.Drawing.Size(144, 25);
            this.lblAliqINSS.TabIndex = 3;
            this.lblAliqINSS.Text = "Alíquota INSS";
            // 
            // lblAliqIRPF
            // 
            this.lblAliqIRPF.AutoSize = true;
            this.lblAliqIRPF.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAliqIRPF.Location = new System.Drawing.Point(19, 321);
            this.lblAliqIRPF.Name = "lblAliqIRPF";
            this.lblAliqIRPF.Size = new System.Drawing.Size(143, 25);
            this.lblAliqIRPF.TabIndex = 4;
            this.lblAliqIRPF.Text = "Alíquota IRPF";
            // 
            // lblSalFamil
            // 
            this.lblSalFamil.AutoSize = true;
            this.lblSalFamil.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSalFamil.Location = new System.Drawing.Point(19, 367);
            this.lblSalFamil.Name = "lblSalFamil";
            this.lblSalFamil.Size = new System.Drawing.Size(154, 25);
            this.lblSalFamil.TabIndex = 5;
            this.lblSalFamil.Text = "Salário Família";
            // 
            // lblSalLiq
            // 
            this.lblSalLiq.AutoSize = true;
            this.lblSalLiq.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSalLiq.Location = new System.Drawing.Point(19, 404);
            this.lblSalLiq.Name = "lblSalLiq";
            this.lblSalLiq.Size = new System.Drawing.Size(155, 25);
            this.lblSalLiq.TabIndex = 6;
            this.lblSalLiq.Text = "Salário Líquido";
            // 
            // lblDescINSS
            // 
            this.lblDescINSS.AutoSize = true;
            this.lblDescINSS.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescINSS.Location = new System.Drawing.Point(449, 274);
            this.lblDescINSS.Name = "lblDescINSS";
            this.lblDescINSS.Size = new System.Drawing.Size(157, 25);
            this.lblDescINSS.TabIndex = 7;
            this.lblDescINSS.Text = "Desconto INSS";
            // 
            // lblDescIRPF
            // 
            this.lblDescIRPF.AutoSize = true;
            this.lblDescIRPF.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescIRPF.Location = new System.Drawing.Point(449, 310);
            this.lblDescIRPF.Name = "lblDescIRPF";
            this.lblDescIRPF.Size = new System.Drawing.Size(156, 25);
            this.lblDescIRPF.TabIndex = 8;
            this.lblDescIRPF.Text = "Desconto IRPF";
            // 
            // TxtBxNomFunc
            // 
            this.TxtBxNomFunc.Location = new System.Drawing.Point(203, 56);
            this.TxtBxNomFunc.Name = "TxtBxNomFunc";
            this.TxtBxNomFunc.Size = new System.Drawing.Size(226, 20);
            this.TxtBxNomFunc.TabIndex = 9;
            this.TxtBxNomFunc.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtBxNomFunc_KeyPress);
            // 
            // txtBxSalBruto
            // 
            this.txtBxSalBruto.Location = new System.Drawing.Point(203, 94);
            this.txtBxSalBruto.Name = "txtBxSalBruto";
            this.txtBxSalBruto.Size = new System.Drawing.Size(226, 20);
            this.txtBxSalBruto.TabIndex = 10;
            this.txtBxSalBruto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtBxSalBruto_KeyPress);
            // 
            // txtBxAliqINSS
            // 
            this.txtBxAliqINSS.Location = new System.Drawing.Point(183, 280);
            this.txtBxAliqINSS.Name = "txtBxAliqINSS";
            this.txtBxAliqINSS.ReadOnly = true;
            this.txtBxAliqINSS.Size = new System.Drawing.Size(226, 20);
            this.txtBxAliqINSS.TabIndex = 12;
            // 
            // txtBxAliqIRPF
            // 
            this.txtBxAliqIRPF.Location = new System.Drawing.Point(183, 321);
            this.txtBxAliqIRPF.Name = "txtBxAliqIRPF";
            this.txtBxAliqIRPF.ReadOnly = true;
            this.txtBxAliqIRPF.Size = new System.Drawing.Size(226, 20);
            this.txtBxAliqIRPF.TabIndex = 13;
            // 
            // txtBxSalFamil
            // 
            this.txtBxSalFamil.Location = new System.Drawing.Point(183, 367);
            this.txtBxSalFamil.Name = "txtBxSalFamil";
            this.txtBxSalFamil.ReadOnly = true;
            this.txtBxSalFamil.Size = new System.Drawing.Size(226, 20);
            this.txtBxSalFamil.TabIndex = 14;
            // 
            // txtBxSalLiq
            // 
            this.txtBxSalLiq.Location = new System.Drawing.Point(183, 404);
            this.txtBxSalLiq.Name = "txtBxSalLiq";
            this.txtBxSalLiq.ReadOnly = true;
            this.txtBxSalLiq.Size = new System.Drawing.Size(226, 20);
            this.txtBxSalLiq.TabIndex = 15;
            // 
            // txtBxDescINSS
            // 
            this.txtBxDescINSS.Location = new System.Drawing.Point(611, 276);
            this.txtBxDescINSS.Name = "txtBxDescINSS";
            this.txtBxDescINSS.ReadOnly = true;
            this.txtBxDescINSS.Size = new System.Drawing.Size(177, 20);
            this.txtBxDescINSS.TabIndex = 16;
            // 
            // txtBxDescIRPF
            // 
            this.txtBxDescIRPF.Location = new System.Drawing.Point(611, 312);
            this.txtBxDescIRPF.Name = "txtBxDescIRPF";
            this.txtBxDescIRPF.ReadOnly = true;
            this.txtBxDescIRPF.Size = new System.Drawing.Size(177, 20);
            this.txtBxDescIRPF.TabIndex = 17;
            // 
            // btnCalc
            // 
            this.btnCalc.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalc.Location = new System.Drawing.Point(307, 180);
            this.btnCalc.Name = "btnCalc";
            this.btnCalc.Size = new System.Drawing.Size(198, 72);
            this.btnCalc.TabIndex = 18;
            this.btnCalc.Text = "Verificar Desconto";
            this.btnCalc.UseVisualStyleBackColor = true;
            this.btnCalc.Click += new System.EventHandler(this.BtnCalc_Click);
            // 
            // NmUpDn
            // 
            this.NmUpDn.Location = new System.Drawing.Point(203, 135);
            this.NmUpDn.Name = "NmUpDn";
            this.NmUpDn.Size = new System.Drawing.Size(226, 20);
            this.NmUpDn.TabIndex = 20;
            this.NmUpDn.Validated += new System.EventHandler(this.NmUpDn_Validated);
            // 
            // gpBxSexo
            // 
            this.gpBxSexo.Controls.Add(this.RbtnSexM);
            this.gpBxSexo.Controls.Add(this.RbtnSexF);
            this.gpBxSexo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpBxSexo.Location = new System.Drawing.Point(573, 54);
            this.gpBxSexo.Name = "gpBxSexo";
            this.gpBxSexo.Size = new System.Drawing.Size(200, 100);
            this.gpBxSexo.TabIndex = 21;
            this.gpBxSexo.TabStop = false;
            this.gpBxSexo.Text = "Sexo";
            // 
            // RbtnSexM
            // 
            this.RbtnSexM.AutoSize = true;
            this.RbtnSexM.Location = new System.Drawing.Point(7, 69);
            this.RbtnSexM.Name = "RbtnSexM";
            this.RbtnSexM.Size = new System.Drawing.Size(48, 29);
            this.RbtnSexM.TabIndex = 1;
            this.RbtnSexM.TabStop = true;
            this.RbtnSexM.Text = "M";
            this.RbtnSexM.UseVisualStyleBackColor = true;
            this.RbtnSexM.CheckedChanged += new System.EventHandler(this.RbtnSexM_CheckedChanged);
            // 
            // RbtnSexF
            // 
            this.RbtnSexF.AutoSize = true;
            this.RbtnSexF.Location = new System.Drawing.Point(7, 30);
            this.RbtnSexF.Name = "RbtnSexF";
            this.RbtnSexF.Size = new System.Drawing.Size(43, 29);
            this.RbtnSexF.TabIndex = 0;
            this.RbtnSexF.TabStop = true;
            this.RbtnSexF.Text = "F";
            this.RbtnSexF.UseVisualStyleBackColor = true;
            this.RbtnSexF.CheckedChanged += new System.EventHandler(this.RbtnSexF_CheckedChanged);
            // 
            // ckBxEstCivil
            // 
            this.ckBxEstCivil.AutoSize = true;
            this.ckBxEstCivil.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ckBxEstCivil.Location = new System.Drawing.Point(573, 203);
            this.ckBxEstCivil.Name = "ckBxEstCivil";
            this.ckBxEstCivil.Size = new System.Drawing.Size(105, 29);
            this.ckBxEstCivil.TabIndex = 23;
            this.ckBxEstCivil.Text = "Casado";
            this.ckBxEstCivil.UseVisualStyleBackColor = true;
            this.ckBxEstCivil.CheckedChanged += new System.EventHandler(this.CkBxEstCivil_CheckedChanged);
            // 
            // lblDados
            // 
            this.lblDados.AutoSize = true;
            this.lblDados.Location = new System.Drawing.Point(14, 257);
            this.lblDados.Name = "lblDados";
            this.lblDados.Size = new System.Drawing.Size(48, 13);
            this.lblDados.TabIndex = 24;
            this.lblDados.Text = "lblDados";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblDados);
            this.Controls.Add(this.ckBxEstCivil);
            this.Controls.Add(this.gpBxSexo);
            this.Controls.Add(this.NmUpDn);
            this.Controls.Add(this.btnCalc);
            this.Controls.Add(this.txtBxDescIRPF);
            this.Controls.Add(this.txtBxDescINSS);
            this.Controls.Add(this.txtBxSalLiq);
            this.Controls.Add(this.txtBxSalFamil);
            this.Controls.Add(this.txtBxAliqIRPF);
            this.Controls.Add(this.txtBxAliqINSS);
            this.Controls.Add(this.txtBxSalBruto);
            this.Controls.Add(this.TxtBxNomFunc);
            this.Controls.Add(this.lblDescIRPF);
            this.Controls.Add(this.lblDescINSS);
            this.Controls.Add(this.lblSalLiq);
            this.Controls.Add(this.lblSalFamil);
            this.Controls.Add(this.lblAliqIRPF);
            this.Controls.Add(this.lblAliqINSS);
            this.Controls.Add(this.lblNumFilhos);
            this.Controls.Add(this.lblSalBruto);
            this.Controls.Add(this.lblNomeFunc);
            this.Name = "Form1";
            this.Text = "Calculador de Salário";
            ((System.ComponentModel.ISupportInitialize)(this.NmUpDn)).EndInit();
            this.gpBxSexo.ResumeLayout(false);
            this.gpBxSexo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNomeFunc;
        private System.Windows.Forms.Label lblSalBruto;
        private System.Windows.Forms.Label lblNumFilhos;
        private System.Windows.Forms.Label lblAliqINSS;
        private System.Windows.Forms.Label lblAliqIRPF;
        private System.Windows.Forms.Label lblSalFamil;
        private System.Windows.Forms.Label lblSalLiq;
        private System.Windows.Forms.Label lblDescINSS;
        private System.Windows.Forms.Label lblDescIRPF;
        private System.Windows.Forms.TextBox TxtBxNomFunc;
        private System.Windows.Forms.TextBox txtBxSalBruto;
        private System.Windows.Forms.TextBox txtBxAliqINSS;
        private System.Windows.Forms.TextBox txtBxAliqIRPF;
        private System.Windows.Forms.TextBox txtBxSalFamil;
        private System.Windows.Forms.TextBox txtBxSalLiq;
        private System.Windows.Forms.TextBox txtBxDescINSS;
        private System.Windows.Forms.TextBox txtBxDescIRPF;
        private System.Windows.Forms.Button btnCalc;
        private System.Windows.Forms.NumericUpDown NmUpDn;
        private System.Windows.Forms.GroupBox gpBxSexo;
        private System.Windows.Forms.RadioButton RbtnSexM;
        private System.Windows.Forms.RadioButton RbtnSexF;
        private System.Windows.Forms.CheckBox ckBxEstCivil;
        private System.Windows.Forms.Label lblDados;
    }
}

