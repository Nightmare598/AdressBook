using System.Collections.ObjectModel;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace appAddress.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class BookPage : ContentPage
    {
        public ObservableCollection<string> Items { get; set; }

        public BookPage()
        {
            InitializeComponent();
        }
    }
}
