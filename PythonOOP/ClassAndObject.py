class Employee:
    def __init__(self, name, id, dept):
        self.name = name
        self.id = id
        self.dept = dept

    def info(self):
        print(f"ID: {self.id}\nName: {self.name}\nDepartment: {self.dept.name}")

class Department:
    def __init__(self, name, id):
        self.name = name
        self.id = id

    def info(self):
        print(f"Name: {self.name}\nID: {self.id}")


acc = Department(name="Accounts", id="d1")
hr = Department(name="HR", id="d2")

john = Employee(name="John", id="e1", dept=acc)
alen = Employee(name="Allen", id="e2", dept=hr)

# john = alen
# above line does not create a clone of the alen object and assign to john.
# it just copies the memory location of alen to john so now, john and alen object
# points to same memory location. so, if john's name is changed alen's name will be
# changed too

alen.info()
john.info()