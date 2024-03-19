using FindDifferentFiles.Properties;

namespace FindDifferentFiles
{
    public partial class Form1 : Form
    {
        string Floder1 = "";
        string Floder2 = "";

        bool flag = false;

        List<string> List1 = new List<string>();
        List<string> List2 = new List<string>();
        List<string> List3 = new List<string>();

        public enum MyStruct
        {
            ONLY_PATHONE,
            ONLY_PATHTWO,
            BOTH_ALL
        };

        public Form1()
        {
            InitializeComponent();
            this.Icon = Resources.favicon__1_;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            folderBrowserDialog1.SelectedPath = Floder1;
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                textBox1.Text = folderBrowserDialog1.SelectedPath;
                Floder1 = folderBrowserDialog1.SelectedPath;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            folderBrowserDialog1.SelectedPath = Floder2;
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                textBox2.Text = folderBrowserDialog1.SelectedPath;
                Floder2 = folderBrowserDialog1.SelectedPath;
            }
        }

        private void bt_start_Click(object sender, EventArgs e)
        {
            flag = true;

            this.listBox1.Items.Clear();
            this.listBox2.Items.Clear();
            this.listBox3.Items.Clear();
            int c1 = 0, c2 = 0, c3 = 0;

            List1.Clear();
            List2.Clear();
            List3.Clear();

            // ��ͬ�ļ�
            List1 = FindDifferentFiles(textBox1.Text, textBox2.Text, MyStruct.BOTH_ALL);
            List1.Sort();
            foreach (var fileName in List1)
            {
                this.listBox1.Items.Add(fileName);
                c1++;
            }

            // ����������·��1
            List2 = FindDifferentFiles(textBox1.Text, textBox2.Text, MyStruct.ONLY_PATHONE);
            List2.Sort();
            foreach (var fileName in List2)
            {
                this.listBox2.Items.Add(fileName);
                c2++;
            }

            // ����������·��2
            List3 = FindDifferentFiles(textBox1.Text, textBox2.Text, MyStruct.ONLY_PATHTWO);
            List3.Sort();
            foreach (var fileName in List3)
            {
                this.listBox3.Items.Add(fileName);
                c3++;
            }

            label3.Text = $"�ļ�����:{c1}";
            label4.Text = $"�ļ�����:{c2}";
            label8.Text = $"�ļ�����:{c3}";
        }

        public List<string> FindDifferentFiles(string dirPath1, string dirPath2, MyStruct myStruct)
        {
            List<string> diffFiles = new List<string>();

            // ȷ��Ŀ¼����
            if (!Directory.Exists(dirPath1))
            {
                MessageBox.Show($"Ŀ¼һ��'{dirPath1}' �����ڣ�");
                return new List<string>();
            }
            if (!Directory.Exists(dirPath2))
            {
                MessageBox.Show($"Ŀ¼����'{dirPath1}' �����ڣ�");
                return new List<string>();
            }

            HashSet<string> filesInDir1 = new HashSet<string>();
            HashSet<string> filesInDir2 = new HashSet<string>();

            foreach (var file in new HashSet<string>(Directory.GetFiles(dirPath1)))
            {
                string fileNameWithExt = Path.GetFileName(file);
                filesInDir1.Add(fileNameWithExt);
            }
            foreach (var file in new HashSet<string>(Directory.GetFiles(dirPath2)))
            {
                string fileNameWithExt = Path.GetFileName(file);
                filesInDir2.Add(fileNameWithExt);
            }

            switch (myStruct)
            {
                case MyStruct.ONLY_PATHONE:
                    // ���ҽ���dirPath1�д��ڵ��ļ�
                    foreach (var file in filesInDir1)
                    {
                        if (!filesInDir2.Contains(file))
                            diffFiles.Add(Path.GetFileName(file));
                    }
                    break;
                case MyStruct.ONLY_PATHTWO:
                    // ���ҽ���dirPath2�д��ڵ��ļ�
                    foreach (var file in filesInDir2)
                    {
                        if (!filesInDir1.Contains(file))
                            diffFiles.Add(Path.GetFileName(file));
                    }
                    break;
                case MyStruct.BOTH_ALL:
                    // ������dirPath1��dirPath2�й�ͬ���ļ�
                    foreach (var file in filesInDir2)
                    {
                        if (filesInDir1.Contains(file))
                            diffFiles.Add(Path.GetFileName(file));
                    }
                    break;
                default:
                    break;
            }
            return diffFiles;
        }
        public static bool CopyFile(string sourceFilePath, string destinationFilePath)
        {
            try
            {
                // ���Դ�ļ��Ƿ����
                if (File.Exists(sourceFilePath))
                {
                    // �����ļ�
                    File.Copy(sourceFilePath, destinationFilePath, true);
                    return true;
                }
                else
                {
                    MessageBox.Show($"Դ�ļ�'{sourceFilePath}'������");
                    return false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"�����ļ�ʱ��������{ex.Message}");
                return false;
            }
        }
        /// <summary>
        /// ���Ŀ¼һ��Ŀ¼�����е��ļ�
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button3_Click(object sender, EventArgs e)
        {
            if (!flag || (listBox1.SelectedItems.Count == 0) && List1.Count == 0)
                return;
            int cnt = 0, allNum = 0;
            if (listBox1.SelectedItems.Count == 0)
            {
                if (MessageBox.Show("ȷ�Ϻ�������ȫ���ļ���������沿����ȡ������ѡ��ָ���ļ�����", "��ʾ", MessageBoxButtons.OKCancel) == DialogResult.OK)
                {
                    if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
                    {
                        foreach (var file in List1)
                        {
                            if (!CopyFile(textBox1.Text + "\\" + file, folderBrowserDialog1.SelectedPath + "\\" + file))
                                continue;
                            cnt++;
                        }
                        allNum = List1.Count;
                    }else
                        return;
                }
                else
                    return;
            }
            else
            {
                if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
                {
                    foreach (var file in listBox1.SelectedItems)
                    {
                        if (!CopyFile(textBox1.Text + "\\" + file, folderBrowserDialog1.SelectedPath + "\\" + file))
                            continue;
                        cnt++;
                    }
                    allNum = listBox1.SelectedItems.Count;
                }
            }

            MessageBox.Show($"�ļ�����{allNum},���ɹ���{cnt}�����ʧ�ܣ�{allNum - cnt}");
        }

