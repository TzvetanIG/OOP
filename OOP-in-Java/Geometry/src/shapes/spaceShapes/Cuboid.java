package shapes.spaceShapes;

import java.util.Arrays;

public class Cuboid extends SpaceShape {
	private double width;
	private double height;
	private double depth;

	public Cuboid(double[] vertexCoordinates, double width, double height,
			double depth) throws Exception {
		super(vertexCoordinates);
		this.setWidht(width);
		this.setHeight(height);
		this.setDepth(depth);
	}

	public void setDepth(double depth) throws Exception {
		if (depth <= 0) {
			throw new Exception("The depth should be positive number.");
		}

		this.depth = depth;
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

	@Override
	public double getArea() {
		double firstSideArea = this.width * this.height;
		double secondSideArea = this.width * this.depth;
		double thirdSideArea = this.depth * this.height;
		double cuboidArea = 2 * firstSideArea + 2 * secondSideArea + 2 * thirdSideArea;
		return cuboidArea;
	}

	@Override
	public double getVolume() {
		double volume = this.width * this.depth * this.height;
		return volume;
	}

	@Override
	public String toString() {
		return "Cuboid [width = " + this.width 
				+ ", height = " + this.height 
				+ ", depth = " 	+ depth 
				+ ", vertexCoordinates = " 	+ Arrays.toString(this.vertexCoordinates) 
				+ ", Area = " + this.getArea() 
				+ ", Volume = " + this.getVolume() 
				+ "]";
	}
	
	

}
