import java.io.*;
import java.util.*;
public class E1 {
	public static void main(String args[]) {
		Random rand = new Random();
		ArrayList<Integer> al = new ArrayList<>();
		for(int i =0;i<25;i++) {
			al.add(rand.nextInt(1000));
		}
		al.forEach(n->{
			int flag=0;
			for(int j=2;j<=n/2;j++) {
				if(n%j==0) {
					flag=1;
					break;
				}
			}
			if(flag==0&&n>2) {
				System.out.println(n);
			}
		});
	}
}
