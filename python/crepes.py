crepe = [35,12,9,65,21,54,78,1,23,14,7,8,22]
rep = 1
bank = 0
for j in range (0,12):
    for i in range (0,12):
        if crepe[i] > crepe[i+1]:
            bank = crepe[i]
            crepe[i] = crepe[i+1]
            crepe[i+1] = bank

print(crepe)
