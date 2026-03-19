namespace CoffeeShop
{
    partial class frmModifyMenuItem
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
            this.gboSelectItem = new System.Windows.Forms.GroupBox();
            this.btnConfirmItem = new System.Windows.Forms.Button();
            this.cboItem = new System.Windows.Forms.ComboBox();
            this.gboEditItemDetails = new System.Windows.Forms.GroupBox();
            this.btnCancel_MMI = new System.Windows.Forms.Button();
            this.btnDelete_MMI = new System.Windows.Forms.Button();
            this.btnUpdate_MMI = new System.Windows.Forms.Button();
            this.lblQuantitySold_MMI = new System.Windows.Forms.Label();
            this.txtQuantitySold = new System.Windows.Forms.TextBox();
            this.lblIngredients_MMI = new System.Windows.Forms.Label();
            this.txtIngredients_MMI = new System.Windows.Forms.TextBox();
            this.gboNutrition = new System.Windows.Forms.GroupBox();
            this.lblSugar_MMI = new System.Windows.Forms.Label();
            this.lblCarbs_MMI = new System.Windows.Forms.Label();
            this.txtSugar_MMI = new System.Windows.Forms.TextBox();
            this.txtCarbs_MMI = new System.Windows.Forms.TextBox();
            this.lblFat = new System.Windows.Forms.Label();
            this.txtFat_MMI = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCalories_MMI = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtImageUrl = new System.Windows.Forms.TextBox();
            this.lblPrice_MMI = new System.Windows.Forms.Label();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.lblCategory = new System.Windows.Forms.Label();
            this.cboCategory = new System.Windows.Forms.ComboBox();
            this.lblTitle_MMI = new System.Windows.Forms.Label();
            this.txtTitle_MMI = new System.Windows.Forms.TextBox();
            this.gboSelectItem.SuspendLayout();
            this.gboEditItemDetails.SuspendLayout();
            this.gboNutrition.SuspendLayout();
            this.SuspendLayout();
            // 
            // gboSelectItem
            // 
            this.gboSelectItem.BackColor = System.Drawing.Color.Transparent;
            this.gboSelectItem.Controls.Add(this.btnConfirmItem);
            this.gboSelectItem.Controls.Add(this.cboItem);
            this.gboSelectItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gboSelectItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(111)))), ((int)(((byte)(78)))), ((int)(((byte)(55)))));
            this.gboSelectItem.Location = new System.Drawing.Point(30, 31);
            this.gboSelectItem.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gboSelectItem.Name = "gboSelectItem";
            this.gboSelectItem.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gboSelectItem.Size = new System.Drawing.Size(975, 123);
            this.gboSelectItem.TabIndex = 0;
            this.gboSelectItem.TabStop = false;
            this.gboSelectItem.Text = "SELECT ITEM TO MODIFY";
            // 
            // btnConfirmItem
            // 
            this.btnConfirmItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(44)))), ((int)(((byte)(42)))));
            this.btnConfirmItem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConfirmItem.ForeColor = System.Drawing.Color.White;
            this.btnConfirmItem.Location = new System.Drawing.Point(558, 28);
            this.btnConfirmItem.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnConfirmItem.Name = "btnConfirmItem";
            this.btnConfirmItem.Size = new System.Drawing.Size(225, 46);
            this.btnConfirmItem.TabIndex = 2;
            this.btnConfirmItem.Text = "📂 CONFIRM";
            this.btnConfirmItem.UseVisualStyleBackColor = false;
            this.btnConfirmItem.Click += new System.EventHandler(this.btnConfirmItem_Click);
            // 
            // cboItem
            // 
            this.cboItem.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboItem.FormattingEnabled = true;
            this.cboItem.Location = new System.Drawing.Point(24, 34);
            this.cboItem.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cboItem.Name = "cboItem";
            this.cboItem.Size = new System.Drawing.Size(523, 33);
            this.cboItem.TabIndex = 1;
            // 
            // gboEditItemDetails
            // 
            this.gboEditItemDetails.AutoSize = true;
            this.gboEditItemDetails.BackColor = System.Drawing.Color.Transparent;
            this.gboEditItemDetails.Controls.Add(this.btnCancel_MMI);
            this.gboEditItemDetails.Controls.Add(this.btnDelete_MMI);
            this.gboEditItemDetails.Controls.Add(this.btnUpdate_MMI);
            this.gboEditItemDetails.Controls.Add(this.lblQuantitySold_MMI);
            this.gboEditItemDetails.Controls.Add(this.txtQuantitySold);
            this.gboEditItemDetails.Controls.Add(this.lblIngredients_MMI);
            this.gboEditItemDetails.Controls.Add(this.txtIngredients_MMI);
            this.gboEditItemDetails.Controls.Add(this.gboNutrition);
            this.gboEditItemDetails.Controls.Add(this.label1);
            this.gboEditItemDetails.Controls.Add(this.txtImageUrl);
            this.gboEditItemDetails.Controls.Add(this.lblPrice_MMI);
            this.gboEditItemDetails.Controls.Add(this.txtPrice);
            this.gboEditItemDetails.Controls.Add(this.lblCategory);
            this.gboEditItemDetails.Controls.Add(this.cboCategory);
            this.gboEditItemDetails.Controls.Add(this.lblTitle_MMI);
            this.gboEditItemDetails.Controls.Add(this.txtTitle_MMI);
            this.gboEditItemDetails.Enabled = false;
            this.gboEditItemDetails.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gboEditItemDetails.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(111)))), ((int)(((byte)(78)))), ((int)(((byte)(55)))));
            this.gboEditItemDetails.Location = new System.Drawing.Point(30, 163);
            this.gboEditItemDetails.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gboEditItemDetails.Name = "gboEditItemDetails";
            this.gboEditItemDetails.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gboEditItemDetails.Size = new System.Drawing.Size(975, 763);
            this.gboEditItemDetails.TabIndex = 1;
            this.gboEditItemDetails.TabStop = false;
            this.gboEditItemDetails.Text = "EDIT ITEM DETAILS";
            // 
            // btnCancel_MMI
            // 
            this.btnCancel_MMI.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(44)))), ((int)(((byte)(42)))));
            this.btnCancel_MMI.Enabled = false;
            this.btnCancel_MMI.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel_MMI.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel_MMI.ForeColor = System.Drawing.Color.White;
            this.btnCancel_MMI.Location = new System.Drawing.Point(600, 675);
            this.btnCancel_MMI.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnCancel_MMI.Name = "btnCancel_MMI";
            this.btnCancel_MMI.Size = new System.Drawing.Size(150, 54);
            this.btnCancel_MMI.TabIndex = 22;
            this.btnCancel_MMI.Text = "❌ CANCEL";
            this.btnCancel_MMI.UseVisualStyleBackColor = false;
            this.btnCancel_MMI.Click += new System.EventHandler(this.btnCancel_MMI_Click);
            // 
            // btnDelete_MMI
            // 
            this.btnDelete_MMI.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(77)))), ((int)(((byte)(77)))));
            this.btnDelete_MMI.Enabled = false;
            this.btnDelete_MMI.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete_MMI.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete_MMI.ForeColor = System.Drawing.Color.White;
            this.btnDelete_MMI.Location = new System.Drawing.Point(399, 675);
            this.btnDelete_MMI.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnDelete_MMI.Name = "btnDelete_MMI";
            this.btnDelete_MMI.Size = new System.Drawing.Size(150, 54);
            this.btnDelete_MMI.TabIndex = 21;
            this.btnDelete_MMI.Text = "🗑️ DELETE";
            this.btnDelete_MMI.UseVisualStyleBackColor = false;
            // 
            // btnUpdate_MMI
            // 
            this.btnUpdate_MMI.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(92)))), ((int)(((byte)(78)))));
            this.btnUpdate_MMI.Enabled = false;
            this.btnUpdate_MMI.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdate_MMI.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate_MMI.ForeColor = System.Drawing.Color.White;
            this.btnUpdate_MMI.Location = new System.Drawing.Point(195, 675);
            this.btnUpdate_MMI.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnUpdate_MMI.Name = "btnUpdate_MMI";
            this.btnUpdate_MMI.Size = new System.Drawing.Size(150, 54);
            this.btnUpdate_MMI.TabIndex = 20;
            this.btnUpdate_MMI.Text = "💾 UPDATE";
            this.btnUpdate_MMI.UseVisualStyleBackColor = false;
            this.btnUpdate_MMI.Click += new System.EventHandler(this.btnUpdate_MMI_Click);
            // 
            // lblQuantitySold_MMI
            // 
            this.lblQuantitySold_MMI.AutoSize = true;
            this.lblQuantitySold_MMI.Location = new System.Drawing.Point(100, 574);
            this.lblQuantitySold_MMI.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblQuantitySold_MMI.Name = "lblQuantitySold_MMI";
            this.lblQuantitySold_MMI.Size = new System.Drawing.Size(150, 25);
            this.lblQuantitySold_MMI.TabIndex = 19;
            this.lblQuantitySold_MMI.Text = "Quantity Sold:";
            // 
            // txtQuantitySold
            // 
            this.txtQuantitySold.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.txtQuantitySold.Location = new System.Drawing.Point(276, 569);
            this.txtQuantitySold.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtQuantitySold.Name = "txtQuantitySold";
            this.txtQuantitySold.ReadOnly = true;
            this.txtQuantitySold.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtQuantitySold.Size = new System.Drawing.Size(118, 30);
            this.txtQuantitySold.TabIndex = 18;
            this.txtQuantitySold.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblIngredients_MMI
            // 
            this.lblIngredients_MMI.AutoSize = true;
            this.lblIngredients_MMI.Location = new System.Drawing.Point(100, 455);
            this.lblIngredients_MMI.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblIngredients_MMI.Name = "lblIngredients_MMI";
            this.lblIngredients_MMI.Size = new System.Drawing.Size(126, 25);
            this.lblIngredients_MMI.TabIndex = 17;
            this.lblIngredients_MMI.Text = "Ingredients:";
            // 
            // txtIngredients_MMI
            // 
            this.txtIngredients_MMI.Location = new System.Drawing.Point(250, 451);
            this.txtIngredients_MMI.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtIngredients_MMI.Multiline = true;
            this.txtIngredients_MMI.Name = "txtIngredients_MMI";
            this.txtIngredients_MMI.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtIngredients_MMI.Size = new System.Drawing.Size(598, 90);
            this.txtIngredients_MMI.TabIndex = 16;
            this.txtIngredients_MMI.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // gboNutrition
            // 
            this.gboNutrition.Controls.Add(this.lblSugar_MMI);
            this.gboNutrition.Controls.Add(this.lblCarbs_MMI);
            this.gboNutrition.Controls.Add(this.txtSugar_MMI);
            this.gboNutrition.Controls.Add(this.txtCarbs_MMI);
            this.gboNutrition.Controls.Add(this.lblFat);
            this.gboNutrition.Controls.Add(this.txtFat_MMI);
            this.gboNutrition.Controls.Add(this.label2);
            this.gboNutrition.Controls.Add(this.txtCalories_MMI);
            this.gboNutrition.Location = new System.Drawing.Point(30, 292);
            this.gboNutrition.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gboNutrition.Name = "gboNutrition";
            this.gboNutrition.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gboNutrition.Size = new System.Drawing.Size(900, 132);
            this.gboNutrition.TabIndex = 8;
            this.gboNutrition.TabStop = false;
            this.gboNutrition.Text = "NUTRITIONAL INFO";
            // 
            // lblSugar_MMI
            // 
            this.lblSugar_MMI.AutoSize = true;
            this.lblSugar_MMI.Location = new System.Drawing.Point(636, 55);
            this.lblSugar_MMI.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSugar_MMI.Name = "lblSugar_MMI";
            this.lblSugar_MMI.Size = new System.Drawing.Size(77, 25);
            this.lblSugar_MMI.TabIndex = 15;
            this.lblSugar_MMI.Text = "Sugar:";
            // 
            // lblCarbs_MMI
            // 
            this.lblCarbs_MMI.AutoSize = true;
            this.lblCarbs_MMI.Location = new System.Drawing.Point(436, 55);
            this.lblCarbs_MMI.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCarbs_MMI.Name = "lblCarbs_MMI";
            this.lblCarbs_MMI.Size = new System.Drawing.Size(77, 25);
            this.lblCarbs_MMI.TabIndex = 14;
            this.lblCarbs_MMI.Text = "Carbs:";
            // 
            // txtSugar_MMI
            // 
            this.txtSugar_MMI.Location = new System.Drawing.Point(720, 51);
            this.txtSugar_MMI.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtSugar_MMI.Name = "txtSugar_MMI";
            this.txtSugar_MMI.Size = new System.Drawing.Size(88, 30);
            this.txtSugar_MMI.TabIndex = 13;
            this.txtSugar_MMI.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtCarbs_MMI
            // 
            this.txtCarbs_MMI.Location = new System.Drawing.Point(528, 51);
            this.txtCarbs_MMI.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtCarbs_MMI.Name = "txtCarbs_MMI";
            this.txtCarbs_MMI.Size = new System.Drawing.Size(88, 30);
            this.txtCarbs_MMI.TabIndex = 12;
            this.txtCarbs_MMI.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblFat
            // 
            this.lblFat.AutoSize = true;
            this.lblFat.Location = new System.Drawing.Point(260, 51);
            this.lblFat.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFat.Name = "lblFat";
            this.lblFat.Size = new System.Drawing.Size(50, 25);
            this.lblFat.TabIndex = 11;
            this.lblFat.Text = "Fat:";
            // 
            // txtFat_MMI
            // 
            this.txtFat_MMI.Location = new System.Drawing.Point(322, 46);
            this.txtFat_MMI.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtFat_MMI.Name = "txtFat_MMI";
            this.txtFat_MMI.Size = new System.Drawing.Size(88, 30);
            this.txtFat_MMI.TabIndex = 10;
            this.txtFat_MMI.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(44, 51);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 25);
            this.label2.TabIndex = 9;
            this.label2.Text = "Calories: ";
            // 
            // txtCalories_MMI
            // 
            this.txtCalories_MMI.Location = new System.Drawing.Point(153, 46);
            this.txtCalories_MMI.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtCalories_MMI.Name = "txtCalories_MMI";
            this.txtCalories_MMI.Size = new System.Drawing.Size(88, 30);
            this.txtCalories_MMI.TabIndex = 9;
            this.txtCalories_MMI.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(66, 235);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 25);
            this.label1.TabIndex = 7;
            this.label1.Text = "Image URL:";
            // 
            // txtImageUrl
            // 
            this.txtImageUrl.Location = new System.Drawing.Point(213, 231);
            this.txtImageUrl.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtImageUrl.Name = "txtImageUrl";
            this.txtImageUrl.Size = new System.Drawing.Size(598, 30);
            this.txtImageUrl.TabIndex = 6;
            // 
            // lblPrice_MMI
            // 
            this.lblPrice_MMI.AutoSize = true;
            this.lblPrice_MMI.Location = new System.Drawing.Point(66, 174);
            this.lblPrice_MMI.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPrice_MMI.Name = "lblPrice_MMI";
            this.lblPrice_MMI.Size = new System.Drawing.Size(74, 25);
            this.lblPrice_MMI.TabIndex = 5;
            this.lblPrice_MMI.Text = "Price: ";
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(150, 169);
            this.txtPrice.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(148, 30);
            this.txtPrice.TabIndex = 4;
            this.txtPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtPrice.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPrice_KeyPress);
            // 
            // lblCategory
            // 
            this.lblCategory.AutoSize = true;
            this.lblCategory.Location = new System.Drawing.Point(66, 112);
            this.lblCategory.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCategory.Name = "lblCategory";
            this.lblCategory.Size = new System.Drawing.Size(113, 25);
            this.lblCategory.TabIndex = 3;
            this.lblCategory.Text = "Category: ";
            // 
            // cboCategory
            // 
            this.cboCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCategory.FormattingEnabled = true;
            this.cboCategory.Location = new System.Drawing.Point(200, 108);
            this.cboCategory.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cboCategory.Name = "cboCategory";
            this.cboCategory.Size = new System.Drawing.Size(298, 33);
            this.cboCategory.TabIndex = 2;
            // 
            // lblTitle_MMI
            // 
            this.lblTitle_MMI.AutoSize = true;
            this.lblTitle_MMI.Location = new System.Drawing.Point(66, 51);
            this.lblTitle_MMI.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTitle_MMI.Name = "lblTitle_MMI";
            this.lblTitle_MMI.Size = new System.Drawing.Size(67, 25);
            this.lblTitle_MMI.TabIndex = 1;
            this.lblTitle_MMI.Text = "Title: ";
            // 
            // txtTitle_MMI
            // 
            this.txtTitle_MMI.Location = new System.Drawing.Point(150, 46);
            this.txtTitle_MMI.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtTitle_MMI.Name = "txtTitle_MMI";
            this.txtTitle_MMI.Size = new System.Drawing.Size(598, 30);
            this.txtTitle_MMI.TabIndex = 0;
            // 
            // frmModifyMenuItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(240)))), ((int)(((byte)(230)))));
            this.ClientSize = new System.Drawing.Size(1026, 980);
            this.Controls.Add(this.gboEditItemDetails);
            this.Controls.Add(this.gboSelectItem);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmModifyMenuItem";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Modify Menu Item - Coffee Shop";
            this.gboSelectItem.ResumeLayout(false);
            this.gboEditItemDetails.ResumeLayout(false);
            this.gboEditItemDetails.PerformLayout();
            this.gboNutrition.ResumeLayout(false);
            this.gboNutrition.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gboSelectItem;
        private System.Windows.Forms.ComboBox cboItem;
        private System.Windows.Forms.Button btnConfirmItem;
        private System.Windows.Forms.GroupBox gboEditItemDetails;
        private System.Windows.Forms.TextBox txtTitle_MMI;
        private System.Windows.Forms.Label lblCategory;
        private System.Windows.Forms.ComboBox cboCategory;
        private System.Windows.Forms.Label lblTitle_MMI;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtImageUrl;
        private System.Windows.Forms.Label lblPrice_MMI;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.GroupBox gboNutrition;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtCalories_MMI;
        private System.Windows.Forms.TextBox txtSugar_MMI;
        private System.Windows.Forms.TextBox txtCarbs_MMI;
        private System.Windows.Forms.Label lblFat;
        private System.Windows.Forms.TextBox txtFat_MMI;
        private System.Windows.Forms.Label lblSugar_MMI;
        private System.Windows.Forms.Label lblCarbs_MMI;
        private System.Windows.Forms.TextBox txtQuantitySold;
        private System.Windows.Forms.Label lblIngredients_MMI;
        private System.Windows.Forms.TextBox txtIngredients_MMI;
        private System.Windows.Forms.Label lblQuantitySold_MMI;
        private System.Windows.Forms.Button btnCancel_MMI;
        private System.Windows.Forms.Button btnDelete_MMI;
        private System.Windows.Forms.Button btnUpdate_MMI;
    }
}