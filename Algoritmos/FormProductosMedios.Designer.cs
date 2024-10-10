namespace Algoritmos
{
    partial class FormProductosMedios
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
            this.txtResultados = new System.Windows.Forms.RichTextBox();
            this.txtSemilla1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtSemilla2 = new System.Windows.Forms.TextBox();
            this.txtCantidad = new System.Windows.Forms.TextBox();
            this.btnGenerar = new System.Windows.Forms.Button();
            this.btnReiniciar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtResultados
            // 
            this.txtResultados.Location = new System.Drawing.Point(82, 201);
            this.txtResultados.Name = "txtResultados";
            this.txtResultados.Size = new System.Drawing.Size(305, 280);
            this.txtResultados.TabIndex = 21;
            this.txtResultados.Text = "";
            // 
            // txtSemilla1
            // 
            this.txtSemilla1.Location = new System.Drawing.Point(245, 79);
            this.txtSemilla1.Name = "txtSemilla1";
            this.txtSemilla1.Size = new System.Drawing.Size(100, 22);
            this.txtSemilla1.TabIndex = 18;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(116, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(248, 20);
            this.label1.TabIndex = 16;
            this.label1.Text = "Algoritmo de Productos Medios ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 79);
            this.label2.Name = "label2";
            this.label2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label2.Size = new System.Drawing.Size(128, 16);
            this.label2.TabIndex = 22;
            this.label2.Text = "Ingrese Semilla X0 =";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(31, 119);
            this.label3.Name = "label3";
            this.label3.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label3.Size = new System.Drawing.Size(128, 16);
            this.label3.TabIndex = 23;
            this.label3.Text = "Ingrese Semilla X1 =";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(31, 158);
            this.label4.Name = "label4";
            this.label4.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label4.Size = new System.Drawing.Size(171, 16);
            this.label4.TabIndex = 24;
            this.label4.Text = "Ingrese cantidad a generar:";
            // 
            // txtSemilla2
            // 
            this.txtSemilla2.Location = new System.Drawing.Point(245, 119);
            this.txtSemilla2.Name = "txtSemilla2";
            this.txtSemilla2.Size = new System.Drawing.Size(100, 22);
            this.txtSemilla2.TabIndex = 19;
            // 
            // txtCantidad
            // 
            this.txtCantidad.Location = new System.Drawing.Point(245, 158);
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(100, 22);
            this.txtCantidad.TabIndex = 25;
            // 
            // btnGenerar
            // 
            this.btnGenerar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGenerar.Location = new System.Drawing.Point(387, 79);
            this.btnGenerar.Name = "btnGenerar";
            this.btnGenerar.Size = new System.Drawing.Size(105, 36);
            this.btnGenerar.TabIndex = 26;
            this.btnGenerar.Text = "Generar";
            this.btnGenerar.UseVisualStyleBackColor = true;
            this.btnGenerar.Click += new System.EventHandler(this.btnGenerar_Click);
            // 
            // btnReiniciar
            // 
            this.btnReiniciar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReiniciar.Location = new System.Drawing.Point(387, 149);
            this.btnReiniciar.Name = "btnReiniciar";
            this.btnReiniciar.Size = new System.Drawing.Size(105, 32);
            this.btnReiniciar.TabIndex = 27;
            this.btnReiniciar.Text = "Reiniciar";
            this.btnReiniciar.UseVisualStyleBackColor = true;
            this.btnReiniciar.Click += new System.EventHandler(this.btnReiniciar_Click);
            // 
            // FormProductosMedios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(520, 520);
            this.Controls.Add(this.btnReiniciar);
            this.Controls.Add(this.btnGenerar);
            this.Controls.Add(this.txtCantidad);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtResultados);
            this.Controls.Add(this.txtSemilla2);
            this.Controls.Add(this.txtSemilla1);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Name = "FormProductosMedios";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Text = "FormProductosMedios";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox txtResultados;
        private System.Windows.Forms.TextBox txtSemilla1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtSemilla2;
        private System.Windows.Forms.TextBox txtCantidad;
        private System.Windows.Forms.Button btnGenerar;
        private System.Windows.Forms.Button btnReiniciar;
    }
}