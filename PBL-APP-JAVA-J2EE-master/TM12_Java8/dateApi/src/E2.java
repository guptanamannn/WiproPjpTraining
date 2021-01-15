import java.io.*;
import java.time.LocalDate;
import java.util.*;
public class E2 {
	public static void main(String args[]) {
		 LocalDate date = LocalDate.now().plusMonths(1);
		 int count =0;
		 for(int i=0;i<date.lengthOfMonth();i++){
			 	if(count==1) {
			 		break;
			 	}
	            if("Sunday".equalsIgnoreCase(date.getDayOfWeek().toString())){
	                count+=1;
	            }else{
	                date=date.plusDays(1);
	            }
	        }

	        System.out.println(date.getDayOfMonth());
	}
}
