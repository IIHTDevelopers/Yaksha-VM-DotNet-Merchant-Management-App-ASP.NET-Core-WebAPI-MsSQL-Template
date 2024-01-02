using MerchantManagementApp.BusinessLayer.Interfaces;
using MerchantManagementApp.BusinessLayer.Services.Repository;
using MerchantManagementApp.BusinessLayer.ViewModels;
using MerchantManagementApp.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace MerchantManagementApp.BusinessLayer.Services
{
    public class MerchantManagementService : IMerchantManagementService
    {
        private readonly IMerchantManagementRepository _repo;

        public MerchantManagementService(IMerchantManagementRepository repo)
        {
            _repo = repo;
        }

        public async Task<Merchant> CreateMerchant(Merchant employeeMerchant)
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
