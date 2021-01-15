import java.io.*;
import java.util.function.Supplier;
import java.util.*;
import java.util.stream.*;
public class E8 {
	public static void main(String args[]) {
		Supplier<List<Integer>> s1 = ()->{
			ArrayList<Integer> al = new ArrayList<>();
			int i=2;
			int flag;
			while(al.size()<10) {
				flag =0;
				for(int j=2;j<=i/2;j++) {
					if(i%j==0) {
						flag =1;
						break;
					}
				}
				if(flag==0) {
					al.add(i);
				}
				i+=1;
			}
			return al;
		};
		s1.get().forEach(System.out::println);
	}
}
