namespace GettingRealRosa
{
    partial class OpretGarn
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
            this.Tilføj = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.OpretGarnTextType = new System.Windows.Forms.TextBox();
            this.OpretGarnTextNavn = new System.Windows.Forms.TextBox();
            this.OpretGarnTextcolor = new System.Windows.Forms.TextBox();
            this.textBox9 = new System.Windows.Forms.TextBox();
            this.textBox10 = new System.Windows.Forms.TextBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.SuspendLayout();
            // 
            // Tilføj
            // 
            this.Tilføj.AccessibleName = "TilføjTilListe";
            this.Tilføj.Location = new System.Drawing.Point(407, 184);
            this.Tilføj.Name = "Tilføj";
            this.Tilføj.Size = new System.Drawing.Size(88, 27);
            this.Tilføj.TabIndex = 0;
            this.Tilføj.Text = "Tilføj";
            this.Tilføj.UseVisualStyleBackColor = true;
            this.Tilføj.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.textBox1.Location = new System.Drawing.Point(12, 12);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 1;
            this.textBox1.Text = "Garn Type";
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.textBox2.Location = new System.Drawing.Point(12, 48);
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 2;
            this.textBox2.Text = "Garn Navn";
            // 
            // textBox3
            // 
            this.textBox3.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.textBox3.Location = new System.Drawing.Point(12, 84);
            this.textBox3.Name = "textBox3";
            this.textBox3.ReadOnly = true;
            this.textBox3.Size = new System.Drawing.Size(100, 20);
            this.textBox3.TabIndex = 3;
            this.textBox3.Text = "Garn Farve";
            // 
            // textBox4
            // 
            this.textBox4.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.textBox4.Location = new System.Drawing.Point(12, 122);
            this.textBox4.Name = "textBox4";
            this.textBox4.ReadOnly = true;
            this.textBox4.Size = new System.Drawing.Size(100, 20);
            this.textBox4.TabIndex = 4;
            this.textBox4.Text = "Pris";
            // 
            // textBox5
            // 
            this.textBox5.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.textBox5.Location = new System.Drawing.Point(12, 158);
            this.textBox5.Name = "textBox5";
            this.textBox5.ReadOnly = true;
            this.textBox5.Size = new System.Drawing.Size(100, 20);
            this.textBox5.TabIndex = 5;
            this.textBox5.Text = "Mængde";
            // 
            // OpretGarnTextType
            // 
            this.OpretGarnTextType.AccessibleDescription = "GarnTypeText";
            this.OpretGarnTextType.Location = new System.Drawing.Point(130, 12);
            this.OpretGarnTextType.Name = "OpretGarnTextType";
            this.OpretGarnTextType.Size = new System.Drawing.Size(365, 20);
            this.OpretGarnTextType.TabIndex = 6;
            this.OpretGarnTextType.TextChanged += new System.EventHandler(this.GarnTypeTxtBox_TextChanged);
            // 
            // OpretGarnTextNavn
            // 
            this.OpretGarnTextNavn.Location = new System.Drawing.Point(130, 48);
            this.OpretGarnTextNavn.Name = "OpretGarnTextNavn";
            this.OpretGarnTextNavn.Size = new System.Drawing.Size(365, 20);
            this.OpretGarnTextNavn.TabIndex = 7;
            this.OpretGarnTextNavn.TextChanged += new System.EventHandler(this.textBox7_TextChanged);
            // 
            // OpretGarnTextcolor
            // 
            this.OpretGarnTextcolor.Location = new System.Drawing.Point(130, 84);
            this.OpretGarnTextcolor.Name = "OpretGarnTextcolor";
            this.OpretGarnTextcolor.Size = new System.Drawing.Size(365, 20);
            this.OpretGarnTextcolor.TabIndex = 8;
            // 
            // textBox9
            // 
            this.textBox9.Location = new System.Drawing.Point(130, 122);
            this.textBox9.Name = "textBox9";
            this.textBox9.Size = new System.Drawing.Size(365, 20);
            this.textBox9.TabIndex = 9;
            // 
            // textBox10
            // 
            this.textBox10.Location = new System.Drawing.Point(130, 158);
            this.textBox10.Name = "textBox10";
            this.textBox10.Size = new System.Drawing.Size(365, 20);
            this.textBox10.TabIndex = 10;
            // 
            // OpretGarn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(503, 225);
            this.Controls.Add(this.textBox10);
            this.Controls.Add(this.textBox9);
            this.Controls.Add(this.OpretGarnTextcolor);
            this.Controls.Add(this.OpretGarnTextNavn);
            this.Controls.Add(this.OpretGarnTextType);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.Tilføj);
            this.Name = "OpretGarn";
            this.Text = "OpretGarn";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Tilføj;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox OpretGarnTextType;
        private System.Windows.Forms.TextBox OpretGarnTextNavn;
        private System.Windows.Forms.TextBox OpretGarnTextcolor;
        private System.Windows.Forms.TextBox textBox9;
        private System.Windows.Forms.TextBox textBox10;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}