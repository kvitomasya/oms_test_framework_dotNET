using System;

namespace oms_test_framework_dotNET.Domains
{
    public class OrderItem
    {
        public virtual int Id { get; set; }
        public virtual double Cost { get; set; }
        public virtual double ItemPrice { get; set; }
        public virtual int Quantity { get; set; }
        public virtual int DimensionRef { get; set; }
        public virtual int OrderRef { get; set; }
        public virtual int ProductRef { get; set; }

        protected OrderItem()
        {

        }

        public static FirstIdStep NewBuilder()
        {
            return new Builder();
        }

        public interface FirstIdStep
        {
            CostStep SetId(int id);
        }

        public interface CostStep
        {
            ItemPriceStep SetCost(double cost);
        }

        public interface ItemPriceStep
        {
            QuantityStep SetItemPrice(double itemPrice);
        }

        public interface QuantityStep
        {
            DimensionReferenceStep SetQuantity(int quantity);
        }

        public interface DimensionReferenceStep
        {
            OrderReferenceStep SetDimensionReference(int dimensionReference);
        }

        public interface OrderReferenceStep
        {
            ProductReferenceStep SetOrderReference(int orderReference);
        }

        public interface ProductReferenceStep
        {
            BuildStep SetProductReference(int productReference);
        }

        public interface BuildStep
        {
            OrderItem Build();
        }

        private class Builder : FirstIdStep, CostStep, ItemPriceStep, QuantityStep,
                DimensionReferenceStep, OrderReferenceStep, ProductReferenceStep, BuildStep
        {

            private int id;
            private double cost;
            private double itemPrice;
            private int quantity;
            private int dimensionReference;
            private int orderReference;
            private int productReference;

            public CostStep SetId(int id)
            {
                this.id = id;
                return this;
            }

            public ItemPriceStep SetCost(double cost)
            {
                this.cost = cost;
                return this;
            }

            public QuantityStep SetItemPrice(double itemPrice)
            {
                this.itemPrice = itemPrice;
                return this;
            }

            public DimensionReferenceStep SetQuantity(int quantity)
            {
                this.quantity = quantity;
                return this;
            }

            public OrderReferenceStep SetDimensionReference(int dimensionReference)
            {
                this.dimensionReference = dimensionReference;
                return this;
            }

            public ProductReferenceStep SetOrderReference(int orderReference)
            {
                this.orderReference = orderReference;
                return this;
            }

            public BuildStep SetProductReference(int productReference)
            {
                this.productReference = productReference;
                return this;
            }

            public OrderItem Build()
            {

                OrderItem orderItem = new OrderItem();

                orderItem.Id = id;
                orderItem.Cost = cost;
                orderItem.ItemPrice = itemPrice;
                orderItem.Quantity = quantity;
                orderItem.DimensionRef = dimensionReference;
                orderItem.OrderRef = orderReference;
                orderItem.ProductRef = productReference;

                return orderItem;
            }
        }

        public override String ToString()
        {
            return "OrderItem{" +
                    "ID=" + Id +
                    ", Cost=" + Cost +
                    ", ItemPrice=" + ItemPrice +
                    ", Quantity=" + Quantity +
                    ", DimensionReference=" + DimensionRef +
                    ", OrderReference=" + OrderRef +
                    ", ProductReference=" + ProductRef +
                    "}";
        }
    }
}
