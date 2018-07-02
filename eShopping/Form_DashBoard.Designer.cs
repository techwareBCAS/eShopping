namespace eShopping
{
    partial class Form_DashBoard
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
            this.label1 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.sidepanel = new System.Windows.Forms.Panel();
            this.btn_settings = new System.Windows.Forms.Button();
            this.btn_cart = new System.Windows.Forms.Button();
            this.btn_products = new System.Windows.Forms.Button();
            this.btn_market = new System.Windows.Forms.Button();
            this.panel6 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.lbl_exit = new System.Windows.Forms.Label();
            this.panel7 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.userControl_Product1 = new eShopping.UserControl_Product();
            this.userControl_Market1 = new eShopping.UserControl_Market();
            this.panel4.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label1.Location = new System.Drawing.Point(15, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(292, 58);
            this.label1.TabIndex = 0;
            this.label1.Text = "E-Shopping";
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(174)))), ((int)(((byte)(96)))));
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold);
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button2.Location = new System.Drawing.Point(860, 47);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(139, 44);
            this.button2.TabIndex = 74;
            this.button2.Text = "Sign In";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(174)))), ((int)(((byte)(96)))));
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold);
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.Location = new System.Drawing.Point(1006, 47);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(141, 44);
            this.button1.TabIndex = 75;
            this.button1.Text = "Sign Up";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.panel4.Controls.Add(this.sidepanel);
            this.panel4.Controls.Add(this.btn_settings);
            this.panel4.Controls.Add(this.btn_cart);
            this.panel4.Controls.Add(this.btn_products);
            this.panel4.Controls.Add(this.btn_market);
            this.panel4.Controls.Add(this.panel6);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(249, 914);
            this.panel4.TabIndex = 81;
            // 
            // sidepanel
            // 
            this.sidepanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.sidepanel.Location = new System.Drawing.Point(0, 194);
            this.sidepanel.Name = "sidepanel";
            this.sidepanel.Size = new System.Drawing.Size(13, 98);
            this.sidepanel.TabIndex = 2;
            // 
            // btn_settings
            // 
            this.btn_settings.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_settings.FlatAppearance.BorderSize = 0;
            this.btn_settings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_settings.Font = new System.Drawing.Font("Century Gothic", 27.75F);
            this.btn_settings.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btn_settings.Location = new System.Drawing.Point(0, 488);
            this.btn_settings.Name = "btn_settings";
            this.btn_settings.Size = new System.Drawing.Size(249, 98);
            this.btn_settings.TabIndex = 1;
            this.btn_settings.Text = " Setting";
            this.btn_settings.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_settings.UseVisualStyleBackColor = true;
            this.btn_settings.Click += new System.EventHandler(this.btn_settings_Click);
            // 
            // btn_cart
            // 
            this.btn_cart.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_cart.FlatAppearance.BorderSize = 0;
            this.btn_cart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_cart.Font = new System.Drawing.Font("Century Gothic", 27.75F);
            this.btn_cart.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btn_cart.Location = new System.Drawing.Point(0, 390);
            this.btn_cart.Name = "btn_cart";
            this.btn_cart.Size = new System.Drawing.Size(249, 98);
            this.btn_cart.TabIndex = 1;
            this.btn_cart.Text = " Cart";
            this.btn_cart.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_cart.UseVisualStyleBackColor = true;
            this.btn_cart.Click += new System.EventHandler(this.btn_cart_Click);
            // 
            // btn_products
            // 
            this.btn_products.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_products.FlatAppearance.BorderSize = 0;
            this.btn_products.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_products.Font = new System.Drawing.Font("Century Gothic", 27.75F);
            this.btn_products.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btn_products.Location = new System.Drawing.Point(0, 292);
            this.btn_products.Name = "btn_products";
            this.btn_products.Size = new System.Drawing.Size(249, 98);
            this.btn_products.TabIndex = 1;
            this.btn_products.Text = " Products";
            this.btn_products.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_products.UseVisualStyleBackColor = true;
            this.btn_products.Click += new System.EventHandler(this.btn_products_Click);
            // 
            // btn_market
            // 
            this.btn_market.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_market.FlatAppearance.BorderSize = 0;
            this.btn_market.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_market.Font = new System.Drawing.Font("Century Gothic", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_market.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btn_market.Location = new System.Drawing.Point(0, 194);
            this.btn_market.Name = "btn_market";
            this.btn_market.Size = new System.Drawing.Size(249, 98);
            this.btn_market.TabIndex = 1;
            this.btn_market.Text = " Market";
            this.btn_market.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_market.UseVisualStyleBackColor = true;
            this.btn_market.Click += new System.EventHandler(this.btn_Market_Click);
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.panel6.Controls.Add(this.label7);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel6.Location = new System.Drawing.Point(0, 0);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(249, 194);
            this.panel6.TabIndex = 0;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label7.Location = new System.Drawing.Point(54, 68);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(140, 58);
            this.label7.TabIndex = 0;
            this.label7.Text = "Logo";
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.panel5.Controls.Add(this.lbl_exit);
            this.panel5.Controls.Add(this.label1);
            this.panel5.Controls.Add(this.button2);
            this.panel5.Controls.Add(this.button1);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel5.Location = new System.Drawing.Point(249, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(1161, 100);
            this.panel5.TabIndex = 82;
            // 
            // lbl_exit
            // 
            this.lbl_exit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_exit.AutoSize = true;
            this.lbl_exit.Font = new System.Drawing.Font("Century Gothic", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_exit.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lbl_exit.Location = new System.Drawing.Point(1115, 0);
            this.lbl_exit.Name = "lbl_exit";
            this.lbl_exit.Size = new System.Drawing.Size(43, 44);
            this.lbl_exit.TabIndex = 0;
            this.lbl_exit.Text = "X";
            this.lbl_exit.Click += new System.EventHandler(this.lbl_exit_Click);
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.White;
            this.panel7.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel7.Location = new System.Drawing.Point(249, 100);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(1161, 41);
            this.panel7.TabIndex = 83;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.userControl_Product1);
            this.panel1.Controls.Add(this.userControl_Market1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(249, 141);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1161, 773);
            this.panel1.TabIndex = 84;
            // 
            // userControl_Product1
            // 
            this.userControl_Product1.Location = new System.Drawing.Point(3, 3);
            this.userControl_Product1.Name = "userControl_Product1";
            this.userControl_Product1.Size = new System.Drawing.Size(1147, 764);
            this.userControl_Product1.TabIndex = 1;
            this.userControl_Product1.Visible = false;
            // 
            // userControl_Market1
            // 
            this.userControl_Market1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.userControl_Market1.Location = new System.Drawing.Point(3, 3);
            this.userControl_Market1.Name = "userControl_Market1";
            this.userControl_Market1.Size = new System.Drawing.Size(1151, 767);
            this.userControl_Market1.TabIndex = 0;
            this.userControl_Market1.Visible = false;
            // 
            // Form_DashBoard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.ClientSize = new System.Drawing.Size(1410, 914);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel7);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel4);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form_DashBoard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form_DashBoard";
            this.panel4.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label lbl_exit;
        private System.Windows.Forms.Button btn_settings;
        private System.Windows.Forms.Button btn_cart;
        private System.Windows.Forms.Button btn_products;
        private System.Windows.Forms.Button btn_market;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel sidepanel;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Panel panel1;
        private UserControl_Product userControl_Product1;
        private UserControl_Market userControl_Market1;
    }
}