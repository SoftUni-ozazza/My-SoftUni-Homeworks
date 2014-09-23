import java.util.Scanner;

public class _01_SymmetricNumbersInRange {

	public static void main(String[] args) {

		Scanner input = new Scanner(System.in);
		System.out.println("Enter range of two numbers between 1 and 999: ");
		int startNum = input.nextInt();
		int endNum = input.nextInt();

		if (startNum < 1 || startNum > 999 || endNum < 1 || endNum > 999) {
			System.out.println("Invalid number");
		} else {

			// if startNum is bigger than endNum - exchange their values
			if (startNum > endNum) {
				int num = startNum;
				startNum = endNum;
				endNum = num;
			}

			checkForSymmetryInRange(startNum, endNum);
		}
	}

	private static void checkForSymmetryInRange(int startNum, int endNum) {
		
		// count the numbers from startNum to endNum
		for (int i = startNum; i <= endNum; i++) {

			// cast int to string and check
			// the first and last digit/char of the string for symmetry
			String numberStr = Integer.toString(i);
			printIfSymmetric(numberStr);
		}
	}

	private static void printIfSymmetric(String numberStr) {
		boolean symmetric = numberStr.charAt(numberStr.length() - 1) == numberStr.charAt(0);
		if (symmetric) {
			System.out.print(numberStr + " ");
		}
	}
}
