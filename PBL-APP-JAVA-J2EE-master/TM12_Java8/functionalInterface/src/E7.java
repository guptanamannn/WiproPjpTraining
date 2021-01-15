import java.io.*;
import java.util.function.Consumer;
import java.util.*;
import java.util.stream.*;
public class E7 {
	public static void main(String args[]) {
		ArrayList<Integer> al = new ArrayList<>();
		Consumer<List<Integer>> c2 = list->{
			for(int i=0;i<list.size();i++) {
				if(list.get(i)%2==0) {
					System.out.println(list.get(i)+" Even");
				}
				else {
					System.out.println(list.get(i)+" Odd");
				}
			}
		};
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
		c2.accept(al);
	}

}
