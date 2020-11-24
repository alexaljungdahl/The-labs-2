using System;
using System.Collections.Generic;
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

namespace Harry_Potter
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            Slytherin slytherin = new Slytherin();
            Ravenclaw ravenclaw = new Ravenclaw();

            slytherin.SetPassword(slytherin.Password, "Det var fult");
            ravenclaw.SetPassword(ravenclaw.Password, "Aha, det blev inte som tänkt");

        }
    }
}
