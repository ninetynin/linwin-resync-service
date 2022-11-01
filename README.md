# linwin-resync-service

## What does this service solve?
-> If u use dual boot in ur desktop and switch between os's then the time is going to be in UTC(im not exactly sure but its going to be wrong for sure) 
-> and this service just connects to time.windows.com server and resets the time 
-> although the automatic thing before logging in is not implemented yet u can manually update using this for the time being 😟

### How to install -> installutil WindowsService1.exe
Guidelines to Install this service
1. U need to run this in Administrator Dev console for vs 2022 (or any other version you have) 
2. Go to the location of the installed exe and execute the command
3. Automatic restart and resyncing is not yet ready but u can do it manually by pressing on start and stop
The service name is linwin ressync service

![image](https://user-images.githubusercontent.com/91336664/199134604-37f91f64-3068-4157-8dc4-b58a7c71ad93.png)

### How to uninstall -> installutil /u WindowsService1.exe (TODO: Change the name🤡)
