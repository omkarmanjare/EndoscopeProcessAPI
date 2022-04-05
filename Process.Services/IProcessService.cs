using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Process.Services
{
    public interface IProcessService
    {
        public IEnumerable<Process.Services.Models.Process> GetProcesses();
        public Process.Services.Models.Process GetProcess(int processId);
        public IEnumerable<Process.Services.Models.Process> SearchProcess(string key,string values) 
    }
}
