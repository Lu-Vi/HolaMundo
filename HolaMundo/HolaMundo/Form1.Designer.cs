namespace HolaMundo
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
            this.label1 = new System.Windows.Forms.Label();
            this.lblprimer = new System.Windows.Forms.Label();
            this.lblsegundo = new System.Windows.Forms.Label();
            this.btnllamar = new System.Windows.Forms.Button();
            this.btnejecutar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(98, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(216, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Este es mi hola mundo con Git";
            // 
            // lblprimer
            // 
            this.lblprimer.AutoSize = true;
            this.lblprimer.Location = new System.Drawing.Point(53, 96);
            this.lblprimer.Name = "lblprimer";
            this.lblprimer.Size = new System.Drawing.Size(78, 13);
            this.lblprimer.TabIndex = 1;
            this.lblprimer.Text = "numero grande";
            // 
            // lblsegundo
            // 
            this.lblsegundo.AutoSize = true;
            this.lblsegundo.Location = new System.Drawing.Point(53, 133);
            this.lblsegundo.Name = "lblsegundo";
            this.lblsegundo.Size = new System.Drawing.Size(66, 13);
            this.lblsegundo.TabIndex = 2;
            this.lblsegundo.Text = "contadorcito";
            // 
            // btnllamar
            // 
            this.btnllamar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnllamar.Location = new System.Drawing.Point(79, 234);
            this.btnllamar.Name = "btnllamar";
            this.btnllamar.Size = new System.Drawing.Size(75, 23);
            this.btnllamar.TabIndex = 5;
            this.btnllamar.Text = "llamar";
            this.btnllamar.UseVisualStyleBackColor = true;
            this.btnllamar.Click += new System.EventHandler(this.Btnllamar_Click);
            // 
            // btnejecutar
            // 
            this.btnejecutar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnejecutar.Location = new System.Drawing.Point(228, 234);
            this.btnejecutar.Name = "btnejecutar";
            this.btnejecutar.Size = new System.Drawing.Size(75, 23);
            this.btnejecutar.TabIndex = 6;
            this.btnejecutar.Text = "ejecutar";
            this.btnejecutar.UseVisualStyleBackColor = true;
            this.btnejecutar.Click += new System.EventHandler(this.Btnejecutar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FloralWhite;
            this.ClientSize = new System.Drawing.Size(412, 327);
            this.Controls.Add(this.btnejecutar);
            this.Controls.Add(this.btnllamar);
            this.Controls.Add(this.lblsegundo);
            this.Controls.Add(this.lblprimer);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblprimer;
        private System.Windows.Forms.Label lblsegundo;
        private System.Windows.Forms.Button btnllamar;
        private System.Windows.Forms.Button btnejecutar;
    }
}

