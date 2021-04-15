namespace P1.NET.models
{
    public class Stock
    {
        private string code;
        public string Code
        {
            get => code;
            set => code = value;
        }
        private int quantity;
        public int Quantity
        {
            get => quantity;
            set => quantity = value;
        }

        public Stock(string code, int quantity)
        {
            this.code = code;
            this.quantity = quantity;
        }

        public void incrementQuantity(int valueToSum)
        {
            quantity += valueToSum;
        }
    }
}