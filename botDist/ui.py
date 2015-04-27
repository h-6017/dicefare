from bot import BotManager
from dTuI import UserInterFace


class UserInterface(object):
    def __init__(self):
        self.bm = BotManager()
        self.running = True
        self.goodBye = "Goodbye, sir."

    def run(self):
        yesOrNo = str(raw_input("Would you like to see the main menu?\n[y/n]:"))
        choice = None
        if yesOrNo.lower() == "y":
            while self.running:
                choice = self.mainMenu()
                if choice == "1":
                    botName = raw_input("Please enter the name of your new Thrall\n:>:")
                    self.bm.addBotNamed(botName)
                elif choice == "2":
                    botName = raw_input("Please enter the name of the Thrall you wish to find\n:>:")
                    bot = self.bm.getBotNamed(botName)
                    print bot.name
                elif choice == "3":
                    botName = raw_input("Please enter the name of the Thrall you wish to delete\n:>:")
                    self.bm.deleteBotNamed(botName)
                elif choice == "4":
                    self.bm.printBots()
                elif choice == "5":
                    uI = UserInterFace()
                    uI.playGame()
                elif choice == "6":
                    self.fareWell()
                    self.running = False
                    break
                else:
                    print("That is not a valid input")
                    raw_input("Press enter to try again")
                    self.running = True
                    continue
                endChoice = raw_input("Would you like to see the menu again?\n[y/n]")
                if endChoice is "y":
                    self.running = True
                else:
                    self.fareWell()
                    self.running = False
        else:
            self.fareWell()
            self.running = False
    def isRunning(self, choice):
	pass
    def newMenuOption(self):
        choice = str(raw_input("Would you like to see a new menu?\[y/n\]"))
        if choice.lower == "y":
            pass
        pass
    def fareWell(self):
        print self.goodBye
    def mainMenu(self):
        menu = True
        while menu:
            print "--MAIN MENU--"
            print "[1]Create a new Thrall."
            print "[2]Find an existing Thrall."
            print "[3]Delete an existing Thrall."
            print "[4]Current Thrall list."
            print "[5]Play a dice roll game."
            print "[6]Exit"
            print "Please input the number that corresponds with your choice"
            choice = str(raw_input(":>: "))
            return choice


