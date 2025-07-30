using Avalonia.Controls;
using Hris.Avalonia.ViewModels;

namespace Hris.Avalonia.Views
{
    public partial class PersonalInformationView : UserControl
    {
        public PersonalInformationView()
        {
            InitializeComponent();
            DataContext = new PersonalInformationViewModel();
        }
    }
}
