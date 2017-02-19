// В этой программе создаются два объекта типа Building.

using System;

class Building
{
    public int Floors; // количество этажей
    public int Area; // общая площадь здания
    public int Occupants; // количество жильцов
}

// В этом классе объявляются два объекта типа Building.
class BuildingDemo
{
    static void Main()
    {
        Building house = new Building();
        Building office = new Building();

        int areaPP; // площадь на одного человека

        // Присвоить значения полям в объекте house.
        house.Occupants = 4;
        house.Area = 2500;
        house.Floors = 2;

        // Присвоить значения полям в объекте office.
        office.Occupants = 25;
        office.Area = 4200;
        office.Floors = 3;

        // Вычислить площадь на одного человека в жилом доме.
        areaPP = house.Area / house.Occupants;

        Console.WriteLine("Дом имеет\n " +
            house.Floors + " этажа\n " +
            house.Occupants + " жильца\n " +
            house.Area + " кв.футов общей площади, из них\n " +
            areaPP + " приходится на одного человека");
        // Вычислить площадь на одного человека в учереждении.
        areaPP = office.Area / office.Occupants;
        Console.WriteLine("Учереждение имеет\n " +
            office.Floors + " этажа\n " +
            office.Occupants + " работников\n " +
            office.Area + " кв.футов общей площади, из них\n " +
            areaPP + " приходится на одного человека");
        Console.ReadKey();
    }
}
