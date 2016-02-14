namespace App.Data.Models
{
    using System;
    using App.Data.Common.Models;

    public class Promotion : BaseModel<int>
    {
        public string Name { get; set; }

        public DateTime? StartDate { get; set; }

        public DateTime? EndDate { get; set; }
    }
}
