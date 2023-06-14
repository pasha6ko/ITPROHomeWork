namespace ITPROHomeWork
{
    public abstract class Vehicle
    {
        protected Vehicle(string name, int weight, int speedLimit, string fabricator, int fuelTankCapacity)
        {
            Name = name;
            Weight = weight;
            SpeedLimit = speedLimit;
            Fabricator = fabricator;
            FuelTankCapacity = fuelTankCapacity;
        }
        /// <summary>Название</summary>
        public string Name { get; private set; }
        /// <summary>Вес кг</summary>
        public int Weight { get; private set; }
        /// <summary>Максимальная скорость км/ч</summary>
        public int SpeedLimit { get; private set; }
        /// <summary>Имя производителя</summary>
        public string Fabricator { get; private set; }
        /// <summary>Объём топливного бака</summary>
        public int FuelTankCapacity { get; private set; }
        /// <summary>Выводит в консоль параметры транспорта</summary>
        public virtual void ShowInfo()
        {
            Console.WriteLine("__________________Vehicle__________________");
            Console.WriteLine($"Название: {Name}");
            Console.WriteLine($"Вес: {Weight}Кг");
            Console.WriteLine($"Ограничение скорости: {SpeedLimit}Км/ч");
            Console.WriteLine($"Производитель: {Fabricator}");
            Console.WriteLine($"Объём топливного бака: {FuelTankCapacity}л");
        }

    }

    public class Car : Vehicle
    {
        /// <summary>Класс автомобиля=</summary>
        public string Classification { get; private set; }
        /// <summary>Время разгона до 100Км/ч</summary>
        public float AccelerationSpeed { get; private set; }
        /// <summary>Цена автомобиля</summary>
        public int Price { get; private set; }

        /// <param name="name">Название транспорта</param>
        /// <param name="weight">Вес</param>
        /// <param name="speedLimit">Лимит скорости</param>
        /// <param name="fabricator">Производитель</param>
        /// <param name="fuelTankCapacity">Объём бака</param>
        /// <param name="classification">Класс</param>
        /// <param name="accelerationSpeed">Время разгона</param>
        /// <param name="price">Цена</param>
        public Car(string name, int weight, int speedLimit, string fabricator, int fuelTankCapacity, string classification, float accelerationSpeed, int price) : base(name, weight, speedLimit, fabricator, fuelTankCapacity)
        {
            this.Classification = classification;
            this.AccelerationSpeed = accelerationSpeed;
            this.Price = price;
        }

        public override void ShowInfo()
        {
            base.ShowInfo();
            Console.WriteLine($"Класс: {Classification}");
            Console.WriteLine($"Время разгона: {AccelerationSpeed}с");
            Console.WriteLine($"Цена: {Price}$");
        }
    }

    public class PassengerCar : Car
    {
        /// <param name="name">Название транспорта</param>
        /// <param name="weight">Вес</param>
        /// <param name="speedLimit">Лимит скорости</param>
        /// <param name="fabricator">Производитель</param>
        /// <param name="fuelTankCapacity">Объём бака</param>
        /// <param name="classification">Класс</param>
        /// <param name="accelerationSpeed">Время разгона</param>
        /// <param name="price">Цена</param>
        /// <param name="passengerLimit">Максимальное количество посажиров</param>
        public PassengerCar(string name, int weight, int speedLimit, string fabricator, int fuelTankCapacity, string classification, float accelerationSpeed, int price, int passengerLimit) : base(name, weight, speedLimit, fabricator, fuelTankCapacity, classification, accelerationSpeed, price)
        {
            PassengerLimit = passengerLimit;
        }

        /// <summary> Максимальное количество посажиров</summary>
        public int PassengerLimit { get; private set; }

        public override void ShowInfo()
        {
            base.ShowInfo();
            Console.WriteLine($"Максимальное колличество пассажиров: {PassengerLimit}");
        }

    }

    public class CargoCar : Car
    {
        /// <param name="name">Название транспорта</param>
        /// <param name="weight">Вес</param>
        /// <param name="speedLimit">Лимит скорости</param>
        /// <param name="fabricator">Производитель</param>
        /// <param name="fuelTankCapacity">Объём бака</param>
        /// <param name="classification">Класс</param>
        /// <param name="accelerationSpeed">Время разгона</param>
        /// <param name="price">Цена</param>
        /// <param name="loadCopacity">Грузоподъёмность т.</param>
        public CargoCar(string name, int weight, int speedLimit, string fabricator, int fuelTankCapacity, string classification, float accelerationSpeed, int price, float loadCopacity) : base(name, weight, speedLimit, fabricator, fuelTankCapacity, classification, accelerationSpeed, price)
        {
            LoadCopacity = loadCopacity;
        }

        /// <summary>Грузоподъёмность т.</summary>
        public float LoadCopacity { get; private set; }

        public override void ShowInfo()
        {
            base.ShowInfo();
            Console.WriteLine($"Грузоподъёмность: {LoadCopacity}т");
        }
    }

    public class AirPlane : Vehicle
    {
        /// <param name="name">Название транспорта</param>
        /// <param name="weight">Вес</param>
        /// <param name="speedLimit">Лимит скорости</param>
        /// <param name="fabricator">Производитель</param>
        /// <param name="fuelTankCapacity">Объём бака</param>
        /// <param name="maxFlyMass">Максимально подёмная масса</param>
        /// <param name="maxAreodynamicQuality">Максимальное Аэродинамическое качество</param>
        /// <param name="wingArea">Площадь крыла</param>
        public AirPlane(string name, int weight, int speedLimit, string fabricator, int fuelTankCapacity, float maxFlyMass, float maxAreodynamicQuality, float wingArea) : base(name, weight, speedLimit, fabricator, fuelTankCapacity)
        {
            MaxFlyMass = maxFlyMass;
            MaxAreodynamicQuality = maxAreodynamicQuality;
            WingArea = wingArea;
        }

        /// <summary>Максимальная взлётная масса, т.</summary>
        public float MaxFlyMass { get; private set; }
        /// <summary>Максимальное аэродинамическое качество</summary>
        public float MaxAreodynamicQuality { get; private set; }
        /// <summary>Площадь крыла м2</summary>
        public float WingArea { get; private set; }

        public override void ShowInfo()
        {
            base.ShowInfo();
            Console.WriteLine($"Максимальная взлётная масса: {MaxFlyMass}т");
            Console.WriteLine($"Максимальное аэродинамическое качество: {MaxAreodynamicQuality}");
            Console.WriteLine($"Площадь крыла: {WingArea}м2");
        }
    }

    public class PassengerAirPlane : AirPlane
    {
        /// <param name="name">Название транспорта</param>
        /// <param name="weight">Вес</param>
        /// <param name="speedLimit">Лимит скорости</param>
        /// <param name="fabricator">Производитель</param>
        /// <param name="fuelTankCapacity">Объём бака</param>
        /// <param name="maxFlyMass">Максимально подёмная масса</param>
        /// <param name="maxAreodynamicQuality">Максимальное Аэродинамическое качество</param>
        /// <param name="wingArea">Площадь крыла</param>
        /// <param name="passagerLimit">Лимит пасажиров</param>
        public PassengerAirPlane(string name, int weight, int speedLimit, string fabricator, int fuelTankCapacity, float maxFlyMass, float maxAreodynamicQuality, float wingArea, int passagerLimit) : base(name, weight, speedLimit, fabricator, fuelTankCapacity, maxFlyMass, maxAreodynamicQuality, wingArea)
        {
            PassengerLimit = passagerLimit;
        }

        /// <summary> Максимальное количество посажиров</summary>
        public int PassengerLimit { get; private set; }

        public override void ShowInfo()
        {
            base.ShowInfo();
            Console.WriteLine($"Максимальное колличество пассажиров: {PassengerLimit}");
        }
    }

    public class CargoAirPlane : AirPlane
    {
        /// <param name="name">Название транспорта</param>
        /// <param name="weight">Вес</param>
        /// <param name="speedLimit">Лимит скорости</param>
        /// <param name="fabricator">Производитель</param>
        /// <param name="fuelTankCapacity">Объём бака</param>
        /// <param name="maxFlyMass">Максимально подёмная масса</param>
        /// <param name="maxAreodynamicQuality">Максимальное Аэродинамическое качество</param>
        /// <param name="wingArea">Площадь крыла</param>
        /// <param name="loadCopacity">Грузоподъёмность т.</param>
        public CargoAirPlane(string name, int weight, int speedLimit, string fabricator, int fuelTankCapacity, float maxFlyMass, float maxAreodynamicQuality, float wingArea, float loadCopacity) : base(name, weight, speedLimit, fabricator, fuelTankCapacity, maxFlyMass, maxAreodynamicQuality, wingArea)
        {
            LoadCopacity = loadCopacity;
        }

        /// <summary>Грузоподъёмность т.</summary>
        public float LoadCopacity { get; private set; }

        public override void ShowInfo()
        {
            base.ShowInfo();
            Console.WriteLine($"Грузоподъёмность: {LoadCopacity}т");
        }
    }
}
