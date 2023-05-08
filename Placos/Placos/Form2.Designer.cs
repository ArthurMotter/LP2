namespace Placos
{
    partial class frmExercicio1
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
            this.rcTxtBx = new System.Windows.Forms.RichTextBox();
            this.btnEspBranc = new System.Windows.Forms.Button();
            this.btnVerifRs = new System.Windows.Forms.Button();
            this.btnParLetras = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // rcTxtBx
            // 
            this.rcTxtBx.Location = new System.Drawing.Point(177, 71);
            this.rcTxtBx.Name = "rcTxtBx";
            this.rcTxtBx.Size = new System.Drawing.Size(452, 211);
            this.rcTxtBx.TabIndex = 0;
            this.rcTxtBx.Text = "";
            // 
            // btnEspBranc
            // 
            this.btnEspBranc.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEspBranc.Location = new System.Drawing.Point(151, 344);
            this.btnEspBranc.Name = "btnEspBranc";
            this.btnEspBranc.Size = new System.Drawing.Size(128, 82);
            this.btnEspBranc.TabIndex = 1;
            this.btnEspBranc.Text = "verificar espaços em branco";
            this.btnEspBranc.UseVisualStyleBackColor = true;
            this.btnEspBranc.Click += new System.EventHandler(this.BtnEspBranc_Click);
            // 
            // btnVerifRs
            // 
            this.btnVerifRs.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVerifRs.Location = new System.Drawing.Point(339, 344);
            this.btnVerifRs.Name = "btnVerifRs";
            this.btnVerifRs.Size = new System.Drawing.Size(128, 82);
            this.btnVerifRs.TabIndex = 2;
            this.btnVerifRs.Text = "verificar R\'s no texto";
            this.btnVerifRs.UseVisualStyleBackColor = true;
            this.btnVerifRs.Click += new System.EventHandler(this.BtnVerifRs_Click);
            // 
            // btnParLetras
            // 
            this.btnParLetras.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnParLetras.Location = new System.Drawing.Point(527, 344);
            this.btnParLetras.Name = "btnParLetras";
            this.btnParLetras.Size = new System.Drawing.Size(128, 82);
            this.btnParLetras.TabIndex = 3;
            this.btnParLetras.Text = "verficar pares de letras";
            this.btnParLetras.UseVisualStyleBackColor = true;
            this.btnParLetras.Click += new System.EventHandler(this.BtnParLetras_Click);
            // 
            // frmExercicio1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnParLetras);
            this.Controls.Add(this.btnVerifRs);
            this.Controls.Add(this.btnEspBranc);
            this.Controls.Add(this.rcTxtBx);
            this.Name = "frmExercicio1";
            this.Text = "exercicio 1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox rcTxtBx;
        private System.Windows.Forms.Button btnEspBranc;
        private System.Windows.Forms.Button btnVerifRs;
        private System.Windows.Forms.Button btnParLetras;
    }
}