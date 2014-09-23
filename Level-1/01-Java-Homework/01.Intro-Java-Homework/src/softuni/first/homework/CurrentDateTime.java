package softuni.first.homework;
import java.text.SimpleDateFormat;
import java.util.Date;


public class CurrentDateTime {
	public static void main(String[] args){
		
		SimpleDateFormat dateTime = new SimpleDateFormat("yyyy/MM/dd HH:mm");
		Date dateNow = new Date();
		String strDateTime = dateTime.format(dateNow);
		System.out.println(strDateTime);
	}

}
