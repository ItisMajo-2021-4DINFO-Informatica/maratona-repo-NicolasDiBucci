using System.Windows;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace MaratonaDiBucciApp
{
    public partial class MainWindow : Window
    {
        readonly ElencoMaratone elenco;
        public MainWindow()
        {
            InitializeComponent();

            elenco = new ElencoMaratone();
            DgElencoMaratona.ItemsSource = elenco.Elenco;
        }

        public object Lista { get; private set; }

        private void BtnLeggiFile_Click(object sender, RoutedEventArgs e)
        {
        elenco.LeggiDaFile();
            DgElencoMaratona.Items.Refresh();
            BtnLeggiFile.IsEnabled = false;

        }

        private void BtnTempoinminuti_Click(object sender, RoutedEventArgs e)
        {
            string maratoneta = TxtMaratoneta.Text;
            string Città = TxtCitta.Text;
            string output = elenco.VisualizzaTempo(maratoneta, Città);
            LblTempo.Content = output;
        }

        private void TextBox_TextChanged(object sender, System.Windows.Controls.TextChangedEventArgs e)
        {

        }
    }
}

