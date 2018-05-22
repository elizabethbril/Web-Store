using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Database;

namespace Logic
{
    public class ShopLogic
    {
        private OperationsContainer operationsContainer;
        public List<Item> items = new List<Item>();
        public List<User> users = new List<User>();
        public List<Order> orders = new List<Order>();
        
        
        public ShopLogic()
        {
            operationsContainer = new OperationsContainer();
            items.AddRange(operationsContainer.LaptopOperations.GetLaptop());
            items.AddRange(operationsContainer.AccessoriesOperations.GetAccessories());
            items.AddRange(operationsContainer.PhotoTechiqueOperations.GetPhotoTechique());
            items.AddRange(operationsContainer.SmartPhoneOperations.GetSmartPhone());
            items.AddRange(operationsContainer.TabletOperations.GetTablet());
            users.AddRange(operationsContainer.UserOperations.GetUser());
            users.AddRange(operationsContainer.ManagerOperations.GetManager());
            users.AddRange(operationsContainer.AdminOperations.GetAdmin());
            orders.AddRange(operationsContainer.OrderOperations.GetOrder());
        }
        public void Registration(string login, string password, string shortName, string phone) 
        {
            users.Add(new User(login,password,shortName, phone));
        }

        public void ChangeItem(Item item)
        {
            for (int i = 0; i < items.Count; i++)
            {
                if (items[i].getId() == item.getId())
                    items[i] = new Item(item);
            }
        }

        public void doOrder(Item item, User user, int id) {
            orders.Add(new Order(id, item, user));
        }

        public void newManager(User user)
        {
            for(int i=0; i<users.Count;i++)
            {
                if (users[i].Equals(user))
                    users[i] = new Manager(user);
            }
        }
    }
}
