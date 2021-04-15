using Dapr.Client;
using MicDapr.ProductApi.Model;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MicDapr.ProductApi.Controllers
{
  [Route("api/[controller]")]
  [ApiController]
  public class MyProductController : ControllerBase
  {
    private DaprClient _client;
    public MyProductController(DaprClient client)
    {
      _client = client;
    }
    /// <summary>
    /// 获取商品
    /// </summary>
    /// <returns></returns>
    [HttpPost]
    [Route("getproducts")]
    public List<ProductDTO> GetProducts()
    {
      return new List<ProductDTO> { new ProductDTO { ProductId = Guid.NewGuid(), ProductName = "测试商品" } };
    }
    /// <summary>
    /// 健康检查
    /// </summary>
    /// <returns></returns>
    [HttpGet]
    [Route("checkheath")]
    public string CheckHeath()
    {
      return "Ok"; 
    }
    /// <summary>
    /// 测试
    /// </summary>
    /// <returns></returns>
    [HttpGet]
    [Route("test")]
    public string Test()
    {
      return "Ok";
    }
    private string TestCommit()
    {
      return "ceshi";
    }
  }
}
