internal class Program
{
    private static void Main(string[] args)
    {
        while (true)
        {
            Console.Write("Old phone pad number :");

            var number = Console.ReadLine();

            if (!string.IsNullOrEmpty(number))
            {
                if (number.Last() != '#')
                    Console.WriteLine("# must be end every input.");
                else
                    Console.WriteLine(OldPhonePad(number));
            }
        }
    }

    // Check delete character
    public static string CheckDelete(string input) 
    {
        string result = "";

        if (input.Contains("*"))
        {
            foreach (var s in input.Split('*'))
            {
                if(s.Length > 1)
                    result += s.Remove(s.Length - 1);
            }
        }
        else
            result = input;

        return result;
    }

    // Main function
    public static string OldPhonePad(string input)
    {
        string result = "";

        // Phone keypad mappings
        string[] nums = { "", "", "ABC", "DEF", "GHI", "JKL", "MNO", "PQRS", "TUV", "WXYZ" };

        // Ignore characters
        char[] ignore = { ' ', '.', '#' };

        char[] str = CheckDelete(input).ToCharArray();

        // Traverse the string str
        int i = 0;
        while (i < str.Length)
        {
            // If the current character exist ignore lists then continue to the next iteration
            if (ignore.Contains(str[i]))
            {
                i++;
                continue;
            }

            // Stores the number of continuous clicks
            int count = 0;

            // Iterate a loop to find the count of same characters
            while (i + 1 < str.Length && str[i] == str[i + 1])
            {
                // 2, 3, 4, 5, 6 and 8 keys will have maximum of 3 letters
                if (count == 2 && ((str[i] >= '2' && str[i] <= '6') || (str[i] == '8')))
                    break;

                // 7 and 9 keys will have maximum of 4 keys
                else if (count == 3 && (str[i] == '7' || str[i] == '9'))
                    break;

                count++;
                i++;

                // Handle the end condition
                if (i == str.Length)
                    break;
            }

            var strIndex = (str[i] - 48);

            if (strIndex > 0 && strIndex <= nums.Length - 1) //error handle
            {
                // Check if the current pressed key is 7 or 9
                if (str[i] == '7' || str[i] == '9')
                    result += nums[strIndex][count % 4];
                else // Else, the key pressed is either 2, 3, 4, 5, 6 or 8
                    result += nums[strIndex][count % 3];
            }

            i++;
        }

        return result;
    }
}