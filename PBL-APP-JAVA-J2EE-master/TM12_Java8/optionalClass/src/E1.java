import java.io.*;
import java.util.*;
public class E1 {
	public static void main(String args[]) {
		String[] name = new String[5];
		Optional<String> op = Optional.ofNullable(name[0]);
		if(op.isPresent()) {
			System.out.println(op.get().length());
		}
	}
}
