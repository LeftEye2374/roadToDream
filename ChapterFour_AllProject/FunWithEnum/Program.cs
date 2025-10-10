using System;

class Program {

   static void Main(string[] args)
    {
        Console.WriteLine("*********** Fun with enums ***********");
        EmpTypeEnum emp = EmpTypeEnum.Contractor;
        AskForBonus(emp);
        Console.ReadLine();
    }


enum EmpTypeEnum : byte
    {
        Manager = 102,
        Grunt, // =103
        Contractor, // =104
        VicePresident // =105
    }

    static void AskForBonus(EmpTypeEnum e)
    {
        switch (e)
        {
            case EmpTypeEnum.Manager:
                Console.WriteLine("How about stock options instead?");
                break;
            case EmpTypeEnum.Grunt:
                Console.WriteLine("You have got to be kidding...");
                break;
            case EmpTypeEnum.Contractor:
                Console.WriteLine("You already get enough cash...");
                break;
            case EmpTypeEnum.VicePresident:
                Console.WriteLine("VERY GOOD, Sir");
                break;
        }

    } 
}