namespace MethodMethodOverload
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num = InsertNumber();
            num=SumNumeralsInNumber(num);
            Console.WriteLine(num);
        }


        public static int SelectMinELementInArray(int[] array)
        {
            int min=array[0];
            for (int i = 1; i < array.Length; i++)
            {
                if (array[i] < min)
                {
                    min = array[i];
                }
            }
            return min;
        }



        public static int Area(int r)
        {
            int area = 3 * r * r;
            return area;
        }
        public static int Area(int a,int b)
        {
            int area = a * b;
            return area;
        }
        public static int Area(int a,int b, int c)
        {
            int area=2 * (a * b + a * c + b * c);
            return area;
        }
        public static int Area(int r,int a,int b,int c)
        {
            int p = (a + b + c) / 2;
            int area = p * r;
            return area;
        }


        public static int InsertNumber()
        {
            Console.WriteLine("Eded daxil edin(Musbet!):");
            bool isParse = int.TryParse(Console.ReadLine(), out int num);
            if(!isParse || num<0)
            {
                num=InsertNumber();
            }
            return num;
        }
        public static int SumNumeralsInNumber(int num)
        {
            int sum = 0;
            while(num > 0)
            {
                sum += num % 10;
                num /= 10;
            }
            return sum;
        }
    }
}