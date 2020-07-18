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
            this.resetButton = new System.Windows.Forms.Button();
            this.salesCountDateLabel = new System.Windows.Forms.Label();
            this.csCountDateLabel = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.buttonPressTimeoutTextBox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // salesButton
            // 
            this.salesButton.BackColor = System.Drawing.Color.Red;
            this.salesButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.salesButton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.salesButton.Location = new System.Drawing.Point(49, 43);
            this.salesButton.Name = "salesButton";
            this.salesButton.Size = new System.Drawing.Size(211, 93);
            this.salesButton.TabIndex = 0;
            this.salesButton.Text = "Sales";
            this.salesButton.UseVisualStyleBackColor = false;
            this.salesButton.Click += new System.EventHandler(this.salesButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(46, 161);
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
            this.csButton.Location = new System.Drawing.Point(354, 43);
            this.csButton.Name = "csButton";
            this.csButton.Size = new System.Drawing.Size(211, 93);
            this.csButton.TabIndex = 7;
            this.csButton.Text = "Customer Service";
            this.csButton.UseVisualStyleBackColor = false;
            this.csButton.Click += new System.EventHandler(this.csButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(351, 161);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 16);
            this.label2.TabIndex = 8;
            this.label2.Text = "Last Entry: ";
            // 
            // salesCountTextBox
            // 
            this.salesCountTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.salesCountTextBox.Location = new System.Drawing.Point(122, 226);
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
            this.csCountTextBox.Location = new System.Drawing.Point(427, 226);
            this.csCountTextBox.Name = "csCountTextBox";
            this.csCountTextBox.ReadOnly = true;
            this.csCountTextBox.Size = new System.Drawing.Size(64, 35);
            this.csCountTextBox.TabIndex = 10;
            this.csCountTextBox.Text = "0";
            this.csCountTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // resetButton
            // 
            this.resetButton.BackColor = System.Drawing.Color.Red;
            this.resetButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resetButton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.resetButton.Location = new System.Drawing.Point(246, 217);
            this.resetButton.Name = "resetButton";
            this.resetButton.Size = new System.Drawing.Size(116, 56);
            this.resetButton.TabIndex = 11;
            this.resetButton.Text = "Reset";
            this.resetButton.UseVisualStyleBackColor = false;
            this.resetButton.Click += new System.EventHandler(this.resetButton_Click);
            // 
            // salesCountDateLabel
            // 
            this.salesCountDateLabel.AutoSize = true;
            this.salesCountDateLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.salesCountDateLabel.Location = new System.Drawing.Point(124, 161);
            this.salesCountDateLabel.Name = "salesCountDateLabel";
            this.salesCountDateLabel.Size = new System.Drawing.Size(41, 16);
            this.salesCountDateLabel.TabIndex = 13;
            this.salesCountDateLabel.Text = "None";
            // 
            // csCountDateLabel
            // 
            this.csCountDateLabel.AutoSize = true;
            this.csCountDateLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.csCountDateLabel.Location = new System.Drawing.Point(429, 161);
            this.csCountDateLabel.Name = "csCountDateLabel";
            this.csCountDateLabel.Size = new System.Drawing.Size(41, 16);
            this.csCountDateLabel.TabIndex = 14;
            this.csCountDateLabel.Text = "None";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(46, 314);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(204, 16);
            this.label3.TabIndex = 15;
            this.label3.Text = "Button Press Timeout (seconds): ";
            // 
            // buttonPressTimeoutTextBox
            // 
            this.buttonPressTimeoutTextBox.Location = new System.Drawing.Point(271, 314);
            this.buttonPressTimeoutTextBox.Name = "buttonPressTimeoutTextBox";
            this.buttonPressTimeoutTextBox.Size = new System.Drawing.Size(100, 20);
            this.buttonPressTimeoutTextBox.TabIndex = 16;
            this.buttonPressTimeoutTextBox.Text = "30";
            this.buttonPressTimeoutTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // button1
            // 
            this.button1.AutoSize = true;
            this.button1.BackColor = System.Drawing.Color.Red;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button1.Location = new System.Drawing.Point(411, 306);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(101, 34);
            this.button1.TabIndex = 17;
            this.button1.Text = "Set Timeout";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ClientSize = new System.Drawing.Size(611, 382);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.buttonPressTimeoutTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.csCountDateLabel);
            this.Controls.Add(this.salesCountDateLabel);
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
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Load += new System.EventHandler(this.MainForm_Load);
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
        private System.Windows.Forms.Button resetButton;
        private System.Windows.Forms.Label salesCountDateLabel;
        private System.Windows.Forms.Label csCountDateLabel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox buttonPressTimeoutTextBox;
        private System.Windows.Forms.Button button1;
    }
}

