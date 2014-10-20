package geometry.geometry;

import java.util.Arrays;

public abstract class Shape {
	protected Vertex[] vertices;

	protected Shape() {
		this.vertices = new Vertex[1];
	}

	public Vertex[] getVertices() {
		return this.vertices;
	}

	public void setVertices(Vertex[] vertices) {
		this.vertices = vertices;
	}

	@Override
	public String toString() {
		return String.format("Shape [vertices=%s]", Arrays.toString(vertices));
	}
}
