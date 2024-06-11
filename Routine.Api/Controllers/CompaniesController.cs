using Microsoft.AspNetCore.Mvc;
using Routine.Api.Models;
using Routine.Api.Services;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Routine.Api.Controllers
{
    [ApiController]
    [Route("api/companies")]
    public class CompaniesController : ControllerBase
    {
        private readonly ICompanyRepository _companyRepository;
        public CompaniesController(ICompanyRepository companyRepository)
        {
            _companyRepository = companyRepository;
        }

        [HttpGet]
        public async Task<IActionResult> GetCompanies()
        {
            var companies = await _companyRepository.GetCompaniesAsync();
            var companyDtos = new List<CompanyDto>();
            foreach (var company in companies)
            {
                companyDtos.Add(new CompanyDto()
                {
                    Name = company.Name,
                    Id = company.Id
                });
            }
            return Ok(companyDtos);
        }

        [HttpGet("{companyId}")] // api/companies/{companyId}
        public async Task<IActionResult> GetCompany(Guid companyId)
        {

            var company = await _companyRepository.GetCompaniesAsync();
            if (company == null)
            {
                return NotFound();
            }
            return Ok(company);
        }

    }
}
