def rectangle(height, width):
    area = height * width
    perimeter = 2 * (height + width)
    if height == width or abs(height - width) > 5:
        return area
    else:
        return perimeter

def triangle(height, base):
    area = 0.5 * height * base
    perimeter = 2 * height + base
    return area, perimeter

def print_triangle(height, base):
    x = base // 2
    y = height // x
    z = base % x
    rows = ((height + 1) // 2)
    star = '*'
    print(star.center(base, ' '))
    if z != 0:
        star = '*' * 3
        for _ in range(z):
            print(star.center(base, ' '))
    stars = 1
    for i in range(1, rows - 2):
        star = '*' * (stars + 2)
        for _ in range(y):
            print(star.center(base, ' '))
        stars = stars + 2
    star = '*' * (base)
    print(star.center(base, ' '))

def main():
    while True:
        print("Choose an option:")
        print("1. Build a rectangle tower")
        print("2. Build a triangle tower")
        print("3. Exit")
        choice = input()
        if choice == "1":
            height = int(input("Enter the height of the rectangle: "))
            width = int(input("Enter the width of the rectangle: "))
            print(rectangle(height, width))
        elif choice == "2":
            height = int(input("Enter the height of the triangle: "))
            base = int(input("Enter the base of the triangle: "))
            print("Choose an option:")
            print("1. Calculation of the perimeter of the triangle")
            print("2. Printing the triangle")
            choice = input()
            if choice == "1":
                print(triangle(height, base)[1])
            elif choice == "2":
                if base % 2 != 0 and base < height * 2:
                    print_triangle(height, base)
                else:
                    print("Invalid base. Can't print the triangle")
        elif choice == "3":
            print("Exiting the program")
            break
        else:
            print("Invalid choice. Please chose 1, 2, 3.")

if __name__ == '__main__':
    main()