namespace CoffeeShop
{
    partial class frmMain
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
            this.lblNavTitle = new System.Windows.Forms.Label();
            this.gboNavOptions = new System.Windows.Forms.GroupBox();
            this.btnExitMain = new System.Windows.Forms.Button();
            this.btnViewOrders = new System.Windows.Forms.Button();
            this.btnCreateOrder = new System.Windows.Forms.Button();
            this.btnAddItem = new System.Windows.Forms.Button();
            this.btnViewMenu = new System.Windows.Forms.Button();
            this.gboNavOptions.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblNavTitle
            // 
            this.lblNavTitle.AutoSize = true;
            this.lblNavTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblNavTitle.Font = new System.Drawing.Font("January Night", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNavTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(111)))), ((int)(((byte)(78)))), ((int)(((byte)(55)))));
            this.lblNavTitle.Location = new System.Drawing.Point(21, 18);
            this.lblNavTitle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNavTitle.Name = "lblNavTitle";
            this.lblNavTitle.Size = new System.Drawing.Size(408, 29);
            this.lblNavTitle.TabIndex = 0;
            this.lblNavTitle.Text = "🥐 Coffee Shop Management System ☕︎";
            // 
            // gboNavOptions
            // 
            this.gboNavOptions.BackColor = System.Drawing.Color.Transparent;
            this.gboNavOptions.Controls.Add(this.btnExitMain);
            this.gboNavOptions.Controls.Add(this.btnViewOrders);
            this.gboNavOptions.Controls.Add(this.btnCreateOrder);
            this.gboNavOptions.Controls.Add(this.btnAddItem);
            this.gboNavOptions.Controls.Add(this.btnViewMenu);
            this.gboNavOptions.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gboNavOptions.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(111)))), ((int)(((byte)(78)))), ((int)(((byte)(55)))));
            this.gboNavOptions.Location = new System.Drawing.Point(114, 73);
            this.gboNavOptions.Margin = new System.Windows.Forms.Padding(2);
            this.gboNavOptions.Name = "gboNavOptions";
            this.gboNavOptions.Padding = new System.Windows.Forms.Padding(2);
            this.gboNavOptions.Size = new System.Drawing.Size(200, 285);
            this.gboNavOptions.TabIndex = 6;
            this.gboNavOptions.TabStop = false;
            this.gboNavOptions.Text = "MENU OPTIONS";
            // 
            // btnExitMain
            // 
            this.btnExitMain.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(77)))), ((int)(((byte)(77)))));
            this.btnExitMain.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExitMain.Font = new System.Drawing.Font("Microsoft Tai Le", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExitMain.ForeColor = System.Drawing.Color.White;
            this.btnExitMain.Location = new System.Drawing.Point(13, 226);
            this.btnExitMain.Margin = new System.Windows.Forms.Padding(2);
            this.btnExitMain.Name = "btnExitMain";
            this.btnExitMain.Size = new System.Drawing.Size(167, 32);
            this.btnExitMain.TabIndex = 10;
            this.btnExitMain.Text = "🚪 EXIT";
            this.btnExitMain.UseVisualStyleBackColor = false;
            this.btnExitMain.Click += new System.EventHandler(this.btnExitMain_Click);
            // 
            // btnViewOrders
            // 
            this.btnViewOrders.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(44)))), ((int)(((byte)(42)))));
            this.btnViewOrders.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnViewOrders.Font = new System.Drawing.Font("Microsoft Tai Le", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnViewOrders.ForeColor = System.Drawing.Color.White;
            this.btnViewOrders.Location = new System.Drawing.Point(13, 177);
            this.btnViewOrders.Margin = new System.Windows.Forms.Padding(2);
            this.btnViewOrders.Name = "btnViewOrders";
            this.btnViewOrders.Size = new System.Drawing.Size(167, 32);
            this.btnViewOrders.TabIndex = 9;
            this.btnViewOrders.Text = "📋 VIEW ORDERS";
            this.btnViewOrders.UseVisualStyleBackColor = false;
            this.btnViewOrders.Click += new System.EventHandler(this.btnViewOrders_Click);
            // 
            // btnCreateOrder
            // 
            this.btnCreateOrder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(44)))), ((int)(((byte)(42)))));
            this.btnCreateOrder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCreateOrder.Font = new System.Drawing.Font("Microsoft Tai Le", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreateOrder.ForeColor = System.Drawing.Color.White;
            this.btnCreateOrder.Location = new System.Drawing.Point(13, 130);
            this.btnCreateOrder.Margin = new System.Windows.Forms.Padding(2);
            this.btnCreateOrder.Name = "btnCreateOrder";
            this.btnCreateOrder.Size = new System.Drawing.Size(167, 32);
            this.btnCreateOrder.TabIndex = 8;
            this.btnCreateOrder.Text = "📝 CREATE ORDER";
            this.btnCreateOrder.UseVisualStyleBackColor = false;
            this.btnCreateOrder.Click += new System.EventHandler(this.btnCreateOrder_Click);
            // 
            // btnAddItem
            // 
            this.btnAddItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(44)))), ((int)(((byte)(42)))));
            this.btnAddItem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddItem.Font = new System.Drawing.Font("Microsoft Tai Le", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddItem.ForeColor = System.Drawing.Color.White;
            this.btnAddItem.Location = new System.Drawing.Point(13, 84);
            this.btnAddItem.Margin = new System.Windows.Forms.Padding(2);
            this.btnAddItem.Name = "btnAddItem";
            this.btnAddItem.Size = new System.Drawing.Size(167, 32);
            this.btnAddItem.TabIndex = 7;
            this.btnAddItem.Text = "➕ ADD ITEM";
            this.btnAddItem.UseVisualStyleBackColor = false;
            this.btnAddItem.Click += new System.EventHandler(this.btnAddItem_Click);
            // 
            // btnViewMenu
            // 
            this.btnViewMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(44)))), ((int)(((byte)(42)))));
            this.btnViewMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnViewMenu.Font = new System.Drawing.Font("Microsoft Tai Le", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnViewMenu.ForeColor = System.Drawing.Color.White;
            this.btnViewMenu.Location = new System.Drawing.Point(13, 36);
            this.btnViewMenu.Margin = new System.Windows.Forms.Padding(2);
            this.btnViewMenu.Name = "btnViewMenu";
            this.btnViewMenu.Size = new System.Drawing.Size(167, 32);
            this.btnViewMenu.TabIndex = 6;
            this.btnViewMenu.Text = "🔍 VIEW MENU";
            this.btnViewMenu.UseVisualStyleBackColor = false;
            this.btnViewMenu.Click += new System.EventHandler(this.btnViewMenu_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(447, 376);
            this.Controls.Add(this.gboNavOptions);
            this.Controls.Add(this.lblNavTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmMain";
            this.Text = "Coffee Menu";
            this.gboNavOptions.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNavTitle;
        private System.Windows.Forms.GroupBox gboNavOptions;
        private System.Windows.Forms.Button btnExitMain;
        private System.Windows.Forms.Button btnViewOrders;
        private System.Windows.Forms.Button btnCreateOrder;
        private System.Windows.Forms.Button btnAddItem;
        private System.Windows.Forms.Button btnViewMenu;
    }
}

