# Archbuddy-Nkeys
A simple Hotkey combo plugin for Archbuddy

I wrote a plugin, to test out different ability combinations that you can setup easily on a hotkey. At the moment combinations are set to keys "1", "2", "3".
Edit your combinations in combo strings1,2,3 e.g.

string [] combo1 = {"Charged bolt", "Piercing shot"};

Please report any known issues.

Known isuess:
a) Sometimes if the spell is casted its dosnt show up in debug that it is used. I guess "if (skillCooldown(CurrentSkill) > 0)" needs more time after casting to change. Will look in to that latter on.
b) Ive noticed that certain skill rotations by hand could be done mutch faster than by the script. Ive noticed this in combo (Concussive arrow + Float)
c) Sometimes after several script launches keyDown just stops, and there is nothing you can do except restart your computer to get it working. Even script restart or restart of AB wont help. I guess its related to the work of events in AB. 
