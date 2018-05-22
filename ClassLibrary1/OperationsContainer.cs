using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Database;

namespace Logic
{
    public class OperationsContainer
    {
        
        public LaptopOperations LaptopOperations { get; }
        public AccessoriesOperations AccessoriesOperations { get; }
        public PhotoTechniqueOperations PhotoTechiqueOperations { get; }
        public SmartPhoneOperations SmartPhoneOperations { get;}
        public TabletOperations TabletOperations { get; }
        public UserOperations UserOperations { get; }
        public ManagerOperations ManagerOperations { get; }
        public AdminOperations AdminOperations { get; }
        public OrderOperations OrderOperations { get; }
        public OperationsContainer()
        {
           
            LaptopOperations = new LaptopOperations();
            AccessoriesOperations = new AccessoriesOperations();
            PhotoTechiqueOperations = new PhotoTechniqueOperations();
            SmartPhoneOperations = new SmartPhoneOperations();
            TabletOperations = new TabletOperations();
            UserOperations = new UserOperations();
            ManagerOperations = new ManagerOperations();
            AdminOperations = new AdminOperations();
            OrderOperations = new OrderOperations();
        }
    }
}
