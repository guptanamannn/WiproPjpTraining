import java.io.*;
import java.util.*;
public class E2 {
	public static void main(String args[]) {
		Scanner sc = new Scanner(System.in);
		String str =sc.next();
		char[] arr = str.toCharArray();
		Arrays.parallelSort(arr);
		System.out.println(String.valueOf(arr));
	}
}
