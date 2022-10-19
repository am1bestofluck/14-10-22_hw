using static System.Console;
class array_randomized_extended:array_randomized
{
    protected int size,lower_limit,upper_limit;
    public array_randomized_extended(int size_i, int lower_limit_i, int upper_limit_i)
    {
        this.size=size_i;
        this.lower_limit=lower_limit_i;
        this.upper_limit=upper_limit_i;
        this.client=calculation();
    }
    public dynamic calculation()// а зачем наследование делать если приходится дублировать нужный код=\
    {
        int[] output= new int[this.size];
        Random _gen = new Random();
        for (int i = 0; i < size; i++)
        {
            output[i]=_gen.Next(lower_limit,upper_limit);
        }
        return output;
    }
    public static void todo(int task)
    {
        switch (task)
        {
            case 1:
            {
                WriteLine("Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.");
                break;
            }
            case 2:
            {
                WriteLine("Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.");
                break;
            }
            default:
            {
                WriteLine("...Мне нужно подумать :)");
                break;
            }
        }
    }
    public dynamic task1()
    {
        array_randomized_extended.todo(1);
        return null;
    }
    public dynamic task2()
    {
        array_randomized_extended.todo(2);
        return null;
    }
}
