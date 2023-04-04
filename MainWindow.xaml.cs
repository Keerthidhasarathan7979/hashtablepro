using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.Pkcs;
using System.Security.Policy;
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

namespace hashtablepro
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

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            String content = "";

            Hashtable hash = new Hashtable();
            hash.Add("Student Name", txtname.Text.ToString());
            hash.Add("Collage Name", txtclg.Text.ToString());
            hash.Add("Mark 1", txtm1.Text.ToString());
            hash.Add("Mark2",txtm2.Text.ToString());
            hash.Add("Total", txttotal.Text.ToString());
            hash.Add("Student No", txtsn.Text.ToString());
            cmbitem.ItemsSource = hash;
            cmbitem.DisplayMemberPath = "Value";

           foreach (DictionaryEntry item in hash)
            {
                content += $"\n{item.Key.ToString()}" + ":" + $"{item.Value.ToString()}";
                


            }

            MessageBox.Show(content);
           
        }

        private void txtm2_TextChanged(object sender, TextChangedEventArgs e)
        {
            int m1 = Convert.ToInt32(txtm1.Text);
            int m2 = Convert.ToInt32(txtm2.Text);
            int Total = m1 + m2;
            txttotal.Text = Total.ToString();
        }
    }
}
