import java.io.*;
import java.util.*;
interface Test{
	int myFunction(int x,int y,int z);
}
class LambdaAndTest{
	public int operate(int x,int y,int z, Test ref) {
		return ref.myFunction(x,y,z);
	}
}
public class E2 {
	public static void main(String args[]) {
		LambdaAndTest t1 = new LambdaAndTest();
		Test addOperation = (int x,int y,int z)->(x+y+z);
		System.out.println("Add Operation: "+t1.operate(6,3,9,addOperation));

		Test multiplyOperation = (int x,int y,int z)->(x*y*z);
		System.out.println("Multiply Operation: "+t1.operate(6,3,9,multiplyOperation));
	}

}
