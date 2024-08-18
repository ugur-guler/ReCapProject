using Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class Car:IEntity
    {
        public int _Id { get; set; }
        public int _BrandID { get; set; }
        public int _ColorId { get; set; }
        public long _DailyPrice { get; set; }
        public string _Description { get; set; }
        public Car(int Id, int BrandId , int ColorId , long DailyPrice , string Description)
        {
            _Id= Id;
            _BrandID = BrandId;
            _ColorId = ColorId;
            _DailyPrice = DailyPrice;
            _Description = Description;

        }

    }
}
