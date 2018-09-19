using System;


namespace Design_Patterns{
    public class Dog : Animal{
        public void digHole(){
            System.Console.WriteLine( "Dog dug a hole" );
        }

        public void changeVar( int randNum ){
            randNum = 12;

            System.Console.WriteLine( "randNum in method value: " + randNum );
        }

        public Dog(){
        
          setSound( "Bark" );

         flyingType  = new CannotFlyBehaviour();


        }


    }
}