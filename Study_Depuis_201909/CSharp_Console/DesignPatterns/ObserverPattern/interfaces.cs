namespace DesignPattern.ObserverPattern
{
    /*
     * 2019.08.26
     */
    public interface Subject
    {
        void registerObserver(Observer o);
        void removeObserver(Observer o);
        void notifyObserver();
    }

    public interface Observer
    {
        void update(float temp, float humidity, float pressure);
    }

    public interface DisplayElement
    {
        void display();
    }
}
