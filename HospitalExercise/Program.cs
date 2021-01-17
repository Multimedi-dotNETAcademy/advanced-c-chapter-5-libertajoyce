using System;

namespace HospitalExerciseInheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            Patient patient1 = new Patient();
            patient1.Name = "John Doe";
            patient1.BaseRate = 50;
            patient1.HourlyRate = 20;
            patient1.TotalHours = 8;
           
            patient1.ShowInfo();

            InsuredPatient patient2 = new InsuredPatient();
            patient2.Name = "Jane Doe";
            patient2.BaseRate = 50;
            patient2.HourlyRate = 20;
            patient2.TotalHours = 8;

            patient2.ShowInfo();


        }
    }
}
