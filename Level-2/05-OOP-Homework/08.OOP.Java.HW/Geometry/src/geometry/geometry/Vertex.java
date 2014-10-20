package geometry.geometry;

public abstract class Vertex extends Shape{
	private Double x;
	private Double y;

	public Vertex(double x, double y) {
		this.setX(x);
		this.setY(y);
	}

	public Double getX() {
		return this.x;
	}

	public void setX(Double x) {
		this.x = x;
	}

	public Double getY() {
		return this.y;
	}

	public void setY(Double y) {
		this.y = y;
	}

	public static double calcDistancePointToPoint(Vertex pointA, Vertex pointB) {
		double deltaX = pointA.getX() - pointB.getX();
		double deltaY = pointA.getY() - pointB.getY();
		double mathPowDelta = Math.pow(deltaX, 2) + Math.pow(deltaY, 2);
		double distancePointToPoint = Math.sqrt(mathPowDelta);

		return distancePointToPoint;
	}
	
	public static double calcVerticesDistanceFromArray(Vertex[] vertices) {
		double distanceSum = 0;
		for (int i = 1; i < vertices.length; i++) {

			double deltaX = vertices[i].getX() - vertices[i - 1].getX();
			double deltaY = vertices[i].getY() - vertices[i - 1].getY();
			double calcDistanceOfTwoCoordinates = Math.pow(deltaX, 2)
					+ Math.pow(deltaY, 2);

			distanceSum += calcDistanceOfTwoCoordinates;
		}
		distanceSum = Math.sqrt(distanceSum);

		return distanceSum;
	}

	@Override
	public String toString() {
		return String.format("Vertex [x=%s, y=%s]", this.x, this.y);
	}
}
