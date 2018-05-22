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
        private readonly IUnitOfWork UoW;
        public LaptopOperations LaptopOperations { get; }
        public AccessoriesOperations AccessoriesOperations { get; }
        public PhotoTechniqueOperations PhotoTechiqueOperations { get; }
        public SmartPhoneOperations SmartPhoneOperations { get;}
        public TabletOperations TabletOperations { get; }
        public UserOperations UserOperations { get; }
        public ManagerOperations ManagerOperations { get; }
        public AdminOperations AdminOperations { get; }
        public OrderOperations OrderOperations { get; }
        public OperationsContainer(IUnitOfWork _uow)
        {
            UoW = _uow;
            LaptopOperations = new LaptopOperations(UoW);
            AccessoriesOperations = new AccessoriesOperations(UoW);
            PhotoTechiqueOperations = new PhotoTechniqueOperations(UoW);
            SmartPhoneOperations = new SmartPhoneOperations(UoW);
            TabletOperations = new TabletOperations(UoW);
            UserOperations = new UserOperations(UoW);
            ManagerOperations = new ManagerOperations(UoW);
            AdminOperations = new AdminOperations(UoW);
            OrderOperations = new OrderOperations(UoW);
        }
    }
}
