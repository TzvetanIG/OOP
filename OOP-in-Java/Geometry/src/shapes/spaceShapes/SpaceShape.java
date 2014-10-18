package shapes.spaceShapes;

import shapes.AreaMeasurable;
import shapes.Shape;
import shapes.VolumeMeasurable;

public abstract class SpaceShape extends Shape implements AreaMeasurable,
		VolumeMeasurable {

	public SpaceShape(double[] vertexCoordinates) {
		this.vertexCoordinates = new double[3];
		this.vertexCoordinates = vertexCoordinates;
	}
}
