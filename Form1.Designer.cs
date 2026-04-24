namespace FindDifferentFiles
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            button1 = new Button();
            button2 = new Button();
            listBox2 = new ListBox();
            label5 = new Label();
            listBox3 = new ListBox();
            label6 = new Label();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            folderBrowserDialog1 = new FolderBrowserDialog();
            bt_start = new Button();
            listBox1 = new ListBox();
            label7 = new Label();
            label8 = new Label();
            label4 = new Label();
            label3 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            tableLayoutPanel2 = new TableLayoutPanel();
            button7 = new Button();
            button6 = new Button();
            tableLayoutPanel2.SuspendLayout();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Dock = DockStyle.Fill;
            button1.Location = new Point(1100, 2);
            button1.Margin = new Padding(2);
            button1.Name = "button1";
            button1.Size = new Size(142, 60);
            button1.TabIndex = 2;
            button1.Text = "目录一";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Dock = DockStyle.Fill;
            button2.Location = new Point(1100, 66);
            button2.Margin = new Padding(2);
            button2.Name = "button2";
            button2.Size = new Size(142, 60);
            button2.TabIndex = 2;
            button2.Text = "目录二";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // listBox2
            // 
            listBox2.Dock = DockStyle.Fill;
            listBox2.FormattingEnabled = true;
            listBox2.Location = new Point(368, 194);
            listBox2.Margin = new Padding(2);
            listBox2.Name = "listBox2";
            tableLayoutPanel2.SetRowSpan(listBox2, 6);
            listBox2.SelectionMode = SelectionMode.MultiExtended;
            listBox2.Size = new Size(362, 614);
            listBox2.TabIndex = 2;
            // 
            // label5
            // 
            label5.BackColor = Color.CornflowerBlue;
            label5.Dock = DockStyle.Fill;
            label5.Font = new Font("Microsoft YaHei UI", 10.5F, FontStyle.Bold, GraphicsUnit.Point, 134);
            label5.ForeColor = SystemColors.Control;
            label5.Location = new Point(368, 128);
            label5.Margin = new Padding(2, 0, 2, 0);
            label5.Name = "label5";
            label5.Size = new Size(362, 64);
            label5.TabIndex = 1;
            label5.Text = "目录一独有";
            label5.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // listBox3
            // 
            listBox3.Dock = DockStyle.Fill;
            listBox3.FormattingEnabled = true;
            listBox3.Location = new Point(734, 194);
            listBox3.Margin = new Padding(2);
            listBox3.Name = "listBox3";
            tableLayoutPanel2.SetRowSpan(listBox3, 6);
            listBox3.SelectionMode = SelectionMode.MultiExtended;
            listBox3.Size = new Size(362, 614);
            listBox3.TabIndex = 2;
            // 
            // label6
            // 
            label6.BackColor = Color.CadetBlue;
            label6.Dock = DockStyle.Fill;
            label6.Font = new Font("Microsoft YaHei UI", 10.5F, FontStyle.Bold, GraphicsUnit.Point, 134);
            label6.ForeColor = SystemColors.Control;
            label6.Location = new Point(734, 128);
            label6.Margin = new Padding(2, 0, 2, 0);
            label6.Name = "label6";
            label6.Size = new Size(362, 64);
            label6.TabIndex = 1;
            label6.Text = "目录二独有";
            label6.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // button3
            // 
            button3.BackColor = Color.Green;
            button3.Dock = DockStyle.Fill;
            button3.ForeColor = SystemColors.Control;
            button3.Location = new Point(1100, 194);
            button3.Margin = new Padding(2);
            button3.Name = "button3";
            button3.Size = new Size(142, 60);
            button3.TabIndex = 7;
            button3.Text = "另存相同文件";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.BackColor = Color.CornflowerBlue;
            button4.Dock = DockStyle.Fill;
            button4.ForeColor = SystemColors.Control;
            button4.Location = new Point(1100, 258);
            button4.Margin = new Padding(2);
            button4.Name = "button4";
            button4.Size = new Size(142, 60);
            button4.TabIndex = 7;
            button4.Text = "另存目录一独有";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // button5
            // 
            button5.BackColor = Color.CadetBlue;
            button5.Dock = DockStyle.Fill;
            button5.ForeColor = SystemColors.Control;
            button5.Location = new Point(1100, 322);
            button5.Margin = new Padding(2);
            button5.Name = "button5";
            button5.Size = new Size(142, 60);
            button5.TabIndex = 7;
            button5.Text = "另存目录二独有";
            button5.UseVisualStyleBackColor = false;
            button5.Click += button5_Click;
            // 
            // bt_start
            // 
            bt_start.Dock = DockStyle.Fill;
            bt_start.Location = new Point(1100, 130);
            bt_start.Margin = new Padding(2);
            bt_start.Name = "bt_start";
            bt_start.Size = new Size(142, 60);
            bt_start.TabIndex = 7;
            bt_start.Text = "开始对比";
            bt_start.UseVisualStyleBackColor = true;
            bt_start.Click += bt_start_Click;
            // 
            // listBox1
            // 
            listBox1.Dock = DockStyle.Fill;
            listBox1.FormattingEnabled = true;
            listBox1.Location = new Point(2, 194);
            listBox1.Margin = new Padding(2);
            listBox1.Name = "listBox1";
            tableLayoutPanel2.SetRowSpan(listBox1, 6);
            listBox1.SelectionMode = SelectionMode.MultiExtended;
            listBox1.Size = new Size(362, 614);
            listBox1.TabIndex = 9;
            // 
            // label7
            // 
            label7.BackColor = Color.Green;
            label7.Dock = DockStyle.Fill;
            label7.Font = new Font("Microsoft YaHei UI", 10.5F, FontStyle.Bold, GraphicsUnit.Point, 134);
            label7.ForeColor = SystemColors.Control;
            label7.Location = new Point(2, 128);
            label7.Margin = new Padding(2, 0, 2, 0);
            label7.Name = "label7";
            label7.Size = new Size(362, 64);
            label7.TabIndex = 9;
            label7.Text = "相同文件";
            label7.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = SystemColors.AppWorkspace;
            label8.Dock = DockStyle.Fill;
            label8.Location = new Point(734, 810);
            label8.Margin = new Padding(2, 0, 2, 0);
            label8.Name = "label8";
            label8.Size = new Size(362, 48);
            label8.TabIndex = 14;
            label8.Text = "文件数量";
            label8.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = SystemColors.AppWorkspace;
            label4.Dock = DockStyle.Fill;
            label4.Location = new Point(368, 810);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(362, 48);
            label4.TabIndex = 13;
            label4.Text = "文件数量";
            label4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = SystemColors.AppWorkspace;
            label3.Dock = DockStyle.Fill;
            label3.Location = new Point(2, 810);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(362, 48);
            label3.TabIndex = 12;
            label3.Text = "文件数量";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // textBox1
            // 
            textBox1.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            textBox1.BackColor = Color.CornflowerBlue;
            tableLayoutPanel2.SetColumnSpan(textBox1, 3);
            textBox1.Font = new Font("Microsoft YaHei UI", 10.5F, FontStyle.Regular, GraphicsUnit.Point, 134);
            textBox1.ForeColor = SystemColors.Control;
            textBox1.Location = new Point(2, 17);
            textBox1.Margin = new Padding(2);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(1094, 30);
            textBox1.TabIndex = 11;
            textBox1.Text = "D:\\MyCode\\CS\\TDVisionV2\\TDVision\\bin\\x64\\Debug";
            // 
            // textBox2
            // 
            textBox2.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            textBox2.BackColor = Color.CadetBlue;
            tableLayoutPanel2.SetColumnSpan(textBox2, 3);
            textBox2.Font = new Font("Microsoft YaHei UI", 10.5F, FontStyle.Regular, GraphicsUnit.Point, 134);
            textBox2.ForeColor = SystemColors.Control;
            textBox2.Location = new Point(2, 81);
            textBox2.Margin = new Padding(2);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(1094, 30);
            textBox2.TabIndex = 12;
            textBox2.Text = "D:\\MyCode\\CS\\TestPro\\2026-4\\Tensorrt_dll_750dll";
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 4;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.33333F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333359F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333359F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 144F));
            tableLayoutPanel2.Controls.Add(button7, 3, 7);
            tableLayoutPanel2.Controls.Add(button6, 3, 6);
            tableLayoutPanel2.Controls.Add(listBox3, 2, 3);
            tableLayoutPanel2.Controls.Add(listBox2, 1, 3);
            tableLayoutPanel2.Controls.Add(listBox1, 0, 3);
            tableLayoutPanel2.Controls.Add(button1, 3, 0);
            tableLayoutPanel2.Controls.Add(textBox2, 0, 1);
            tableLayoutPanel2.Controls.Add(label6, 2, 2);
            tableLayoutPanel2.Controls.Add(label7, 0, 2);
            tableLayoutPanel2.Controls.Add(label5, 1, 2);
            tableLayoutPanel2.Controls.Add(button2, 3, 1);
            tableLayoutPanel2.Controls.Add(textBox1, 0, 0);
            tableLayoutPanel2.Controls.Add(bt_start, 3, 2);
            tableLayoutPanel2.Controls.Add(button3, 3, 3);
            tableLayoutPanel2.Controls.Add(button5, 3, 5);
            tableLayoutPanel2.Controls.Add(button4, 3, 4);
            tableLayoutPanel2.Controls.Add(label8, 2, 9);
            tableLayoutPanel2.Controls.Add(label4, 1, 9);
            tableLayoutPanel2.Controls.Add(label3, 0, 9);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(0, 0);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 10;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 64F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 64F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 64F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 64F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 64F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 64F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 64F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 64F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 48F));
            tableLayoutPanel2.Size = new Size(1244, 858);
            tableLayoutPanel2.TabIndex = 13;
            // 
            // button7
            // 
            button7.BackColor = Color.PaleVioletRed;
            button7.Dock = DockStyle.Fill;
            button7.ForeColor = SystemColors.Control;
            button7.Location = new Point(1100, 450);
            button7.Margin = new Padding(2);
            button7.Name = "button7";
            button7.Size = new Size(142, 60);
            button7.TabIndex = 16;
            button7.Text = "移除目录二相同";
            button7.UseVisualStyleBackColor = false;
            button7.Click += button7_Click;
            // 
            // button6
            // 
            button6.BackColor = Color.PaleVioletRed;
            button6.Dock = DockStyle.Fill;
            button6.ForeColor = SystemColors.Control;
            button6.Location = new Point(1100, 386);
            button6.Margin = new Padding(2);
            button6.Name = "button6";
            button6.Size = new Size(142, 60);
            button6.TabIndex = 15;
            button6.Text = "移除目录一相同";
            button6.UseVisualStyleBackColor = false;
            button6.Click += button6_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1244, 858);
            Controls.Add(tableLayoutPanel2);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(2);
            Name = "Form1";
            Text = "目录文件差异对比工具";
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Button button1;
        private Button button2;
        private Label label5;
        private Label label6;
        private Button button3;
        private Button button4;
        private Button button5;
        private FolderBrowserDialog folderBrowserDialog1;
        private Button bt_start;
        private ListBox listBox2;
        private ListBox listBox3;
        private ListBox listBox1;
        private Label label7;
        private Label label8;
        private Label label4;
        private TextBox textBox1;
        private TextBox textBox2;
        private Label label3;
        private TableLayoutPanel tableLayoutPanel2;
        private Button button7;
        private Button button6;
    }
}
