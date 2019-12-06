using System.Windows.Forms;

namespace Raffle_System
{
    partial class RaffleGuest
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
            float screenHeight = SystemInformation.VirtualScreen.Height;

            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RaffleGuest));
            this.timeRandom = new System.Windows.Forms.Timer(this.components);
            this.pbRandomGuest = new System.Windows.Forms.ProgressBar();
            this.pnlMain = new System.Windows.Forms.TableLayoutPanel();
            this.pnlBottom = new System.Windows.Forms.TableLayoutPanel();
            this.btnBack = new System.Windows.Forms.Label();
            this.pnlTop = new System.Windows.Forms.TableLayoutPanel();
            this.lblRandomGuest = new System.Windows.Forms.Label();
            this.lblRandomSchool = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnRaffleStart = new RoundButton();
            this.pnlMain.SuspendLayout();
            this.pnlBottom.SuspendLayout();
            this.pnlTop.SuspendLayout();
            this.SuspendLayout();
            // 
            // timeRandom
            // 
            this.timeRandom.Tick += new System.EventHandler(this.timeRandom_Tick);
            this.timeRandom.Interval = 100;
            // 
            // pbRandomGuest
            // 
            this.pbRandomGuest.Name = "pbRandomGuest";
            this.pbRandomGuest.Visible = false;
            this.pbRandomGuest.Maximum = 600;
            // 
            // pnlMain
            // 
            this.pnlMain.BackColor = System.Drawing.Color.Transparent;
            this.pnlMain.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnlMain.BackgroundImage")));
            this.pnlMain.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlMain.ColumnCount = 1;
            this.pnlMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.pnlMain.Controls.Add(this.pnlBottom, 0, 1);
            this.pnlMain.Controls.Add(this.pnlTop, 0, 0);
            this.pnlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMain.Location = new System.Drawing.Point(10, 10);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.RowCount = 2;
            this.pnlMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 75F));
            this.pnlMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.pnlMain.Size = new System.Drawing.Size(1260, 700);
            this.pnlMain.TabIndex = 0;
            // 
            // pnlBottom
            // 
            this.pnlBottom.ColumnCount = 3;
            this.pnlBottom.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.pnlBottom.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.pnlBottom.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.pnlBottom.Controls.Add(this.btnRaffleStart, 1, 0);
            this.pnlBottom.Controls.Add(this.btnBack, 0, 0);
            this.pnlBottom.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlBottom.Location = new System.Drawing.Point(3, 528);
            this.pnlBottom.Name = "pnlBottom";
            this.pnlBottom.RowCount = 1;
            this.pnlBottom.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.pnlBottom.Size = new System.Drawing.Size(1254, 169);
            this.pnlBottom.TabIndex = 0;
            // 
            // btnBack
            // 
            this.btnBack.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnBack.AutoSize = true;
            this.btnBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.ForeColor = System.Drawing.Color.Red;
            this.btnBack.Location = new System.Drawing.Point(3, 61);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(114, 108);
            this.btnBack.TabIndex = 1;
            this.btnBack.Text = "◄";
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // pnlTop
            // 
            this.pnlTop.ColumnCount = 3;
            this.pnlTop.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.pnlTop.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.pnlTop.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.pnlTop.Controls.Add(this.lblRandomGuest, 0, 1);
            this.pnlTop.Controls.Add(this.lblRandomSchool, 1, 2);
            this.pnlTop.Controls.Add(this.label1, 1, 0);
            this.pnlTop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlTop.Location = new System.Drawing.Point(3, 3);
            this.pnlTop.Name = "pnlTop";
            this.pnlTop.RowCount = 3;
            this.pnlTop.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.pnlTop.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 55F));
            this.pnlTop.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.pnlTop.Size = new System.Drawing.Size(1254, 519);
            this.pnlTop.TabIndex = 1;
            // 
            // lblRandomGuest
            // 
            this.lblRandomGuest.AutoSize = true;
            this.lblRandomGuest.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.pnlTop.SetColumnSpan(this.lblRandomGuest, 3);
            this.lblRandomGuest.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblRandomGuest.Font = new System.Drawing.Font("Herald Typeface", screenHeight*0.1F);
            this.lblRandomGuest.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(42)))), ((int)(((byte)(57)))));
            this.lblRandomGuest.Location = new System.Drawing.Point(3, 103);
            this.lblRandomGuest.Name = "lblRandomGuest";
            this.lblRandomGuest.Size = new System.Drawing.Size(1248, 285);
            this.lblRandomGuest.TabIndex = 0;
            this.lblRandomGuest.Text = "---";
            this.lblRandomGuest.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblRandomSchool
            // 
            this.lblRandomSchool.AutoSize = true;
            this.lblRandomSchool.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(42)))), ((int)(((byte)(57)))));
            this.lblRandomSchool.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblRandomSchool.Font = new System.Drawing.Font("HoloLens MDL2 Assets", screenHeight * 0.05F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblRandomSchool.ForeColor = System.Drawing.Color.White;
            this.lblRandomSchool.Location = new System.Drawing.Point(253, 388);
            this.lblRandomSchool.Name = "lblRandomSchool";
            this.lblRandomSchool.Size = new System.Drawing.Size(746, 131);
            this.lblRandomSchool.TabIndex = 1;
            this.lblRandomSchool.Text = "---";
            this.lblRandomSchool.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Herald Typeface", screenHeight * 0.05F);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(42)))), ((int)(((byte)(57)))));
            this.label1.Location = new System.Drawing.Point(253, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(746, 103);
            this.label1.TabIndex = 2;
            this.label1.Text = "I.T. Week 2019 Raffle";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnRaffleStart
            // 
            this.btnRaffleStart.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(104)))), ((int)(((byte)(103)))));
            this.btnRaffleStart.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnRaffleStart.Font = new System.Drawing.Font("Herald Typeface", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.btnRaffleStart.ForeColor = System.Drawing.Color.White;
            this.btnRaffleStart.HoverColor = System.Drawing.SystemColors.ControlDark;
            this.btnRaffleStart.Location = new System.Drawing.Point(505, 3);
            this.btnRaffleStart.Name = "btnRaffleStart";
            this.btnRaffleStart.Size = new System.Drawing.Size(244, 163);
            this.btnRaffleStart.TabIndex = 0;
            this.btnRaffleStart.TextStartPoint = new System.Drawing.Point(60, 60);
            this.btnRaffleStart.UseVisualStyleBackColor = false;
            this.btnRaffleStart.Click += new System.EventHandler(this.btnRaffleStart_Click);
            // 
            // RaffleGuest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1280, 720);
            this.Controls.Add(this.pnlMain);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "RaffleGuest";
            this.Padding = new System.Windows.Forms.Padding(10);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Tag = "";
            this.Text = "AdDU Raffle";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.RaffleGuest_Load);
            this.pnlMain.ResumeLayout(false);
            this.pnlBottom.ResumeLayout(false);
            this.pnlBottom.PerformLayout();
            this.pnlTop.ResumeLayout(false);
            this.pnlTop.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Timer timeRandom;
        private System.Windows.Forms.ProgressBar pbRandomGuest;
        private System.Windows.Forms.TableLayoutPanel pnlMain;
        private System.Windows.Forms.TableLayoutPanel pnlBottom;
        private System.Windows.Forms.Label btnBack;
        private System.Windows.Forms.TableLayoutPanel pnlTop;
        private System.Windows.Forms.Label lblRandomGuest;
        private System.Windows.Forms.Label lblRandomSchool;
        private System.Windows.Forms.Label label1;
        private RoundButton btnRaffleStart;
    }
}

