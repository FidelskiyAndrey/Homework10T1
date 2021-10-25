using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework10T1
{
    class Program
    {
        static void Main(string[] args)
        {

            Angle angle = new Angle(56, 12, 42);
            angle.ToRadiant();
            Console.ReadKey();

        }
    }

    class Angle
    {

        int gradus;//Градусы
        int min;//Минуты
        int sec;//Секунды

        public int Gradus
        {
            set
            {
                if (value > 0 && value < 360)
                {
                    gradus = value;
                }
                else
                {
                    Console.WriteLine("Значение градуса не может быть больше 360 градусов и отрицательным");
                }
            }
            get
            {
                return gradus;
            }
        }
        public int Min
        {
            set
            {
                if (value > 0 && value < 60)
                {
                    min = value;
                }
                else
                {
                    Console.WriteLine("Значение минут не может быть больше 59 минут и отрицательным");
                }
            }
            get
            {
                return min;
            }
        }
        public int Sec
        {
            set
            {
                if (value > 0 && value < 60)
                {
                    sec = value;
                }
                else
                {
                    Console.WriteLine("Значение секунд не может быть больше 59 минут и отрицательным");
                }
            }
            get
            {
                return sec;
            }
        }
        public Angle(int gradus, int min, int sec)
        {
            this.Gradus = gradus;
            this.Min = min;
            this.Sec = sec;
        }

        public void ToRadiant()
        {

            double d = (gradus + (min / 60) + (sec / 3600)) * Math.PI / 180;
            Console.WriteLine("Радиана данного угла равняется ={0}", d);
        }

    }

}
