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
        private string[] lines;
        private int numberOfHubs, numberOfStations, numberOfEdges, numberOfLocomotives;
        private Hub[] hubs; //hubs in the railroad
        private Locomotive[] locomotives; //locomotives in the railroad
        private Edge[] edges; //edges in the railroad
        private Station stations; //stations in the railroad
        struct Hub
        {
            private Locomotive[] Locomotives; //locomotives that have this hub as a home
        }
        struct Locomotive
        {
            private Hub homeHub; //home hub for the locomotive
            private string type; //either passenger or freight
        }
        struct Edge
        {
            private float weight; //distance of the edge
            private Station station1, station2; //stations the edge is connected to
            private Hub hub; //hub that the edge is connected to. Will not be used for most edges since most edges will not be connected to a hub
            private float startAvailableTime, endAvailableTime; //the time between that the edge is available
        }
        struct Station
        {
            private string type; //either passenger or freight
            private int maxNumberOfTrains; //the maxium number of trains that can be at a station at once
            private int randomOnRangeLower, randonOnRangeUpper; //range for how many passengers will get on the passenger train. 0 for freight trains
            private int randonOffRangelower, randomOffRangeUpper; //range for how many passengers will get off the passenger train. 0 for freight trains
        }

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
