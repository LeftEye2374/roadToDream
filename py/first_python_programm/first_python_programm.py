# ex 1
x = int(input())
y = int(input())
z = int(input())

if x > 0 and y > 0 and z > 0:
    print (x + y + z)
elif x > 0 and y > 0 and z < 0:
    print (x + y)
elif x > 0 and y < 0 and z > 0:
    print (x + z)
elif x < 0 and y > 0 and z > 0:
    print (y + z)

# ex 2

x = int(input())
y = int(input())
z = int(input())
d = int(input())

if x < y and x < z and x < d:
    print(x)
elif y < x and y < z and y < d:
    print(y)
elif z < x and z < y and z < d:
    print(z)
elif d < x and d < y and d < z:
    print(d)

# ex 3

x = int(input())

if x <= 13:
    print('детство')
elif x > 13 and x <= 24:
    print('молодость')
elif x > 24 and x <= 59:
    print('зрелость')
elif x >=60:
    print('старость')

# ex 4

x = int(input())

if x > 0 and x // 2:
    print('положительное четное')
elif x > 0 and x % 2 != 0:
    print('положительное нечетное')
elif x < 0:
    print('отрицательное')
else:
    print('ноль')

# ex 5

a = int(input())
b = int(input())
c = int(input())

if a + b > c:
    print('YES')
elif a + c > b:
    print('YES')
elif b + c > a:
    print('YES')
else:
    print('NO')
