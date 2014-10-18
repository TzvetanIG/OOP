package shapes.spaceShapes;

import java.util.Arrays;

public class Sphera extends SpaceShape {

	private double radius;

	public Sphera(double[] vertexCoordinates, double radius) throws Exception {
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
	public double getArea() {
		double sphereArea = 4 * Math.PI * this.radius * this.radius;
		return sphereArea;
	}

	@Override
	public double getVolume() {
		double sphereVolume = 4 * Math.PI * this.radius * this.radius * this.radius / 3;
		return sphereVolume;
	}

	@Override
	public String toString() {
		return "Sphera [radius = " + this.radius 
				+ ", vertexCoordinates = " + Arrays.toString(this.vertexCoordinates) 
				+ ", Area = " + this.getArea() 
				+ ", Volume =" + this.getVolume() 
				+ "]";
	}
	
	
}
