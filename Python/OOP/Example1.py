class Paper:
    def method2(self):
        print("Paper 2")

    def method3(self):
        print("Paper 3")
        self.method2()  # This will call the most derived class's method2


class Clip(Paper):
    def method2(self):
        print("Clip 2")
        super().method2()  # Equivalent to base.Method2() in C#


class Stapler(Clip):
    def method1(self):
        print("Stapler 1")

    def method2(self):
        print("Stapler 2")


class Pen(Paper):
    def method1(self):
        print("Pen 1")

    def method2(self):
        print("Pen 2")


def run():
    # Creating instances
    var1 = Pen()  # Paper var1 = new Pen();
    var2 = Stapler()  # Stapler var2 = new Stapler();
    var3 = Stapler()  # Paper var3 = new Stapler();
    var4 = Paper()  # Paper var4 = new Paper();
    var5 = Stapler()  # object var5 = new Stapler();
    var6 = Clip()  # Paper var6 = new Clip();

    # Method calls
    var1.method2()  # var1.Method2();
    var2.method2()  # var2.Method2();
    var3.method2()  # var3.Method2();
    var4.method2()  # var4.Method2();
    var5.method2()  # ((Paper)var5).Method2();
    var6.method2()  # var6.Method2();

    var1.method1()  # ((Pen)var1).Method1();
    var2.method1()  # var2.Method1();
    var3.method1()  # ((Stapler)var3).Method1();

    var1.method3()  # var1.Method3();
    var2.method3()  # var2.Method3();
    var3.method3()  # var3.Method3();
    var4.method3()  # var4.Method3();

    var1.method1()  # ((Pen)var1).Method1();
    var3.method1()  # ((Stapler)var3).Method1();
    var3.method3()  # ((Clip)var3).Method3();

    var5.method1()  # ((Clip)var5).Method1();
    var5.method1()  # ((Pen)var5).Method1();

    var6.method2()  # ((Clip)var6).Method2();
    var6.method3()  # ((Stapler)var6).Method3();


if __name__ == "__main__":
    run()