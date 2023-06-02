using System.Collections;
using System.Linq.Expressions;
using TestConsoleApp1.TestDTO;
using System.Numerics;

namespace TestConsoleApp1.Controller;

public class TechInfosController 
{
    private readonly IQueryable<ApplicabilityDTO> _applicabilityDtos;
    public  TechInfosController ()
    {
        _applicabilityDtos = DatabaseGenerator.GetDatabase();
    }

    // public async Task<IEnumerable<ApplicabilityDTO>> Get(string code)
    // {
    //     var query = _applicabilityDtos.Where(x => x.ProductCode == code);
    //     // Console.WriteLine(query.ToArray());
    //     // Console.ReadKey();
    //     return query.ToArray();
    // }

    
    public IQueryable<ApplicabilityDTO> Get(string[]? codes = null) 
    {
        // Заготовка под фильтр
        Expression<Func<ApplicabilityDTO, bool>> filter = null;
        // Если определен массив артикулов, то нужно инициализировать такой фильтр, чтобы код товара попадал в массив
        if (codes is {Length: > 0})
            filter = x => codes.Contains(x.ProductCode);
    
        // Делаем заготовку запроса (это еще не сам запрос)
        var query = _applicabilityDtos.AsQueryable();
            // .Set<ApplicabilityDTO>().AsQueryable();
    
        // Если фильтр был ранее определен, то применяем его к заготовке
        if (filter != null)
            query = query.Where(filter);
    
        return query;
        
    }
}




