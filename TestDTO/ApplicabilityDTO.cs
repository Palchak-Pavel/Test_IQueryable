using System.ComponentModel;
using TestConsoleApp1;

namespace TestConsoleApp1.TestDTO
{
    public class ApplicabilityDTO : BaseDto
    {

        [DisplayName("Бренд")]
        public string BrandName { get; set; }

        [DisplayName("Наименование")]
        public string Name { get; set; }

        [DisplayName("Марка")]
        public string CarMark { get; set; }

        [DisplayName("Модель")]
        public string CarModel { get; set; }

        [DisplayName("Модификация")]
        public string CarModification { get; set; }

        [DisplayName("Двигатель")]
        public string Engine { get; set; }

        [DisplayName("Мощность, л.с.")]
        public int Hp { get; set; }

        [DisplayName("Мощность, кВт")]
        public string Kw { get; set; }

        [DisplayName("Начало производства")]
        public string StartDate { get; set; }

        [DisplayName("Окончаение производства")]
        public string EndDate { get; set; }
    }
    
}