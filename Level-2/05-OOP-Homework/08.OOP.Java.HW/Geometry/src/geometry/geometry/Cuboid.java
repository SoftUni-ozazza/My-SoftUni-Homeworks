package geometry.geometry;

public class Cuboid extends SpaceShape {

	private double width;
	private double height;
	private double depth;

	public Cuboid(double x, double y, double z, double width, double height,
			double depth) {
		super(x, y, z);
		this.setWidth(width);
		this.setHeight(height);
		this.setDepth(depth);
	}

	public double getWidth() {
		return width;
	}

	public void setWidth(double width) {
		if (width < 0) {
			throw new IllegalArgumentException(
					"Width value should be positive.");
		}

		this.width = width;
	}

	public double getHeight() {
		return height;
	}

	public void setHeight(double height) {
		if (height < 0) {
			throw new IllegalArgumentException(
					"Height value should be positive.");
		}

		this.height = height;
	}

	public double getDepth() {
		return depth;
	}

	public void setDepth(double depth) {
		if (depth < 0) {
			throw new IllegalArgumentException(
					"Depth value should be positive.");
		}

		this.depth = depth;
	}

	@Override
	public double calcArea() {
		double areaCuboid = 2 * this.width * this.depth + 2 * this.depth
				* this.height + 2 * this.height * this.width;

		return areaCuboid;
	}

	@Override
	public double calcVolume() {
		double volumeCuboid = this.width * this.height * this.depth;

		return volumeCuboid;
	}

	@Override
	public String toString() {
		return String.format("Cuboid [calcArea()=%s, calcVolume()=%s]",
				calcArea(), calcVolume());
	}
}
