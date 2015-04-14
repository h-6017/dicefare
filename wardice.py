import random

dfour = random.randint(1,4)
dsix = random.randint(1,6)
deight = random.randint(1,8)
dten = random.randint(1,10) 
dtwelve = random.randint(1,12)
dtwenty = random.randint(1,20)


playerone = raw_input()
playertwo = raw_input()
#playerthree = raw_input()

dicelistp1 = [dfour, dsix, deight, dten, dtwelve, dtwenty]
dicenamelistp1 = [4,6,8,10,12,20]
dicelistp2 = [dfour, dsix, deight, dten, dtwelve, dtwenty]
dicenamelistp2 = [4,6,8,10,12,20]
print "Choose the number of sides on your dice", dicenamelistp1

dicechoicep1 = int(raw_input())


#print dicechoice

#this is for player one
if dicechoicep1 in dicenamelistp1:
    print "You have chosen your", dicechoicep1, "sided dice"
#    print dicenamelist.index(dicechoice)
    diep1 = dicenamelistp1.index(dicechoicep1)
    dicerollp1 = dicelistp1[diep1]
    print "You rolled a ", dicelistp1[diep1]
    print "You no longer have your", dicechoicep1, "sided die"
    del dicenamelistp1[diep1]
    del dicelistp1[diep1]
else:
    print "That is not a correct response."
print dicelistp1
print dicenamelistp1

dicechoicep2 = int(raw_input())

#this is for player 2
if dicechoicep2 in dicenamelistp2:
    print "You have chosen your", dicechoicep2, "sided dice"
#    print dicenamelist.index(dicechoice)
    diep2 = dicenamelistp2.index(dicechoicep2)
    dicerollp2 = dicelistp2[diep2]
    print "You rolled a ", dicelistp2[diep2]
    print "You no longer have your", dicechoicep2, "sided die"
    del dicenamelistp2[diep2]
    del dicelistp2[diep2]
else:
    print "That is not a correct response."
print dicelistp2
print dicenamelistp2
raw_input()


#print dicelist
