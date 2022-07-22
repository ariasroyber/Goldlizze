using Goldlizze.ViewModels;
using System.ComponentModel;
using Xamarin.Forms;

namespace Goldlizze.Views
{
    public partial class ItemDetailPage : ContentPage
    {
        public ItemDetailPage()
        {
            InitializeComponent();
            BindingContext = new ItemDetailViewModel();
        }
    }
}