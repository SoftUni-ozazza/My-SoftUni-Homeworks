import java.applet.Applet;
import java.awt.Dimension;
import java.awt.Graphics;

@SuppressWarnings("serial")
public class GameApplet extends Applet {
	private Game newGame;
	GetPressedKey keyPressed;

	public void init() {
		newGame = new Game();
		newGame.setPreferredSize(new Dimension(800, 650));
		newGame.setVisible(true);
		newGame.setFocusable(true);
		this.add(newGame);
		this.setVisible(true);
		this.setSize(new Dimension(800, 650));
		keyPressed = new GetPressedKey(newGame);
	}

	public void paint(Graphics gameGraphic) {
		this.setSize(new Dimension(800, 650));
	}

}
