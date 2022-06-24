// Разбор вопросов.
/*
string name = "Natali";

Console.WriteLine(name);

char symbol = '*';

char[] symbol2 = {'P', 'a'};
Console.WriteLine(symbol2);

string[] names = {"HiJb", "jsdbv", "jsd"};
Console.WriteLine(names[1][2]); // 1 - слово 2 - буква

Console.Write(('2' > '5'));

Console.Write(('c' > 'b'));

Console.Write(('c' > 'C')); // кодировки строчных букв идут после заглавных
*/

// Задача 1. Метод принимает на вход массив строк, а возвращает переменную, которая показывает, сколько четных слов в массиве 
/*
string[] names = { "Pavel", "Denal", "Anna", "Denis", "Annet", "Natali" };

int CountEvent(string[] words)
{
    int count = 0;
    for (int i = 0; i < words.Length; i++)
    {
        if (words[i].Length % 2 == 0) count++;
    }
    return count;
}

Console.Write(CountEvent(names));
*/

// Задача 2. Метод принимает на вход массив строк и сортирует по размерам каждого слова. Пусть слова с равным количеством букв идут друг за другом, но по алфавиту.
/*
string[] names = { "Pavel", "Denal", "Anna", "Denis", "Deniq", "Denip", "Annet", "A", "An", "Ana", "Ala", "Apa" };

string[] SortWordsLength(string[] words)
{
    string tmp = String.Empty;

    for (int i = 0; i < words.Length - 1; i++)
    {
        for (int j = 0; j < words.Length - 1 - i; j++)
        {
            if (words[j].Length > words[j + 1].Length)
            {
                tmp = words[j];
                words[j] = words[j + 1];
                words[j + 1] = tmp;
            }
            else if (words[j].Length == words[j + 1].Length)
            {
                for (int k = 0; k < words[j].Length; k++)
                {
                    if (words[j][k] > words[j + 1][k])
                    {
                        tmp = words[j];
                        words[j] = words[j + 1];
                        words[j + 1] = tmp;
                        break;
                    }
                    else
                    {
                        if (words[j][k] < words[j + 1][k])
                            break;
                    }

                }
            }
        }
    }
    return words;
}

void PrintArray(string[] result)
{
    Console.WriteLine();
    for (int i = 0; i < result.Length; i++)
        Console.Write(result[i] + " ");
}

PrintArray(names);
PrintArray(SortWordsLength(names));
*/

