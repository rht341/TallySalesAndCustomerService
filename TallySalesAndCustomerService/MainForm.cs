using System;
using System.Drawing;
using System.Windows.Forms;

namespace TallySalesAndCustomerService
{
    public partial class MainForm : Form
    {
        public int SalesCount { get; set; }
        public int CSCount { get; set; }

        private readonly static Timer salesTimer = new Timer();
        private readonly static Timer csTimer = new Timer();

        //const int COUNTDOWNTIME = 5000;

        public int ButtonPressCountDownTime { get; set; }
        public MainForm()
        {
            salesTimer.Tick += SalesTimerEventProcessor;
            //salesTimer.Interval = COUNTDOWNTIME;
            csTimer.Tick += csTimerEventProcessor;
            //csTimer.Interval = COUNTDOWNTIME;

            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            int buttonPressCountDownTime = Int32.Parse(buttonPressTimeoutTextBox.Text) * 1000;
            salesTimer.Interval = buttonPressCountDownTime;
            csTimer.Interval = buttonPressCountDownTime;

            ResetValues();
        }

        private void SalesTimerEventProcessor(object sender, EventArgs e)
        {
            salesTimer.Stop();

            salesButton.Enabled = true;
            salesButton.BackColor = Color.Red;
        }

        private void csTimerEventProcessor(object sender, EventArgs e)
        {
            csTimer.Stop();

            csButton.Enabled = true;
            csButton.BackColor = Color.Red;
        }
        private void ResetValues()
        {
            salesCountDateLabel.Text = "None";
            salesCountTextBox.Text = "0";
            csCountDateLabel.Text = "None";
            csCountTextBox.Text = "0";
        }

        private void resetButton_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to reset?",
                                                  "Reset?",
                                                  MessageBoxButtons.YesNo,
                                                  MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                ResetValues();
            }
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to exit? All values will be lost.",
                                                  "Exit?",
                                                  MessageBoxButtons.YesNo,
                                                  MessageBoxIcon.Question);

            if (result == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        private void salesButton_Click(object sender, EventArgs e)
        {
            SalesCount++;

            salesCountTextBox.Text = SalesCount.ToString();
            salesCountDateLabel.Text = DateTime.Now.ToString();

            salesButton.Enabled = false;
            salesButton.BackColor = Color.Gray;
            salesTimer.Start();
        }

        private void csButton_Click(object sender, EventArgs e)
        {
            CSCount++;

            csCountTextBox.Text = CSCount.ToString();
            csCountDateLabel.Text = DateTime.Now.ToString();

            csButton.Enabled = false;
            csButton.BackColor = Color.Gray;
            csTimer.Start();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int newTimeout = Int32.Parse(buttonPressTimeoutTextBox.Text) * 1000;

            salesTimer.Interval = newTimeout;
            csTimer.Interval = newTimeout;
        }
    }
}