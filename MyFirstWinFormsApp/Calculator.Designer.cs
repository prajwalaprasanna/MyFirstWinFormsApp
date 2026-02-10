
namespace MyFirstWinFormsApp
{
    partial class Calculator
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.FirstNumber = new System.Windows.Forms.TextBox();
            this.SecondNumber = new System.Windows.Forms.TextBox();
            this.SumButton = new System.Windows.Forms.Button();
            this.Summation = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(102, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Enter first num";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(106, 143);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(139, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Enter second num";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(110, 276);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Summation";
            // 
            // FirstNumber
            // 
            this.FirstNumber.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.FirstNumber.Location = new System.Drawing.Point(385, 38);
            this.FirstNumber.Multiline = true;
            this.FirstNumber.Name = "FirstNumber";
            this.FirstNumber.Size = new System.Drawing.Size(238, 45);
            this.FirstNumber.TabIndex = 3;
            // 
            // SecondNumber
            // 
            this.SecondNumber.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.SecondNumber.Location = new System.Drawing.Point(385, 124);
            this.SecondNumber.Multiline = true;
            this.SecondNumber.Name = "SecondNumber";
            this.SecondNumber.Size = new System.Drawing.Size(238, 45);
            this.SecondNumber.TabIndex = 4;
            // 
            // SumButton
            // 
            this.SumButton.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.SumButton.Location = new System.Drawing.Point(472, 208);
            this.SumButton.Name = "SumButton";
            this.SumButton.Size = new System.Drawing.Size(94, 45);
            this.SumButton.TabIndex = 5;
            this.SumButton.Text = "Sum";
            this.SumButton.UseVisualStyleBackColor = false;
            this.SumButton.Click += new System.EventHandler(this.SumButton_Click);
            // 
            // Summation
            // 
            this.Summation.Location = new System.Drawing.Point(395, 286);
            this.Summation.Multiline = true;
            this.Summation.Name = "Summation";
            this.Summation.Size = new System.Drawing.Size(238, 45);
            this.Summation.TabIndex = 6;
            this.Summation.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // Calculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Summation);
            this.Controls.Add(this.SumButton);
            this.Controls.Add(this.SecondNumber);
            this.Controls.Add(this.FirstNumber);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Calculator";
            this.Text = "Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox FirstNumber;
        private System.Windows.Forms.TextBox SecondNumber;
        private System.Windows.Forms.Button SumButton;
        private System.Windows.Forms.TextBox Summation;
    }
}