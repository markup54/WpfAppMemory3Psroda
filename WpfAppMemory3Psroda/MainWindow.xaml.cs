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

namespace WpfAppMemory3Psroda
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public List<BitmapImage> Images { get; set; }
        public int Pierwszy { get; set; }
        public int Drugi { get; set; }
        public Image PierwszyObraz { get; set; }
        public Image DrugiObraz { get; set; }


        public MainWindow()
        {
            InitializeComponent();
            PrzygotujGrafike();
            Pierwszy = -1;
            Drugi = -1;
        }
        private void PrzygotujGrafike()
        {
            Images = new List<BitmapImage>();
            Images.Add(new BitmapImage(new Uri("rys1.jpg",UriKind.Relative)));
            Images.Add(new BitmapImage(new Uri("rys1.jpg",UriKind.Relative)));
            Images.Add(new BitmapImage(new Uri("rys2.jpg",UriKind.Relative)));
            Images.Add(new BitmapImage(new Uri("rys2.jpg",UriKind.Relative)));
            Images.Add(new BitmapImage(new Uri("rys3.jpg",UriKind.Relative)));
            Images.Add(new BitmapImage(new Uri("rys3.jpg",UriKind.Relative)));
            Images.Add(new BitmapImage(new Uri("rys4.jpg",UriKind.Relative)));
            Images.Add(new BitmapImage(new Uri("rys4.jpg",UriKind.Relative)));
            Images.Add(new BitmapImage(new Uri("rys5.jpg",UriKind.Relative)));
            Images.Add(new BitmapImage(new Uri("rys5.jpg",UriKind.Relative)));
            Images.Add(new BitmapImage(new Uri("rys6.jpg",UriKind.Relative)));
            Images.Add(new BitmapImage(new Uri("rys6.jpg",UriKind.Relative)));
            Images.Add(new BitmapImage(new Uri("rys7.jpg",UriKind.Relative)));
            Images.Add(new BitmapImage(new Uri("rys7.jpg",UriKind.Relative)));
            Images.Add(new BitmapImage(new Uri("rys8.jpg",UriKind.Relative)));
            Images.Add(new BitmapImage(new Uri("rys8.jpg",UriKind.Relative)));
            Images = Images.OrderBy(x => Random.Shared.Next()).ToList();
            
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Button button = sender as Button;
            Image image = (Image) button.Content;
            int ktory = int.Parse(image.Name.Substring(3,image.Name.Length-3))-1;
            image.Source = Images[ktory];
            if(Pierwszy <0)
            {
                Pierwszy = ktory;
                PierwszyObraz = image;
            }
            else if( ktory != Pierwszy) 
            {
                Drugi = ktory;
                DrugiObraz = image;
                MessageBox.Show("Kliknięto dwa"+DrugiObraz.Source+" "+PierwszyObraz.Source);

                if (Images[Pierwszy].UriSource == Images[Drugi].UriSource)
                {
                    MessageBox.Show("takie same !!!!!");
                }
                Pierwszy = -1;
                Drugi = -1;
            }
        }
    }
}
