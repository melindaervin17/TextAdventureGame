using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

public class ItemsRepo
    {
    private readonly List<Items> _iRepo = new List<Items>();

    public bool AddItemToBackpack(Items item)
    {
        if(item != null)
        {
            _count++;
            item.ID = _count;
            _iRepo.Add(item);
            return true;
        }
        return false;
    }
        public List<Items> ViewAllItems()
        {
            return _iRepo;
        }

        public Items GetItemByID(int id)
        {
            foreach(Items i in _iRepo)
            {
                if(i.ID == id)
                {
                    return i;
                }

            }
            return null;
        }

    private int _count;
}
