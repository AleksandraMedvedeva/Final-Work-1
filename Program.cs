Console.Clear();
Console.Write("Введити количество элементов массива");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите элементы массива через пробел:");
string[] array1 = Console.ReadLine().Split(' ');
string[] array2 = new string[array1.Length];
void SecondArray(string[] array1, string[] array2)
{
    int j = 0; for (int i = 0; i < array1.Length; i++)
    {
        if (array1[i].Length <= 3)
        {
            array2[j] = array1[i];
            j++;
        }
    }
}
