using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Globalization;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace ShoppingCart
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Product[] Products = new Product[6];
        Product[] CartProducts = new Product[6];
        Product[] FilteredProducts = new Product[6];
        double total = 0;

        public MainWindow()
        {
            
            Variation male = new Variation { VarType = "Male" };
            Variation female = new Variation { VarType = "Female" };

            Product aProduct = new Product { ID = 1234, Name = "Road Bike", Price = 535.90, Variation = male};
            Product bProduct = new Product { ID = 4321, Name = "Road Bike", Price = 635.00, Variation = female };
            Product cProduct = new Product { ID = 5612, Name = "Mountain Bike", Price = 740.00, Variation = male };
            Product dProduct = new Product { ID = 1511, Name = "Mountain Bike", Price = 780.00, Variation = female };
            Product eProduct = new Product { ID = 6542, Name = "Hybrid Bike", Price = 155.00, Variation = male };
            Product fProduct = new Product { ID = 8234, Name = "Hybrid Bike", Price = 204.55, Variation = female };

            Products[0] = aProduct;
            Products[1] = bProduct;
            Products[2] = cProduct;
            Products[3] = dProduct;
            Products[4] = eProduct;
            Products[5] = fProduct;

            InitializeComponent();
        }

        private void btnRemoveFromCart_Click(object sender, RoutedEventArgs e)
        {
            Product selectedProduct = listBoxCart.SelectedItem as Product;
            listBoxCart.ItemsSource = "";
            if (selectedProduct != null)
            {
                for (int i = 0; i < CartProducts.Length; i++)
                {
                    if (selectedProduct == CartProducts[i])
                    {
                        
                        Array.Clear(CartProducts, i, 1);
                       
                    }
                }
            }
            listBoxCart.ItemsSource = CartProducts;
            total = 0;
            foreach (Product p in CartProducts)
            {
                if (p != null)
                {
                    total += p.Price;
                }
            }
            totalAmount.Content = total;
        }

        private void btnAddToCart_Click(object sender, RoutedEventArgs e)
        {
            listBoxCart.ItemsSource = "";
            Product selectedProduct = listBoxProducts.SelectedItem as Product;
            if(selectedProduct != null)
            {
                for(int i = 0; i < CartProducts.Length; i++)
                {
                    if(selectedProduct == Products[i])
                    {
                        CartProducts[i] = selectedProduct;

                    }
                }
            }
            listBoxCart.ItemsSource = CartProducts;
            foreach (Product p in CartProducts)
            {
                if (p != null)
                {
                    total += p.Price;
                }
            }
            totalAmount.Content = total;

        }

        private void btnAddTax_Click(object sender, RoutedEventArgs e)
        {
            listBoxProducts.ItemsSource = "";
            foreach(Product product in Products)
            {
                product.AddTax(0.21);
            }
            listBoxProducts.ItemsSource = Products;
        }

        private void btnExit_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void OnWindowLoaded(object sender, RoutedEventArgs e)
        {
            listBoxProducts.ItemsSource = Products;
            string[] bikeTypes = { "All", "Male", "Female" };
            comboBoxBikeType.ItemsSource = bikeTypes;
            comboBoxBikeType.SelectedIndex = 0; //Set index to All
        }

        private void comboBoxBikeType_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            listBoxProducts.ItemsSource = "";
            Product selectedProduct = listBoxProducts.SelectedItem as Product;
            Variation selectedItem = comboBoxBikeType.SelectedItem as Variation;
            if (selectedItem != null)
            {
                for (int i = 0; i < Products.Length; i++)
                {
                    if (Products[i].Variation == selectedItem)
                    {
                        FilteredProducts[i] = (Product)selectedItem;
                    }

                }
            }
            listBoxProducts.ItemsSource = FilteredProducts;
        }
    }

    class Product : Variation
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        public double Tax { get; set; }
        public Variation Variation{ get; set; } = new Variation();
        
        public override string ToString()
        {
            if (this.Tax != 0)
            {
                return (this.ID + "\t" + this.Name + String.Format("\t{0:C2}\t{1:C2}", this.Price, this.Tax) );
            }
            else
            {
                return (this.ID + "\t" + this.Name + String.Format("\t{0:C2}", this.Price));
            }
        }

        public void AddTax(double taxRate)
        {
            this.Tax = this.Price * taxRate;
        }
    }

    class Variation
    {
        public string VarType { get; set; }
    }
}
