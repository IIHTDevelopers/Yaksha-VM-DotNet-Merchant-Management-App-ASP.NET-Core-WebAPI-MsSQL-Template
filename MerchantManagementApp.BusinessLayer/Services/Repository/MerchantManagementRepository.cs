using Microsoft.EntityFrameworkCore;
using MerchantManagementApp.BusinessLayer.ViewModels;
using MerchantManagementApp.DataLayer;
using MerchantManagementApp.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace MerchantManagementApp.BusinessLayer.Services.Repository
{
    public class MerchantManagementRepository : IMerchantManagementRepository
    {
        private readonly MerchantManagementAppDbContext _dbContext;
        public MerchantManagementRepository(MerchantManagementAppDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<Merchant> CreateMerchant(Merchant MerchantModel)
        {
            //write your code here
            throw new NotImplementedException();
        }

        public async Task<bool> DeleteMerchantById(long id)
        {
            //write your code here
            throw new NotImplementedException();
        }

        public List<Merchant> GetAllMerchants()
        {
            //write your code here
            throw new NotImplementedException();
        }

        public async Task<Merchant> GetMerchantById(long id)
        {
            //write your code here
            throw new NotImplementedException();
        }

       
        public async Task<Merchant> UpdateMerchant(MerchantViewModel model)
        {
            //write your code here
            throw new NotImplementedException();
        }
    }
}