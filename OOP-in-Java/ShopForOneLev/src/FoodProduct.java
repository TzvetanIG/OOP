import java.text.ParseException;
import java.text.SimpleDateFormat;
import java.util.Date;
import java.util.concurrent.TimeUnit;

public class FoodProduct extends Product implements Expirable {
	private Date expirationDate;

	public FoodProduct(String name, double price, int quantity,
			AgeRestriction ageRestriction, String expirationDate) {
		super(name, price, quantity, ageRestriction);
		this.setExpirationDate(expirationDate);
	}

	@Override
	public Date getExpirationDate() {
		return this.expirationDate;
	}

	public void setExpirationDate(String expirationDate) {
		SimpleDateFormat myFormat = new SimpleDateFormat("dd.MM.yyyy");
		try {
			this.expirationDate = myFormat.parse(expirationDate);
		} catch (ParseException e) {
			e.printStackTrace();
		}
	}

	@Override
	public double getPrice() {

		Date now = new Date();
		long DaysToExpirationDate = getDaysBetweenToDate(this.getExpirationDate(), now);
		if (DaysToExpirationDate <= 15 ) {
			return super.getPrice() * 0.7;
		}

		return super.getPrice();

	}

	private long getDaysBetweenToDate(Date firstDate, Date secondDay) {
		long diff = firstDate.getTime() - secondDay.getTime();
		long days = TimeUnit.DAYS.convert(diff, TimeUnit.MILLISECONDS);
		return days;
	}

}
