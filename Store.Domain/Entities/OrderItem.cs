using Flunt.Validations;

namespace Store.Domain.Entities
{
    public class OrderItem : Entity
    {
        public Product Product { get; private set; }
        public double Price { get; private set; }
        public int Quantity { get; private set; }

        public OrderItem(Product product, int quantity)
        {
            AddNotifications(
                new Contract()
                    .Requires()
                    .IsNotNull(product, "Product", "Produto inválido")
                    .IsGreaterThan(quantity, 0, "Quantity", "A quantidade deve ser maior  que zero")
            );
            // sdasd
            Product = product;
            Price = Product != null ? product.Price : 0;
            Quantity = quantity;
        }

        public double Total()
        {
            return Price * Quantity;
        }
    }
}