
namespace Bsp06
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
            this.txtZahl1 = new System.Windows.Forms.TextBox();
            this.txtZahl2 = new System.Windows.Forms.TextBox();
            this.btnAddieren = new System.Windows.Forms.Button();
            this.btnSubtrahieren = new System.Windows.Forms.Button();
            this.btnDividieren = new System.Windows.Forms.Button();
            this.btnMultiplizieren = new System.Windows.Forms.Button();
            this.txtErgebnis = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtZahl1
            // 
            this.txtZahl1.Location = new System.Drawing.Point(35, 67);
            this.txtZahl1.Name = "txtZahl1";
            this.txtZahl1.Size = new System.Drawing.Size(230, 28);
            this.txtZahl1.TabIndex = 0;
            this.txtZahl1.Text = "0";
            this.txtZahl1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // txtZahl2
            // 
            this.txtZahl2.Location = new System.Drawing.Point(306, 67);
            this.txtZahl2.Name = "txtZahl2";
            this.txtZahl2.Size = new System.Drawing.Size(231, 28);
            this.txtZahl2.TabIndex = 1;
            this.txtZahl2.Text = "0";
            // 
            // btnAddieren
            // 
            this.btnAddieren.Location = new System.Drawing.Point(35, 120);
            this.btnAddieren.Name = "btnAddieren";
            this.btnAddieren.Size = new System.Drawing.Size(97, 53);
            this.btnAddieren.TabIndex = 2;
            this.btnAddieren.Text = "+";
            this.btnAddieren.UseVisualStyleBackColor = true;
            this.btnAddieren.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnSubtrahieren
            // 
            this.btnSubtrahieren.Location = new System.Drawing.Point(174, 120);
            this.btnSubtrahieren.Name = "btnSubtrahieren";
            this.btnSubtrahieren.Size = new System.Drawing.Size(91, 53);
            this.btnSubtrahieren.TabIndex = 3;
            this.btnSubtrahieren.Text = "-";
            this.btnSubtrahieren.UseVisualStyleBackColor = true;
            // 
            // btnDividieren
            // 
            this.btnDividieren.Location = new System.Drawing.Point(445, 120);
            this.btnDividieren.Name = "btnDividieren";
            this.btnDividieren.Size = new System.Drawing.Size(92, 53);
            this.btnDividieren.TabIndex = 4;
            this.btnDividieren.Text = "/";
            this.btnDividieren.UseVisualStyleBackColor = true;
            this.btnDividieren.Click += new System.EventHandler(this.button3_Click);
            // 
            // btnMultiplizieren
            // 
            this.btnMultiplizieren.Location = new System.Drawing.Point(306, 120);
            this.btnMultiplizieren.Name = "btnMultiplizieren";
            this.btnMultiplizieren.Size = new System.Drawing.Size(95, 53);
            this.btnMultiplizieren.TabIndex = 5;
            this.btnMultiplizieren.Text = "*";
            this.btnMultiplizieren.UseVisualStyleBackColor = true;
            this.btnMultiplizieren.Click += new System.EventHandler(this.button4_Click);
            // 
            // txtErgebnis
            // 
            this.txtErgebnis.Location = new System.Drawing.Point(35, 198);
            this.txtErgebnis.Name = "txtErgebnis";
            this.txtErgebnis.Size = new System.Drawing.Size(502, 28);
            this.txtErgebnis.TabIndex = 6;
            this.txtErgebnis.TextChanged += new System.EventHandler(this.txtErgebnis_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(568, 704);
            this.Controls.Add(this.txtErgebnis);
            this.Controls.Add(this.btnMultiplizieren);
            this.Controls.Add(this.btnDividieren);
            this.Controls.Add(this.btnSubtrahieren);
            this.Controls.Add(this.btnAddieren);
            this.Controls.Add(this.txtZahl2);
            this.Controls.Add(this.txtZahl1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtZahl1;
        private System.Windows.Forms.TextBox txtZahl2;
        private System.Windows.Forms.Button btnAddieren;
        private System.Windows.Forms.Button btnSubtrahieren;
        private System.Windows.Forms.Button btnDividieren;
        private System.Windows.Forms.Button btnMultiplizieren;
        private System.Windows.Forms.TextBox txtErgebnis;
    }
}

