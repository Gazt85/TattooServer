
using System.Collections.Generic;

namespace Entities.RequestFeatures
{
     public abstract class RequestParameters
    {
        const int maxPageSize = 50;
        public int PageNumber { get; set; } = 1;

        private int _pageSize = 10;

        public int PageSize
        {
            get
            {
                return _pageSize;
            }
            set
            {
                _pageSize = (value > maxPageSize) ? maxPageSize : value;
            }

        }

        public string OrderBy { get; set; }
        public string Fields { get; set; }
    }

    public class UserParameters : RequestParameters
    {
        public UserParameters()
        {
            OrderBy = "FirstName";
        }
    }

    public class ProductParameters : RequestParameters
    {
        public ProductParameters()
        {
            OrderBy = "name";
        }

        public uint MinPrice { get; set; }
        public uint MaxPrice { get; set; } = int.MaxValue;
        public List<string> Category { get; set; } = new List<string>();

        public bool ValidPriceRange => MaxPrice > MinPrice;

        public string SearchTerm { get; set; }
    }

    public class AppointmentParameters : RequestParameters
    {
        public AppointmentParameters()
        {
            OrderBy = "StartDateTime";
        }
    }

    public class VideoParameters : RequestParameters
    {
        public VideoParameters()
        {
            OrderBy = "Date";
        }
    }
}
