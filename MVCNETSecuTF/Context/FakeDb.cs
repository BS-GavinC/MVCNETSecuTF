using MVCNETSecuTF.Models;

namespace MVCNETSecuTF.Context;

public static class FakeDb
{
    private static List<Car> Cars { get; set; } = new ()
    {
        new Car(1, "Audi", "A4", "Noir", 20000, 150),
        new Car(2, "Audi", "A3", "Blanc", 15000, 120),
        new Car(3, "Audi", "A5", "Rouge", 25000, 180),
        new Car(4, "Audi", "A6", "Bleu", 30000, 200),
        new Car(5, "BMW", "Serie 1", "Noir", 20000, 150),
        new Car(6, "BMW", "Serie 2", "Blanc", 15000, 120),
        new Car(7, "BMW", "Serie 3", "Rouge", 25000, 180),
        new Car(8, "BMW", "Serie 4", "Bleu", 30000, 200),
        new Car(9, "Mercedes", "Classe A", "Noir", 20000, 150),
        new Car(10, "Mercedes", "Classe B", "Blanc", 15000, 120),
        new Car(11, "Mercedes", "Classe C", "Rouge", 25000, 180),
        new Car(12, "Mercedes", "Classe E", "Bleu", 30000, 200),
        new Car(13, "Renault", "Clio", "Noir", 20000, 150),
        new Car(14, "Renault", "Megane", "Blanc", 15000, 120),
        new Car(15, "Renault", "Captur", "Rouge", 25000, 180),
        new Car(16, "Renault", "Scenic", "Bleu", 30000, 200),
        new Car(17, "Peugeot", "208", "Noir", 20000, 150),
        new Car(18, "Peugeot", "308", "Blanc", 15000, 120),
        new Car(19, "Peugeot", "2008", "Rouge", 25000, 180),
        new Car(20, "Peugeot", "3008", "Bleu", 30000, 200)
    };
    
    public static List<Car> GetCars()
    {
        return Cars;
    }

    public static Car? GetById(int id)
    {
        return Cars.FirstOrDefault(c => c?.Id == id, null);
    }

    public static void AddCar(Car car)
    {
        car.Id = Cars.Last().Id + 1;
        Cars.Add(car);
    }

    public static void RemoveCar(int id)
    {
        Car? carToDelete = GetById(id);
        if (carToDelete is not null)
        {
            Cars.Remove(carToDelete);
        }
    }
    
    public static void UpdateCar(Car car)
    {
        Car? carToUpdate = GetById(car.Id);
        if (carToUpdate is not null)
        {
            carToUpdate.Marque = car.Marque;
            carToUpdate.Modele = car.Modele;
            carToUpdate.Couleur = car.Couleur;
            carToUpdate.Prix = car.Prix;
            carToUpdate.Puissance = car.Puissance;
        }
    }
}