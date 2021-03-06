﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Horus.Functions.Models
{
    public class DocumentLineItem
    {
        public DocumentLineItem() { this.CalculatedLineQuantity = 0; }
        public string ItemDescription { get; set; }
        public string LineQuantity { get; set; }
        public decimal UnitPrice { get; set; }

        public string VATCode { get; set; }
        public string Taxableindicator { get; set; }
        public string DocumentLineNumber { get; set; }
        public decimal NetAmount { get; set; }
        public decimal CalculatedLineQuantity {
            get {
                // Calculate Line Quantities where possible

                if (NetAmount != 0 && UnitPrice != 0) return NetAmount / UnitPrice; else return 0;
                    }

              protected set { }
            }
        public decimal DiscountPercent { get; set; }
    }
}
