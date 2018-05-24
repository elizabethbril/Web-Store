using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Database;
using System.Text.RegularExpressions;

namespace Logic
{
    public class ShopLogic
    {
        static ShopLogic(){
            AutoMapper.Initialize();
            }
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
            
           users.AddRange(operationsContainer.ManagerOperations.GetManager());
            users.AddRange(operationsContainer.AdminOperations.GetAdmin());
            foreach(User user in operationsContainer.UserOperations.GetUser())
            {
                if (!users.Contains(user))
                {
                    users.Add(user);
                }
            }
            orders.AddRange(operationsContainer.OrderOperations.GetOrder());
        }
        public void Registration(string login, string password, string shortName, string phone) 
        {
            User user = new User(login, password, shortName, phone);
            users.Add(user);
            operationsContainer.UserOperations.AddUser(user);
        }

        public void ChangeItem(Item item)
        {
            for (int i = 0; i < items.Count; i++)
            {
                if (items[i].getId() == item.getId())
                    items[i] = new Item(item);
            }
        }
        public Item findItem(int id)
        {
            return items.First(i => i.getId() == id);
        }
        public void doOrder(Item item, User user) {
            Order order = new Order(0, item, user);
            orders.Add(order);
            operationsContainer.OrderOperations.AddOrder(order);

        }
        public User FindUserById(int id)
        {
            return users.First(u => u.id == id);
        }
        public User FindUser(string email,string password)
        {
            return users.First(u => u.getLogin() == email && u.getPassword() == password);
        }
        public List<Item> findItems(string text)
        {
            string pattern = $@"{text}";
            return items.Where(i => Regex.IsMatch(i.Name, text, RegexOptions.IgnoreCase)).ToList();

        }
        public void newManager(int id)
        {
            operationsContainer.UserOperations.DeleteUser(id);
            Manager manager = new Manager(FindUserById(id));
            operationsContainer.ManagerOperations.AddManager(manager);
            for (int i = 0; i < users.Count; i++)
            {
                if (users[i].id == id)
                    users[i] = manager;
            }
        }
    }
}
