namespace BeeCrowd
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Prolem no 1000
            //Console.WriteLine("Hello World!");
            //problem no 1001
            //int A, B, X;
            //A = int.Parse(Console.ReadLine());
            //B = int.Parse(Console.ReadLine());
            //X = A + B;
            //Console.WriteLine("X =" + X);


            //problem no 1002

            //double A, R;
            //double n = 3.14159;
            //R = double.Parse(Console.ReadLine());
            //A = n *(Math.Pow(R, 2));            
            //Console.WriteLine("A="+A.ToString("F4"));

            //problem no 1003

            //int A, B, SOMA;
            //A = int.Parse(Console.ReadLine());
            //B = int.Parse(Console.ReadLine());
            //SOMA = A + B;
            //Console.WriteLine("SOMA = "+SOMA);

            //problem no 1004

            //int A, B, PROD;
            //A=int.Parse(Console.ReadLine());
            //B=int.Parse(Console.ReadLine());
            //PROD = A * B;
            //Console.WriteLine("PROD = " + PROD);

            //problem no 1005
            //double A, B;
            //double  WeightA = 3.5;
            //double WeightB = 7.5;
            //A = double.Parse(Console.ReadLine());
            //B = double.Parse(Console.ReadLine());
            //double MEDIA=((A*WeightA)+(B*WeightB))/(WeightA+WeightB);
            //Console.WriteLine("MEDIA = "+MEDIA.ToString("F5"));

            //problem no 1006

            double A, B, C;
            double WeightA =2;
            double WeightB =3;
            double WeightC = 5;
            A = double.Parse(Console.ReadLine());
            B = double.Parse(Console.ReadLine());
            C = double.Parse(Console.ReadLine());
            double MEDIA = ((A * WeightA) + (B * WeightB)+(C*WeightC)) / (WeightA + WeightB+WeightC);
            Console.WriteLine("MEDIA = " + MEDIA.ToString("F1"));

        }
    }
}
