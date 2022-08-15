int[] array = { 1, 42, 32, 45, 51, 6, 7, 32, 9};

int n = array.Length;
int find = 32;
int index = 0;

while (index < n)
{
    if(array[index]==find)
    {
        Console.WriteLine(index);
        break;
    }
    index++;
}