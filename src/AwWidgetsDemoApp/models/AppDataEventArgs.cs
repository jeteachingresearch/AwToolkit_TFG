using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AwWidgetsDemoApp.models
{
    public class AppDataEventArgs : EventArgs
    {
        public MedicalRecordSnapshot MedicalRecordSnapshot { get; set; }

        public AppDataEventArgs(MedicalRecordSnapshot medicalRecordSnapshot)
        {
            MedicalRecordSnapshot = medicalRecordSnapshot;
        }

        public override string ToString()
        {
            return "AppDataEventArgs: { MedicalRecordSnapshot: " + MedicalRecordSnapshot + "}";
        }
    }
}
