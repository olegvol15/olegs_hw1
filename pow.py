num = int(input("Enter the number: "))
i = 0
while i < num:
    a = i ** 2
    if a > num:
      break
    i += 1
    print(a, end="\t")

