namespace PansitBilao
{
    partial class AddForm
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
            this.itemNo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.quantityLabel = new System.Windows.Forms.Label();
            this.orderName = new System.Windows.Forms.TextBox();
            this.addBtn = new System.Windows.Forms.Button();
            this.cancelBtn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.qty = new System.Windows.Forms.TextBox();
            this.priceLabel = new System.Windows.Forms.Label();
            this.price = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // itemNo
            // 
            this.itemNo.Location = new System.Drawing.Point(80, 91);
            this.itemNo.Name = "itemNo";
            this.itemNo.Size = new System.Drawing.Size(195, 22);
            this.itemNo.TabIndex = 0;
            this.itemNo.TextChanged += new System.EventHandler(this.itemNo_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(77, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Item No.";
            // 
            // quantityLabel
            // 
            this.quantityLabel.AutoSize = true;
            this.quantityLabel.Location = new System.Drawing.Point(77, 121);
            this.quantityLabel.Name = "quantityLabel";
            this.quantityLabel.Size = new System.Drawing.Size(81, 16);
            this.quantityLabel.TabIndex = 3;
            this.quantityLabel.Text = "Order Name";
            // 
            // orderName
            // 
            this.orderName.Location = new System.Drawing.Point(80, 140);
            this.orderName.Name = "orderName";
            this.orderName.Size = new System.Drawing.Size(195, 22);
            this.orderName.TabIndex = 2;
            // 
            // addBtn
            // 
            this.addBtn.Location = new System.Drawing.Point(216, 336);
            this.addBtn.Name = "addBtn";
            this.addBtn.Size = new System.Drawing.Size(91, 39);
            this.addBtn.TabIndex = 4;
            this.addBtn.Text = "Proceed";
            this.addBtn.UseVisualStyleBackColor = true;
            this.addBtn.Click += new System.EventHandler(this.addBtn_Click);
            // 
            // cancelBtn
            // 
            this.cancelBtn.Location = new System.Drawing.Point(27, 336);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Size = new System.Drawing.Size(91, 39);
            this.cancelBtn.TabIndex = 5;
            this.cancelBtn.Text = "Cancel";
            this.cancelBtn.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(77, 182);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 16);
            this.label2.TabIndex = 7;
            this.label2.Text = "Quantity";
            // 
            // qty
            // 
            this.qty.Location = new System.Drawing.Point(80, 201);
            this.qty.Name = "qty";
            this.qty.Size = new System.Drawing.Size(195, 22);
            this.qty.TabIndex = 6;
            // 
            // priceLabel
            // 
            this.priceLabel.AutoSize = true;
            this.priceLabel.Location = new System.Drawing.Point(77, 240);
            this.priceLabel.Name = "priceLabel";
            this.priceLabel.Size = new System.Drawing.Size(38, 16);
            this.priceLabel.TabIndex = 9;
            this.priceLabel.Text = "Price";
            // 
            // price
            // 
            this.price.Location = new System.Drawing.Point(80, 259);
            this.price.Name = "price";
            this.price.Size = new System.Drawing.Size(195, 22);
            this.price.TabIndex = 8;
            // 
            // AddForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(357, 404);
            this.Controls.Add(this.priceLabel);
            this.Controls.Add(this.price);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.qty);
            this.Controls.Add(this.cancelBtn);
            this.Controls.Add(this.addBtn);
            this.Controls.Add(this.quantityLabel);
            this.Controls.Add(this.orderName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.itemNo);
            this.Name = "AddForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox itemNo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label quantityLabel;
        private System.Windows.Forms.TextBox orderName;
        private System.Windows.Forms.Button addBtn;
        private System.Windows.Forms.Button cancelBtn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox qty;
        private System.Windows.Forms.Label priceLabel;
        private System.Windows.Forms.TextBox price;
    }
}