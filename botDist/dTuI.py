from diceTastic import Game

class UserInterFace(object):
    def __init__(self):
        self.message = None
        self.game = Game()
    def displayScore(self):
        #print(self.game.playerOne.name, "Has", self.game.playerOne.score)
        print("{p1.name} Has {p1.score}".format(p1=self.game.playerOne))
        print("{p2.name} Has {p2.score}".format(p2=self.game.playerTwo))

    def playGame(self):
        notValidDice = True
        playerOne = self.game.acceptPlayerOne(raw_input('Player one, please enter your name: > '))
        playerTwo = self.game.acceptPlayerTwo(raw_input('Player two, please enter your name: > '))
        while self.game.isRunning:
            self.displayScore()
            while self.game.roundIsRunning:
                while notValidDice:
                    diceType1 = self.game.getDiceType(playerOne)
                    if diceType1: break

                roll1 = playerOne.rollDice(diceType1)
                while notValidDice:
                    diceType2 = self.game.getDiceType(playerTwo)
                    if diceType2: break

                roll2 = playerTwo.rollDice(diceType2)
                if 1 in [roll1, roll2]:
                    if roll1 == 1:
                        self.game.declareRoundWin(playerOne)
                    elif roll2 == 1:
                        self.game.declareRoundWin(playerTwo)
                elif roll1 > roll2:
                    self.game.declareRoundWin(playerOne)
                elif roll1 < roll2:
                    self.game.declareRoundWin(playerTwo)
                elif roll1 == roll2:
                    self.game.declareDraw()
                playerOne.removeDiceUsed(diceType1)
                playerTwo.removeDiceUsed(diceType2)
                self.game.isRoundRunning(playerOne, playerTwo)
            self.game.shouldGameContinue(playerOne, playerTwo)




