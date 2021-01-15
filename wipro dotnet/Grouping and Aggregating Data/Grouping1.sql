select * from employee Where salary=(select min(salary) from employee)
