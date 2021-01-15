package com.wipro.jsp_bean;

public class employ {
	private String name;
	int id;
	public void setName(String n) {
		this.name = n;
	}
	public void setId(String n) {
		this.id = Integer.parseInt(n);
	}
	public String getName() {
		return this.name;
	}
	public String getId() {
		return String.valueOf(this.id);
	}
}
