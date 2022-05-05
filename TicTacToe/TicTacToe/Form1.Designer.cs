namespace TicTacToe
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
            this.A00 = new System.Windows.Forms.Button();
            this.A01 = new System.Windows.Forms.Button();
            this.A02 = new System.Windows.Forms.Button();
            this.A10 = new System.Windows.Forms.Button();
            this.A11 = new System.Windows.Forms.Button();
            this.A12 = new System.Windows.Forms.Button();
            this.A20 = new System.Windows.Forms.Button();
            this.A21 = new System.Windows.Forms.Button();
            this.NGMButton = new System.Windows.Forms.Button();
            this.Player1Label = new System.Windows.Forms.Label();
            this.ResetButton = new System.Windows.Forms.Button();
            this.ExitButton = new System.Windows.Forms.Button();
            this.DrawLabel = new System.Windows.Forms.Label();
            this.Player2Label = new System.Windows.Forms.Label();
            this.A22 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // A00
            // 
            this.A00.Location = new System.Drawing.Point(12, 12);
            this.A00.Name = "A00";
            this.A00.Size = new System.Drawing.Size(75, 76);
            this.A00.TabIndex = 0;
            this.A00.UseVisualStyleBackColor = true;
            this.A00.Click += new System.EventHandler(this.buttonClick);
            // 
            // A01
            // 
            this.A01.Location = new System.Drawing.Point(93, 12);
            this.A01.Name = "A01";
            this.A01.Size = new System.Drawing.Size(75, 76);
            this.A01.TabIndex = 1;
            this.A01.UseVisualStyleBackColor = true;
            this.A01.Click += new System.EventHandler(this.buttonClick);
            // 
            // A02
            // 
            this.A02.Location = new System.Drawing.Point(174, 12);
            this.A02.Name = "A02";
            this.A02.Size = new System.Drawing.Size(75, 76);
            this.A02.TabIndex = 2;
            this.A02.UseVisualStyleBackColor = true;
            this.A02.Click += new System.EventHandler(this.buttonClick);
            // 
            // A10
            // 
            this.A10.Location = new System.Drawing.Point(12, 94);
            this.A10.Name = "A10";
            this.A10.Size = new System.Drawing.Size(75, 76);
            this.A10.TabIndex = 3;
            this.A10.UseVisualStyleBackColor = true;
            this.A10.Click += new System.EventHandler(this.buttonClick);
            // 
            // A11
            // 
            this.A11.Location = new System.Drawing.Point(93, 94);
            this.A11.Name = "A11";
            this.A11.Size = new System.Drawing.Size(75, 76);
            this.A11.TabIndex = 4;
            this.A11.UseVisualStyleBackColor = true;
            this.A11.Click += new System.EventHandler(this.buttonClick);
            // 
            // A12
            // 
            this.A12.Location = new System.Drawing.Point(174, 176);
            this.A12.Name = "A12";
            this.A12.Size = new System.Drawing.Size(75, 76);
            this.A12.TabIndex = 5;
            this.A12.UseVisualStyleBackColor = true;
            this.A12.Click += new System.EventHandler(this.buttonClick);
            // 
            // A20
            // 
            this.A20.Location = new System.Drawing.Point(12, 176);
            this.A20.Name = "A20";
            this.A20.Size = new System.Drawing.Size(75, 76);
            this.A20.TabIndex = 6;
            this.A20.UseVisualStyleBackColor = true;
            this.A20.Click += new System.EventHandler(this.buttonClick);
            // 
            // A21
            // 
            this.A21.Location = new System.Drawing.Point(93, 176);
            this.A21.Name = "A21";
            this.A21.Size = new System.Drawing.Size(75, 76);
            this.A21.TabIndex = 7;
            this.A21.UseVisualStyleBackColor = true;
            this.A21.Click += new System.EventHandler(this.buttonClick);
            // 
            // NGMButton
            // 
            this.NGMButton.Location = new System.Drawing.Point(271, 188);
            this.NGMButton.Name = "NGMButton";
            this.NGMButton.Size = new System.Drawing.Size(99, 52);
            this.NGMButton.TabIndex = 9;
            this.NGMButton.Text = "New Game";
            this.NGMButton.UseVisualStyleBackColor = true;
            this.NGMButton.Click += new System.EventHandler(this.NGMButton_Click);
            // 
            // Player1Label
            // 
            this.Player1Label.AutoSize = true;
            this.Player1Label.Location = new System.Drawing.Point(302, 44);
            this.Player1Label.Name = "Player1Label";
            this.Player1Label.Size = new System.Drawing.Size(35, 13);
            this.Player1Label.TabIndex = 11;
            this.Player1Label.Text = "label1";
            // 
            // ResetButton
            // 
            this.ResetButton.Location = new System.Drawing.Point(394, 188);
            this.ResetButton.Name = "ResetButton";
            this.ResetButton.Size = new System.Drawing.Size(99, 52);
            this.ResetButton.TabIndex = 12;
            this.ResetButton.Text = "Reset";
            this.ResetButton.UseVisualStyleBackColor = true;
            this.ResetButton.Click += new System.EventHandler(this.ResetButton_Click);
            // 
            // ExitButton
            // 
            this.ExitButton.Location = new System.Drawing.Point(516, 188);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(99, 52);
            this.ExitButton.TabIndex = 13;
            this.ExitButton.Text = "Exit";
            this.ExitButton.UseVisualStyleBackColor = true;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // DrawLabel
            // 
            this.DrawLabel.AutoSize = true;
            this.DrawLabel.Location = new System.Drawing.Point(423, 44);
            this.DrawLabel.Name = "DrawLabel";
            this.DrawLabel.Size = new System.Drawing.Size(35, 13);
            this.DrawLabel.TabIndex = 14;
            this.DrawLabel.Text = "label2";
            // 
            // Player2Label
            // 
            this.Player2Label.AutoSize = true;
            this.Player2Label.Location = new System.Drawing.Point(550, 44);
            this.Player2Label.Name = "Player2Label";
            this.Player2Label.Size = new System.Drawing.Size(35, 13);
            this.Player2Label.TabIndex = 15;
            this.Player2Label.Text = "label3";
            // 
            // A22
            // 
            this.A22.Location = new System.Drawing.Point(174, 94);
            this.A22.Name = "A22";
            this.A22.Size = new System.Drawing.Size(75, 76);
            this.A22.TabIndex = 16;
            this.A22.UseVisualStyleBackColor = true;
            this.A22.Click += new System.EventHandler(this.buttonClick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(653, 272);
            this.Controls.Add(this.A22);
            this.Controls.Add(this.Player2Label);
            this.Controls.Add(this.DrawLabel);
            this.Controls.Add(this.ExitButton);
            this.Controls.Add(this.ResetButton);
            this.Controls.Add(this.Player1Label);
            this.Controls.Add(this.NGMButton);
            this.Controls.Add(this.A21);
            this.Controls.Add(this.A20);
            this.Controls.Add(this.A12);
            this.Controls.Add(this.A11);
            this.Controls.Add(this.A10);
            this.Controls.Add(this.A02);
            this.Controls.Add(this.A01);
            this.Controls.Add(this.A00);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button A00;
        private System.Windows.Forms.Button A01;
        private System.Windows.Forms.Button A02;
        private System.Windows.Forms.Button A10;
        private System.Windows.Forms.Button A11;
        private System.Windows.Forms.Button A12;
        private System.Windows.Forms.Button A20;
        private System.Windows.Forms.Button A21;
        private System.Windows.Forms.Button NGMButton;
        private System.Windows.Forms.Label Player1Label;
        private System.Windows.Forms.Button ResetButton;
        private System.Windows.Forms.Button ExitButton;
        private System.Windows.Forms.Label DrawLabel;
        private System.Windows.Forms.Label Player2Label;
        private System.Windows.Forms.Button A22;
    }
}

