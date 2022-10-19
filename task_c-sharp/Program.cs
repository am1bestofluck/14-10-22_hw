// // See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");
using static System.Console;

void main()
{

    array_randomized_extended obj=new array_randomized_extended(size_i:10,lower_limit_i:100,upper_limit_i:1000) ;
    obj.represent();
    obj.print_result();
    WriteLine("\n\n");
    obj.task1();
    WriteLine("\n\n");
    obj.task2();
    WriteLine("\n\n");
    array_randomized_floating_point.todo();
    array_randomized_floating_point obj_fp= new array_randomized_floating_point(
        size_i:10,lower_limit_i:100,upper_limit_i:1000);
    WriteLine(obj_fp.return_string());
    double _out=obj_fp.get_difference_between_extremums();
}
main();