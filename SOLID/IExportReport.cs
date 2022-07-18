using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID
{
    //internal interface IExportReport
    //{
    //    void ExportExcelReport();
    //    void ExportPdfReport();

    //}

    public interface IExportPdfFile
    {
        void ExportPdfReport();
    }
    public interface IExportExcelReport
    {
        void ExportExcelReport();
    }
}
