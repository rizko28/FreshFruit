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
using FreshFruit.Model;
using FreshFruit.Controller;


namespace FreshFruit
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window, BucketEventListener
    {

        private Seller rizko;
        Fruit anggur = new Fruit("Anggur");
        Fruit Apel = new Fruit("Apel");
        Fruit Pisang = new Fruit("Pisang");
        Fruit jeruk = new Fruit("Jeruk");
        public MainWindow()
        {
            InitializeComponent();

            Bucket keranjangBuah = new Bucket(4); // bisa diisi maksimal keranjang
            BucketController bucketController = new
            BucketController(keranjangBuah, this);
            rizko = new Seller("rizko", bucketController);
            ListBoxBucket.ItemsSource = keranjangBuah.findAll();
        }


        private void Button1_Click(object sender, RoutedEventArgs e)
        {
            rizko.addFruit(anggur);
        }

        private void Button2_Click(object sender, RoutedEventArgs e)
        {
            rizko.addFruit(Apel);

        }
        private void Button3_Click(object sender, RoutedEventArgs e)
        {
            rizko.addFruit(Pisang);

        }
        private void Button4_Click(object sender, RoutedEventArgs e)
        {
            rizko.addFruit(jeruk);

        }
        private void removerei_Click(object sender, RoutedEventArgs e)
        {
            rizko.RmvFruitrizko(anggur);
            rizko.RmvFruitrizko(Apel);
            rizko.RmvFruitrizko(Pisang);
            rizko.RmvFruitrizko(jeruk);
        }

        public void onFailed(string message)
        {
            MessageBox.Show(message, "Warning", MessageBoxButton.OK, MessageBoxImage.Warning);
        }

        public void onSucceed(string message)
        {
            MessageBox.Show(message, "Info", MessageBoxButton.OK, MessageBoxImage.Information);
            ListBoxBucket.Items.Refresh();
        }

    }

}