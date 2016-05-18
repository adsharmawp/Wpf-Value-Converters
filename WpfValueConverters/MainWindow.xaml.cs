using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
namespace WpfValueConverters
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Employee vm = new Employee() { ShowImage = true, FirstName = "Akash", LastName = "Sharma" };

        public MainWindow()
        {
            InitializeComponent();
            this.DataContext = vm;
        }
    }
}
