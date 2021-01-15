import java.io.*;
import java.util.*;
import java.util.function.Consumer;
public class E2 {
	public static void main(String args[]) {
		ArrayList<Integer> al = new ArrayList<>();
		Consumer<Integer> c = i->System.out.println(i);
		al.add(10);
		al.add(2);
		al.add(77);
		al.add(43);
		al.add(51);
		al.add(62);
		al.add(75);
		al.add(96);
		al.add(89);
		al.add(15);
		int sum = al.stream().mapToInt(i->i).sum();
		c.accept(sum);
	}
}
