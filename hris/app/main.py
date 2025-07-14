from .models import Employee, Leave

employees = []

def create_employee(name, age, position):
    employee = Employee(name, age, position)
    employees.append(employee)
    return employee

def get_employees():
    return employees

def get_employee(name):
    for employee in employees:
        if employee.name == name:
            return employee
    return None

def update_employee(name, new_age=None, new_position=None):
    employee = get_employee(name)
    if employee:
        if new_age:
            employee.age = new_age
        if new_position:
            employee.position = new_position
        return employee
    return None

def delete_employee(name):
    employee = get_employee(name)
    if employee:
        employees.remove(employee)
        return True
    return False


leaves = []


def request_leave(employee_name, start_date, end_date):
    employee = get_employee(employee_name)
    if employee:
        leave = Leave(employee, start_date, end_date)
        employee.leaves.append(leave)
        leaves.append(leave)
        return leave
    return None


def get_all_leaves():
    return leaves


def approve_leave(leave_id):
    for leave in leaves:
        if id(leave) == leave_id:
            leave.status = "Approved"
            return leave
    return None


def reject_leave(leave_id):
    for leave in leaves:
        if id(leave) == leave_id:
            leave.status = "Rejected"
            return leave
    return None

def main():
    while True:
        print("\n1. Create employee")
        print("2. View all employees")
        print("3. View employee")
        print("4. Update employee")
        print("5. Delete employee")
        print("6. Request leave")
        print("7. View all leave requests")
        print("8. Approve leave")
        print("9. Reject leave")
        print("10. Exit")

        choice = input("Enter your choice: ")

        if choice == "1":
            name = input("Enter name: ")
            age = int(input("Enter age: "))
            position = input("Enter position: ")
            create_employee(name, age, position)
            print("Employee created successfully.")
        elif choice == "2":
            all_employees = get_employees()
            for emp in all_employees:
                print(emp)
        elif choice == "3":
            name = input("Enter name: ")
            employee = get_employee(name)
            if employee:
                print(employee)
            else:
                print("Employee not found.")
        elif choice == "4":
            name = input("Enter name: ")
            age = input("Enter new age (leave blank to skip): ")
            position = input("Enter new position (leave blank to skip): ")
            new_age = int(age) if age else None
            update_employee(name, new_age, position or None)
            print("Employee updated successfully.")
        elif choice == "5":
            name = input("Enter name: ")
            if delete_employee(name):
                print("Employee deleted successfully.")
            else:
                print("Employee not found.")
        elif choice == "6":
            employee_name = input("Enter your name: ")
            start_date = input("Enter start date (YYYY-MM-DD): ")
            end_date = input("Enter end date (YYYY-MM-DD): ")
            request_leave(employee_name, start_date, end_date)
            print("Leave requested successfully.")
        elif choice == "7":
            all_leaves = get_all_leaves()
            for leave in all_leaves:
                print(leave)
        elif choice == "8":
            all_leaves = get_all_leaves()
            for i, leave in enumerate(all_leaves):
                print(f"{i}. {leave}")
            leave_index = int(input("Enter leave index to approve: "))
            approve_leave(id(all_leaves[leave_index]))
            print("Leave approved.")
        elif choice == "9":
            all_leaves = get_all_leaves()
            for i, leave in enumerate(all_leaves):
                print(f"{i}. {leave}")
            leave_index = int(input("Enter leave index to reject: "))
            reject_leave(id(all_leaves[leave_index]))
            print("Leave rejected.")
        elif choice == "10":
            break
        else:
            print("Invalid choice.")

if __name__ == "__main__":
    main()
