// Задача: Написать программу, которая из имеющегося массива строк 
// формирует новый массив из строк, длина которых меньше, либо равна 3 символам. 
// Первоначальный массив можно ввести с клавиатуры, 
// либо задать на старте выполнения алгоритма


string [] array = {"Стамбул", "Рим", "Мадрид", "Осло", "Уфа", ":-)" };

int x=0;
int n=3;
for (int i=0; i<array.Length; i++)
{
    if (array [i].Length <=n) x++;
}
string [] slovo = new string [x];

int j =0;
for (int i=0; i<array.Length; i++)
{
    if (array [i].Length <=n) 
    {
        slovo[j]=array[i];
        j++;
    }
}

for (int y=0; y<slovo.Length; y++)
{
    Console.Write($"{slovo[y]} \t");
}
