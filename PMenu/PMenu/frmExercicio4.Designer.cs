namespace PMenu
{
    partial class frmExercicio4
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
            this.btnVerifNum = new System.Windows.Forms.Button();
            this.btnVerifEspBranco = new System.Windows.Forms.Button();
            this.btnVerifLetras = new System.Windows.Forms.Button();
            this.rcTxtBx = new System.Windows.Forms.RichTextBox();
            this.lblRichText = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnVerifNum
            // 
            this.btnVerifNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVerifNum.Location = new System.Drawing.Point(111, 325);
            this.btnVerifNum.Name = "btnVerifNum";
            this.btnVerifNum.Size = new System.Drawing.Size(145, 95);
            this.btnVerifNum.TabIndex = 0;
            this.btnVerifNum.Text = "verificar números";
            this.btnVerifNum.UseVisualStyleBackColor = true;
            this.btnVerifNum.Click += new System.EventHandler(this.btnVerifNum_Click);
            // 
            // btnVerifEspBranco
            // 
            this.btnVerifEspBranco.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVerifEspBranco.Location = new System.Drawing.Point(321, 325);
            this.btnVerifEspBranco.Name = "btnVerifEspBranco";
            this.btnVerifEspBranco.Size = new System.Drawing.Size(145, 95);
            this.btnVerifEspBranco.TabIndex = 1;
            this.btnVerifEspBranco.Text = "verificar espaços em branco";
            this.btnVerifEspBranco.UseVisualStyleBackColor = true;
            this.btnVerifEspBranco.Click += new System.EventHandler(this.btnVerifEspBranco_Click);
            // 
            // btnVerifLetras
            // 
            this.btnVerifLetras.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVerifLetras.Location = new System.Drawing.Point(518, 325);
            this.btnVerifLetras.Name = "btnVerifLetras";
            this.btnVerifLetras.Size = new System.Drawing.Size(145, 95);
            this.btnVerifLetras.TabIndex = 2;
            this.btnVerifLetras.Text = "Verificar caracteres alfabéticos";
            this.btnVerifLetras.UseVisualStyleBackColor = true;
            this.btnVerifLetras.Click += new System.EventHandler(this.btnVerifLetras_Click);
            // 
            // rcTxtBx
            // 
            this.rcTxtBx.Location = new System.Drawing.Point(111, 113);
            this.rcTxtBx.Name = "rcTxtBx";
            this.rcTxtBx.Size = new System.Drawing.Size(552, 173);
            this.rcTxtBx.TabIndex = 3;
            this.rcTxtBx.Text = "";
            // 
            // lblRichText
            // 
            this.lblRichText.AutoSize = true;
            this.lblRichText.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRichText.Location = new System.Drawing.Point(343, 73);
            this.lblRichText.Name = "lblRichText";
            this.lblRichText.Size = new System.Drawing.Size(66, 25);
            this.lblRichText.TabIndex = 4;
            this.lblRichText.Text = "Texto";
            // 
            // frmExercicio4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblRichText);
            this.Controls.Add(this.rcTxtBx);
            this.Controls.Add(this.btnVerifLetras);
            this.Controls.Add(this.btnVerifEspBranco);
            this.Controls.Add(this.btnVerifNum);
            this.Name = "frmExercicio4";
            this.Text = "frmExercicio4";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnVerifNum;
        private System.Windows.Forms.Button btnVerifEspBranco;
        private System.Windows.Forms.Button btnVerifLetras;
        private System.Windows.Forms.RichTextBox rcTxtBx;
        private System.Windows.Forms.Label lblRichText;
    }
}