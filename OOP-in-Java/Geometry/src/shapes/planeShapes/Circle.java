package shapes.planeShapes;

import java.util.Arrays;

public class Circle extends PlaneShape {

	private double radius;

	public Circle(double[] vertexCoordinates, double radius) throws Exception {
		super(vertexCoordinates);
		this.setRadius(radius);
	}
	
	public void setRadius(double radius) throws Exception {
		if (radius <= 0) {
			throw new Exception("The radius should be positive number.");
		}

		this.radius = radius;
	}

	@Override
	public double getPerimeter() {
		double perimeter = 2 * Math.PI * this.radius;
		return perimeter;
	}

	@Override
	public double getArea() {
		double area = Math.PI * this.radius * this.radius;
		return area;
	}

	@Override
	public String toString() {
		return "Circle [radius = " + this.radius 
				+ ", vertexCoordinates = " + Arrays.toString(vertexCoordinates)
				+ ", Perimeter = " + this.getPerimeter() 
				+ ", Area=" + this.getArea()
				+ "]";
	}

}
