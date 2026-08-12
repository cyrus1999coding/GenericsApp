using System;
using System.Collections.Generic;
using System.Text;

namespace GenericsApp
{
    internal class ReportTask : ITask<string>
    {
        public string ReportName { get; set; }

        public string Perform()
        {
            return $"Report {ReportName} generated succesfully";
        }

    }
}
