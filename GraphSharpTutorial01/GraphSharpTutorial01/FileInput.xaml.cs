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

using System.IO;
using Microsoft.Win32;




namespace RailroadSimulation
{
    /// <summary>
    /// Interaction logic for FileInput.xaml
    /// </summary>
    public partial class FileInput : Window
    {
        string[] lines;

        public  FileInput()
        {
            InitializeComponent();


        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Railroad newRailroadWindow = new Railroad();
            // window1.Show(); // Win10 tablet in tablet mode, use this, when sub Window is closed, the main window will be covered by the Start menu.
            newRailroadWindow.ShowDialog();
        }

        private void openFile_Click(object sender, RoutedEventArgs e)
        {
            int numberOfHubs, numberOfStations, numberOfEdges, numberOfLocomotives;

            OpenFileDialog openFileDialog = new OpenFileDialog();
            if (openFileDialog.ShowDialog() == true)
            {
                //txtEditor.Text = File.ReadAllText(openFileDialog.FileName);
                lines = File.ReadAllLines(openFileDialog.FileName);
                foreach (string line in lines)
                {
                    txtEditor.Text += line;
                    txtEditor.Text += "\n";
                }
            }


        }
    }
}
