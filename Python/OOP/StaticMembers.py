class Dog:
    count = 0 #static variable

    def __init__(self, name):
        self.name = name
        Dog.count += 1

    @staticmethod
    def current_count():
        print(Dog.count)

dog1 = Dog("dog1")
dog2 = Dog("dog2")

print(Dog.count)
# print(dog1.count) # also accessible with instance

Dog.current_count()
# dog2.current_count() # also accessible with instance