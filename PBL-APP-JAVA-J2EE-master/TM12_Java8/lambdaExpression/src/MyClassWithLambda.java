import java.io.*;
import java.util.*;
interface WordCount{
	int count(String str);
}
public class MyClassWithLambda {
	public static void main(String args[]) {
		WordCount wc = str->{
			String[] arr = str.split(" ");
			return arr.length;
		};
		int l = wc.count("Naman Gupta 9639556");
		System.out.println(l);
	}
}
