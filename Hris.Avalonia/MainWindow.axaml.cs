using Avalonia.Controls;
using Hris.Avalonia.Views;

namespace Hris.Avalonia
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void NavigationListBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (e.AddedItems.Count > 0)
            {
                var selectedItem = (ListBoxItem)e.AddedItems[0];
                if (selectedItem != null && selectedItem.Content != null)
                {
                    switch (selectedItem.Content.ToString())
                    {
                        case "Personal Information":
                            MainContent.Content = new PersonalInformationView();
                            break;
                        // Add other cases here later
                    }
                }
            }
        }
    }
}
