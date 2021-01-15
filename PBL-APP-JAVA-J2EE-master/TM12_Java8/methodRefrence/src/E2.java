import java.io.*;
import java.util.*;
interface myRefernce{
	int dodigitCount(int n);
}
class staticInst{
	public static int digitCount(int n) {
		return String.valueOf(n).length();
	}
}
public class E2 {
	public static void main(String args[]) {
		myRefernce myref = staticInst::digitCount;
		System.out.println(myref.dodigitCount(5648));
	}
}
