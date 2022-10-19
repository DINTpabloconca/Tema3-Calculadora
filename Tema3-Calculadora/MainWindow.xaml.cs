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

namespace Tema3_Calculadora
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            botones();
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Button boton = (Button)sender;

            resultadoTextBox.Text += boton.Tag.ToString();
        }
        private void botones()
        {
            int val = 1;
            for (int i = 1; i < 4; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Button boton = new Button();
                    Viewbox viewbox = new Viewbox();
                    TextBlock textblock = new TextBlock();

                    textblock.Text = val.ToString();
                    boton.Tag = val.ToString();

                    viewbox.Child = textblock;
                    boton.Content = viewbox;

                    Grid.SetRow(boton, i);
                    Grid.SetColumn(boton, j);

                    contenedor.Children.Add(boton);
                    val++;
                }
            }
        }
 
    }
}

