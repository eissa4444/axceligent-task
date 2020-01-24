namespace _06_ConstructionGame
{
    public interface IBuilding
    {
        IBuilding AddKitchen();
        IBuilding AddBedroom(string roomName);
        IBuilding AddBalcony();
        IBuilding Build();
        string Describe();
    }
}