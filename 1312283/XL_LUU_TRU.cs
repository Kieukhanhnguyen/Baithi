using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace _1312283
{
    class XL_LUU_TRU
    {
        static string duongdan = @"..\..\Tailieu.xml";
        public XmlElement Doc()
        {
            XmlElement kq;
            XmlDocument Tailieu = new XmlDocument();
            Tailieu.Load(duongdan);
            kq = Tailieu.DocumentElement;
            return kq;
        }
        public void Ghi(XmlElement cha, string tenthe, string id,string ten, string idlop, string ngaysinh, string gioitinh,string idkhoi, string DTB)
        {
            XmlDocument tailieu = cha.OwnerDocument;
            XmlElement kq = tailieu.DocumentElement;
            XmlElement note = tailieu.CreateElement(tenthe);
            kq.AppendChild(note);
            note.SetAttribute("ID", id.ToString());
            note.SetAttribute("TEN", ten.ToString());
            note.SetAttribute("ID_LOP", idlop.ToString());
            note.SetAttribute("ID_KHOI", idkhoi.ToString());
            note.SetAttribute("NGAY_SINH", ngaysinh.ToString());
            note.SetAttribute("GIOI_TINH", gioitinh.ToString());
            note.SetAttribute("DIEM_TB", DTB.ToString());
            tailieu.Save(duongdan);
        }
        public void Tao_tai_lieu()
        {
            XmlElement kq;
            Random random = new Random();
            XmlDocument tailieu = new XmlDocument();
            kq = tailieu.CreateElement("GOC");
            tailieu.AppendChild(kq);
            XmlElement note = tailieu.CreateElement("TRUONG");
            kq.AppendChild(note);
            note.SetAttribute("ID", "1");
            note.SetAttribute("TEN", "X");
            note = tailieu.CreateElement("KHOI");
            kq.AppendChild(note);
            note.SetAttribute("ID", "1");
            note.SetAttribute("TEN", "KHOI_10");
            note = tailieu.CreateElement("KHOI");
            kq.AppendChild(note);
            note.SetAttribute("ID", "2");
            note.SetAttribute("TEN", "KHOI_11");
            note = tailieu.CreateElement("KHOI");
            kq.AppendChild(note);
            note.SetAttribute("ID", "3");
            note.SetAttribute("TEN", "KHOI_12");
            char tenlop = 'A';
            for(int i=1;i<=6;i++)
            {
                note = tailieu.CreateElement("LOP");
                kq.AppendChild(note);
                note.SetAttribute("ID", (i.ToString()));
                note.SetAttribute("TEN_LOP", "10" + tenlop.ToString());
                note.SetAttribute("ID_KHOI", "1");
                tenlop++;
            }
            tenlop = 'A';
            for (int i = 1; i <= 6; i++)
            {
                note = tailieu.CreateElement("LOP");
                kq.AppendChild(note);
                note.SetAttribute("ID", (i.ToString()));
                note.SetAttribute("TEN_LOP", "11" + tenlop.ToString());
                note.SetAttribute("ID_KHOI", "2");
                tenlop++;
            }
            tenlop = 'A';
            for (int i = 1; i <= 6; i++)
            {
                note = tailieu.CreateElement("LOP");
                kq.AppendChild(note);
                note.SetAttribute("ID", (i.ToString()));
                note.SetAttribute("TEN_LOP", "12" + tenlop.ToString());
                note.SetAttribute("ID_KHOI", "3");
                tenlop++;
            }
            string[] Ho = { "Nguyễn", "Trần", "Đỗ", "Đoàn", "Trương", "Huỳnh" };
            string[] tenlot = { "Thanh", "Kiều", "Minh", "Tuấn", "Mạnh", "Chấn" };
            string[] ten = { "Như", "Đông", "Hiệp", "Phát", "Hiền", "Trí", "Dũng", "Đạt", "Anh", "Ngọc", "Nhi" };
            string[] gioitinh = { "Nam", "Nu" };
            for(int i=1;i<=35;i++)
            {
                for (int j = 1; j <= 6;j++)
                {
                    note = tailieu.CreateElement("HOC_SINH");
                    kq.AppendChild(note);
                    note.SetAttribute("ID", i.ToString());
                    note.SetAttribute("TEN", Ho[random.Next(0, 6)].ToString() + " " + tenlot[random.Next(0, 6)].ToString() + " " + ten[random.Next(0, 11)].ToString());
                    note.SetAttribute("ID_LOP", j.ToString());
                    note.SetAttribute("ID_KHOI", "1");
                    note.SetAttribute("NGAY_SINH", random.Next(1, 31).ToString() + "/" + random.Next(1, 13).ToString() + "/" + random.Next(1998, 2001).ToString());
                    note.SetAttribute("GIOI_TINH", gioitinh[random.Next(0, 2)].ToString());
                    note.SetAttribute("DIEM_TB", random.Next(4, 11).ToString());
                }
            }
          

            for (int i = 1; i <= 35; i++)
            {
                for (int j = 1; j <= 6; j++)
                {
                    note = tailieu.CreateElement("HOC_SINH");
                    kq.AppendChild(note);
                    note.SetAttribute("ID", i.ToString());
                    note.SetAttribute("TEN", Ho[random.Next(0, 6)].ToString() + " " + tenlot[random.Next(0, 6)].ToString() + " " + ten[random.Next(0, 11)].ToString());
                    note.SetAttribute("ID_LOP", j.ToString());
                    note.SetAttribute("ID_KHOI", "2");
                    note.SetAttribute("NGAY_SINH", random.Next(1, 31).ToString() + "/" + random.Next(1, 13).ToString() + "/" + random.Next(1997, 2000).ToString());
                    note.SetAttribute("GIOI_TINH", gioitinh[random.Next(0, 2)].ToString());
                    note.SetAttribute("DIEM_TB", random.Next(4, 11).ToString());
                }
            }
            for (int i = 1; i <= 35; i++)
            {
                for (int j = 1; j <= 6; j++)
                {
                    note = tailieu.CreateElement("HOC_SINH");
                    kq.AppendChild(note);
                    note.SetAttribute("ID", i.ToString());
                    note.SetAttribute("TEN", Ho[random.Next(0, 6)].ToString() + " " + tenlot[random.Next(0, 6)].ToString() + " " + ten[random.Next(0, 11)].ToString());
                    note.SetAttribute("ID_LOP", j.ToString());
                    note.SetAttribute("ID_KHOI", "3");
                    note.SetAttribute("NGAY_SINH", random.Next(1, 31).ToString() + "/" + random.Next(1, 13).ToString() + "/" + random.Next(1996, 1999).ToString());
                    note.SetAttribute("GIOI_TINH", gioitinh[random.Next(0, 2)].ToString());
                    note.SetAttribute("DIEM_TB", random.Next(4, 11).ToString());
                }
            }
            tailieu.Save(duongdan);
        }
    }
}
