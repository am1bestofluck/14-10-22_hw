using static System.Console;
class array_randomized_extended:array_randomized
{

    public array_randomized_extended():base()
        {
            //этот родительский метод вызывался чаще чем хотелось бы=))
        }
    public array_randomized_extended(int size_i, int lower_limit_i, int upper_limit_i):base(size_i:size_i,upper_limit_i:upper_limit_i,lower_limit_i:lower_limit_i)
    {
        //это было ОЧЕНЬ сложно ._.
    }
    
    public dynamic show_quantity_of_even_values()
    {
        int print_this=0;
        for (int i = 0; i < this.client.Length; i++)
        {
            if (this.client[i]%2==0)
            {
                print_this++;
            }
        }
        WriteLine($"Чётных элементов в массиве: {print_this}");
        return null;
    }
    
    public dynamic show_sum_of_uneven_elements()
    {
        int print_this=0;
        for (int i = 0; i < this.client.Length; i++)
        {
            if (i%2==1)
            {
                print_this+=this.client[i];
            }
        }
        WriteLine($"Cумма нечётных элементов: {print_this}");
        return null;

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
        this.show_quantity_of_even_values();
        return null;
    }
    public dynamic task2()
    {
        array_randomized_extended.todo(2);
        this.show_sum_of_uneven_elements();
        return null;
    }
}
