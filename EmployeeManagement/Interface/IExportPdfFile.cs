﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeManagement.Interface
{
    public interface IExportPdfFile
    {
        void ExportPdfReport();

        void Test() { 
            Console.WriteLine("Test default implementation of interface");
        }
    }
}
