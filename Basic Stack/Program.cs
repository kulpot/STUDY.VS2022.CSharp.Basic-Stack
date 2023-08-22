using System;

//ref link:https://www.youtube.com/watch?v=WOlrjNvM4jg&list=PLRwVmtr-pp07XP8UBiUJ0cyORVCmCgkdA&index=3
//  about memory -- stack --

class MainClass
{
    static void Goo()
    {
        int gooeyInt = 29;
        double gooeyDouble = 43;
    }
    static void Main()
    {
        int myInt = 5;
        int anotherInt = 10;
        Goo();
        double meDouble = 98.3;
        Goo();
    }
}