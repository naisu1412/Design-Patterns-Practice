namespace Design_Patterns
{

    public class Animal{


        public Animal(){
          
        }
        private string name;
        private double height;
        private int weight;
        private string favFood;
        private string sound;
        
        // implementing ng fly
        public IFly flyingType;

        public void setName(string newName){
            name = newName;
        }
        public string getName(){ return name; }

        public void setHeight(double newHeight){ height = newHeight ; }
        public double getHeight(){ return height; }

        public void setWeight( int newWeight ){
            if(newWeight > 0){
                weight = newWeight;
            }else{
                System.Console.WriteLine( "Weight must be bigger than 0" );
            }
        }
        public int getWeight(){ return weight; }

        public void setFavFood( string newFavFood ){ favFood = newFavFood; }
        public string getFavFood(){ return favFood; }



        public void setSound( string newSound ){ sound = newSound; }
        public string getSound(){ return sound; }

            // A private method can only be accessed by other public methods
            // that are in the same class

        private void bePrivate(){
            System.Console.WriteLine( " I'm a private method " );
        }

        public string tryToFly(){

            if(flyingType == null){
                return "Have not set the flying behaviour" ; 
            }else{
            
                return flyingType.fly();
            }           
        }
        
        public void setFlyingAbility( IFly newFlyType ){
            flyingType = newFlyType;
        }
    }
}