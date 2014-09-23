package softuni.first.homework;

import java.util.Scanner;

public class SumTwoNumbers {
	public static void main(String[] args) {
		Scanner input = new Scanner(System.in);
		
		try{
			System.out.print("Enter First Number: ");
			int first = input.nextInt();
			System.out.print("Enter Second Number: ");
			int second = input.nextInt();
			int sum = first + second;
			System.out.println(sum);
		} finally {
			input.close();
		}
	}
}
