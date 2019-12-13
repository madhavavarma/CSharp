
namespace CSharp.Basic {

    using System;

    public static class Array {

        public static void Execute() {
            Console.WriteLine("Array");
            Initialize();
        }

        public static void Initialize() {
            int[] intArray = new int[5] {1,2,3,4,5};

            for(int i=0; i<intArray.Length; i++) {
                Console.WriteLine(intArray[i]);
            }
        }
    }
}