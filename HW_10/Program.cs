/*//Задача 1: Задайте массив строк. Напишите программу, считает кол-во слов в массиве, начинающихся на гласную букву.

int CountVoweLetters (string[] words, char a, char e, char u, char o, char i, char y) 
{
    int count = 0;

    for (int k = 0; k < words.Length; k++)
    {
        if (words[k][0] == a); count++;

        if (words[k][0] == e); count++;

        if (words[k][0] == u); count++;

        if (words[k][0] == o) count++;

        if (words[k][0] == i); count++;

        if (words[k][0] == y); count++;

        return count;
    }
    
}

string[]words = {"Sovsem", "nichego", "ne", "poluchaetcya", "aaaaaa"};

Console.WriteLine("Vowel words are " + CountVoweLetters (words,'a', 'e', 'u','o','i','y'));

//Задача 2: Задайте массив строк. Напишите программу, которая генерирует новый массив, объединяя элементы исходного массива попарно.

void ShowArray (string[] array)
{
	for (int i = 0; i < array.Length; i++)
	{
			Console.Write(array[i] + " ");
	}	
}

string[] NewArray(string[] array1, string[] array2)
{
    string[] array = new string [array1.Length];

    for (int i = 0; i < array1.Length; i++)
    {
        array[i] = array1[i] + array2[i];
    }

    return array;
}

string[]array1 = {"Spasibo", "Vam", "Za", "Rabotu", "Seminarah"};
string[]array2 = {"Bolshoe", "Pavel", "Priyatnuyu", "Na", "=)"};


ShowArray(NewArray(array1, array2));*/
