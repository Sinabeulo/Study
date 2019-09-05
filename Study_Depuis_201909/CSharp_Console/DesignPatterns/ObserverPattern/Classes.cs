using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static DesignPattern.Program;

namespace DesignPattern.ObserverPattern
{
    /*
     * 2019.08.26
     */
    public class WeatherStation : IExampleRun
    {
        public WeatherStation()
        {
            Console.WriteLine("=== === ObserverPattern === ===");
            RunExample();
        }

        public void RunExample()
        {
            WeatherData weatherData = new WeatherData();
            CurrentConditionsDisplay ConditionsDisplay = new CurrentConditionsDisplay(weatherData);

            weatherData.setMeasurements(80, 65, 30.4f);
            weatherData.setMeasurements(82, 70, 29.2f);
            weatherData.setMeasurements(78, 65, 29.2f);

        }
    } // END WeatherStation

    internal class WeatherData : Subject
    {
        /*
         * 옵저버 패턴
         * 주체에 옵저버들이 등록 취소 할 수 있다.
         * 주체는 값이 변경되면 모든 옵저버 객체에게 알린다.
         */
        private List<Observer> observers;
        private float temperature;
        private float humidity;
        private float pressure;

        public WeatherData()
        {
            observers = new List<Observer>();
        }

        public void registerObserver(Observer o)
        {
            observers.Add(o);
        }

        public void removeObserver(Observer o)
        {
            observers.Remove(o);
        }

        public void notifyObserver()
        {
            foreach(var o in observers)
            {
                o.update(temperature, humidity, pressure);
            }
        }
        
        public void measurementsChanged()
        {
            notifyObserver();
        }

        public void setMeasurements(float temperature, float humidity, float pressure)
        {
            this.temperature = temperature;
            this.humidity = humidity;
            this.pressure = pressure;
            measurementsChanged();
        }

        //기타 WeatherData 메서드
    } // END WeatherData

    internal class CurrentConditionsDisplay : Observer, DisplayElement
    {
        private float temperature;
        private float humidity;
        private Subject weatherData;

        public CurrentConditionsDisplay(Subject weatherData)
        {
            this.weatherData = weatherData;
            weatherData.registerObserver(this);
        }

        public void update(float temp, float humidity, float pressure)
        {
            this.temperature = temp;
            this.humidity = humidity;
            display();
        }

        public void display()
        {
            Console.WriteLine("Current Conditions: " + temperature + "F degress and " + humidity + "% humidity");
        }
    } // END CurrentConditionsDisplay
}
