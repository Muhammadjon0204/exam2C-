using TASK1;

TASK1.Math math=new TASK1.Math();



System.Console.WriteLine("Vvedite chisla : (double , int)");
double value1=Convert.ToDouble(Console.ReadLine());
int value2=Convert.ToInt32(Console.ReadLine());
double v1=math.ABSOLUTE(value1);
int v2=math.ABSOLUTE(value2);
System.Console.WriteLine($"Absolute of v1 : {v1}");
System.Console.WriteLine($"Absolute of v2 : {v2}");


 System.Console.WriteLine("Vvedite  chislo : ");
 double ch=Convert.ToDouble(Console.ReadLine());
System.Console.WriteLine("Vvedite stepen : ");
double st=Convert.ToDouble(Console.ReadLine());
double result=math.PowN(ch,st);
System.Console.WriteLine($"Otvet : {result}");

System.Console.WriteLine("Vvedite iskomoe : ");
int chislo=Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine($"Koren : {math.SQRT(chislo)}");


System.Console.WriteLine("Vvedite dva chisla : ");
int val1=Convert.ToInt32(Console.ReadLine());
int val2=Convert.ToInt32(Console.ReadLine());

System.Console.WriteLine($"Maximum : {math.Max(val1,val2)}");
System.Console.WriteLine($"Minimum : {math.Min(val1,val2)}");

