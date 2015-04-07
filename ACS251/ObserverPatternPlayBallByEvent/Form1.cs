using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ObserverPatternPlayBallByEvent
{
    public partial class Form1 : Form
    {
        private GameController game;

        public Form1()
        {
            InitializeComponent();
            game = new GameController();
            UpdateUI();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            game.PlayBall(double.Parse(this.textBox1.Text), double.Parse(this.textBox2.Text));
            UpdateUI();
        }

        public void UpdateUI()
        {
            richTextBox1.Text = game.DisplayMessage;
        }
    }
}