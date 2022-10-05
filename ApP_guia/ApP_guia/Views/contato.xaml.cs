using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ApP_guia.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class contato : ContentPage
    {
        public contato()
        {
            InitializeComponent();
        }
        private void Button_Clicked(object sender, EventArgs e)
        {
            Device.OpenUri(new Uri("tel:01936560052"));
        }
    }
}