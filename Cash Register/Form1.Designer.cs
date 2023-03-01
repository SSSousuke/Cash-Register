namespace Cash_Register
{
    partial class Form1
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.numOfTunaLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.numOfSalmonLabel = new System.Windows.Forms.Label();
            this.numOfShrimp = new System.Windows.Forms.Label();
            this.numOfTunaInput = new System.Windows.Forms.TextBox();
            this.numOfSalmonInput = new System.Windows.Forms.TextBox();
            this.numOfShrimpInput = new System.Windows.Forms.TextBox();
            this.calculateButton = new System.Windows.Forms.Button();
            this.TotalLabel = new System.Windows.Forms.Label();
            this.TaxLabel = new System.Windows.Forms.Label();
            this.subTotalLabel = new System.Windows.Forms.Label();
            this.totalOutput = new System.Windows.Forms.Label();
            this.taxOutput = new System.Windows.Forms.Label();
            this.subTotalOutput = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tendredLabel = new System.Windows.Forms.Label();
            this.tendredInput = new System.Windows.Forms.TextBox();
            this.changeButton = new System.Windows.Forms.Button();
            this.changeOutput = new System.Windows.Forms.Label();
            this.changeLabel = new System.Windows.Forms.Label();
            this.printButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.receiptWordOutput = new System.Windows.Forms.Label();
            this.receiptTitle = new System.Windows.Forms.Label();
            this.receiptNumOutput = new System.Windows.Forms.Label();
            this.neworderButton = new System.Windows.Forms.Button();
            this.errorLabel1 = new System.Windows.Forms.Label();
            this.errorLabel2 = new System.Windows.Forms.Label();
            this.errorLabel3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.pictureBox1.Image = global::Cash_Register.Properties.Resources.programming3;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(677, 45);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // numOfTunaLabel
            // 
            this.numOfTunaLabel.AutoSize = true;
            this.numOfTunaLabel.BackColor = System.Drawing.Color.Wheat;
            this.numOfTunaLabel.Font = new System.Drawing.Font("HGS行書体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.numOfTunaLabel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.numOfTunaLabel.Location = new System.Drawing.Point(35, 85);
            this.numOfTunaLabel.Name = "numOfTunaLabel";
            this.numOfTunaLabel.Size = new System.Drawing.Size(141, 20);
            this.numOfTunaLabel.TabIndex = 2;
            this.numOfTunaLabel.Text = "Number of Tuna";
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Wheat;
            this.label1.Location = new System.Drawing.Point(0, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(687, 596);
            this.label1.TabIndex = 1;
            // 
            // numOfSalmonLabel
            // 
            this.numOfSalmonLabel.AutoSize = true;
            this.numOfSalmonLabel.BackColor = System.Drawing.Color.Wheat;
            this.numOfSalmonLabel.Font = new System.Drawing.Font("HGS行書体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.numOfSalmonLabel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.numOfSalmonLabel.Location = new System.Drawing.Point(35, 118);
            this.numOfSalmonLabel.Name = "numOfSalmonLabel";
            this.numOfSalmonLabel.Size = new System.Drawing.Size(159, 20);
            this.numOfSalmonLabel.TabIndex = 3;
            this.numOfSalmonLabel.Text = "Number of Salmon";
            // 
            // numOfShrimp
            // 
            this.numOfShrimp.AutoSize = true;
            this.numOfShrimp.BackColor = System.Drawing.Color.Wheat;
            this.numOfShrimp.Font = new System.Drawing.Font("HGS行書体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.numOfShrimp.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.numOfShrimp.Location = new System.Drawing.Point(35, 149);
            this.numOfShrimp.Name = "numOfShrimp";
            this.numOfShrimp.Size = new System.Drawing.Size(155, 20);
            this.numOfShrimp.TabIndex = 4;
            this.numOfShrimp.Text = "Number of Shrimp";
            // 
            // numOfTunaInput
            // 
            this.numOfTunaInput.Location = new System.Drawing.Point(208, 86);
            this.numOfTunaInput.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.numOfTunaInput.Name = "numOfTunaInput";
            this.numOfTunaInput.Size = new System.Drawing.Size(63, 22);
            this.numOfTunaInput.TabIndex = 5;
            this.numOfTunaInput.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // numOfSalmonInput
            // 
            this.numOfSalmonInput.Location = new System.Drawing.Point(208, 118);
            this.numOfSalmonInput.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.numOfSalmonInput.Name = "numOfSalmonInput";
            this.numOfSalmonInput.Size = new System.Drawing.Size(63, 22);
            this.numOfSalmonInput.TabIndex = 6;
            this.numOfSalmonInput.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // numOfShrimpInput
            // 
            this.numOfShrimpInput.Location = new System.Drawing.Point(208, 150);
            this.numOfShrimpInput.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.numOfShrimpInput.Name = "numOfShrimpInput";
            this.numOfShrimpInput.Size = new System.Drawing.Size(63, 22);
            this.numOfShrimpInput.TabIndex = 7;
            this.numOfShrimpInput.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // calculateButton
            // 
            this.calculateButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.calculateButton.BackColor = System.Drawing.Color.White;
            this.calculateButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.calculateButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.calculateButton.Font = new System.Drawing.Font("MS UI Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.calculateButton.Location = new System.Drawing.Point(37, 189);
            this.calculateButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.calculateButton.Name = "calculateButton";
            this.calculateButton.Size = new System.Drawing.Size(233, 31);
            this.calculateButton.TabIndex = 8;
            this.calculateButton.Text = "Calculate Totals";
            this.calculateButton.UseVisualStyleBackColor = false;
            this.calculateButton.Click += new System.EventHandler(this.calculateButton_Click);
            // 
            // TotalLabel
            // 
            this.TotalLabel.AutoSize = true;
            this.TotalLabel.BackColor = System.Drawing.Color.Wheat;
            this.TotalLabel.Font = new System.Drawing.Font("HGS行書体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.TotalLabel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.TotalLabel.Location = new System.Drawing.Point(35, 311);
            this.TotalLabel.Name = "TotalLabel";
            this.TotalLabel.Size = new System.Drawing.Size(49, 20);
            this.TotalLabel.TabIndex = 11;
            this.TotalLabel.Text = "Total";
            // 
            // TaxLabel
            // 
            this.TaxLabel.AutoSize = true;
            this.TaxLabel.BackColor = System.Drawing.Color.Wheat;
            this.TaxLabel.Font = new System.Drawing.Font("HGS行書体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.TaxLabel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.TaxLabel.Location = new System.Drawing.Point(35, 279);
            this.TaxLabel.Name = "TaxLabel";
            this.TaxLabel.Size = new System.Drawing.Size(39, 20);
            this.TaxLabel.TabIndex = 10;
            this.TaxLabel.Text = "Tax";
            // 
            // subTotalLabel
            // 
            this.subTotalLabel.AutoSize = true;
            this.subTotalLabel.BackColor = System.Drawing.Color.Wheat;
            this.subTotalLabel.Font = new System.Drawing.Font("HGS行書体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.subTotalLabel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.subTotalLabel.Location = new System.Drawing.Point(35, 248);
            this.subTotalLabel.Name = "subTotalLabel";
            this.subTotalLabel.Size = new System.Drawing.Size(86, 20);
            this.subTotalLabel.TabIndex = 9;
            this.subTotalLabel.Text = "Sub Total";
            // 
            // totalOutput
            // 
            this.totalOutput.AccessibleRole = System.Windows.Forms.AccessibleRole.Equation;
            this.totalOutput.BackColor = System.Drawing.Color.Wheat;
            this.totalOutput.Font = new System.Drawing.Font("HGS行書体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.totalOutput.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.totalOutput.Location = new System.Drawing.Point(171, 311);
            this.totalOutput.Name = "totalOutput";
            this.totalOutput.Size = new System.Drawing.Size(101, 20);
            this.totalOutput.TabIndex = 14;
            this.totalOutput.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // taxOutput
            // 
            this.taxOutput.AccessibleRole = System.Windows.Forms.AccessibleRole.Equation;
            this.taxOutput.BackColor = System.Drawing.Color.Wheat;
            this.taxOutput.Font = new System.Drawing.Font("HGS行書体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.taxOutput.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.taxOutput.Location = new System.Drawing.Point(171, 279);
            this.taxOutput.Name = "taxOutput";
            this.taxOutput.Size = new System.Drawing.Size(101, 20);
            this.taxOutput.TabIndex = 13;
            this.taxOutput.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // subTotalOutput
            // 
            this.subTotalOutput.AccessibleRole = System.Windows.Forms.AccessibleRole.Equation;
            this.subTotalOutput.BackColor = System.Drawing.Color.Wheat;
            this.subTotalOutput.Font = new System.Drawing.Font("HGS行書体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.subTotalOutput.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.subTotalOutput.Location = new System.Drawing.Point(165, 248);
            this.subTotalOutput.Name = "subTotalOutput";
            this.subTotalOutput.Size = new System.Drawing.Size(105, 20);
            this.subTotalOutput.TabIndex = 12;
            this.subTotalOutput.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label3
            // 
            this.label3.AccessibleRole = System.Windows.Forms.AccessibleRole.Equation;
            this.label3.BackColor = System.Drawing.Color.DimGray;
            this.label3.Font = new System.Drawing.Font("HGS行書体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Location = new System.Drawing.Point(37, 362);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(233, 10);
            this.label3.TabIndex = 16;
            // 
            // tendredLabel
            // 
            this.tendredLabel.AutoSize = true;
            this.tendredLabel.BackColor = System.Drawing.Color.Wheat;
            this.tendredLabel.Font = new System.Drawing.Font("HGS行書体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.tendredLabel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.tendredLabel.Location = new System.Drawing.Point(35, 390);
            this.tendredLabel.Name = "tendredLabel";
            this.tendredLabel.Size = new System.Drawing.Size(77, 20);
            this.tendredLabel.TabIndex = 17;
            this.tendredLabel.Text = "Tendred";
            // 
            // tendredInput
            // 
            this.tendredInput.Location = new System.Drawing.Point(208, 391);
            this.tendredInput.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tendredInput.Name = "tendredInput";
            this.tendredInput.Size = new System.Drawing.Size(63, 22);
            this.tendredInput.TabIndex = 18;
            this.tendredInput.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // changeButton
            // 
            this.changeButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.changeButton.BackColor = System.Drawing.Color.White;
            this.changeButton.Enabled = false;
            this.changeButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.changeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.changeButton.Font = new System.Drawing.Font("MS UI Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.changeButton.Location = new System.Drawing.Point(37, 429);
            this.changeButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.changeButton.Name = "changeButton";
            this.changeButton.Size = new System.Drawing.Size(233, 31);
            this.changeButton.TabIndex = 19;
            this.changeButton.Text = "Calculate Change";
            this.changeButton.UseVisualStyleBackColor = false;
            this.changeButton.Click += new System.EventHandler(this.changeButton_Click);
            // 
            // changeOutput
            // 
            this.changeOutput.AccessibleRole = System.Windows.Forms.AccessibleRole.Equation;
            this.changeOutput.BackColor = System.Drawing.Color.Wheat;
            this.changeOutput.Font = new System.Drawing.Font("HGS行書体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.changeOutput.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.changeOutput.Location = new System.Drawing.Point(173, 476);
            this.changeOutput.Name = "changeOutput";
            this.changeOutput.Size = new System.Drawing.Size(97, 20);
            this.changeOutput.TabIndex = 21;
            this.changeOutput.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // changeLabel
            // 
            this.changeLabel.AutoSize = true;
            this.changeLabel.BackColor = System.Drawing.Color.Wheat;
            this.changeLabel.Font = new System.Drawing.Font("HGS行書体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.changeLabel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.changeLabel.Location = new System.Drawing.Point(35, 476);
            this.changeLabel.Name = "changeLabel";
            this.changeLabel.Size = new System.Drawing.Size(69, 20);
            this.changeLabel.TabIndex = 20;
            this.changeLabel.Text = "Change";
            // 
            // printButton
            // 
            this.printButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.printButton.BackColor = System.Drawing.Color.White;
            this.printButton.Enabled = false;
            this.printButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.printButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.printButton.Font = new System.Drawing.Font("MS UI Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.printButton.Location = new System.Drawing.Point(37, 511);
            this.printButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.printButton.Name = "printButton";
            this.printButton.Size = new System.Drawing.Size(233, 31);
            this.printButton.TabIndex = 22;
            this.printButton.Text = "Print Receipt";
            this.printButton.UseVisualStyleBackColor = false;
            this.printButton.Click += new System.EventHandler(this.printButton_Click);
            // 
            // label2
            // 
            this.label2.AccessibleRole = System.Windows.Forms.AccessibleRole.Equation;
            this.label2.BackColor = System.Drawing.Color.FloralWhite;
            this.label2.Font = new System.Drawing.Font("HGS行書体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(333, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(308, 410);
            this.label2.TabIndex = 23;
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // receiptWordOutput
            // 
            this.receiptWordOutput.AccessibleRole = System.Windows.Forms.AccessibleRole.Equation;
            this.receiptWordOutput.BackColor = System.Drawing.Color.FloralWhite;
            this.receiptWordOutput.Font = new System.Drawing.Font("HGS行書体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.receiptWordOutput.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.receiptWordOutput.Location = new System.Drawing.Point(352, 141);
            this.receiptWordOutput.Name = "receiptWordOutput";
            this.receiptWordOutput.Size = new System.Drawing.Size(236, 342);
            this.receiptWordOutput.TabIndex = 24;
            // 
            // receiptTitle
            // 
            this.receiptTitle.AccessibleRole = System.Windows.Forms.AccessibleRole.Equation;
            this.receiptTitle.BackColor = System.Drawing.Color.FloralWhite;
            this.receiptTitle.Font = new System.Drawing.Font("HGS行書体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.receiptTitle.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.receiptTitle.Location = new System.Drawing.Point(379, 99);
            this.receiptTitle.Name = "receiptTitle";
            this.receiptTitle.Size = new System.Drawing.Size(221, 25);
            this.receiptTitle.TabIndex = 25;
            this.receiptTitle.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // receiptNumOutput
            // 
            this.receiptNumOutput.AccessibleRole = System.Windows.Forms.AccessibleRole.Equation;
            this.receiptNumOutput.BackColor = System.Drawing.Color.FloralWhite;
            this.receiptNumOutput.Font = new System.Drawing.Font("HGS行書体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.receiptNumOutput.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.receiptNumOutput.Location = new System.Drawing.Point(489, 200);
            this.receiptNumOutput.Name = "receiptNumOutput";
            this.receiptNumOutput.Size = new System.Drawing.Size(99, 211);
            this.receiptNumOutput.TabIndex = 26;
            this.receiptNumOutput.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // neworderButton
            // 
            this.neworderButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.neworderButton.BackColor = System.Drawing.Color.White;
            this.neworderButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.neworderButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.neworderButton.Font = new System.Drawing.Font("MS UI Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.neworderButton.Location = new System.Drawing.Point(337, 511);
            this.neworderButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.neworderButton.Name = "neworderButton";
            this.neworderButton.Size = new System.Drawing.Size(304, 31);
            this.neworderButton.TabIndex = 27;
            this.neworderButton.Text = "New Order";
            this.neworderButton.UseVisualStyleBackColor = false;
            this.neworderButton.Click += new System.EventHandler(this.neworderButton_Click);
            // 
            // errorLabel1
            // 
            this.errorLabel1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.errorLabel1.Font = new System.Drawing.Font("Trebuchet MS", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.errorLabel1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.errorLabel1.Location = new System.Drawing.Point(291, 86);
            this.errorLabel1.Name = "errorLabel1";
            this.errorLabel1.Size = new System.Drawing.Size(240, 104);
            this.errorLabel1.TabIndex = 28;
            this.errorLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.errorLabel1.Visible = false;
            // 
            // errorLabel2
            // 
            this.errorLabel2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.errorLabel2.Font = new System.Drawing.Font("Trebuchet MS", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.errorLabel2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.errorLabel2.Location = new System.Drawing.Point(291, 362);
            this.errorLabel2.Name = "errorLabel2";
            this.errorLabel2.Size = new System.Drawing.Size(220, 112);
            this.errorLabel2.TabIndex = 29;
            this.errorLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.errorLabel2.Visible = false;
            // 
            // errorLabel3
            // 
            this.errorLabel3.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.errorLabel3.Font = new System.Drawing.Font("Trebuchet MS", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.errorLabel3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.errorLabel3.Location = new System.Drawing.Point(291, 362);
            this.errorLabel3.Name = "errorLabel3";
            this.errorLabel3.Size = new System.Drawing.Size(220, 112);
            this.errorLabel3.TabIndex = 30;
            this.errorLabel3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.errorLabel3.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(677, 608);
            this.Controls.Add(this.errorLabel3);
            this.Controls.Add(this.errorLabel2);
            this.Controls.Add(this.errorLabel1);
            this.Controls.Add(this.neworderButton);
            this.Controls.Add(this.receiptNumOutput);
            this.Controls.Add(this.receiptTitle);
            this.Controls.Add(this.receiptWordOutput);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.printButton);
            this.Controls.Add(this.changeOutput);
            this.Controls.Add(this.changeLabel);
            this.Controls.Add(this.changeButton);
            this.Controls.Add(this.tendredInput);
            this.Controls.Add(this.tendredLabel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.totalOutput);
            this.Controls.Add(this.taxOutput);
            this.Controls.Add(this.subTotalOutput);
            this.Controls.Add(this.TotalLabel);
            this.Controls.Add(this.TaxLabel);
            this.Controls.Add(this.subTotalLabel);
            this.Controls.Add(this.calculateButton);
            this.Controls.Add(this.numOfShrimpInput);
            this.Controls.Add(this.numOfSalmonInput);
            this.Controls.Add(this.numOfTunaInput);
            this.Controls.Add(this.numOfShrimp);
            this.Controls.Add(this.numOfSalmonLabel);
            this.Controls.Add(this.numOfTunaLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label numOfTunaLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label numOfSalmonLabel;
        private System.Windows.Forms.Label numOfShrimp;
        private System.Windows.Forms.TextBox numOfTunaInput;
        private System.Windows.Forms.TextBox numOfSalmonInput;
        private System.Windows.Forms.TextBox numOfShrimpInput;
        private System.Windows.Forms.Button calculateButton;
        private System.Windows.Forms.Label TotalLabel;
        private System.Windows.Forms.Label TaxLabel;
        private System.Windows.Forms.Label subTotalLabel;
        private System.Windows.Forms.Label totalOutput;
        private System.Windows.Forms.Label taxOutput;
        private System.Windows.Forms.Label subTotalOutput;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label tendredLabel;
        private System.Windows.Forms.TextBox tendredInput;
        private System.Windows.Forms.Button changeButton;
        private System.Windows.Forms.Label changeOutput;
        private System.Windows.Forms.Label changeLabel;
        private System.Windows.Forms.Button printButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label receiptWordOutput;
        private System.Windows.Forms.Label receiptTitle;
        private System.Windows.Forms.Label receiptNumOutput;
        private System.Windows.Forms.Button neworderButton;
        private System.Windows.Forms.Label errorLabel1;
        private System.Windows.Forms.Label errorLabel2;
        private System.Windows.Forms.Label errorLabel3;
    }
}

