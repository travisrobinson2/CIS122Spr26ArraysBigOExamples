namespace CIS122Spr26ArraysBigOExamples
{
    public class BigOExamples
    {
        public static void Main()
        {
            Console.WriteLine("CIS122Spr26ArraysBigOExamples");

            int[] myArray = new int[1000];


            //O(1) - constant
            var myVar = myArray[0];


            //(N) - linear
            for (int i = 0; i < myArray.Length; i++)
            {
                Console.WriteLine(myArray[i]);
            }



            //removing element from array
            //O(N) - linear, cycling through most elements, aN - 4, look at largest factor
            int lastIndex = myArray.Length - 1;

            for (int i = 4; i < myArray.Length; i++)
            {
                myArray[i] = myArray[i + 1];
            }

            lastIndex--;

            //adding element to array
            //O(N) - linear, cycling through most elements
            int targetIndex = 5;
            int newValue = 42;

            for (int i = myArray.Length - 1; i > targetIndex; i--)
            {
                myArray[i] = myArray[i - 1];
            }
            myArray[targetIndex] = newValue;
            lastIndex++;



            //10000000 * 10000000
            //10*10
            //O(N^2) - quadratic, nested loops, N*N
            for (int i = 0; i < myArray.Length; i++)
            {
                int myVal = myArray[i];
                for (int j = 0; j < myArray.Length; i++)
                {
                    myVal = myArray[j] + myVal;
                }
                myArray[i] = myVal;
            }

            //N * N^2 = N^3
            for (int k = 0; k < myArray.Length; k++)
            {
                for (int i = 0; i < myArray.Length; i++)
                {
                    int myVal = myArray[i];
                    for (int j = 0; j < myArray.Length; i++)
                    {
                        myVal = myArray[j] + myVal;
                    }
                    myArray[i] = myVal;
                }
            }
        }
    }
}