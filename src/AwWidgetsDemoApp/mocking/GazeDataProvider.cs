using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using AwWidgetsCore.models;

namespace AwWidgetsDemoApp.mocking
{
    internal class GazeDataProvider
    {
        private static GazeDataProvider _instance;

        System.Threading.Thread _thread;

        private readonly Random _random;

        private bool isRunning;

        private List<Tuple<int,int>> gazePoints;

        private GazeDataProvider()
        {
            _random = new Random();
            this.isRunning = false;
            this.gazePoints = new List<Tuple<int, int>>();

            _thread = new System.Threading.Thread(SendData);
            _thread.IsBackground = true;

            this.gazePoints.Add(Tuple.Create(10, 10));
            this.gazePoints.Add(Tuple.Create(20, 30));
            this.gazePoints.Add(Tuple.Create(40, 40));
            this.gazePoints.Add(Tuple.Create(43, 43));
            this.gazePoints.Add(Tuple.Create(45, 45));
            this.gazePoints.Add(Tuple.Create(45, 45));
            this.gazePoints.Add(Tuple.Create(450, 405));
            this.gazePoints.Add(Tuple.Create(250, 150));
            this.gazePoints.Add(Tuple.Create(75, 10));
            this.gazePoints.Add(Tuple.Create(0, 0));
            this.gazePoints.Add(Tuple.Create(500, 500));
            this.gazePoints.Add(Tuple.Create(23, 300));
        }

        public static GazeDataProvider GetInstance()
        {
            if (_instance == null)
            {
                _instance = new GazeDataProvider();
            }
            return _instance;
        }

        public void run()
        {
            if (this.isRunning)
            {
                throw new Exception("GazeDataProvider is already running!");
            }
            this.isRunning = true;
            
            _thread.Start();
        }

        public void stop()
        {
            this.isRunning = false;
            _thread.Join();
        }

        public delegate void GazeDataReceivedEventHandler(object source, GazeDataEventArgs<SpecificGazeData> e);
        public event GazeDataReceivedEventHandler GazeDataReceived;

        protected virtual void OnGazeDataReceived(SpecificGazeData gazeData)
        {
            if (GazeDataReceived != null)
            {
                Console.WriteLine("Sending message!");
                GazeDataReceived(this, new GazeDataEventArgs<SpecificGazeData>(gazeData));
            }
        }

        private void SendData()
        {
            while (isRunning)
            {
                var chosen = _random.Next(0, gazePoints.Count());
                OnGazeDataReceived(
                    new SpecificGazeData(gazePoints.ElementAt(chosen))
                );
                Thread.Sleep(1000);
            }
        }
    }
}
