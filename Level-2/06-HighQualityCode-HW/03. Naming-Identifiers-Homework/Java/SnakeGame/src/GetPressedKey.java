import java.awt.event.KeyEvent;
import java.awt.event.KeyListener;

public class GetPressedKey implements KeyListener {

	public GetPressedKey(Game game) {
		game.addKeyListener(this);
	}

	public void keyPressed(KeyEvent keyEvent) {
		int keyCode = keyEvent.getKeyCode();

		if (keyCode == KeyEvent.VK_W || keyCode == KeyEvent.VK_UP) {
			if (Game.mySnake.getVelocityY() != 20) {
				Game.mySnake.setVelocityX(0);
				Game.mySnake.setVelocityY(-20);
			}
		}
		if (keyCode == KeyEvent.VK_S || keyCode == KeyEvent.VK_DOWN) {
			if (Game.mySnake.getVelocityY() != -20) {
				Game.mySnake.setVelocityX(0);
				Game.mySnake.setVelocityY(20);
			}
		}
		if (keyCode == KeyEvent.VK_D || keyCode == KeyEvent.VK_RIGHT) {
			if (Game.mySnake.getVelocityX() != -20) {
				Game.mySnake.setVelocityX(20);
				Game.mySnake.setVelocityY(0);
			}
		}
		if (keyCode == KeyEvent.VK_A || keyCode == KeyEvent.VK_LEFT) {
			if (Game.mySnake.getVelocityX() != 20) {
				Game.mySnake.setVelocityX(-20);
				Game.mySnake.setVelocityY(0);
			}
		}

		// Other controls
		if (keyCode == KeyEvent.VK_ESCAPE) {
			System.exit(0);
		}
	}

	public void keyReleased(KeyEvent e) {
	}

	public void keyTyped(KeyEvent e) {

	}

}
