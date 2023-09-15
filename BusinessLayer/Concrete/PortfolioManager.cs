using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class PortfolioManager : IPortfolioService
    {
        IPortfolioDal _portfolioDal;

        public PortfolioManager(IPortfolioDal portfolioDal)
        {
            _portfolioDal = portfolioDal;
        }

        public void TAdd(Portfolio t)
        {
            //throw new NotImplementedException();
            _portfolioDal.Insert(t);
        }

        public void TDelete(Portfolio t)
        {
            //throw new NotImplementedException();
            _portfolioDal.Delete(t);
        }

        public Portfolio TGetByID(int id)
        {
            //throw new NotImplementedException();
            return _portfolioDal.GetByID(id);
        }

        public List<Portfolio> TGetList()
        {
            return _portfolioDal.GetList();
        }

        public void TUpdate(Portfolio t)
        {
            //throw new NotImplementedException();
            _portfolioDal.Update(t);
        }

    }
}
