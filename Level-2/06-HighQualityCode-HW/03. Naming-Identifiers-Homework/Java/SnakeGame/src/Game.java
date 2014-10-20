import java.awt.Canvas;
import java.awt.Dimension;
import java.awt.Graphics;

@SuppressWarnings("serial")
public class Game extends Canvas implements Runnable {
	public static Snake mySnake;
	public static Apple myApple;
	static int point;

	private Graphics globalGraphics;
	private Thread runThread;
	public static final int WIDTH = 600;
	public static final int HEIGHT = 600;
	private final Dimension gameDimension = new Dimension(WIDTH, HEIGHT);

	static boolean gameRunning = false;

	public void paint(Graphics gameGraphic) {
		this.setPreferredSize(gameDimension);
		globalGraphics = gameGraphic.create();
		point = 0;

		if (runThread == null) {
			runThread = new Thread(this);
			runThread.start();
			gameRunning = true;
		}
	}

	public void run() {
		while (gameRunning) {
			mySnake.moveSnake();
			render(globalGraphics);
			try {
				Thread.sleep(100);
			} catch (Exception e) {
				// TODO: exception
			}
		}
	}

	public Game() {
		mySnake = new Snake();
		myApple = new Apple(mySnake);
	}

	public void render(Graphics g) {
		g.clearRect(0, 0, WIDTH, HEIGHT + 25);
		g.drawRect(0, 0, WIDTH, HEIGHT);
		mySnake.drawSnake(g);
		myApple.drawApple(g);
		g.drawString("score= " + point, 10, HEIGHT + 25);
	}
}
