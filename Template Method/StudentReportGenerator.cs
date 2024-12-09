using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Template_Method
{

    class StudentReportGenerator : ReportGenerator
    {
        protected override void CollectData()
        {
            Console.WriteLine("Сбор данных о студентах 2207g2...");
        }

        protected override void ProcessData()
        {
            Console.WriteLine("Обработка данных по студентам 2207g2...");
        }

        protected override void FormatReport()
        {
            Console.WriteLine("Форматирование отчета по студентам 2207g2...");
        }

        protected override void ExportReport()
        {
            Console.WriteLine("Экспорт отчета по студентам 2207g2 в файл excel...");
        }
    }
}
