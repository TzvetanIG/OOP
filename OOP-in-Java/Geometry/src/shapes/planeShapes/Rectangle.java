package shapes.planeShapes;

import java.util.Arrays;

public class Rectangle extends PlaneShape {
	private double height;
	private double width;

	public Rectangle(double[] vertex, double height, double widht)
			throws Exception {
		super(vertex);
		this.setHeight(height);
		this.setWidth(widht);
	}

	public double getHeight() {
		return height;
	}

	public void setHeight(double height) throws Exception {
		if (height <= 0) {
			throw new Exception("The height should be positive number.");
		}

		this.height = height;
	}

	public double getWidth() {
		return width;
	}

	public void setWidth(double widht) throws Exception {
		if (widht <= 0) {
			throw new Exception("The width should be positive number.");
		}

		this.width = widht;
	}

	@Override
	public double getPerimeter() {
		double perimeter = this.height * 2 + this.width * 2;
		return perimeter;
	}

	@Override
	public double getArea() {
		double area = this.height * this.width;
		return area;
	}

	@Override
	public String toString() {
		return "Rectangle [height = " + this.height 
				+ ", widht = " + this.width
				+ ", vertexCoordinates = " + Arrays.toString(this.vertexCoordinates)
				+ ", Perimeter = " 	+ this.getPerimeter() 
				+ ", Area = " + this.getArea()
				+ "]";
	}

}
