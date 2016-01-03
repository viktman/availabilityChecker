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
            this.components = new System.ComponentModel.Container();
            this.inputLink = new System.Windows.Forms.TextBox();
            this.addProduct = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.productName = new System.Windows.Forms.Label();
            this.productStatus = new System.Windows.Forms.Label();
            this.productLink = new System.Windows.Forms.LinkLabel();
            this.label4 = new System.Windows.Forms.Label();
            this.lastUpdate = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.countdown = new System.Windows.Forms.Label();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // inputLink
            // 
            this.inputLink.Location = new System.Drawing.Point(12, 12);
            this.inputLink.Name = "inputLink";
            this.inputLink.Size = new System.Drawing.Size(179, 20);
            this.inputLink.TabIndex = 0;
            // 
            // addProduct
            // 
            this.addProduct.Location = new System.Drawing.Point(197, 10);
            this.addProduct.Name = "addProduct";
            this.addProduct.Size = new System.Drawing.Size(75, 23);
            this.addProduct.TabIndex = 1;
            this.addProduct.Text = "Check";
            this.addProduct.UseVisualStyleBackColor = true;
            this.addProduct.Click += new System.EventHandler(this.addProduct_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 70F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 200F));
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.productName, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.productStatus, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.productLink, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.label4, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.lastUpdate, 1, 3);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 38);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(260, 160);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(27, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Link";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 96);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Status";
            // 
            // productName
            // 
            this.productName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.productName.AutoSize = true;
            this.productName.Location = new System.Drawing.Point(143, 14);
            this.productName.Name = "productName";
            this.productName.Size = new System.Drawing.Size(58, 13);
            this.productName.TabIndex = 0;
            this.productName.Text = "no product";
            // 
            // productStatus
            // 
            this.productStatus.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.productStatus.AutoSize = true;
            this.productStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.productStatus.ForeColor = System.Drawing.Color.Red;
            this.productStatus.Location = new System.Drawing.Point(116, 91);
            this.productStatus.Name = "productStatus";
            this.productStatus.Size = new System.Drawing.Size(111, 24);
            this.productStatus.TabIndex = 0;
            this.productStatus.Text = "no product";
            // 
            // productLink
            // 
            this.productLink.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.productLink.AutoSize = true;
            this.productLink.Location = new System.Drawing.Point(143, 55);
            this.productLink.Name = "productLink";
            this.productLink.Size = new System.Drawing.Size(58, 13);
            this.productLink.TabIndex = 1;
            this.productLink.TabStop = true;
            this.productLink.Text = "no product";
            this.productLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.productLink_LinkClicked);
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(4, 137);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Last update";
            // 
            // lastUpdate
            // 
            this.lastUpdate.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lastUpdate.AutoSize = true;
            this.lastUpdate.Location = new System.Drawing.Point(143, 137);
            this.lastUpdate.Name = "lastUpdate";
            this.lastUpdate.Size = new System.Drawing.Size(58, 13);
            this.lastUpdate.TabIndex = 0;
            this.lastUpdate.Text = "no product";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(75, 216);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 13);
            this.label5.TabIndex = 3;
            this.label5.Text = "Next update in";
            // 
            // countdown
            // 
            this.countdown.AutoSize = true;
            this.countdown.Font = new System.Drawing.Font("Consolas", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.countdown.Location = new System.Drawing.Point(68, 229);
            this.countdown.Name = "countdown";
            this.countdown.Size = new System.Drawing.Size(154, 56);
            this.countdown.TabIndex = 4;
            this.countdown.Text = "00:30";
            // 
            // timer
            // 
            this.timer.Interval = 1000;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 291);
            this.Controls.Add(this.countdown);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.addProduct);
            this.Controls.Add(this.inputLink);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
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
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lastUpdate;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label countdown;
        private System.Windows.Forms.Timer timer;
    }
}

