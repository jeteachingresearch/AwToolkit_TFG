using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using AwWidgetsDemoApp.models;

namespace AwWidgetsDemoApp.mocking
{
    internal class AppDataProvider
    {
        private static AppDataProvider _instance;

        System.Threading.Thread _thread;

        private bool isRunning;

        private readonly Random _random;

        private List<MedicalRecordSnapshot> medicalRecords;

        private AppDataProvider() 
        { 
            _random = new Random();
            this.isRunning = false;
            this.medicalRecords = new List<MedicalRecordSnapshot>();

            _thread = new System.Threading.Thread(SendData);
            _thread.IsBackground = true;

            var record1 = new MedicalRecordSnapshot("Test Subject", "60", "100", "90", "93", "17", "98", "23", "36.5");
            this.medicalRecords.Add(record1);
            var record2 = new MedicalRecordSnapshot("Test Subject", "61", "101", "90", "93", "17", "98", "20", "36.5");
            this.medicalRecords.Add(record2);
            var record3 = new MedicalRecordSnapshot("Test Subject", "60", "100", "89", "93", "17", "96", "25", "37");
            this.medicalRecords.Add(record3);
            var record4 = new MedicalRecordSnapshot("Test Subject", "62", "100", "90", "93", "18", "99", "23", "38");
            this.medicalRecords.Add(record4);
            var record5 = new MedicalRecordSnapshot("Test Subject", "59", "100", "90", "93", "17", "98", "24", "38");
            this.medicalRecords.Add(record5);
        }

        public static AppDataProvider GetInstance()
        {
            if (_instance == null)
            {
                _instance = new AppDataProvider();
            }
            return _instance;
        }

        public void run()
        {
            if (this.isRunning)
            {
                throw new Exception("AppDataProvider is already running!");
            }
            this.isRunning = true;
            _thread.Start();
        }

        public void stop()
        {
            this.isRunning = false;
            _thread.Join();
        }

        public delegate void AppDataReceivedEventHandler(object source, AppDataEventArgs e);
        public event AppDataReceivedEventHandler AppDataReceived;

        protected virtual void OnAppDataReceived(MedicalRecordSnapshot medicalRecordSnapshot)
        {
            if (AppDataReceived != null)
            {
                AppDataReceived(this, new AppDataEventArgs(medicalRecordSnapshot));
            }
        }

        private void SendData()
        {
            while (isRunning)
            {
                var chosen = _random.Next(0, medicalRecords.Count());
                OnAppDataReceived(
                    medicalRecords.ElementAt(chosen)
                );
                Thread.Sleep(5000);
            }
        }

    }
}
