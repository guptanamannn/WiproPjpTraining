import java.io.*;
import java.util.*;
interface myConsReference{
	void docheckPrime(int n);
}
class paraCons{
	paraCons(int n){
			if(n>2) {
				int flag = 1;
				for(int j=2;j<=n/2;j++) {
					if(n%j==0) {
						flag =0;
						break;
					}
				}
				if(flag==1) {
					System.out.println("Prime");
				}
				else {
					System.out.println("Not Prime");
				}
			}
			else {
				System.out.println("Not Prime");
			}
	}
}
public class E3 {
	public static void main(String args[]) {
		myConsReference pr = paraCons::new;
		pr.docheckPrime(31);	
	}
}
