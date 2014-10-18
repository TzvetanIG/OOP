package shapes.planeShapes;

import java.util.Arrays;

public class Triangle extends PlaneShape {
	protected double[] secondVertexCoordinates = new double[2];
	protected double[] thirdVertexCoordinates = new double[2];

	public Triangle(double[] firstVertexCoordinates,
			double[] secondVertexCoordinates, double[] thirdVertexCoordinates) {

		super(firstVertexCoordinates);
		this.secondVertexCoordinates = secondVertexCoordinates;
		this.thirdVertexCoordinates = thirdVertexCoordinates;
	}

	@Override
	public double getPerimeter() {
		double[] sides = this.getSides();
		double perimeter = sides[0] + sides[1] + sides[2];
		return perimeter;
	}

	@Override
	public double getArea() {
		double[] sides = this.getSides();
		double halfPerimeter = this.getPerimeter() / 2;
		double area = Math.sqrt((halfPerimeter - sides[0])
				* (halfPerimeter - sides[1]) * (halfPerimeter - sides[2]));
		return area;
	}

	@Override
	public String toString() {
		return "Triangle [firstVertex = " + Arrays.toString(this.vertexCoordinates) 
				+ ", secondVertex = " + Arrays.toString(this.secondVertexCoordinates)
				+ ", thirdVertex = " + Arrays.toString(this.thirdVertexCoordinates)
				+ ", Perimeter = " 	+ this.getPerimeter() 
				+ ", Area = " + this.getArea()
				+ "]";
	}

	private double[] getSides() {
		double firstSide = getDistanceBetweenTwoPoints(vertexCoordinates,
				secondVertexCoordinates);
		double secondSide = getDistanceBetweenTwoPoints(
				secondVertexCoordinates, thirdVertexCoordinates);
		double thirdSide = getDistanceBetweenTwoPoints(thirdVertexCoordinates,
				vertexCoordinates);
		double[] sides = { firstSide, secondSide, thirdSide };
		return sides;
	}

	private double getDistanceBetweenTwoPoints(double[] firstPoint,
			double[] secondPoint) {
		double deltaX = firstPoint[0] - secondPoint[0];
		double deltaY = firstPoint[1] - secondPoint[1];
		double distance = Math.sqrt(deltaX * deltaX + deltaY * deltaY);
		return distance;
	}

}
