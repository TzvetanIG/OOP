import java.sql.Date;
import java.time.LocalDate;

public class PurchaseManager {

	public static void ProcessPurchase(Product product, Customer customer) {
		checkExpirationDate(product);
		checkCustomerBalance(customer, product.getPrice());
		checkForAgeRestrictions(customer, product);
		checkForOutOfStock(product);
		
		double newBalance = customer.getBalance() - product.getPrice();
		int newQuantity = product.getQuantity() - 1;
		product.setQuantity(newQuantity);
		customer.setBalance(newBalance);
	}
	
	private static void checkForOutOfStock(Product product){
		if (product.getQuantity() - 1 < 0) {
			throw new RuntimeException("There are not " + product.getName() + ".");
		}
	}
	
	private static void checkExpirationDate(Product product){
		if (product instanceof Expirable) {
			Expirable expirableProduct = (Expirable)product;
			Date now = Date.valueOf(LocalDate.now());
			if (expirableProduct.getExpirationDate().before(now)) {
				throw new RuntimeException(product.getName() + " is past its date." );
			}
		}
	}
	
	private static void checkCustomerBalance(Customer customer, double sum){
		if (customer.getBalance() < sum) {
			throw new RuntimeException(customer.getName() + " has not enough money to buy this product!" );
		}
	}
	
	private static void checkForAgeRestrictions(Customer customer, Product product){
		if (product.getAgeRestriction() == AgeRestriction.Adult) {
			if (customer.getAge() < 18) {
				throw new RuntimeException(customer.getName() + " is too young to buy this product!" );
			}
		}
	}
}
