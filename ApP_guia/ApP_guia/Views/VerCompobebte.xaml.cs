using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;


using ApP_guia.Models;

namespace ApP_guia.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class VerCompobebte : ContentPage
    {
        public VerCompobebte()
        {
         
            InitializeComponent();

            this.BindingContext = c; 
        }
    }
}