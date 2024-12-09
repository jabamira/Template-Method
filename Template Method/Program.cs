
namespace Template_Method
{
    class Program
    {

        static void Main()
        {
            Console.WriteLine("Генерация отчета по студентам:");
            ReportGenerator REPORTER = new StudentReportGenerator();
            REPORTER.GenerateReport();

            Console.WriteLine("\nГенерация отчета по курсам:");
            REPORTER = new CourseReportGenerator();
            REPORTER.GenerateReport();
        }
    }
}