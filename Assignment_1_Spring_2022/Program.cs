/* 
 
YOU ARE NOT ALLOWED TO MODIFY ANY FUNCTION DEFINATION's PROVIDED.
WRITE YOUR CODE IN THE RESPECTIVE FUNCTION BLOCK

*/
using System;

namespace DIS_Assignmnet1_SPRING_2022
{
    class Program
    {
        static void Main(string[] args)
        {
            //Question 1
            Console.WriteLine("Q1: Enter the string:");
            string s = Console.ReadLine();
            string final_string = RemoveVowels(s);
            Console.WriteLine("Final string after removing the Vowels: {0}",final_string);
            Console.WriteLine();

            //Question 2:
            string[] bulls_string1 = new string[]{"Marshall", "Student","Center"};
            string[] bulls_string2 = new string[]{"MarshallStudent", "Center"};
            bool flag = ArrayStringsAreEqual(bulls_string1, bulls_string2);
            Console.WriteLine("Q2");
            if (flag)
            {
                Console.WriteLine("Yes, Both the array’s represent the same string");
            }
            else
            {
                Console.WriteLine("No, Both the array’s don’t represent the same string ");
            }
            Console.WriteLine();

            //Question 3:
            int[] bull_bucks = new int[] { 1, 2, 3, 2 };
            int unique_sum = SumOfUnique(bull_bucks);
            Console.WriteLine("Q3:");
            Console.WriteLine("Sum of Unique Elements in the array are :{0}", unique_sum);
            Console.WriteLine();


            //Question 4:
            int[,] bulls_grid = new int[,] { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } };
            Console.WriteLine("Q4:");
            int diagSum = DiagonalSum(bulls_grid);
            Console.WriteLine("The sum of diagonal elements in the bulls grid is {0}:", diagSum);
            Console.WriteLine();

            //Question 5:
            Console.WriteLine("Q5:");
            String bulls_string = "aiohn";
            int[] indices = { 3, 1, 4, 2, 0 };
            String rotated_string = RestoreString(bulls_string, indices);
            Console.WriteLine("The  Final string after rotation is {0} ", rotated_string);
            Console.WriteLine();

            //Quesiton 6:
            string bulls_string6 = "mumacollegeofbusiness";
            char ch ='c';
            string reversed_string = ReversePrefix(bulls_string6, ch);
            Console.WriteLine("Q6:");
            Console.WriteLine("Resultant string are reversing the prefix:{0}", reversed_string);
            Console.WriteLine();

        }

        /* 
        <summary>
        Given a string s, remove the vowels 'a', 'e', 'i', 'o', and 'u' from it, and return the new string.

        Example 1:
        Input: s = "MumaCollegeofBusiness"
        Output: "MmCllgfBsnss"

        Example 2:
        Input: s = "aeiou"
        Output: ""

        Constraints:
        •	0 <= s.length <= 10000
        s consists of uppercase and lowercase letters
        </summary>
        */

        private static string RemoveVowels(string s)
        {
            try
            {
                // write your code here

                Char[] output = new char[10000];
                
                
                int j = 0;
                for (int i = 0; i < s.Length; i++)
                {
                    //verifying if the element at the current index is a vowel.
                    if (Convert.ToChar(s[i]) == 'A' || Convert.ToChar(s[i]) == 'a' || Convert.ToChar(s[i]) == 'E' || Convert.ToChar(s[i]) == 'e' || Convert.ToChar(s[i]) == 'I' || Convert.ToChar(s[i]) == 'i' || Convert.ToChar(s[i]) == 'O' || Convert.ToChar(s[i]) == 'o' || Convert.ToChar(s[i]) == 'U' || Convert.ToChar(s[i]) == 'u')
                    {
                        //No action if the index position contains a vowel.
                        continue;
                    }
                    else
                    {
                        //else the consonant is appended to the jth position of the character array.
                        output[j] = s[i];
                        j++;
                    }
                        
                    
                }
                //Converting the character array back to the string and returning the output.
                string str = new string(output);
                String final_string = "";
                final_string = str;

                return final_string;
            }
            catch (Exception)
            {
                throw;
            }

        }

