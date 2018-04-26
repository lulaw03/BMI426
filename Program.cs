using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace BM.I317
{
    class Program
    {
        static void Main(string[] args)
        {   //宣告馬力歐BEEP音
            Console.Beep(659, 125); Console.Beep(659, 125); Thread.Sleep(125); Console.Beep(659, 125); Thread.Sleep(167); Console.Beep(523, 125); Console.Beep(659, 125); Thread.Sleep(125); Console.Beep(784, 125); Thread.Sleep(375); Console.Beep(392, 125); Thread.Sleep(375); Console.Beep(523, 125); Thread.Sleep(250); Console.Beep(392, 125); Thread.Sleep(250); Console.Beep(330, 125); Thread.Sleep(250); Console.Beep(440, 125); Thread.Sleep(125); Console.Beep(494, 125); Thread.Sleep(125); Console.Beep(466, 125); Thread.Sleep(42); Console.Beep(440, 125); Thread.Sleep(125); Console.Beep(392, 125); Thread.Sleep(125); Console.Beep(659, 125); Thread.Sleep(125); Console.Beep(784, 125); Thread.Sleep(125); Console.Beep(880, 125); Thread.Sleep(125); Console.Beep(698, 125); Console.Beep(784, 125); Thread.Sleep(125); Console.Beep(659, 125); Thread.Sleep(125); Console.Beep(523, 125); Thread.Sleep(125); Console.Beep(587, 125); Console.Beep(494, 125); Thread.Sleep(125); Console.Beep(523, 125); Thread.Sleep(250); Console.Beep(392, 125); Thread.Sleep(250); Console.Beep(330, 125); Thread.Sleep(250); Console.Beep(440, 125); Thread.Sleep(125); Console.Beep(494, 125); Thread.Sleep(125); Console.Beep(466, 125); Thread.Sleep(42); Console.Beep(440, 125); Thread.Sleep(125); Console.Beep(392, 125); Thread.Sleep(125); Console.Beep(659, 125); Thread.Sleep(125); Console.Beep(784, 125); Thread.Sleep(125); Console.Beep(880, 125); Thread.Sleep(125); Console.Beep(698, 125); Console.Beep(784, 125); Thread.Sleep(125); Console.Beep(659, 125); Thread.Sleep(125); Console.Beep(523, 125); Thread.Sleep(125); Console.Beep(587, 125); Console.Beep(494, 125); Thread.Sleep(375); Console.Beep(784, 125); Console.Beep(740, 125); Console.Beep(698, 125); Thread.Sleep(42); Console.Beep(622, 125); Thread.Sleep(125); Console.Beep(659, 125); Thread.Sleep(167); Console.Beep(415, 125); Console.Beep(440, 125); Console.Beep(523, 125); Thread.Sleep(125); Console.Beep(440, 125); Console.Beep(523, 125); Console.Beep(587, 125); Thread.Sleep(250); Console.Beep(784, 125); Console.Beep(740, 125); Console.Beep(698, 125); Thread.Sleep(42); Console.Beep(622, 125); Thread.Sleep(125); Console.Beep(659, 125); Thread.Sleep(167); Console.Beep(698, 125); Thread.Sleep(125); Console.Beep(698, 125); Console.Beep(698, 125); Thread.Sleep(625); Console.Beep(784, 125); Console.Beep(740, 125); Console.Beep(698, 125); Thread.Sleep(42); Console.Beep(622, 125); Thread.Sleep(125); Console.Beep(659, 125); Thread.Sleep(167); Console.Beep(415, 125); Console.Beep(440, 125); Console.Beep(523, 125); Thread.Sleep(125); Console.Beep(440, 125); Console.Beep(523, 125); Console.Beep(587, 125); Thread.Sleep(250); Console.Beep(622, 125); Thread.Sleep(250); Console.Beep(587, 125); Thread.Sleep(250); Console.Beep(523, 125); Thread.Sleep(1125); Console.Beep(784, 125); Console.Beep(740, 125); Console.Beep(698, 125); Thread.Sleep(42); Console.Beep(622, 125); Thread.Sleep(125); Console.Beep(659, 125); Thread.Sleep(167); Console.Beep(415, 125); Console.Beep(440, 125); Console.Beep(523, 125); Thread.Sleep(125); Console.Beep(440, 125); Console.Beep(523, 125); Console.Beep(587, 125); Thread.Sleep(250); Console.Beep(784, 125); Console.Beep(740, 125); Console.Beep(698, 125); Thread.Sleep(42); Console.Beep(622, 125); Thread.Sleep(125); Console.Beep(659, 125); Thread.Sleep(167); Console.Beep(698, 125); Thread.Sleep(125); Console.Beep(698, 125); Console.Beep(698, 125); Thread.Sleep(625); Console.Beep(784, 125); Console.Beep(740, 125); Console.Beep(698, 125); Thread.Sleep(42); Console.Beep(622, 125); Thread.Sleep(125); Console.Beep(659, 125); Thread.Sleep(167); Console.Beep(415, 125); Console.Beep(440, 125); Console.Beep(523, 125); Thread.Sleep(125); Console.Beep(440, 125); Console.Beep(523, 125); Console.Beep(587, 125); Thread.Sleep(250); Console.Beep(622, 125); Thread.Sleep(250); Console.Beep(587, 125); Thread.Sleep(250); Console.Beep(523, 125);

            // 宣告變數
            double BMI;

            // 設定字顏色
            Console.ForegroundColor = ConsoleColor.Red;

            // 介面、輸入數值
            Console.WriteLine("請輸入你的體重(公斤):");

            double weight = double.Parse(Console.ReadLine());


            Console.WriteLine("請輸入你的身高(公分):");

            double height = double.Parse(Console.ReadLine());

            // 設定BMI公式
            BMI = weight / (height/100) * (height/100);

            // 判斷體重等級
             
            if (BMI < 20)

            {
                Console.WriteLine("過輕，多吃一點身體會變得更健康喔！");
            }

            if (BMI >= 20 && BMI <= 25)

            {
                Console.WriteLine("正常，你不會想變成我這樣肥胖的傢伙");
            }

            if (BMI > 25 && BMI <= 28)

            {
                Console.WriteLine("過重，少吃一點身體就會變得更健康喔！");
            }

            if(BMI > 28)

            {
                Console.WriteLine("肥胖，恭喜你因為太胖所以免役！呵呵");
            }

            Console.WriteLine("請按1退出視窗");

            // 秀動畫，加分用
            int Joke = int.Parse(Console.ReadLine());

            if(Joke == 1)

            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Yellow;
                
                Console.WriteLine("╮(╯３╰)╭");
                          System.Threading.Thread.Sleep(500);
                Console.Clear();

                Console.WriteLine("  ╰(╯３╰)╯");
                          System.Threading.Thread.Sleep(500);
                Console.Clear();
                
                Console.WriteLine("      ╮(╯３╰)╭");
                          System.Threading.Thread.Sleep(500);
                Console.Clear();

                Console.WriteLine("       ╰(╯３╰)╯");
                          System.Threading.Thread.Sleep(500);
                Console.Clear();

                Console.WriteLine("         ╮(╯３╰)╭");
                          System.Threading.Thread.Sleep(500);
                Console.Clear();

                Console.WriteLine("          ╰(╯３╰)╯");
                          System.Threading.Thread.Sleep(500);
                Console.Clear();

                Console.WriteLine("            ╮(╯３╰)╭");
                         System.Threading.Thread.Sleep(500);
                Console.Clear();
            }

                      
        }
    }
}
