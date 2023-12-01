#region Task1
//Console.WriteLine("Birinci ededi daxil et");
//string input1 = Console.ReadLine();

//Console.WriteLine("2-ci ededi daxil edin");
//string input2 = Console.ReadLine();

//Console.WriteLine($"Daxil edilen melumat: {input1} 2-ci eded : {input2}");

//int input1Num = int.Parse(input1);
//int input2Num = int.Parse(input2);

//Console.WriteLine();

//int result = input2Num + input1Num;

//if (result % 2 == 0)
//{
//    Console.WriteLine($"Cut ededdir {result}");
//}
//else
//{
//    Console.WriteLine("Tek ededdir");
//}
#endregion Task1

#region Task2
//int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
//Console.WriteLine("Massivdeki cut ededler:");

//foreach (int number in numbers)
//{
//    if (number % 2 == 0)
//    {
//        Console.WriteLine(number);
//    }
//}
#endregion Task2

#region Task3
//int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
//int result = 0;
//Console.WriteLine("Massivdeki tek ededler:");

//for (int i = 0; i < numbers.Length; i++)
//{
//    if (numbers[i] % 2 != 0)
//    {

//        result = result + numbers[i];
//    }


//}
//Console.WriteLine(result);
#endregion Task3

#region Task4
//class Program
//{
//    static void Main()
//    {
//        Console.Write("Ededi daxil edin: ");
//        string input = Console.ReadLine();

//        if (IsFourDigitNumber(input))
//        {
//            int sum = CalculateSumOfDigits(input);
//            Console.WriteLine($"Ededin reqemlerinin cemi: {sum}");
//        }
//        else
//        {
//            Console.WriteLine("Sehv! Eded 4 reqemli olmalidir.");
//        }
//    }

//    static bool IsFourDigitNumber(string input)
//    {
//        return input.Length == 4 && int.TryParse(input, out _);
//    }

//    static int CalculateSumOfDigits(string input)
//    {
//        int sum = 0;
//        foreach (char digitChar in input)
//        {
//            sum += int.Parse(digitChar.ToString());
//        }
//        return sum;
//    }
//}
#endregion Task4

#region Task5
//class Student
//{
//    public string Name { get; set; }
//    public string Surname { get; set; }
//    public int Age { get; set; }
//    public string Specialty { get; set; }
//    public string GroupNo { get; set; }

//    static void Main()
//    {
//        Student student1 = new Student();
//        student1.Name = "Konul";
//        student1.Surname = "Maharramzade";
//        student1.Age = 24;
//        student1.Specialty = "Economy";
//        student1.GroupNo = "P419";

//        Student student2 = new Student();
//        student2.Name = "Shahin";
//        student2.Surname = "Aliyev";
//        student2.Age = 21;
//        student2.Specialty = "IT";
//        student2.GroupNo = "P419";

//        Student[] arrStudents = { student1, student2 };

//        for (int i = 0; i < arrStudents.Length; i++)
//        {
//            Console.WriteLine($"Student {i + 1} information:");
//            Console.WriteLine($"Name: {arrStudents[i].Name}; Surname: {arrStudents[i].Surname};Age: {arrStudents[i].Age}; Specialty: {arrStudents[i].Specialty}; GroupNo: {arrStudents[i].GroupNo}");
//            Console.WriteLine();
//        }
//    }
//}
#endregion Task5












