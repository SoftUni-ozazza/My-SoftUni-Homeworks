package geometry.geometry;

import geometry.interfaces.VolumeMeasurable;

import java.util.Arrays;
import java.util.List;
import java.util.stream.Collectors;

public class Geometry {

	public static void main(String[] args) {

		Shape[] shapeCollection = new Shape[6];
		shapeCollection[0] = new Triangle(1, -7, 3, 11, 20, 30);
		shapeCollection[1] = new Circle(122, -17, 13);
		shapeCollection[2] = new Rectangle(10, -70, 3, 22);
		shapeCollection[3] = new SquarePyramid(1, -7, 3, 11, 1);
		shapeCollection[4] = new Cuboid(1, -7, 3, 11, 20, 30);
		shapeCollection[5] = new Sphere(97, -12, 3, 50);

		for (Shape shape : shapeCollection) {
			System.out.println(shape);
		}

		List<Shape> largeVolumeShapes = Arrays.asList(shapeCollection).stream()
				.filter(s -> s instanceof VolumeMeasurable)
				.filter(v -> ((VolumeMeasurable) v).calcVolume() > 40)
				.collect(Collectors.toList());

		for (Shape shape : largeVolumeShapes) {
			System.out.println(shape);
		}

	}

}
