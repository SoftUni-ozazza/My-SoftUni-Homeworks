package geometry.geometry;

public class Vertex3D extends Vertex {

	private double z;

	public Vertex3D(double x, double y, double z) {
		super(x, y);
		this.setZ(z);
	}

	public double getZ() {
		return this.z;
	}

	public void setZ(double z) {
		this.z = z;
	}

	@Override
	public String toString() {
		return String.format("Vertex3D [toString()=%s, z=%s]",
				super.toString(), this.z);
	}
}
