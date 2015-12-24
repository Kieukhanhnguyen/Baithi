using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace _1312283
{
    class XL_NGHIEP_VU
    {
        public XmlElement Doc_tai_lieu()
        {
            XL_LUU_TRU luu_tru = new XL_LUU_TRU();
            XmlElement kq = luu_tru.Doc();
            return kq;
        }
        public void Tao_tai_lieu()
        {
            XL_LUU_TRU luu_tru = new XL_LUU_TRU();
            luu_tru.Tao_tai_lieu();
        }
        public void Them_hoc_sinh(string ten, string id, string idlop, string idkhoi, string ngaysinh, string gioitinh,string DTB)
        {
            XmlElement kq = Doc_tai_lieu();
            XL_LUU_TRU luu_tru = new XL_LUU_TRU();
            bool checkidhs = true;
            bool checkidlop = false;
            bool checkidkhoi = false;
            foreach(XmlElement hs in kq.SelectNodes("HOC_SINH"))
            {
                if(id.ToString()==hs.GetAttribute("ID").ToString()&&hs.GetAttribute("ID_LOP").ToString()==idlop.ToString()&&idkhoi.ToString()==hs.GetAttribute("ID_KHOI").ToString())
                {
                    MessageBox.Show("ID đã tồn tại");
                    checkidhs = false;
                    break;
                }
            }
            foreach(XmlElement lop in kq.SelectNodes("LOP"))
            {
                if(idlop.ToString()==lop.GetAttribute("ID").ToString()&&idkhoi.ToString()==lop.GetAttribute("ID_KHOI").ToString())
                {
                    checkidlop = true;
                    break;
                }
            }
            if (checkidlop == false)
            {
                MessageBox.Show("lop nay khong ton tai");
            }
            if(checkidhs==true&&checkidlop==true)
            {
                luu_tru.Ghi(kq, "HOC_SINH", id, ten, idlop, ngaysinh, gioitinh, idkhoi,DTB);
                MessageBox.Show("Thêm thành công");
            }
            else
     
                checkidhs = true;
        }
        public List<XmlElement> Tracuu(string tenlop, string hocluc)
        {
            XL_LUU_TRU luu_tru = new XL_LUU_TRU();
            List<XmlElement> Danh_sach = new List<XmlElement>();
            XmlElement goc = luu_tru.Doc();
            foreach(XmlElement hs in goc.SelectNodes("HOC_SINH"))
            {
                int diem = int.Parse(hs.GetAttribute("DIEM_TB"));
                string idlop = hs.GetAttribute("ID_LOP").ToString();
                string idkhoi = hs.GetAttribute("ID_KHOI").ToString();
                foreach(XmlElement lop in goc.SelectNodes("LOP"))
                {
                    if(hocluc=="Giỏi")
                    {
                        if(diem>=8.5&&idlop==lop.GetAttribute("ID").ToString()&&idkhoi==lop.GetAttribute("ID_KHOI").ToString()&&lop.GetAttribute("TEN_LOP").ToString()==tenlop)
                        {
                            Danh_sach.Add(hs);
                        }
                    }
                    if (hocluc == "Khá")
                    {
                        if (diem < 8.5 && idlop == lop.GetAttribute("ID").ToString() && idkhoi == lop.GetAttribute("ID_KHOI").ToString() && lop.GetAttribute("TEN_LOP").ToString() == tenlop)
                        {
                            Danh_sach.Add(hs);
                        }
                    }
                    if (hocluc == "Trung bình")
                    {
                        if (diem < 6.5 && idlop == lop.GetAttribute("ID").ToString() && idkhoi == lop.GetAttribute("ID_KHOI").ToString() && lop.GetAttribute("TEN_LOP").ToString() == tenlop)
                        {
                            Danh_sach.Add(hs);
                        }
                    }
                    if (hocluc == "Yếu")
                    {
                        if (diem < 5 && idlop == lop.GetAttribute("ID").ToString() && idkhoi == lop.GetAttribute("ID_KHOI").ToString() && lop.GetAttribute("TEN_LOP").ToString() == tenlop)
                        {
                            Danh_sach.Add(hs);
                        }
                    }

                }
            }
            return Danh_sach;
        }

    }
}
