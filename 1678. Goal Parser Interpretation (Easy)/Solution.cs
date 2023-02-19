public class Solution
{
    public string Interpret(string command)
    {
        string result = "";
        for (int i = 0; i < command.Length; i++)
        {

            switch (command[i])
            {
                case 'G': result += "G"; break;

                case '(':
                    if (command[i + 1] == ')')
                    {
                        result += "o";
                        i += 1;
                    }
                    else
                    {
                        result += "al";
                        i += 3;
                    }
                    break;
            }
        }
        return result;
    }
}