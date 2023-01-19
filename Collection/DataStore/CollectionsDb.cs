using Collection.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Dynamic;

namespace Collection.DataStore
{
    public class CollectionsDb
    {
        private List<Products> _products;

        public CollectionsDb(List<Products> products)
        {
            _products = products;
        }

        public List<ExpandoObject> GetProperties(params string[] properties)
        {
            var result = new List<ExpandoObject>();
            foreach (var property in _products)
            {
                dynamic expandoProduct = new ExpandoObject();

                var expandoDictionary = expandoProduct as IDictionary<string, object>;

                if (properties.Length == 0)
                {
                    expandoDictionary["Id"] = property.Id;

                    expandoDictionary["Name"] = property.Name;

                    expandoDictionary["Quantity"] = property.Quantity;

                    expandoDictionary["Price"] = property.Price;

                    expandoDictionary["Category"] = property.Category;

                    expandoDictionary["OrderCount"] = property.OrderCount;
                }
                else
                {
                    foreach (var prop in properties)
                    {
                        switch (prop)
                        {
                            case "Id":

                                expandoDictionary["Id"] = property.Id;

                                break;

                            case "Name":

                                expandoDictionary["Name"] = property.Name;

                                break;

                            case "Quantity":

                                expandoDictionary["Quantity"] = property.Quantity;

                                break;

                            case "Price":

                                expandoDictionary["Price"] = property.Price;

                                break;

                            case "Category":

                                expandoDictionary["Category"] = property.Category;

                                break;

                            case "OrderCount":

                                expandoDictionary["OrderCount"] = property.OrderCount;

                                break;
                        }
                    }
                }
                result.Add(expandoProduct);
            }
            return result;
        }

        public void Display(List<ExpandoObject> expandoObjects, params string[] properties)
        {
            if (properties.Length == 0)
            {
                properties = new string[] { "Id", "Name", "Quantity", "Price", "Category", "OrderCount" };
            }
            //var header = string.Join(", ", properties);

            //Console.WriteLine(header);

            foreach (var expando in expandoObjects)
            {
                var dictionary = expando as IDictionary<string, object>;
                foreach (var item in dictionary)
                {
                    Console.Write(item.Key + ": " + item.Value + ", ");
                }
                Console.WriteLine();
            }

        }
    }



    
}
