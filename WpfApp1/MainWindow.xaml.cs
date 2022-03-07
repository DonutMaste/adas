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
using QRCoder;
using QRCoder.Xaml;

namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Buttonpotvrzení_Click(object sender, RoutedEventArgs e)
        {
            string zadanyText = Text.Text;
            // Vytvoření generátoru QR kódu
            QRCodeGenerator qRCodeGenerator = new QRCodeGenerator();

            // Vytvoření dat QR kódu
            QRCodeData dataQR = qRCodeGenerator.CreateQrCode(zadanyText, QRCodeGenerator.ECCLevel.M);

            // Vytvoření QR kódu s daty vytvořenými nahoře
            XamlQRCode GRkOD = new XamlQRCode(dataQR);

            DrawingImage vkladenyobrazek = GRkOD.GetGraphic(30);
            ObrazekQR.Source = vkladenyobrazek;
        }

        private void Text_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void Text_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            Text.Text = "";
        }

        private void Text_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            Text.Text = " ";
        }
    }
}
// AJDFHJKSHFJSBHF