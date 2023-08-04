namespace BookStoreCart;

public class Cart
{
    public decimal CalculateCost(int[] ints)
    {
        return 8m * ints.Length;
    }
}