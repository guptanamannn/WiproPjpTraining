import java.io.*;
import java.util.function.Consumer;
import java.util.*;
import java.util.stream.*;
public class E6 {
	public static String reverse(String s) {
		StringBuffer sb = new StringBuffer(s);
		return String.valueOf(sb.reverse());
	}
	public static void main(String args[]) {
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
		Consumer<String> t = (s)->System.out.println(s);
		Consumer<List<String>> t1 = list->{
			for(int i=0;i<list.size();i++) {
				list.set(i,reverse(list.get(i)));
			}
		};
		t1.accept(al);
		al.forEach(n->t.accept(n));
	}
}
