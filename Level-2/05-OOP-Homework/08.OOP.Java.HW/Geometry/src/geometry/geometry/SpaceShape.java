package geometry.geometry;

import geometry.interfaces.AreaMeasurable;
import geometry.interfaces.VolumeMeasurable;

public abstract class SpaceShape extends Shape implements AreaMeasurable,
		VolumeMeasurable {

	public SpaceShape(double x, double y, double z) {
		this.vertices[0] = new Vertex3D(x, y, z);
		this.vertices = new Vertex3D[1];
	}

	@Override
	public abstract double calcArea();
	
	@Override
	public abstract double calcVolume();

	@Override
	public String toString() {
		return String.format("SpaceShape [CalcArea()=%s, calcVolume()=%s]",
				calcArea(), calcVolume());
	}

	
}
