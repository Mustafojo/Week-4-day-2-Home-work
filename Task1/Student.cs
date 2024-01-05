class Student : Person
{
    public void Study()
    {
        System.Console.WriteLine("I'm studying");
    }
    public string ShowAge()
    {
        return $"My age is: {Age} years old";
    }
}