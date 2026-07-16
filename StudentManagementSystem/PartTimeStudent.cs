namespace StudentManagementSystem
{
    class PartTimeStudent : Student
    {
        public PartTimeStudent(int id, string name, string dept)
            : base(id, name, dept)
        {
        }

        public override double CalculateFee()
        {
            return TotalCredits() * 800;
        }

        public override string StudentType()
        {
            return "Part-Time";
        }
    }
}
