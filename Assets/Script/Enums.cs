using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assets.Script
{
    public static class Enums
    {
        public class Illness
        {
            public string Name { get; set; }
            public string Description { get; set; }
            public string[] Symptoms { get; set; }
            public string[] Treatment { get; set; }
        }

        public class PatientData
        {
            public string FirstName { get; set; }
            public string LastName { get; set; }
            public DateTime DOB { get; set; }
            public float Weight { get; set; }
            public float Height { get; set; }
            public Illness Illness { get; set; }
        }
    }
}
