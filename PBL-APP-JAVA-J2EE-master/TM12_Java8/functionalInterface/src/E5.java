import java.io.*;
import java.util.function.Predicate;
import java.util.*;
import java.util.stream.*;
public class E5 {
	public static boolean checkSquare(Double x) {
		Double sb = Math.sqrt(x);
		return (sb-Math.floor(sb)==0);
	}
	public static void main(String args[]) {
		Predicate<Double> t = x->checkSquare(x);
		ArrayList<Double> al = new ArrayList<>();
		al.add(4.0);
		al.add(25.0);
		al.add(45.0);
		al.add(83.0);
		al.add(99.0);
		al.add(121.0);
		al.add(143.0);
		al.add(100.0);
		al.add(123.0);
		al.add(169.0);
		List<Double> list = al.stream().filter(t).collect(Collectors.toList());
		list.forEach(System.out::println);
	}
}
