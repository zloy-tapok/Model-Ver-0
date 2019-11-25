using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    /// <summary>
    /// Рабочий класс №1 - производный от Human.
    /// Здесь зп считается по формуле: стоимость часа * количество часов в месяц.
    /// Реализует методы расчеты и получения зарплаты от интерфейса IZarplata.
    /// По подобию базового класса имена полей и свойств и проверка на валидацию.
    /// </summary>
    public class WorkerZP1 : Human, IZarplata 
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
                        Console.Write("Некорректный ввод данных.\nПовторите ввод: ");
                        value = Console.ReadLine();
                    }
                }
            }
        }

        private uint experience;  
        
        public uint GetEperience
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
                        Console.Write("Некорректный ввод данных.\nПовторите ввод: ");
                        value = Console.ReadLine();
                    }
                }
            }
        }

        private uint costHour;     
        public uint GetCostHour
        {
            get { return costHour; }
        }
        public string SetCostHour
        {
            set
            {
                while (true)
                {
                    if (uint.TryParse(value, out uint result) && value != null && result < 1000)
                    {
                        costHour = result;
                        break;
                    }
                    else
                    {
                        Console.Write("Некорректный ввод данных.\nПовторите ввод: ");
                        value = Console.ReadLine();
                    }
                }
            }
        }

        private uint numberHours;  
        
        public uint GetNumberHours
        {
            get
            {
                return numberHours;
            }
        }
        public string SetNumberHours
        {
            set
            {
                while (true)
                {
                    if (uint.TryParse(value, out uint result) && value != null && result < 500)
                    {
                        numberHours = result;
                        break;
                    }
                    else
                    {
                        Console.Write("Некорректный ввод данных.\nПовторите ввод: ");
                        value = Console.ReadLine();
                    }
                }
            }
        }

        private UInt64 zarplata; 

        public UInt64 GetRaschet()
        {
            return zarplata;
        }
     
        public void SetRaschet()
        {
            
                zarplata = costHour * numberHours;          
        }

        
    }
}
