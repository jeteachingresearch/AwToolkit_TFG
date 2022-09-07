using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AwWidgetsDemoApp.models
{
    public class MedicalRecordSnapshot
    {
        public string Name { get; set; }
        public string F_card { get; set; }
        public string T_sist { get; set; }
        public string T_dis { get; set; }
        public string T_mean { get; set; }
        public string F_resp { get; set; }
        public string Sat_o2 { get; set; }
        public string Sat_co2 { get; set; }
        public string Temp { get; set; }

        public MedicalRecordSnapshot(
            string name, string f_card, string t_sist, 
            string t_dis, string t_mean, string f_resp,
            string sat_o2, string sat_co2, string temp) { 

            Name = name;
            F_card = f_card;
            T_sist = t_sist;
            T_dis = t_dis;
            T_mean = t_mean;
            F_resp = f_resp;
            Sat_o2 = sat_o2;
            Sat_co2 = sat_co2;
            Temp = temp;
        }

        public override bool Equals(object? obj)
        {
            return obj is MedicalRecordSnapshot snapshot &&
                   Name == snapshot.Name &&
                   F_card == snapshot.F_card &&
                   T_sist == snapshot.T_sist &&
                   T_dis == snapshot.T_dis &&
                   T_mean == snapshot.T_mean &&
                   F_resp == snapshot.F_resp &&
                   Sat_o2 == snapshot.Sat_o2 &&
                   Sat_co2 == snapshot.Sat_co2 &&
                   Temp == snapshot.Temp;
        }

        public override int GetHashCode()
        {
            HashCode hash = new HashCode();
            hash.Add(Name);
            hash.Add(F_card);
            hash.Add(T_sist);
            hash.Add(T_dis);
            hash.Add(T_mean);
            hash.Add(F_resp);
            hash.Add(Sat_o2);
            hash.Add(Sat_co2);
            hash.Add(Temp);
            return hash.ToHashCode();
        }
    }
}
