using NET8RC1_SwipeItem_Error.ViewModel;

namespace NET8RC1_SwipeItem_Error
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
