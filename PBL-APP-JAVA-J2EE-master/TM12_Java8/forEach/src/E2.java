import java.io.*;
import java.util.*;
class Employee{
	public int id;
	public String name;
	public String address;
	public double salary;
	Employee(int id, String name, String address, double salary){
		this.id=id;
		this.name=name;
		this.address=address;
		this.salary=salary;		
	}
	public void printEmp() {
		System.out.println("ID: "+id+"  Name: "+name+"  Address: "+address+"  Salary: "+salary);
	}
}
public class E2 {
	public static void main(String args[]) {
		ArrayList<Employee> al = new ArrayList<>();
		Employee e1 = new Employee(1,"Naman","Lucknow",45000);
		Employee e2 = new 
Employee(2,"Gagan","Delhi",30000);
		Employee e3 = new Employee(3,"Raksha","Gujrat",60000);
		Employee e4 = new Employee(4,"Shikhar","Lucknow",60000);
		Employee e5 = new Employee(5,"Chhavi","Haryana",50000);
		al.add(e1);
		al.add(e2);
		al.add(e3);
		al.add(e4);
		al.add(e5);
		al.forEach(n->n.printEmp());
	}
}
