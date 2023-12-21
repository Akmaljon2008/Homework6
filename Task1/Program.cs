var t1 = new Teacher();
t1.Name = Console.ReadLine();
t1.Subject = Console.ReadLine();
t1.Expiarence = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine(t1.Name);
System.Console.WriteLine(t1.Subject);
System.Console.WriteLine(t1.Expiarence);



class Teacher{
    private string fullName;
    private string subject;
    private int expiarence;

    public string Name{
        get {
            return fullName;
        }
        set {
            fullName = value;
        }
    }
    public string Subject{
        get {
            return subject;
        }
        set {
            subject = value;
        }
    }
    public int Expiarence{
        get {
            return expiarence;
        }
        set {
            expiarence = value;
        }
    }
    public Teacher(){

    }
    public Teacher(){
        System.Console.WriteLine($"{Name} {Subject}");
    }
}