using NET7_SwipeItem.ViewModel;
namespace NET7_SwipeItem
{
    public partial class MainPage : ContentPage
    { 
        public MainPage()
        {
            InitializeComponent();
            BindingContext = new MonkeyViewModel();
        }
         
    }

}
