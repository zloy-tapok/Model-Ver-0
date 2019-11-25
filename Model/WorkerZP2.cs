using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    /// <summary>
    /// Рабочий класс №2, производный от Human.
    /// Реализует методы расчеты и получения зарплаты от интерфейса IZarplata.
    /// Тут ЗП считается так: Оклад / Кол-во официальных рабочих дней * Кол-во фактически отработанных дней.
    /// Имена полей, свойств согласно rsdn по подобию базового класса
    /// </summary>
    public class WorkerZP2: Human, IZarplata 
  {

        private string profession; 
        public string GetProfession
        {
            get { return profession; }
        }
        public string SetProfession
        {
            set
            {
                while (true)
                {
                    if (!String.IsNullOrEmpty(value))
                    {
                        profession = value;
                        break;
                    }
                    else
                    {
                        Console.WriteLine("вы не ввели профессию сотрудника");
                        value = Console.ReadLine();
                    }
                }
            }
        }
        private uint experience;   
        public uint GetExperience
        {
            get { return experience; }
        }
        public string SetExperience
        {
            set
            {
                while (true)
                {
                    if (uint.TryParse(value, out uint result) && value != null && result < 100)
                    {
                        experience = result;
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Ошибка ввода стажа сотрудника");
                        value = Console.ReadLine();
                    }
                }
            }
        }
        private uint oklad;        
        public uint GetOklad
        {
            get { return oklad; }
        }
        public string SetOklad
        {
            set
            {
                while (true)
                {
                    if (uint.TryParse(value, out uint result) && value != null && result < 100000)
                    {
                        oklad = result;
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Ошибка ввода оклада");
                        value = Console.ReadLine();
                    }
                }
            }
        }
        private uint numberDays;
        public uint GetNumberDays
        {
            get { return numberDays; }
        }
        public string SetNumberDays
        {
            set
            {
                while (true)
                {
                    if (uint.TryParse(value, out uint result) && value != null && result < 32)
                    {
                        numberDays = result;
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Ошибка ввода количества положенных дней");
                        value = Console.ReadLine();
                    }
                }
            }
        }
        private uint numberFactDays;
        public uint GetNumberFactDays
        {
            get { return numberFactDays; }
        }
        public string SetNumberFactDays
        {
            set
            {
                while (true)
                {
                    if (uint.TryParse(value, out uint result) && value != null && result < 32)
                    {
                        numberFactDays = result;
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Ошибка ввода количества отработанных дней");
                        value = Console.ReadLine();
                    }
                }
            }
        }

        private uint zarplata;
       
        
        public void SetRaschet()
        {
            zarplata = oklad / numberDays * numberFactDays;
        }

        public UInt64 GetRaschet()
        {
            return zarplata;
        }
    }
}

