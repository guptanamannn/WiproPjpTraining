import java.io.*;
import java.util.*;
import java.util.stream.*;
public class E1 {
	public static void main(String args[]) {
		ArrayList<Integer> al = new ArrayList<>();
		al.add(85);
		al.add(-8);
		al.add(19);
		al.add(63);
		al.add(-585);
		al.add(30);
		List<Integer> list = al.stream()
				.filter(x-> x < 0)
				.filter(x->x%2==0)
				.collect(Collectors.toList());
		System.out.println(list);
	}
}
