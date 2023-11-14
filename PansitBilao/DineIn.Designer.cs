namespace PansitBilao
{
    partial class DineIn
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.total = new System.Windows.Forms.TextBox();
            this.cash = new System.Windows.Forms.TextBox();
            this.status = new System.Windows.Forms.TextBox();
            this.addBtn = new System.Windows.Forms.Button();
            this.cancelBtn = new System.Windows.Forms.Button();
            this.proceedBtn = new System.Windows.Forms.Button();
            this.itemTable = new System.Windows.Forms.DataGridView();
            this.itemNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.order = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.itemTable)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(76, 129);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Status";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(76, 163);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Total";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(76, 197);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Cash";
            // 
            // total
            // 
            this.total.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.total.Location = new System.Drawing.Point(127, 159);
            this.total.Name = "total";
            this.total.ReadOnly = true;
            this.total.Size = new System.Drawing.Size(148, 22);
            this.total.TabIndex = 4;
            // 
            // cash
            // 
            this.cash.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.cash.Location = new System.Drawing.Point(127, 193);
            this.cash.Name = "cash";
            this.cash.Size = new System.Drawing.Size(148, 22);
            this.cash.TabIndex = 5;
            // 
            // status
            // 
            this.status.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.status.Location = new System.Drawing.Point(127, 126);
            this.status.Name = "status";
            this.status.ReadOnly = true;
            this.status.Size = new System.Drawing.Size(148, 22);
            this.status.TabIndex = 3;
            // 
            // addBtn
            // 
            this.addBtn.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.addBtn.Location = new System.Drawing.Point(79, 265);
            this.addBtn.Name = "addBtn";
            this.addBtn.Size = new System.Drawing.Size(88, 53);
            this.addBtn.TabIndex = 6;
            this.addBtn.Text = "ADD";
            this.addBtn.UseVisualStyleBackColor = true;
            this.addBtn.Click += new System.EventHandler(this.addBtn_Click);
            // 
            // cancelBtn
            // 
            this.cancelBtn.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.cancelBtn.Location = new System.Drawing.Point(187, 265);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Size = new System.Drawing.Size(88, 53);
            this.cancelBtn.TabIndex = 7;
            this.cancelBtn.Text = "CANCEL";
            this.cancelBtn.UseVisualStyleBackColor = true;
            this.cancelBtn.Click += new System.EventHandler(this.cancelBtn_Click);
            // 
            // proceedBtn
            // 
            this.proceedBtn.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.proceedBtn.Location = new System.Drawing.Point(294, 265);
            this.proceedBtn.Name = "proceedBtn";
            this.proceedBtn.Size = new System.Drawing.Size(88, 53);
            this.proceedBtn.TabIndex = 8;
            this.proceedBtn.Text = "PROCEED";
            this.proceedBtn.UseVisualStyleBackColor = true;
            this.proceedBtn.Click += new System.EventHandler(this.proceedBtn_Click);
            // 
            // itemTable
            // 
            this.itemTable.AllowUserToAddRows = false;
            this.itemTable.AllowUserToDeleteRows = false;
            this.itemTable.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.itemTable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.itemTable.ColumnHeadersHeight = 29;
            this.itemTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.itemTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.itemNo,
            this.order,
            this.quantity,
            this.price});
            this.itemTable.Location = new System.Drawing.Point(429, 47);
            this.itemTable.Name = "itemTable";
            this.itemTable.ReadOnly = true;
            this.itemTable.RowHeadersVisible = false;
            this.itemTable.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.itemTable.RowTemplate.Height = 24;
            this.itemTable.Size = new System.Drawing.Size(453, 339);
            this.itemTable.TabIndex = 9;
            // 
            // itemNo
            // 
            this.itemNo.HeaderText = "Item No.";
            this.itemNo.MinimumWidth = 6;
            this.itemNo.Name = "itemNo";
            this.itemNo.ReadOnly = true;
            // 
            // order
            // 
            this.order.HeaderText = "Order";
            this.order.MinimumWidth = 6;
            this.order.Name = "order";
            this.order.ReadOnly = true;
            // 
            // quantity
            // 
            this.quantity.HeaderText = "Quantity";
            this.quantity.MinimumWidth = 6;
            this.quantity.Name = "quantity";
            this.quantity.ReadOnly = true;
            // 
            // price
            // 
            this.price.HeaderText = "Price";
            this.price.MinimumWidth = 6;
            this.price.Name = "price";
            this.price.ReadOnly = true;
            // 
            // DineIn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(946, 433);
            this.Controls.Add(this.itemTable);
            this.Controls.Add(this.proceedBtn);
            this.Controls.Add(this.cancelBtn);
            this.Controls.Add(this.addBtn);
            this.Controls.Add(this.cash);
            this.Controls.Add(this.total);
            this.Controls.Add(this.status);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "DineIn";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DineIn";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.itemTable)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox total;
        private System.Windows.Forms.TextBox cash;
        private System.Windows.Forms.TextBox status;
        private System.Windows.Forms.Button addBtn;
        private System.Windows.Forms.Button cancelBtn;
        private System.Windows.Forms.Button proceedBtn;
        private System.Windows.Forms.DataGridView itemTable;
        private System.Windows.Forms.DataGridViewTextBoxColumn itemNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn order;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn price;
    }
}