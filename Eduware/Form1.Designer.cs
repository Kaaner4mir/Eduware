namespace Eduware
{
    partial class form_login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(form_login));
            this.pnl_window_control_button = new System.Windows.Forms.Panel();
            this.btn_minimize = new System.Windows.Forms.Button();
            this.btn_close = new System.Windows.Forms.Button();
            this.tt = new System.Windows.Forms.ToolTip(this.components);
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.pbx_information = new System.Windows.Forms.PictureBox();
            this.pbx_link = new System.Windows.Forms.PictureBox();
            this.tbx_usernumber = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.tbx_password = new System.Windows.Forms.TextBox();
            this.pbx_logo = new System.Windows.Forms.PictureBox();
            this.lbl_usernumber = new System.Windows.Forms.Label();
            this.lbl_password = new System.Windows.Forms.Label();
            this.btn_login = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.pnl_window_control_button.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbx_information)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbx_link)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbx_logo)).BeginInit();
            this.SuspendLayout();
            // 
            // pnl_window_control_button
            // 
            this.pnl_window_control_button.BackColor = System.Drawing.Color.Silver;
            this.pnl_window_control_button.Controls.Add(this.btn_minimize);
            this.pnl_window_control_button.Controls.Add(this.btn_close);
            this.pnl_window_control_button.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_window_control_button.Location = new System.Drawing.Point(0, 0);
            this.pnl_window_control_button.Name = "pnl_window_control_button";
            this.pnl_window_control_button.Size = new System.Drawing.Size(585, 30);
            this.pnl_window_control_button.TabIndex = 0;
            this.pnl_window_control_button.TabStop = true;
            this.pnl_window_control_button.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnl_window_control_button_MouseDown);
            // 
            // btn_minimize
            // 
            this.btn_minimize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_minimize.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_minimize.BackColor = System.Drawing.Color.Gray;
            this.btn_minimize.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_minimize.BackgroundImage")));
            this.btn_minimize.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_minimize.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_minimize.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btn_minimize.FlatAppearance.BorderSize = 0;
            this.btn_minimize.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btn_minimize.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btn_minimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_minimize.Location = new System.Drawing.Point(525, 0);
            this.btn_minimize.Name = "btn_minimize";
            this.btn_minimize.Size = new System.Drawing.Size(30, 30);
            this.btn_minimize.TabIndex = 3;
            this.btn_minimize.TabStop = false;
            this.btn_minimize.UseVisualStyleBackColor = false;
            this.btn_minimize.Click += new System.EventHandler(this.btn_minimize_Click);
            // 
            // btn_close
            // 
            this.btn_close.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_close.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_close.BackColor = System.Drawing.Color.Gray;
            this.btn_close.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_close.BackgroundImage")));
            this.btn_close.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_close.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_close.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btn_close.FlatAppearance.BorderSize = 0;
            this.btn_close.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red;
            this.btn_close.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.btn_close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_close.Location = new System.Drawing.Point(555, 0);
            this.btn_close.Name = "btn_close";
            this.btn_close.Size = new System.Drawing.Size(30, 30);
            this.btn_close.TabIndex = 2;
            this.btn_close.TabStop = false;
            this.btn_close.UseVisualStyleBackColor = false;
            this.btn_close.Click += new System.EventHandler(this.btn_close_Click);
            // 
            // pbx_information
            // 
            this.pbx_information.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.pbx_information.BackColor = System.Drawing.Color.Transparent;
            this.pbx_information.Image = ((System.Drawing.Image)(resources.GetObject("pbx_information.Image")));
            this.pbx_information.Location = new System.Drawing.Point(479, 689);
            this.pbx_information.Name = "pbx_information";
            this.pbx_information.Size = new System.Drawing.Size(40, 40);
            this.pbx_information.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbx_information.TabIndex = 1;
            this.pbx_information.TabStop = false;
            // 
            // pbx_link
            // 
            this.pbx_link.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.pbx_link.BackColor = System.Drawing.Color.Transparent;
            this.pbx_link.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbx_link.Image = ((System.Drawing.Image)(resources.GetObject("pbx_link.Image")));
            this.pbx_link.Location = new System.Drawing.Point(525, 684);
            this.pbx_link.Name = "pbx_link";
            this.pbx_link.Size = new System.Drawing.Size(50, 50);
            this.pbx_link.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbx_link.TabIndex = 2;
            this.pbx_link.TabStop = false;
            this.pbx_link.Click += new System.EventHandler(this.pbx_link_Click);
            // 
            // tbx_usernumber
            // 
            this.tbx_usernumber.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.tbx_usernumber.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbx_usernumber.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tbx_usernumber.Location = new System.Drawing.Point(39, 4);
            this.tbx_usernumber.MaxLength = 10;
            this.tbx_usernumber.Name = "tbx_usernumber";
            this.tbx_usernumber.Size = new System.Drawing.Size(228, 26);
            this.tbx_usernumber.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.tbx_usernumber);
            this.panel1.Location = new System.Drawing.Point(163, 483);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(271, 33);
            this.panel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(4, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(30, 30);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.pictureBox2);
            this.panel2.Controls.Add(this.tbx_password);
            this.panel2.Location = new System.Drawing.Point(163, 567);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(271, 33);
            this.panel2.TabIndex = 1;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox2.BackgroundImage")));
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(4, 2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(30, 30);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 4;
            this.pictureBox2.TabStop = false;
            // 
            // tbx_password
            // 
            this.tbx_password.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.tbx_password.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbx_password.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tbx_password.Location = new System.Drawing.Point(39, 4);
            this.tbx_password.MaxLength = 10;
            this.tbx_password.Name = "tbx_password";
            this.tbx_password.Size = new System.Drawing.Size(228, 26);
            this.tbx_password.TabIndex = 0;
            this.tbx_password.UseSystemPasswordChar = true;
            // 
            // pbx_logo
            // 
            this.pbx_logo.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pbx_logo.BackColor = System.Drawing.Color.Transparent;
            this.pbx_logo.Image = ((System.Drawing.Image)(resources.GetObject("pbx_logo.Image")));
            this.pbx_logo.Location = new System.Drawing.Point(117, 65);
            this.pbx_logo.Name = "pbx_logo";
            this.pbx_logo.Size = new System.Drawing.Size(350, 350);
            this.pbx_logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbx_logo.TabIndex = 7;
            this.pbx_logo.TabStop = false;
            // 
            // lbl_usernumber
            // 
            this.lbl_usernumber.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbl_usernumber.AutoSize = true;
            this.lbl_usernumber.Font = new System.Drawing.Font("Leelawadee", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_usernumber.Location = new System.Drawing.Point(163, 451);
            this.lbl_usernumber.Name = "lbl_usernumber";
            this.lbl_usernumber.Size = new System.Drawing.Size(121, 23);
            this.lbl_usernumber.TabIndex = 8;
            this.lbl_usernumber.Text = "Usernumber";
            // 
            // lbl_password
            // 
            this.lbl_password.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbl_password.AutoSize = true;
            this.lbl_password.Font = new System.Drawing.Font("Leelawadee", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_password.Location = new System.Drawing.Point(163, 537);
            this.lbl_password.Name = "lbl_password";
            this.lbl_password.Size = new System.Drawing.Size(95, 23);
            this.lbl_password.TabIndex = 9;
            this.lbl_password.Text = "Password";
            // 
            // btn_login
            // 
            this.btn_login.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btn_login.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(35)))), ((int)(((byte)(64)))));
            this.btn_login.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_login.FlatAppearance.BorderSize = 0;
            this.btn_login.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(97)))), ((int)(((byte)(146)))));
            this.btn_login.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(35)))), ((int)(((byte)(64)))));
            this.btn_login.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_login.Font = new System.Drawing.Font("Leelawadee UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_login.ForeColor = System.Drawing.Color.White;
            this.btn_login.Location = new System.Drawing.Point(161, 634);
            this.btn_login.Name = "btn_login";
            this.btn_login.Size = new System.Drawing.Size(109, 39);
            this.btn_login.TabIndex = 2;
            this.btn_login.Text = "Log in";
            this.btn_login.UseVisualStyleBackColor = false;
            this.btn_login.Click += new System.EventHandler(this.btn_login_Click);
            // 
            // button1
            // 
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(97)))), ((int)(((byte)(146)))));
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(35)))), ((int)(((byte)(64)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Leelawadee UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(297, 634);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(137, 39);
            this.button1.TabIndex = 3;
            this.button1.Text = "Forgot password";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // form_login
            // 
            this.AcceptButton = this.btn_login;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(97)))), ((int)(((byte)(146)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(585, 746);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btn_login);
            this.Controls.Add(this.lbl_password);
            this.Controls.Add(this.lbl_usernumber);
            this.Controls.Add(this.pbx_logo);
            this.Controls.Add(this.pbx_link);
            this.Controls.Add(this.pbx_information);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pnl_window_control_button);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "form_login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login to Eduware";
            this.Load += new System.EventHandler(this.form_login_Load);
            this.pnl_window_control_button.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbx_information)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbx_link)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbx_logo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnl_window_control_button;
        private System.Windows.Forms.Button btn_close;
        private System.Windows.Forms.Button btn_minimize;
        private System.Windows.Forms.ToolTip tt;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.PictureBox pbx_information;
        private System.Windows.Forms.PictureBox pbx_link;
        private System.Windows.Forms.TextBox tbx_usernumber;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.TextBox tbx_password;
        private System.Windows.Forms.PictureBox pbx_logo;
        private System.Windows.Forms.Label lbl_usernumber;
        private System.Windows.Forms.Label lbl_password;
        private System.Windows.Forms.Button btn_login;
        private System.Windows.Forms.Button button1;
    }
}

