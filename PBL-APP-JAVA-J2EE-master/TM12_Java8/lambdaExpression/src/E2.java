import java.io.*;
import java.util.*;
public class E2 {
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
			StringBuffer sb = new StringBuffer(n);
			System.out.println(String.valueOf(sb.reverse()));
		});
	}
}
