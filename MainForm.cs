using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RedBluePageComposer
{
    public partial class MainForm : Form
    {
        // 变量，全局对象



        // 事件，方法
        public MainForm()
        {
            InitializeComponent();
            textBox_OutputPath.Text = Environment.CurrentDirectory + "\\";
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void button_OriginWord_Click(object sender, EventArgs e)
        {
            openFileDialog.ShowDialog();
        }
        private void button_OutputPath_Click(object sender, EventArgs e)
        {
            saveFileDialog.ShowDialog();
        }
        private void openFileDialog_FileOk(object sender, CancelEventArgs e)
        {
            textBox_OriginWord.Text = openFileDialog.FileName;
        }
        private void saveFileDialog_FileOk(object sender, CancelEventArgs e)
        {
            string fname = saveFileDialog.FileName;
            string fpath = fname.Substring(0, fname.LastIndexOf('.')) + getExtension();
            textBox_OutputPath.Text = fpath;
        }

        // 自己写的函数
        private string getExtension()
        {
            string ext = "";
            if (radioButton_html.Checked) { ext = ".html"; }
            else { ext = ".docx"; }

            return ext;
        }
    }
}
