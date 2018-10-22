
using System;
using System.Collections.Generic;


namespace Design_Patterns{
    public class StockGrabber : ISubject{

        private List<IObserver> observers;
        private double ibmPrice;
        private double applePrice;
        private double googlePrice;


        public StockGrabber (){
            observers = new List<IObserver>();
        }
        //Overriding the register in the ISubject
        public void register(IObserver newObserver){
            //adding the observer
            observers.Add(newObserver);
        }

         public void unregister(IObserver deleteObserver){
            int observerIndex = observers.IndexOf(deleteObserver);

            System.Console.WriteLine( "Observer " + (observerIndex + 1) + " deleted" );

            observers.RemoveAt(observerIndex);
        }

         public void notifyObserver(){
            foreach (IObserver observer in observers)
            {
                observer.update(ibmPrice, applePrice, googlePrice);
            }
        }

          public void setApplePrice( double newApplePrice ){
              this.applePrice = newApplePrice;
              notifyObserver();
          }

            public void setIbmPrice( double newIbmPrice ){
              this.ibmPrice = newIbmPrice;
              notifyObserver();
          }

            public void setGooglePrice( double newGooglePrice ){
              this.googlePrice = newGooglePrice;
              notifyObserver();
          }

          
    }
}