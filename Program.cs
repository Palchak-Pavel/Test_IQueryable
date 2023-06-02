// See https://aka.ms/new-console-template for more information

using System.Collections;
using System.Linq.Dynamic;
using TestConsoleApp1.Controller;
using TestConsoleApp1.TestDTO;

namespace TestConsoleApp1
{
    class Program
    {
        static void Main(string[] agrs)
        {
          
            // ApplicabilityDTO anotherApplicabilityDto = new ApplicabilityDTO();
            // anotherApplicabilityDto.Hp = 10;
            //
            // myApplicabilityDto.ShowI();
            // anotherApplicabilityDto.ShowI();
            
            //var applicabilityDtos = DatabaseGenerator.GetDatabase();

            // var query = from emp in applicabilityDtos
            //     where emp.Hp < 900
            //     orderby emp.Hp
            //     select new
            //     {
            //         BrandName = emp.BrandName,
            //         CarModification = emp.CarModification,
            //         Hp = emp.Hp
            //     };
            // foreach (var i in query)
            // {
            //     Console.WriteLine(i);
            // }

            var controller = new TechInfosController();

            var codes = new[] {"av105"};
            var result1 = controller.Get().ToArray();
            var result2 = controller.Get(codes: new []{"av105"}).ToArray();

        }
    }
}

