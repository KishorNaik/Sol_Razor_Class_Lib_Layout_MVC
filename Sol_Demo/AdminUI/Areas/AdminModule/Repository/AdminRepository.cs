using AdminUI.Areas.AdminModule.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace AdminUI.Areas.AdminModule.Repository
{
    public interface IAdminRepository
    {
        bool AddUser(AdminModel adminModel);
    }

    public class AdminRepository : IAdminRepository
    {
        bool IAdminRepository.AddUser(AdminModel adminModel)
        {
            Debug.WriteLine(adminModel.FullName);
            return true;
        }
    }
}
