using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfacesDemo
{                           //SOLID Interface Segregation
    class Program
    {
        static void Main(string[] args)
        {
            IWorker[] workers = new IWorker[3]{
                new Manager(), new Robot(),new Worker() };

            foreach (var worker in workers)
            {
                worker.Work();


            }
            IEat[] eats = new IEat[2]
            {
                new Manager(),new Worker()
            };
            foreach (var eater in eats)
            {
                eater.Eat();
            }
         }

        interface IWorker
        {
            void Work();
            
            

        }

        interface IEat
        {
            void Eat();
        }

        interface ISalary
        {
            void GetSalary();
    }

        class Manager : IWorker, IEat, ISalary
        {
            public void Eat()
            {
                throw new NotImplementedException();
            }

            public void GetSalary()
            {
                throw new NotImplementedException();
            }

            public void Work()
            {
                throw new NotImplementedException();
            }
        }
        class Worker : IWorker, IEat, ISalary
        {
            public void Eat()
            {
                throw new NotImplementedException();
            }

            public void GetSalary()
            {
                throw new NotImplementedException();
            }

            public void Work()
            {
                throw new NotImplementedException();
            }
        }
        class Robot : IWorker
        {
            public void Work()
            {
                throw new NotImplementedException();
            }
        }
    }
}
