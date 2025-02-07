class Animal:
    def __init__(self, name, species):
        self.name = name
        self.species = species

    def make_sound(self):
        print("Some generic animal sound")

    def describe(self):
        return f"{self.name} is a {self.species}"


class Dog(Animal):
    def __init__(self, name, breed):
        # Call parent class's __init__
        super().__init__(name, species="Dog")
        self.breed = breed

    def make_sound(self):
        print("Woof!")


# Creating instances
generic_animal = Animal("Generic", "Unknown")
my_dog = Dog("Buddy", "Golden Retriever")

print(my_dog.describe())  # Output: Buddy is a Dog
my_dog.make_sound()  # Output: Woof!


class Flying:
    def fly(self):
        print("I can fly!")

    def description(self):
        return "Flying creature"


class Swimming:
    def swim(self):
        print("I can swim!")

    def description(self):
        return "Swimming creature"


class Duck(Flying, Swimming):
    def description(self):
        # Call both parent class methods
        return f"I'm a {Flying.description(self)} and {Swimming.description(self)}"


donald = Duck()
donald.fly()  # Output: I can fly!
donald.swim()  # Output: I can swim!
print(donald.description())

from abc import ABC, abstractmethod

class Shape(ABC):
    @abstractmethod
    def area(self):
        pass

    @abstractmethod
    def perimeter(self):
        pass


class Rectangle(Shape):
    def __init__(self, length, width):
        self.length = length
        self.width = width

    def area(self):
        return self.length * self.width

    def perimeter(self):
        return 2 * (self.length + self.width)


# This would raise an error:
# shape = Shape()  # Can't instantiate abstract class

rect = Rectangle(5, 3)
print(f"Area: {rect.area()}")  # Output: Area: 15
print(f"Perimeter: {rect.perimeter()}")  # Output: Perimeter: 16