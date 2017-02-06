namespace Assignment2
{
    partial class SharpAuoForm
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
            this.priceLabel = new System.Windows.Forms.Label();
            this.optionsLabel = new System.Windows.Forms.Label();
            this.subTotalLabel = new System.Windows.Forms.Label();
            this.taxLabel = new System.Windows.Forms.Label();
            this.totalLabel = new System.Windows.Forms.Label();
            this.allowanceLabel = new System.Windows.Forms.Label();
            this.basePriceBox = new System.Windows.Forms.TextBox();
            this.optionsBox = new System.Windows.Forms.TextBox();
            this.subTotalBox = new System.Windows.Forms.TextBox();
            this.taxBox = new System.Windows.Forms.TextBox();
            this.allowanceBox = new System.Windows.Forms.TextBox();
            this.totalBox = new System.Windows.Forms.TextBox();
            this.itemsGroupBox = new System.Windows.Forms.GroupBox();
            this.nosCheckBox = new System.Windows.Forms.CheckBox();
            this.computerCheckBox = new System.Windows.Forms.CheckBox();
            this.leatherCheckBox = new System.Windows.Forms.CheckBox();
            this.stereoCheckBox = new System.Windows.Forms.CheckBox();
            this.exteriorGroupBox = new System.Windows.Forms.GroupBox();
            this.mattedRadioButton = new System.Windows.Forms.RadioButton();
            this.detailingRadioButton = new System.Windows.Forms.RadioButton();
            this.pearlizedRadioButton = new System.Windows.Forms.RadioButton();
            this.standardRadioButton = new System.Windows.Forms.RadioButton();
            this.calculateButton = new System.Windows.Forms.Button();
            this.clearButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.calculateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clearToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fontToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.colorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.amountDueLabel = new System.Windows.Forms.Label();
            this.amountDueBox = new System.Windows.Forms.TextBox();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.fontDialog1 = new System.Windows.Forms.FontDialog();
            this.itemsGroupBox.SuspendLayout();
            this.exteriorGroupBox.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // priceLabel
            // 
            this.priceLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.priceLabel.Location = new System.Drawing.Point(68, 40);
            this.priceLabel.Name = "priceLabel";
            this.priceLabel.Size = new System.Drawing.Size(83, 20);
            this.priceLabel.TabIndex = 0;
            this.priceLabel.Text = "Base Price :";
            // 
            // optionsLabel
            // 
            this.optionsLabel.AutoSize = true;
            this.optionsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.optionsLabel.Location = new System.Drawing.Point(28, 80);
            this.optionsLabel.Name = "optionsLabel";
            this.optionsLabel.Size = new System.Drawing.Size(123, 16);
            this.optionsLabel.TabIndex = 1;
            this.optionsLabel.Text = "Additional Options :";
            // 
            // subTotalLabel
            // 
            this.subTotalLabel.AutoSize = true;
            this.subTotalLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.subTotalLabel.Location = new System.Drawing.Point(79, 123);
            this.subTotalLabel.Name = "subTotalLabel";
            this.subTotalLabel.Size = new System.Drawing.Size(72, 16);
            this.subTotalLabel.TabIndex = 2;
            this.subTotalLabel.Text = "SubTotal : ";
            // 
            // taxLabel
            // 
            this.taxLabel.AutoSize = true;
            this.taxLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.taxLabel.Location = new System.Drawing.Point(39, 166);
            this.taxLabel.Name = "taxLabel";
            this.taxLabel.Size = new System.Drawing.Size(112, 16);
            this.taxLabel.TabIndex = 3;
            this.taxLabel.Text = "Sales Tax (13%) :";
            // 
            // totalLabel
            // 
            this.totalLabel.AutoSize = true;
            this.totalLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalLabel.Location = new System.Drawing.Point(103, 207);
            this.totalLabel.Name = "totalLabel";
            this.totalLabel.Size = new System.Drawing.Size(48, 16);
            this.totalLabel.TabIndex = 4;
            this.totalLabel.Text = "Total : ";
            // 
            // allowanceLabel
            // 
            this.allowanceLabel.AutoSize = true;
            this.allowanceLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.allowanceLabel.Location = new System.Drawing.Point(18, 247);
            this.allowanceLabel.Name = "allowanceLabel";
            this.allowanceLabel.Size = new System.Drawing.Size(133, 16);
            this.allowanceLabel.TabIndex = 5;
            this.allowanceLabel.Text = "Trade-in Allowance : ";
            // 
            // basePriceBox
            // 
            this.basePriceBox.Location = new System.Drawing.Point(174, 39);
            this.basePriceBox.Name = "basePriceBox";
            this.basePriceBox.Size = new System.Drawing.Size(126, 20);
            this.basePriceBox.TabIndex = 6;
            this.basePriceBox.TextChanged += new System.EventHandler(this.PriceBox_TextChanged);
            // 
            // optionsBox
            // 
            this.optionsBox.Location = new System.Drawing.Point(174, 79);
            this.optionsBox.Multiline = true;
            this.optionsBox.Name = "optionsBox";
            this.optionsBox.ReadOnly = true;
            this.optionsBox.Size = new System.Drawing.Size(126, 20);
            this.optionsBox.TabIndex = 7;
            this.optionsBox.TextChanged += new System.EventHandler(this.PriceBox_TextChanged);
            // 
            // subTotalBox
            // 
            this.subTotalBox.Location = new System.Drawing.Point(174, 122);
            this.subTotalBox.Name = "subTotalBox";
            this.subTotalBox.ReadOnly = true;
            this.subTotalBox.Size = new System.Drawing.Size(126, 20);
            this.subTotalBox.TabIndex = 8;
            // 
            // taxBox
            // 
            this.taxBox.Location = new System.Drawing.Point(174, 165);
            this.taxBox.Name = "taxBox";
            this.taxBox.ReadOnly = true;
            this.taxBox.Size = new System.Drawing.Size(126, 20);
            this.taxBox.TabIndex = 9;
            // 
            // allowanceBox
            // 
            this.allowanceBox.Location = new System.Drawing.Point(174, 247);
            this.allowanceBox.Name = "allowanceBox";
            this.allowanceBox.Size = new System.Drawing.Size(126, 20);
            this.allowanceBox.TabIndex = 10;
            this.allowanceBox.Text = "0";
            this.allowanceBox.TextChanged += new System.EventHandler(this.PriceBox_TextChanged);
            // 
            // totalBox
            // 
            this.totalBox.Location = new System.Drawing.Point(174, 206);
            this.totalBox.Name = "totalBox";
            this.totalBox.ReadOnly = true;
            this.totalBox.Size = new System.Drawing.Size(126, 20);
            this.totalBox.TabIndex = 11;
            // 
            // itemsGroupBox
            // 
            this.itemsGroupBox.Controls.Add(this.nosCheckBox);
            this.itemsGroupBox.Controls.Add(this.computerCheckBox);
            this.itemsGroupBox.Controls.Add(this.leatherCheckBox);
            this.itemsGroupBox.Controls.Add(this.stereoCheckBox);
            this.itemsGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.itemsGroupBox.Location = new System.Drawing.Point(328, 27);
            this.itemsGroupBox.Name = "itemsGroupBox";
            this.itemsGroupBox.Size = new System.Drawing.Size(200, 132);
            this.itemsGroupBox.TabIndex = 12;
            this.itemsGroupBox.TabStop = false;
            this.itemsGroupBox.Text = "Additional Items";
            // 
            // nosCheckBox
            // 
            this.nosCheckBox.AutoSize = true;
            this.nosCheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nosCheckBox.Location = new System.Drawing.Point(7, 103);
            this.nosCheckBox.Name = "nosCheckBox";
            this.nosCheckBox.Size = new System.Drawing.Size(50, 19);
            this.nosCheckBox.TabIndex = 3;
            this.nosCheckBox.Text = "NoS";
            this.nosCheckBox.UseVisualStyleBackColor = true;
            this.nosCheckBox.CheckedChanged += new System.EventHandler(this.CheckedChangedHandler);
            // 
            // computerCheckBox
            // 
            this.computerCheckBox.AutoSize = true;
            this.computerCheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.computerCheckBox.Location = new System.Drawing.Point(7, 78);
            this.computerCheckBox.Name = "computerCheckBox";
            this.computerCheckBox.Size = new System.Drawing.Size(141, 19);
            this.computerCheckBox.TabIndex = 2;
            this.computerCheckBox.Text = "Computer Navigation";
            this.computerCheckBox.UseVisualStyleBackColor = true;
            this.computerCheckBox.CheckedChanged += new System.EventHandler(this.CheckedChangedHandler);
            // 
            // leatherCheckBox
            // 
            this.leatherCheckBox.AutoSize = true;
            this.leatherCheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.leatherCheckBox.Location = new System.Drawing.Point(7, 53);
            this.leatherCheckBox.Name = "leatherCheckBox";
            this.leatherCheckBox.Size = new System.Drawing.Size(109, 19);
            this.leatherCheckBox.TabIndex = 1;
            this.leatherCheckBox.Text = "Leather Interior";
            this.leatherCheckBox.UseVisualStyleBackColor = true;
            this.leatherCheckBox.CheckedChanged += new System.EventHandler(this.CheckedChangedHandler);
            // 
            // stereoCheckBox
            // 
            this.stereoCheckBox.AutoSize = true;
            this.stereoCheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stereoCheckBox.Location = new System.Drawing.Point(7, 27);
            this.stereoCheckBox.Name = "stereoCheckBox";
            this.stereoCheckBox.Size = new System.Drawing.Size(105, 19);
            this.stereoCheckBox.TabIndex = 0;
            this.stereoCheckBox.Text = "Stereo System";
            this.stereoCheckBox.UseVisualStyleBackColor = true;
            this.stereoCheckBox.CheckedChanged += new System.EventHandler(this.CheckedChangedHandler);
            // 
            // exteriorGroupBox
            // 
            this.exteriorGroupBox.Controls.Add(this.mattedRadioButton);
            this.exteriorGroupBox.Controls.Add(this.detailingRadioButton);
            this.exteriorGroupBox.Controls.Add(this.pearlizedRadioButton);
            this.exteriorGroupBox.Controls.Add(this.standardRadioButton);
            this.exteriorGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exteriorGroupBox.Location = new System.Drawing.Point(328, 191);
            this.exteriorGroupBox.Name = "exteriorGroupBox";
            this.exteriorGroupBox.Size = new System.Drawing.Size(200, 135);
            this.exteriorGroupBox.TabIndex = 13;
            this.exteriorGroupBox.TabStop = false;
            this.exteriorGroupBox.Text = "Exterior Finish";
            // 
            // mattedRadioButton
            // 
            this.mattedRadioButton.AutoSize = true;
            this.mattedRadioButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mattedRadioButton.Location = new System.Drawing.Point(7, 105);
            this.mattedRadioButton.Name = "mattedRadioButton";
            this.mattedRadioButton.Size = new System.Drawing.Size(66, 19);
            this.mattedRadioButton.TabIndex = 3;
            this.mattedRadioButton.TabStop = true;
            this.mattedRadioButton.Text = "Matted ";
            this.mattedRadioButton.UseVisualStyleBackColor = true;
            this.mattedRadioButton.CheckedChanged += new System.EventHandler(this.CheckedChangedHandler);
            // 
            // detailingRadioButton
            // 
            this.detailingRadioButton.AutoSize = true;
            this.detailingRadioButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.detailingRadioButton.Location = new System.Drawing.Point(6, 80);
            this.detailingRadioButton.Name = "detailingRadioButton";
            this.detailingRadioButton.Size = new System.Drawing.Size(142, 19);
            this.detailingRadioButton.TabIndex = 2;
            this.detailingRadioButton.TabStop = true;
            this.detailingRadioButton.Text = "Customized Detailing";
            this.detailingRadioButton.UseVisualStyleBackColor = true;
            this.detailingRadioButton.CheckedChanged += new System.EventHandler(this.CheckedChangedHandler);
            // 
            // pearlizedRadioButton
            // 
            this.pearlizedRadioButton.AutoSize = true;
            this.pearlizedRadioButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pearlizedRadioButton.Location = new System.Drawing.Point(6, 55);
            this.pearlizedRadioButton.Name = "pearlizedRadioButton";
            this.pearlizedRadioButton.Size = new System.Drawing.Size(77, 19);
            this.pearlizedRadioButton.TabIndex = 1;
            this.pearlizedRadioButton.TabStop = true;
            this.pearlizedRadioButton.Text = "Pearlized";
            this.pearlizedRadioButton.UseVisualStyleBackColor = true;
            this.pearlizedRadioButton.CheckedChanged += new System.EventHandler(this.CheckedChangedHandler);
            // 
            // standardRadioButton
            // 
            this.standardRadioButton.AutoSize = true;
            this.standardRadioButton.Checked = true;
            this.standardRadioButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.standardRadioButton.Location = new System.Drawing.Point(7, 28);
            this.standardRadioButton.Name = "standardRadioButton";
            this.standardRadioButton.Size = new System.Drawing.Size(75, 19);
            this.standardRadioButton.TabIndex = 0;
            this.standardRadioButton.TabStop = true;
            this.standardRadioButton.Text = "Standard";
            this.standardRadioButton.UseVisualStyleBackColor = true;
            this.standardRadioButton.CheckedChanged += new System.EventHandler(this.CheckedChangedHandler);
            // 
            // calculateButton
            // 
            this.calculateButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.calculateButton.Location = new System.Drawing.Point(42, 350);
            this.calculateButton.Name = "calculateButton";
            this.calculateButton.Size = new System.Drawing.Size(104, 32);
            this.calculateButton.TabIndex = 14;
            this.calculateButton.Text = "Calculate";
            this.calculateButton.UseVisualStyleBackColor = true;
            this.calculateButton.Click += new System.EventHandler(this.CalculateButton_Click);
            // 
            // clearButton
            // 
            this.clearButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clearButton.Location = new System.Drawing.Point(209, 350);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(109, 32);
            this.clearButton.TabIndex = 15;
            this.clearButton.Text = "Clear";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.ClearButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitButton.Location = new System.Drawing.Point(374, 350);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(115, 32);
            this.exitButton.TabIndex = 16;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.exitToolStripMenuItem.Text = "&Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.calculateToolStripMenuItem,
            this.clearToolStripMenuItem,
            this.fontToolStripMenuItem,
            this.colorToolStripMenuItem});
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
            this.editToolStripMenuItem.Text = "&Edit";
            // 
            // calculateToolStripMenuItem
            // 
            this.calculateToolStripMenuItem.Name = "calculateToolStripMenuItem";
            this.calculateToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.calculateToolStripMenuItem.Text = "&Calculate";
            this.calculateToolStripMenuItem.Click += new System.EventHandler(this.CalculateButton_Click);
            // 
            // clearToolStripMenuItem
            // 
            this.clearToolStripMenuItem.Name = "clearToolStripMenuItem";
            this.clearToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.clearToolStripMenuItem.Text = "&Clear";
            this.clearToolStripMenuItem.Click += new System.EventHandler(this.ClearButton_Click);
            // 
            // fontToolStripMenuItem
            // 
            this.fontToolStripMenuItem.Name = "fontToolStripMenuItem";
            this.fontToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.fontToolStripMenuItem.Text = "&Font";
            this.fontToolStripMenuItem.Click += new System.EventHandler(this.fontToolStripMenuItem_Click);
            // 
            // colorToolStripMenuItem
            // 
            this.colorToolStripMenuItem.Name = "colorToolStripMenuItem";
            this.colorToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.colorToolStripMenuItem.Text = "&Color";
            this.colorToolStripMenuItem.Click += new System.EventHandler(this.colourToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "&Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.aboutToolStripMenuItem.Text = "&About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(540, 24);
            this.menuStrip1.TabIndex = 17;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // amountDueLabel
            // 
            this.amountDueLabel.AutoSize = true;
            this.amountDueLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.amountDueLabel.Location = new System.Drawing.Point(61, 292);
            this.amountDueLabel.Name = "amountDueLabel";
            this.amountDueLabel.Size = new System.Drawing.Size(90, 16);
            this.amountDueLabel.TabIndex = 18;
            this.amountDueLabel.Text = "Amount Due : ";
            // 
            // amountDueBox
            // 
            this.amountDueBox.Location = new System.Drawing.Point(174, 288);
            this.amountDueBox.Name = "amountDueBox";
            this.amountDueBox.ReadOnly = true;
            this.amountDueBox.Size = new System.Drawing.Size(126, 20);
            this.amountDueBox.TabIndex = 19;
            // 
            // SharpAuoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(540, 397);
            this.Controls.Add(this.amountDueBox);
            this.Controls.Add(this.amountDueLabel);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.calculateButton);
            this.Controls.Add(this.exteriorGroupBox);
            this.Controls.Add(this.itemsGroupBox);
            this.Controls.Add(this.totalBox);
            this.Controls.Add(this.allowanceBox);
            this.Controls.Add(this.taxBox);
            this.Controls.Add(this.subTotalBox);
            this.Controls.Add(this.optionsBox);
            this.Controls.Add(this.basePriceBox);
            this.Controls.Add(this.allowanceLabel);
            this.Controls.Add(this.totalLabel);
            this.Controls.Add(this.taxLabel);
            this.Controls.Add(this.subTotalLabel);
            this.Controls.Add(this.optionsLabel);
            this.Controls.Add(this.priceLabel);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "SharpAuoForm";
            this.Text = "Auto Center";
            this.Load += new System.EventHandler(this.SharpAuoForm_Load);
            this.itemsGroupBox.ResumeLayout(false);
            this.itemsGroupBox.PerformLayout();
            this.exteriorGroupBox.ResumeLayout(false);
            this.exteriorGroupBox.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label priceLabel;
        private System.Windows.Forms.Label optionsLabel;
        private System.Windows.Forms.Label subTotalLabel;
        private System.Windows.Forms.Label taxLabel;
        private System.Windows.Forms.Label totalLabel;
        private System.Windows.Forms.Label allowanceLabel;
        private System.Windows.Forms.TextBox basePriceBox;
        private System.Windows.Forms.TextBox optionsBox;
        private System.Windows.Forms.TextBox subTotalBox;
        private System.Windows.Forms.TextBox taxBox;
        private System.Windows.Forms.TextBox allowanceBox;
        private System.Windows.Forms.TextBox totalBox;
        private System.Windows.Forms.GroupBox itemsGroupBox;
        private System.Windows.Forms.CheckBox nosCheckBox;
        private System.Windows.Forms.CheckBox computerCheckBox;
        private System.Windows.Forms.CheckBox leatherCheckBox;
        private System.Windows.Forms.CheckBox stereoCheckBox;
        private System.Windows.Forms.GroupBox exteriorGroupBox;
        private System.Windows.Forms.RadioButton mattedRadioButton;
        private System.Windows.Forms.RadioButton detailingRadioButton;
        private System.Windows.Forms.RadioButton pearlizedRadioButton;
        private System.Windows.Forms.RadioButton standardRadioButton;
        private System.Windows.Forms.Button calculateButton;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem calculateToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clearToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fontToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem colorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.Label amountDueLabel;
        private System.Windows.Forms.TextBox amountDueBox;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.FontDialog fontDialog1;
    }
}

