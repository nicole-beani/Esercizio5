using Microsoft.AspNet.SignalR.Hubs;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Xml.Linq;

namespace Esercizio5
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        public static List<Product> productList = new List<Product>();
        protected void Page_Load(object sender, EventArgs e)
        {
            List<Product> productList = new List<Product>();
            Product product1 = new Product(1, "https://assets.mmsrg.com/isr/166325/c1/-/ASSET_MMS_118129025?x=320&y=320&format=jpg&quality=80&sp=yes&strip=yes&trim&ex=320&ey=320&align=center&resizesource&unsharp=1.5x1+0.7+0.02&cox=0&coy=0&cdx=320&cdy=320", "Iphone 14 Pro", 1300, "Costa tanto");
            Product product2 = new Product(2, "https://assets.mmsrg.com/isr/166325/c1/-/ASSET_MMS_92338008?x=320&y=320&format=jpg&quality=80&sp=yes&strip=yes&trim&ex=320&ey=320&align=center&resizesource&unsharp=1.5x1+0.7+0.02&cox=0&coy=0&cdx=320&cdy=320", "Iphone 11", 800, "Costa medio");
            Product product3 = new Product(3, "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcR8tlVIZX01amSgEfllZfddCfZeVqGnzPNSABl8HN0ByJFbnatc_4t2MhQrDKYwbV6hqnk&usqp=CAU", "Iphone XR", 700, "Costa medio");
            Product product4 = new Product(4, "https://store.storeimages.cdn-apple.com/4668/as-images.apple.com/is/refurb-iphone-13-pro-max-silver-2023?wid=1144&hei=1144&fmt=jpeg&qlt=90&.v=1679072987085", "Iphone 13 Pro", 1000, "Costa medio");
            Product product5 = new Product(5, "https://cdn11.bigcommerce.com/s-7a72dboqi9/products/1763/images/2279/s-l1600-6__58989.1578985127.500.750.jpg?c=2", "Nokia 3310", 10, "Il Top, il mattone");
            Product product6 = new Product(6, "https://assets.swappie.com/cdn-cgi/image/width=600,height=600,fit=contain,format=auto/swappie-iphone-x-space-gray.png?v=35", "Iphone X", 700, "Costa medio");
            Product product7 = new Product(7, "https://m.media-amazon.com/images/I/71iaSyGDNNL.jpg", "Samsung A52", 500, "Costa medio");
            Product product8 = new Product(8, "https://data.wikomobile.com/documents/images/IT/7f9dd80ab2398af05a265e0a8b48a2cc.jpg", "Wiko Fever 2", 250, "Costa poco");
            Product product9 = new Product(9, "https://pskmegastore.com/img/p/1/1/1/3/4/1/8/1113418.jpg", "Xiaomi 12", 200, "Costa poco");
            Product product10 = new Product(10, "https://assets.mmsrg.com/isr/166325/c1/-/ASSET_MMS_98068527?x=320&y=320&format=jpg&quality=80&sp=yes&strip=yes&trim&ex=320&ey=320&align=center&resizesource&unsharp=1.5x1+0.7+0.02&cox=0&coy=0&cdx=320&cdy=320", "Iphone 12", 1100, "Costa poco");
           productList.Add(product1);
            productList.Add(product2);
            productList.Add(product3);
            productList.Add(product4);
            productList.Add(product5);
            productList.Add(product6);
            productList.Add(product7);
            productList.Add(product8);
            productList.Add(product9);
            productList.Add(product10);

            Repeater1.DataSource = productList;
            Repeater1.DataBind();
        }

        
        
       
    }
}