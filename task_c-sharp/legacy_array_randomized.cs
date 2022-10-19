using static System.Console;
class array_randomized
{
    protected int size,lower_limit,upper_limit;
    protected int[] client;
    public array_randomized(int size_i, int lower_limit_i, int upper_limit_i)
    {
        this.size=size_i;
        this.lower_limit=lower_limit_i;
        this.upper_limit=upper_limit_i;
        this.client=calculation();
    }   
    public array_randomized()
    {
        bool valid_input;
        valid_input=false;
        while (valid_input!=true)
        {
            WriteLine("Заполняем размер массива");
            valid_input=Int32.TryParse(ReadLine(),out this.size);
            if (this.size<0)
            {
                valid_input=false;
            }
        }
        valid_input=false;
        while( valid_input==false)
        {
            WriteLine("Заполняем нижний предел массива");
            valid_input=Int32.TryParse(ReadLine(),out this.lower_limit);
        }
        valid_input=false;
        while (valid_input==false)
        {
            WriteLine("Заполняем верхний предел массива");
            valid_input=Int32.TryParse(ReadLine(),out this.upper_limit);
        }
        if (this.upper_limit==this.lower_limit)
        {
            this.upper_limit++;
        }
        this.client=calculation();
    }
    public dynamic calculation()
    {
        int[] output= new int[this.size];
        Random _gen = new Random();
        for (int i = 0; i < size; i++)
        {
            output[i]=_gen.Next(lower_limit,upper_limit);
        }
        return output;
    }
    public dynamic print_result()
    {
        for (int step = 0; step < this.client.Length; step++)
        {
            if (step==0)
            {
                Write($"[{this.client[step]}, ");
            }
            else if(step==this.client.Length-1)
            {
                Write($"{this.client[step]}]");
            }
            else
            {
                Write($"{this.client[step]}, ");
            }
        }
    return null;
    }
    public dynamic return_string()
    {
        string output=$"[{String.Join(", ",this.client)}]";
        return output;
    }
    public dynamic represent()
    {
        WriteLine($"Рандомим массив размером {this.size} элементов(size_i), с пределами {this.lower_limit}-{this.upper_limit}");
        return null;
    }
}