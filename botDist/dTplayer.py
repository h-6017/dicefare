from random import choice

class Player(object):
    def __init__(self):
        self.name = None
        self.score = []
        self.gameWins = []
        self.diceList = []

    def setName(self, name):
        self.name = name
        return self.name

    def rollDice(self, diceType):
        die = Die()
        roll =  die.roll(diceType)
        return roll

    def gameWins(self):
        print self.gameWins

    def removeDiceUsed(self, diceUsed):
        if diceUsed in self.diceList:
            self.diceList.remove(diceUsed)
            print "{}, you may still roll your {} sided dice".format(self.name, ",".join(str(d) for d in self.diceList))

class Die(object):
    def __init__(self):
        self.face = None
    def roll(self, diceType):
        self.face = choice(range(1, diceType))
        print self.face
        return self.face



