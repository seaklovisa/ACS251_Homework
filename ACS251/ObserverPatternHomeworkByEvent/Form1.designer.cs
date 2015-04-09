namespace ObserverPatternHomeworkByEvent
{
    partial class Form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置 Managed 資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器
        /// 修改這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.txtMessage = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblBearStatus = new System.Windows.Forms.Label();
            this.lblRabbitStatus = new System.Windows.Forms.Label();
            this.lblBreadStatus = new System.Windows.Forms.Label();
            this.lblJamesStatus = new System.Windows.Forms.Label();
            this.picBear = new System.Windows.Forms.PictureBox();
            this.picRabbit = new System.Windows.Forms.PictureBox();
            this.picBreadMan = new System.Windows.Forms.PictureBox();
            this.picJames = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBear)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picRabbit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBreadMan)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picJames)).BeginInit();
            this.SuspendLayout();
            // 
            // txtMessage
            // 
            this.txtMessage.Location = new System.Drawing.Point(12, 188);
            this.txtMessage.Multiline = true;
            this.txtMessage.Name = "txtMessage";
            this.txtMessage.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtMessage.Size = new System.Drawing.Size(360, 73);
            this.txtMessage.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(390, 188);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(138, 73);
            this.button1.TabIndex = 1;
            this.button1.Text = "模擬攻擊";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lblBearStatus);
            this.panel1.Controls.Add(this.lblRabbitStatus);
            this.panel1.Controls.Add(this.lblBreadStatus);
            this.panel1.Controls.Add(this.lblJamesStatus);
            this.panel1.Controls.Add(this.picBear);
            this.panel1.Controls.Add(this.picRabbit);
            this.panel1.Controls.Add(this.picBreadMan);
            this.panel1.Controls.Add(this.picJames);
            this.panel1.Location = new System.Drawing.Point(12, 13);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(516, 169);
            this.panel1.TabIndex = 2;
            // 
            // lblBearStatus
            // 
            this.lblBearStatus.Location = new System.Drawing.Point(400, 124);
            this.lblBearStatus.Name = "lblBearStatus";
            this.lblBearStatus.Size = new System.Drawing.Size(100, 40);
            this.lblBearStatus.TabIndex = 7;
            this.lblBearStatus.Text = "label4";
            // 
            // lblRabbitStatus
            // 
            this.lblRabbitStatus.Location = new System.Drawing.Point(277, 124);
            this.lblRabbitStatus.Name = "lblRabbitStatus";
            this.lblRabbitStatus.Size = new System.Drawing.Size(100, 40);
            this.lblRabbitStatus.TabIndex = 6;
            this.lblRabbitStatus.Text = "label3";
            // 
            // lblBreadStatus
            // 
            this.lblBreadStatus.Location = new System.Drawing.Point(143, 124);
            this.lblBreadStatus.Name = "lblBreadStatus";
            this.lblBreadStatus.Size = new System.Drawing.Size(100, 40);
            this.lblBreadStatus.TabIndex = 5;
            this.lblBreadStatus.Text = "label2";
            // 
            // lblJamesStatus
            // 
            this.lblJamesStatus.Location = new System.Drawing.Point(14, 124);
            this.lblJamesStatus.Name = "lblJamesStatus";
            this.lblJamesStatus.Size = new System.Drawing.Size(100, 40);
            this.lblJamesStatus.TabIndex = 4;
            this.lblJamesStatus.Text = "label1";
            // 
            // picBear
            // 
            this.picBear.Image = ((System.Drawing.Image)(resources.GetObject("picBear.Image")));
            this.picBear.Location = new System.Drawing.Point(402, 14);
            this.picBear.Name = "picBear";
            this.picBear.Size = new System.Drawing.Size(100, 103);
            this.picBear.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBear.TabIndex = 3;
            this.picBear.TabStop = false;
            this.picBear.Click += new System.EventHandler(this.picBear_Click);
            // 
            // picRabbit
            // 
            this.picRabbit.Image = ((System.Drawing.Image)(resources.GetObject("picRabbit.Image")));
            this.picRabbit.Location = new System.Drawing.Point(279, 14);
            this.picRabbit.Name = "picRabbit";
            this.picRabbit.Size = new System.Drawing.Size(100, 103);
            this.picRabbit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picRabbit.TabIndex = 2;
            this.picRabbit.TabStop = false;
            this.picRabbit.Click += new System.EventHandler(this.picRabbit_Click);
            // 
            // picBreadMan
            // 
            this.picBreadMan.Image = ((System.Drawing.Image)(resources.GetObject("picBreadMan.Image")));
            this.picBreadMan.Location = new System.Drawing.Point(145, 14);
            this.picBreadMan.Name = "picBreadMan";
            this.picBreadMan.Size = new System.Drawing.Size(100, 103);
            this.picBreadMan.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBreadMan.TabIndex = 1;
            this.picBreadMan.TabStop = false;
            this.picBreadMan.Click += new System.EventHandler(this.picBreadMan_Click);
            // 
            // picJames
            // 
            this.picJames.Image = ((System.Drawing.Image)(resources.GetObject("picJames.Image")));
            this.picJames.Location = new System.Drawing.Point(14, 14);
            this.picJames.Name = "picJames";
            this.picJames.Size = new System.Drawing.Size(100, 103);
            this.picJames.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picJames.TabIndex = 0;
            this.picJames.TabStop = false;
            this.picJames.Click += new System.EventHandler(this.picJames_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(540, 273);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtMessage);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picBear)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picRabbit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBreadMan)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picJames)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtMessage;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox picBear;
        private System.Windows.Forms.PictureBox picRabbit;
        private System.Windows.Forms.PictureBox picBreadMan;
        private System.Windows.Forms.PictureBox picJames;
        private System.Windows.Forms.Label lblBearStatus;
        private System.Windows.Forms.Label lblRabbitStatus;
        private System.Windows.Forms.Label lblBreadStatus;
        private System.Windows.Forms.Label lblJamesStatus;
    }
}

