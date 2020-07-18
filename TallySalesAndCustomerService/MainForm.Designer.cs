namespace TallySalesAndCustomerService
{
    partial class MainForm
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
            this.salesButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.csButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.salesCountTextBox = new System.Windows.Forms.TextBox();
            this.csCountTextBox = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.resetButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // salesButton
            // 
            this.salesButton.BackColor = System.Drawing.Color.Red;
            this.salesButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.salesButton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.salesButton.Location = new System.Drawing.Point(142, 119);
            this.salesButton.Name = "salesButton";
            this.salesButton.Size = new System.Drawing.Size(211, 93);
            this.salesButton.TabIndex = 0;
            this.salesButton.Text = "Sales";
            this.salesButton.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(139, 237);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 16);
            this.label1.TabIndex = 6;
            this.label1.Text = "Last Entry: ";
            // 
            // csButton
            // 
            this.csButton.BackColor = System.Drawing.Color.Red;
            this.csButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.csButton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.csButton.Location = new System.Drawing.Point(447, 119);
            this.csButton.Name = "csButton";
            this.csButton.Size = new System.Drawing.Size(211, 93);
            this.csButton.TabIndex = 7;
            this.csButton.Text = "Customer Service";
            this.csButton.UseVisualStyleBackColor = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(444, 237);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 16);
            this.label2.TabIndex = 8;
            this.label2.Text = "Last Entry: ";
            // 
            // salesCountTextBox
            // 
            this.salesCountTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.salesCountTextBox.Location = new System.Drawing.Point(215, 302);
            this.salesCountTextBox.Name = "salesCountTextBox";
            this.salesCountTextBox.ReadOnly = true;
            this.salesCountTextBox.Size = new System.Drawing.Size(64, 35);
            this.salesCountTextBox.TabIndex = 9;
            this.salesCountTextBox.Text = "0";
            this.salesCountTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // csCountTextBox
            // 
            this.csCountTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.csCountTextBox.Location = new System.Drawing.Point(520, 302);
            this.csCountTextBox.Name = "csCountTextBox";
            this.csCountTextBox.ReadOnly = true;
            this.csCountTextBox.Size = new System.Drawing.Size(64, 35);
            this.csCountTextBox.TabIndex = 10;
            this.csCountTextBox.Text = "0";
            this.csCountTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(358, 454);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(64, 35);
            this.textBox1.TabIndex = 12;
            this.textBox1.Text = "0";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // resetButton
            // 
            this.resetButton.BackColor = System.Drawing.Color.Red;
            this.resetButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resetButton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.resetButton.Location = new System.Drawing.Point(339, 293);
            this.resetButton.Name = "resetButton";
            this.resetButton.Size = new System.Drawing.Size(116, 56);
            this.resetButton.TabIndex = 11;
            this.resetButton.Text = "Reset";
            this.resetButton.UseVisualStyleBackColor = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.resetButton);
            this.Controls.Add(this.csCountTextBox);
            this.Controls.Add(this.salesCountTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.csButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.salesButton);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sales and Customer Support Counts";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button salesButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button csButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox salesCountTextBox;
        private System.Windows.Forms.TextBox csCountTextBox;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button resetButton;
    }
}

