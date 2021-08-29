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

namespace COCOQuitung
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            txtPreis.Text = "0,00€";
            txtMenge.Text = "0";
           // this. += new EventHandler(lstSelectItem);

        }
        static int index = 0;
        private void fillListBox() {
            lstArtikel.Items.Clear();
            lstdesc.Items.Clear();
            foreach (Artikel a in artikelListe)
            {
                lstArtikel.Items.Add(a.get_name());
                lstdesc.Items.Add(a.get_dicription());
            }
        }
        List<Artikel> artikelListe = new List<Artikel>();
        private void btnAddAction(object sender, RoutedEventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtartikel.Text) && !string.IsNullOrWhiteSpace(txtbeschreibung.Text))
            {


                Artikel neuArtikel = new Artikel();
                neuArtikel.set_name(txtartikel.Text);
                neuArtikel.set_discription(txtbeschreibung.Text);
                neuArtikel.set_amounts(Int32.Parse(txtMenge.Text));
                neuArtikel.set_price(double.Parse(txtPreis.Text));
                artikelListe.Add(neuArtikel);
                fillListBox();

            }
        }

        private void lstSelectItem(object sender, System.EventArgs e)
        {
            
            ListBox obj = (ListBox)sender;
            if (obj.SelectedIndex != -1)
            {
                index = obj.SelectedIndex;
                lstArtikel.SelectionMode = SelectionMode.Single;
                lstdesc.SelectionMode = SelectionMode.Single;
                if (obj == lstArtikel)
                {
                    lstdesc.SelectedIndex = index;
                }
                else
                {
                    lstArtikel.SelectedIndex = index;
                }

                
            }
        }

        private void btnDeleteAction(object sender, RoutedEventArgs e)
        {
            if (lstArtikel.Items.Count > 0)
            {
                artikelListe.RemoveAt(index);
                fillListBox();
            }
            else {
                MessageBox.Show("Keine Elemente vorhanden");
            }
        }
    }
}
