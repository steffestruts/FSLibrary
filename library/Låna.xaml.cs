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
using System.Windows.Shapes;

namespace library
{
    /// <summary>
    /// Interaction logic for Låna.xaml
    /// </summary>
    public partial class Låna : Window
    {
        public Låna win2;
        public Låna(List<Book> basket)
        {
            InitializeComponent();

            //MessageBox.Show(basket.ToString());
            List<Book> localData = new List<Book>();
            foreach (var item in basket)
            { 

            using (FSMbibliotekEntities data = new FSMbibliotekEntities())
            {
                    var res = from x in basket
                              join booking in data.Bookings on x.Book_Id equals booking.Book_Id 
                              join lib in data.Libraries on booking.Library_Id equals lib.Library_Id  
                              //where x.Book_Id == booking.Book_Id 
                              select new
                              {
                                booking.Book_Id, lib.Library_Name
                              };


                    foreach (var a in res)
                    {
                        //localData.Add(a);
                    }
                }

                dataGrid.ItemsSource = localData;
        }
        }
    }
}
