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

namespace library
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        public List<Book> basket = new List<Book>();
        public MainWindow()
        {
            InitializeComponent();
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            List<Book> localData = new List<Book>();

            using (FSMbibliotekEntities data = new FSMbibliotekEntities()) { 
                var query = from m in data.Books
                            where m.Book_Title.Contains(textBox.Text)
                            select m;

                foreach (var item in query)
                {
                    localData.Add(item);
                }
            }
            dataGrid.ItemsSource = localData;
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            if (dataGrid.SelectedCells.Count > 0)
            {
                
                basket.Add((Book)dataGrid.SelectedItem);

                dataGrid1.ItemsSource = basket.ToList();
            }
        }

        private void button2_Click(object sender, RoutedEventArgs e)
        {

            Låna win2 = new Låna(basket);
            win2.Show();
            this.Close();

        }
    }
    }

