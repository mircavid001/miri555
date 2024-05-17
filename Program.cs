


#region do-while
//int reqem1 = 15;
//int reqem2 = 2;


//int cem = reqem1 + reqem2;
//int cixma = reqem1 - reqem2;
//int vurma = reqem1 * reqem2;
//int bolma = reqem1 / reqem2;
//Console.WriteLine("cem: " + cem);
//Console.WriteLine("cixma: " + cixma);
//Console.WriteLine("vurma: " + vurma);
//Console.WriteLine("bolma: " + bolma);


//string ad = "mircavid";
//Console.WriteLine(ad);

//int reqem1 = 9;
//int reqem2 = 10;

//bool netice = reqem1 > reqem2;
//Console.WriteLine(netice);

//int reqem1 = 1997;
//int reqem2 = 2024;
//Console.WriteLine(reqem2 - reqem1);

//Console.WriteLine("plise enter your name");
//string name = Console.ReadLine();
//Console.WriteLine("your name is: " + name);


//istifadeciden yashini isdemek ve yashini hesablamaq

//Console.WriteLine("zehmet olmasa tevelludunuzu qeyd edin");
//int tevellud = int.Parse(Console.ReadLine());
//int netice = 2024-tevellud;
//Console.WriteLine("sizin yasiniz: " + netice);
//Console.WriteLine($"sizin yasiniz {netice}");


//boyukdur kicikdir

//Console.WriteLine("please enter first number");
//int reqem1 = int.Parse(Console.ReadLine());
//Console.WriteLine("pleas enter second number");
//int reqem2 = int.Parse(Console.ReadLine());

//if (reqem1 > reqem2)
//{
//    Console.WriteLine($"{reqem1} boyukdur");
//}
//else if (reqem1 == reqem2)
//    Console.WriteLine("ededler beraberdir");
//else
//{
//    Console.WriteLine($"{reqem2} boyukdur");
//}


#endregion


//" == "assigment - menimsetmek
// " == " deyishenin deyerlerini beraber olub olmadigini yoxlayir
// " != " beraber deil demekdir 
//int num1 = 5;
//int num2 = 8;

//if (num1 == num2)
//{
//    Console.WriteLine("beraberdir");

//}
//else if (num1 > num2)
//{
//    Console.WriteLine(num1 + " boyukdur");
//}
//else
//{
//    Console.WriteLine(num2 + " boyukdur");
//}


//int num1 = 9;
//int num2 = 9;

//if (num1 != num2)
//{
//    Console.WriteLine("beraber deyil");
//}
//else
//{
//    Console.WriteLine("beraberdir");
//}


//Console.WriteLine("1. enter name");
//Console.WriteLine("2. enter surname");
//Console.WriteLine("3. enter age");

//string secim = Console.ReadLine();
//switch (secim)
//{
//    case "1":

//       Console.WriteLine("zehmet olmasa adinizi daxil edin");
//        string name = Console.ReadLine();
//        Console.WriteLine(name);
//        break;

//    case "2":
//        Console.WriteLine("soyadinizi daxil edin");
//        string surname = Console.ReadLine();
//        Console.WriteLine(surname);
//        break;

//        case "3":
//        Console.WriteLine("yashinizi daxil edin");
//        string age = Console.ReadLine();
//        Console.WriteLine(age);
//        break;



//}

using System.Runtime;

string[] adlar = { "turkie", "gurcustan", "azerbaican", "russia", };

   for (int i = 0; i < adlar.Length; i++)
{
    Console.WriteLine(adlar[i]);
}

int[] regemler = { 2, 4, 5, 6, 7, };
for (int i = 0;i < regemler.Length; i++)
{
    Console.WriteLine(regemler[i]);
}