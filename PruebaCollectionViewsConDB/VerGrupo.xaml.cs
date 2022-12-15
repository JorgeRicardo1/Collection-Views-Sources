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

        private void SearchBar_TextChanged(object sender, TextChangedEventArgs e)
        {
            var _container = BindingContext as VerGrupoModelView;
            if (string.IsNullOrEmpty(e.NewTextValue))
            {
                grup_arti_list.ItemsSource = _container.ListArticulos;
            }
            else
            {
                grup_arti_list.ItemsSource = _container.ListArticulos.Where(i => i.nombre.Contains(e.NewTextValue.ToUpper()));
            }
        }
    }
}
