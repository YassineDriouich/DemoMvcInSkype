using DemoInSkype.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace DemoInSkype.BLL.Services
{
    public interface IEcoleService
    {
        IEnumerable<Ecole> GetAllEcoles();
        void Register(Ecole ecole);
        void Update(Ecole ecole);
        Ecole GetEcoleById(int Id);
        void DeleteEcole(int Id);

    }
}
