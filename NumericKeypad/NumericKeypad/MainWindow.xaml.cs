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

namespace NumericKeypad
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        int first;
        int second;

        char op;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Button btn = (Button)sender;
            TxtResult.Text += btn.Content.ToString();
        }

        private void Back_Click(object sender, RoutedEventArgs e)
        {
            Button btn = (Button)sender;
            if(TxtResult.Text != string.Empty)
            {
                TxtResult.Text = TxtResult.Text.Remove(TxtResult.Text.Length - 1, 1);
            }
        }

        private void Decimal_Click(object sender, RoutedEventArgs e)
        {
            Button btn = (Button)sender;
            if(!TxtResult.Text.Contains("."))
            {
                TxtResult.Text += btn.Content.ToString();
            }
        }

        private void Clear_Click(object sender, RoutedEventArgs e)
        {
            Button btn = (Button)sender;
            TxtResult.Text = string.Empty;
        }

        private void Enter_Click(object sender, RoutedEventArgs e)
        {
            if(TxtResult.Text != String.Empty)
            {
                List_Box.Items.Add(TxtResult.Text);
                TxtResult.Text = string.Empty;
            }
        }

        private void Remove_From_List_Click(object sender, RoutedEventArgs e)
        {
            if (!List_Box.Items.IsEmpty)
            {
                List_Box.Items.Remove(List_Box.SelectedItem);
            }
        }

        private void Clear_List_Click(object sender, RoutedEventArgs e)
        {
            List_Box.Items.Clear();
        }

        private void ListBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
    }
}
