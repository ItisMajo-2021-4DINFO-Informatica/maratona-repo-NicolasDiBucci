using System.Windows;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace SalimbeniMaratonaApp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        readonly ElencoMaratone elenco;
        public MainWindow()
        {
            InitializeComponent();

            elenco = new ElencoMaratone();
        }

        private void BtnLeggiFile_Click(object sender, RoutedEventArgs e) => elenco.LeggiDaFile();
    }
}
