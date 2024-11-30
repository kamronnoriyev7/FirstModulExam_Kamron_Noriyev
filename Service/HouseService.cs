using FirstModulExam_Kamron_Noriyev.Modul;

namespace FirstModulExam_Kamron_Noriyev.Service;

public class HouseService
{
   
    List<House> houseList;
    public HouseService()
    {
        
        houseList = new List<House>();
    }
    

    public House AddHouse(House house)
    {
        house.Id = Guid.NewGuid();
        houseList.Add(house);
        return house;
    }

    public House GetById(Guid id)
    {
        foreach (var element in houseList)
        {
            if (element.Id == id)
            {
                return element;
            }
        }
        return null;
    }

    public bool Delete(Guid id)
    {
        var house = GetById(id);
        var element =houseList.Remove(house);
        if (element != null)
        {
            return true;
        }
        return false;
    }

    public House Update(Guid id, House newHouse)
    {
        foreach (var element in houseList)
        {
            if (element.Id == id)
            {
                newHouse.Id = element.Id;
                return newHouse;
            }
        }
        return null;
    }
    public List<House> GetHouseList()
    {
        return houseList;
    }
}