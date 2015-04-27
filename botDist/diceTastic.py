from dTplayer import Player

class Game(object):
    def __init__(self):
        self.isRunning = True
        self.roundIsRunning = True
        self.message = "Greetings combatants! May you glory in this day!"
        self.playerList = []
        self.masterDiceList = [4,6,8,10,12,20]

    def getDiceType(self, player):
        diceType = int(raw_input('{} Choose the number of faces on your dice > '.format(player.name)))
        if diceType in self.masterDiceList:
            return diceType
        else:
            print("\t{} is not a valid dice! Choose from: {}".format(diceType, ",".join(str(d) for d in self.masterDiceList)))
            return None

    @property
    def playerOne(self):
        for player in self.playerList:
            if player.postion == 1:
                return player
    @property
    def playerTwo(self):
        for player in self.playerList:
            if player.postion == 2:
                return player

    def acceptPlayerOne(self, name):
        playerOne = self._createPlayer(name)
        playerOne.postion = 1
        playerOne.diceList = self.masterDiceList[:]
        return playerOne
    def acceptPlayerTwo(self, name):
        playerTwo = self._createPlayer(name)
        playerTwo.postion = 2
        playerTwo.diceList = self.masterDiceList[:]
        return playerTwo

    def _createPlayer(self, name):
        player = Player()
        player.setName(name)
        self.playerList.append(player)
        return player


    def declareRoundWin(self, player):
        print player.name, "Has triumphed this round!"
        player.score.append("1 point")
        self.endRound()
        return player

    def declareDraw(self):
        print "The round is a draw! Neither player advances!"
        return True

    def endRound(self):
        self.roundIsRunning = False
        return self.roundIsRunning

    def endGame(self):
        self.isRunning = False
        return self.isRunning

    def isRoundRunning(self, p1, p2):
        if len(p1.score) >= 2:
            self.endRound()
            return self.roundIsRunning
        if len(p2.score) >= 2:
            self.roundIsRunning = False
            return self.roundIsRunning
        else:
            self.roundIsRunning = True
            return self.roundIsRunning

    def shouldGameContinue(self, p1, p2):
        if len(p1.gameWins) == 3  or len(p2.gameWins) == 3:
            self.isRunning = False
            return self.isRunning
        else:
            self.isRunning = True
            return self.isRunning

    def oneRound(self, p1, p2):
        notValidDice = True
        while notValidDice:
            print("Getting the first player's die selection...")
            diceType1 = self.getDiceType(p1)
            if diceType1: break
        while notValidDice:
            print("Getting the second player's die selection...")
            diceType2 = self.getDiceType(p2)
            if diceType2: break
        print("We should be able to roll the dice...")
        roll1 = p1.rollDice(diceType1)
        roll2 = p2.rollDice(diceType2)
        if 1 in [roll1, roll2]:
            if roll1 == 1 and roll2 == 1:
                self.declareDraw()
            if roll1 == 1:
                self.declareRoundWin(p1)
            elif roll2 == 1:
                self.declareRoundWin(p2)
        elif roll1 > roll2:
            self.declareRoundWin(p1)
        elif roll1 < roll2:
            self.declareRoundWin(p1)
        elif roll1 == roll2:
            self.declareDraw()
        p1.removeDiceUsed(diceType1)
        p2.removeDiceUsed(diceType2)
        return p1, p2

    def assessRound(self, theRound):
        if 1 in [roll1, roll2]:
            if roll1 == 1 and roll2 == 1:
                self.declareDraw()
            if roll1 == 1:
                self.declareRoundWin(playerOne)
            elif roll2 == 1:
                self.declareRoundWin(playerTwo)
        elif roll1 > roll2:
            self.declareRoundWin(playerOne)
        elif roll1 < roll2:
            self.declareRoundWin(playerTwo)
        elif roll1 == roll2:
            self.declareDraw()
        playerOne.removeDiceUsed(diceType1)
        playerTwo.removeDiceUsed(diceType2)






