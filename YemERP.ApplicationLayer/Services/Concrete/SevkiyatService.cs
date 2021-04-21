using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using YemERP.ApplicationLayer.Services.Interfaces;
using YemERP.DomainLayer.Entities.Concrete;
using YemERP.DomainLayer.UnitOfWork.Interfaces;

namespace YemERP.ApplicationLayer.Services.Concrete
{
    public class SevkiyatService:ISevkiyatService
    {

        private readonly IUnıtOfWork _unitOfWork;
        public SevkiyatService( IUnıtOfWork unıtOfWork)
        {
            this._unitOfWork = unıtOfWork;
        }

        public List<NetsisIsemriTbl> GetAllSevkiyat()
        {
            throw new NotImplementedException();
        }




        //Task<List<NetsisIsemriTbl>> ISevkiyatService.GetAllSevkiyat()
        //{
        //    throw new NotImplementedException();
    }
    
}
