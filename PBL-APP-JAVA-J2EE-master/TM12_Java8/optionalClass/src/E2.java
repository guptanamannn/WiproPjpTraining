import java.io.*;
import java.util.*;
public class E2 {
	String address;
	String defaultv = "India";
	public static void main(String args[]) {
		E2 e = new E2();
		Optional<String> op = Optional.ofNullable(e.address);
		System.out.println(op.orElse(e.defaultv));
	}
}
