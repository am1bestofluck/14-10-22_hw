class array_randomized_floating_point:array_randomized
{
    public static void todo()
    {
        WriteLine("Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.");
    }
    public static void core()
    {
        decimal output=decimal.Zero;
    }
    public dynamic calculation()
    {
        decimal[] output= new decimal[this.size];
        Random _gen = new Random();
        for (int i = 0; i < size; i++)
        {
            output[i]=_gen.Next(
                System.Convert.ToDecimal( lower_limit),
                System.Convert.ToDecimal(upper_limit));
        }
        return output;
    }
}