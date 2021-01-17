namespace HospitalExerciseInheritance
{
    internal class Patient
    {
        public string Name { get; set; }

        public int TotalHours { get; set; }

        public int BaseRate { get; set; }

        public int HourlyRate { get; set; }

        public virtual decimal CalculateCosts()
        {
            decimal result = (HourlyRate * TotalHours) + BaseRate;
            return result;
        }

        public void ShowInfo()
        {
            System.Console.WriteLine($"Patient Name: {Name} - Total hours in hospital: {TotalHours} hours - Total costs: {CalculateCosts()} euros");
        }
    }
}