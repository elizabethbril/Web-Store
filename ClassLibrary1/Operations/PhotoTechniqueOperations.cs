using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Database;
using AutoMapper;

namespace Logic
{
    public class PhotoTechniqueOperations
    {
        private readonly IUnitOfWork _uow;
        public PhotoTechniqueOperations()
        {
            _uow = new UnitOfWork();
        }

        public List<PhotoTechique> GetPhotoTechique()
        {

            return Mapper.Map<IEnumerable<Database.PhotoTechique>, List<PhotoTechique>>(_uow.PhotoTechiques.Get());

        }
        public PhotoTechique GetPhotoTechiqueById(int id)
        {

            return Mapper.Map<Database.PhotoTechique, PhotoTechique>(_uow.PhotoTechiques.GetOne(x => (x.Id == id)));

        }
        public void AddPhotoTechique(PhotoTechique PhotoTechique)
        {

            _uow.PhotoTechiques.Create(new Database.PhotoTechique { Name = PhotoTechique.Name, Description = PhotoTechique.Description, Price = PhotoTechique.Price, imageLink = PhotoTechique.ImageLink, Views = PhotoTechique.Purchases });
          
        }

        public void DeletePhotoTechique(int id)
        {
            _uow.PhotoTechiques.Remove(_uow.PhotoTechiques.FindById(id));
       
        }
    }
}
