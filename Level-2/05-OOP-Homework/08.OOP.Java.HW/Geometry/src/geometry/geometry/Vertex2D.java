package geometry.geometry;

public class Vertex2D extends Vertex {

	public Vertex2D(double x, double y) {
		super(x, y);
	}

	@Override
	public String toString() {
		return String.format("Vertex2D [toString()=%s]", super.toString());
	}
}
