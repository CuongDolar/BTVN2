using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Demohoa
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PageListiewHoa : ContentPage
    {
        ObservableCollection<hoa> Hoas = new ObservableCollection<hoa>();
        public PageListiewHoa()
        {
            InitializeComponent();
            Hoas.Add(new hoa { TenHoa = "Đón xuân", Gia = 50000, Hinh = "h1.jpg", MoTa = "Hoa cúc các màu : trắng, vàng, cam" });
            Hoas.Add(new hoa { TenHoa = "Hồn nhiên", Gia = 60000, Hinh = "h2.jpg", MoTa = "Hoa cúc vàng, cam. lá mảng" });
            Hoas.Add(new hoa { TenHoa = "Tím thủy chung", Gia = 45000, Hinh = "h3.jpg", MoTa = "Hoa cúc tím" });
            lsvHoa.ItemsSource = Hoas;
        }
        
    }
}