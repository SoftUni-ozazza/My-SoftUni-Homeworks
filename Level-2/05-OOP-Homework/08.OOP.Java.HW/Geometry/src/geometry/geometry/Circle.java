package geometry.geometry;

public class Circle extends PlaneShape {

	private double radius;

	public Circle(double x, double y, double radius) {
		super(x, y);
		this.setRadius(radius);
	}

	public double getRadius() {
		return this.radius;
	}

	public void setRadius(double radius) {
		if (radius < 0) {
			throw new IllegalArgumentException(
					"Radius value should be positive.");
		}

		this.radius = radius;
	}

	@Override
	public double calcArea() {
		double areaCircle = Math.PI * this.radius * this.radius;

		return areaCircle;
	}

	@Override
	public double calcPerimeter() {
		double perimeterCircle = Math.PI * 2 * this.radius;

		return perimeterCircle;
	}

	@Override
	public String toString() {
		return String
				.format("Circle [radius=%s, getRadius()=%s, calcArea()=%s, toString()=%s]",
						radius, getRadius(), calcArea(), super.toString());
	}

}
