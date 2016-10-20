using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oms_test_framework_dotNET.Domains
{
    public class Order
    {
        public virtual int Id { get; set; }
        public virtual String DeliveryDate { get; set; }
        public virtual int IsGift { get; set; }
        public virtual int MaxDiscount { get; set; }
        public virtual String OrderDate { get; set; }
        public virtual String OrderName { get; set; }
        public virtual int OrderNumber { get; set; }
        public virtual String PreferableDeliveryDate { get; set; }
        public virtual double TotalPrice { get; set; }
        public virtual int Assigne { get; set; }
        public virtual int Customer { get; set; }
        public virtual int OrderStatusRef { get; set; }

        protected Order()
        {

        }

        public static FirstIdStep NewBuilder()
        {
            return new Builder();
        }

        public interface FirstIdStep
        {
            DeliveryDateStep SetId(int id);
        }

        public interface DeliveryDateStep
        {
            IsGiftStep SetDeliveryDate(String deliveryDate);
        }

        public interface IsGiftStep
        {
            MaxDiscountStep SetIsGift(int isGift);
        }

        public interface MaxDiscountStep
        {
            OrderDateStep SetMaxDiscount(int maxDiscount);
        }

        public interface OrderDateStep
        {
            OrderNameStep SetOrderDate(String orderDate);
        }

        public interface OrderNameStep
        {
            OrderNumberStep SetOrderName(String orderName);
        }

        public interface OrderNumberStep
        {
            PreferableDeliveryDateStep SetOrderNumber(int orderNumber);
        }

        public interface PreferableDeliveryDateStep
        {
            TotalPriceStep SetPreferableDeliveryDate(String preferableDeliveryDate);
        }

        public interface TotalPriceStep
        {
            AssigneeStep SetTotalPrice(double totalPrice);
        }

        public interface AssigneeStep
        {
            CustomerStep SetAssignee(int assignee);
        }

        public interface CustomerStep
        {
            OrderStatusReferenceStep SetCustomer(int customer);
        }

        public interface OrderStatusReferenceStep
        {
            BuildStep SetOrderStatusReference(int orderStatusReference);
        }

        public interface BuildStep
        {
            Order Build();
        }

        private class Builder : FirstIdStep, DeliveryDateStep, IsGiftStep, MaxDiscountStep,
                OrderDateStep, OrderNameStep, OrderNumberStep, PreferableDeliveryDateStep, TotalPriceStep,
                AssigneeStep, CustomerStep, OrderStatusReferenceStep, BuildStep
        {

            private int id;
            private String deliveryDate;
            private int isGift;
            private int maxDiscount;
            private String orderDate;
            private String orderName;
            private int orderNumber;
            private String preferableDeliveryDate;
            private double totalPrice;
            private int assignee;
            private int customer;
            private int orderStatusReference;

            public DeliveryDateStep SetId(int id)
            {
                this.id = id;
                return this;
            }

            public IsGiftStep SetDeliveryDate(String deliveryDate)
            {
                this.deliveryDate = deliveryDate;
                return this;
            }

            public MaxDiscountStep SetIsGift(int isGift)
            {
                this.isGift = isGift;
                return this;
            }

            public OrderDateStep SetMaxDiscount(int maxDiscount)
            {
                this.maxDiscount = maxDiscount;
                return this;
            }

            public OrderNameStep SetOrderDate(String orderDate)
            {
                this.orderDate = orderDate;
                return this;
            }

            public OrderNumberStep SetOrderName(String orderName)
            {
                this.orderName = orderName;
                return this;
            }

            public PreferableDeliveryDateStep SetOrderNumber(int orderNumber)
            {
                this.orderNumber = orderNumber;
                return this;
            }

            public TotalPriceStep SetPreferableDeliveryDate(String preferableDeliveryDate)
            {
                this.preferableDeliveryDate = preferableDeliveryDate;
                return this;
            }

            public AssigneeStep SetTotalPrice(double totalPrice)
            {
                this.totalPrice = totalPrice;
                return this;
            }

            public CustomerStep SetAssignee(int assignee)
            {
                this.assignee = assignee;
                return this;
            }

            public OrderStatusReferenceStep SetCustomer(int customer)
            {
                this.customer = customer;
                return this;
            }

            public BuildStep SetOrderStatusReference(int orderStatusReference)
            {
                this.orderStatusReference = orderStatusReference;
                return this;
            }

            public Order Build()
            {

                Order order = new Order();

                order.Id = id;
                order.DeliveryDate = deliveryDate;
                order.IsGift = isGift;
                order.MaxDiscount = maxDiscount;
                order.OrderDate = orderDate;
                order.OrderName = orderName;
                order.OrderNumber = orderNumber;
                order.PreferableDeliveryDate = preferableDeliveryDate;
                order.TotalPrice = totalPrice;
                order.Assigne = assignee;
                order.Customer = customer;
                order.OrderStatusRef = orderStatusReference;

                return order;
            }
        }

        public override String ToString()
        {

            return "Order{" +
                    "ID=" + Id +
                    ", DeliveryDate='" + DeliveryDate +
                    ", IsGift=" + IsGift +
                    ", MaxDiscount=" + MaxDiscount +
                    ", OrderDate='" + OrderDate +
                    ", OrderName='" + OrderName +
                    ", OrderNumber=" + OrderNumber +
                    ", PreferableDeliveryDate='" + PreferableDeliveryDate +
                    ", TotalPrice=" + TotalPrice +
                    ", Assignee=" + Assigne +
                    ", Customer=" + Customer +
                    ", OrderStatusReference=" + OrderStatusRef +
                    "}";
        }
    }
}
