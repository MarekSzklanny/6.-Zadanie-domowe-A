namespace _6._Zadanie_domowe_A
{
    public class Employee
    {
        private List<int> score = new List<int>();
        public Employee(string name, string surname, int age)
        {
            Name = name;
            Surname = surname;
            Age = age;
        }
        public string Name { get; private set; }
        public string Surname { get; private set; }
        public int Age { get; private set; }

        public int Result
        {
            get
            {
                return score.Sum();
            }
        }
        public void AddScore(int number)
        {
            this.score.Add(number);
        }
    }
}
