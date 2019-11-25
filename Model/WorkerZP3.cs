using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    /// <summary>
    /// Рабочий класс №3 - произовдный от Human.
    /// Имена полей, свойств подобно базовому.
    /// Реализует методы расчеты и получения зарплаты от интерфейса IZarplata.
    /// Расчет ЗП по формуле: Ставка (дневная) * Кол-во отработанных дней.
    /// </summary>
    public class WorkerZP3 : Human, IZarplata
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

        private uint stavka;    
        public uint GetStavka
        {
            get { return stavka; }
        }
        public string SetStavka
        {
            set
            {
                while (true)
                {
                    if (uint.TryParse(value, out uint result) && value != null && result < 10000)
                    {
                        stavka = result;
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Ошибка ввода стоимости суточной ставки");
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
                    if (uint.TryParse(value, out uint result) && value != null && result < 500)
                    {
                        numberDays = result;
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Ошибка ввода количества отработанных часов");
                        value = Console.ReadLine();
                    }
                }
            }
        }

        private UInt64 zarplata; 
        public void SetRaschet()
            {
                zarplata = stavka * numberDays;
            }
        public UInt64 GetRaschet()
            {
                return zarplata;
            }
        }
}


