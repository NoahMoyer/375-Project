﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using QuickGraph;

namespace GraphSharpTutorial01
{
    class FileInputClass
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

            public List<Locomotive> LocomotivesInHub //get method for locommotivesInHub
            {
                get { return locomotivesInHub; }
                

            }

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


            public string Name //get and set for name
            {
                get { return name; }
                set { name = value; }
            }

        }

        class Locomotive
        {
            private Hub homeHub; //home hub for the locomotive
            private string type; //either passenger or freight
            private string name; //name of the locomotive

            public Hub HomeHub
            {
                get { return homeHub; }
                set { homeHub = value; }
            }



        }

        class Edge
        {
            private float weight; //distance of the edge
            private Station station1, station2; //stations the edge is connected to
            private Hub hub; //hub that the edge is connected to. Will not be used for most edges since most edges will not be connected to a hub
            private float startAvailableTime, endAvailableTime; //the time between that the edge is available


        }

        class Station
        {
            private string type; //either passenger or freight
            private int maxNumberOfTrains; //the maxium number of trains that can be at a station at once
            private int randomOnRangeLower, randonOnRangeUpper; //range for how many passengers will get on the passenger train. 0 for freight trains
            private int randonOffRangelower, randomOffRangeUpper; //range for how many passengers will get off the passenger train. 0 for freight trains
            private string name; //name of the station


        }

        public void buildRailroad(int numberOfHubs, int numberOfStations, int numberOfEdges, int numberOfLocomotives)
        {
            var RailroadGraph = new BidirectionalGraph<object, IEdge<object>>();

            List<Hub> hubs = new List<Hub>(); //list of hubs
            for (int i = 0; i < numberOfHubs; i++) //adding hubs to the graph as vertices
            {
                hubs.
                RailroadGraph.AddVertex(hubs[i]);
            }


            List<Station> stations = new List<Station>(); //list of stations
            for (int i = 0; i < numberOfHubs; i++) //adding stations to the graph as verticies
            {
                stations.Add("Station " + (i + 1).ToString());
                RailroadGraph.AddVertex(stations[i]);
            }



        }


    }
}
