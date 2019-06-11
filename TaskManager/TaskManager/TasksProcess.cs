using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace TaskManager
{
    public class TasksProcess
    { 
        public string ProcessName { get; set; }
        public List<Process> GetProcessesByName()
        {
            return Process.GetProcesses().ToList();
        }
    }
}
