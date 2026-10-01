using Microsoft.AspNetCore.Mvc;
using MvcBasicSample.Models;

namespace MvcBasicSample.Controllers;

//UrlのHelloに対応する要求を受け取るController
public class HelloController : Controller {

    // ../Hello/Indexで呼び出されるAction
    public IActionResult Index() {
        //商品１件のオブジェトを作る
        var products = new List<Product> {
            new Product {
                Name = "ノート",
                Price = 250
                
            },
            new Product {
                Name = "ペン",
                Price = 150
            }
            
        };
        return View(products);
    }
}
