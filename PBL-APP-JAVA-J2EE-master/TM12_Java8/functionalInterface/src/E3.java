import java.io.*;
import java.util.function.Predicate;
import java.util.*;
import java.util.stream.*;
public class E3 {
	public static String reverse(String s) {
		StringBuffer sb = new StringBuffer(s);
		return String.valueOf(sb.reverse());
	}
	public static void main(String args[]) {
		Predicate<String> t = x->x.equalsIgnoreCase(reverse(x));
		ArrayList<String> al = new ArrayList<>();
		al.add("Tom");
		al.add("Mom");
		al.add("Dad");
		al.add("Wipro");
		al.add("Technologies");
		al.add("Tat");
		al.add("Volvo");
		al.add("Limited");
		al.add("Vishu");
		al.add("Gita");
		List<String> arr = al.stream().filter(t).collect(Collectors.toList());
		arr.forEach(System.out::println);
	}
}
