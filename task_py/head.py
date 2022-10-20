import random

class random_list:
    def __init__(self,size_i:int,lower_limit_i:int,upper_limit_i:int) -> None:
        self.__size=size_i
        self.__lower_limit=lower_limit_i
        self.__upper_limit=upper_limit_i
        self.__client=self.calculate()
        pass
    def __repr__(self,fp=False) -> str:
        if fp==True:
            return(f'list: {str(self.__client_fp)}')
        return(f'list: {str(self.__client)}')
    def calculate(self)->list:
        list_o=[]
        for walk in range(self.__size):
            list_o.append(random.choice(range(self.__lower_limit,self.__upper_limit+1,1)))
        return list_o
    def calculate_fp(self)->list:
        output=[]
        for walk  in self.__client:
            output.insert(0,walk+round(random.uniform(0,1),4))# магия бесконтактного переворачивания списка в действии.
        return output
    def get_quantity_of_even_values(self)->None:
        _out=0
        for walk in self.__client:
            if walk%2==0:
                _out+=1
        print(f"\nЧётных элементов: {_out}")
        return
    def get_sum_of_elements(self,add_even=False,add_uneven=True)->int:
        out=0
        if not add_even and not add_uneven:
            print("складывать нечего :)")
            return out
        for walk in self.__client:
            if add_even and walk%2==0:
                out+=walk
            if add_uneven and walk%2!=0:
                out+=walk
        print(f"\nсумма {'нечётных' if add_uneven else ''}{' и ' if add_even and add_uneven else ''} {'чётных'if add_even else ''} элементов: {str(out)}")
        return out
    def get_extremums(self,floating_point=True)->dict:
        obj=self.__client_fp if floating_point else self.__client
        output={"min":obj[0],"max":obj[0]}
        for walk in obj[1:]:
            # output["min"]= walk if walk<output["min"] else output["min"]#а можно тут без самоцитирования обойтись как-то?...можно^^
            if output["min"]>walk: output["min"]=walk# например так
            output["max"]=max(walk,output["max"])# или вообще так оО
        return output
        
    def todo(self,task:int)->None:
        print()
        match task:
            case 1:
                print("## Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.")
            case 2:
                print("## Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.")
            case 3:
                print("## Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.")
    def task1(self)->None:
        self.todo(1)
        self.get_quantity_of_even_values()
        return
    def task2(self)->int:
        self.todo(2)
        external_sum_uneven=self.get_sum_of_elements()
        return
    def task3(self)->float:
        self.__client_fp=self.calculate_fp()
        self.todo(3)
        print(f'Новый! {self.__repr__(True)}')
        _minmax=self.get_extremums(True)
        print(f"Разность пределов{str(_minmax['min'])} и {str(_minmax['max'])}: {str(abs(_minmax['min']-_minmax['max']))}")
        return


def main():
    _obj=random_list(10,100,999)
    print(_obj)
    _obj.task1()
    _obj.task2()
    _obj.task3()
    return
if __name__ =='__main__':
    main()
