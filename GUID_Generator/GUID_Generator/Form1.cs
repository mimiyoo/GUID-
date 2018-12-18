using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUID_Generator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private string ForMateStr = "D";

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            ForMateStr = "P";
            if (textBox1.Text.Trim() == string.Empty)
            {
                textBox1.Text= Guid.NewGuid().ToString(ForMateStr);
            }
            if (textBox1.Text.Trim() != "")
            {
                try
                {
                    label2.Text = Guid.Parse(textBox1.Text.Trim()).ToString(ForMateStr);
                }
                catch
                {
                    MessageBox.Show("不是有效的GUID!");
                    textBox1.Text = string.Empty;
                }
                return;
            }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            ForMateStr = "D";
            if (textBox1.Text.Trim() == string.Empty)
            {
                textBox1.Text = Guid.NewGuid().ToString(ForMateStr);
            }
            if (textBox1.Text.Trim() != "")
            {
                try
                {
                    label2.Text = Guid.Parse(textBox1.Text.Trim()).ToString(ForMateStr);
                }
                catch
                {
                    MessageBox.Show("不是有效的GUID!");
                    textBox1.Text = string.Empty;
                }
                return;
            }

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            ForMateStr = "N";
            if (textBox1.Text.Trim() == string.Empty)
            {
                textBox1.Text = Guid.NewGuid().ToString(ForMateStr);
            }
            if (textBox1.Text.Trim() != "")
            {
                try
                {
                    label2.Text = Guid.Parse(textBox1.Text.Trim()).ToString(ForMateStr);
                }
                catch
                {
                    MessageBox.Show("不是有效的GUID!");
                    textBox1.Text = string.Empty;
                }
                return;
            }
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            ForMateStr = "B";
            if (textBox1.Text.Trim() == string.Empty)
            {
                textBox1.Text = Guid.NewGuid().ToString(ForMateStr);
            }
            if (textBox1.Text.Trim() != "")
            {
                try
                {
                    label2.Text = Guid.Parse(textBox1.Text.Trim()).ToString(ForMateStr);
                }
                catch
                {
                    MessageBox.Show("不是有效的GUID!");
                    textBox1.Text = string.Empty;
                }
                return;
            }
        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {
            ForMateStr = "X";
            if (textBox1.Text.Trim() == string.Empty)
            {
                textBox1.Text = Guid.NewGuid().ToString(ForMateStr); textBox1.Text = Guid.Empty.ToString(ForMateStr);
            }
            if (textBox1.Text.Trim() != "")
            {
                try
                {
                    label2.Text = Guid.Parse(textBox1.Text.Trim()).ToString(ForMateStr);
                }
                catch
                {
                    MessageBox.Show("不是有效的GUID!");
                    textBox1.Text = string.Empty;
                }
                return;
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                textBox1.Text = Guid.Empty.ToString(ForMateStr);
            }
            if (radioButton1.Checked)
            {
                radioButton1_CheckedChanged(sender, e);
            }
            else if (radioButton2.Checked)
            {
                radioButton2_CheckedChanged(sender, e);
            }
            else if (radioButton3.Checked)
            {
                radioButton3_CheckedChanged(sender, e);
            }
            else if (radioButton4.Checked)
            {
                radioButton4_CheckedChanged(sender, e);
            }
            else if (radioButton5.Checked)
            {
                radioButton5_CheckedChanged(sender, e);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Clipboard.SetDataObject(this.label2.Text);
            MessageBox.Show("已复制到剪切板!");
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                textBox1.Text = Guid.Empty.ToString(ForMateStr);
            }
            if (radioButton1.Checked)
            {
                radioButton1_CheckedChanged(sender, e);
            }
            else if (radioButton2.Checked)
            {
                radioButton2_CheckedChanged(sender, e);
            }
            else if (radioButton3.Checked)
            {
                radioButton3_CheckedChanged(sender, e);
            }
            else if (radioButton4.Checked)
            {
                radioButton4_CheckedChanged(sender, e);
            }
            else if (radioButton5.Checked)
            {
                radioButton5_CheckedChanged(sender, e);
            }
        }
    }
}
