class Student:
    count = 0 #static variable

    def __init__(self, name):
        self.name = name
        Student.count += 1

    @staticmethod
    def current_count():
        print(Student.count)

s1 = Student("s1")
s2 = Student("s2")
s3 = Student("s3")

print(Student.count)
# print(dog1.count) # also accessible with instance

Student.current_count()
# dog2.current_count() # also accessible with instance