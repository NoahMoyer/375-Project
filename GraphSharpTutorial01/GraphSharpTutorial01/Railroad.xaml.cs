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
    /// Interaction logic for Railroad.xaml
    /// </summary>
    public partial class Railroad : Window
    {
        private IBidirectionalGraph<object, IEdge<object>> _graphToVisualize;

        public IBidirectionalGraph<object, IEdge<object>> GraphToVisualize
        {
            get { return _graphToVisualize; }
        }

        public Railroad()
        {
            CreateGraphToVisualize();

            InitializeComponent();
        }

        private void CreateGraphToVisualize()
        {
            var g = new BidirectionalGraph<object, IEdge<object>>();

            //add the vertices to the graph
            List<string> vertices = new List<string>();
            for (int i = 0; i < 10; i++)
            {
                vertices.Add("Hub " + (i + 1).ToString());
                g.AddVertex(vertices[i]);
            }




            //add some edges to the graph
            g.AddEdge(new Edge<object>(vertices[0], vertices[1]));
            g.AddEdge(new Edge<object>(vertices[1], vertices[0]));
            g.AddEdge(new Edge<object>(vertices[2], vertices[3]));
            g.AddEdge(new Edge<object>(vertices[3], vertices[1])); 
            g.AddEdge(new Edge<object>(vertices[1], vertices[4]));
            g.AddEdge(new Edge<object>(vertices[5], vertices[4]));
            g.AddEdge(new Edge<object>(vertices[6], vertices[3]));
            g.AddEdge(new Edge<object>(vertices[7], vertices[2]));
            g.AddEdge(new Edge<object>(vertices[8], vertices[1]));
            g.AddEdge(new Edge<object>(vertices[9], vertices[0]));




            _graphToVisualize = g;
        }

        //private void addMultidirectionalEdge(string) //this will add an edge pointing to both vertices
    }
}
