namespace CoffeeShop
{
    partial class frmOrdersView
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
            this.gboSorting_OV = new System.Windows.Forms.GroupBox();
            this.btnRefresh_OV = new System.Windows.Forms.Button();
            this.btnSortDate_OV = new System.Windows.Forms.Button();
            this.btnSortPrice_OV = new System.Windows.Forms.Button();
            this.gboOrders_CNO = new System.Windows.Forms.GroupBox();
            this.dgvOrders_OV = new System.Windows.Forms.DataGridView();
            this.gboOrderDetails_OV = new System.Windows.Forms.GroupBox();
            this.lblCustomerEmailInsert = new System.Windows.Forms.Label();
            this.lblCustomerEmail_OV = new System.Windows.Forms.Label();
            this.lblOrderTotal_OV = new System.Windows.Forms.Label();
            this.dgvOrderItems_OV = new System.Windows.Forms.DataGridView();
            this.lblOrderheader = new System.Windows.Forms.Label();
            this.btnBack_OV = new System.Windows.Forms.Button();
            this.gboSorting_OV.SuspendLayout();
            this.gboOrders_CNO.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrders_OV)).BeginInit();
            this.gboOrderDetails_OV.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrderItems_OV)).BeginInit();
            this.SuspendLayout();
            // 
            // gboSorting_OV
            // 
            this.gboSorting_OV.Controls.Add(this.btnRefresh_OV);
            this.gboSorting_OV.Controls.Add(this.btnSortDate_OV);
            this.gboSorting_OV.Controls.Add(this.btnSortPrice_OV);
            this.gboSorting_OV.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gboSorting_OV.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(111)))), ((int)(((byte)(78)))), ((int)(((byte)(55)))));
            this.gboSorting_OV.Location = new System.Drawing.Point(30, 31);
            this.gboSorting_OV.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gboSorting_OV.Name = "gboSorting_OV";
            this.gboSorting_OV.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gboSorting_OV.Size = new System.Drawing.Size(1275, 108);
            this.gboSorting_OV.TabIndex = 0;
            this.gboSorting_OV.TabStop = false;
            this.gboSorting_OV.Text = "SORT OPTIONS";
            // 
            // btnRefresh_OV
            // 
            this.btnRefresh_OV.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(44)))), ((int)(((byte)(42)))));
            this.btnRefresh_OV.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRefresh_OV.ForeColor = System.Drawing.Color.White;
            this.btnRefresh_OV.Location = new System.Drawing.Point(884, 46);
            this.btnRefresh_OV.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnRefresh_OV.Name = "btnRefresh_OV";
            this.btnRefresh_OV.Size = new System.Drawing.Size(246, 46);
            this.btnRefresh_OV.TabIndex = 2;
            this.btnRefresh_OV.Text = "🔄 REFRESH";
            this.btnRefresh_OV.UseVisualStyleBackColor = false;
            this.btnRefresh_OV.Click += new System.EventHandler(this.btnRefresh_OV_Click);
            // 
            // btnSortDate_OV
            // 
            this.btnSortDate_OV.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(44)))), ((int)(((byte)(42)))));
            this.btnSortDate_OV.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSortDate_OV.ForeColor = System.Drawing.Color.White;
            this.btnSortDate_OV.Location = new System.Drawing.Point(528, 46);
            this.btnSortDate_OV.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnSortDate_OV.Name = "btnSortDate_OV";
            this.btnSortDate_OV.Size = new System.Drawing.Size(266, 46);
            this.btnSortDate_OV.TabIndex = 1;
            this.btnSortDate_OV.Text = "📅 SORT BY DATE";
            this.btnSortDate_OV.UseVisualStyleBackColor = false;
            this.btnSortDate_OV.Click += new System.EventHandler(this.btnSortDate_OV_Click);
            // 
            // btnSortPrice_OV
            // 
            this.btnSortPrice_OV.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(44)))), ((int)(((byte)(42)))));
            this.btnSortPrice_OV.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSortPrice_OV.ForeColor = System.Drawing.Color.White;
            this.btnSortPrice_OV.Location = new System.Drawing.Point(196, 46);
            this.btnSortPrice_OV.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnSortPrice_OV.Name = "btnSortPrice_OV";
            this.btnSortPrice_OV.Size = new System.Drawing.Size(246, 46);
            this.btnSortPrice_OV.TabIndex = 0;
            this.btnSortPrice_OV.Text = "💰 SORT BY PRICE";
            this.btnSortPrice_OV.UseVisualStyleBackColor = false;
            this.btnSortPrice_OV.Click += new System.EventHandler(this.btnSortPrice_OV_Click);
            // 
            // gboOrders_CNO
            // 
            this.gboOrders_CNO.Controls.Add(this.dgvOrders_OV);
            this.gboOrders_CNO.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gboOrders_CNO.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(111)))), ((int)(((byte)(78)))), ((int)(((byte)(55)))));
            this.gboOrders_CNO.Location = new System.Drawing.Point(30, 154);
            this.gboOrders_CNO.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gboOrders_CNO.Name = "gboOrders_CNO";
            this.gboOrders_CNO.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gboOrders_CNO.Size = new System.Drawing.Size(1275, 308);
            this.gboOrders_CNO.TabIndex = 3;
            this.gboOrders_CNO.TabStop = false;
            this.gboOrders_CNO.Text = "ALL ORDERS (Click to view)";
            // 
            // dgvOrders_OV
            // 
            this.dgvOrders_OV.AllowUserToAddRows = false;
            this.dgvOrders_OV.AllowUserToDeleteRows = false;
            this.dgvOrders_OV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvOrders_OV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOrders_OV.Location = new System.Drawing.Point(15, 46);
            this.dgvOrders_OV.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dgvOrders_OV.MultiSelect = false;
            this.dgvOrders_OV.Name = "dgvOrders_OV";
            this.dgvOrders_OV.ReadOnly = true;
            this.dgvOrders_OV.RowHeadersVisible = false;
            this.dgvOrders_OV.RowHeadersWidth = 62;
            this.dgvOrders_OV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvOrders_OV.Size = new System.Drawing.Size(1245, 246);
            this.dgvOrders_OV.TabIndex = 0;
            this.dgvOrders_OV.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvOrders_OV_CellClick);
            // 
            // gboOrderDetails_OV
            // 
            this.gboOrderDetails_OV.Controls.Add(this.lblCustomerEmailInsert);
            this.gboOrderDetails_OV.Controls.Add(this.lblCustomerEmail_OV);
            this.gboOrderDetails_OV.Controls.Add(this.lblOrderTotal_OV);
            this.gboOrderDetails_OV.Controls.Add(this.dgvOrderItems_OV);
            this.gboOrderDetails_OV.Controls.Add(this.lblOrderheader);
            this.gboOrderDetails_OV.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gboOrderDetails_OV.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(111)))), ((int)(((byte)(78)))), ((int)(((byte)(55)))));
            this.gboOrderDetails_OV.Location = new System.Drawing.Point(30, 471);
            this.gboOrderDetails_OV.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gboOrderDetails_OV.Name = "gboOrderDetails_OV";
            this.gboOrderDetails_OV.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gboOrderDetails_OV.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.gboOrderDetails_OV.Size = new System.Drawing.Size(1275, 462);
            this.gboOrderDetails_OV.TabIndex = 1;
            this.gboOrderDetails_OV.TabStop = false;
            this.gboOrderDetails_OV.Text = "ORDER DETAILS";
            // 
            // lblCustomerEmailInsert
            // 
            this.lblCustomerEmailInsert.AutoSize = true;
            this.lblCustomerEmailInsert.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(44)))), ((int)(((byte)(42)))));
            this.lblCustomerEmailInsert.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblCustomerEmailInsert.Location = new System.Drawing.Point(124, 346);
            this.lblCustomerEmailInsert.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCustomerEmailInsert.Name = "lblCustomerEmailInsert";
            this.lblCustomerEmailInsert.Size = new System.Drawing.Size(136, 25);
            this.lblCustomerEmailInsert.TabIndex = 4;
            this.lblCustomerEmailInsert.Text = "[Cust. Email]";
            this.lblCustomerEmailInsert.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblCustomerEmail_OV
            // 
            this.lblCustomerEmail_OV.AutoSize = true;
            this.lblCustomerEmail_OV.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(44)))), ((int)(((byte)(42)))));
            this.lblCustomerEmail_OV.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblCustomerEmail_OV.Location = new System.Drawing.Point(30, 346);
            this.lblCustomerEmail_OV.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCustomerEmail_OV.Name = "lblCustomerEmail_OV";
            this.lblCustomerEmail_OV.Size = new System.Drawing.Size(78, 25);
            this.lblCustomerEmail_OV.TabIndex = 3;
            this.lblCustomerEmail_OV.Text = "Email: ";
            this.lblCustomerEmail_OV.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblOrderTotal_OV
            // 
            this.lblOrderTotal_OV.AutoSize = true;
            this.lblOrderTotal_OV.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(92)))), ((int)(((byte)(78)))));
            this.lblOrderTotal_OV.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblOrderTotal_OV.Location = new System.Drawing.Point(750, 338);
            this.lblOrderTotal_OV.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblOrderTotal_OV.Name = "lblOrderTotal_OV";
            this.lblOrderTotal_OV.Size = new System.Drawing.Size(151, 25);
            this.lblOrderTotal_OV.TabIndex = 2;
            this.lblOrderTotal_OV.Text = "TOTAL: $0.00";
            this.lblOrderTotal_OV.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // dgvOrderItems_OV
            // 
            this.dgvOrderItems_OV.AllowUserToAddRows = false;
            this.dgvOrderItems_OV.AllowUserToDeleteRows = false;
            this.dgvOrderItems_OV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvOrderItems_OV.BackgroundColor = System.Drawing.Color.White;
            this.dgvOrderItems_OV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOrderItems_OV.Location = new System.Drawing.Point(30, 85);
            this.dgvOrderItems_OV.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dgvOrderItems_OV.MultiSelect = false;
            this.dgvOrderItems_OV.Name = "dgvOrderItems_OV";
            this.dgvOrderItems_OV.ReadOnly = true;
            this.dgvOrderItems_OV.RowHeadersVisible = false;
            this.dgvOrderItems_OV.RowHeadersWidth = 62;
            this.dgvOrderItems_OV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvOrderItems_OV.Size = new System.Drawing.Size(900, 246);
            this.dgvOrderItems_OV.TabIndex = 1;
            // 
            // lblOrderheader
            // 
            this.lblOrderheader.AutoSize = true;
            this.lblOrderheader.Location = new System.Drawing.Point(30, 38);
            this.lblOrderheader.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblOrderheader.Name = "lblOrderheader";
            this.lblOrderheader.Size = new System.Drawing.Size(301, 25);
            this.lblOrderheader.TabIndex = 0;
            this.lblOrderheader.Text = "Select an order to view details";
            // 
            // btnBack_OV
            // 
            this.btnBack_OV.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(44)))), ((int)(((byte)(42)))));
            this.btnBack_OV.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBack_OV.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack_OV.ForeColor = System.Drawing.Color.White;
            this.btnBack_OV.Location = new System.Drawing.Point(1024, 954);
            this.btnBack_OV.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnBack_OV.Name = "btnBack_OV";
            this.btnBack_OV.Size = new System.Drawing.Size(266, 46);
            this.btnBack_OV.TabIndex = 4;
            this.btnBack_OV.Text = "🔙 BACK TO MENU";
            this.btnBack_OV.UseVisualStyleBackColor = false;
            this.btnBack_OV.Click += new System.EventHandler(this.btnBack_OV_Click);
            // 
            // frmOrdersView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(240)))), ((int)(((byte)(230)))));
            this.ClientSize = new System.Drawing.Size(1347, 1050);
            this.Controls.Add(this.btnBack_OV);
            this.Controls.Add(this.gboOrderDetails_OV);
            this.Controls.Add(this.gboOrders_CNO);
            this.Controls.Add(this.gboSorting_OV);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "frmOrdersView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmOrdersView";
            this.gboSorting_OV.ResumeLayout(false);
            this.gboOrders_CNO.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrders_OV)).EndInit();
            this.gboOrderDetails_OV.ResumeLayout(false);
            this.gboOrderDetails_OV.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrderItems_OV)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gboSorting_OV;
        private System.Windows.Forms.Button btnRefresh_OV;
        private System.Windows.Forms.Button btnSortDate_OV;
        private System.Windows.Forms.Button btnSortPrice_OV;
        private System.Windows.Forms.GroupBox gboOrders_CNO;
        private System.Windows.Forms.DataGridView dgvOrders_OV;
        private System.Windows.Forms.GroupBox gboOrderDetails_OV;
        private System.Windows.Forms.Label lblOrderTotal_OV;
        private System.Windows.Forms.DataGridView dgvOrderItems_OV;
        private System.Windows.Forms.Label lblOrderheader;
        private System.Windows.Forms.Label lblCustomerEmailInsert;
        private System.Windows.Forms.Label lblCustomerEmail_OV;
        private System.Windows.Forms.Button btnBack_OV;
    }
}