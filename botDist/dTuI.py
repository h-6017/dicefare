from diceTastic import Game
from ui import *
from bot import BotManager

class UserInterFace(object):
    def __init__(self):
        self.message = None
        self.game = Game()
        self.ui = UserInterface()
    def displayScore(self):
        print("{p1.name} Has {p1.score}".format(p1=self.game.playerOne))
        print("{p2.name} Has {p2.score}".format(p2=self.game.playerTwo))

    def playGame(self):
        notValidDice = True
        answer = raw_input("Would You Like to play a game of dice?[y/n]:")
        playerOne = self.game.acceptPlayerOne(raw_input('Player one, please enter your name: > '))
        playerTwo = self.game.acceptPlayerTwo(raw_input('Player two, please enter your name: > '))
        if self.game.isRunning is False:
            self.ui.run()
        while self.game.isRunning:
            self.displayScore()
            if self.game.isRunning is False:
                break
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




