﻿namespace Algoritmos
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.btnCuadradosMedios = new System.Windows.Forms.Button();
            this.btnProductosMedios = new System.Windows.Forms.Button();
            this.btnMulConstante = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.btnCongruencial = new System.Windows.Forms.Button();
            this.btnCongruencialM = new System.Windows.Forms.Button();
            this.btnCongruencialMul = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(114, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(295, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Numeros Pseudoaleatorio";
            // 
            // btnCuadradosMedios
            // 
            this.btnCuadradosMedios.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCuadradosMedios.Location = new System.Drawing.Point(39, 137);
            this.btnCuadradosMedios.Name = "btnCuadradosMedios";
            this.btnCuadradosMedios.Size = new System.Drawing.Size(227, 37);
            this.btnCuadradosMedios.TabIndex = 1;
            this.btnCuadradosMedios.Text = "Cuadrados Medios ";
            this.btnCuadradosMedios.UseVisualStyleBackColor = true;
            this.btnCuadradosMedios.Click += new System.EventHandler(this.btnCuadradosMedios_Click);
            // 
            // btnProductosMedios
            // 
            this.btnProductosMedios.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProductosMedios.Location = new System.Drawing.Point(82, 194);
            this.btnProductosMedios.Name = "btnProductosMedios";
            this.btnProductosMedios.Size = new System.Drawing.Size(227, 35);
            this.btnProductosMedios.TabIndex = 2;
            this.btnProductosMedios.Text = "Productos Medios\n";
            this.btnProductosMedios.UseVisualStyleBackColor = true;
            this.btnProductosMedios.Click += new System.EventHandler(this.btnProductosMedios_Click);
            // 
            // btnMulConstante
            // 
            this.btnMulConstante.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMulConstante.Location = new System.Drawing.Point(119, 250);
            this.btnMulConstante.Name = "btnMulConstante";
            this.btnMulConstante.Size = new System.Drawing.Size(265, 34);
            this.btnMulConstante.TabIndex = 3;
            this.btnMulConstante.Text = "Multiplicador Constante ";
            this.btnMulConstante.UseVisualStyleBackColor = true;
            this.btnMulConstante.Click += new System.EventHandler(this.btnMulConstante_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "Eliga un algoritmo:";
            // 
            // btnCongruencial
            // 
            this.btnCongruencial.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCongruencial.Location = new System.Drawing.Point(162, 304);
            this.btnCongruencial.Name = "btnCongruencial";
            this.btnCongruencial.Size = new System.Drawing.Size(247, 37);
            this.btnCongruencial.TabIndex = 5;
            this.btnCongruencial.Text = "Congruencial Aditivo";
            this.btnCongruencial.UseVisualStyleBackColor = true;
            this.btnCongruencial.Click += new System.EventHandler(this.btnCongruencial_Click);
            // 
            // btnCongruencialM
            // 
            this.btnCongruencialM.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCongruencialM.Location = new System.Drawing.Point(200, 366);
            this.btnCongruencialM.Name = "btnCongruencialM";
            this.btnCongruencialM.Size = new System.Drawing.Size(247, 37);
            this.btnCongruencialM.TabIndex = 6;
            this.btnCongruencialM.Text = "Congruencial Mixto";
            this.btnCongruencialM.UseVisualStyleBackColor = true;
            this.btnCongruencialM.Click += new System.EventHandler(this.btnCongruencialM_Click);
            // 
            // btnCongruencialMul
            // 
            this.btnCongruencialMul.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCongruencialMul.Location = new System.Drawing.Point(240, 424);
            this.btnCongruencialMul.Name = "btnCongruencialMul";
            this.btnCongruencialMul.Size = new System.Drawing.Size(286, 37);
            this.btnCongruencialMul.TabIndex = 7;
            this.btnCongruencialMul.Text = "Congruencial Multiplicativo";
            this.btnCongruencialMul.UseVisualStyleBackColor = true;
            this.btnCongruencialMul.Click += new System.EventHandler(this.btnCongruencialMul_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(538, 525);
            this.Controls.Add(this.btnCongruencialMul);
            this.Controls.Add(this.btnCongruencialM);
            this.Controls.Add(this.btnCongruencial);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnMulConstante);
            this.Controls.Add(this.btnProductosMedios);
            this.Controls.Add(this.btnCuadradosMedios);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCuadradosMedios;
        private System.Windows.Forms.Button btnProductosMedios;
        private System.Windows.Forms.Button btnMulConstante;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnCongruencial;
        private System.Windows.Forms.Button btnCongruencialM;
        private System.Windows.Forms.Button btnCongruencialMul;
    }
}

