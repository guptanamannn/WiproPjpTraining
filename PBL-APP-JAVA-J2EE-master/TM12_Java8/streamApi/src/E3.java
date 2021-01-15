import java.io.*;
import java.util.*;
import java.util.stream.*;
class Employe{
	int empNo;
	String name;
	int marks;
	Employe(int id,String s,int a){
		this.empNo = id;
		this.name = s;
		this.marks = a;
	}
	public String toString() {
        return ("EmpID: "+this.empNo+
                " Name: "+ this.name +
                " Marks: "+ this.marks);
}
}
public class E3 {
	public static void main(String args[]) {
		Employe e1 = new Employe(101,"Shivam",60);
		Employe e2 = new Employe(102,"Aditi",42);
		Employe e3 = new Employe(103,"Vasu",71);
		Employe e4 = new Employe(104,"Lakshay",33);
		Employe e5 = new Employe(104,"Hari",59);
		ArrayList<Employe> al = new ArrayList<>();
		al.add(e1);
		al.add(e2);
		al.add(e3);
		al.add(e4);
		al.add(e5);
		long c = al.stream().filter(x -> x.marks>50).count();
		System.out.println(c);
	}
}
