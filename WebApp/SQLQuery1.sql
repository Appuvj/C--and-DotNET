alter table employee with check add constraint fk_emp_dept foreign key (Department_ID) references Department(Id)

alter table employee check constraint fk_emp_dept