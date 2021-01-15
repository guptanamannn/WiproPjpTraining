import java.io.*;
import java.time.LocalDate;
import java.util.*;
public class E1 {
	public static void main(String args[]) {
		LocalDate ld = LocalDate.now();
		System.out.println("Today's Date: "+ld);
		System.out.println("Date After 10 days: "+ld.plusDays(10));
	}
}
