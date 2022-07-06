using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace day23_02
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int Index1 = select_Fruit.SelectedIndex;
            string Index2 = input_num.Text.ToString();
            int Index3 = select_purchase.SelectedIndex;
            string Fruitname = select_Fruit.Text;

            try
            {
                if (string.IsNullOrEmpty(select_Fruit.Text) || string.IsNullOrEmpty(Index2) || Index3 == -1)
                    throw new Exception();

                string datetime = DateTime.Now.ToString();

                string invoiceNum = DateTime.Now.ToString("yyyyMMddHHmmss");
                invoiceNum += $"-{Index1}-{Index2}-{Index3}";
                invoice_num.Text = invoiceNum;

                output_Time.Text = datetime;
                output_fruit.Text = Fruitname;
                output_num.Text = input_num.Text.ToString();
                output_how.Text = select_purchase.Text;

                btn_purchase.Visible = true;
            }
            catch (Exception)
            {
                MessageBox.Show("칸이 비었습니다.");
            }
        }

        private void btn_purchase_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("구매하시겠습니까?", "구매확인", MessageBoxButtons.YesNo) == DialogResult.No)
                MessageBox.Show("구매를 취소하였습니다.", "취소");
            else { MessageBox.Show("구매하였습니다.", "완료"); WaitingList.Items.Add(invoice_num.Text); }
            ReSeT();
            btn_purchase.Visible = false;
        }

        public void ReSeT()
        {
            output_Time.Clear();
            select_Fruit.Text = "";
            select_purchase.ClearSelected();
            input_num.Clear();
            output_fruit.Clear();
            output_how.Clear();
            output_num.Clear();
            invoice_num.Clear();
        }

        private void btn_ADD_Click(object sender, EventArgs e)
        {
            select_Fruit.Items.Add(select_Fruit.Text);
        }
    }
}
