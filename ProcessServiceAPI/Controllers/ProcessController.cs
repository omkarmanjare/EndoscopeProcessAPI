using Microsoft.AspNetCore.Mvc;
using Process.Services;
using ProcessServiceAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProcessServiceAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ProcessController : Controller
    {
        private IProcessService _processService;

        public ProcessController(IProcessService processService)
        {
            _processService = processService;
        }

        [HttpGet("GetAllProcesses")]
        public Task<IActionResult<IEnumerable<Process>> GetAllProcess()
        {
           var processes = _processService.GetProcesses(); 
            return Ok(processes);
        }

        [HttpGet("GetProcess")]
        public Task<IActionResult<IEnumerable<Process>> GetProcess(int processId)
            {
               var process = _processService.GetProcesses(); 
                return Ok(process);
         }

        [HttpGet("sEARCHProcess")]
        public Task<IActionResult<IEnumerable<Process>> SearchProcess(string key)
        {
            var process = _processService.SearchProcesses();
            return Ok(process);
        }
    
}
