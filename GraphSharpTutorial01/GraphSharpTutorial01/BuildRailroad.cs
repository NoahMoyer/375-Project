using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using QuickGraph;

namespace RailroadSimulation
{
    class BuildRailroad
    {
        private int numberOfHubs, numberOfStations, numberOfEdges, numberOfLocomotives;
        private Hub[] hubs; //hubs in the railroad
        private Locomotive[] locomotives; //locomotives in the railroad
        private Edge[] edges; //edges in the railroad
        private Station stations; //stations in the railroad

        class Hub
        {
            List<Locomotive> locomotivesInHub = new List<Locomotive>(); //locomotives that have this hub as a home
            private string name; //name of the hub

            public List<Locomotive> LocomotivesInHub { get; }//get method for locommotivesInHub

            public void addLocomotiveToHub(Locomotive LocomotiveToAddToHub) //add a locomotive in a hub
            {
                locomotivesInHub.Add(LocomotiveToAddToHub);
            }

            public void removeLocomotiveFromHub(Locomotive LocomotiveToRemoveFromHub) //remove a locomotive in a hub
            {
                if (locomotivesInHub.Contains(LocomotiveToRemoveFromHub))
                {
                    locomotivesInHub.Remove(LocomotiveToRemoveFromHub);
                }
            }


            public string Name { get; set; } //get and set for name

        }

        class Locomotive
        {
            private Hub homeHub; //home hub for the locomotive
            private string type; //either passenger or freight
            private string name; //name of the locomotive

            public Hub HomeHub { get; set; }
            public string Type {get; set;}
            public string Name { get; set; }



        }

        class Edge
        {
            private float weight; //distance of the edge
            private Station station1, station2; //stations the edge is connected to
            private Hub hub; //hub that the edge is connected to. Will not be used for most edges since most edges will not be connected to a hub
            private float startAvailableTime, endAvailableTime; //the time between that the edge is available

            public float Weight { get; set; }
            public Station Station1 { get; set; }
            public Station Station2 { get; set; }
            public Hub Hub { get; set; }
            public float StartAvailableTime { get; set; }
            public float EndAvailableTime { get; set; }


        }

        class Station
        {
            private string type; //either passenger or freight
            private int maxNumberOfTrains; //the maxium number of trains that can be at a station at once
            private int randomOnRangeLower, randonOnRangeUpper; //range for how many passengers will get on the passenger train. 0 for freight trains
            private int randonOffRangelower, randomOffRangeUpper; //range for how many passengers will get off the passenger train. 0 for freight trains
            private string name; //name of the station

            public string Name { get; set; } //get and set for name of station
            public string Type { get; set; }
            public int MaxNumberOfTrains { get; set; }
            public int RandomOnRangeLower { get; set; }
            public int RandomOnRangerUpper { get; set; }
            public int RandomOffRangerLower { get; set; }
            public int RandomOffRangeUpper { get; set; }


        }

        public void buildRailroad(BidirectionalGraph<object, IEdge<object>> RailroadGraph, int numberOfHubs, int numberOfStations, int numberOfEdges, int numberOfLocomotives )
        {
            RailroadGraph = new BidirectionalGraph<object, IEdge<object>>();

            List<Hub> hubs = new List<Hub>(); //list of hubs
            for (int i = 0; i < numberOfHubs; i++) //adding hubs to the graph as vertices
            {
                Hub newHub  = new Hub { Name = "Hub " + (i + 1).ToString() };


                hubs.Add(newHub);
                RailroadGraph.AddVertex(hubs[i].Name);
            }


            List<Station> stations = new List<Station>(); //list of stations
            for (int i = 0; i < numberOfStations; i++) //adding stations to the graph as verticies
            {
                Station newStation = new Station { Name = "Station " + (i + 1).ToString() };

                stations.Add(newStation);
                RailroadGraph.AddVertex(stations[i].Name);
            }

            List<Edge> edges = new List<Edge>();
            for (int i = 0; i < numberOfStations; i++) //adding stations to the graph as verticies
            {
                Edge newEdge = new Edge();

                edges.Add(newEdge);
                RailroadGraph.AddEdge(new Edge<object>(edges[i].Station1, edges[i].Station2));
            }

        }


    }
}
