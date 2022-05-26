namespace CSClass
{
    internal class Student
    {
        public string name;
        public int grade;
        public override string ToString()
        {
            return grade + "학년 " + name;
        }
    }
}