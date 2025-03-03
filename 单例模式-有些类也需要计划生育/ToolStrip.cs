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
    public partial class ToolStrip : Form
    {
        /// <summary>
        /// 
        /// </summary>
        //public ToolStrip()
        //{
        //    InitializeComponent();
        //}

        private static ToolStrip tool;


        //将public改为私有private，外部不能实例化
        private ToolStrip()
        {
            InitializeComponent();
        }

        public static ToolStrip Instance()
        {
            //IsDisposed已经打开了窗体关掉后IsDisposed属性值改变，tool没有变为null
            if (tool == null || tool.IsDisposed)
            {
                //ToolStrip tool = new ToolStrip();
                tool = new ToolStrip();
                tool.MdiParent = Home.ActiveForm;
                tool.Show();
            }

            return tool;
        }

        private void ToolStrip_Load(object sender, EventArgs e)
        {

        }
    }
}
