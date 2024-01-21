using System;

class NearestSmaller
{

    
 
    static void NearestSmallerValue(int[] arr)
    {
        // This one for first element of array
        Console.Write("-1, ");
        //For loop strt from second element
      
        for (int i = 1; i < arr.Length; i++)
        {
            // finding for smallervalue
         
            int j;
            for (j = i - 1; j >= 0; j--)
            {
                if (arr[j] <= arr[i])
                {
                    Console.Write(arr[j]
                                + ", ");
                    break;
                }
            }
                        
            if (j == -1)
                Console.Write("-1, ");
        }
    }

    public static void Main()
    {

        Console.WriteLine("Input: new int[] { 2, 4, 5, 1, 7 }");
        Console.Write("Output:");
        NearestSmallerValue(new int[] { 2, 4, 5, 1, 7 });

       Console.WriteLine("");
        Console.WriteLine("Input: new int[] { 5, 3, 1, 9, 7, 3, 4, 1 }");
        Console.Write("Output:");
       
        NearestSmallerValue(new int[] { 5, 3, 1, 9, 7, 3, 4, 1 });
        Console.ReadLine();
    }
}

