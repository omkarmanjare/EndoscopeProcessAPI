using Processes.Data;
using System;
using System.Collections.Generic;

namespace Process.Services
{
    public class ProcessService : IProcessService
    {
        private IProcessService _processService

        public ProcessService(IProcessService processService)
        {
            _processService = processService;
        }

        public Models.Process GetAllProcess()
        {
           return  new ProcessRepository().GetAllProcess();
        }

        public IEnumerable<Models.Process> GetProcesses(int processId)
        {
            return new ProcessRepository().GetProcess (processId);
        }

        public IEnumerable<Models.Process> SearchProcess(string key, string values)
        {
            return new ProcessRepository().SearchProcess(key);
        }
    }
}
