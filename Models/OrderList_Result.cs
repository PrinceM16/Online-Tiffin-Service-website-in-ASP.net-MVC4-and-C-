//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Project.Models
{
    using System;
    
    public partial class OrderList_Result
    {
        public int OrderId { get; set; }
        public int CustomerId { get; set; }
        public int MenuId { get; set; }
        public System.DateTime Date { get; set; }
        public string Description { get; set; }
        public System.DateTime EndDate { get; set; }
        public Nullable<int> Quantity { get; set; }
        public System.DateTime StartDate { get; set; }
        public string Status { get; set; }
        public Nullable<decimal> Tax { get; set; }
        public Nullable<decimal> Total { get; set; }
        public Nullable<decimal> GrandTotal { get; set; }
        public string DeliveryAddr { get; set; }
        public decimal Price { get; set; }
        public string Name { get; set; }
        public string Image { get; set; }
        public string FirstName { get; set; }
        public string PhoneNo { get; set; }
    }
}
