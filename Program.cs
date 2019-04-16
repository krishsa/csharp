using System;

namespace csharp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            sen();
        }

        static void krish() {
            int[] nos = new int[6] {3,5,6,6,7,7};
            int[] distinct = new int[6];
            distinct[0] = nos[0];
            int nextIndex = 1;
            for(int i=1; i<nos.Length;i++)
            {
                for(int j=1;j<(distinct.Length);j++)
                {
                    if(nos[j] != distinct[j-1])
                    {
                        distinct[nextIndex] = nos[j];
                    }
                }
                nextIndex++;
            }

            Console.WriteLine("Remove duplicate values from the array....");
            for(int i=0;i<distinct.Length;i++)
            {
                Console.Write(distinct[i] + " ");
            } 
        }

        static void sen() {
            int[] nos = new int[6] {3,5,6,6,7,7};
            int[] distinct = new int[nos.Length];
            distinct[0] = nos[0];
            int currentIndex =1;
            for(int i = 1; i<nos.Length; i++){
                if(!exist(nos[i], distinct)){
                    distinct[currentIndex] = nos[i];
                    currentIndex++;
                }
            }

            for(int i=0; i< currentIndex;i++){
                Console.WriteLine(distinct[i]);
            }
        }

        static bool exist(int element, int[] arr){
            for(int i = 0; i<arr.Length; i++){
                if(arr[i] == element){
                    return true;
                }
            }
            return false;
        }

    }
}