        /* 
        <summary>
       Given two string arrays word1 and word2, return true if the two arrays represent the same string, and false otherwise.
       A string is represented by an array if the array elements concatenated in order forms the string.
       Example 1:
       Input: : bulls_string1 = ["Marshall", "Student",”Center”], : bulls_string2 = ["MarshallStudent ", "Center"]
       Output: true
       Explanation:
       word1 represents string "marshall" + "student" + “center” -> "MarshallStudentCenter "
       word2 represents string "MarshallStudent" + "Center" -> "MarshallStudentCenter"
       The strings are the same, so return true.
       Example 2:
       Input: word1 = ["Zimmerman", "School", ”of Advertising”, ”and Mass Communications”], word2 = ["Muma", “College”,"of”, “Business"]
       Output: false

       Example 3:
       Input: word1  = ["University", "of", "SouthFlorida"], word2 = ["UniversityofSouthFlorida"]
       Output: true
       </summary>
       */

        private static bool ArrayStringsAreEqual(string[] bulls_string1, string[] bulls_string2)
        {
            try
            {

                // write your code here.
                int k = 0;
                char[] out1 = new char[10000];
                char[] out2 = new char[10000];

                //If a string array contains spaces, it is a multidimensional array, hence we convert the string array into a single dimensional char array first.
                
                for (int i = 0; i < bulls_string1.Length; i++) 
                {
                    for (int j = 0; j < bulls_string1[i].Length; j++)
                    {
                        //String 1
                        out1[k] = bulls_string1[i][j];
                        k++;
                    }
                }
                k = 0;
                for (int i = 0; i < bulls_string2.Length; i++)
                {
                    for (int j = 0; j < bulls_string2[i].Length; j++)
                    {
                        //String 2
                        out2[k] = bulls_string2[i][j];
                        k++; 
                    }
                }
                //Conversion of character array to a single dimenstional string
                string out1_str = new string(out1);
                string out2_str = new string(out2);
                
                //comparing strings for similarity and returning the corresponding boolean output.
                if (out1_str == out2_str)
                    return true;
                else
                    return false;
        }
            catch (Exception)
            {

                throw;
            }

}
        /*
        <summary> 
       You are given an integer array bull_bucks. The unique elements of an array are the elements that appear exactly once in the array.
       Return the sum of all the unique elements of nums.
       Example 1:
       Input: bull_bucks = [1,2,3,2]
       Output: 4
       Explanation: The unique elements are [1,3], and the sum is 4.
       Example 2:
       Input: bull_bucks = [1,1,1,1,1]
       Output: 0
       Explanation: There are no unique elements, and the sum is 0.
       Example 3:
       Input: bull_bucks = [1,2,3,4,5]
       Output: 15
       Explanation: The unique elements are [1,2,3,4,5], and the sum is 15.
       </summary>
        */

        private static int SumOfUnique(int[] bull_bucks)
        {
            try
            {
                // write your code here
                int Sum = 0, count = 0;
                for (int i = 0; i < bull_bucks.Length; i++) 
                {
                    for (int j = 0; j < bull_bucks.Length; j++) 
                    {
                        //Every time an element is encountered, the count is incremented.
                        if (bull_bucks[i] == bull_bucks[j])
                        {
                            count++;
                            
                        }
                    }
                    //If an element is unique, the count will always be 1.
                    if(count == 1)
                    {
                        //The sum is computed everytime a unique element is encountered.
                        Sum = Sum + bull_bucks[i];
                        
                    }
                    //The count has to be reset to 0 to prevent miscalculations due to overlapping.
                    count = 0;
                }

                return Sum;

            }
            catch (Exception)
            {
                throw;
            }
        }
        /*

        <summary>
       Given a square matrix bulls_grid, return the sum of the matrix diagonals.
       Only include the sum of all the elements on the primary diagonal and all the elements on the secondary diagonal that are not part of the primary diagonal.

       Example 1:
       Input: bulls_grid = [[1,2,3],[4,5,6], [7,8,9]]
       Output: 25
       Explanation: Diagonals sum: 1 + 5 + 9 + 3 + 7 = 25
       Notice that element mat[1][1] = 5 is counted only once.
       Example 2:
       Input: bulls_grid = [[1,1,1,1], [1,1,1,1],[1,1,1,1], [1,1,1,1]]
       Output: 8
       Example 3:
       Input: bulls_grid = [[5]]
       Output: 5
       </summary>

        */

