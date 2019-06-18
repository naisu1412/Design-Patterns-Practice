using System;
using System.Collections.Generic;
using System.Text;

namespace DecoratorSampleApp
{


    /* 
        You got an item you can either delete or 
    */
    class Program
    {
        static void Main(string[] args)
        {
            for(int i = 0; i < 5; i++){
                Console.WriteLine("Hello There");
            }
        }
    }


    class Game{
        Random numRand= new Random(1);
        Iitem itemInvent;

        int num ;

        public Game(Iitem itemInvent){
          this.itemInvent = itemInvent;
        }


        public void Run(){
           itemInvent.itemManage("item");
        }
    }

    interface Iitem{
        void itemManage(string itemName);
    }

    class DeleteBehaviour : Iitem{
        public void itemManage(string itemName){
            System.Console.WriteLine("Item is deleted");
        }
    }

    class AddToInventoryBehaviour : Iitem{
        
        public void itemManage(string itemName){
            System.Console.WriteLine("Item is added");            
        }
    }


    
}
























  /* 
            // Let us create a Simple Cake Base first
            CakeBase cBase = new CakeBase();
            PrintProductDetails(cBase);

            // Lets add cream to the cake
            CreamDecorator creamCake = new CreamDecorator(cBase);
            PrintProductDetails(creamCake);
            
            // Let now add a Cherry on it
            CherryDecorator cherryCake = new CherryDecorator(creamCake);
            PrintProductDetails(cherryCake);

            // Lets now add Scent to it
            ArtificialScentDecorator scentedCake = new ArtificialScentDecorator(cherryCake);
            PrintProductDetails(scentedCake);

            // Finally add a Name card on the cake
            NameCardDecorator nameCardOnCake = new NameCardDecorator(scentedCake);
            PrintProductDetails(nameCardOnCake);
            
            // Lets now create a simple Pastry
            PastryBase pastry = new PastryBase();
            PrintProductDetails(pastry);

            // Lets just add cream and cherry only on the pastry 
            CreamDecorator creamPastry = new CreamDecorator(pastry);
            CherryDecorator cherryPastry = new CherryDecorator(creamPastry);
            PrintProductDetails(cherryPastry);
        }

        private static void PrintProductDetails(BakeryComponent product)
        {
            Console.WriteLine(); // some whitespace for readability
            Console.WriteLine("Item: {0}, Price: {1}", product.GetName(), product.GetPrice());
        }
        */
