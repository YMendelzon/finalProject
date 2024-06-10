using DAL.Models;
using SERVER.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Text;
using System.Threading.Tasks;


namespace DAL.DalApi;

public interface IMotherDal
{
    public List<Mother> GetMotherList();
}
