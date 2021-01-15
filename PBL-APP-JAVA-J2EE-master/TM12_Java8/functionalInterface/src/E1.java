import java.io.*;
import java.util.ArrayList;
import java.util.function.Consumer;
class Employe{
	int empNo;
	String name;
	String location;
	double Salary;
	Employe(int id,String s,String l,double a){
		this.empNo = id;
		this.name = s;
		this.Salary = a;
		this.location = l;
	}
	public String toString() {
        return ("EmpID: "+this.empNo+
                " Name: "+ this.name +
                " Location: "+ this.location+" Salary: "+this.Salary);
}
}
public class E1 {
	public static void main(String args[]) {
		Consumer<String> c = i->System.out.println(i);
		Employe e1 = new Employe(101,"Shivam","Pune",60000);
		Employe e2 = new Employe(102,"Aditi","Haryana",42000);
		Employe e3 = new Employe(103,"Vasu","Hyderabad",71000);
		Employe e4 = new Employe(104,"Lakshay","Mumbai",33000);
		Employe e5 = new Employe(104,"Hari","Chennai",59000);
		ArrayList<Employe> al = new ArrayList<>();
		al.add(e1);
		al.add(e2);
		al.add(e3);
		al.add(e4);
		al.add(e5);
		al.forEach(n->c.accept(n.location));
	}
}
