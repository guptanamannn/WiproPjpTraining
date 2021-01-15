import java.io.*;
import java.time.*;
import java.util.*;
public class E3 {
	public static void main(String[] args) {
        LocalDate day = LocalDate.of(2019, 9, 5);
        LocalDate today = LocalDate.now();
        
        Period tym = Period.between(day, today);
        int years = tym.getYears();
        int months = tym.getMonths();
        int days = tym.getDays();

        System.out.println("number of years: " + years);
        System.out.println("number of months: " + months);
        System.out.println("number of days: " + days);
    }
}
