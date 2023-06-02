using System.ComponentModel;

namespace TestConsoleApp1
{
    public class BaseDto
    {
        
        [DisplayName("Артикул")]
        
        public string ProductCode { get; set; }
    }
}