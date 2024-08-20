namespace VirtualBankWinForms
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lbl_welcome = new Label();
            lbl_account = new Label();
            lbl_balance = new Label();
            groupBox1 = new GroupBox();
            txt_amount = new TextBox();
            lbl_amount = new Label();
            btn_deposit = new Button();
            btn_withdraw = new Button();
            pictureBox1 = new PictureBox();
            comboBox1 = new ComboBox();
            comboBox2 = new ComboBox();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // lbl_welcome
            // 
            lbl_welcome.AutoSize = true;
            lbl_welcome.Font = new Font("Tw Cen MT", 13.875F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_welcome.Location = new Point(137, 198);
            lbl_welcome.Name = "lbl_welcome";
            lbl_welcome.Size = new Size(160, 43);
            lbl_welcome.TabIndex = 0;
            lbl_welcome.Text = "Welcome";
            lbl_welcome.TextAlign = ContentAlignment.TopCenter;
            lbl_welcome.UseWaitCursor = true;
            lbl_welcome.Click += label1_Click;
            // 
            // lbl_account
            // 
            lbl_account.AutoSize = true;
            lbl_account.Font = new Font("Tw Cen MT", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_account.Location = new Point(514, 198);
            lbl_account.Name = "lbl_account";
            lbl_account.Size = new Size(138, 37);
            lbl_account.TabIndex = 1;
            lbl_account.Text = "Account : ";
            lbl_account.Click += label1_Click_1;
            // 
            // lbl_balance
            // 
            lbl_balance.AutoSize = true;
            lbl_balance.Font = new Font("Tw Cen MT", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_balance.Location = new Point(514, 281);
            lbl_balance.Name = "lbl_balance";
            lbl_balance.Size = new Size(134, 37);
            lbl_balance.TabIndex = 2;
            lbl_balance.Text = "Balance :";
            lbl_balance.Click += label1_Click_2;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = SystemColors.ControlDark;
            groupBox1.Controls.Add(comboBox2);
            groupBox1.Controls.Add(txt_amount);
            groupBox1.Controls.Add(lbl_amount);
            groupBox1.Controls.Add(btn_deposit);
            groupBox1.Controls.Add(btn_withdraw);
            groupBox1.Font = new Font("Tw Cen MT", 10.125F, FontStyle.Regular, GraphicsUnit.Point, 0);
            groupBox1.ForeColor = SystemColors.ActiveCaptionText;
            groupBox1.Location = new Point(137, 362);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(766, 257);
            groupBox1.TabIndex = 3;
            groupBox1.TabStop = false;
            groupBox1.Text = "Transaction";
            // 
            // txt_amount
            // 
            txt_amount.Location = new Point(230, 65);
            txt_amount.Name = "txt_amount";
            txt_amount.Size = new Size(228, 37);
            txt_amount.TabIndex = 3;
            // 
            // lbl_amount
            // 
            lbl_amount.AutoSize = true;
            lbl_amount.Font = new Font("Tw Cen MT", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_amount.ForeColor = SystemColors.Desktop;
            lbl_amount.Location = new Point(86, 68);
            lbl_amount.Name = "lbl_amount";
            lbl_amount.Size = new Size(124, 42);
            lbl_amount.TabIndex = 2;
            lbl_amount.Text = "Amount :";
            lbl_amount.UseCompatibleTextRendering = true;
            // 
            // btn_deposit
            // 
            btn_deposit.Font = new Font("Tw Cen MT", 10.875F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_deposit.Location = new Point(461, 151);
            btn_deposit.Name = "btn_deposit";
            btn_deposit.RightToLeft = RightToLeft.No;
            btn_deposit.Size = new Size(226, 46);
            btn_deposit.TabIndex = 1;
            btn_deposit.Text = "DEPOSIT";
            btn_deposit.UseVisualStyleBackColor = true;
            // 
            // btn_withdraw
            // 
            btn_withdraw.Font = new Font("Tw Cen MT", 10.875F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_withdraw.Location = new Point(86, 151);
            btn_withdraw.Name = "btn_withdraw";
            btn_withdraw.Size = new Size(217, 46);
            btn_withdraw.TabIndex = 0;
            btn_withdraw.Text = "WITHDRAW";
            btn_withdraw.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            pictureBox1.InitialImage = Properties.Resources.datacan;
            pictureBox1.Location = new Point(50, 62);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(200, 100);
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(689, 198);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(242, 40);
            comboBox1.TabIndex = 5;
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(552, 64);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(135, 39);
            comboBox2.TabIndex = 5;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLight;
            ClientSize = new Size(1076, 714);
            Controls.Add(comboBox1);
            Controls.Add(pictureBox1);
            Controls.Add(groupBox1);
            Controls.Add(lbl_balance);
            Controls.Add(lbl_account);
            Controls.Add(lbl_welcome);
            Name = "Form1";
            Text = "DataCan Virtual Bank";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbl_welcome;
        private Label lbl_account;
        private Label lbl_balance;
        private GroupBox groupBox1;
        private TextBox txt_amount;
        private Label lbl_amount;
        private Button btn_deposit;
        private Button btn_withdraw;
        private PictureBox pictureBox1;
        private ComboBox comboBox2;
        private ComboBox comboBox1;
    }
}
