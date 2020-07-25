namespace Falcon_0_0
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
            this.btnComenzar = new System.Windows.Forms.Button();
            this.btnRutina = new System.Windows.Forms.Button();
            this.btnRutina2 = new System.Windows.Forms.Button();
            this.btnStarR1 = new System.Windows.Forms.Button();
            this.btnStopR1 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btnPanTill = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnComenzar
            // 
            this.btnComenzar.Location = new System.Drawing.Point(68, 61);
            this.btnComenzar.Name = "btnComenzar";
            this.btnComenzar.Size = new System.Drawing.Size(102, 31);
            this.btnComenzar.TabIndex = 0;
            this.btnComenzar.Text = "Comenzar";
            this.btnComenzar.UseVisualStyleBackColor = true;
            this.btnComenzar.Click += new System.EventHandler(this.btnComenzar_Click);
            // 
            // btnRutina
            // 
            this.btnRutina.Location = new System.Drawing.Point(68, 115);
            this.btnRutina.Name = "btnRutina";
            this.btnRutina.Size = new System.Drawing.Size(102, 31);
            this.btnRutina.TabIndex = 1;
            this.btnRutina.Text = "Rutina";
            this.btnRutina.UseVisualStyleBackColor = true;
            this.btnRutina.Click += new System.EventHandler(this.btnRutina_Click);
            // 
            // btnRutina2
            // 
            this.btnRutina2.Location = new System.Drawing.Point(68, 163);
            this.btnRutina2.Name = "btnRutina2";
            this.btnRutina2.Size = new System.Drawing.Size(102, 31);
            this.btnRutina2.TabIndex = 2;
            this.btnRutina2.Text = "Rutina 2";
            this.btnRutina2.UseVisualStyleBackColor = true;
            this.btnRutina2.Click += new System.EventHandler(this.btnRutina2_Click);
            // 
            // btnStarR1
            // 
            this.btnStarR1.Location = new System.Drawing.Point(254, 61);
            this.btnStarR1.Name = "btnStarR1";
            this.btnStarR1.Size = new System.Drawing.Size(90, 31);
            this.btnStarR1.TabIndex = 3;
            this.btnStarR1.Text = "Start";
            this.btnStarR1.UseVisualStyleBackColor = true;
            this.btnStarR1.Click += new System.EventHandler(this.btnStarR1_Click);
            // 
            // btnStopR1
            // 
            this.btnStopR1.Location = new System.Drawing.Point(254, 115);
            this.btnStopR1.Name = "btnStopR1";
            this.btnStopR1.Size = new System.Drawing.Size(90, 31);
            this.btnStopR1.TabIndex = 4;
            this.btnStopR1.Text = "Stop";
            this.btnStopR1.UseVisualStyleBackColor = true;
            this.btnStopR1.Click += new System.EventHandler(this.btnStopR1_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(254, 167);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(90, 27);
            this.button1.TabIndex = 5;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnPanTill
            // 
            this.btnPanTill.Location = new System.Drawing.Point(68, 200);
            this.btnPanTill.Name = "btnPanTill";
            this.btnPanTill.Size = new System.Drawing.Size(102, 31);
            this.btnPanTill.TabIndex = 6;
            this.btnPanTill.Text = "Pan-Till";
            this.btnPanTill.UseVisualStyleBackColor = true;
            this.btnPanTill.Click += new System.EventHandler(this.btnPanTill_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(254, 208);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(90, 23);
            this.button3.TabIndex = 8;
            this.button3.Text = "button3";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.btnPanTill);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnStopR1);
            this.Controls.Add(this.btnStarR1);
            this.Controls.Add(this.btnRutina2);
            this.Controls.Add(this.btnRutina);
            this.Controls.Add(this.btnComenzar);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnComenzar;
        private System.Windows.Forms.Button btnRutina;
        private System.Windows.Forms.Button btnRutina2;
        private System.Windows.Forms.Button btnStarR1;
        private System.Windows.Forms.Button btnStopR1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnPanTill;
        private System.Windows.Forms.Button button3;
    }
}

