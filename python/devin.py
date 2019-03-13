# jeu du devin

import random

def trouver(nombre):
    if nombre < rdm:
        res = "trop petit"
    if nombre > rdm:
        res = "trop grand"
    if nombre == rdm:
        res = "\n BRAVO !"
    return res

print("##### TROUVES MOI #####")
rdm = random.randint(0,100)
nombre = 101
while rdm != nombre:
    nombre = int(input("nombre : "))
    resultat = trouver(nombre)
    print("",resultat)
