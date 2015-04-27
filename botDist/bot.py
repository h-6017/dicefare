import pymongo
from pymongo import MongoClient


import json

class Bot(object):
    def __init__(self):
        self.message = "Generic Message"
        self.name = None
        self.knowledge = {}
    def setName(self, name):
        self.name = name
    def sayHello(self):
        print 'Hello, I am', self.name

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

    def getBotNamed(self, botName):#need to figure out how to get the bot out of database
        matchedBot = None
        for bot in self.botList:
            #print bot.name
            if bot.name == botName:
                print("This is the bot you are looking for.")
                print bot.message
                bot.sayHello()
                matchedBot = bot 
                break
            if matchedBot:
                return matchedBot
            else:
                print("Bot not found yet, checking...")
        #botName = self.collection.find_one(name)#and build new bot to spec


    def addBotNamed(self, botName):
        newBot = self.bf.spawnBot(botName)
        theId = self.collection.insert_one(newBot.asDict).inserted_id
        print("inserted {} into the database".format(theId))
        self.botList.append(newBot)

    def deleteBotNamed(self, botName):
        matchedBot = None
        for bot in self.botList:
            if bot.name == botName:
                print 'This bot has been found -->'
                matchedBot = bot
                matchedBot.sayHello()
                break
        if matchedBot:
            print matchedBot.name, "has been deleted."
            self.botList.remove(matchedBot)
        else:
            print 'Bot not found'

    def printBots(self):
        print("Here is a list of the bots I have stored.")
        for bot in self.botList:
            print bot.name
        print("")
