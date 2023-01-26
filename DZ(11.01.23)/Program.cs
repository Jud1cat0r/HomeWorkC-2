using System.Xml.Linq;

namespace DZ_11._01._23_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Car car = new Car("Lada", 200);
            car.Move();
            car.Dispose();

        }
    }
    class Car : IDisposable
    {
        string model;
        int speed;
        private bool disposedValue;

        public Car(string model, int speed)
        {
            this.model = model;
            this.speed = speed;
        }

        public void Move()
        {
            Console.WriteLine($"Машина {model} едет со скоростью {speed}");
        }

        protected virtual void Dispose(bool disposing)
        {
            if (!disposedValue)
            {
                if (disposing)
                {
                    // TODO: освободить управляемое состояние (управляемые объекты)
                }

                // TODO: освободить неуправляемые ресурсы (неуправляемые объекты) и переопределить метод завершения
                // TODO: установить значение NULL для больших полей
                disposedValue = true;
            }
        }

        // // TODO: переопределить метод завершения, только если "Dispose(bool disposing)" содержит код для освобождения неуправляемых ресурсов
        ~Car()
        {
            // Не изменяйте этот код. Разместите код очистки в методе "Dispose(bool disposing)".
            Dispose(disposing: false);
        }

        public void Dispose()
        {
            // Не изменяйте этот код. Разместите код очистки в методе "Dispose(bool disposing)".
            Dispose(disposing: true);
            GC.SuppressFinalize(this);
        }
    }
}