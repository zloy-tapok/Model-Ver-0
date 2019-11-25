using System;
using System.Collections.Generic;
using Model;

namespace ConsoleModel
{  
/// <summary>
/// Консольное приложение для реализации бизнес логики.
/// Заполняем с помощью List списки объектами.
/// Используем циклы + валидацию для заполнения.
/// Не пускаем пользователя дальше, пока не введет корректно данные.
/// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Сколько вы хотите добавить человек в программу: ");
            string Squantity = Console.ReadLine();
            uint Qcycle = 0;
            while (true)
            {
                if (uint.TryParse(Squantity, out uint Uquantity) && Squantity != null && Uquantity < 101)
                {
                    Qcycle = Uquantity;
                    break;
                }
                else
                {
                    Console.Write("Либо неверный формат, либо больше 100.\nПовторите Ввод: ");
                    Squantity = Console.ReadLine();
                }
            }
            var SpisokHumans = new List <Human>();

            for(int i = 0 ;i < Qcycle; i++)  
            {
                SpisokHumans.Add(new Human());
                Console.WriteLine("Введите Имя");
                SpisokHumans[i].SetFirstName= Console.ReadLine();
                Console.WriteLine("Введите фамилию");
                SpisokHumans[i].SetSecondName = Console.ReadLine();
                Console.WriteLine("Введите отчество");
                SpisokHumans[i].SetLastName =  Console.ReadLine();
                Console.WriteLine("Введите возраст");
                SpisokHumans[i].SetAge = Console.ReadLine();
                Console.WriteLine("Введите номер телефона");
                SpisokHumans[i].SetPhone = Console.ReadLine();
                Human.count++;
                Console.WriteLine();
                Console.WriteLine("Проверьте введенные данные:");
                Console.WriteLine("Имя = " + SpisokHumans[i].GetFirstName);
                Console.WriteLine("Фамилия = " + SpisokHumans[i].GetSecondName);
                Console.WriteLine("Отчество = " + SpisokHumans[i].GetLastName);
                Console.WriteLine("Возраст = " + SpisokHumans[i].GetAge);
                Console.WriteLine("Телефон = " + SpisokHumans[i].GetPhone);
                Console.WriteLine("Добавлен человек № " + Human.count);
                Console.WriteLine("Нажмите любую клавишу для продолжения");
                Console.ReadLine();

            }
            Console.WriteLine("Всего добавлено {0} людей", Human.count);
            Console.ReadLine();
            
