package shapes.planeShapes;

import shapes.AreaMeasurable;
import shapes.PerimeterMeasurable;
import shapes.Shape;

public abstract class PlaneShape extends Shape implements PerimeterMeasurable,
		AreaMeasurable {
	public PlaneShape(double[] vertexCoordinates) {
		this.vertexCoordinates = new double[2];
		this.vertexCoordinates = vertexCoordinates;
	}
}
