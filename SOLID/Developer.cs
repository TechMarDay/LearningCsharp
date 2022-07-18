using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID
{
    internal class Developer : Employee, IExportPdfFile, IExportExcelReport
    {
        public void ExportExcelReport()
        {
            throw new NotImplementedException();
        }

        public void ExportPdfReport()
        {
            throw new NotImplementedException();
        }
    }
}
