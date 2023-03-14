using System;
bool flag = false;
while(!flag)
{
    Console.WriteLine("Enter your password:");
    String pw = Console.ReadLine();
    int isAlpha = 0;
    int isNum = 0;
    int isChr = 0;


    if (pw != null && pw.Length >= 6)
    {
        foreach (char c in pw)
        {
            if (c >= 'a' && c <= 'z' || c >= 'A' && c <= 'Z')
                isAlpha = 1;
            else if (c >= '0' && c <= '9')
                isNum = 1;
            else
                isChr = 1;
        }
        if (isAlpha + isNum + isChr == 3)
            Console.WriteLine("Your password is strong");
        else if (isAlpha + isNum + isChr == 2)
            Console.WriteLine("Your password is medium-difficulty");
        else if (isChr + isNum + isChr == 1)
            Console.WriteLine("Your password is weak");
        flag = true;
    }
    else
        Console.WriteLine("Please enter at least 6 character");
}

