import java.io.*;
import java.util.*;
public class E3 {
	public static void main(String args[]) {
		int[] al = new int[] {10,56,1,32,55,46,98,86,76,53};
		Arrays.parallelSort(al,0,5);
		for(int i =0;i<al.length;i++) {
			System.out.print(al[i]+" ");
		}
		System.out.println();
	}
}
