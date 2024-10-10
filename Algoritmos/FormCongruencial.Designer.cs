namespace Algoritmos
{
    partial class FormCongruencial
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
            this.txtSemillas = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtModulo = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnReiniciar
            // 
            this.btnReiniciar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReiniciar.Location = new System.Drawing.Point(501, 194);
            this.btnReiniciar.Name = "btnReiniciar";
            this.btnReiniciar.Size = new System.Drawing.Size(98, 34);
            this.btnReiniciar.TabIndex = 19;
            this.btnReiniciar.Text = "Reiniciar";
            this.btnReiniciar.UseVisualStyleBackColor = true;
            this.btnReiniciar.Click += new System.EventHandler(this.btnReiniciar_Click);
            // 
            // btnGenerar
            // 
            this.btnGenerar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGenerar.Location = new System.Drawing.Point(378, 195);
            this.btnGenerar.Name = "btnGenerar";
            this.btnGenerar.Size = new System.Drawing.Size(98, 33);
            this.btnGenerar.TabIndex = 18;
            this.btnGenerar.Text = "Generar";
            this.btnGenerar.UseVisualStyleBackColor = true;
            this.btnGenerar.Click += new System.EventHandler(this.btnGenerar_Click);
            // 
            // txtResultados
            // 
            this.txtResultados.Location = new System.Drawing.Point(57, 250);
            this.txtResultados.Name = "txtResultados";
            this.txtResultados.Size = new System.Drawing.Size(542, 227);
            this.txtResultados.TabIndex = 17;
            this.txtResultados.Text = "";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(45, 212);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(171, 16);
            this.label2.TabIndex = 16;
            this.label2.Text = "Ingrese cantidad a generar:";
            // 
            // txtCantidad
            // 
            this.txtCantidad.Location = new System.Drawing.Point(244, 212);
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(78, 22);
            this.txtCantidad.TabIndex = 15;
            // 
            // txtSemillas
            // 
            this.txtSemillas.Location = new System.Drawing.Point(161, 88);
            this.txtSemillas.Name = "txtSemillas";
            this.txtSemillas.Size = new System.Drawing.Size(400, 22);
            this.txtSemillas.TabIndex = 13;
            // 
            // label12
            // 
            this.label12.Location = new System.Drawing.Point(45, 88);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(133, 23);
            this.label12.TabIndex = 11;
            this.label12.Text = "Ingrese Semillas:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(194, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(243, 20);
            this.label1.TabIndex = 10;
            this.label1.Text = "Algoritmo Congruencial Aditivo ";
            // 
            // label7
            // 
            this.label7.Location = new System.Drawing.Point(45, 156);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(74, 30);
            this.label7.TabIndex = 28;
            this.label7.Text = "Modulo:";
            // 
            // txtModulo
            // 
            this.txtModulo.Location = new System.Drawing.Point(125, 156);
            this.txtModulo.Name = "txtModulo";
            this.txtModulo.Size = new System.Drawing.Size(129, 22);
            this.txtModulo.TabIndex = 29;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(195, 113);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(318, 23);
            this.label3.TabIndex = 30;
            this.label3.Text = "El espacio es la terminacion de una cantidad";
            // 
            // FormCongruencial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(669, 506);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtModulo);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btnReiniciar);
            this.Controls.Add(this.btnGenerar);
            this.Controls.Add(this.txtResultados);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtCantidad);
            this.Controls.Add(this.txtSemillas);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label1);
            this.Name = "FormCongruencial";
            this.Text = "FormCongruencial";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnReiniciar;
        private System.Windows.Forms.Button btnGenerar;
        private System.Windows.Forms.RichTextBox txtResultados;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtCantidad;
        private System.Windows.Forms.TextBox txtSemillas;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtModulo;
        private System.Windows.Forms.Label label3;
    }
}