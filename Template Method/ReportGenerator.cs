using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Template_Method
{
    abstract class ReportGenerator
    {
        public void GenerateReport()
        {
            CollectData();
            ProcessData();
            FormatReport();
            ExportReport();
        }

        protected abstract void CollectData();
        protected abstract void ProcessData();
        protected abstract void FormatReport();
        protected virtual void ExportReport()
        {
            Console.WriteLine("Экспорт отчета в файл...");
        }
    }


}
