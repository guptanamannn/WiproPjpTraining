package com.wipro.jsp_bean;

public class emp {
	private String name;
	private String id;
	private String destination;
	public void setName(String n) {
		this.name = n;
	}
	public void setId(String n) {
		this.id = n;
	}
	public void setDestination(String n) {
		this.destination = n;
	}
	public String getName() {
		return this.name;
	}

	public String getDestination() {
		return this.destination;
	}
	public String getId() {
		return String.valueOf(this.id);
	}
}
