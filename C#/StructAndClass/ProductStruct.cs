namespace StructAndClass;
public struct ProductStruct(string description, decimal price, decimal discount, int categoryId)
{
	public Guid Sku = Guid.NewGuid();
	public string Description = description;
	public decimal Price = price;
	public decimal Discount = discount;
	public int CategoryId = categoryId;
}