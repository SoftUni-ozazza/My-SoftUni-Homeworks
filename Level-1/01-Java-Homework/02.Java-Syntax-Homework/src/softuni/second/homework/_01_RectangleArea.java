package softuni.second.homework;

import java.util.Scanner;

public class _01_RectangleArea {
	public static void main(String[] args){
		calcAndPrintRectangleArea();
	}

	private static void calcAndPrintRectangleArea() {
		System.out.println("Calculating rectangl's area. Insert:");
		Scanner input = new Scanner(System.in);
		System.out.print("width = ");
		double width = input.nextDouble();
		System.out.print("height = ");
		double height = input.nextDouble();
		
		double area = calcRectangleArea(width, height);
		System.out.printf("Area = %.2f\n", area);
	}

	static double calcRectangleArea(double width, double height) {
		return width*height;
	}

}
