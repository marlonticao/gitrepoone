class Employee:
    def __init__(self, name, age, position):
        self.name = name
        self.age = age
        self.position = position
        self.leaves = []

    def __repr__(self):
        return f"Employee(name='{self.name}', age={self.age}, position='{self.position}')"


class Leave:
    def __init__(self, employee, start_date, end_date, status="Pending"):
        self.employee = employee
        self.start_date = start_date
        self.end_date = end_date
        self.status = status

    def __repr__(self):
        return f"Leave(employee='{self.employee.name}', start_date='{self.start_date}', end_date='{self.end_date}', status='{self.status}')"
