namespace Design_Patterns
{
    public class StockObserver : IObserver
    {
   
        private double ibmPrice;
        private double applePrice;
        private double googlePrice;


        private static int observerIDTracker = 0;

        private int observerID;

        private ISubject stockGrabber;

        public StockObserver( ISubject stockGrabber ){
            this.stockGrabber = stockGrabber;

            this.observerID = ++observerIDTracker;

            System.Console.WriteLine( "New Observer " + this.observerID );
            
            
            stockGrabber.register(this);
        

        }
        public void update(double ibmPrice, double applePrice, double  googlePrice){
            this.ibmPrice = ibmPrice;
            this.applePrice = applePrice;
            this.googlePrice = googlePrice;
        }
    }
}