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

dicelist = [dfour, dsix, deight, dten, dtwelve, dtwenty]
dicenamelist = [4,6,8,10,12,20]
print "Choose the number of sides on your dice", dicenamelist

dicechoice = int(raw_input())

#print dicechoice
if dicechoice in dicenamelist:
    print "You have chosen your", dicechoice, "sided dice"
#    print dicenamelist.index(dicechoice)
    die = dicenamelist.index(dicechoice)
    print "You rolled a ", dicelist[die]
    print "You no longer have your", dicechoice, "sided die"
    del dicenamelist[die]
    del dicelist[die]
else:
    print "That is not a correct response."
print dicelist
print dicenamelist

raw_input()


#print dicelist
