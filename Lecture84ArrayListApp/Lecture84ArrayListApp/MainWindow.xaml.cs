using System;
using System.Collections;
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

namespace Lecture84ArrayListApp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        ArrayList arrayList;
        public MainWindow()
        {
            InitializeComponent();
            arrayList = new ArrayList();
        }

        private void btnAdd_Click(object sender, RoutedEventArgs e)
        {
            arrayList.Add(txtValue.Text);
            txtValue.Text = "";
        }

        private void btnRemove_Click(object sender, RoutedEventArgs e)
        {
            arrayList.Remove(txtValue.Text);
            txtValue.Text = "";
        }

        private void btnShowAll_Click(object sender, RoutedEventArgs e)
        {
            foreach (string data in arrayList)
            {
                MessageBox.Show(data);
            }
        }
    }
}
