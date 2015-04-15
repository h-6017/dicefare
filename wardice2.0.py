import random

dfour = random.randint(1,4)
dsix = random.randint(1,6)
deight = random.randint(1,8)
dten = random.randint(1,10)
dtwelve = random.randint(1,12)
dtwenty = random.randint(1,20)




playeronewins = 0
playertwowins = 0
wins = 0
dicelistp1 = [dfour, dsix, deight, dten, dtwelve, dtwenty]
dicenamelistp1 = [4,6,8,10,12,20]
dicelistp2 = [dfour, dsix, deight, dten, dtwelve, dtwenty]
dicenamelistp2 = [4,6,8,10,12,20]

print "First entrant, sign your name!"
playerone = raw_input()
print "Second contender, declare yourself!"
playertwo = raw_input()

while wins <= 6:
    print playerone, ", choose the number of sides on your dice", dicenamelistp1, "."
    dicechoicep1 = int(raw_input())
    if dicechoicep1 in dicenamelistp1:
        print "You have laid your hand upon your", dicechoicep1, "sided dice"
        #print dicenamelist.index(dicechoice)
        diep1 = dicenamelistp1.index(dicechoicep1)
        dicerollp1 = dicelistp1[diep1]
        print "You have made bold to roll a ", dicelistp1[diep1]
        print "You no longer have your", dicechoicep1, "sided die"
    else:
        print "That is not a correct response."
    #print dicelistp1
    #print dicenamelistp1

    #this is for player 2
    print playertwo, ", choose the number of sides on your dice", dicenamelistp2, "."
    dicechoicep2 = int(raw_input())
    if dicechoicep2 in dicenamelistp2:
        print "You have taken up your", dicechoicep2, "sided dice"
        #print dicenamelist.index(dicechoice)
        diep2 = dicenamelistp2.index(dicechoicep2)
        dicerollp2 = dicelistp2[diep2]
        print "You have rolled a ", dicelistp2[diep2]
        print "You no longer have your", dicechoicep2, "sided die"
    else:
        print "That is not a correct response."
    #print dicelistp2
    #print dicenamelistp2

#add if one is rolled that player wins

    if dicerollp1 is dicerollp2:
        print "It is declared a draw! Neither warrior advances!"
        del dicenamelistp1[diep1]
        del dicenamelistp2[diep2]
        del dicelistp1[diep1]
        del dicelistp2[diep2]
    elif dicerollp1 > dicerollp2:
        print playerone, "has taken the day!"
        playeronewins += 1
        print playerone, "has gained", playeronewins, "victories"
        del dicenamelistp1[diep1]
        del dicenamelistp2[diep2]
        del dicelistp1[diep1]
        del dicelistp2[diep2]
    elif dicerollp1 < dicerollp2:
        print playertwo, "has triumphed"
        playertwowins = playertwowins + 1
        print playertwo, "holds", playertwowins, "victories!"
        del dicenamelistp2[diep2]
        del dicenamelistp1[diep1]
        del dicelistp2[diep2]
        del dicelistp1[diep1]
    if playeronewins + playertwowins is 3:
        print playerone, "-", playeronewins, "-"
        print playertwo, "-", playertwowins, "-"
        print "Press any key and hit enter to quit."
        raw_input()


