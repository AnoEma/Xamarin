using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace VariosPagina
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Desinho : ContentPage
    {
        public Desinho()
        {
            InitializeComponent();
            navegador.Source = "https://www.minutoseguros.com.br/";
        }
        
        private void PagOnNavigating(object sender, WebNavigatingEventArgs e)
        {
            lblStatus.Text = "Carregando página...";
        }
        private void PagOnNavigated(object sender, WebNavigatedEventArgs e)
        {
            lblStatus.Text = "Página carregada...";
        }
    }
}