package geometry.geometry;

public class Rectangle extends PlaneShape {

	private double width;
	private double height;

	public Rectangle(double x, double y, double width, double height) {
		super(x, y);
		this.setWidth(width);
		this.setHeight(height);
	}

	public double getWidth() {
		return this.width;
	}

	public void setWidth(double width) {
		if (width < 0) {
			throw new IllegalArgumentException("Width should be positive.");
		}

		this.width = width;
	}

	public double getHeight() {
		return this.height;
	}

	public void setHeight(double height) {
		if (height < 0) {
			throw new IllegalArgumentException("Height should be positive.");
		}

		this.height = height;
	}

	@Override
	public double calcArea() {
		double areaRectangle = this.width * this.height;

		return areaRectangle;
	}

	@Override
	public double calcPerimeter() {
		double perimeterRectangle = (this.width * 2) + (this.height * 2);

		return perimeterRectangle;
	}

	@Override
	public String toString() {
		return String
				.format("Rectangle [width=%s, height=%s, calcArea()=%s, calcPerimeter()=%s, toString()=%s]",
						this.width, this.height, calcArea(), calcPerimeter(),
						super.toString());
	}

	
}
