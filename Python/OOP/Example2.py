class Gandalf:
    def method1(self):
        print("Gandalf 1")

    def method2(self):
        print("Gandalf 2")
        self.method1()


class Bilbo(Gandalf):
    def method1(self):
        print("Bilbo 1")


class Frodo(Bilbo):
    def method1(self):
        print("Frodo 1")
        super().method1()

    def method3(self):
        print("Frodo 3")


class Gollum(Gandalf):
    def method3(self):
        print("Gollum 3")


def run():
    # Object creation
    var1 = Frodo()
    var2 = Bilbo()
    var3 = Gandalf()
    var4 = Bilbo()
    var5 = Frodo()
    var6 = Gollum()

    print("\nFirst set of method1() calls:")
    var1.method1()
    var2.method1()
    var3.method1()
    var4.method1()
    var5.method1()
    var6.method1()

    print("\nSecond set of method2() calls:")
    var1.method2()
    var2.method2()
    var3.method2()
    var4.method2()
    var5.method2()
    var6.method2()

    print("\nAdditional method calls:")
    # These will raise AttributeError if methods don't exist
    var1.method2()
    var4.method1()
    var6.method2()
    var4.method1()
    var5.method3()


if __name__ == "__main__":
    run()