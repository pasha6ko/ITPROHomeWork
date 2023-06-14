using ITPROHomeWork;

PassengerCar passengerCar = new PassengerCar("911 Turbo",1715,320,"Porche",25,"F",2.8f,239000,2);
passengerCar.ShowInfo();
CargoCar cargoCar = new CargoCar("HD78",1000,175, "Hyundai",50,"",13f,4000,5.0f);
cargoCar.ShowInfo();
PassengerAirPlane passengerAirPlane = new PassengerAirPlane("Boeing 767", 175540, 967, "Boeing", 77412, 142880, 16f, 47.57f, 255);
passengerAirPlane.ShowInfo();
CargoAirPlane cargoAirPlane = new CargoAirPlane("Ан 225 «Мрия»",250000,900, "Авиалинии Антонова", 300000,60000,7.6f,88.5f,250);
cargoAirPlane.ShowInfo();
Train train = new Train("ЭТ2М", 100000, 120, "РЖД", 0, 13);
train.ShowInfo();