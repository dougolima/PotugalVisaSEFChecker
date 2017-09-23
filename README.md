# PotugalVisaSEFChecker

Windows TraySystem application which checks Portugal SEF visa status in http://www.secomunidades.pt in a configurable interval.

## Prerequisites

- Visual Studio 2017
- .NET framework 4.6.1

## How to install

- Build project in release mode
- Configure username, password and interval (in minutes) in the configuration file located at \PortugalVisaSEFCheckerTraySystem\bin\Release\PortugalVisaSEFCheckerTraySystem.exe\PortugalVisaSEFCheckerTraySystem.exe.config
- Execute \PortugalVisaSEFCheckerTraySystem\bin\Release\PortugalVisaSEFCheckerTraySystem.exe

## How application works
- The application will access http://www.secomunidades.pt/vistos/index.php?option=com_content&view=article&id=163&Itemid=143&lang=en with username and password configured
- The icon will change based on SEF status

- It is possible to refresh the status immediately through the context menu "Refresh"
- It is possible to see last and next execution info through the context menu "Execution Info"
