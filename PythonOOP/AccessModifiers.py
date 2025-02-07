class User:
    def __init__(self, name, username, email, password):
        self.name = name
        self._username = username # protected. still accessible outside class.
        self.email = email
        self.__password = password # private. not accessible outside class.

    def get_username(self):
        return self._username

    def get_password(self):
        return self.__password

    @property
    def username(self):
        print("accessing username through getter property")
        return self._username

    @property
    def password(self):
        print("accessing password through getter property")
        return self.__password

    @username.setter
    def username(self, new_username):
        print("setting username through setter property")
        self._username = new_username

user = User(name="user one", username="user.one", email="user.one@gmail.com", password="u53r1@")

print(user.name)
print(user.email)
# print(user._username) # accessible here.
print(user.get_username())
# print(user.__password) # not accessible.
# print(user._User__password) # private variables are accessible like this.

print(user.username)
print(user.password)

user.username = "new.user.one"
print(user.username)
