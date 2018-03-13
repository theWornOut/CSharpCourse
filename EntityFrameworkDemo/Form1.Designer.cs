namespace EntityFrameworkDemo
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
            this.btnRemove = new System.Windows.Forms.Button();
            this.gbDelete = new System.Windows.Forms.GroupBox();
            this.gbUpdate = new System.Windows.Forms.GroupBox();
            this.txtIdUpdate = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.txtNameUpdate = new System.Windows.Forms.TextBox();
            this.txtStockAmountUpdate = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtUnitPriceUpdate = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.gbAdd = new System.Windows.Forms.GroupBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtStockAmount = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtUnitPrice = new System.Windows.Forms.TextBox();
            this.dgvProducts = new System.Windows.Forms.DataGridView();
            this.gbDelete.SuspendLayout();
            this.gbUpdate.SuspendLayout();
            this.gbAdd.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProducts)).BeginInit();
            this.SuspendLayout();
            // 
            // btnRemove
            // 
            this.btnRemove.Location = new System.Drawing.Point(98, 17);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(134, 23);
            this.btnRemove.TabIndex = 7;
            this.btnRemove.Text = "Remove";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // gbDelete
            // 
            this.gbDelete.Controls.Add(this.btnRemove);
            this.gbDelete.Location = new System.Drawing.Point(500, 215);
            this.gbDelete.Name = "gbDelete";
            this.gbDelete.Size = new System.Drawing.Size(238, 49);
            this.gbDelete.TabIndex = 13;
            this.gbDelete.TabStop = false;
            this.gbDelete.Text = "Delete a product";
            // 
            // gbUpdate
            // 
            this.gbUpdate.Controls.Add(this.txtIdUpdate);
            this.gbUpdate.Controls.Add(this.label7);
            this.gbUpdate.Controls.Add(this.btnUpdate);
            this.gbUpdate.Controls.Add(this.txtNameUpdate);
            this.gbUpdate.Controls.Add(this.txtStockAmountUpdate);
            this.gbUpdate.Controls.Add(this.label4);
            this.gbUpdate.Controls.Add(this.label5);
            this.gbUpdate.Controls.Add(this.label6);
            this.gbUpdate.Controls.Add(this.txtUnitPriceUpdate);
            this.gbUpdate.Location = new System.Drawing.Point(256, 215);
            this.gbUpdate.Name = "gbUpdate";
            this.gbUpdate.Size = new System.Drawing.Size(238, 152);
            this.gbUpdate.TabIndex = 12;
            this.gbUpdate.TabStop = false;
            this.gbUpdate.Text = "Update a product";
            // 
            // txtIdUpdate
            // 
            this.txtIdUpdate.Location = new System.Drawing.Point(98, 19);
            this.txtIdUpdate.Name = "txtIdUpdate";
            this.txtIdUpdate.Size = new System.Drawing.Size(134, 20);
            this.txtIdUpdate.TabIndex = 9;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(18, 22);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(16, 13);
            this.label7.TabIndex = 8;
            this.label7.Text = "Id";
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(98, 123);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(134, 23);
            this.btnUpdate.TabIndex = 7;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // txtNameUpdate
            // 
            this.txtNameUpdate.Location = new System.Drawing.Point(98, 45);
            this.txtNameUpdate.Name = "txtNameUpdate";
            this.txtNameUpdate.Size = new System.Drawing.Size(134, 20);
            this.txtNameUpdate.TabIndex = 2;
            // 
            // txtStockAmountUpdate
            // 
            this.txtStockAmountUpdate.Location = new System.Drawing.Point(98, 97);
            this.txtStockAmountUpdate.Name = "txtStockAmountUpdate";
            this.txtStockAmountUpdate.Size = new System.Drawing.Size(134, 20);
            this.txtStockAmountUpdate.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(18, 48);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Name";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(18, 100);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Stock Amount";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(18, 74);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 13);
            this.label6.TabIndex = 3;
            this.label6.Text = "Unit Price";
            // 
            // txtUnitPriceUpdate
            // 
            this.txtUnitPriceUpdate.Location = new System.Drawing.Point(98, 71);
            this.txtUnitPriceUpdate.Name = "txtUnitPriceUpdate";
            this.txtUnitPriceUpdate.Size = new System.Drawing.Size(134, 20);
            this.txtUnitPriceUpdate.TabIndex = 4;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(98, 97);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(134, 23);
            this.btnAdd.TabIndex = 7;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // gbAdd
            // 
            this.gbAdd.Controls.Add(this.btnAdd);
            this.gbAdd.Controls.Add(this.txtName);
            this.gbAdd.Controls.Add(this.txtStockAmount);
            this.gbAdd.Controls.Add(this.label1);
            this.gbAdd.Controls.Add(this.label3);
            this.gbAdd.Controls.Add(this.label2);
            this.gbAdd.Controls.Add(this.txtUnitPrice);
            this.gbAdd.Location = new System.Drawing.Point(12, 215);
            this.gbAdd.Name = "gbAdd";
            this.gbAdd.Size = new System.Drawing.Size(238, 129);
            this.gbAdd.TabIndex = 11;
            this.gbAdd.TabStop = false;
            this.gbAdd.Text = "Add a product";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(98, 19);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(134, 20);
            this.txtName.TabIndex = 2;
            // 
            // txtStockAmount
            // 
            this.txtStockAmount.Location = new System.Drawing.Point(98, 71);
            this.txtStockAmount.Name = "txtStockAmount";
            this.txtStockAmount.Size = new System.Drawing.Size(134, 20);
            this.txtStockAmount.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 74);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Stock Amount";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Unit Price";
            // 
            // txtUnitPrice
            // 
            this.txtUnitPrice.Location = new System.Drawing.Point(98, 45);
            this.txtUnitPrice.Name = "txtUnitPrice";
            this.txtUnitPrice.Size = new System.Drawing.Size(134, 20);
            this.txtUnitPrice.TabIndex = 4;
            // 
            // dgvProducts
            // 
            this.dgvProducts.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProducts.Location = new System.Drawing.Point(12, 12);
            this.dgvProducts.Name = "dgvProducts";
            this.dgvProducts.Size = new System.Drawing.Size(726, 197);
            this.dgvProducts.TabIndex = 10;
            this.dgvProducts.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProducts_CellClick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(751, 371);
            this.Controls.Add(this.gbDelete);
            this.Controls.Add(this.gbUpdate);
            this.Controls.Add(this.gbAdd);
            this.Controls.Add(this.dgvProducts);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.gbDelete.ResumeLayout(false);
            this.gbUpdate.ResumeLayout(false);
            this.gbUpdate.PerformLayout();
            this.gbAdd.ResumeLayout(false);
            this.gbAdd.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProducts)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.GroupBox gbDelete;
        private System.Windows.Forms.GroupBox gbUpdate;
        private System.Windows.Forms.TextBox txtIdUpdate;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.TextBox txtNameUpdate;
        private System.Windows.Forms.TextBox txtStockAmountUpdate;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtUnitPriceUpdate;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.GroupBox gbAdd;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtStockAmount;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtUnitPrice;
        private System.Windows.Forms.DataGridView dgvProducts;
    }
}

