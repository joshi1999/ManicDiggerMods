# BlockLoader

The BlockLoader mod is a mod for Manic Digger.

It defines for every compatible Mod an own BlockId which makes it easier to add new mods and handling the BlockIds.

## How to install it for downloaded mods which use BlockLoader:
Simply put the "BlockLoader.cs" file into your mods folder and start your server. :)

## How to use it with your own mod (onlinemode):

1. Create your mod like normal, then add the lines like in the Example.cs file
2. After finishing your mod you want to test it: Toggle the "useUpToDateBlockIds" to off (in BlockLoader.cs) and create "blocks.csv" in the directory "UserData/BlockLoader"
3. Now write into that created file your block ids and names seperated by ",", just like in the block.csv in this repository
4. If your mod works, you can send an push request (please add a link to your mod) for your blockids to my repo, please add these ids after every other blockids.
5. After your request is accepted you can use your mod in online mode too

## How to use it with your own mod (offlinemode):

1. Start the game with BlockLoader, to load fresh updates from github.
2. Start by 1. (onlinemode) and end with 3.
3. Now its important, that you don't go to the onlinemode, because your block ids will be overwritten from github if you do so.

Now: Have fun with my BlockLoader Mod :)
