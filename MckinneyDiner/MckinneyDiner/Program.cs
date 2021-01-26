using System;
using System.Collections;
using System.Collections.Generic;

namespace Diner
{
    public class MckinneyDiner
    {
        private Queue<int> waitingQueue = new Queue<int>();

        public void addCustomerToQueue(int parameter)
        {
            waitingQueue.Enqueue(parameter);
        }

        public void showCustomer()
        {
            Console.Write("This is the amount of customers that need to be seated: " +
                                 waitingQueue.Count);

        }
        public void actualCustomer()
        {
            foreach (var item in waitingQueue)
            {
                Console.WriteLine("Customer: " + item);
            }
        }
        public void CustomerSeated()
        {
            waitingQueue.Dequeue();
        }
        private Stack<String> DirtyDish = new Stack<string>();
        private Stack<string> CleanDish = new Stack<string>();

        public void CustomerDishes(string Dishes)
        {
            DirtyDish.Push(Dishes);

        }
        public void CleanTheDishes()
        {
            string lastCustomer = DirtyDish.Pop();
            CleanDish.Push(lastCustomer);
        }
        public void CleanPile()
        {
            foreach(var item in  CleanDish)
            {
                Console.WriteLine("The dishes are put back:" + item);
            }
        }






        static void Main(string[] args)
        {
            MckinneyDiner restaurantCustomer = new MckinneyDiner();
            restaurantCustomer.addCustomerToQueue(1);
            restaurantCustomer.addCustomerToQueue(2);
            restaurantCustomer.addCustomerToQueue(3);
            restaurantCustomer.addCustomerToQueue(4);
            restaurantCustomer.addCustomerToQueue(5);
            restaurantCustomer.addCustomerToQueue(6);

            restaurantCustomer.CustomerSeated();

            restaurantCustomer.actualCustomer();




        
            restaurantCustomer.CustomerDishes("dish1");
            restaurantCustomer.CustomerDishes("dish2");
            restaurantCustomer.CustomerDishes("dish3");

            restaurantCustomer.CleanTheDishes();
            restaurantCustomer.CleanPile();












        }

    }

    

}

