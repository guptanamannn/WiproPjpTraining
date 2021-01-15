import java.io.*;
import java.util.*;
public class E3 {
	public static void main(String args[]) {
		ArrayList<String> al = new ArrayList<>();
		al.add("Hello");
		al.add("This");
		al.add("Is");
		al.add("Naman");
		al.add("Gupta");
		al.add("9639556");
		al.add("Wipro");
		al.add("Technologies");
		al.add("LTD");
		al.add("Pune");
		al.forEach(n->{
			if(n.length()%2!=0) {
				System.out.println(n);
			}
		});
	}
}