        /// <summary>
        /// �����Ŀ¼һ�����ļ�
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button4_Click(object sender, EventArgs e)
        {
            if (!flag || (listBox2.SelectedItems.Count == 0) && List2.Count == 0)
                return;
            int cnt = 0, allNum = 0;
            if (listBox2.SelectedItems.Count == 0)
            {
                if (MessageBox.Show("ȷ�Ϻ�������ȫ���ļ���������沿����ȡ������ѡ��ָ���ļ�����", "��ʾ", MessageBoxButtons.OKCancel) == DialogResult.OK)
                {
                    if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
                    {
                        foreach (var file in List2)
                        {
                            if (!CopyFile(textBox1.Text + "\\" + file, folderBrowserDialog1.SelectedPath + "\\" + file))
                                continue;
                            cnt++;
                        }
                        allNum = List2.Count;
                    }
                    else
                        return;
                }
                else
                    return;
            }
            else
            {
                if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
                {
                    foreach (var file in listBox2.SelectedItems)
                    {
                        if (!CopyFile(textBox1.Text + "\\" + file, folderBrowserDialog1.SelectedPath + "\\" + file))
                            continue;
                        cnt++;
                    }
                    allNum = listBox2.SelectedItems.Count;
                }
            }

            MessageBox.Show($"�ļ�����{allNum},���ɹ���{cnt}�����ʧ�ܣ�{allNum - cnt}");
        }
        /// <summary>
        /// �����Ŀ¼�������ļ�
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button5_Click(object sender, EventArgs e)
        {
            if (!flag || (listBox3.SelectedItems.Count == 0 && List3.Count == 0))
                return;
            int cnt = 0, allNum = 0;
            if (listBox3.SelectedItems.Count == 0)
            {
                if (MessageBox.Show("ȷ�Ϻ�������ȫ���ļ���������沿����ȡ������ѡ��ָ���ļ�����", "��ʾ", MessageBoxButtons.OKCancel) == DialogResult.OK)
                {
                    if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
                    {
                        foreach (var file in List3)
                        {
                            if (!CopyFile(textBox2.Text + "\\" + file, folderBrowserDialog1.SelectedPath + "\\" + file))
                                continue;
                            cnt++;
                        }
                        allNum = List3.Count;
                    }
                    else
                        return;
                }
                else
                    return;
            }
            else
            {
                if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
                {
                    foreach (var file in listBox3.SelectedItems)
                    {
                        if (!CopyFile(textBox2.Text + "\\" + file, folderBrowserDialog1.SelectedPath + "\\" + file))
                            continue;
                        cnt++;
                    }
                    allNum = listBox3.SelectedItems.Count;
                }
            }

            MessageBox.Show($"�ļ�����{allNum},���ɹ���{cnt}�����ʧ�ܣ�{allNum - cnt}");
        }
    }

}
