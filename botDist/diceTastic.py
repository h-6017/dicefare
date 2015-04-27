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
            self.roundIsRunning = False
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

    def oneRound(self, answer):
        while self.game.roundIsRunning:
            while notValidDice:
                diceType1 = self.game.getDiceType(playerOne)
                if diceType1: break
            while notValidDice:
                dicetype2 = self.game.getDiceType(playerTwo)
                if diceType2: break
            roll1 = playerOne.rollDice(diceType1)
            roll2 = playerTwo.rollDice(diceType2)

