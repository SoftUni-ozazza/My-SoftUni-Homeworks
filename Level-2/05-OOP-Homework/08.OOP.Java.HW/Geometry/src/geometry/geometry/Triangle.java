package geometry.geometry;

import java.util.Arrays;

public class Triangle extends PlaneShape {

	private double aSide;
	private double bSide;
	private double cSide;

	public Triangle(double x1, double y1, double x2, double y2, double x3,
			double y3) {
		super(x1, y2);

		this.vertices[1] = new Vertex2D(x2, y2);
		this.vertices[2] = new Vertex2D(x3, y3);

		this.aSide = Vertex.calcDistancePointToPoint(this.vertices[0],
				this.vertices[1]);
		this.bSide = Vertex.calcDistancePointToPoint(this.vertices[1],
				this.vertices[2]);
		this.cSide = Vertex.calcDistancePointToPoint(this.vertices[2],
				this.vertices[0]);
	}

	@Override
	public double calcArea() {
		double s = this.calcPerimeter();
		double areaTriangle = Math.sqrt(s * (s - this.aSide) * (s - this.bSide)
				* (s - this.cSide));

		return areaTriangle;
	}

	@Override
	public double calcPerimeter() {
		double perimeterTriangle = this.aSide + this.bSide + this.cSide;

		return perimeterTriangle;
	}

	@Override
	public String toString() {
		return String
				.format("Triangle [aSide=%s, bSide=%s, cSide=%s, vertices=%s, calcArea()=%s, calcPerimeter()=%s, toString()=%s]",
						this.aSide, this.bSide, this.cSide, Arrays.toString(vertices),
						calcArea(), calcPerimeter(), super.toString());
	}

}
