string[] NewArray(string[] array)                       
{                                                         
    string[] findarray = new string[0];                      
    for (int i = 0, j = 0; i < array.Length; i++)
    {
        if (array[i].Length <= 3)                             
        {
            Array.Resize(ref findarray, findarray.Length + 1);
            findarray[j] = array[i];                          
            j++;
        }
    }
    return findarray;
}
Console.Write("Вводите элементы массива через запятую и пробел: ");
string text = Convert.ToString(Console.ReadLine()) ?? String.Empty;
string[] firstArray = text.Split(", ");
string[] secondArray = NewArray(firstArray);
Console.WriteLine();
Console.WriteLine($"[{String.Join(", ", firstArray)}] -> [{String.Join(", ", secondArray)}]");
Console.WriteLine();
