using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 记事本应用程序
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //创建一个泛型集合用来存储文件的全路径
        List<string> list = new List<string>();
        private void Form1_Load(object sender, EventArgs e)
        {
            //加载程序时，隐藏panel
            panelFather.Visible = false;
            //窗体加载时取消文本框的自动换行
            tbShow.WordWrap = false;
        }
        #region 隐藏panel
        private void btnviserble_Click(object sender, EventArgs e)
        {
            //点击<按钮时，panel隐藏
            panelFather.Visible = false;
        }

        private void tsmShow_Click(object sender, EventArgs e)
        {
            //点击显示按钮时，panel显示
            panelFather.Visible = true;
        }

        private void tsmViserble_Click(object sender, EventArgs e)
        {
            //点击隐藏按钮时，panel隐藏
            panelFather.Visible = false;
        }
        #endregion

        #region 打开文件
        private void tsmOpenFile_Click(object sender, EventArgs e)
        {
            //创建打开对话框的对象
            OpenFileDialog ofd = new OpenFileDialog();
            //修改对话框的标题
            ofd.Title = "请选择您要打开的文件";
            //设置对话框可以多选
            ofd.Multiselect = true;
            //初始化对话框的目录
            ofd.InitialDirectory = @"C:\Users\TANGJIANYI\Desktop";
            //设置对话框可以选择的文件类型
            ofd.Filter = "文本文件|*.txt|所有文件|*.*";
            //显示对话框
            ofd.ShowDialog();
            //获取在对话框选中的文件的全路径
            string path = ofd.FileName;
            //获得了用户打开文件的文件名
            string fileName = Path.GetFileName(path);
            //将文件名放到ListBox里面去
            listbox.Items.Add(fileName);
            //存储文件全路径
            list.Add(path);
            //判断如果没有选择文件
            if (path == "") return;
            //创建FileStream对象 用来读取文件
            using (FileStream fsread = new FileStream(path, FileMode.Open, FileAccess.Read))
            {
                //设置读取一次读取的字节大小
                byte[] buffer = new byte[1024 * 1024 * 5];
                //实际读取的字节大小
                int r = fsread.Read(buffer, 0, buffer.Length);
                //将读取到的字节数组转换成Utf-8的格式并赋值给文本框
                tbShow.Text = Encoding.UTF8.GetString(buffer, 0, r);

            }
        }
        #endregion

        #region 保存文件
        private void tsmSaveFile_Click(object sender, EventArgs e)
        {
            //创建一个保存对话框的对象
            SaveFileDialog sf = new SaveFileDialog();
            //修改对话框的标题
            sf.Title = "请选择您需要保存的位置";
            //初始化对话框的目录
            sf.InitialDirectory = @"C:\Users\TANGJIANYI\Desktop";
            //设置对话框可以保存的文件类型
            sf.Filter = "文本文件|*.txt|所有文件|*.*";
            //显示对话框
            sf.ShowDialog();
            //从对话框获取你所保存的文件全路径
            string path = sf.FileName;
            //如果点击取消 没有保存路径
            if (path == "") return;
            //创建一个FileStream对象用来写入文件
            using (FileStream fsWrite = new FileStream(path, FileMode.OpenOrCreate, FileAccess.Write))
            {
                //将文本框里的内容转换成utf-8格式的字节数组
                byte[] buffer = Encoding.UTF8.GetBytes(tbShow.Text);
                //将字节数组写入文件流
                fsWrite.Write(buffer, 0, buffer.Length);
            }
            MessageBox.Show("保存成功");
        }

        #endregion

        #region 字体样式
        private void tsmFont_Click(object sender, EventArgs e)
        {
            FontDialog fd = new FontDialog();
            fd.ShowDialog();
            tbShow.Font = fd.Font;
        }

        private void tsmColor_Click(object sender, EventArgs e)
        {
            ColorDialog cd = new ColorDialog();   
            cd.ShowDialog();
            tbShow.ForeColor = cd.Color;
        }
        #endregion

        #region 自动换行
        private void tsmWordWrap_Click(object sender, EventArgs e)
        {
            if (tsmWordWrap.Text == "自动换行")
            {
                tbShow.WordWrap = true;
                tsmWordWrap.Text = "取消自动换行";
            }
            else
            {
                tbShow.WordWrap = false;
                tsmWordWrap.Text = "自动换行";
            }
        }
        #endregion

        private void listbox_DoubleClick(object sender, EventArgs e)
        {
            //获得双击的文件所对应的全路径
            string path= list[listbox.SelectedIndex];
            using (FileStream fsRead = new FileStream(path, FileMode.Open, FileAccess.Read))
            {
                byte[] buffer = new byte[1024 * 1024 * 5];
                int r = fsRead.Read(buffer, 0, buffer.Length);
                tbShow.Text=Encoding.UTF8.GetString(buffer, 0, r);
            }
        }
    }
}
