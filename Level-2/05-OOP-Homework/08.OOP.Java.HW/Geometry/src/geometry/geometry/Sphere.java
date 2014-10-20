package geometry.geometry;

public class Sphere extends SpaceShape {

	private double radius;

	public Sphere(double x, double y, double z, double radius) {
		super(x, y, z);
		this.setRadius(radius);
	}

	public double getRadius() {
		return radius;
	}

	public void setRadius(double radius) {
		if (radius < 0) {
			throw new IllegalArgumentException(
					"Radius should be positive value");
		}

		this.radius = radius;
	}

	@Override
	public double calcArea() {
		double areaSphere = Math.PI * Math.pow(this.radius, 2) * 4;

		return areaSphere;
	}

	@Override
	public double calcVolume() {
		double volumeSphere = Math.PI * Math.pow(this.radius, 3) * (4 / 3);

		return volumeSphere;
	}

	@Override
	public String toString() {
		return String.format("Sphere [calcArea()=%s, calcVolume()=%s]",
				calcArea(), calcVolume());
	}

}
