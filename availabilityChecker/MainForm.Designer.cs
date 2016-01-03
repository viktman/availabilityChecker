namespace availabilityChecker
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.inputLink = new System.Windows.Forms.TextBox();
            this.addProduct = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.productName = new System.Windows.Forms.Label();
            this.productStatus = new System.Windows.Forms.Label();
            this.productLink = new System.Windows.Forms.LinkLabel();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // inputLink
            // 
            this.inputLink.Location = new System.Drawing.Point(12, 12);
            this.inputLink.Name = "inputLink";
            this.inputLink.Size = new System.Drawing.Size(160, 20);
            this.inputLink.TabIndex = 0;
            // 
            // addProduct
            // 
            this.addProduct.Location = new System.Drawing.Point(197, 9);
            this.addProduct.Name = "addProduct";
            this.addProduct.Size = new System.Drawing.Size(75, 23);
            this.addProduct.TabIndex = 1;
            this.addProduct.Text = "Check";
            this.addProduct.UseVisualStyleBackColor = true;
            this.addProduct.Click += new System.EventHandler(this.addProduct_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 200F));
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.productName, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.productStatus, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.productLink, 1, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 60);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(260, 150);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(27, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Link";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 118);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Status";
            // 
            // productName
            // 
            this.productName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.productName.AutoSize = true;
            this.productName.Location = new System.Drawing.Point(131, 18);
            this.productName.Name = "productName";
            this.productName.Size = new System.Drawing.Size(58, 13);
            this.productName.TabIndex = 0;
            this.productName.Text = "no product";
            // 
            // productStatus
            // 
            this.productStatus.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.productStatus.AutoSize = true;
            this.productStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.productStatus.Location = new System.Drawing.Point(119, 117);
            this.productStatus.Name = "productStatus";
            this.productStatus.Size = new System.Drawing.Size(81, 16);
            this.productStatus.TabIndex = 0;
            this.productStatus.Text = "no product";
            // 
            // productLink
            // 
            this.productLink.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.productLink.AutoSize = true;
            this.productLink.Location = new System.Drawing.Point(131, 68);
            this.productLink.Name = "productLink";
            this.productLink.Size = new System.Drawing.Size(58, 13);
            this.productLink.TabIndex = 1;
            this.productLink.TabStop = true;
            this.productLink.Text = "no product";
            this.productLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.productLink_LinkClicked);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.addProduct);
            this.Controls.Add(this.inputLink);
            this.Name = "MainForm";
            this.Text = "Availability Checker";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox inputLink;
        protected internal System.Windows.Forms.Button addProduct;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label productName;
        private System.Windows.Forms.Label productStatus;
        private System.Windows.Forms.LinkLabel productLink;
    }
}

