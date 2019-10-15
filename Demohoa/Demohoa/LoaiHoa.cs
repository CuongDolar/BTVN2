using System;
using System.Collections.Generic;
using System.Text;


namespace Demohoa
{
    class LoaiHoa : List<hoa>
    {
        public string Tenloai { get; set; }
        private LoaiHoa(string tenloai)
        {
            Tenloai = tenloai;

        }
        public IList<LoaiHoa> LoaiHoas { get; set; }
        public LoaiHoa()
        {
            List<LoaiHoa> l = new List<LoaiHoa>
                {
                    new LoaiHoa("Hoa cúc"){
                    new hoa { TenHoa = "Đón xuân", Gia = 50000, Hinh = "h1.jpg", MoTa = "Hoa cúc các màu : trắng, vàng, cam" },
                    new hoa { TenHoa = "Hồn nhiên", Gia = 60000, Hinh = "h2.jpg", MoTa = "Hoa cúc vàng, cam. lá mảng" },
                    new hoa { TenHoa = "Tím thủy chung", Gia = 45000, Hinh = "h3.jpg", MoTa = "Hoa cúc tím" }
                    },
                    new LoaiHoa("Hoa cưới")
                    {
                    new hoa { TenHoa = "Dây tơ hồng", Gia = 25000, Hinh = "h4.jpg", MoTa = "Hoa cúc các màu : trắng, vàng, cam" },
                    new hoa { TenHoa = "Cầu thủy tinh", Gia = 60000, Hinh = "h5.jpg", MoTa = "Hoa cúc vàng, cam. lá mảng" },
                    new hoa { TenHoa = "Duyên hồng", Gia = 5000, Hinh = "h6.jpg", MoTa = "Hoa cúc tím" }

                    }
                };
            LoaiHoas = l;
        }
    }
}
