package shapes.spaceShapes;

import java.util.Arrays;

public class SquarePyramid extends SpaceShape {

	private double width;
	private double height;
	private double apotema;
	
	public SquarePyramid(double[] vertexCoordinates, double width,
			double height, double apotema) throws Exception {
		super(vertexCoordinates);
		this.setWidht(width);
		this.setHeight(height);
		this.setApotema(apotema);
	}

	public void setApotema(double apotema) throws Exception {
		if (apotema <= 0) {
			throw new Exception("The apotema should be positive number.");
		}
		
		this.apotema = apotema;
	}

	public void setHeight(double height) throws Exception {
		if (height <= 0) {
			throw new Exception("The height should be positive number.");
		}
		
		this.height = height;
	}
	
	public double getWidth() {
		return this.width;
	}
	
	public void setWidht(double width) throws Exception {
		if (width <= 0) {
			throw new Exception("The width should be positive number.");
		}
		
		this.width = width;
	}
	
	private double getBaseArea(){
		double baseArea = this.width * this.width;
		return baseArea;
	}
	
	@Override
	public double getArea() {
		double sidesArea = 4 * this.width * this.apotema * 0.5;
		double area = this.getBaseArea() + sidesArea;
		return area;
	}

	@Override
	public double getVolume() {
		double volume =  this.getBaseArea() * this.height / 3;
		return volume;
	}

	@Override
	public String toString() {
		return "SquarePyramid [width = " + width 
				+ ", this.height = " + this.height
				+ ", apotema = " + this.apotema 
				+ ", vertexCoordinates = " + Arrays.toString(this.vertexCoordinates) 
				+ ", Area = " + this.getArea() 
				+ ", Volume = " + this.getVolume() 
				+ "]";
	}

	
}
