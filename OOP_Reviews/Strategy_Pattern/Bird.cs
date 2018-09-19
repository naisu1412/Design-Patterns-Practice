namespace Design_Patterns
{

    public class Bird: Animal {
        public Bird(){
            setSound(" Tweet ");


            flyingType  = new FlyBehaviour();
        }
    }

}