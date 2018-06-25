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

namespace suumoGenerator
{
    /// <summary>
    /// MainWindow.xaml の相互作用ロジック
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            if (suumo.Text.Length != 0 && su.Text.Length == 2 && emojiA.Text.Length != 0 && emojiB.Text.Length != 0 && emojiC.Text.Length != 0)
            {
                string gen = string.Format("あ❗️{0}❗️{2}ダン💥ダン💥ダン💥シャーン🎶" +
                "{1}{3}{1}{2}{1}{3}{1}{2}{1}{3}{1}{2}{5}〜〜〜{6}⤴{3}" +
                "{1}{3}{1}{2}{1}{3}{1}{2}{1}{3}{1}{2}{5}〜〜〜{6}⤵{4}", suumo.Text, su.Text, emojiA.Text, emojiB.Text, emojiC.Text, su.Text[0], su.Text[1]);
                Clipboard.SetText(gen);
                MessageBox.Show(gen+ "\n コピーもしたよ");
            }
            else
            {
                MessageBox.Show("入力ミスがあるよ");
            }
        }

        private void emojiC_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void emojiB_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void emojiA_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void suumo_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void su_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
}
