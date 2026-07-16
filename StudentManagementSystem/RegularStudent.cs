namespace StudentManagementSystem
{
    class RegularStudent : Student
    {
        public RegularStudent(int id, string name, string dept)
            : base(id, name, dept)
        {
        }

        public override double CalculateFee()
        {
            return TotalCredits() * 1000;
        }

        public override string StudentType()
        {
            return "Regular";
        }
    }
}
