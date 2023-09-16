using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Esercizio5
{
    public partial class WebForm2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            List<Product> Carrello = new List<Product>();
            double tot = 0;

            Repeater2.DataSource = Db.Carrello;
            Repeater2.DataBind();
            Repeater3.DataSource = Db.Carrello;
            Repeater3.DataBind();
            totale.InnerHtml = $"€ {Db.TotCarrello}";

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Db.deleteAll();
            Response.Redirect(Request.RawUrl);
        }

        protected void rimuovi_Click(object sender, EventArgs e)
        {
            Button button = (sender as Button);
            int id = Convert.ToInt32(button.CommandArgument);
            Db.deletePrd(id);
            Response.Redirect(Request.RawUrl);
        }
    }
    }
