using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ProductList.Data;

namespace ProductList
{
    public partial class About : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            JSONUtilisation.LoadFromJSON(txtShowProduct);

        }

        protected void btnJSONSave_Click(object sender, EventArgs e)
        {
            lblError.Text = "";

            if (String.IsNullOrEmpty(txtJSONName.Text) || Validation.PriceValidation(txtJSONPrice.Text) == 0)
            {
                lblError.Text = ("Molimo vas da unesete naziv i cijenu");
            }
            else if (Validation.PriceValidation(txtJSONPrice.Text) == -1)
            {
                lblError.Text = ("Molimo vas da unesete ispravnu cijenu");
            }
            else if (!String.IsNullOrEmpty(DatabaseUtilisation.IsNameExist(txtJSONName.Text)))
            {
                lblError.Text = ("Proizvod postoji u bazi.");
            }
            else
            {
                var product = new Product();
                product.Name = txtJSONName.Text;
                product.Manufacturer = txtJSONManuf.Text;
                product.Descripteion = txtJSONDescription.Text;
                product.Supplier = txtJSONSupplier.Text;
                product.Category = txtJSONCategory.Text;
                product.Price = Convert.ToDouble(txtJSONPrice.Text);

                JSONUtilisation.SaveToJSON(product);
                JSONUtilisation.LoadFromJSON(txtShowProduct);
            }
        }

        protected void btnJSONUpdate_Click(object sender, EventArgs e)
        {
            lblError.Text="Nije implementirano";
       
        }
    }
}