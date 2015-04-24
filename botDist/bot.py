import pymongo
from pymongo import MongoClient


import json
class Bot(object):
    def __init__(self):
        self.message = "I am a new bot"
        self.name = None
        self.knowledge = {}
    def setName(self, name):
        self.name = name
    def sayHello(self):
        print 'hello', self.name
    def saygoodbye(self):
        print 'Goodbye then,', self.name

    @property
    def asDict(self):
        d = dict()
        d['name'] = self.name
        d['knowledge'] = self.knowledge
        d['message'] = self.message
        return d

class BotFactory(object):
    def __init__(self):
        self.message = 'Crafting...'
    def spawnBot(self, name):
        newBot = Bot()
        newBot.setName(name)
        newBot.sayHello
        return newBot


class BotManager(object):
    def __init__(self):
        self.botList = []
        self.bf = BotFactory()
        self.numberOfBots = None
        self.client = MongoClient()
        self.db = self.client.bot_store
        self.collection = self.db.bots

    def printBotNamed(self, botName):
        for bots in self.botlist:
            if botName in self.botList:
                print self.botlist[bots]
            else:
                print "Bot not found"
                break

    def getBotNamed(self, name):#need to figure out how to get the bot out of database
        botName = self.collection.find_one(name)#and build new bot to spec
        for botName in botnames:
            return(botName)


    def addBotNamed(self, botName):
        newBot = self.bf.spawnBot(botName)
        theId = self.collection.insert_one(newBot.asDict).inserted_id
        print("inserted {} into the database".format(theId))
        self.botList.append(newBot)

    def deleteBotNamed(self, botName):
        matchedBot = None
        for bot in self.botList:
            if bot.name(botName) is botName:
                matchedBot = botName
                break
        if matchedBot:
            self.botlist.remove(matchedBot)
        else:
            print 'Bot not found'

    def printBots(self):
        for bot in self.botList:
            print "This bot\'s name is\n:>:", bot.name
