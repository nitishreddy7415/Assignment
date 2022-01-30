using System;
public class GFG
{

    static void printDiagonalSums(int[,] mat,
                                        int n)
    {
        int principal = 0, secondary = 0;
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {

                // Condition for principal
                // diagonal
                if (i == j)
                {
                    principal += mat[i, j];
                }


                if ((i + j) == (n - 1) && i != j)
                {
                    principal += mat[i, j];
                }
            }
        }

       
        Console.WriteLine("Principal Diagonal:"
                                  + principal);


    }

    // Driver code
    static public void Main()
    {
        Console.Write("Enter the elements of matrix : ");


        int[,] a = { { 1, 2, 3  },
                     { 4, 5, 6 },
                     { 7, 8, 9 } };

        printDiagonalSums(a, 3);
    }
}