using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
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

namespace WpfAppCollections
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    /// 
    
    public partial class MainWindow : Window
    {
        private List<UserControl1> _controlSrc = new List<UserControl1>();
        private List<UserControl1> Controls1 = new List<UserControl1>();

        public List<string> manuList = new List<string>();

        public List<double> priceList = new List<double>();
        public List<int> inStockList = new List<int>();

        public MainWindow()
        {
            InitializeComponent();
            _controlSrc.Add(new UserControl1() { productImgPath = "https://upload.wikimedia.org/wikipedia/en/3/30/CodeGeassmovieposter.png", productName = "Code Geass the Complete Series (Blu-ray)", productDesc = "Code Geass the Complete Series contains anime episodes 1-25 of Season 1...", productManu = "SUNRISE", productPric = 4100, productInStock = 5 });
            _controlSrc.Add(new UserControl1() { productImgPath = "https://upload.wikimedia.org/wikipedia/ru/8/82/Re_Zero_volume_1_cover.jpg", productName = "Re:Zero kara Hajimeta Isekai Seikatsu", productDesc = "Subaru Natsuki was just trying to get to the convenience store ... ", productManu = "Yen On", productPric = 999, productInStock = 7 });
            _controlSrc.Add(new UserControl1() { productImgPath = "https://upload.wikimedia.org/wikipedia/en/c/c3/Danganronpacharacters4.jpg", productName = "Danganronpa: The Animation", productDesc = "Hope’s Peak High School is an exclusive private school that only accepts the best of the best...", productManu = "Lerche", productPric = 7100, productInStock = 3 });

            Controls1 = _controlSrc;

            manuList.Add("All Manufacturers");
            foreach ( var c in Controls1 )
            {
                manuList.Add(c.productManu);
                priceList.Add(c.productPric);
                inStockList.Add(c.productInStock);
            }

            mainList.ItemsSource = Controls1;
            manuComboBox.ItemsSource = manuList;

        }


        private bool handle = true;
        private void manuComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (handle) comboHandle(sender as ComboBox);
            handle = true;
        }

        private void manuComboBox_DropDownClosed(object sender, EventArgs e)
        {
            ComboBox cmb = sender as ComboBox;
            handle = !cmb.IsDropDownOpen;
            comboHandle(cmb);
        }

        private void comboHandle(ComboBox cmbSelect)
        {
            if (cmbSelect.SelectedValue.ToString() == "All Manufacturers" || cmbSelect.SelectedValue.ToString() == "")
            {   
                // TODO: Call handler for sort
                Controls1 = _controlSrc;
            }
            else
            {
                Controls1 = _controlSrc.Where(c => c.productManu.Contains(cmbSelect.SelectedValue.ToString())).ToList();
                mainList.ItemsSource = Controls1;
            }
        }
    }
}
