using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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

namespace ASsn4
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

        private void txtZipCodeToCheck_TextChanged(object sender, TextChangedEventArgs e)
        {
            // T1R2X4
            string checkZip = @"^(\d{5}(-\d{4})?|[A-Z]\d[A-Z] ?\d[A-Z]\d)$";  // from https://www.regextester.com/103297 
            //"^[0-9]{5}(?:-[0-9]{4})?$";  <<== works for US zip codes

            if (Regex.IsMatch(txtZipCodeToCheck.Text,checkZip))
            {
                btnGoodZip.IsEnabled = true;
            }
            else
            {
                btnGoodZip.IsEnabled = false;
            }
        }
    }
}
