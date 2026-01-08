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
            this.btn_restore = new System.Windows.Forms.Button();
            this.btn_minimize = new System.Windows.Forms.Button();
            this.btn_close = new System.Windows.Forms.Button();
            this.pnl_information = new System.Windows.Forms.Panel();
            this.pbx_logo = new System.Windows.Forms.PictureBox();
            this.tt = new System.Windows.Forms.ToolTip(this.components);
            this.pbx_information = new System.Windows.Forms.PictureBox();
            this.pbx_link = new System.Windows.Forms.PictureBox();
            this.pnl_window_control_button.SuspendLayout();
            this.pnl_information.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbx_logo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbx_information)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbx_link)).BeginInit();
            this.SuspendLayout();
            // 
            // pnl_window_control_button
            // 
            this.pnl_window_control_button.BackColor = System.Drawing.Color.Silver;
            this.pnl_window_control_button.Controls.Add(this.btn_restore);
            this.pnl_window_control_button.Controls.Add(this.btn_minimize);
            this.pnl_window_control_button.Controls.Add(this.btn_close);
            this.pnl_window_control_button.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_window_control_button.Location = new System.Drawing.Point(0, 0);
            this.pnl_window_control_button.Name = "pnl_window_control_button";
            this.pnl_window_control_button.Size = new System.Drawing.Size(1046, 30);
            this.pnl_window_control_button.TabIndex = 0;
            this.pnl_window_control_button.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnl_window_control_button_MouseDown);
            // 
            // btn_restore
            // 
            this.btn_restore.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_restore.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_restore.BackColor = System.Drawing.Color.Gray;
            this.btn_restore.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_restore.BackgroundImage")));
            this.btn_restore.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_restore.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_restore.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btn_restore.FlatAppearance.BorderSize = 0;
            this.btn_restore.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btn_restore.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btn_restore.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_restore.Location = new System.Drawing.Point(986, 0);
            this.btn_restore.Name = "btn_restore";
            this.btn_restore.Size = new System.Drawing.Size(30, 30);
            this.btn_restore.TabIndex = 4;
            this.btn_restore.UseVisualStyleBackColor = false;
            this.btn_restore.Click += new System.EventHandler(this.btn_restore_Click);
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
            this.btn_minimize.Location = new System.Drawing.Point(956, 0);
            this.btn_minimize.Name = "btn_minimize";
            this.btn_minimize.Size = new System.Drawing.Size(30, 30);
            this.btn_minimize.TabIndex = 3;
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
            this.btn_close.Location = new System.Drawing.Point(1016, 0);
            this.btn_close.Name = "btn_close";
            this.btn_close.Size = new System.Drawing.Size(30, 30);
            this.btn_close.TabIndex = 2;
            this.btn_close.UseVisualStyleBackColor = false;
            this.btn_close.Click += new System.EventHandler(this.btn_close_Click);
            // 
            // pnl_information
            // 
            this.pnl_information.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(35)))), ((int)(((byte)(64)))));
            this.pnl_information.Controls.Add(this.pbx_link);
            this.pnl_information.Controls.Add(this.pbx_information);
            this.pnl_information.Controls.Add(this.pbx_logo);
            this.pnl_information.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnl_information.Location = new System.Drawing.Point(0, 30);
            this.pnl_information.Name = "pnl_information";
            this.pnl_information.Size = new System.Drawing.Size(320, 689);
            this.pnl_information.TabIndex = 1;
            // 
            // pbx_logo
            // 
            this.pbx_logo.Image = ((System.Drawing.Image)(resources.GetObject("pbx_logo.Image")));
            this.pbx_logo.Location = new System.Drawing.Point(35, 35);
            this.pbx_logo.Name = "pbx_logo";
            this.pbx_logo.Size = new System.Drawing.Size(250, 250);
            this.pbx_logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbx_logo.TabIndex = 0;
            this.pbx_logo.TabStop = false;
            // 
            // pbx_information
            // 
            this.pbx_information.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.pbx_information.Image = ((System.Drawing.Image)(resources.GetObject("pbx_information.Image")));
            this.pbx_information.Location = new System.Drawing.Point(59, 635);
            this.pbx_information.Name = "pbx_information";
            this.pbx_information.Size = new System.Drawing.Size(40, 40);
            this.pbx_information.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbx_information.TabIndex = 1;
            this.pbx_information.TabStop = false;
            // 
            // pbx_link
            // 
            this.pbx_link.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.pbx_link.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbx_link.Image = ((System.Drawing.Image)(resources.GetObject("pbx_link.Image")));
            this.pbx_link.Location = new System.Drawing.Point(3, 631);
            this.pbx_link.Name = "pbx_link";
            this.pbx_link.Size = new System.Drawing.Size(50, 50);
            this.pbx_link.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbx_link.TabIndex = 2;
            this.pbx_link.TabStop = false;
            this.pbx_link.Click += new System.EventHandler(this.pbx_link_Click);
            // 
            // form_login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(97)))), ((int)(((byte)(146)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1046, 719);
            this.Controls.Add(this.pnl_information);
            this.Controls.Add(this.pnl_window_control_button);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "form_login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login to Eduware";
            this.pnl_window_control_button.ResumeLayout(false);
            this.pnl_information.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbx_logo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbx_information)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbx_link)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnl_window_control_button;
        private System.Windows.Forms.Panel pnl_information;
        private System.Windows.Forms.Button btn_close;
        private System.Windows.Forms.Button btn_restore;
        private System.Windows.Forms.Button btn_minimize;
        private System.Windows.Forms.PictureBox pbx_logo;
        private System.Windows.Forms.ToolTip tt;
        private System.Windows.Forms.PictureBox pbx_information;
        private System.Windows.Forms.PictureBox pbx_link;
    }
}

