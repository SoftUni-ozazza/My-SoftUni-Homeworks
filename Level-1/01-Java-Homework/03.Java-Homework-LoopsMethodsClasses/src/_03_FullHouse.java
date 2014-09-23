import java.util.ArrayList;
import java.util.Arrays;
import java.util.Collections;
import java.util.Random;

public class _03_FullHouse {

	public static void main(String[] args) {
		ArrayList<String> suits = new ArrayList<String>(Arrays.asList("♣", "♦",
				"♥", "♠"));
		ArrayList<String> faces = new ArrayList<String>(Arrays.asList("2", "3",
				"4", "5", "6", "7", "8", "9", "10", "J", "Q", "K", "A"));

//		Random randomGen = new Random(); //USELESS
//		int faceInt = randomGen.nextInt(faces.size());
//		int suitInt = randomGen.nextInt(suits.size());
//
//		String faceRandom = faces.get(faceInt);
//		String suitRandom = suits.get(suitInt);

		// places to store each temporary 5 cards in a hand
		ArrayList<String> handFace = new ArrayList<String>();
		ArrayList<String> handCards = new ArrayList<String>();
		int counterHand = 0;
		while (counterHand < 5) {
			handFace.add("");
			handCards.add("");
			counterHand++;
		}

		counterHand = 0;
		int countFullHouse = 0;
		for (int i = 0; i < suits.size(); i++) {
			for (int j = 0; j < faces.size(); j++) {
				
				String suit = suits.get(i);
				String face = faces.get(j);
				
				if (counterHand < 5) {
					handFace.set(counterHand, face);
					handCards.set(counterHand, face + suit);
				} else {
					// int count = Collections.frequency(handFace, handFace.get(m)); // return how many times contains
//					// handFace.get(m);
//					for(String s : handFace){ // REMOVE
//						System.out.print(s + " ");
//					}
//					for(String u : handCards){ // REMOVE
//						System.out.print(u + " ");
//					}
					if (handFace.get(0) == handFace.get(1)
							&& handFace.get(0) == handFace.get(2)) {
						if (handFace.get(0) != handFace.get(3)
								&& handFace.get(3) == handFace.get(4)) {
							for (String card : handCards) {
								System.out.print(card + " ");
							}
							countFullHouse++;
						}
					}
					counterHand = -1;
				}
				counterHand++;
			}
		}
		System.out.println(countFullHouse);
	}
}
