using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 单例模式_有些类也需要计划生育
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void Btn_Tool_Click(object sender, EventArgs e)
        {
            ToolStrip.Instance().Show();
        }
    }
}
