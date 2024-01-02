using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MerchantManagementApp.BusinessLayer.Interfaces;
using MerchantManagementApp.BusinessLayer.ViewModels;
using MerchantManagementApp.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;
using ManagementApp.Entities;

namespace MerchantManagementApp.Controllers
{
    [ApiController]
    public class MerchantManagementController : ControllerBase
    {
        private readonly IMerchantManagementService  _merchantService;
        public MerchantManagementController(IMerchantManagementService merchantservice)
        {
             _merchantService = merchantservice;
        }

        [HttpPost]
        [Route("create-merchant")]
        [AllowAnonymous]
        public async Task<IActionResult> CreateMerchant([FromBody] Merchant model)
        {
            //write your code here
            throw new NotImplementedException();
        }


        [HttpPut]
        [Route("update-merchant")]
        public async Task<IActionResult> UpdateMerchant([FromBody] MerchantViewModel model)
        {
            //write your code here
            throw new NotImplementedException();
        }

      
        [HttpDelete]
        [Route("delete-merchant")]
        public async Task<IActionResult> DeleteMerchant(long id)
        {
            //write your code here
            throw new NotImplementedException();
        }


        [HttpGet]
        [Route("get-merchant-by-id")]
        public async Task<IActionResult> GetMerchantById(long id)
        {
            //write your code here
            throw new NotImplementedException();
        }

        [HttpGet]
        [Route("get-all-merchants")]
        public async Task<IEnumerable<Merchant>> GetAllMerchants()
        {
            //write your code here
            throw new NotImplementedException();
        }
    }
}
