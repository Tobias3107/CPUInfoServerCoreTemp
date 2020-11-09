# CPUInfoServerCoreTemp
Core Temp Plugin just getting Data and put them To a File. Updates the Data continuously. 

If u want to Change the Directory from the File that will Update. U can do this in [CPUInfoServerCoreTemp / CPUInfoServerCoreTemp / CoreTempPlugin.cs:96](https://github.com/Tobias3107/CPUInfoServerCoreTemp/blob/3235e7b5e3d38c009afa55af33de2f00495bc8f6/CPUInfoServerCoreTemp/CoreTempPlugin.cs#L96)           
```C-Sharp
dataToJSON.transferToJSON(Data, "C:\\Program Files\\Core Temp\\Plugins\\localData.json");
```

If u have something to improve. Do it.
