using AwWidgetsDemoApp.mocking;
using AwWidgetsDemoApp.models;

namespace AwWidgetsDemoApp
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
            InitializeDataGathering();
            Form1.CheckForIllegalCrossThreadCalls = false;
        }

        private void InitializeDataGathering()
        {
            appDataProvider = AppDataProvider.GetInstance();
            gazeDataProvider = GazeDataProvider.GetInstance();

            appDataProvider.AppDataReceived += this.OnAppDataReceived;
            gazeDataProvider.GazeDataReceived += this.panel5.getController().OnGazeDataReceived;

            appDataProvider.run();
            gazeDataProvider.run();
        }

        public void OnAppDataReceived(object source, AppDataEventArgs e)
        {
            this.name.Text = e.MedicalRecordSnapshot.Name;
            this.f_card.Text = e.MedicalRecordSnapshot.F_card;
            this.f_resp.Text = e.MedicalRecordSnapshot.F_resp;

            this.temp_value.Text = e.MedicalRecordSnapshot.Temp;
            this.spO2_value.Text = e.MedicalRecordSnapshot.Sat_o2;
            this.co2_value.Text = e.MedicalRecordSnapshot.Sat_co2;

            this.mean_val.Text = e.MedicalRecordSnapshot.T_mean;
            this.sistolica.Text = e.MedicalRecordSnapshot.T_sist;
            this.distolica.Text = e.MedicalRecordSnapshot.T_dis;
        }
    }
}