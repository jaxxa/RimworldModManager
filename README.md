# RimworldModManager

This is still a work in progress and does not currently work correctly.

Keep an eye out for this on the official forums in the Tools section.

#Instructions

Note that this program only works on windows. Tested on 7 and 10.

1. Open the program "RimworldModManager.exe"

2. Press Load to Load a Profile, these profiles record your Rimworld game lcoation and config location.

3. Press New, In the Top Box Enter or navigate to your Rimworld folder (the folder containing Rimworld.exe). The next box is for the Rimworld Config Folder. The default should already be selected "C:\Users\{USER}\AppData\LocalLow\Ludeon Studios\RimWorld". If you are overriding it to a new location enter / navigate to that lcoation. Note that Relitive paths will start from this program, not to the RimWorld.exe.  Then press OK to create your New profile.

4. Select the Profile that you want to use and click OK. This will probaly be the profile you just created if you made one, or can be any of the previously saved profiles. 

5. The main grid will now show you all of the mods that you have and the status of them. You can move them up / down or enable / disable the selected mod using the buttons at the top of the screen. You can then Just save the Mod configuration or Save the configuration and Run Rimworld.

Issue checking:

The main interesting part of theis program is the Issues column.
This tries to automatically detect issues in your load order / configuration. These issues are writted out in both the issues Column and The selected mod's issues are writted in the pannel on the right when the mod is selected.

Some types of issues that are chaecked are Core mod not enabled, core mod not first, Mod missing on disk (it exists in your load order but the actual mod is missing), a mod with missing dependencies, dependencies that are not loaded or dependencied that are later in the load order. 

Checking for dependencies is done based on an aditional .xml file and so may not be avalable for every mod without out the modder including that file.

Part of the reasong for including this functionality is as a demonstration on what could be done with the hope that somthing similar could be included in the base game or a more integrated mod / program.


# ChangeLog:

01.00.00
Initial Release