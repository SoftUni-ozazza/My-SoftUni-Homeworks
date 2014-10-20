package geometry.geometry;

public class SquarePyramid extends SpaceShape {

	private double baseWidth;
	private double height;

	public SquarePyramid(double x, double y, double z, double baseWidth,
			double height) {
		super(x, y, z);
		this.setBaseWidth(baseWidth);
		this.setHeight(height);
	}

	public double getBaseWidth() {
		return baseWidth;
	}

	public void setBaseWidth(double baseWidth) {
		if (baseWidth < 0) {
			throw new IllegalArgumentException(
					"BaseWidth value should be positive.");
		}

		this.baseWidth = baseWidth;
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

	@Override
	public double calcArea() {
		double areaSurfacePiramid = this.baseWidth * 4 * this.height * (1 / 2);
		double areaAllPyramid = this.calcAreaBasePiramid() + areaSurfacePiramid;

		return areaAllPyramid;
	}

	@Override
	public double calcVolume() {
		double volumePyramid = calcAreaBasePiramid() * this.height * (1 / 3);

		return volumePyramid;
	}

	@Override
	public String toString() {
		return String
				.format("SquarePyramid [calcArea()=%s, calcVolume()=%s]",
						calcArea(), calcVolume());
	}

	private double calcAreaBasePiramid() {
		double areaBasePiramid = this.baseWidth * this.baseWidth;

		return areaBasePiramid;
	}

}
