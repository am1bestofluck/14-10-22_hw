using static System.Console;
class array_randomized_floating_point:array_randomized
{
    new double[] client_fp;
    public array_randomized_floating_point():base()
    {
        // this.client = new double[this.size];
        this.client_fp=calculation();
    }
    public array_randomized_floating_point(int size_i, int lower_limit_i,int upper_limit_i):base(size_i:size_i, lower_limit_i:lower_limit_i,upper_limit_i:upper_limit_i)
    {
        // double[] this.client_fp = new double[this.size];
        this.client_fp=calculation();
    }
    public static void todo()
    {
        WriteLine("Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.");
    }
    new public dynamic calculation()
    {
        double[] output= new double[this.size];
        Random _gen = new Random();
        for (int i = 0; i < this.size; i++)
        {
            output[i]=Math.Round(this.client[i]*1.0+_gen.NextDouble(),4);//Путь наименьшего сопротивления?
        }
        return output;
    }
    public dynamic get_difference_between_extremums()
    {
        double output=0.0,supv_min=this.client_fp[0],supv_max=this.client_fp[0];
        for (int i = 0; i < this.client.Length; i++)
        {
            if (this.client_fp[i]>supv_max)
            {
                supv_max=client_fp[i];
            }
            if (this.client_fp[i]<supv_min)
            {
                supv_min=client_fp[i];
            }
        }
        output=Math.Abs(supv_min-supv_max);
        WriteLine($"Разность пределов {supv_min} и {supv_max}: {output}");
        return output;
    }

    new public dynamic return_string()
    {
        string output=$"[{String.Join(", ",this.client_fp)}]";
        return output;
    }
}