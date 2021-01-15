import java.io.*;
import java.util.*;
public class E1 {
	public static void main(String args[]) {
		ArrayList<String> al = new ArrayList<>();
		al.add("Monday");
		al.add("Tuesday");
		al.add("Wednesday");
		al.add("Thursday");
		al.add("Friday");
		al.add("Saturday");
		al.add("Sunday");
		al.forEach(n->System.out.println(n));
	}
}
