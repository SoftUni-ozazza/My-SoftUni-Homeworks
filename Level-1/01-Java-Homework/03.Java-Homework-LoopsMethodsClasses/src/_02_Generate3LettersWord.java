import java.util.ArrayList;
import java.util.List;
import java.util.Scanner;

//	Problem 2. Generate 3-Letter Words
//Write a program to generate and print all 3-letter words consisting of given set of characters. 
//For example if we have the characters 'a' and 'b', all possible words 
//will be "aaa", "aab", "aba", "abb", "baa", "bab", "bba" and "bbb". 
//The input characters are given as string at the first line of the input. 
//Input characters are unique (there are no repeating characters).

public class _02_Generate3LettersWord {
	public static void main(String[] args) {
		Scanner input = new Scanner(System.in);

		List<String> container = generatePossible3WordCombinations(input);
		printPossibleWordCombinations(container);
		input.close();
	}

	private static List<String> generatePossible3WordCombinations(Scanner input) {
		String letters = input.nextLine();
		List<String> container = new ArrayList<String>();

		String word = "";
		for (int l = 0; l < letters.length(); l++) {
			for (int m = 0; m < letters.length(); m++) {
				for (int n = 0; n < letters.length(); n++) {

					word = "" + letters.charAt(l) + letters.charAt(m)
							+ letters.charAt(n);
					checkIfNoDublicateWordsAndAddToArrayList(container, word);
				}
			}
		}
		return container;
	}

	private static void checkIfNoDublicateWordsAndAddToArrayList(
			List<String> container, String word) {
		if (container.contains(word) == false) {
			container.add(word);
		}
	}

	private static void printPossibleWordCombinations(List<String> container) {
		for (String i : container) {
			System.out.print(i + " ");
		}
	}
}
