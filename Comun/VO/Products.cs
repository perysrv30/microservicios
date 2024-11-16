using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace VO
{
    [DataContract] // PARA TRANSFERIR INFORMACION
    public class Products
    {
        [DataMember (EmitDefaultValue = false)] // VALOR POR DEFECTO EN LA RESUPESTA
        public int Id { get; set; }
        [DataMember(EmitDefaultValue = false)]
        public string Name { get; set; }
        [DataMember(EmitDefaultValue = false)]
        public string Description { get; set; }
        [DataMember(EmitDefaultValue = false)]
        public decimal MyProperty { get; set; }
        [DataMember(EmitDefaultValue = false)]
        public int CurrentStock { get; set; }
        [DataMember(EmitDefaultValue = false)]
        public int MaxStock { get; set; }
        [DataMember(EmitDefaultValue = false)]
        public eStockStatus StockStatusId { get; set; }
        [DataMember(EmitDefaultValue = false)]
        public string ImagePath { get; set; }
        [DataMember(EmitDefaultValue = false)]
        public DateTime CreatedAt { get; set; }
        [DataMember(EmitDefaultValue = false)]
        public DateTime UpdatedAt { get; set; }
    }
}
