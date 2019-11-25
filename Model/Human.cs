using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Model
{/// <summary>
/// Базовый класс людей - ФизЛиц, который в будущем раскидаем по рабочим классам. Каждому рассчитаем зарплату по одной из формул, согласно заданию.
/// Создаем приватные поля класса (camelCase согласно rsdn)
/// Для каждого поля создаем свойства через get и set (названия PascalCase согласно rsdn)
/// В свойствах проверка на валидацию в цикле (бесконечен, пока пользователь не введет правильно)
/// </summary>
    public class Human
    {
        protected string firstName;
        
        public string GetFirstName
        {
            get { return firstName; }
        }
        public string SetFirstName
        {
            set
            {
                while (true)
                {
                    if (!String.IsNullOrEmpty(value))
                    {
                        firstName = value;
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
        
        protected string secondName;
        
       
        public string GetSecondName
        {
            get { return secondName; }
        }
        public string SetSecondName
        {
            set
            {
                while (true)
                {
                    if (!String.IsNullOrEmpty(value))
                    {
                        secondName = value;
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

        protected string lastName;

        public string GetLastName
        {
            get { return lastName; }          
        }
        
        public string SetLastName
        {
            set
            {
                while (true)
                {
                    if (!String.IsNullOrEmpty(value))
                    {
                        lastName = value;
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


        protected uint age = 0;
        public uint GetAge
        {
            get { return age; }
        }
        public string SetAge
        {
         
            set {
                while (true)
                {
                    if (uint.TryParse(value, out uint result) && value != null && result < 150)
                    {
                        age = result;
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
       

        protected uint phone = 0;
        public uint GetPhone
        {
            get { return phone; }
        }
        public string SetPhone
        {
            set
            {
                while (true)
                {
                    if (uint.TryParse(value, out uint result) && value != null)
                    {
                        phone = result;
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
        public static int count = 0;
        




    }
        
           
}
