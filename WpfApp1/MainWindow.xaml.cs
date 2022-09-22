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

namespace WpfApp1
{
    /// <summary>
    /// MainWindow.xaml 的互動邏輯
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            char [] delimiterChars = { ' ', ',', ',', '，', '。',':', '\t', '.' };
            string[] words = textBox.Text.Split(delimiterChars);
            string ans = "";
            string[] split = textBox2.Text.Split(delimiterChars);

            foreach (var word in words)
            {
                ans += $"{word}";
            }

            textBox1.Text = "";

            foreach (var word1 in split)
            {
                char aa = Convert.ToChar(word1);
                int count = ans.Split(aa).Length - 1;
                textBox1.Text += $"{word1}:{count}\n";
            }
        }
    }
}
