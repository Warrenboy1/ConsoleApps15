using System.ComponentModel.DataAnnotations;

namespace ConsoleAppProject.App01
{
    public enum UnitEnum
    {
        [Display(Name = "Meter")]METER,
        [Display(Name = "Feet")]FEET,
        [Display(Name = "Mile")]MILE
    }
}