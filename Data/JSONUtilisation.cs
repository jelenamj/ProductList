using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI.WebControls;
using System.IO;
using Newtonsoft.Json;

namespace ProductList.Data
{
    public class JSONUtilisation
    {
        
        private const string _file = @"C:\Users\PC\Desktop\ProductList\Product.json";
        private static int countid = 0;
        public static void LoadFromJSON(TextBox textBox )
        {
            string jsonFromFile;
            

            try
            {
                using (var reader = new StreamReader(_file))
                {
                    
                    jsonFromFile = reader.ReadToEnd();
                    textBox.Text = jsonFromFile;

                }    

            }
            catch (Exception)
            {

                throw;
            }

        }

        public static void SaveToJSON(Product product)
        {
            countid += 1;
            product.Id = countid;
            try
            {
                string jsonString = System.Text.Json.JsonSerializer.Serialize(product);
                using (var writer = new StreamWriter(_file, append: true))
                {
                    writer.WriteLine(jsonString);
                }
            }
            catch (Exception)
            {

                throw;
            }

            
           
        }
        public static void UpdateJSON(Product product)
        {

            //plementation of method
        }


    }

}