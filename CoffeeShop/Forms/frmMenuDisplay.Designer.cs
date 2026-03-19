namespace CoffeeShop
{
    partial class frmMenuDisplay
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
            this.gboDetailInformation = new System.Windows.Forms.GroupBox();
            this.lblTotalSold_DI = new System.Windows.Forms.Label();
            this.lblIngredients_DI = new System.Windows.Forms.Label();
            this.lblSugar_DI = new System.Windows.Forms.Label();
            this.lblCarbs_DI = new System.Windows.Forms.Label();
            this.lblFats_DI = new System.Windows.Forms.Label();
            this.lblCalories_DI = new System.Windows.Forms.Label();
            this.lblCategory_DI = new System.Windows.Forms.Label();
            this.lblPrice = new System.Windows.Forms.Label();
            this.lblDescription = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.pboItem = new System.Windows.Forms.PictureBox();
            this.btnAddNew_MD = new System.Windows.Forms.Button();
            this.btnModify_MD = new System.Windows.Forms.Button();
            this.btnDelete_MD = new System.Windows.Forms.Button();
            this.btnBack_MD = new System.Windows.Forms.Button();
            this.gboFilterOptions = new System.Windows.Forms.GroupBox();
            this.btnFilter = new System.Windows.Forms.Button();
            this.cboCategory = new System.Windows.Forms.ComboBox();
            this.gboMenuItems = new System.Windows.Forms.GroupBox();
            this.dvgMenuItems = new System.Windows.Forms.DataGridView();
            this.btnRefresh_MD = new System.Windows.Forms.Button();
            this.gboDetailInformation.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pboItem)).BeginInit();
            this.gboFilterOptions.SuspendLayout();
            this.gboMenuItems.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dvgMenuItems)).BeginInit();
            this.SuspendLayout();
            // 
            // gboDetailInformation
            // 
            this.gboDetailInformation.BackColor = System.Drawing.Color.Transparent;
            this.gboDetailInformation.Controls.Add(this.lblTotalSold_DI);
            this.gboDetailInformation.Controls.Add(this.lblIngredients_DI);
            this.gboDetailInformation.Controls.Add(this.lblSugar_DI);
            this.gboDetailInformation.Controls.Add(this.lblCarbs_DI);
            this.gboDetailInformation.Controls.Add(this.lblFats_DI);
            this.gboDetailInformation.Controls.Add(this.lblCalories_DI);
            this.gboDetailInformation.Controls.Add(this.lblCategory_DI);
            this.gboDetailInformation.Controls.Add(this.lblPrice);
            this.gboDetailInformation.Controls.Add(this.lblDescription);
            this.gboDetailInformation.Controls.Add(this.lblTitle);
            this.gboDetailInformation.Controls.Add(this.pboItem);
            this.gboDetailInformation.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gboDetailInformation.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(111)))), ((int)(((byte)(78)))), ((int)(((byte)(55)))));
            this.gboDetailInformation.Location = new System.Drawing.Point(12, 331);
            this.gboDetailInformation.Name = "gboDetailInformation";
            this.gboDetailInformation.Size = new System.Drawing.Size(850, 366);
            this.gboDetailInformation.TabIndex = 4;
            this.gboDetailInformation.TabStop = false;
            this.gboDetailInformation.Text = "DETAILED INFO";
            // 
            // lblTotalSold_DI
            // 
            this.lblTotalSold_DI.AutoEllipsis = true;
            this.lblTotalSold_DI.AutoSize = true;
            this.lblTotalSold_DI.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalSold_DI.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(92)))), ((int)(((byte)(78)))));
            this.lblTotalSold_DI.Location = new System.Drawing.Point(38, 275);
            this.lblTotalSold_DI.Name = "lblTotalSold_DI";
            this.lblTotalSold_DI.Size = new System.Drawing.Size(238, 29);
            this.lblTotalSold_DI.TabIndex = 10;
            this.lblTotalSold_DI.Text = "[Total appear here]";
            // 
            // lblIngredients_DI
            // 
            this.lblIngredients_DI.AutoEllipsis = true;
            this.lblIngredients_DI.AutoSize = true;
            this.lblIngredients_DI.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIngredients_DI.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(44)))), ((int)(((byte)(42)))));
            this.lblIngredients_DI.Location = new System.Drawing.Point(36, 218);
            this.lblIngredients_DI.Name = "lblIngredients_DI";
            this.lblIngredients_DI.Size = new System.Drawing.Size(309, 29);
            this.lblIngredients_DI.TabIndex = 9;
            this.lblIngredients_DI.Text = "[Ingredients appear here]";
            // 
            // lblSugar_DI
            // 
            this.lblSugar_DI.AutoSize = true;
            this.lblSugar_DI.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSugar_DI.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(44)))), ((int)(((byte)(42)))));
            this.lblSugar_DI.Location = new System.Drawing.Point(615, 151);
            this.lblSugar_DI.Name = "lblSugar_DI";
            this.lblSugar_DI.Size = new System.Drawing.Size(89, 29);
            this.lblSugar_DI.TabIndex = 8;
            this.lblSugar_DI.Text = "Sugar:";
            // 
            // lblCarbs_DI
            // 
            this.lblCarbs_DI.AutoSize = true;
            this.lblCarbs_DI.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCarbs_DI.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(44)))), ((int)(((byte)(42)))));
            this.lblCarbs_DI.Location = new System.Drawing.Point(615, 112);
            this.lblCarbs_DI.Name = "lblCarbs_DI";
            this.lblCarbs_DI.Size = new System.Drawing.Size(89, 29);
            this.lblCarbs_DI.TabIndex = 7;
            this.lblCarbs_DI.Text = "Carbs:";
            // 
            // lblFats_DI
            // 
            this.lblFats_DI.AutoSize = true;
            this.lblFats_DI.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFats_DI.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(44)))), ((int)(((byte)(42)))));
            this.lblFats_DI.Location = new System.Drawing.Point(375, 151);
            this.lblFats_DI.Name = "lblFats_DI";
            this.lblFats_DI.Size = new System.Drawing.Size(70, 29);
            this.lblFats_DI.TabIndex = 6;
            this.lblFats_DI.Text = "Fats:";
            // 
            // lblCalories_DI
            // 
            this.lblCalories_DI.AutoSize = true;
            this.lblCalories_DI.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCalories_DI.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(44)))), ((int)(((byte)(42)))));
            this.lblCalories_DI.Location = new System.Drawing.Point(190, 151);
            this.lblCalories_DI.Name = "lblCalories_DI";
            this.lblCalories_DI.Size = new System.Drawing.Size(118, 29);
            this.lblCalories_DI.TabIndex = 5;
            this.lblCalories_DI.Text = "Calories:";
            // 
            // lblCategory_DI
            // 
            this.lblCategory_DI.AutoSize = true;
            this.lblCategory_DI.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCategory_DI.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(44)))), ((int)(((byte)(42)))));
            this.lblCategory_DI.Location = new System.Drawing.Point(375, 112);
            this.lblCategory_DI.Name = "lblCategory_DI";
            this.lblCategory_DI.Size = new System.Drawing.Size(132, 29);
            this.lblCategory_DI.TabIndex = 4;
            this.lblCategory_DI.Text = "Category: ";
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrice.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(44)))), ((int)(((byte)(42)))));
            this.lblPrice.Location = new System.Drawing.Point(190, 112);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(88, 29);
            this.lblPrice.TabIndex = 3;
            this.lblPrice.Text = "Price: ";
            // 
            // lblDescription
            // 
            this.lblDescription.AutoEllipsis = true;
            this.lblDescription.AutoSize = true;
            this.lblDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescription.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(44)))), ((int)(((byte)(42)))));
            this.lblDescription.Location = new System.Drawing.Point(190, 71);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(358, 29);
            this.lblDescription.TabIndex = 2;
            this.lblDescription.Text = "[Description will appear here]";
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(44)))), ((int)(((byte)(42)))));
            this.lblTitle.Location = new System.Drawing.Point(190, 31);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(278, 29);
            this.lblTitle.TabIndex = 1;
            this.lblTitle.Text = "[Title will appear here]";
            // 
            // pboItem
            // 
            this.pboItem.BackColor = System.Drawing.Color.White;
            this.pboItem.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pboItem.Location = new System.Drawing.Point(20, 31);
            this.pboItem.Name = "pboItem";
            this.pboItem.Size = new System.Drawing.Size(150, 150);
            this.pboItem.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pboItem.TabIndex = 0;
            this.pboItem.TabStop = false;
            // 
            // btnAddNew_MD
            // 
            this.btnAddNew_MD.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(44)))), ((int)(((byte)(42)))));
            this.btnAddNew_MD.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddNew_MD.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddNew_MD.ForeColor = System.Drawing.Color.White;
            this.btnAddNew_MD.Location = new System.Drawing.Point(131, 723);
            this.btnAddNew_MD.Name = "btnAddNew_MD";
            this.btnAddNew_MD.Size = new System.Drawing.Size(126, 35);
            this.btnAddNew_MD.TabIndex = 5;
            this.btnAddNew_MD.Text = "➕ ADD NEW";
            this.btnAddNew_MD.UseVisualStyleBackColor = false;
            this.btnAddNew_MD.Click += new System.EventHandler(this.btnAddNew_MD_Click);
            // 
            // btnModify_MD
            // 
            this.btnModify_MD.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(44)))), ((int)(((byte)(42)))));
            this.btnModify_MD.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModify_MD.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModify_MD.ForeColor = System.Drawing.Color.White;
            this.btnModify_MD.Location = new System.Drawing.Point(263, 723);
            this.btnModify_MD.Name = "btnModify_MD";
            this.btnModify_MD.Size = new System.Drawing.Size(123, 35);
            this.btnModify_MD.TabIndex = 6;
            this.btnModify_MD.Text = "✏️ MODIFY";
            this.btnModify_MD.UseVisualStyleBackColor = false;
            this.btnModify_MD.Click += new System.EventHandler(this.btnModify_MD_Click);
            // 
            // btnDelete_MD
            // 
            this.btnDelete_MD.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(44)))), ((int)(((byte)(42)))));
            this.btnDelete_MD.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete_MD.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete_MD.ForeColor = System.Drawing.Color.White;
            this.btnDelete_MD.Location = new System.Drawing.Point(392, 723);
            this.btnDelete_MD.Name = "btnDelete_MD";
            this.btnDelete_MD.Size = new System.Drawing.Size(128, 35);
            this.btnDelete_MD.TabIndex = 7;
            this.btnDelete_MD.Text = "🗑️ DELETE";
            this.btnDelete_MD.UseVisualStyleBackColor = false;
            this.btnDelete_MD.Click += new System.EventHandler(this.btnDelete_MD_Click);
            // 
            // btnBack_MD
            // 
            this.btnBack_MD.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(44)))), ((int)(((byte)(42)))));
            this.btnBack_MD.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBack_MD.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack_MD.ForeColor = System.Drawing.Color.White;
            this.btnBack_MD.Location = new System.Drawing.Point(671, 723);
            this.btnBack_MD.Name = "btnBack_MD";
            this.btnBack_MD.Size = new System.Drawing.Size(100, 35);
            this.btnBack_MD.TabIndex = 8;
            this.btnBack_MD.Text = "🔙 BACK";
            this.btnBack_MD.UseVisualStyleBackColor = false;
            this.btnBack_MD.Click += new System.EventHandler(this.btnBack_MD_Click);
            // 
            // gboFilterOptions
            // 
            this.gboFilterOptions.BackColor = System.Drawing.Color.Transparent;
            this.gboFilterOptions.Controls.Add(this.btnFilter);
            this.gboFilterOptions.Controls.Add(this.cboCategory);
            this.gboFilterOptions.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gboFilterOptions.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(111)))), ((int)(((byte)(78)))), ((int)(((byte)(55)))));
            this.gboFilterOptions.Location = new System.Drawing.Point(12, 12);
            this.gboFilterOptions.Name = "gboFilterOptions";
            this.gboFilterOptions.Size = new System.Drawing.Size(850, 89);
            this.gboFilterOptions.TabIndex = 9;
            this.gboFilterOptions.TabStop = false;
            this.gboFilterOptions.Text = "FILTER OPTIONS";
            // 
            // btnFilter
            // 
            this.btnFilter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(44)))), ((int)(((byte)(42)))));
            this.btnFilter.ForeColor = System.Drawing.Color.White;
            this.btnFilter.Location = new System.Drawing.Point(324, 29);
            this.btnFilter.Name = "btnFilter";
            this.btnFilter.Size = new System.Drawing.Size(147, 45);
            this.btnFilter.TabIndex = 5;
            this.btnFilter.Text = "🔍 FILTER";
            this.btnFilter.UseVisualStyleBackColor = false;
            this.btnFilter.Click += new System.EventHandler(this.btnFilter_Click);
            // 
            // cboCategory
            // 
            this.cboCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboCategory.FormattingEnabled = true;
            this.cboCategory.Location = new System.Drawing.Point(68, 35);
            this.cboCategory.Name = "cboCategory";
            this.cboCategory.Size = new System.Drawing.Size(250, 34);
            this.cboCategory.TabIndex = 4;
            // 
            // gboMenuItems
            // 
            this.gboMenuItems.BackColor = System.Drawing.Color.Transparent;
            this.gboMenuItems.Controls.Add(this.dvgMenuItems);
            this.gboMenuItems.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gboMenuItems.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(111)))), ((int)(((byte)(78)))), ((int)(((byte)(55)))));
            this.gboMenuItems.Location = new System.Drawing.Point(12, 107);
            this.gboMenuItems.Name = "gboMenuItems";
            this.gboMenuItems.Size = new System.Drawing.Size(850, 200);
            this.gboMenuItems.TabIndex = 0;
            this.gboMenuItems.TabStop = false;
            this.gboMenuItems.Text = "MENU ITEMS";
            // 
            // dvgMenuItems
            // 
            this.dvgMenuItems.AllowUserToAddRows = false;
            this.dvgMenuItems.AllowUserToDeleteRows = false;
            this.dvgMenuItems.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dvgMenuItems.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dvgMenuItems.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvgMenuItems.GridColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dvgMenuItems.Location = new System.Drawing.Point(10, 31);
            this.dvgMenuItems.MultiSelect = false;
            this.dvgMenuItems.Name = "dvgMenuItems";
            this.dvgMenuItems.ReadOnly = true;
            this.dvgMenuItems.RowHeadersVisible = false;
            this.dvgMenuItems.RowHeadersWidth = 62;
            this.dvgMenuItems.RowTemplate.Height = 28;
            this.dvgMenuItems.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dvgMenuItems.Size = new System.Drawing.Size(830, 160);
            this.dvgMenuItems.TabIndex = 4;
            this.dvgMenuItems.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dvgMenuItems_CellClick);
            // 
            // btnRefresh_MD
            // 
            this.btnRefresh_MD.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(44)))), ((int)(((byte)(42)))));
            this.btnRefresh_MD.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRefresh_MD.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRefresh_MD.ForeColor = System.Drawing.Color.White;
            this.btnRefresh_MD.Location = new System.Drawing.Point(526, 723);
            this.btnRefresh_MD.Name = "btnRefresh_MD";
            this.btnRefresh_MD.Size = new System.Drawing.Size(140, 35);
            this.btnRefresh_MD.TabIndex = 10;
            this.btnRefresh_MD.Text = "⟳ REFRESH";
            this.btnRefresh_MD.UseVisualStyleBackColor = false;
            this.btnRefresh_MD.Click += new System.EventHandler(this.btnRefresh_MD_Click);
            // 
            // frmMenuDisplay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(240)))), ((int)(((byte)(230)))));
            this.ClientSize = new System.Drawing.Size(878, 810);
            this.Controls.Add(this.btnRefresh_MD);
            this.Controls.Add(this.btnDelete_MD);
            this.Controls.Add(this.gboMenuItems);
            this.Controls.Add(this.btnAddNew_MD);
            this.Controls.Add(this.gboFilterOptions);
            this.Controls.Add(this.btnBack_MD);
            this.Controls.Add(this.gboDetailInformation);
            this.Controls.Add(this.btnModify_MD);
            this.Name = "frmMenuDisplay";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu Display";
            this.Load += new System.EventHandler(this.frmMenuDisplay_Load);
            this.gboDetailInformation.ResumeLayout(false);
            this.gboDetailInformation.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pboItem)).EndInit();
            this.gboFilterOptions.ResumeLayout(false);
            this.gboMenuItems.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dvgMenuItems)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox gboDetailInformation;
        private System.Windows.Forms.Button btnAddNew_MD;
        private System.Windows.Forms.Button btnModify_MD;
        private System.Windows.Forms.Button btnDelete_MD;
        private System.Windows.Forms.Button btnBack_MD;
        private System.Windows.Forms.GroupBox gboFilterOptions;
        private System.Windows.Forms.Button btnFilter;
        private System.Windows.Forms.ComboBox cboCategory;
        private System.Windows.Forms.GroupBox gboMenuItems;
        private System.Windows.Forms.DataGridView dvgMenuItems;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.PictureBox pboItem;
        private System.Windows.Forms.Label lblSugar_DI;
        private System.Windows.Forms.Label lblCarbs_DI;
        private System.Windows.Forms.Label lblFats_DI;
        private System.Windows.Forms.Label lblCalories_DI;
        private System.Windows.Forms.Label lblCategory_DI;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.Label lblTotalSold_DI;
        private System.Windows.Forms.Label lblIngredients_DI;
        private System.Windows.Forms.Button btnRefresh_MD;
    }
}