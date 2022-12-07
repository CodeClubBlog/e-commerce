using Project.Domain.Common;
using Project.Domain.Entities.Categories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Domain.Entities.Products
{
    public class Product : Auditable
    {
        public string Brand { get; set; } = String.Empty;
        public string Model { get; set; } = String.Empty;
        public string Price { get; set; } = String.Empty;
        public string CPU { get; set; } = String.Empty;
        public string GPU { get; set; } = String.Empty;
        public float ScreenDioganal { get; set; }
        public float ScreenResolution { get; set; }
        public string MatrixType { get; set; } = String.Empty;
        public string RAM { get; set; } = String.Empty;
        public string Storage { get; set; } = String.Empty;
        public string WirelessConnection { get; set; } = String.Empty;
        public string Guarantee { get; set; } = String.Empty;
        public string Keyboard { get; set; } = String.Empty;
        public string Frame { get; set; } = String.Empty;
        public string Color { get; set; } = String.Empty;
        public string Webcam { get; set; } = String.Empty;
        public string Audio { get; set; } = String.Empty;
        public string Ports { get; set; } = String.Empty;
        public long? CategoryId { get; set; }
        public Category? Category { get; set; }
    }
}
