using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MicDapr.ProductApi.Model
{
  public class ProductDTO
  {
    public Guid ProductId { get; set; }
    public string ProductName { get; set; }
  }
}
