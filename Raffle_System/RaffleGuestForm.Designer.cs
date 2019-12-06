namespace Raffle_System
{
    partial class RaffleGuestForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RaffleGuestForm));
            this.timeRandom = new System.Windows.Forms.Timer(this.components);
            this.pbRandomGuest = new System.Windows.Forms.ProgressBar();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.pnlTop = new System.Windows.Forms.TableLayoutPanel();
            this.lblRandomGuest = new System.Windows.Forms.Label();
            this.lblRandomSchool = new System.Windows.Forms.Label();
            this.pnlBottom = new System.Windows.Forms.TableLayoutPanel();
            this.btnRaffleStart = new RoundButton();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.pnlTop.SuspendLayout();
            this.pnlBottom.SuspendLayout();
            this.SuspendLayout();
            // 
            // timeRandom
            // 
            this.timeRandom.Tick += new System.EventHandler(this.timeRandom_Tick);
            // 
            // pbRandomGuest
            // 
            this.pbRandomGuest.Location = new System.Drawing.Point(0, 0);
            this.pbRandomGuest.Name = "pbRandomGuest";
            this.pbRandomGuest.Size = new System.Drawing.Size(100, 23);
            this.pbRandomGuest.TabIndex = 0;
            this.pbRandomGuest.Visible = false;
            // 
            // splitContainer1
            // 
            this.splitContainer1.BackColor = System.Drawing.Color.Transparent;
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.IsSplitterFixed = true;
            this.splitContainer1.Location = new System.Drawing.Point(10, 10);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.pnlTop);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.pnlBottom);
            this.splitContainer1.Size = new System.Drawing.Size(940, 520);
            this.splitContainer1.SplitterDistance = 313;
            this.splitContainer1.TabIndex = 0;
            // 
            // pnlTop
            // 
            this.pnlTop.AutoSize = true;
            this.pnlTop.ColumnCount = 3;
            this.pnlTop.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.pnlTop.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.pnlTop.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.pnlTop.Controls.Add(this.lblRandomGuest, 0, 1);
            this.pnlTop.Controls.Add(this.lblRandomSchool, 1, 2);
            this.pnlTop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlTop.Location = new System.Drawing.Point(0, 0);
            this.pnlTop.Name = "pnlTop";
            this.pnlTop.RowCount = 3;
            this.pnlTop.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.pnlTop.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.pnlTop.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.pnlTop.Size = new System.Drawing.Size(940, 313);
            this.pnlTop.TabIndex = 0;
            // 
            // lblRandomGuest
            // 
            this.lblRandomGuest.AutoSize = true;
            this.pnlTop.SetColumnSpan(this.lblRandomGuest, 3);
            this.lblRandomGuest.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblRandomGuest.Font = new System.Drawing.Font("Herald Typeface", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRandomGuest.Location = new System.Drawing.Point(3, 31);
            this.lblRandomGuest.Name = "lblRandomGuest";
            this.lblRandomGuest.Size = new System.Drawing.Size(934, 219);
            this.lblRandomGuest.TabIndex = 0;
            this.lblRandomGuest.Text = "---";
            this.lblRandomGuest.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblRandomSchool
            // 
            this.lblRandomSchool.AutoSize = true;
            this.lblRandomSchool.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblRandomSchool.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRandomSchool.Location = new System.Drawing.Point(144, 250);
            this.lblRandomSchool.Name = "lblRandomSchool";
            this.lblRandomSchool.Size = new System.Drawing.Size(652, 63);
            this.lblRandomSchool.TabIndex = 1;
            this.lblRandomSchool.Text = "---";
            this.lblRandomSchool.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlBottom
            // 
            this.pnlBottom.AutoSize = true;
            this.pnlBottom.ColumnCount = 3;
            this.pnlBottom.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.pnlBottom.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.pnlBottom.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.pnlBottom.Controls.Add(this.btnRaffleStart, 1, 0);
            this.pnlBottom.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlBottom.Location = new System.Drawing.Point(0, 0);
            this.pnlBottom.Name = "pnlBottom";
            this.pnlBottom.RowCount = 1;
            this.pnlBottom.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.pnlBottom.Size = new System.Drawing.Size(940, 203);
            this.pnlBottom.TabIndex = 0;
            // 
            // btnRaffleStart
            // 
            this.btnRaffleStart.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnRaffleStart.Location = new System.Drawing.Point(379, 3);
            this.btnRaffleStart.Name = "btnRaffleStart";
            this.btnRaffleStart.Size = new System.Drawing.Size(182, 197);
            this.btnRaffleStart.TabIndex = 0;
            this.btnRaffleStart.Text = "GO";
            this.btnRaffleStart.Click += new System.EventHandler(this.btnRaffleStart_Click);
            // 
            // RaffleGuestForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(960, 540);
            this.Controls.Add(this.splitContainer1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "RaffleGuestForm";
            this.Padding = new System.Windows.Forms.Padding(10);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Tag = "";
            this.Text = "Guest Raffle";
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.pnlTop.PerformLayout();


        }

        #endregion
        private System.Windows.Forms.Timer timeRandom;
        private System.Windows.Forms.ProgressBar pbRandomGuest;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.TableLayoutPanel pnlTop;
        private System.Windows.Forms.Label lblRandomGuest;
        private System.Windows.Forms.Label lblRandomSchool;
        private System.Windows.Forms.TableLayoutPanel pnlBottom;
        private RoundButton btnRaffleStart;
    }
}

