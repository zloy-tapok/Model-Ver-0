using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{/// <summary>
/// Согласно заданию создаем публичный Интерфейс.
/// Обязаны его реализовать в Рабочих классах (разными способоами).
/// </summary>
    public interface IZarplata
    {
        UInt64 GetRaschet ();
        void SetRaschet();
    }
}
