using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
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

namespace Json.First_Assessment.Product
{
    /// <summary>
    /// Interaction logic for ProductWindow.xaml
    /// </summary>
    public partial class ProductWindow : Window
    {
        public ProductWindow()
        {
            InitializeComponent();
            Product product = new Product();
            using (StreamReader r = new StreamReader("data\\product.json"))
            {
                string json = r.ReadToEnd();
                product = JsonConvert.DeserializeObject<Product>(json);
            }
            lblOrderId.Content = "OrderId :" + product.OrderId;
            lblCreatedAt.Content = "CreatedAt :" + product.CreatedAt;
            lblCustomerId.Content = "CustomerId :" + product.CustomerId;
            lblLineItems.Content = "LineItems :" + product.LineItems;
        }
    }
}
