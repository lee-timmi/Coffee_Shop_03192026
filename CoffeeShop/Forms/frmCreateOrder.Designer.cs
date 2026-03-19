namespace CoffeeShop
{
    partial class frmCreateOrder
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
            this.gboCustomer_CNO = new System.Windows.Forms.GroupBox();
            this.lblCustomerEmail_CNO = new System.Windows.Forms.Label();
            this.lblCustomerName_CNO = new System.Windows.Forms.Label();
            this.tboCustomerEmail_CNO = new System.Windows.Forms.TextBox();
            this.tboCustomerName_CNO = new System.Windows.Forms.TextBox();
            this.gboSummary_CNO = new System.Windows.Forms.GroupBox();
            this.lblTotal_CNO = new System.Windows.Forms.Label();
            this.lblTax_CNO = new System.Windows.Forms.Label();
            this.lblSubtotal_CNO = new System.Windows.Forms.Label();
            this.lboOrderItems_CNO = new System.Windows.Forms.ListBox();
            this.gboAddItems_CNO = new System.Windows.Forms.GroupBox();
            this.btnRemoveItem_CNO = new System.Windows.Forms.Button();
            this.btnAddToOrder_CNO = new System.Windows.Forms.Button();
            this.lblItemPrice_CNO = new System.Windows.Forms.Label();
            this.lblQuantity_CNO = new System.Windows.Forms.Label();
            this.nudQuantity_CNO = new System.Windows.Forms.NumericUpDown();
            this.lblSelectItems_CNO = new System.Windows.Forms.Label();
            this.cboMenuItem_CNO = new System.Windows.Forms.ComboBox();
            this.btnPlaceOrder_CNO = new System.Windows.Forms.Button();
            this.btnCancelItem_CNO = new System.Windows.Forms.Button();
            this.gboCustomer_CNO.SuspendLayout();
            this.gboSummary_CNO.SuspendLayout();
            this.gboAddItems_CNO.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudQuantity_CNO)).BeginInit();
            this.SuspendLayout();
            // 
            // gboCustomer_CNO
            // 
            this.gboCustomer_CNO.Controls.Add(this.lblCustomerEmail_CNO);
            this.gboCustomer_CNO.Controls.Add(this.lblCustomerName_CNO);
            this.gboCustomer_CNO.Controls.Add(this.tboCustomerEmail_CNO);
            this.gboCustomer_CNO.Controls.Add(this.tboCustomerName_CNO);
            this.gboCustomer_CNO.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gboCustomer_CNO.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(111)))), ((int)(((byte)(78)))), ((int)(((byte)(55)))));
            this.gboCustomer_CNO.Location = new System.Drawing.Point(30, 31);
            this.gboCustomer_CNO.Name = "gboCustomer_CNO";
            this.gboCustomer_CNO.Size = new System.Drawing.Size(525, 242);
            this.gboCustomer_CNO.TabIndex = 0;
            this.gboCustomer_CNO.TabStop = false;
            this.gboCustomer_CNO.Text = "CUSTOMER INFORMATION";
            // 
            // lblCustomerEmail_CNO
            // 
            this.lblCustomerEmail_CNO.AutoSize = true;
            this.lblCustomerEmail_CNO.Location = new System.Drawing.Point(30, 112);
            this.lblCustomerEmail_CNO.Name = "lblCustomerEmail_CNO";
            this.lblCustomerEmail_CNO.Size = new System.Drawing.Size(72, 25);
            this.lblCustomerEmail_CNO.TabIndex = 3;
            this.lblCustomerEmail_CNO.Text = "Email:";
            // 
            // lblCustomerName_CNO
            // 
            this.lblCustomerName_CNO.AutoSize = true;
            this.lblCustomerName_CNO.Location = new System.Drawing.Point(30, 46);
            this.lblCustomerName_CNO.Name = "lblCustomerName_CNO";
            this.lblCustomerName_CNO.Size = new System.Drawing.Size(75, 25);
            this.lblCustomerName_CNO.TabIndex = 2;
            this.lblCustomerName_CNO.Text = "Name:";
            // 
            // tboCustomerEmail_CNO
            // 
            this.tboCustomerEmail_CNO.Location = new System.Drawing.Point(114, 109);
            this.tboCustomerEmail_CNO.Name = "tboCustomerEmail_CNO";
            this.tboCustomerEmail_CNO.Size = new System.Drawing.Size(373, 30);
            this.tboCustomerEmail_CNO.TabIndex = 1;
            // 
            // tboCustomerName_CNO
            // 
            this.tboCustomerName_CNO.Location = new System.Drawing.Point(114, 42);
            this.tboCustomerName_CNO.Name = "tboCustomerName_CNO";
            this.tboCustomerName_CNO.Size = new System.Drawing.Size(373, 30);
            this.tboCustomerName_CNO.TabIndex = 0;
            this.tboCustomerName_CNO.TextChanged += new System.EventHandler(this.tboCustomerName_CNO_TextChanged);
            // 
            // gboSummary_CNO
            // 
            this.gboSummary_CNO.Controls.Add(this.lblTotal_CNO);
            this.gboSummary_CNO.Controls.Add(this.lblTax_CNO);
            this.gboSummary_CNO.Controls.Add(this.lblSubtotal_CNO);
            this.gboSummary_CNO.Controls.Add(this.lboOrderItems_CNO);
            this.gboSummary_CNO.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gboSummary_CNO.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(111)))), ((int)(((byte)(78)))), ((int)(((byte)(55)))));
            this.gboSummary_CNO.Location = new System.Drawing.Point(600, 31);
            this.gboSummary_CNO.Name = "gboSummary_CNO";
            this.gboSummary_CNO.Size = new System.Drawing.Size(525, 242);
            this.gboSummary_CNO.TabIndex = 4;
            this.gboSummary_CNO.TabStop = false;
            this.gboSummary_CNO.Text = "ORDER SUMMARY";
            // 
            // lblTotal_CNO
            // 
            this.lblTotal_CNO.AutoSize = true;
            this.lblTotal_CNO.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(92)))), ((int)(((byte)(78)))));
            this.lblTotal_CNO.Location = new System.Drawing.Point(327, 145);
            this.lblTotal_CNO.Name = "lblTotal_CNO";
            this.lblTotal_CNO.Size = new System.Drawing.Size(151, 25);
            this.lblTotal_CNO.TabIndex = 6;
            this.lblTotal_CNO.Text = "TOTAL: $0.00";
            this.lblTotal_CNO.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblTax_CNO
            // 
            this.lblTax_CNO.AutoSize = true;
            this.lblTax_CNO.Location = new System.Drawing.Point(327, 95);
            this.lblTax_CNO.Name = "lblTax_CNO";
            this.lblTax_CNO.Size = new System.Drawing.Size(175, 25);
            this.lblTax_CNO.TabIndex = 5;
            this.lblTax_CNO.Text = "Tax(10%): $0.00";
            this.lblTax_CNO.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblSubtotal_CNO
            // 
            this.lblSubtotal_CNO.AutoSize = true;
            this.lblSubtotal_CNO.Location = new System.Drawing.Point(327, 46);
            this.lblSubtotal_CNO.Name = "lblSubtotal_CNO";
            this.lblSubtotal_CNO.Size = new System.Drawing.Size(159, 25);
            this.lblSubtotal_CNO.TabIndex = 4;
            this.lblSubtotal_CNO.Text = "Subtotal: $0.00";
            this.lblSubtotal_CNO.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lboOrderItems_CNO
            // 
            this.lboOrderItems_CNO.FormattingEnabled = true;
            this.lboOrderItems_CNO.ItemHeight = 25;
            this.lboOrderItems_CNO.Location = new System.Drawing.Point(20, 46);
            this.lboOrderItems_CNO.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.lboOrderItems_CNO.Name = "lboOrderItems_CNO";
            this.lboOrderItems_CNO.Size = new System.Drawing.Size(298, 154);
            this.lboOrderItems_CNO.TabIndex = 0;
            this.lboOrderItems_CNO.DoubleClick += new System.EventHandler(this.lboOrderItems_CNO_DoubleClick);
            // 
            // gboAddItems_CNO
            // 
            this.gboAddItems_CNO.Controls.Add(this.btnRemoveItem_CNO);
            this.gboAddItems_CNO.Controls.Add(this.btnAddToOrder_CNO);
            this.gboAddItems_CNO.Controls.Add(this.lblItemPrice_CNO);
            this.gboAddItems_CNO.Controls.Add(this.lblQuantity_CNO);
            this.gboAddItems_CNO.Controls.Add(this.nudQuantity_CNO);
            this.gboAddItems_CNO.Controls.Add(this.lblSelectItems_CNO);
            this.gboAddItems_CNO.Controls.Add(this.cboMenuItem_CNO);
            this.gboAddItems_CNO.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gboAddItems_CNO.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(111)))), ((int)(((byte)(78)))), ((int)(((byte)(55)))));
            this.gboAddItems_CNO.Location = new System.Drawing.Point(30, 280);
            this.gboAddItems_CNO.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gboAddItems_CNO.Name = "gboAddItems_CNO";
            this.gboAddItems_CNO.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gboAddItems_CNO.Size = new System.Drawing.Size(1095, 231);
            this.gboAddItems_CNO.TabIndex = 5;
            this.gboAddItems_CNO.TabStop = false;
            this.gboAddItems_CNO.Text = "ADD ITEMS TO ORDER";
            // 
            // btnRemoveItem_CNO
            // 
            this.btnRemoveItem_CNO.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(77)))), ((int)(((byte)(77)))));
            this.btnRemoveItem_CNO.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRemoveItem_CNO.ForeColor = System.Drawing.Color.White;
            this.btnRemoveItem_CNO.Location = new System.Drawing.Point(622, 146);
            this.btnRemoveItem_CNO.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnRemoveItem_CNO.Name = "btnRemoveItem_CNO";
            this.btnRemoveItem_CNO.Size = new System.Drawing.Size(291, 54);
            this.btnRemoveItem_CNO.TabIndex = 9;
            this.btnRemoveItem_CNO.Text = "🗑️ REMOVE ITEM";
            this.btnRemoveItem_CNO.UseVisualStyleBackColor = false;
            this.btnRemoveItem_CNO.Click += new System.EventHandler(this.btnRemoveItem_CNO_Click);
            // 
            // btnAddToOrder_CNO
            // 
            this.btnAddToOrder_CNO.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(44)))), ((int)(((byte)(42)))));
            this.btnAddToOrder_CNO.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddToOrder_CNO.ForeColor = System.Drawing.Color.White;
            this.btnAddToOrder_CNO.Location = new System.Drawing.Point(277, 146);
            this.btnAddToOrder_CNO.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnAddToOrder_CNO.Name = "btnAddToOrder_CNO";
            this.btnAddToOrder_CNO.Size = new System.Drawing.Size(248, 54);
            this.btnAddToOrder_CNO.TabIndex = 8;
            this.btnAddToOrder_CNO.Text = "➕ ADD TO ORDER";
            this.btnAddToOrder_CNO.UseVisualStyleBackColor = false;
            this.btnAddToOrder_CNO.Click += new System.EventHandler(this.btnAddToOrder_CNO_Click);
            // 
            // lblItemPrice_CNO
            // 
            this.lblItemPrice_CNO.AutoSize = true;
            this.lblItemPrice_CNO.Location = new System.Drawing.Point(872, 49);
            this.lblItemPrice_CNO.Name = "lblItemPrice_CNO";
            this.lblItemPrice_CNO.Size = new System.Drawing.Size(181, 25);
            this.lblItemPrice_CNO.TabIndex = 7;
            this.lblItemPrice_CNO.Text = "Price: $0.00 each";
            // 
            // lblQuantity_CNO
            // 
            this.lblQuantity_CNO.AutoSize = true;
            this.lblQuantity_CNO.Location = new System.Drawing.Point(645, 51);
            this.lblQuantity_CNO.Name = "lblQuantity_CNO";
            this.lblQuantity_CNO.Size = new System.Drawing.Size(100, 25);
            this.lblQuantity_CNO.TabIndex = 6;
            this.lblQuantity_CNO.Text = "Quantity:";
            // 
            // nudQuantity_CNO
            // 
            this.nudQuantity_CNO.Location = new System.Drawing.Point(764, 46);
            this.nudQuantity_CNO.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.nudQuantity_CNO.Maximum = new decimal(new int[] {
            99,
            0,
            0,
            0});
            this.nudQuantity_CNO.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudQuantity_CNO.Name = "nudQuantity_CNO";
            this.nudQuantity_CNO.Size = new System.Drawing.Size(90, 30);
            this.nudQuantity_CNO.TabIndex = 5;
            this.nudQuantity_CNO.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // lblSelectItems_CNO
            // 
            this.lblSelectItems_CNO.AutoSize = true;
            this.lblSelectItems_CNO.Location = new System.Drawing.Point(30, 51);
            this.lblSelectItems_CNO.Name = "lblSelectItems_CNO";
            this.lblSelectItems_CNO.Size = new System.Drawing.Size(127, 25);
            this.lblSelectItems_CNO.TabIndex = 4;
            this.lblSelectItems_CNO.Text = "Select Item:";
            // 
            // cboMenuItem_CNO
            // 
            this.cboMenuItem_CNO.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboMenuItem_CNO.FormattingEnabled = true;
            this.cboMenuItem_CNO.Location = new System.Drawing.Point(177, 46);
            this.cboMenuItem_CNO.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cboMenuItem_CNO.Name = "cboMenuItem_CNO";
            this.cboMenuItem_CNO.Size = new System.Drawing.Size(448, 33);
            this.cboMenuItem_CNO.TabIndex = 0;
            this.cboMenuItem_CNO.SelectedIndexChanged += new System.EventHandler(this.cboMenuItem_CNO_SelectedIndexChanged);
            // 
            // btnPlaceOrder_CNO
            // 
            this.btnPlaceOrder_CNO.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(44)))), ((int)(((byte)(42)))));
            this.btnPlaceOrder_CNO.Enabled = false;
            this.btnPlaceOrder_CNO.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPlaceOrder_CNO.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPlaceOrder_CNO.ForeColor = System.Drawing.Color.White;
            this.btnPlaceOrder_CNO.Location = new System.Drawing.Point(354, 665);
            this.btnPlaceOrder_CNO.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnPlaceOrder_CNO.Name = "btnPlaceOrder_CNO";
            this.btnPlaceOrder_CNO.Size = new System.Drawing.Size(244, 62);
            this.btnPlaceOrder_CNO.TabIndex = 10;
            this.btnPlaceOrder_CNO.Text = "💾 PLACE ORDER";
            this.btnPlaceOrder_CNO.UseVisualStyleBackColor = false;
            this.btnPlaceOrder_CNO.Click += new System.EventHandler(this.btnPlaceOrder_CNO_Click);
            // 
            // btnCancelItem_CNO
            // 
            this.btnCancelItem_CNO.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(44)))), ((int)(((byte)(42)))));
            this.btnCancelItem_CNO.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelItem_CNO.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelItem_CNO.ForeColor = System.Drawing.Color.White;
            this.btnCancelItem_CNO.Location = new System.Drawing.Point(620, 665);
            this.btnCancelItem_CNO.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnCancelItem_CNO.Name = "btnCancelItem_CNO";
            this.btnCancelItem_CNO.Size = new System.Drawing.Size(244, 62);
            this.btnCancelItem_CNO.TabIndex = 11;
            this.btnCancelItem_CNO.Text = "❌ CANCEL";
            this.btnCancelItem_CNO.UseVisualStyleBackColor = false;
            this.btnCancelItem_CNO.Click += new System.EventHandler(this.btnCancelItem_CNO_Click);
            // 
            // frmCreateOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(240)))), ((int)(((byte)(230)))));
            this.ClientSize = new System.Drawing.Size(1201, 780);
            this.Controls.Add(this.btnCancelItem_CNO);
            this.Controls.Add(this.btnPlaceOrder_CNO);
            this.Controls.Add(this.gboAddItems_CNO);
            this.Controls.Add(this.gboSummary_CNO);
            this.Controls.Add(this.gboCustomer_CNO);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "frmCreateOrder";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Create New Order - Coffee Shop";
            this.gboCustomer_CNO.ResumeLayout(false);
            this.gboCustomer_CNO.PerformLayout();
            this.gboSummary_CNO.ResumeLayout(false);
            this.gboSummary_CNO.PerformLayout();
            this.gboAddItems_CNO.ResumeLayout(false);
            this.gboAddItems_CNO.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudQuantity_CNO)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gboCustomer_CNO;
        private System.Windows.Forms.Label lblCustomerEmail_CNO;
        private System.Windows.Forms.Label lblCustomerName_CNO;
        private System.Windows.Forms.TextBox tboCustomerEmail_CNO;
        private System.Windows.Forms.TextBox tboCustomerName_CNO;
        private System.Windows.Forms.GroupBox gboSummary_CNO;
        private System.Windows.Forms.Label lblTax_CNO;
        private System.Windows.Forms.Label lblSubtotal_CNO;
        private System.Windows.Forms.ListBox lboOrderItems_CNO;
        private System.Windows.Forms.Label lblTotal_CNO;
        private System.Windows.Forms.GroupBox gboAddItems_CNO;
        private System.Windows.Forms.ComboBox cboMenuItem_CNO;
        private System.Windows.Forms.Button btnRemoveItem_CNO;
        private System.Windows.Forms.Button btnAddToOrder_CNO;
        private System.Windows.Forms.Label lblItemPrice_CNO;
        private System.Windows.Forms.Label lblQuantity_CNO;
        private System.Windows.Forms.NumericUpDown nudQuantity_CNO;
        private System.Windows.Forms.Label lblSelectItems_CNO;
        private System.Windows.Forms.Button btnPlaceOrder_CNO;
        private System.Windows.Forms.Button btnCancelItem_CNO;
    }
}