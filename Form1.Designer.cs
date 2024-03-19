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
            panel1 = new Panel();
            listBox1 = new ListBox();
            label7 = new Label();
            tableLayoutPanel1 = new TableLayoutPanel();
            label8 = new Label();
            label4 = new Label();
            panel2 = new Panel();
            panel3 = new Panel();
            label3 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            panel1.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(1347, 32);
            button1.Name = "button1";
            button1.Size = new Size(112, 43);
            button1.TabIndex = 2;
            button1.Text = "目录一";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(1347, 92);
            button2.Name = "button2";
            button2.Size = new Size(112, 43);
            button2.TabIndex = 2;
            button2.Text = "目录二";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // listBox2
            // 
            listBox2.Dock = DockStyle.Fill;
            listBox2.FormattingEnabled = true;
            listBox2.ItemHeight = 24;
            listBox2.Location = new Point(0, 0);
            listBox2.Name = "listBox2";
            listBox2.SelectionMode = SelectionMode.MultiExtended;
            listBox2.Size = new Size(395, 767);
            listBox2.TabIndex = 2;
            // 
            // label5
            // 
            label5.BackColor = Color.CornflowerBlue;
            label5.Dock = DockStyle.Fill;
            label5.Font = new Font("Microsoft YaHei UI", 10.5F, FontStyle.Bold, GraphicsUnit.Point, 134);
            label5.ForeColor = SystemColors.Control;
            label5.Location = new Point(404, 0);
            label5.Name = "label5";
            label5.Size = new Size(395, 36);
            label5.TabIndex = 1;
            label5.Text = "目录一独有";
            label5.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // listBox3
            // 
            listBox3.Dock = DockStyle.Fill;
            listBox3.FormattingEnabled = true;
            listBox3.ItemHeight = 24;
            listBox3.Location = new Point(0, 0);
            listBox3.Name = "listBox3";
            listBox3.SelectionMode = SelectionMode.MultiExtended;
            listBox3.Size = new Size(396, 767);
            listBox3.TabIndex = 2;
            // 
            // label6
            // 
            label6.BackColor = Color.CadetBlue;
            label6.Dock = DockStyle.Fill;
            label6.Font = new Font("Microsoft YaHei UI", 10.5F, FontStyle.Bold, GraphicsUnit.Point, 134);
            label6.ForeColor = SystemColors.Control;
            label6.Location = new Point(805, 0);
            label6.Name = "label6";
            label6.Size = new Size(396, 36);
            label6.TabIndex = 1;
            label6.Text = "目录二独有";
            label6.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // button3
            // 
            button3.BackColor = Color.Green;
            button3.ForeColor = SystemColors.Control;
            button3.Location = new Point(1311, 302);
            button3.Name = "button3";
            button3.Size = new Size(148, 54);
            button3.TabIndex = 7;
            button3.Text = "另存相同文件";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.BackColor = Color.CornflowerBlue;
            button4.ForeColor = SystemColors.Control;
            button4.Location = new Point(1311, 409);
            button4.Name = "button4";
            button4.Size = new Size(148, 54);
            button4.TabIndex = 7;
            button4.Text = "另存目录一独有";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // button5
            // 
            button5.BackColor = Color.CadetBlue;
            button5.ForeColor = SystemColors.Control;
            button5.Location = new Point(1311, 524);
            button5.Name = "button5";
            button5.Size = new Size(148, 54);
            button5.TabIndex = 7;
            button5.Text = "另存目录二独有";
            button5.UseVisualStyleBackColor = false;
            button5.Click += button5_Click;
            // 
            // bt_start
            // 
            bt_start.Location = new Point(1311, 204);
            bt_start.Name = "bt_start";
            bt_start.Size = new Size(148, 54);
            bt_start.TabIndex = 7;
            bt_start.Text = "开始对比";
            bt_start.UseVisualStyleBackColor = true;
            bt_start.Click += bt_start_Click;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.Window;
            panel1.Controls.Add(listBox1);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(3, 39);
            panel1.Name = "panel1";
            panel1.Size = new Size(395, 767);
            panel1.TabIndex = 8;
            // 
            // listBox1
            // 
            listBox1.Dock = DockStyle.Fill;
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 24;
            listBox1.Location = new Point(0, 0);
            listBox1.Name = "listBox1";
            listBox1.SelectionMode = SelectionMode.MultiExtended;
            listBox1.Size = new Size(395, 767);
            listBox1.TabIndex = 9;
            // 
            // label7
            // 
            label7.BackColor = Color.Green;
            label7.Dock = DockStyle.Fill;
            label7.Font = new Font("Microsoft YaHei UI", 10.5F, FontStyle.Bold, GraphicsUnit.Point, 134);
            label7.ForeColor = SystemColors.Control;
            label7.Location = new Point(3, 0);
            label7.Name = "label7";
            label7.Size = new Size(395, 36);
            label7.TabIndex = 9;
            label7.Text = "相同文件";
            label7.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 3;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.33333F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333359F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333359F));
            tableLayoutPanel1.Controls.Add(label8, 2, 2);
            tableLayoutPanel1.Controls.Add(label4, 1, 2);
            tableLayoutPanel1.Controls.Add(label7, 0, 0);
            tableLayoutPanel1.Controls.Add(label6, 2, 0);
            tableLayoutPanel1.Controls.Add(label5, 1, 0);
            tableLayoutPanel1.Controls.Add(panel1, 0, 1);
            tableLayoutPanel1.Controls.Add(panel2, 1, 1);
            tableLayoutPanel1.Controls.Add(panel3, 2, 1);
            tableLayoutPanel1.Controls.Add(label3, 0, 2);
            tableLayoutPanel1.Location = new Point(70, 156);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 3;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 36F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 36F));
            tableLayoutPanel1.Size = new Size(1204, 843);
            tableLayoutPanel1.TabIndex = 10;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = SystemColors.AppWorkspace;
            label8.Dock = DockStyle.Fill;
            label8.Location = new Point(805, 809);
            label8.Name = "label8";
            label8.Size = new Size(396, 36);
            label8.TabIndex = 14;
            label8.Text = "文件数量";
            label8.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = SystemColors.AppWorkspace;
            label4.Dock = DockStyle.Fill;
            label4.Location = new Point(404, 809);
            label4.Name = "label4";
            label4.Size = new Size(395, 36);
            label4.TabIndex = 13;
            label4.Text = "文件数量";
            label4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            panel2.Controls.Add(listBox2);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(404, 39);
            panel2.Name = "panel2";
            panel2.Size = new Size(395, 767);
            panel2.TabIndex = 10;
            // 
            // panel3
            // 
            panel3.Controls.Add(listBox3);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(805, 39);
            panel3.Name = "panel3";
            panel3.Size = new Size(396, 767);
            panel3.TabIndex = 11;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = SystemColors.AppWorkspace;
            label3.Dock = DockStyle.Fill;
            label3.Location = new Point(3, 809);
            label3.Name = "label3";
            label3.Size = new Size(395, 36);
            label3.TabIndex = 12;
            label3.Text = "文件数量";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.CornflowerBlue;
            textBox1.Font = new Font("Microsoft YaHei UI", 10.5F, FontStyle.Regular, GraphicsUnit.Point, 134);
            textBox1.ForeColor = SystemColors.Control;
            textBox1.Location = new Point(73, 35);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(1201, 34);
            textBox1.TabIndex = 11;
            textBox1.Text = "D:\\MyPrograms\\Vision Master 4.3.0\\VisionMaster4.3.0\\Applications\\PublicFile\\x64";
            // 
            // textBox2
            // 
            textBox2.BackColor = Color.CadetBlue;
            textBox2.Font = new Font("Microsoft YaHei UI", 10.5F, FontStyle.Regular, GraphicsUnit.Point, 134);
            textBox2.ForeColor = SystemColors.Control;
            textBox2.Location = new Point(70, 95);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(1201, 34);
            textBox2.TabIndex = 12;
            textBox2.Text = "F:\\海康\\HTAI及其依赖-2024年3月14日\\加速版x64\\x64";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(11F, 24F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1520, 1029);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(tableLayoutPanel1);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(bt_start);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form1";
            Text = "目录文件差异对比工具";
            panel1.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel3.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
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
        private Panel panel1;
        private ListBox listBox2;
        private ListBox listBox3;
        private ListBox listBox1;
        private Label label7;
        private TableLayoutPanel tableLayoutPanel1;
        private Panel panel2;
        private Panel panel3;
        private Label label8;
        private Label label4;
        private TextBox textBox1;
        private TextBox textBox2;
        private Label label3;
    }
}
