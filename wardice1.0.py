###############################
#This is where we import the libraries we need
###############
import random
###############################
#This is where we assign the values of the variables we need
###############
dfourP1 = random.randint(1,4)
dsixP1 = random.randint(1,6)
deightP1 = random.randint(1,8)
dtenP1 = random.randint(1,10)
dtwelveP1 = random.randint(1,12)
dtwentyP1 = random.randint(1,20)
dfourP2 = random.randint(1,4)
dsixP2 = random.randint(1,6)
deightP2 = random.randint(1,8)
dtenP2 = random.randint(1,10)
dtwelveP2 = random.randint(1,12)
dtwentyP2 = random.randint(1,20)
playeronewins = 0
playertwowins = 0
wins = 0
###############################
#This is where we populate the lists we need
###############
dicelistp1 = [dfourP1, dsixP1, deightP1, dtenP1, dtwelveP1, dtwentyP1]
dicenamelistp1 = [4,6,8,10,12,20]
dicelistp2 = [dfourP2, dsixP2, deightP2, dtenP2, dtwelveP2, dtwentyP2]
dicenamelistp2 = [4,6,8,10,12,20]
print "First entrant, sign your name!"
playerone = raw_input()
print "Second contender, declare yourself!"
playertwo = raw_input()
###############################
#This loop is effectlively the game.
################
while wins <= 2:
    print playerone, ", choose the number of sides on your dice", dicenamelistp1, "."
###############################
#This code handles the first players roll.
################
    dicechoicep1 = int(raw_input())
    if dicechoicep1 in dicenamelistp1:
        print "You have laid your hand upon your", dicechoicep1, "sided dice"
        diep1 = dicenamelistp1.index(dicechoicep1)
        dicerollp1 = dicelistp1[diep1]
        print "You have made bold to roll a ", dicelistp1[diep1]
        print "You no longer have your", dicechoicep1, "sided die"
    else:
        print "That is not a correct response."
    print playertwo, ", choose the number of sides on your dice", dicenamelistp2, "."
###############################
#This code handles the second players roll.
################
    dicechoicep2 = int(raw_input())
    if dicechoicep2 in dicenamelistp2:
        print "You have taken up your", dicechoicep2, "sided dice"
        diep2 = dicenamelistp2.index(dicechoicep2)
        dicerollp2 = dicelistp2[diep2]
        print "You have rolled a ", dicelistp2[diep2]
        print "You no longer have your", dicechoicep2, "sided die"
    else:
        print "That is not a correct response."
    #print dicelistp2
    #print dicenamelistp2
#add if one is rolled that player wins##DevNote##
###############################
#These if statements handle the winners, and also determine the end of the game.
################
    if dicerollp1 is dicerollp2:
        print "It is declared a draw! Neither warrior advances!"
    if dicerollp1 > dicerollp2:
        print playerone, "has taken the day!"
        playeronewins += 1
        print playerone, "has gained", playeronewins, "victories"
    if dicerollp1 < dicerollp2:
        print playertwo, "has triumphed"
        playertwowins += 1
        print playertwo, "holds", playertwowins, "victories!"
    wins = playeronewins + playertwowins
    if wins is 3:
        print playerone, "-", playeronewins, "-"
        print playertwo, "-", playertwowins, "-"
        print "Press any key and hit enter to quit."
###############################
#Here the dice chosen by the players are removed from play
################
    del dicenamelistp1[diep1]
    del dicenamelistp2[diep2]
    del dicelistp1[diep1]
    del dicelistp2[diep2]
    print "########################"
    raw_input("Press enter to continue: ")
    print "########################"


