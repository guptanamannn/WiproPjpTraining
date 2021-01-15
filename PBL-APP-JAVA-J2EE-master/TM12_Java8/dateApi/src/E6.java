import java.time.*;
import java.io.*;
import java.util.*;
public class E6 {
	public static void main(String args[]) {
		LocalTime lt = LocalTime.now();
		System.out.println("Time: "+lt);
		System.out.println("After 5hr and 30mins: "+lt.plusHours(5).plusMinutes(30));
	}
}
