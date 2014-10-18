public abstract class ElectonicsProduct extends Product {
	
	public int guaranteePeriodInMonths;

	public ElectonicsProduct(String name, double price, int quantity,
			AgeRestriction ageRestriction, int guaranteePeriodInMonths ) {
		super(name, price, quantity, ageRestriction);
		this.guaranteePeriodInMonths = guaranteePeriodInMonths;
	}
}
