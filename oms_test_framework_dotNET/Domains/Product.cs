using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oms_test_framework_dotNET.Domains
{
    public class Product
    {
        public virtual int Id { get; set; }
        public virtual int IsProductActive { get; set; }
        public virtual String ProductDescription { get; set; }
        public virtual String ProductName { get; set; }
        public virtual double ProductPrice { get; set; }

        protected Product()
        {

        }

        public static FirstIdStep NewBuilder()
        {
            return new Builder();
        }

        public interface FirstIdStep
        {
            ProductActiveStep SetId(int id);
        }

        public interface ProductActiveStep
        {
            ProductDescriptionStep SetProductActive(int productActive);
        }

        public interface ProductDescriptionStep
        {
            ProductNameStep SetProductDescription(String productDescription);
        }

        public interface ProductNameStep
        {
            ProductPriceStep SetProductName(String productName);
        }

        public interface ProductPriceStep
        {
            BuildStep SetProductPrice(double productPrice);
        }

        public interface BuildStep
        {
            Product Build();
        }

        private class Builder : FirstIdStep, ProductActiveStep,
                ProductDescriptionStep, ProductNameStep, ProductPriceStep,
                BuildStep
        {

            private int id;
            private int productActive;
            private String productDescription;
            private String productName;
            private double productPrice;

            public ProductActiveStep SetId(int id)
            {
                this.id = id;
                return this;
            }

            public ProductDescriptionStep SetProductActive(int productActive)
            {
                this.productActive = productActive;
                return this;
            }

            public ProductNameStep SetProductDescription(String productDescription)
            {
                this.productDescription = productDescription;
                return this;
            }

            public ProductPriceStep SetProductName(String productName)
            {
                this.productName = productName;
                return this;
            }

            public BuildStep SetProductPrice(double productPrice)
            {
                this.productPrice = productPrice;
                return this;
            }

            public Product Build()
            {

                Product product = new Product();

                product.Id = id;
                product.IsProductActive = productActive;
                product.ProductDescription = productDescription;
                product.ProductName = productName;
                product.ProductPrice = productPrice;

                return product;
            }
        }

        public override String ToString()
        {

            return "Product {" +
                    "ID=" + Id +
                    ", IsProductActive=" + IsProductActive +
                    ", ProductDescription=" + ProductDescription +
                    ", ProductName=" + ProductName +
                    ", ProductPrice=" + ProductPrice +
                    "}";
        }
    }
}
