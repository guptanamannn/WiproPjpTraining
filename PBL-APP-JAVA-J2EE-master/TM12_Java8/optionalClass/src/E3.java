import java.io.*;
import java.util.*;
class InvalidEmployeeException extends Exception{    
	   InvalidEmployeeException() {
	   }
	   public String toString(){ 
		return ("InvalidEmployeeException Occurred") ;
	   }
    }
public class E3 {
	String name;
    public static void main(String[] args)throws InvalidEmployeeException{
        E3 e1= new E3();
        Optional<String> n = Optional.ofNullable(e1.name);
        try{
    		System.out.print(n.orElseThrow(() -> new InvalidEmployeeException()));
    	}
    	catch(InvalidEmployeeException exp){
    		System.out.println(exp) ;
    	}
    }

}