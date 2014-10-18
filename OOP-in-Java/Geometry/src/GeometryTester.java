import java.util.Arrays;
import java.util.Comparator;
import java.util.List;
import java.util.stream.Collectors;
import shapes.PerimeterMeasurable;
import shapes.Shape;
import shapes.planeShapes.Circle;
import shapes.planeShapes.Rectangle;
import shapes.planeShapes.Triangle;
import shapes.spaceShapes.Cuboid;
import shapes.spaceShapes.SpaceShape;
import shapes.spaceShapes.Sphera;
import shapes.spaceShapes.SquarePyramid;

public class GeometryTester {

	public static void main(String[] args) throws Exception {
		double[] a = { 0, 0 };
		double[] b = { 1, 1 };
		double[] c = { 2, 2 };

		Shape triangle = new Triangle(a, b, c);
		Shape rectangle = new Rectangle(c, 5, 20);
		Shape circle = new Circle(a, 1);
		Shape piramida = new SquarePyramid(b, 25.8, 14.5, 10.1);
		Shape cuboid = new Cuboid(a, 17, 27, 27);
		Shape sphere = new Sphera(a, 9.25);

		Shape[] shapes = { triangle, rectangle, circle, piramida, cuboid,
				sphere };

		for (Shape shape : shapes) {
			System.out.println(shape);
		}
		
		List<SpaceShape> shapeList = Arrays.asList(shapes).stream()
				.filter(s -> s instanceof SpaceShape).map(s -> (SpaceShape) s)
				.filter(v -> v.getVolume() > 40).collect(Collectors.toList());

		System.out.println();		
		for (Shape shape : shapeList) {
			System.out.println(shape);
		}
		

		
		Comparator<PerimeterMeasurable> comparatorByPerimeter = (
				PerimeterMeasurable s1, PerimeterMeasurable s2) -> {
			double diff = s1.getPerimeter() - s2.getPerimeter();
			if (diff < 0) {
				return -1;
			}

			if (diff > 0) {
				return 1;
			}

			return 0;
		};

		List<PerimeterMeasurable> SortedShapes = Arrays.asList(shapes).stream()
				.filter(s -> s instanceof PerimeterMeasurable)
				.map(s -> (PerimeterMeasurable) s)
				.sorted(comparatorByPerimeter)
				.collect(Collectors.toList());
		
		System.out.println();
		for (PerimeterMeasurable shape : SortedShapes) {
			System.out.println(shape);
		}

	}
}
