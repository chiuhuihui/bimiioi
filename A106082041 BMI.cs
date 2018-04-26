using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            // 字體背景的顏色
            Console.ForegroundColor = ConsoleColor.Black;
            Console.BackgroundColor = ConsoleColor.Gray;

            Console.Write("請輸入身高(cm): ");
            string height = Console.ReadLine();
            float Height = float.Parse(height) / 100;
            Console.Write("請輸入體重(kg): ");
            string weight = Console.ReadLine();
            float Weight = float.Parse(weight);
            float BMI = (Weight / (Height * Height));
            if (BMI < 16.5)
            {
                Console.WriteLine("您的BMI為: " + BMI + ", 免役");
                Console.ReadLine();
            }
            if (16.5 <= BMI && BMI < 18.5)
            {
                Console.WriteLine("您的BMI為: " + BMI + ", 體重過輕免役");
                Console.ReadLine();
            }
            if (18.5 <= BMI && BMI < 24)
            {
                Console.WriteLine("您的BMI為: " + BMI + ", 您的體重正常喔");
                Console.ReadLine();
            }
            if (24 <= BMI && BMI < 28)
            {
                Console.WriteLine("您的BMI為: " + BMI + ", 體重超重");
                Console.ReadLine();
            }
            if (28 <= BMI && BMI <= 31.5)
            {
                Console.WriteLine("您的BMI為: " + BMI + ", 體重過胖");
                Console.ReadLine();
            }
            if (BMI > 31.5)
            {
                Console.WriteLine("您的BMI為: " + BMI + ", 體重過胖免役");
                Console.ReadLine();
            }
        }
    }
}
