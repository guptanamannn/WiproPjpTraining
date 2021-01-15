import java.io.*;
import java.util.*;
import java.util.stream.*;
class Employee{
	int empNo;
	String name;
	int age;
	String location;
	Employee(int id,String s,int a, String l){
		this.empNo = id;
		this.name = s;
		this.age = a;
		this.location = l;
	}
	public String toString() {
        return ("EmpID: "+this.empNo+
                " Name: "+ this.name +
                " Age: "+ this.age +
                " Location : " + this.location);
}
}
public class E2 {
	public static void main(String args[]) {
		Employee e1 = new Employee(101,"Shivam",22,"Haryana");
		Employee e2 = new Employee(102,"Aditi",21,"Pune");
		Employee e3 = new Employee(103,"Vasu",20,"Mathura");
		Employee e4 = new Employee(104,"Lakshay",21,"Pune");
		Employee e5 = new Employee(104,"Hari",22,"Mumbai");
		ArrayList<Employee> al = new ArrayList<>();
		al.add(e1);
		al.add(e2);
		al.add(e3);
		al.add(e4);
		al.add(e5);
		List<Employee> list = al.stream().filter(x -> x.location=="Pune").collect(Collectors.toList());
		list.forEach(System.out::println);
	}
}
