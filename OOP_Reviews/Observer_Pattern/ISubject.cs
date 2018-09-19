namespace Design_Patterns{
    public interface ISubject
    {
         void register (IObserver o);
         void unregister (IObserver o);
         void notifyObserver ();
    }
}