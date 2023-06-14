namespace ITPROClassWork
{
    public class Driver
    {
        protected string name;
        protected int driveExperience;

        public Driver(string name, int driveExperience)
        {
            this.name = name;
            this.driveExperience = driveExperience;
        }

        public void ShowInfo()
        {
            Console.WriteLine($"ФИО: {name}");
            Console.WriteLine($"Стаж вождения: {driveExperience}");
        }
    }
    public class Engine
    {
        protected int power;
        protected string fabricator;

        public Engine(int power, string fabricator)
        {
            this.power = power;
            this.fabricator = fabricator;
        }

        public void ShowInfo()
        {
            Console.WriteLine($"Мощность: {power}");
            Console.WriteLine($"Производитель: {fabricator}");
        }
    }
    public class Car
    {
        protected string brand;
        protected string classification;
        protected int weight;
        protected Driver driver;
        protected Engine engine;

        public Car(string brand, string classification, int weight, Driver driver, Engine engine)
        {
            this.brand = brand;
            this.classification = classification;
            this.weight = weight;
            this.driver = driver;
            this.engine = engine;
        }

        public void Start() => Console.WriteLine("Поехали");

        public void Stop() => Console.WriteLine("Останавливаемся");

        public void TurnLeft() => Console.WriteLine("Поворот налево");

        public void TurnRight() => Console.WriteLine("Поворот направо");

        public virtual void ShowInfo()
        {
            Console.WriteLine("___________СarInfo___________");
            Console.WriteLine($"Произваодитель: {brand}");
            Console.WriteLine($"Класс: {classification}");
            Console.WriteLine($"Вес: {weight}");
            Console.WriteLine($"Водитель:");
            driver.ShowInfo();
            Console.WriteLine($"Двигатель:");
            engine.ShowInfo();
        }
    }
    public class Lorry : Car
    {
        protected int loadCopacity;

        public Lorry(string brand, string classification, int weight, Driver driver, Engine engine, int loadCopacity) : base(brand, classification, weight, driver, engine)
        {
            this.loadCopacity = loadCopacity;
        }

        public override void ShowInfo()
        {
            base.ShowInfo();
            Console.WriteLine($"Грузоподёмность: {loadCopacity}");
        }
    }
    public class SportCar : Car
    {
        protected int speedLimit;

        public SportCar(string brand, string classification, int weight, Driver driver, Engine engine, int speedLimit) : base(brand, classification, weight, driver, engine)
        {
            this.speedLimit = speedLimit;
        }

        public override void ShowInfo()
        {
            base.ShowInfo();
            Console.WriteLine($"Предельная скорость: {speedLimit}");
        }
    }

}
