using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using QuickGraph;




namespace RailroadSimulation
{
    /// <summary>
    /// Interaction logic for FileInput.xaml
    /// </summary>
    public partial class FileInput : Window
    {
        GameValueControls GVC;

        public FileInput()
        {
            InitializeComponent();


        }

        private void Button_Click(object sender, EventArgs e)
        {
            this.Frame.Navigate(typeof(Railroad));
        }
    }
}