            ///Общее количество людей в рабочих классах = кол-во ФизЛиц в базовом классе
            for (int i = 0; i < Human.count; i++) 
            {
                Console.Write("Начнем переводить людей в рабочие категории. Введите цифрой от 1 до 3 категорию:");
                string numberWorker = Console.ReadLine();
                while (true)
                {
                    if (int.TryParse(numberWorker, out int typeZP) && typeZP >= 1 && typeZP <= 3)
                    {
                        switch (typeZP)
                        {
                            case 1:
                                {
                                    var SpisokWorkersZP1 = new List<WorkerZP1>();
                                    SpisokWorkersZP1.Add(new WorkerZP1());
                                    int iZP1 = 0;      //Счетчик людей по рабочим классам              
                                    SpisokWorkersZP1[iZP1].SetFirstName = SpisokHumans[i].GetFirstName;
                                    SpisokWorkersZP1[iZP1].SetSecondName = SpisokHumans[i].GetSecondName;
                                    SpisokWorkersZP1[iZP1].SetLastName = SpisokHumans[i].GetLastName;
                                    SpisokWorkersZP1[iZP1].SetAge = Convert.ToString(SpisokHumans[i].GetAge);
                                    SpisokWorkersZP1[iZP1].SetPhone = Convert.ToString(SpisokHumans[i].GetPhone);
                                    Console.WriteLine("Введите профессию");
                                    SpisokWorkersZP1[iZP1].SetProfession = Console.ReadLine();
                                    Console.WriteLine("Введите Стаж");
                                    SpisokWorkersZP1[iZP1].SetExperience = Console.ReadLine();
                                    Console.WriteLine("Введите Стоимость часа");
                                    SpisokWorkersZP1[iZP1].SetCostHour = Console.ReadLine();
                                    Console.WriteLine("Введите Количество часов");
                                    SpisokWorkersZP1[iZP1].SetNumberHours = Console.ReadLine();
                                    SpisokWorkersZP1[iZP1].SetRaschet();
                                    Console.WriteLine($"{SpisokWorkersZP1[iZP1].GetProfession} {SpisokWorkersZP1[iZP1].GetSecondName} {SpisokWorkersZP1[iZP1].GetFirstName} {SpisokWorkersZP1[iZP1].GetLastName} заработал { SpisokWorkersZP1[iZP1].GetRaschet()} рублей");
                                    iZP1++;
                                }
                                break;

                            case 2:
                                {
                                    var SpisokWorkersZP2 = new List<WorkerZP2>();
                                    SpisokWorkersZP2.Add(new WorkerZP2());
                                    int iZP2 = 0;
                                    SpisokWorkersZP2[iZP2].SetFirstName = SpisokHumans[i].GetFirstName;
                                    SpisokWorkersZP2[iZP2].SetSecondName = SpisokHumans[i].GetSecondName;
                                    SpisokWorkersZP2[iZP2].SetLastName = SpisokHumans[i].GetLastName;
                                    SpisokWorkersZP2[iZP2].SetAge = Convert.ToString(SpisokHumans[i].GetAge);
                                    SpisokWorkersZP2[iZP2].SetPhone = Convert.ToString(SpisokHumans[i].GetPhone);
                                    Console.WriteLine("Введите профессию");
                                    SpisokWorkersZP2[iZP2].SetProfession = Console.ReadLine();
                                    Console.WriteLine("Введите Стаж");
                                    SpisokWorkersZP2[iZP2].SetExperience = Console.ReadLine();
                                    Console.WriteLine("Введите Оклад");
                                    SpisokWorkersZP2[iZP2].SetOklad = Console.ReadLine();
                                    Console.WriteLine("Введите Количество дней");
                                    SpisokWorkersZP2[iZP2].SetNumberDays = Console.ReadLine();
                                    Console.WriteLine("Введите Количество факт дней");
                                    SpisokWorkersZP2[iZP2].SetNumberFactDays = Console.ReadLine();
                                    SpisokWorkersZP2[iZP2].SetRaschet();
                                    Console.WriteLine($"{SpisokWorkersZP2[iZP2].GetProfession} {SpisokWorkersZP2[iZP2].GetSecondName} {SpisokWorkersZP2[iZP2].GetFirstName} {SpisokWorkersZP2[iZP2].GetLastName} заработал { SpisokWorkersZP2[iZP2].GetRaschet()} рублей");
                                    iZP2++;
                                }

                                break;

                            case 3:
                                {
                                    var SpisokWorkersZP3 = new List<WorkerZP3>();
                                    SpisokWorkersZP3.Add(new WorkerZP3());
                                    int iZP3 = 0;
                                    SpisokWorkersZP3[iZP3].SetFirstName = SpisokHumans[i].GetFirstName;
                                    SpisokWorkersZP3[iZP3].SetSecondName = SpisokHumans[i].GetSecondName;
                                    SpisokWorkersZP3[iZP3].SetLastName = SpisokHumans[i].GetLastName;
                                    SpisokWorkersZP3[iZP3].SetAge = Convert.ToString(SpisokHumans[i].GetAge);
                                    SpisokWorkersZP3[iZP3].SetPhone = Convert.ToString(SpisokHumans[i].GetPhone);
                                    Console.WriteLine("Введите профессию");
                                    SpisokWorkersZP3[iZP3].SetProfession = Console.ReadLine();
                                    Console.WriteLine("Введите Стаж");
                                    SpisokWorkersZP3[iZP3].SetExperience = Console.ReadLine();
                                    Console.WriteLine("Введите Ставку");
                                    SpisokWorkersZP3[iZP3].SetStavka = Console.ReadLine();
                                    Console.WriteLine("Введите Количество часов");
                                    SpisokWorkersZP3[iZP3].SetNumberDays = Console.ReadLine();
                                    SpisokWorkersZP3[iZP3].SetRaschet();
                                    Console.WriteLine($"{SpisokWorkersZP3[iZP3].GetProfession} {SpisokWorkersZP3[iZP3].GetSecondName} {SpisokWorkersZP3[iZP3].GetFirstName} {SpisokWorkersZP3[iZP3].GetLastName} заработал { SpisokWorkersZP3[iZP3].GetRaschet()} рублей");
                                    iZP3++;
                                }
                                break;
                        }
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Вы неправильно сделали выбор класса работника.\nПовторите ввод:");
                        numberWorker = Console.ReadLine();
                    }
                }
                
            }
            Console.WriteLine();
            Console.WriteLine("Списки работников заполнены верны!");

        }
    }
}
