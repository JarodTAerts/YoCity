using Xamarin.Forms;

namespace YoCity.Views
{
    public partial class MasterTabbedPage : TabbedPage
    {
        public MasterTabbedPage()
        {
            InitializeComponent();
        }

        protected override bool OnBackButtonPressed()
        {
            return true;
        }
    }
}
