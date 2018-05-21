using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Database;
using AutoMapper;

namespace ClassLibrary1
{
    public class PhotoTechniqueOperations
    {
        private readonly UnitOfWork _uow;
        public PhotoTechniqueOperations(UnitOfWork uow)
        {
            this._uow = uow;
        }

        public List<Logic.PhotoTechique> GetPhotoTechique()
        {

            return Mapper.Map<IEnumerable<PhotoTechique>, List<Logic.PhotoTechique>>(_uow.PhotoTechiques.Get());

        }
        public Logic.PhotoTechique GetPhotoTechiqueById(int id)
        {

            return Mapper.Map<PhotoTechique, Logic.PhotoTechique>(_uow.PhotoTechiques.GetOne(x => (x.Id == id)));

        }
        public void AddPhotoTechique(Logic.PhotoTechique PhotoTechique)
        {

            _uow.PhotoTechiques.Create(new PhotoTechique { Name = PhotoTechique.Name, Description = PhotoTechique.Description, Price = PhotoTechique.Price });
            _uow.Save();
        }

        public void DeletePhotoTechique(int id)
        {
            _uow.PhotoTechiques.Remove(_uow.PhotoTechiques.FindById(id));
            _uow.Save();
        }
    }
}
