import java.io.*;
import java.util.function.Predicate;
import java.util.*;
import java.util.stream.*;
class Employee{
	int empNo;
	String name;
	double Salary;
	Employee(int id,String s,double a){
		this.empNo = id;
		this.name = s;
		this.Salary = a;
	}
	public int getId() {
		return this.empNo;
	}

	public String getName() {
		return this.name;
	}

	public double getSalary() {
		return this.Salary;
	}
	public void setId(int i) {
		this.empNo = i;
	}
	public void setName(String n) {
		this.name = n;
	}
	public void setSalary(Double s) {
		this.Salary = s;
	}
	public String toString() {
		return(getName());
	}
}
public class E4 {
	public static void main(String args[]) {
		Employee e1 = new Employee(101,"Lakshay",50000);
		Employee e2 = new Employee(102,"Manoj",45000);
		Employee e3 = new Employee(103,"Rakhi",8000);
		Employee e4 = new Employee(104,"Varsha",250000);
		Employee e5 = new Employee(105,"Tanmay",15000);
		Employee e6 = new Employee(106,"Raju",5000);
		Employee e7 = new Employee(107,"Akshay",10000);
		Predicate<Employee> t = x->x.getSalary()>10000;
		ArrayList<Employee> al = new ArrayList<>();
		al.add(e1);
		al.add(e2);
		al.add(e3);
		al.add(e4);
		al.add(e5);
		al.add(e6);
		al.add(e7);
		List<Employee> list = al.stream().filter(t).collect(Collectors.toList());
		list.forEach(System.out::println);
	}
}
