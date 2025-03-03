using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 策略模式_商场促销
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
            combox_Calculation.Items.AddRange(new object[] { "正常收费", "打八折", "打七折", "打五折", "满300减100" });
            combox_Calculation.SelectedIndex = 0;
            txtPrice = txt_price;
            txtNumber = txt_number;
        }

        double total = 0d;
        static TextBox txtPrice;
        static TextBox txtNumber;

        private void Btn_confirm_Click(object sender, EventArgs e)
        {
            double totalPrice = 0d;
            totalPrice = double.Parse(txtPrice.Text) * double.Parse(txt_number.Text);

            //CashSuper super = CashFactory.CreateCashSuper(combox_Calculation.Text);
            //totalPrice = super.acceptCash(totalPrice);

            CashContext cash = new CashContext(combox_Calculation.Text);
            totalPrice = cash.GetResult(totalPrice);

            total += totalPrice;
            txtbox_list.Text += "单价：" + txt_price.Text + "　数量：" + txt_number.Text + "　" + combox_Calculation.Text + "　合计：" + totalPrice + "\r\n";
            lab_totalprice.Text = total.ToString();
        }

        private void Btn_reset_Click(object sender, EventArgs e)
        {
            total = 0d;
            txtbox_list.Text = null;
            txt_number.Text = null;
            txt_price.Text = null;
            combox_Calculation.SelectedIndex = 0;
            lab_totalprice.Text = "0.00";
        }

        #region 简单工厂模式

        /// <summary>
        /// 工厂类
        /// </summary>
        class CashFactory
        {
            public static CashSuper CreateCashSuper(string type)
            {
                CashSuper cash = null;
                switch (type)
                {
                    case "正常收费":
                        cash = new CashNormal();
                        break;
                    case "打八折":
                        cash = new CashRebate("0.8");
                        break;
                    case "打七折":
                        cash = new CashRebate("0.7");
                        break;
                    case "打五折":
                        cash = new CashRebate("0.5");
                        break;
                    case "满300减100":
                        cash = new CashReturn(300, 100);
                        break;
                }

                return cash;
            }
        }

        /// <summary>
        /// 收费抽象类-参数为原价，返回原价
        /// </summary>
        abstract class CashSuper
        {
            public abstract double acceptCash(double money);
        }

        /// <summary>
        /// 正常收费-原价返回
        /// </summary>
        class CashNormal : CashSuper
        {
            public override double acceptCash(double money)
            {
                return money;
            }
        }

        /// <summary>
        /// 打折收费类
        /// </summary>
        class CashRebate : CashSuper
        {
            private double rebate = 1d;//打折
            /// <summary>
            /// 初始化时传入折扣率
            /// </summary>
            /// <param name="moneyRebate">折扣率</param>
            public CashRebate(string moneyRebate)   //
            {
                this.rebate = double.Parse(moneyRebate);
            }
            public override double acceptCash(double money)
            {
                return money * rebate;
            }
        }

        /// <summary>
        /// 返利收费类
        /// </summary>
        class CashReturn : CashSuper
        {
            private double moneyCondition = 0d; //返利条件
            private double moneyReturn = 0d;    //返利值
            /// <summary>
            /// (满300减100=>moneyCondition=300,moneyReturn=100)
            /// </summary>
            /// <param name="mcondition">返利条件</param>
            /// <param name="mreturn">返利值</param>
            public CashReturn(double mcondition, double mreturn)
            {
                this.moneyCondition = mcondition;
                this.moneyReturn = mreturn;
            }

            public override double acceptCash(double money)
            {
                if (money >= moneyCondition)
                    return money - Math.Floor(money / moneyCondition) * moneyReturn;
                return money;
            }
        }

        #endregion

        #region 策略模式

        /// <summary>
        /// 抽象算法类
        /// </summary>
        abstract class Strategy
        {
            //算法方法
            public abstract void AlgorithInterface();
        }

        class CashContext
        {
            private CashSuper cs;
            //public CashContext(CashSuper csuper)    //通过构造方法，传入具体的收费策略
            //{
            //    this.cs = csuper;
            //}
            public CashContext(string type)    //通过构造方法，传入具体的收费策略
            {
                switch (type)   //简单工厂和策略模式结合
                {
                    case "正常收费":
                        cs = new CashNormal();
                        break;
                    case "打八折":
                        cs = new CashRebate("0.8");
                        break;
                    case "打七折":
                        cs = new CashRebate("0.7");
                        break;
                    case "打五折":
                        cs = new CashRebate("0.5");
                        break;
                    case "满300减100":
                        cs = new CashReturn(300, 100);
                        break;
                }
            }

            public double GetResult(double money)
            {
                return cs.acceptCash(money);
            }
        }
        #endregion
    }

}
