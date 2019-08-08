using System;
using System.Collections.Generic;


namespace basic_13
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] numbers= {2,5,5,8,9,6,3,65,-88};
            
        // PrintNumbers();
        // PrintOdds();
        // PrintSum();
        // LoopArray(numbers);
        // FindMax(numbers);
        // GetAverage(numbers);
        // OddArray();
        GreaterThanY(numbers, 6);
        // SquareArrayValues(numbers);
        // EliminateNegatives(numbers);
        // MinMaxAverage(numbers);
        // ShiftValues(numbers);**************
        // NumToString(numbers);
        }

        public static void PrintNumbers(){
                for (int i=0; i<256; i++){
                System.Console.WriteLine(i);
            }
        }

        public static void PrintOdds(){
               for(int i=0;i<256; i++){
                if (i%2!=0)
                System.Console.WriteLine(i);
            }
        }

        public static void PrintSum()
        {
            int sum = 0;
            for (int i=0; i<256; i++){
                System.Console.WriteLine(i);
                sum += i;
                System.Console.WriteLine(sum);
            }
        }

        public static void LoopArray(int[] numbers)
        {
            for(int i=0; i<numbers.Length; i++){
                System.Console.WriteLine(numbers[i]);
            }
        }

        public static int FindMax(int[] numbers)
        {
            int max = 0;
            for (int i=0; i<numbers.Length; i++){
                if(numbers[i]>max)
                    max=numbers[i];
            }
            System.Console.WriteLine(max);
            return max;
        }

        public static void GetAverage(int[] numbers)
        {
            int sum = 0; 
            double avg = 0; 
            for (int i=0; i<numbers.Length; i++){
                sum += numbers[i];
            }
            avg = sum/numbers.Length;
            System.Console.WriteLine(avg);
        }

        public static int[] OddArray()
        {
            List<int> myList = new List<int>();
            for (int i=1; i<=255 ; i++){
                if (i%2!=0){
                    myList.Add(i);
                }
            }
            foreach(var item in myList){
                System.Console.WriteLine(item);
            }
            return myList.ToArray();
        }

        public static int GreaterThanY(int[] numbers, int y)
        {  
            int count = 0;
            for (int i=0; i<numbers.Length; i++){
                if(numbers[i]>y)
                    count +=1;
            }
            System.Console.WriteLine(count);
            return count;
        }


        public static void SquareArrayValues(int[] numbers)
        {
            for (int i=0; i<=numbers.Length-1; i++){
                numbers[i]*= numbers[i];
                System.Console.WriteLine(numbers[i]);
            }
        }

        public static void EliminateNegatives(int[] numbers)
        {
            for (int i=0; i<=numbers.Length-1; i++){
                if (numbers[i]< 0)
                numbers[i]=0;

                System.Console.WriteLine(numbers[i]);
            }
        }

        public static void MinMaxAverage(int[] numbers)
        {
            int max = numbers[0];
            int sum = numbers[0]; 
            int min = numbers[0]; 
            double avg = 0; 

            for (int i=0; i<numbers.Length; i++){
                if(numbers[i]>max)
                    max=numbers[i];
            }

            for (int i=0; i<numbers.Length; i++){
                if(numbers[i]<min)
                    min=numbers[i];
            }
        
            for (int i=0; i<numbers.Length; i++){
                sum += numbers[i];
            }

            avg = sum/numbers.Length;

            System.Console.WriteLine(min);
            System.Console.WriteLine(max);
            System.Console.WriteLine(avg);
        }





        // public static void ShiftValues(int[] numbers)
        // {


        // }




        public static object[] NumToString(int[] numbers)
        {
            object[] arr = new object[numbers.Length];
            for (int i=0; i<=arr.Length-1; i++){

                if (numbers[i] <  0){
                arr[i]= "Dojo" ;
                }
                else{
                    arr[i]=numbers[i];
                }
                System.Console.WriteLine(arr[i]);
            }
            return arr;
        }







    }
}
