import random
masterdice = ["4", "6", "8", "10", "12", "20"]

player1wins = 0
player2wins = 0
gamesplayed = 0
gameplaying = True

playerone = raw_input("First entrant, sign your name: ")
playertwo = raw_input("Second contender, declare yourself: ")

def getDice(player, list):
	print list
	choice = raw_input(player + " choose the dice or press q to quit: ")
	while (choice not in list and choice != 'q'):
		choice = raw_input(player + " choose the dice or press q to quit: ")
	return choice
	
def checkQuit(input):
	if (input == 'q'):
		gameplaying = False
		gameover = True
		return True
	return False
	
def dice(choice, list):
	list.remove(choice)
	if len(list) == 0:
		list = masterdice[:]
	
	return random.randint(1, int(choice))
	
while gameplaying:
	player1dice = masterdice[:]
	player2dice = masterdice[:]
	player1roundwins = 0
	player2roundwins = 0
	gameover = False
			
	while not gameover:
		dicechoicep1 = getDice(playerone, player1dice)
		if checkQuit(dicechoicep1):
			gameplaying = False
			break
		
		dicechoicep2 = getDice(playertwo, player2dice)
		if checkQuit(dicechoicep2):
			gameplaying = False
			break
			
		p1Roll = dice(dicechoicep1, player1dice)
		p2Roll = dice(dicechoicep2, player2dice)
		
		print playerone, "rolls: ", p1Roll, "-", playertwo, "rolls: ", p2Roll

		if p1Roll < p2Roll:
			if p1Roll == 1:
				gameover = True
				player1roundwins = 2
				print playerone, "is lucky and won this game."
			else:
				if p1Roll == 2:
					player1roundwins -= 1
				player2roundwins += 1
				print playertwo, "has won this round"
		elif p1Roll > p2Roll:
			if p2Roll == 1:	
				gameover = True
				player2roundwins = 2
				print playertwo, "is lucky and won this game."
			else:
				if p2Roll == 2:
					player2roundwins -= 1
					
				player1roundwins += 1
				print playerone, "has won this round"
		else:
			print "You guys have tied!"
			
		gamesplayed += 1
		
		print
		print playerone, " wins:", player1roundwins, "-", playertwo, " wins:", player2roundwins
		print
		
		def won(player, rounds, wins):
			if (rounds == 2 or rounds == -1):
				print player, "has won this game!"
				wins += 1
				return True
			return False
			
		won(player, player1roundwins, player1wins)
		won(player, player2roundwins, player2wins)
			
	print playerone, "Games won:", player1wins, "-", playertwo, "Games won:", player2wins
