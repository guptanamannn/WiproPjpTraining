import java.io.*;
import java.time.*;
import java.util.*;
public class E4 {
	public static void main(String args[]) {
		LocalDate ld = LocalDate.now();
		if(ld.isLeapYear()) {
			System.out.println("This Year is a Leap Year");
		}else {
			System.out.println("Not a Leap year");
		}
	}
}
