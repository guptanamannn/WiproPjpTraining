import java.io.*;
import java.util.*;
public class E1 {
	public static void main(String args[]) {
		int[] al = new int[] {10,56,1,32,55,46,98,86,76,53};
		Arrays.parallelSort(al);
		System.out.println(al[0]+al[al.length-1]);
	}
}