        private static int DiagonalSum(int[,] bulls_grid)
        {
            int Sum = 0, common;
            try
            {
                // write your code here.
                //Compute the length of the matrix.
                int len = Convert.ToInt32(Math.Sqrt(bulls_grid.Length));
            
                for (int i = 0; i < len; i++)
                {
                //Computing sum for first diagonal
                Sum = Sum + bulls_grid[i, i];                       
                }

                for (int i = len - 1; i >= 0; i--)
                {
                    //Computing sum for second diagonal
                    Sum = Sum + bulls_grid[Math.Abs(len - (i+1)),i];
                }
                if(((len) %2!=0)&&(len > 1))
                {
                    //subtracting the value of the element repeating in the second diagonal.
                    common = (len - 1) / 2;
                    Sum = Sum - bulls_grid[common, common];
                }

                return Sum;
        }
            catch (Exception e)
            {

                Console.WriteLine("An error occured: " + e.Message);
                throw;
            }

}



        /*
         
        <summary>
        Given a string bulls_string  and an integer array indices of the same length.
        The string bulls_string  will be shuffled such that the character at the ith position moves to indices[i] in the shuffled string.
        Return the shuffled string.

        Example 3:
        Input: bulls_string  = "aiohn", indices = [3,1,4,2,0]
        Output: "nihao"

        */

        private static string RestoreString(string bulls_string, int[] indices)
        {
            try
            {
                // write your code here.

                char[] out_1 = new char[10000];

                for (int i = 0; i < bulls_string.Length; i++)
                {
                    //the indexes within the indices array are used in the new character array.

                    out_1[indices[i]] = bulls_string[i]; 
                }
                //the char array has to be converted back to a one dimensional string.
                string output = new string(out_1);

                return output;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                throw;
            }

        }

        /*
         <summary>
        Given a 0-indexed string bulls_string   and a character ch, reverse the segment of word that starts at index 0 and ends at the index of the first occurrence of ch (inclusive). If the character ch does not exist in word, do nothing.
        For example, if word = "abcdefd" and ch = "d", then you should reverse the segment that starts at 0 and ends at 3 (inclusive). The resulting string will be "dcbaefd".
        Return the resulting string.

        Example 1:
        Input: bulls_string   = "mumacollegeofbusiness", ch = "c"
        Output: "camumollegeofbusiness"
        Explanation: The first occurrence of "c" is at index 4. 
        Reverse the part of word from 0 to 4 (inclusive), the resulting string is "camumollegeofbusiness".

        Example 2:
        Input: bulls_string   = "xyxzxe", ch = "z"
        Output: "zxyxxe"
        Explanation: The first and only occurrence of "z" is at index 3.
        Reverse the part of word from 0 to 3 (inclusive), the resulting string is "zxyxxe".

        Example 3:
        Input: bulls_string   = "zimmermanschoolofadvertising", ch = "x"
        Output: "zimmermanschoolofadvertising"
        Explanation: "x" does not exist in word.
        You should not do any reverse operation, the resulting string is "zimmermanschoolofadvertising".
        */

        private static string ReversePrefix(string bulls_string6, char ch)
        {
            //try
            //{
                int pos = 0, j = 0;
                char[] output = new char[10000];

                //identifying the position of the character
                for (int i = 0; i < bulls_string6.Length; i++)
                {
                    if(bulls_string6[i]==ch)
                    {
                        pos = i;
                    }
                }

                //adding elements from the position (pos) to the first element
                for (int i = pos; i >= 0; i--)
                {

                output[j] = bulls_string6[i];
              
                j++;
                }

                //adding the remainder of the string to the char array
                for (int i = pos + 1; i < bulls_string6.Length; i++)
                {
                    output[i] = bulls_string6[i];
                }

                //converting char array into single dimension string
                string output2 = new string(output);
                String prefix_string ="";
                prefix_string = output2;
                return prefix_string;
           // }
            //catch (Exception)
            //{

            //    throw;
            //}

        }
    }
}
