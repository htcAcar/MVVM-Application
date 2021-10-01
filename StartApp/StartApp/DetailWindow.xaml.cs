using StartApp.ViewModels;
using System.Windows;


namespace StartApp
{
    /// <summary>
    /// Interaction logic for DetailWindow.xaml
    /// </summary>
    public partial class DetailWindow : Window
    {        
        public DetailWindow()
        {
            InitializeComponent();
            this.DataContext = new DetailWindowViewModel();
        }
    }
}
