using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ProductList.Data;

namespace ProductList
{
    public partial class _Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            DatabaseUtilisation.LoadProduct(gvDbList);

        }

        protected void gvListDb_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void btnDbSave_Click(object sender, EventArgs e)
        {
            lblError.Text = "";
            
            if (String.IsNullOrEmpty(txtDbName.Text) || Validation.PriceValidation(txtDbPrice.Text)==0)
            {
                lblError.Text = ("Molimo vas da unesete naziv i cijenu");
            }
            else if (Validation.PriceValidation(txtDbPrice.Text) == -1)
            {
                lblError.Text = ("Molimo vas da unesete ispravnu cijenu");
            }
            else if (!String.IsNullOrEmpty(DatabaseUtilisation.IsNameExist(txtDbName.Text)))
            {
                lblError.Text = ("Proizvod postoji u bazi.");
            }
            else
            {
                var product = new Product();
                product.Name = txtDbName.Text;
                product.Manufacturer = txtDbManuf.Text;
                product.Descripteion = txtDbDescription.Text;
                product.Supplier = txtDbSupplier.Text;
                product.Category = txtDbCategory.Text;
                product.Price = Convert.ToDouble(txtDbPrice.Text);
                DatabaseUtilisation.SaveProduct(product);
                DatabaseUtilisation.LoadProduct(gvDbList);
            }
            
        }

        protected void btnDbUpdate_Click(object sender, EventArgs e)
        {
            lblError.Text = "";
            if (String.IsNullOrEmpty(txtDbName.Text) || Validation.PriceValidation(txtDbPrice.Text) == 0)
            {
                lblError.Text = ("Molimo vas da unesete naziv i cijenu");
            }
            else if (Validation.PriceValidation(txtDbPrice.Text) == -1)
            {
                lblError.Text = ("Molimo vas da unesete ispravnu cijenu");
            }
            else if (String.IsNullOrEmpty(DatabaseUtilisation.IsNameExist(txtDbName.Text)))
            {
                lblError.Text = ("Proizvod ne postoji u bazi.");
            }
            else
            {
                var product = new Product();
                product.Name = txtDbName.Text;
                product.Manufacturer = txtDbManuf.Text;
                product.Supplier = txtDbSupplier.Text;
                product.Descripteion = txtDbDescription.Text;
                product.Category = txtDbCategory.Text;
                product.Price = Convert.ToDouble(txtDbPrice.Text);
                DatabaseUtilisation.UpdateProduct(product);
                DatabaseUtilisation.LoadProduct(gvDbList);
            }
                
        }
    }
}