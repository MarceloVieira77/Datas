
namespace Datas
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
            this.btnCalcula = new System.Windows.Forms.Button();
            this.txtDias = new System.Windows.Forms.TextBox();
            this.lblDataFinal = new System.Windows.Forms.Label();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.dtpData = new System.Windows.Forms.DateTimePicker();
            this.lblDias = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnCalcula
            // 
            this.btnCalcula.Location = new System.Drawing.Point(184, 29);
            this.btnCalcula.Name = "btnCalcula";
            this.btnCalcula.Size = new System.Drawing.Size(75, 23);
            this.btnCalcula.TabIndex = 1;
            this.btnCalcula.Text = "&Calcular";
            this.btnCalcula.UseVisualStyleBackColor = true;
            this.btnCalcula.Click += new System.EventHandler(this.btnCalcula_Click);
            // 
            // txtDias
            // 
            this.txtDias.Location = new System.Drawing.Point(12, 94);
            this.txtDias.MaxLength = 5;
            this.txtDias.Name = "txtDias";
            this.txtDias.Size = new System.Drawing.Size(109, 23);
            this.txtDias.TabIndex = 0;
            // 
            // lblDataFinal
            // 
            this.lblDataFinal.AutoSize = true;
            this.lblDataFinal.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblDataFinal.ForeColor = System.Drawing.Color.Blue;
            this.lblDataFinal.Location = new System.Drawing.Point(13, 120);
            this.lblDataFinal.Name = "lblDataFinal";
            this.lblDataFinal.Size = new System.Drawing.Size(50, 19);
            this.lblDataFinal.TabIndex = 3;
            this.lblDataFinal.Text = "label1";
            // 
            // btnLimpar
            // 
            this.btnLimpar.Location = new System.Drawing.Point(184, 94);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(75, 23);
            this.btnLimpar.TabIndex = 4;
            this.btnLimpar.Text = "&Limpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // dtpData
            // 
            this.dtpData.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpData.Location = new System.Drawing.Point(13, 27);
            this.dtpData.Name = "dtpData";
            this.dtpData.Size = new System.Drawing.Size(109, 23);
            this.dtpData.TabIndex = 5;
            // 
            // lblDias
            // 
            this.lblDias.AutoSize = true;
            this.lblDias.Location = new System.Drawing.Point(12, 73);
            this.lblDias.Name = "lblDias";
            this.lblDias.Size = new System.Drawing.Size(32, 15);
            this.lblDias.TabIndex = 6;
            this.lblDias.Text = "Dias:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(297, 168);
            this.Controls.Add(this.lblDias);
            this.Controls.Add(this.dtpData);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.lblDataFinal);
            this.Controls.Add(this.txtDias);
            this.Controls.Add(this.btnCalcula);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Datas";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnCalcula;
        private System.Windows.Forms.TextBox txtDias;
        private System.Windows.Forms.Label lblDataFinal;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.DateTimePicker dtpData;
        private System.Windows.Forms.Label lblDias;
    }
}

