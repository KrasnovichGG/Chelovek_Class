using System;
using System.Threading;

namespace Chelovek_Class
{
    public delegate void Smert(string message);
    public delegate void Jump(string message);
    class Program
    {
        static void Main(string[] args)
        {
            //Как мне выводить его имя возратс и т.п. на CW?
            Chelovek Sasha = new Chelovek("Sasha", 18, true, 2, 2, "Krutoi", "Brown", "Black", "Black",new RightHand(),new LeftHand(),new RightFoot(),new LeftFoot());
            Sasha.Dead();
            Sasha.Sleep();
            Console.WriteLine(Sasha.righthand);
        }
    }
    public class Chelovek
    {
        string name { get; set; } /*1*/
        int? age { get; set; } /*2*/
        bool man_or_woman { get; set; } /*3*/
        int hand { get; set; } /*4*/
        int foot { get; set; } /*5*/
        string build { get; set; } /*6*/
        string hair_color { get; set; } /*7*/
        string eyes_color { get; set; } /*8*/
        string skin_color { get; set; } /*9*/
        int blood = 500; /*10*/
        int minuta = 3600;
        Smert smert = Console.WriteLine;
        Jump jump = Console.WriteLine;
        readonly public Ihand righthand;
        readonly public Ihand lefthand;
        readonly public Ifoot LeftFoot;
        readonly public Ifoot RightFoot;
        public Chelovek(string name,int age,bool man_or_woman, int hand,int foot,string build,string hair_color,string eyes_color,string skin_color,Ihand righthand = null,Ihand lefthand= null,Ifoot LeftFoot = null, Ifoot RightFoot = null)
        {
            this.age = age;
            this.build = build;
            this.eyes_color = eyes_color;
            this.foot = foot;
            this.hair_color = hair_color;
            this.hand = hand;
            this.man_or_woman = man_or_woman;
            this.name = name;
            this.skin_color = skin_color;
            this.righthand = righthand;
            this.lefthand = lefthand;
        }
        public Chelovek()
        {

        }
        public void Sleep()
        {
            for (int i = 0; i < minuta; i++)
            {

                Console.Write(i + " " +"минута" + " " + "Братанчик спит:)");
                Thread.Sleep(1000);
            }
           
        }
        public void Jump()
        {
            double v = 2;
            double g = 9.8;
            double h = 2.22;
            double JUMP = (v * v)  * g * h;
            jump("Поздравляю Братан ты на высоте:)" + " " + "Твой прыжок составил:" + " " + JUMP);
        }
        public void Dead()
        {
            smert("Братан ты умер:( Твой возраст:" + " " + age + "лет");
        }
        public double Run()
        {
            const double V = 2.5;
            double skorost = V * (double)age;
            if (skorost >= 44) 
            {
                Console.WriteLine("У вас сверхчеловек берегите такого! Его скорость более 44км.ч и равна:" + " "+ skorost + "км.ч");
            }
            return skorost;
        }
        public void KchBlood()
        {
            for (int i = 1; i <= blood; i++)
            {
                Console.Write(i + " " + "Кровь качается!");
                Thread.Sleep(10);
            }
        }
        
    }
    abstract class Foots : Ifoot
    {
        public  double Dlinafoot { get; set; }
        public  int Fingers { get; set; }
        public  bool job { get; set; }
    }
    class LeftFoot : Foots
    {
        public LeftFoot()
        {
            Dlinafoot = 1.2;
            Fingers = 5;
            job = true;
        }
        public override string ToString()
        {
            return $"Длина вашей левой ноги: {Dlinafoot} и количество пальцев {Fingers} и она работает :) {job}";
        }
    }
    class RightFoot : Foots
    {
        public RightFoot()
        {
            Dlinafoot = 1.2;
            Fingers = 5;
            job = true;
        }
        public override string ToString()
        {
            return $"Длина вашей правой ноги: {Dlinafoot} и количество пальцев {Fingers} и она работает :) {job}";
        }
    }

    abstract class Hands : Ihand
    {
        public  double Dlina { get; set; }
        public  int Fingers { get; set; }
        public  bool Hand_Brush { get; set; }
    }
    class LeftHand : Hands 
    {
       public LeftHand()
        {
            Dlina = 0.65;
            Fingers = 5;
            Hand_Brush = true;

        }
        public override string ToString()
        {
            return $"Длина вашей левой руки: {Dlina} и количество пальцев {Fingers} и {Hand_Brush} в норме:)";
        }
    }
    class RightHand : Hands
    {
        public RightHand()
        {
            Dlina = 0.64;
            Fingers = 5;
            Hand_Brush = true;

        }
        public override string ToString()
        {
            return $"Длина вашей правой руки: {Dlina} и количество пальцев {Fingers} и {Hand_Brush} в норме:)";
        }
    }
}
