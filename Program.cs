using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_Theme_01
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            // Заказчик просит написать программу «Записная книжка». Оплата фиксированная - $ 120.

            // В данной программе, должна быть возможность изменения значений нескольких переменных для того,
            // чтобы персонифецировать вывод данных, под конкретного пользователя.

            // Для этого нужно: 
            // 1. Создать несколько переменных разных типов, в которых могут храниться данные
            //    - имя;
            //    - возраст;
            //    - рост;
            //    - баллы по трем предметам: история, математика, русский язык;

            // 2. Реализовать в системе автоматический подсчёт среднего балла по трем предметам, 
            //    указанным в пункте 1.

            // 3. Реализовать возможность печатки информации на консоли при помощи 
            //    - обычного вывода;
            //    - форматированного вывода;
            //    - использования интерполяции строк;

            // 4. Весь код должен быть откомментирован с использованием обычных и хml-комментариев

            // **
            // 5. В качестве бонусной части, за дополнительную оплату $50, заказчик просит реализовать 
            //    возможность вывода данных в центре консоли.

            String Name = "Алексей";
            byte Age = 18; // Предполагаем, что возвраст не может быть больше 255 лет
            ushort HeightMillimeters = 1770;
            byte ScoreHistory = 5;
            byte ScoreMath = 2;
            byte ScoreRussian = 4;

            float ScoreAverage = (float)(ScoreMath + ScoreHistory + ScoreRussian) / 3F;

            // Обычный вывод с конкатенацией
            Console.WriteLine("Имя: " + Name + ", Возраст: " + Age + " лет, Рост: " + HeightMillimeters + " ∂мм, Средний балл: " + ScoreAverage);
            // Вывод с форматированием
            Console.WriteLine("Имя: " + Name + ", Возраст: " + Age.ToString("#") + " лет, Рост: " + HeightMillimeters.ToString("### ###") + " мм, Средний балл: " + ScoreAverage.ToString("#.##"));
            // Интерполяция строк
            String message = $"Имя: {Name}, Возраст: {Age:0} лет, Рост: {HeightMillimeters:### ###} мм, Средний балл: {ScoreAverage:0.00}";
            Console.WriteLine(message);
            Console.WriteLine("Нажмите кнопку для вывода по центру консоли");
            Console.ReadKey();

            CenterPrint(message);
        }

        private static void CenterPrint(String Message)
        {
            Console.Clear();
            int Height = Console.WindowHeight;
            int Width = Console.WindowWidth;

            int CenterLine = Height / 2 - 1;
            int CenterWidth = Width / 2;
            int TypeFrom = CenterWidth - Message.Length / 2;
            Console.CursorLeft = TypeFrom;
            Console.CursorTop = CenterLine;
            Console.Write(Message);
        }
    }
}
