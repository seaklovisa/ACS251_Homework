﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Windows.Forms;

namespace ObserverPatterHomework
{
    public partial class Form1 : Form
    {
        private GameCenter gameCenter;

        public Form1()
        {
            InitializeComponent();
            gameCenter = new GameCenter();
        }

        public void UpdateUI()
        {
            this.txtMessage.Text += gameCenter.DisplayMessage;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (gameCenter.PlayersCount == 0)
            {
                MessageBox.Show("請先點選人物加入遊戲");
                return;
            }

            gameCenter.StartMurder();
            this.txtMessage.Text = gameCenter.DisplayMessage;
            this.lblJamesStatus.Text = gameCenter.setJamesStatus();
            this.lblBearStatus.Text = gameCenter.setBearStatus();
            this.lblBreadStatus.Text = gameCenter.setbreadStatus();
            this.lblRabbitStatus.Text = gameCenter.setrabbitStatus();
        }

        private void picJames_Click(object sender, EventArgs e)
        {
            MessageBox.Show(String.Format("歡迎{0}加入遊戲", gameCenter.JamesJoinOrLeaveGame()));
            this.lblJamesStatus.Text = gameCenter.setJamesStatus();
            /*
            james = new JamesPlayer() { Name = "詹姆士", HP = 4500, Level = 12, status = this.lblJamesStatus };
            lblJamesStatus.Text = "生命值:" + (james.HP < 0 ? 0 : james.HP) + Environment.NewLine + "等級:" + james.Level;
            gameCenter.IsExistsPlayer(new JamesPlayer() { Name = "詹姆士", HP = 4500, Level = 12 });
            james.Members = gameCenter.GetPlayers();
            MessageBox.Show("歡迎" + james.Name + "加入遊戲");
            */
        }

        private void picBreadMan_Click(object sender, EventArgs e)
        {
            MessageBox.Show(String.Format("歡迎{0}加入遊戲", gameCenter.BreadJoinOrLeaveGame()));

            this.lblBreadStatus.Text = gameCenter.setbreadStatus();
            /*
            bread = new BreadPlayer() { Name = "饅頭人", HP = 5200, Level = 13, status = this.lblBreadStatus };
            this.lblBreadStatus.Text = "生命值:" + (bread.HP < 0 ? 0 : bread.HP) + Environment.NewLine + "等級:" + bread.Level;
            gameCenter.IsExistsPlayer(bread);
            bread.Members = gameCenter.GetPlayers();
            MessageBox.Show("歡迎" + bread.Name + "加入遊戲");
            */
        }

        private void picRabbit_Click(object sender, EventArgs e)
        {
            MessageBox.Show(String.Format("歡迎{0}加入遊戲", gameCenter.RabbitJoinOrLeaveGame()));

            this.lblRabbitStatus.Text = gameCenter.setrabbitStatus();
            /*
            rabbit = new RabbitPlayer() { Name = "兔兔", HP = 4000, Level = 13, status = this.lblRabbitStatus };
            this.lblRabbitStatus.Text = "生命值:" + (rabbit.HP < 0 ? 0 : rabbit.HP) + Environment.NewLine + "等級:" + rabbit.Level;
            gameCenter.IsExistsPlayer(rabbit);
            rabbit.Members = gameCenter.GetPlayers();
            MessageBox.Show("歡迎" + rabbit.Name + "加入遊戲");
            */
        }

        private void picBear_Click(object sender, EventArgs e)
        {
            MessageBox.Show(String.Format("歡迎{0}加入遊戲", gameCenter.BearJoinOrLeaveGame()));
            this.lblBearStatus.Text = gameCenter.setBearStatus();

            /*
            bear = new BearPlayer() { Name = "雄大", HP = 6000, Level = 10, status = this.lblBearStatus };
            this.lblBearStatus.Text = "生命值:" + (bear.HP < 0 ? 0 : bear.HP) + Environment.NewLine + "等級:" + bear.Level;
            gameCenter.IsExistsPlayer(bear);
            bear.Members = gameCenter.GetPlayers();
            MessageBox.Show("歡迎" + bear.Name + "加入遊戲");
            */
        }
    }
}