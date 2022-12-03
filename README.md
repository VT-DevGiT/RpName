# RpName
This plugin are plugin for SCP sl servers under the [synapse loader](https://github.com/SynapseSL/Synapse). Plugin inspired by [Exiled Rp Name](https://github.com/babyboucher/RPNames). This plugin allows you to customize the name of the players according to their roles !


## Installation
1. [Install Synapse](https://github.com/SynapseSL/Synapse/wiki#hosting-guides).
2. Place the dll file in your plugin directory.
3. Restart/Start your server.

the plugins dll can be download [here](https://github.com/VT-DevGiT/RpName/releases) 

## Config

| ConfigName | Type | Description |
| :-------------: | :---------: | :------: |
| RoleName | Dictionary of Int and String | the int is the [roleID](https://docs.synapsesl.xyz/resources#roles) and the name associate. |
| FirstName | StringList | the possible fristname, that replace the tag "%FirstName%" |
| SecondName | StringList | the possible secondname, that replace the tag "%Secondname%" |

the "%TAG%" in the name are replaced !

| Tag | Replace |
| :-------------: | :---------: |
| %firstName% | A random firstname in the FirstName list | 
| %secondName% | A random secondname in the SecondName list  |
| %randomNum% | A random figure |
| %randomChar% | A random letter |
| %playerName% | The player name |
