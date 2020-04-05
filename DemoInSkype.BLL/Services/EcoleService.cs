using DemoInSkype.DAL.Data;
using DemoInSkype.DAL.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DemoInSkype.BLL.Services
{
    public class EcoleService : IEcoleService
    {
        private readonly DemoInSkypeDbContext _demoInSkypeDbContext;
        public EcoleService(DemoInSkypeDbContext demoInSkypeDbContext)
        {
            _demoInSkypeDbContext = demoInSkypeDbContext;
        }
        public void DeleteEcole(int Id)
        {
            try
            {
                var ecole = _demoInSkypeDbContext.ecoles.Find(Id);
                _demoInSkypeDbContext.ecoles.Remove(ecole);
                _demoInSkypeDbContext.SaveChanges();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
        //Method for Get All Ecoles
        public IEnumerable<Ecole> GetAllEcoles()
        {
            try
            {
                return _demoInSkypeDbContext.ecoles.ToList();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public Ecole GetEcoleById(int Id)
        {
            try
            {
                return _demoInSkypeDbContext.ecoles.Find(Id);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public void Register(Ecole ecole)
        {
            try
            {
                _demoInSkypeDbContext.ecoles.Add(ecole);
                _demoInSkypeDbContext.SaveChanges();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public void Update(Ecole ecole)
        {
            try
            {
                _demoInSkypeDbContext.Entry(ecole).State = EntityState.Modified;
                _demoInSkypeDbContext.SaveChanges();

            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
    }
}
