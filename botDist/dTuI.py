from diceTastic import Game
from ui import *
from bot import BotManager

class UserInterFace(object):
    def __init__(self):
        self.message = None
        self.game = Game()
    def displayScore(self):
        print("{p1.name} Has {p1.score}".format(p1=self.game.playerOne))
        print("{p2.name} Has {p2.score}".format(p2=self.game.playerTwo))

    def playGame(self):
        answer = raw_input("Would You Like to play a game of dice?\n[y/n]:")
        playerOne = self.game.acceptPlayerOne(raw_input('Player one, please enter your name: > '))
        playerTwo = self.game.acceptPlayerTwo(raw_input('Player two, please enter your name: > '))
        while self.game.isRunning:
            answer = raw_input("Are you ready to play a round?\n[y/n]:")
            if answer.lower() == "y":
                while self.game.roundIsRunning:
                    self.game.oneRound(playerOne, playerTwo)
                    self.game.isRoundRunning(playerOne, playerTwo)
                    if self.game.isRunning is False:
                        break
                self.game.shouldGameContinue(playerOne, playerTwo)
            else:
                print "Please have a pleasant day."
                break



