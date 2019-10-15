using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Demohoa
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PageListviewGroup : ContentPage
    {
        public PageListviewGroup()
        {
            InitializeComponent();
            LoaiHoa l = new LoaiHoa();
            lsthoa.ItemsSource = l.LoaiHoas;
        }
    }
}