# WPFBattle
Uses RPG Library and Engine repositories from my page with WPF to provide animations/graphics

![RPGTester image](https://i.imgur.com/7LNXGdJ.jpg)

This is a simple OOP library for a variety of character classes and a basic RPG combat system. Most people probably would not use WPF for game developement, but this shows that it is possible!

It includes full animations and a simulated battle sequence. If you want a more full featured engine, this definitely is not the one. It is extremely barebones- but it does reflect OOP standards. To get your own game up, take a look at MainWindow.xaml.cs.

A brief walkthrough of that code is here:

First, an ICombat interface is needed for any combat. The example adds it as a private class variable. 

'''

//Appears at top of class
private ICombat encounter;

'''

To initiate combat, we need to call a Combat object. Basically, which two parties are attacking each other. In general, this will be the play and a set of enemies. 

'''

            //Initalize combat 
            encounter = new Combat(playerParty, enemyParty, playerPartyName, enemyPartyName);

'''

To create these parties, make a list of ICharacters. 

'''

            //Initalize variables
            IList<ICharacter> playerParty = new List<ICharacter>();
            IList<ICharacter> enemyParty = new List<ICharacter>();
            string playerPartyName = "Heroes";
            string enemyPartyName = "Villains";

'''

The code above is fairly self expanatory. Making the names separate might not be the best design decision, but it does the trick. 
You can now add characters as such,

'''

            //Create player characters
            ICharacter player1 = new ImageMage("Harry Potter", 41, characterImage);
            ICharacter player2 = new ImageWarrior("Carl Sagan", 110, characterImage1);

            //Create enemy characters
            ICharacter enemy1 = new ImageArcher("Voldemort", 90, characterImage2);
            ICharacter enemy2 = new ImageComputerWizard("Neil deGrasse Tyson", 41, characterImage3);

            //Add players to party
            playerParty.Add(player1);
            playerParty.Add(player2);

            //Add enemys to party
            enemyParty.Add(enemy1);
            enemyParty.Add(enemy2);

'''

Note that this all is currently run through the console. 
'''

            TextBoxStreamWriter consoleWriter = new TextBoxStreamWriter(textBox);
            Console.SetOut(consoleWriter);

'''

Finally, start the combat thread! 

'''
            //Initalize combat 
            encounter = new Combat(playerParty, enemyParty, playerPartyName, enemyPartyName);

            CombatThread combatThread = new CombatThread(encounter);
            combatThread.Start();
            
'''
