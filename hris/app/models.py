class Employee:
    def __init__(self, name, age, position):
        self.name = name
        self.age = age
        self.position = position

    def __repr__(self):
        return f"Employee(name='{self.name}', age={self.age}, position='{self.position}')"
