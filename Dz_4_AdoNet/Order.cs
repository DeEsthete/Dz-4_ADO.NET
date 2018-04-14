namespace Dz_4_AdoNet
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Order
    {
        public int Id { get; set; }

        public int Buyers_id { get; set; }

        public int Sellers_id { get; set; }

        public int Cost { get; set; }

        public DateTime Order_date { get; set; }

        public virtual Buyer Buyer { get; set; }

        public virtual Seller Seller { get; set; }
    }
}
