using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace srpexamples
{
    public interface IMovingToys
    {
        void Move();
    }
    public interface IFlyingToys
    {
        void Fly();
    }
    public interface IToysPrice
    {
        void SetToysPrice(double price);
        double GetToysPrice(int id);
    }
    class FlyingToys:IFlyingToys,IToysPrice
    {
        public void Fly()
        {
            Console.WriteLine("Flying toys");
        }

        public void SetToysPrice(double price)
        {
            Console.WriteLine(price);
        }

        public double GetToysPrice(int id)
        {
            double price = 50000;
            return price;
        }

    }
    public class MovingToys : IMovingToys, IToysPrice
    {
        public double GetToysPrice(int id)
        {
            double amount = 1000;
            return amount;
        }

        public void Move()
        {
            Console.WriteLine("Moving Toys");
        }

        public void SetToysPrice(double price)
        {
            Console.WriteLine(price);
        }
    }
    class Isp
    {
        static void Main(string[] args)
        {
            FlyingToys flyingToys = new FlyingToys();
            flyingToys.Fly();
            
            double Amount=flyingToys.GetToysPrice(1);
            flyingToys.SetToysPrice(Amount);
            MovingToys movingToys = new MovingToys();
            movingToys.Move();
           
            double Price= movingToys.GetToysPrice(1);
            movingToys.SetToysPrice(Price);

        }
    }
}
