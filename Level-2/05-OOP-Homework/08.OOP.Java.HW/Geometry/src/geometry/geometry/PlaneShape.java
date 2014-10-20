package geometry.geometry;

import geometry.interfaces.AreaMeasurable;
import geometry.interfaces.PerimeterMeasurable;

public abstract class PlaneShape extends Shape implements AreaMeasurable,
		PerimeterMeasurable {

	private final int VERTEX_COUNT = 3;

	public PlaneShape(double x, double y) {
		this.vertices = new Vertex2D[VERTEX_COUNT];
		this.vertices[0] = new Vertex2D(x, y);
	}

	@Override
	public abstract double calcArea();

	@Override
	public abstract double calcPerimeter();

	@Override
	public String toString() {
		return String.format(
				"PlaneShape [calcArea()=%s, calcPerimeter()=%s]",
				calcArea(), calcPerimeter());
	}

}
