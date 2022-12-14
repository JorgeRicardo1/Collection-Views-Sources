using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using PruebaCollectionViewsConDB.ViewsModels;

namespace PruebaCollectionViewsConDB
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            BindingContext = new VerGrupoModelView();
        }
    }
}
