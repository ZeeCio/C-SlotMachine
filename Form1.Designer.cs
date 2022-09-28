namespace Assessment1Exercise2SlotMachineWF
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
            this.components = new System.ComponentModel.Container();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.lbl_casino = new System.Windows.Forms.Label();
            this.lbl_balance = new System.Windows.Forms.Label();
            this.lbl_win = new System.Windows.Forms.Label();
            this.lbl_loss = new System.Windows.Forms.Label();
            this.lbl_bid = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btn_spin = new System.Windows.Forms.Button();
            this.btn_bid = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Assessment1Exercise2SlotMachineWF.Properties.Resources.zero;
            this.pictureBox1.Location = new System.Drawing.Point(35, 81);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(164, 143);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Assessment1Exercise2SlotMachineWF.Properties.Resources.zero;
            this.pictureBox2.Location = new System.Drawing.Point(220, 81);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(155, 143);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::Assessment1Exercise2SlotMachineWF.Properties.Resources.zero;
            this.pictureBox3.Location = new System.Drawing.Point(399, 81);
            this.pictureBox3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(168, 143);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 2;
            this.pictureBox3.TabStop = false;
            // 
            // lbl_casino
            // 
            this.lbl_casino.AutoSize = true;
            this.lbl_casino.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_casino.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.lbl_casino.Location = new System.Drawing.Point(45, 11);
            this.lbl_casino.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_casino.Name = "lbl_casino";
            this.lbl_casino.Size = new System.Drawing.Size(94, 29);
            this.lbl_casino.TabIndex = 3;
            this.lbl_casino.Text = "Casino";
            // 
            // lbl_balance
            // 
            this.lbl_balance.AutoSize = true;
            this.lbl_balance.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_balance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.lbl_balance.Location = new System.Drawing.Point(342, 11);
            this.lbl_balance.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_balance.Name = "lbl_balance";
            this.lbl_balance.Size = new System.Drawing.Size(170, 29);
            this.lbl_balance.TabIndex = 4;
            this.lbl_balance.Text = "Balance:£100";
            this.lbl_balance.Click += new System.EventHandler(this.label2_Click);
            // 
            // lbl_win
            // 
            this.lbl_win.AutoSize = true;
            this.lbl_win.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_win.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.lbl_win.Location = new System.Drawing.Point(45, 277);
            this.lbl_win.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_win.Name = "lbl_win";
            this.lbl_win.Size = new System.Drawing.Size(78, 29);
            this.lbl_win.TabIndex = 5;
            this.lbl_win.Text = "Win:0";
            // 
            // lbl_loss
            // 
            this.lbl_loss.AutoSize = true;
            this.lbl_loss.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_loss.ForeColor = System.Drawing.Color.Red;
            this.lbl_loss.Location = new System.Drawing.Point(45, 327);
            this.lbl_loss.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_loss.Name = "lbl_loss";
            this.lbl_loss.Size = new System.Drawing.Size(75, 29);
            this.lbl_loss.TabIndex = 6;
            this.lbl_loss.Text = "Loss:";
            // 
            // lbl_bid
            // 
            this.lbl_bid.AutoSize = true;
            this.lbl_bid.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_bid.ForeColor = System.Drawing.Color.White;
            this.lbl_bid.Location = new System.Drawing.Point(277, 326);
            this.lbl_bid.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_bid.Name = "lbl_bid";
            this.lbl_bid.Size = new System.Drawing.Size(59, 29);
            this.lbl_bid.TabIndex = 7;
            this.lbl_bid.Text = "Bid:";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(347, 322);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(159, 34);
            this.textBox1.TabIndex = 8;
            // 
            // btn_spin
            // 
            this.btn_spin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btn_spin.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_spin.Location = new System.Drawing.Point(68, 396);
            this.btn_spin.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_spin.Name = "btn_spin";
            this.btn_spin.Size = new System.Drawing.Size(192, 76);
            this.btn_spin.TabIndex = 9;
            this.btn_spin.Text = "SPIN";
            this.btn_spin.UseVisualStyleBackColor = false;
            this.btn_spin.Click += new System.EventHandler(this.btn_spin_Click);
            // 
            // btn_bid
            // 
            this.btn_bid.BackColor = System.Drawing.Color.Yellow;
            this.btn_bid.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_bid.Location = new System.Drawing.Point(309, 396);
            this.btn_bid.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_bid.Name = "btn_bid";
            this.btn_bid.Size = new System.Drawing.Size(197, 76);
            this.btn_bid.TabIndex = 10;
            this.btn_bid.Text = "Add Balance";
            this.btn_bid.UseVisualStyleBackColor = false;
            this.btn_bid.Click += new System.EventHandler(this.btn_bid_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(600, 500);
            this.Controls.Add(this.btn_bid);
            this.Controls.Add(this.btn_spin);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lbl_bid);
            this.Controls.Add(this.lbl_loss);
            this.Controls.Add(this.lbl_win);
            this.Controls.Add(this.lbl_balance);
            this.Controls.Add(this.lbl_casino);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label lbl_casino;
        private System.Windows.Forms.Label lbl_balance;
        private System.Windows.Forms.Label lbl_win;
        private System.Windows.Forms.Label lbl_loss;
        private System.Windows.Forms.Label lbl_bid;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btn_spin;
        private System.Windows.Forms.Button btn_bid;
        private System.Windows.Forms.Timer timer1;
    }
}

