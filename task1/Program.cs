﻿int Max(int arg1, int arg2, int arg3)
{
    int result = arg1;
    if(arg2>result) result = arg2;
    if(arg3>result) result = arg3;
    return result;
}
int a1 = 2525;
int b1 = 12;
int c1 = 65;
int a2 = 78;
int b2 = 2;
int c2 = 96;
int a3 = 8;
int b3 = 16;
int c3 = 323;

int max1 = Max(a1, b1, c1);
int max2 = Max(a2, b2, c2);
int max3 = Max(a3, b3, c3);
int max = Max(max1, max2, max3);

Console.WriteLine(max);