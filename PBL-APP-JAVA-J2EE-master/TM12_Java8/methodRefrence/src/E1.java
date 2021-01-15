interface myReference{
	int dofactorial(int n);
}
class InstanceRef{
	public int factorial(int n) {
		if(n==0||n==1) {
			return 1;
		}
		return n*(factorial(n-1));
	}
}
public class E1 {
	public static void main(String args[]) {
		InstanceRef r1 = new InstanceRef();
		myReference newr = r1::factorial;
		System.out.println(newr.dofactorial(5));
	}
}
