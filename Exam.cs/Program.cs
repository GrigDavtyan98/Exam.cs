namespace Exam.cs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("greq Narcis tiv, narcis tiv e hamarvum ayn tivy, vory havasar e ir tvanshery barcacrac tvanshaneri qanaki astichanneri gumarin");
            var userNum = Console.ReadLine();
            string count;
            int calck=0;
            var addCount = Add(Convert.ToInt32(userNum));

            for(var  i = 0;i<userNum.Length;i++)
            {
                count = userNum[i] + "";
                int userNumber = Convert.ToInt32(count);
                calck = calck + Calck(userNumber,addCount);
            }

            if (calck == Convert.ToInt32(userNum))
            {
                Console.WriteLine(true);
            }
            else
            {
               Console.WriteLine(false);
            }
           
        }
        static  int Add(int number)
        {
            int count = 0;
            while (number > 0)
            {
                number = number / 10;
                count++;
            }
            return count;
            
        }
        static int Calck(int number,int qanak)
        {
            var sum = 1;
            for(var i = 0; i<qanak; i++)
            {
                sum = sum * number;

            }
                return sum;

        }


    }
}