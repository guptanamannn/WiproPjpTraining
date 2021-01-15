import java.io.*;
import java.util.*;
public class E2 {
	public static void main(String args[]) {
		String[] str = new String[]{"Vellore","Pune","Mumbai","Calcutta"};
		String[] str1 = new String[]{"Hyderabad","Delhi","Chandigarh","Panipat"};
		StringJoiner sj = new StringJoiner("-");
		StringJoiner sj1 = new StringJoiner("-");
		for(int i=0;i<str.length;i++) {
			sj.add(str[i]);
			sj1.add(str1[i]);
		}
		System.out.println(sj.merge(sj1));
		System.out.println(sj1.merge(sj));
	}
}
