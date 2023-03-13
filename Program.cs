// Написать программу, которая из имеющегося массива строк формирует массив из строк, 
//длина которых меньше или равна 3 символа.

string[] inArray = new string[5] { "1", "2300", "hel", "world", "re" };
string[] finalArray = new string[inArray.Length];

void GetFinalArray(string[] inArray, string[] finalArray)
{
    int count = 0;
    for (int i = 0; i < inArray.Length; i++)
    {
        if (inArray[i].Length <= 3)
        {
            finalArray[count] = inArray[i];
            count++;
        }
    }
}

GetFinalArray(inArray, finalArray);
Console.WriteLine(String.Join(" ", finalArray));
