using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace _1312283
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            XL_NGHIEP_VU nv = new XL_NGHIEP_VU();
            nv.Tao_tai_lieu();
        }

        private void btntracuu_Click(object sender, EventArgs e)
        {
            danhsach.Controls.Clear();
            XL_NGHIEP_VU nv = new XL_NGHIEP_VU();
            List<XmlElement> Danh_sach = nv.Tracuu(txttenlop.Text,txtloaihocluc.Text);
            foreach (XmlElement hs in Danh_sach)
            {
                Button bt = new Button();
                bt.Text = hs.GetAttribute("TEN").ToString() + "\n";
                bt.Size = new Size(200, 40);
                danhsach.Controls.Add(bt);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnthem_Click(object sender, EventArgs e)
        {
            XL_NGHIEP_VU nv = new XL_NGHIEP_VU();
            nv.Them_hoc_sinh(txthoten.Text, txtid.Text, txtidlop.Text, txtidkhoi.Text, dateTimePicker1.Value.Date.ToString(), cbbgioitinh.SelectedItem.ToString(), txtdiem.Text);
            Button bt = new Button();
            bt.Text = txthoten.Text;
            bt.Size = new Size(200, 40);
            danhsach.Controls.Add(bt);
        }
    }
}
