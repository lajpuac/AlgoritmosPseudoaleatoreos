namespace Algoritmos
{
    partial class FormCongruencialMixto
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
            this.btnReiniciar = new System.Windows.Forms.Button();
            this.btnGenerar = new System.Windows.Forms.Button();
            this.txtResultados = new System.Windows.Forms.RichTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCantidad = new System.Windows.Forms.TextBox();
            this.txtSemilla = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtMultiplicativa = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtAditiva = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtModulo = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnReiniciar
            // 
            this.btnReiniciar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReiniciar.Location = new System.Drawing.Point(343, 124);
            this.btnReiniciar.Name = "btnReiniciar";
            this.btnReiniciar.Size = new System.Drawing.Size(106, 32);
            this.btnReiniciar.TabIndex = 25;
            this.btnReiniciar.Text = "Reiniciar";
            this.btnReiniciar.UseVisualStyleBackColor = true;
            this.btnReiniciar.Click += new System.EventHandler(this.btnReiniciar_Click);
            // 
            // btnGenerar
            // 
            this.btnGenerar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGenerar.Location = new System.Drawing.Point(343, 69);
            this.btnGenerar.Name = "btnGenerar";
            this.btnGenerar.Size = new System.Drawing.Size(106, 32);
            this.btnGenerar.TabIndex = 24;
            this.btnGenerar.Text = "Generar";
            this.btnGenerar.UseVisualStyleBackColor = true;
            this.btnGenerar.Click += new System.EventHandler(this.btnGenerar_Click);
            // 
            // txtResultados
            // 
            this.txtResultados.Location = new System.Drawing.Point(61, 270);
            this.txtResultados.Name = "txtResultados";
            this.txtResultados.Size = new System.Drawing.Size(371, 233);
            this.txtResultados.TabIndex = 23;
            this.txtResultados.Text = "";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(28, 235);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(185, 18);
            this.label2.TabIndex = 22;
            this.label2.Text = "Ingrese cantidad a generar:";
            // 
            // txtCantidad
            // 
            this.txtCantidad.Location = new System.Drawing.Point(244, 231);
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(100, 22);
            this.txtCantidad.TabIndex = 21;
            // 
            // txtSemilla
            // 
            this.txtSemilla.Location = new System.Drawing.Point(148, 69);
            this.txtSemilla.Name = "txtSemilla";
            this.txtSemilla.Size = new System.Drawing.Size(100, 22);
            this.txtSemilla.TabIndex = 20;
            // 
            // label12
            // 
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(28, 69);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(100, 23);
            this.label12.TabIndex = 19;
            this.label12.Text = "Ingrese X0:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(95, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(313, 20);
            this.label1.TabIndex = 18;
            this.label1.Text = "Algoritmo de Congruencial Mixto (LIneal)";
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(28, 107);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 23);
            this.label3.TabIndex = 26;
            this.label3.Text = "Ingrese a:";
            // 
            // txtMultiplicativa
            // 
            this.txtMultiplicativa.Location = new System.Drawing.Point(148, 106);
            this.txtMultiplicativa.Name = "txtMultiplicativa";
            this.txtMultiplicativa.Size = new System.Drawing.Size(100, 22);
            this.txtMultiplicativa.TabIndex = 27;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(28, 147);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 23);
            this.label4.TabIndex = 28;
            this.label4.Text = "Ingrese c:";
            // 
            // txtAditiva
            // 
            this.txtAditiva.Location = new System.Drawing.Point(148, 148);
            this.txtAditiva.Name = "txtAditiva";
            this.txtAditiva.Size = new System.Drawing.Size(100, 22);
            this.txtAditiva.TabIndex = 29;
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(28, 188);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(124, 23);
            this.label5.TabIndex = 30;
            this.label5.Text = "Ingrese modulo:";
            // 
            // txtModulo
            // 
            this.txtModulo.Location = new System.Drawing.Point(187, 189);
            this.txtModulo.Name = "txtModulo";
            this.txtModulo.Size = new System.Drawing.Size(100, 22);
            this.txtModulo.TabIndex = 31;
            // 
            // FormCongruencialMixto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(526, 515);
            this.Controls.Add(this.txtModulo);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtAditiva);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtMultiplicativa);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnReiniciar);
            this.Controls.Add(this.btnGenerar);
            this.Controls.Add(this.txtResultados);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtCantidad);
            this.Controls.Add(this.txtSemilla);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label1);
            this.Name = "FormCongruencialMixto";
            this.Text = "FormCongruencialMixto";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnReiniciar;
        private System.Windows.Forms.Button btnGenerar;
        private System.Windows.Forms.RichTextBox txtResultados;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtCantidad;
        private System.Windows.Forms.TextBox txtSemilla;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtMultiplicativa;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtAditiva;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtModulo;
    }
}