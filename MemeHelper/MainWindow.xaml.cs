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

namespace MemeHelper
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        public int LenText;
        public string Text;
        public string Text2;
        public string final;
        int star = 0;
        int l = 0;
        public void AddText()
        {
            Text= textex.Text;
            Text2=mem.Text;
        }
        private void res_Click(object sender, RoutedEventArgs e)
        {
            Text = textex.Text;
            Text2 = mem.Text;
            otl.Text = "";
            star = 0;
            l = 0;
            finalmem.Clear();
            final = null;
            char[] ue = Text.ToCharArray();
            char[] ft = Text2.ToCharArray();
            for (int i = 0; i < ue.Length; i++)
            {
                if(ft[l]==ue[i]) 
                { final += ft[l]; l++; }
                else { final += " "; }
                if (l == ft.Length) { break; }
            }
            finalmem.Text = final;
        }
    }
}
