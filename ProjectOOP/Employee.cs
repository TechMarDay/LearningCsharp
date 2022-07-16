namespace ProjectOOP
{

    public abstract class Employee
    {
        public string ID { get; set; }
        public string FirstName { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
        public void GetName()
        { Console.WriteLine("Họ và tên:" + FirstName + Name); }
        public abstract void GetInformation();


    }
}

