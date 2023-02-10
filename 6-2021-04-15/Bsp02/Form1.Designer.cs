
namespace Bsp02
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnListeLaden = new System.Windows.Forms.Button();
            this.btFrauen = new System.Windows.Forms.Button();
            this.btnHerren = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(32, 148);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(485, 215);
            this.dataGridView1.TabIndex = 0;
            // 
            // btnListeLaden
            // 
            this.btnListeLaden.Location = new System.Drawing.Point(32, 71);
            this.btnListeLaden.Name = "btnListeLaden";
            this.btnListeLaden.Size = new System.Drawing.Size(165, 53);
            this.btnListeLaden.TabIndex = 1;
            this.btnListeLaden.Text = "LISTE LADEN";
            this.btnListeLaden.UseVisualStyleBackColor = true;
            this.btnListeLaden.Click += new System.EventHandler(this.btnListeLaden_Click);
            // 
            // btFrauen
            // 
            this.btFrauen.Location = new System.Drawing.Point(214, 71);
            this.btFrauen.Name = "btFrauen";
            this.btFrauen.Size = new System.Drawing.Size(165, 53);
            this.btFrauen.TabIndex = 2;
            this.btFrauen.Text = "FRAUEN";
            this.btFrauen.UseVisualStyleBackColor = true;
            this.btFrauen.Click += new System.EventHandler(this.btFrauen_Click);
            // 
            // btnHerren
            // 
            this.btnHerren.Location = new System.Drawing.Point(396, 71);
            this.btnHerren.Name = "btnHerren";
            this.btnHerren.Size = new System.Drawing.Size(165, 53);
            this.btnHerren.TabIndex = 3;
            this.btnHerren.Text = "HERREN";
            this.btnHerren.UseVisualStyleBackColor = true;
            this.btnHerren.Click += new System.EventHandler(this.btnHerren_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(688, 428);
            this.Controls.Add(this.btnHerren);
            this.Controls.Add(this.btFrauen);
            this.Controls.Add(this.btnListeLaden);
            this.Controls.Add(this.dataGridView1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnListeLaden;
        private System.Windows.Forms.Button btFrauen;
        private System.Windows.Forms.Button btnHerren;
    }
}

