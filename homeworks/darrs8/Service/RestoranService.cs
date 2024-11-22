using darrs8.Model;
       
namespace darrs8.Service;

public class RestoranService
{
    private List<Restoran> restorans;
    public RestoranService()
    {
        restorans = new List<Restoran>();
    }
    public Restoran AddRestoran(Restoran restoran)
    {
        restoran.Id = Guid.NewGuid();
        restorans.Add(restoran);
            
        return restoran;
    }
    public bool DeleteRestaurant(Guid restauranId)
    {
        var exist = false;
        foreach (var restoran in restorans)
        {
            if (restoran.Id == restauranId)
            {
                exist = true;
                break;
            }
        }
        return exist;
    }
    public bool UpdateRestoran(Restoran updatedRestoran)
    {
        for (var i = 0; i < restorans.Count; ++i)
        {
            if (restorans[i].Id == updatedRestoran.Id)
            {
                restorans[i] = updatedRestoran;
                return true;
            }
        }
        return false;
    }
    public List<Restoran> GetAllRestoran()
    {
        return restorans;
    }
    public Restoran GetById (Guid restoranId)
    {
        foreach (var restoran in restorans)
        {
            if (restoran.Id == restoranId)
            {
                return restoran;
            }
        }
        return null;
    }
}

