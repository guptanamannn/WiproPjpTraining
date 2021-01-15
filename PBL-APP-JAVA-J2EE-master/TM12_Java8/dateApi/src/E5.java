import java.time.*;
import java.io.*;
import java.util.*;
public class E5 {
	public static void main(String args[]) {
		LocalTime lt = LocalTime.now();
		System.out.println("Time: "+lt);
		System.out.println("After 25mins: "+lt.plusMinutes(25));
	}
}
