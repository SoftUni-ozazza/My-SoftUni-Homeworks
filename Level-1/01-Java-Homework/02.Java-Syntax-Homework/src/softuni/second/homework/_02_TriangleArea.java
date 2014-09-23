package softuni.second.homework;

import java.text.DecimalFormat;
import java.util.Scanner;

public class _02_TriangleArea {
	public static void main(String[] args) {
		Scanner in = new Scanner(System.in);
		double x1 = in.nextDouble();
		double y1 = in.nextDouble();
		double x2 = in.nextDouble();
		double y2 = in.nextDouble();
		double x3 = in.nextDouble();
		double y3 = in.nextDouble();

		double areaTriangle = Math
				.abs(((x1 * (y2 - y3)) + (x2 * (y3 - y1)) + (x3 * (y1 - y2))) / 2);
		DecimalFormat df = new DecimalFormat("#");
		System.out.println(df.format(areaTriangle));
	}
}
