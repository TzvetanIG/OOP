public abstract class Product implements Buyable {
	private String name;
	private double price;
	private int quantity;
	private AgeRestriction ageRestriction;
	
	public Product(String name, double price, int quantity,	AgeRestriction ageRestriction) {
		this.name = name;
		this.setPrice(price);
		this.setQuantity(quantity);
		this.ageRestriction = ageRestriction;
	}

	@Override
	public double getPrice() {
		return this.price;
	}

	public void setPrice(double price) {
		this.price = price;
	}

	public int getQuantity() {
		return this.quantity;
	}

	public void setQuantity(int quantity) {
		this.quantity = quantity;
	}

	public String getName() {
		return this.name;
	}

	public AgeRestriction getAgeRestriction() {
		return this.ageRestriction;
	}
	
	
}
