namespace Computershare_Code_Test
{
    class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public int PickedNumber { get; set; }

        public Person(int age, string name, int pickedNumber)
        {
            Age = age;
            Name = name;
            PickedNumber = pickedNumber;
        }
      
    }
}
