using System;

namespace Day_04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region problem1
            int[] array1 = new int[5]; //new int [size]
            int[] array2 = { 1, 2, 3, 4, 5 }; // initailizer list
            int[] array3 = new[] { 6, 7, 8, 9, 10, 11, }; // syntax sugar
            
            // assign values
            array1[0] = 1; array1[1] = 2; array1[2] = 3; array1[3] = 4; array1[4] = 5;
            Console.WriteLine(array1[0]);
            Console.WriteLine(array1[1]);
            Console.WriteLine(array1[2]);
            Console.WriteLine(array1[3]);
            Console.WriteLine(array1[4]);

            // Demonstrates an IndexOutOfRangeException. 2 ways but i will use only one 
            //try catch
            try
            {
                Console.WriteLine(array1[0]);
                Console.WriteLine(array1[1]);
                Console.WriteLine(array1[2]);
                Console.WriteLine(array1[3]);
                Console.WriteLine(array1[4]);
                Console.WriteLine(array1[5]); // throws IndexOutOfRange exception
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: {0}", ex.Message);
            }

            /* 
             *  Question: What is the default value assigned to array elements in C#?
                In C#, the default value assigned to array elements depends on the type:
                    Numeric types (e.g., int, double): 0 (or 0.0 for floating-point types).
                    Boolean: false.
                    Reference types (e.g., string, object): null.

            */

            #endregion

            #region problem2
            int[] arr1 = { 1, 2, 3 };
            int[] arr2 = { 4, 5, 6 };
            arr2 = arr1; // shallow copy  
            Console.WriteLine($"arr1: {string.Join(", ", arr1)}"); // arr1 is affected
            Console.WriteLine($"arr2: {string.Join(", ", arr2)}"); // arr2 is affected
            arr1[0] = 34;// 34  2  3
            Console.WriteLine(arr2[0]);//34
           
            int[] arr3 = (int[])arr1.Clone(); // Deep Copy
            arr3[0] = 40;
            Console.Write($"arr1: {string.join(", ",arr1)}");
            Console.Write($"arr3: {string.join(", ", arr3)}");

            /*
              Question: What is the difference between Array.Clone() and Array.Copy()?
               
                                Array.Clone()                                         Array.Copy()
                        >>Creates a new array with the same elements.	        >>Copies elements from one array to another.
                    	>>Returns a shallow copy of the original array.	        >>Copies elements based on the specified range.
                    	>>Typically used to create a duplicate array.	        >>Used for partial or specific range copying.
                    	>>Returns a new array object.	                        >>Copies data into an existing array.
                    	>>Not supported. Entire array is cloned.	            >>Supports specifying source/destination indices.
        
             */
            #endregion


            int[,] grades = new int[3, 3];

            // take inputs from the user 

            Console.WriteLine("Enter grades");
            for (int i = 0; i < grades.GetLength(0); i++) {

                Console.WriteLine($"Enter grades for student {i + 1}: ");
                for (int j = 0; j < grades.GetLength(1); j++) {

                    Console.WriteLine($"Subject: {j + 1}: ");
                    grades[i, j] = int.Parse(Console.ReadLine());

                }

            }

            for (int i = 0; i < grades.GetLength(0); i++) {

                Console.WriteLine($"Student: {i + 1}");
                   for (int j = 0; j < grades.GetLength(1); j++) {

                    Console.WriteLine(grades[i,j]+ " "); 
                
                
                }

                Console.WriteLine();



            }





        }
    }
}
