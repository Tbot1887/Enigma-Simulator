namespace Enigma_Machine
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
            System.Windows.Forms.Panel Rotor1;
            System.Windows.Forms.Panel Rotor2;
            System.Windows.Forms.Panel Rotor3;
            this.RotorOne_Lower = new System.Windows.Forms.TextBox();
            this.RotorOne_Center = new System.Windows.Forms.TextBox();
            this.RotorOne_Upper = new System.Windows.Forms.TextBox();
            this.RotorTwo_Lower = new System.Windows.Forms.TextBox();
            this.RotorTwo_Center = new System.Windows.Forms.TextBox();
            this.RotorTwo_Upper = new System.Windows.Forms.TextBox();
            this.RotorThree_Lower = new System.Windows.Forms.TextBox();
            this.RotorThree_Center = new System.Windows.Forms.TextBox();
            this.RotorThree_Upper = new System.Windows.Forms.TextBox();
            this.RotorThree_Name = new System.Windows.Forms.Label();
            this.RotorTwo_Name = new System.Windows.Forms.Label();
            this.RotorOne_Name = new System.Windows.Forms.Label();
            Rotor1 = new System.Windows.Forms.Panel();
            Rotor2 = new System.Windows.Forms.Panel();
            Rotor3 = new System.Windows.Forms.Panel();
            Rotor1.SuspendLayout();
            Rotor2.SuspendLayout();
            Rotor3.SuspendLayout();
            this.SuspendLayout();
            // 
            // Rotor1
            // 
            Rotor1.BackColor = System.Drawing.Color.Transparent;
            Rotor1.Controls.Add(this.RotorOne_Lower);
            Rotor1.Controls.Add(this.RotorOne_Center);
            Rotor1.Controls.Add(this.RotorOne_Upper);
            Rotor1.Location = new System.Drawing.Point(450, 34);
            Rotor1.Name = "Rotor1";
            Rotor1.Size = new System.Drawing.Size(200, 67);
            Rotor1.TabIndex = 1;
            // 
            // RotorOne_Lower
            // 
            this.RotorOne_Lower.Enabled = false;
            this.RotorOne_Lower.Location = new System.Drawing.Point(76, 43);
            this.RotorOne_Lower.Name = "RotorOne_Lower";
            this.RotorOne_Lower.ReadOnly = true;
            this.RotorOne_Lower.Size = new System.Drawing.Size(49, 22);
            this.RotorOne_Lower.TabIndex = 2;
            this.RotorOne_Lower.TabStop = false;
            this.RotorOne_Lower.Text = "26";
            this.RotorOne_Lower.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // RotorOne_Center
            // 
            this.RotorOne_Center.Enabled = false;
            this.RotorOne_Center.Location = new System.Drawing.Point(76, 22);
            this.RotorOne_Center.Name = "RotorOne_Center";
            this.RotorOne_Center.ReadOnly = true;
            this.RotorOne_Center.Size = new System.Drawing.Size(49, 22);
            this.RotorOne_Center.TabIndex = 1;
            this.RotorOne_Center.TabStop = false;
            this.RotorOne_Center.Text = "1";
            this.RotorOne_Center.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // RotorOne_Upper
            // 
            this.RotorOne_Upper.Enabled = false;
            this.RotorOne_Upper.Location = new System.Drawing.Point(76, 1);
            this.RotorOne_Upper.Name = "RotorOne_Upper";
            this.RotorOne_Upper.ReadOnly = true;
            this.RotorOne_Upper.Size = new System.Drawing.Size(49, 22);
            this.RotorOne_Upper.TabIndex = 0;
            this.RotorOne_Upper.TabStop = false;
            this.RotorOne_Upper.Text = "2";
            this.RotorOne_Upper.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Rotor2
            // 
            Rotor2.BackColor = System.Drawing.Color.Transparent;
            Rotor2.Controls.Add(this.RotorTwo_Lower);
            Rotor2.Controls.Add(this.RotorTwo_Center);
            Rotor2.Controls.Add(this.RotorTwo_Upper);
            Rotor2.Location = new System.Drawing.Point(320, 34);
            Rotor2.Name = "Rotor2";
            Rotor2.Size = new System.Drawing.Size(200, 67);
            Rotor2.TabIndex = 3;
            // 
            // RotorTwo_Lower
            // 
            this.RotorTwo_Lower.Enabled = false;
            this.RotorTwo_Lower.Location = new System.Drawing.Point(76, 43);
            this.RotorTwo_Lower.Name = "RotorTwo_Lower";
            this.RotorTwo_Lower.ReadOnly = true;
            this.RotorTwo_Lower.Size = new System.Drawing.Size(49, 22);
            this.RotorTwo_Lower.TabIndex = 2;
            this.RotorTwo_Lower.TabStop = false;
            this.RotorTwo_Lower.Text = "26";
            this.RotorTwo_Lower.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // RotorTwo_Center
            // 
            this.RotorTwo_Center.Enabled = false;
            this.RotorTwo_Center.Location = new System.Drawing.Point(76, 22);
            this.RotorTwo_Center.Name = "RotorTwo_Center";
            this.RotorTwo_Center.ReadOnly = true;
            this.RotorTwo_Center.Size = new System.Drawing.Size(49, 22);
            this.RotorTwo_Center.TabIndex = 1;
            this.RotorTwo_Center.TabStop = false;
            this.RotorTwo_Center.Text = "1";
            this.RotorTwo_Center.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // RotorTwo_Upper
            // 
            this.RotorTwo_Upper.Enabled = false;
            this.RotorTwo_Upper.Location = new System.Drawing.Point(76, 1);
            this.RotorTwo_Upper.Name = "RotorTwo_Upper";
            this.RotorTwo_Upper.ReadOnly = true;
            this.RotorTwo_Upper.Size = new System.Drawing.Size(49, 22);
            this.RotorTwo_Upper.TabIndex = 0;
            this.RotorTwo_Upper.TabStop = false;
            this.RotorTwo_Upper.Text = "2";
            this.RotorTwo_Upper.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Rotor3
            // 
            Rotor3.BackColor = System.Drawing.Color.Transparent;
            Rotor3.Controls.Add(this.RotorThree_Lower);
            Rotor3.Controls.Add(this.RotorThree_Center);
            Rotor3.Controls.Add(this.RotorThree_Upper);
            Rotor3.Location = new System.Drawing.Point(190, 34);
            Rotor3.Name = "Rotor3";
            Rotor3.Size = new System.Drawing.Size(200, 67);
            Rotor3.TabIndex = 4;
            // 
            // RotorThree_Lower
            // 
            this.RotorThree_Lower.Enabled = false;
            this.RotorThree_Lower.Location = new System.Drawing.Point(76, 43);
            this.RotorThree_Lower.Name = "RotorThree_Lower";
            this.RotorThree_Lower.ReadOnly = true;
            this.RotorThree_Lower.Size = new System.Drawing.Size(49, 22);
            this.RotorThree_Lower.TabIndex = 2;
            this.RotorThree_Lower.TabStop = false;
            this.RotorThree_Lower.Text = "26";
            this.RotorThree_Lower.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // RotorThree_Center
            // 
            this.RotorThree_Center.Enabled = false;
            this.RotorThree_Center.Location = new System.Drawing.Point(76, 22);
            this.RotorThree_Center.Name = "RotorThree_Center";
            this.RotorThree_Center.ReadOnly = true;
            this.RotorThree_Center.Size = new System.Drawing.Size(49, 22);
            this.RotorThree_Center.TabIndex = 1;
            this.RotorThree_Center.TabStop = false;
            this.RotorThree_Center.Text = "1";
            this.RotorThree_Center.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // RotorThree_Upper
            // 
            this.RotorThree_Upper.Enabled = false;
            this.RotorThree_Upper.Location = new System.Drawing.Point(76, 1);
            this.RotorThree_Upper.Name = "RotorThree_Upper";
            this.RotorThree_Upper.ReadOnly = true;
            this.RotorThree_Upper.Size = new System.Drawing.Size(49, 22);
            this.RotorThree_Upper.TabIndex = 0;
            this.RotorThree_Upper.TabStop = false;
            this.RotorThree_Upper.Text = "2";
            this.RotorThree_Upper.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // RotorThree_Name
            // 
            this.RotorThree_Name.AutoSize = true;
            this.RotorThree_Name.BackColor = System.Drawing.Color.Transparent;
            this.RotorThree_Name.Enabled = false;
            this.RotorThree_Name.Font = new System.Drawing.Font("JMH Typewriter", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RotorThree_Name.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.RotorThree_Name.Location = new System.Drawing.Point(271, 9);
            this.RotorThree_Name.Name = "RotorThree_Name";
            this.RotorThree_Name.Size = new System.Drawing.Size(44, 15);
            this.RotorThree_Name.TabIndex = 5;
            this.RotorThree_Name.Text = "label1";
            this.RotorThree_Name.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // RotorTwo_Name
            // 
            this.RotorTwo_Name.AutoSize = true;
            this.RotorTwo_Name.BackColor = System.Drawing.Color.Transparent;
            this.RotorTwo_Name.Enabled = false;
            this.RotorTwo_Name.Font = new System.Drawing.Font("JMH Typewriter", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RotorTwo_Name.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.RotorTwo_Name.Location = new System.Drawing.Point(401, 9);
            this.RotorTwo_Name.Name = "RotorTwo_Name";
            this.RotorTwo_Name.Size = new System.Drawing.Size(44, 15);
            this.RotorTwo_Name.TabIndex = 6;
            this.RotorTwo_Name.Text = "label2";
            this.RotorTwo_Name.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // RotorOne_Name
            // 
            this.RotorOne_Name.AutoSize = true;
            this.RotorOne_Name.BackColor = System.Drawing.Color.Transparent;
            this.RotorOne_Name.Enabled = false;
            this.RotorOne_Name.Font = new System.Drawing.Font("JMH Typewriter", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RotorOne_Name.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.RotorOne_Name.Location = new System.Drawing.Point(530, 9);
            this.RotorOne_Name.Name = "RotorOne_Name";
            this.RotorOne_Name.Size = new System.Drawing.Size(44, 15);
            this.RotorOne_Name.TabIndex = 7;
            this.RotorOne_Name.Text = "label3";
            this.RotorOne_Name.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Enigma_Machine.Properties.Resources.blacktexture;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(933, 578);
            this.Controls.Add(this.RotorOne_Name);
            this.Controls.Add(this.RotorTwo_Name);
            this.Controls.Add(this.RotorThree_Name);
            this.Controls.Add(Rotor3);
            this.Controls.Add(Rotor2);
            this.Controls.Add(Rotor1);
            this.Font = new System.Drawing.Font("JMH Typewriter", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Enigma Machine";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyUp);
            Rotor1.ResumeLayout(false);
            Rotor1.PerformLayout();
            Rotor2.ResumeLayout(false);
            Rotor2.PerformLayout();
            Rotor3.ResumeLayout(false);
            Rotor3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox RotorOne_Upper;
        private System.Windows.Forms.TextBox RotorOne_Lower;
        private System.Windows.Forms.TextBox RotorOne_Center;
        private System.Windows.Forms.TextBox RotorTwo_Lower;
        private System.Windows.Forms.TextBox RotorTwo_Center;
        private System.Windows.Forms.TextBox RotorTwo_Upper;
        private System.Windows.Forms.TextBox RotorThree_Lower;
        private System.Windows.Forms.TextBox RotorThree_Center;
        private System.Windows.Forms.TextBox RotorThree_Upper;
        private System.Windows.Forms.Label RotorThree_Name;
        private System.Windows.Forms.Label RotorTwo_Name;
        private System.Windows.Forms.Label RotorOne_Name;
    }
}

