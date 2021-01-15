import java.io.*;
import java.util.*;
public class E1 {
	public static void main(String args[]) {
		String[] str = new String[]{"Raj","Varshit","Gaurav","Ved","Reena"};
		StringJoiner sj = new StringJoiner(",","{","}");
		for(int i=0;i<str.length;i++) {
			sj.add(str[i]);
		}
		System.out.println(sj);
	}
}
