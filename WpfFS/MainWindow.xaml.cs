using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfFS
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public ObservableCollection<FSLib.MyRecord2> Items { get; } = new ObservableCollection<FSLib.MyRecord2>();

        public MainWindow()
        {
            this.DataContext = this;
            InitializeComponent();
            //Items.Add(new FSLib.MyRecord2(new FSLib.MyRecord("x", n)))
        }
    }
}
