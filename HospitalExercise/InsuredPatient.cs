namespace HospitalExerciseInheritance
{
    internal class InsuredPatient : Patient
    {
        public override decimal CalculateCosts()
        {
            decimal baseCalc = base.CalculateCosts();
            decimal resultPercentage = baseCalc - ( (baseCalc * 10) / 100 );

            return resultPercentage;
        }
    }
}