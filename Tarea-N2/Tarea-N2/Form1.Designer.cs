namespace Tarea_N2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.txb2 = new System.Windows.Forms.TextBox();
            this.txb3 = new System.Windows.Forms.TextBox();
            this.txb4 = new System.Windows.Forms.TextBox();
            this.txb5 = new System.Windows.Forms.TextBox();
            this.bt1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(49, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Materia:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(46, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nota I-Parcial:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(46, 105);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Nota II-Parcial:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(46, 137);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(97, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Nota III-Parcial:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(46, 168);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(97, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Nota IV-Parcial:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(132, 31);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(150, 20);
            this.textBox1.TabIndex = 5;
            // 
            // txb2
            // 
            this.txb2.Location = new System.Drawing.Point(146, 69);
            this.txb2.Name = "txb2";
            this.txb2.Size = new System.Drawing.Size(100, 20);
            this.txb2.TabIndex = 6;
            this.txb2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // txb3
            // 
            this.txb3.Location = new System.Drawing.Point(146, 102);
            this.txb3.Name = "txb3";
            this.txb3.Size = new System.Drawing.Size(100, 20);
            this.txb3.TabIndex = 7;
            this.txb3.TextChanged += new System.EventHandler(this.txb3_TextChanged);
            // 
            // txb4
            // 
            this.txb4.Location = new System.Drawing.Point(146, 134);
            this.txb4.Name = "txb4";
            this.txb4.Size = new System.Drawing.Size(100, 20);
            this.txb4.TabIndex = 8;
            this.txb4.TextChanged += new System.EventHandler(this.txb4_TextChanged);
            // 
            // txb5
            // 
            this.txb5.Location = new System.Drawing.Point(146, 165);
            this.txb5.Name = "txb5";
            this.txb5.Size = new System.Drawing.Size(100, 20);
            this.txb5.TabIndex = 9;
            this.txb5.TextChanged += new System.EventHandler(this.txb5_TextChanged);
            // 
            // bt1
            // 
            this.bt1.Font = new System.Drawing.Font("Perpetua Titling MT", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt1.ForeColor = System.Drawing.Color.Red;
            this.bt1.Image = global::Tarea_N2.Properties.Resources.images__5_;
            this.bt1.Location = new System.Drawing.Point(252, 72);
            this.bt1.Name = "bt1";
            this.bt1.Size = new System.Drawing.Size(82, 113);
            this.bt1.TabIndex = 10;
            this.bt1.Text = "Promedio";
            this.bt1.UseVisualStyleBackColor = true;
            this.bt1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Tarea_N2.Properties.Resources.images__6_;
            this.ClientSize = new System.Drawing.Size(381, 207);
            this.Controls.Add(this.bt1);
            this.Controls.Add(this.txb5);
            this.Controls.Add(this.txb4);
            this.Controls.Add(this.txb3);
            this.Controls.Add(this.txb2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PROMEDIO";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox txb2;
        private System.Windows.Forms.TextBox txb3;
        private System.Windows.Forms.TextBox txb4;
        private System.Windows.Forms.TextBox txb5;
        private System.Windows.Forms.Button bt1;
    }
}

