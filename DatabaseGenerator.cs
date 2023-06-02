using TestConsoleApp1.TestDTO;

namespace TestConsoleApp1;

public static class DatabaseGenerator
{
    public static IQueryable<ApplicabilityDTO> GetDatabase()
    {
        return new List<ApplicabilityDTO>
            {
                     new ApplicabilityDTO
                     {
                         ProductCode = "av105",
                         BrandName = "AIKO",
                         Name = "Фильтр масляный двигателя",
                         CarMark = "ACURA",
                         CarModification = "ModificationT1000",
                         Engine = "LADA",
                         Hp = 100,
                         Kw = "5000",
                     },
                     new ApplicabilityDTO                       
                     {     
                         ProductCode = "av105",
                         BrandName = "FEBI",                    
                         Name = "Фильтр масляный двигателя",    
                         CarMark = "ACURA",                     
                         CarModification = "ModificationT4000", 
                         Engine = "V8",                       
                         Hp = 600,                            
                         Kw = "700",                           
                     },      
                     new ApplicabilityDTO                       
                     {       
                         ProductCode = "Bv105",
                         BrandName = "DODA",                    
                         Name = "Фильтр масляный двигателя",    
                         CarMark = "ACURA",                     
                         CarModification = "4000", 
                         Engine = "V800",                         
                         Hp = 800,                            
                         Kw = "700",                            
                     },          
                     new ApplicabilityDTO                       
                     {        
                         ProductCode = "Dv105",
                         BrandName = "JAC",                    
                         Name = "Фильтр масляный двигателя",    
                         CarMark = "ACURA",                     
                         CarModification = "B450", 
                         Engine = "V2",                         
                         Hp = 1280,                            
                         Kw = "70540",                            
                     },
            }.AsQueryable();
    }
}