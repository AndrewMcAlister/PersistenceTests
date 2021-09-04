﻿using System;
using dfi = McAlister.Study.PersistenceTests.Definitions.Interfaces;

namespace McAlister.Study.PersistenceTests.Definitions.Models
{
    public class Order: dfi.IBusinessModel
    {
        public Order()
        {
            //InverseBackorderOrder = new HashSet<OrderModels>();
            //Invoices = new HashSet<InvoiceModels>();
            //OrderLines = new HashSet<OrderLineModels>();
        }

        public int OrderId { get; set; }
        public int CustomerId { get; set; }
        public int SalespersonPersonId { get; set; }
        public int? PickedByPersonId { get; set; }
        public int ContactPersonId { get; set; }
        public int? BackorderOrderId { get; set; }
        public DateTime OrderDate { get; set; }
        public DateTime ExpectedDeliveryDate { get; set; }
        public string CustomerPurchaseOrderNumber { get; set; }
        public bool IsUndersupplyBackordered { get; set; }
        public string Comments { get; set; }
        public string DeliveryInstructions { get; set; }
        public string InternalComments { get; set; }
        public DateTime? PickingCompletedWhen { get; set; }
        public int LastEditedBy { get; set; }
        public DateTime LastEditedWhen { get; set; }

        //public virtual Orders BackorderOrder { get; set; }
        //public virtual People ContactPerson { get; set; }
        //public virtual Customers Customer { get; set; }
        //public virtual People LastEditedByNavigation { get; set; }
        //public virtual People PickedByPerson { get; set; }
        //public virtual People SalespersonPerson { get; set; }
        //public virtual ICollection<Orders> InverseBackorderOrder { get; set; }
        //public virtual ICollection<Invoices> Invoices { get; set; }
        //public virtual ICollection<OrderLines> OrderLines { get; set; }
    }

}