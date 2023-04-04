namespace VMK_L2k_2023_03_21_DataGrid
{
    partial class EditForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; thiswise, false.</param>
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
            cbType = new ComboBox();
            tbName = new TextBox();
            nudId = new NumericUpDown();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            lblRating = new Label();
            label2 = new Label();
            label1 = new Label();
            tableLayoutPanel1 = new TableLayoutPanel();
            trBRating = new TrackBar();
            nudPrice = new NumericUpDown();
            nudCalories = new NumericUpDown();
            btnOk = new Button();
            btnCancel = new Button();
            ((System.ComponentModel.ISupportInitialize)nudId).BeginInit();
            tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)trBRating).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudPrice).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudCalories).BeginInit();
            SuspendLayout();
            // 
            // cbType
            // 
            cbType.FormattingEnabled = true;
            cbType.Location = new Point(129, 143);
            cbType.Name = "cbType";
            cbType.Size = new Size(361, 23);
            cbType.TabIndex = 9;
            // 
            // tbName
            // 
            tbName.Location = new Point(129, 51);
            tbName.Name = "tbName";
            tbName.Size = new Size(361, 23);
            tbName.TabIndex = 7;
            tbName.TextChanged += tbName_TextChanged;
            // 
            // nudId
            // 
            nudId.Location = new Point(129, 5);
            nudId.Maximum = new decimal(new int[] { 2000000000, 0, 0, 0 });
            nudId.Name = "nudId";
            nudId.Size = new Size(361, 23);
            nudId.TabIndex = 6;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(5, 232);
            label6.Name = "label6";
            label6.Size = new Size(55, 15);
            label6.TabIndex = 5;
            label6.Text = "Калории";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(5, 186);
            label5.Name = "label5";
            label5.Size = new Size(35, 15);
            label5.TabIndex = 4;
            label5.Text = "Цена";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(5, 140);
            label4.Name = "label4";
            label4.Size = new Size(63, 15);
            label4.TabIndex = 3;
            label4.Text = "Категория";
            // 
            // lblRating
            // 
            lblRating.AutoSize = true;
            lblRating.Location = new Point(5, 94);
            lblRating.Name = "lblRating";
            lblRating.Size = new Size(51, 15);
            lblRating.TabIndex = 2;
            lblRating.Text = "Рейтинг";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(5, 48);
            label2.Name = "label2";
            label2.Size = new Size(98, 15);
            label2.TabIndex = 1;
            label2.Text = "Название блюда";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(5, 2);
            label1.Name = "label1";
            label1.Size = new Size(45, 15);
            label1.TabIndex = 0;
            label1.Text = "Номер";
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanel1.CellBorderStyle = TableLayoutPanelCellBorderStyle.Outset;
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 75F));
            tableLayoutPanel1.Controls.Add(label1, 0, 0);
            tableLayoutPanel1.Controls.Add(label2, 0, 1);
            tableLayoutPanel1.Controls.Add(lblRating, 0, 2);
            tableLayoutPanel1.Controls.Add(label4, 0, 3);
            tableLayoutPanel1.Controls.Add(label5, 0, 4);
            tableLayoutPanel1.Controls.Add(label6, 0, 5);
            tableLayoutPanel1.Controls.Add(nudId, 1, 0);
            tableLayoutPanel1.Controls.Add(tbName, 1, 1);
            tableLayoutPanel1.Controls.Add(cbType, 1, 3);
            tableLayoutPanel1.Controls.Add(trBRating, 1, 2);
            tableLayoutPanel1.Controls.Add(nudPrice, 1, 4);
            tableLayoutPanel1.Controls.Add(nudCalories, 1, 5);
            tableLayoutPanel1.Location = new Point(12, 12);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 6;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 16.666666F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 16.666666F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 16.666666F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 16.666666F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 16.666666F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 16.666666F));
            tableLayoutPanel1.Size = new Size(495, 278);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // trBRating
            // 
            trBRating.LargeChange = 100;
            trBRating.Location = new Point(129, 97);
            trBRating.Maximum = 500;
            trBRating.Minimum = 100;
            trBRating.Name = "trBRating";
            trBRating.Size = new Size(361, 38);
            trBRating.TabIndex = 10;
            trBRating.TickFrequency = 50;
            trBRating.Value = 100;
            // 
            // nudPrice
            // 
            nudPrice.DecimalPlaces = 2;
            nudPrice.Location = new Point(129, 189);
            nudPrice.Maximum = new decimal(new int[] { 1000000, 0, 0, 0 });
            nudPrice.Name = "nudPrice";
            nudPrice.Size = new Size(361, 23);
            nudPrice.TabIndex = 11;
            // 
            // nudCalories
            // 
            nudCalories.Location = new Point(129, 235);
            nudCalories.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            nudCalories.Name = "nudCalories";
            nudCalories.Size = new Size(361, 23);
            nudCalories.TabIndex = 12;
            // 
            // btnOk
            // 
            btnOk.Location = new Point(17, 314);
            btnOk.Name = "btnOk";
            btnOk.Size = new Size(142, 23);
            btnOk.TabIndex = 1;
            btnOk.Text = "ОК";
            btnOk.UseVisualStyleBackColor = true;
            btnOk.Click += btnOk_Click;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(360, 314);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(142, 23);
            btnCancel.TabIndex = 2;
            btnCancel.Text = "Отмена";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // EditForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(519, 349);
            ControlBox = false;
            Controls.Add(btnCancel);
            Controls.Add(btnOk);
            Controls.Add(tableLayoutPanel1);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "EditForm";
            Text = "EditForm";
            ((System.ComponentModel.ISupportInitialize)nudId).EndInit();
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)trBRating).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudPrice).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudCalories).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private ComboBox cbType;
        private TextBox tbName;
        private NumericUpDown nudId;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label lblRating;
        private Label label2;
        private Label label1;
        private TableLayoutPanel tableLayoutPanel1;
        private TrackBar trBRating;
        private NumericUpDown nudPrice;
        private NumericUpDown nudCalories;
        private Button btnOk;
        private Button btnCancel;
    }
}