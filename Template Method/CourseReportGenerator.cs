using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Template_Method
{
    class CourseReportGenerator : ReportGenerator
    {
        protected override void CollectData()
        {
            Console.WriteLine("Сбор данных о курсах VKI...");
        }

        protected override void ProcessData()
        {
            Console.WriteLine("Обработка данных по курсам VKI...");
        }

        protected override void FormatReport()
        {
            Console.WriteLine("Форматирование отчета по курсам VKI...");
        }

        protected override void ExportReport()
        {
            Console.WriteLine("Экспорт отчета по курсам в файл excel...");
        }
    }
}
