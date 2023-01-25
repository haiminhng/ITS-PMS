## ITS-PMS
## Its Stuttgart Parking Management System

Das Ziel des Projekts "Automatisierte Parkplatzantragsverwaltung" ist es, das traditionelle Papierformularverfahren für Parkplatzanträge zu ersetzen und den Schülern die Möglichkeit zu geben, bequem von zu Hause aus über private Geräte Parkplatzanträge zu stellen. 
Das System sollte es den Schülern ermöglichen, Anträge auf Parkplätze einzureichen und zu verfolgen. 
Gleichzeitig sollte das System für die Schulsekretärin eine große Erleichterung darstellen, da es jeden Antrag automatisch bewertet und sortiert, indem es die Entfernung des Schülers von der Schule mithilfe von Google API live berechnet. 
Das System sollte auch einen Überblick über alle genehmigten, abgelehnten und wartelisten-Anträge bieten und die Schulsekretärin sollte in der Lage sein, E-Mails an alle genehmigten oder abgelehnten Antragssteller zu senden.

![Unbenannt_geschwärzt_Seite_3](https://user-images.githubusercontent.com/77732765/213553915-db4e3cb8-d9ff-4e4b-b847-4e41945e7243.png)
![Unbenannt_geschwärzt_Seite_2](https://user-images.githubusercontent.com/77732765/213553923-dc3d6524-99b6-488e-b592-c4093a6df965.png)
![Unbenannt_geschwärzt_Seite_1](https://user-images.githubusercontent.com/77732765/213553925-f10e2ae0-48ee-4acc-945e-8ab3db5630e3.png)


### Technology:

#### .Net Core:

Im Projekt wurde .NET Core als Haupt-Entwicklungsplattform verwendet. Es wurde für die Server-Seiten-Anwendung mit ASP.NET Core Blazor Server verwendet und für die Desktop-Anwendung mit Windows Forms für .NET. .NET Core wurde auch verwendet, um Zugriff auf die Google Distance Matrix API und die Datenbank mit .NET EF Core zu ermöglichen. Insgesamt hat .NET Core eine wichtige Rolle bei der Entwicklung dieses Projekts gespielt und hat es ermöglicht, die verschiedenen Komponenten und Funktionen zu integrieren und zu verbinden.

####	.Net EF (Entity Framework) Core: 

Im Projekt wurde .NET EF Core verwendet, um Zugriff auf die Datenbank zu ermöglichen und Daten zu speichern und abzurufen. Es wurde verwendet, um die Struktur der Datenbank zu definieren und zu verwalten, sowie um CRUD- (Create, Read, Update, Delete) Operationen auf Daten auszuführen. .NET EF Core hat es ermöglicht, die Integration der Datenbank in das Projekt zu vereinfachen und die Entwicklung zu beschleunigen.

####	Windows Forms für .NET

Im Projekt wurde Windows Forms für .NET als Frontend-Technologie für die Verwaltung des Schulsekretariats ausgewählt. Es wurde ausgewählt, da es gut in die vorhandene Software integriert werden kann, die ebenfalls mit Windows Forms geschrieben wurde. Die Verwendung von Windows Forms für .NET hat es ermöglicht, eine Benutzeroberfläche zu entwickeln, die für die Schulsekretärin benutzerfreundlich und intuitiv zu verwenden ist, wodurch die Arbeitslast verringert wird. Zusätzlich hat es auch die Integration in die vorhandene Software erleichtert und die Entwicklungszeit verkürzt.

####	Google Distance Matrix API:

Im Projekt wird die Google Distance Matrix API verwendet, um die Reisezeit, Entfernung und Kosten von Schülern mit Bahn und Auto basierend auf der Adresse des Schülers zu berechnen. Die API wird verwendet, um die Punktzahl jedes Parkantrags mithilfe des Weighted-Scoring-Algorithmus zu berechnen, der Faktoren wie Reisezeit, Entfernung und Kosten berücksichtigt. Die Verwendung der Google Distance Matrix API hat es ermöglicht, diese Berechnungen schnell und präzise durchzuführen und hat somit zur Verbesserung der Effizienz bei der Bearbeitung von Parkanträgen beigetragen.



####	Microsoft SQL Server 2022

In Bezug auf das Projekt könnte MS SQL Server verwendet werden, da die IT-Schule, in welcher dieses Projekt entsteht, es bereits verwendet und es gut in das bestehende System integriert ist. Eine RDBMS wie MS SQL Server bietet eine zentrale und sichere Möglichkeit, um die Daten zu speichern und zu verwalten, die für das Projekt erforderlich sind, einschließlich Informationen über die Parkplätze und die Schüeler, die die Plätze beantragen. Da die IT-Schule MS SQL Server bereits in ihrer Infrastruktur verwendet, es gibt auch erfahrenen IT-Personal die damit arbeiten können und es wird es einfacher, es in bestehende Systeme und Prozesse zu integrieren. Es kann auch in Zukunft einfacher sein, die Daten und die Anwendung weiter zu entwickeln und zu warten, weil es Teil des bestehenden technischen Umfelds ist.

### Framework

#### ASP.NET Core Blazor Server

Im Kontext des beschriebenen Projekts wird Blazor Server derzeit im Verwaltungsportalsystem der Schule verwendet, um Schülern die Möglichkeit zu geben, ihre persönlichen Daten zu bearbeiten und eine Lizenz für die Software sowie Krankheiten zu melden. Mit dem Einsatz von Blazor Server, kann die Schule eine moderne und benutzerfreundliche Oberfläche bieten, die Schülern ermöglicht, ihre Daten einfach und effektiv zu verwalten. Es wird geplant die Technologie für die weiterentwicklung zur Integration des Abschnitts für Parkanwendungen zu nutzen. Dies ermöglicht, dass die Schule eine einheitliche und integrierte Plattform für die Verwaltung von Schülerdaten und Parkplatzanträgen bereitstellen kann.

####	Json.NET

Im Projekts wird Json.NET verwendet, um Daten von der Distance Matrix API abzufangen, welche von Google Maps angeboten wird. Diese API ermöglicht es Entwicklern, Entfernungen und Fahrzeiten zwischen verschiedenen Orten zu berechnen. Der Aufruf der API liefert die Ergebnisse in einer Antwort im JSON-Format zurück, die Json.NET verwendet werden kann, um die Daten einfach zu parsen und weiter zu verarbeiten, wie z.B die Berechnung der Fahrzeit und Reisezeit.

####	Unity

In diesem Projekt wird Unity Container verwendet, um Forms und Services zu verwalten und die Trennung der logischen und Datenschnittstellen zu gewährleisten. Unity ist ein Dependency Injection (DI)-Container, der es Entwicklern ermöglicht, Abhängigkeiten von Klassen automatisch bereitzustellen. Dies erleichtert die Entwicklung und Wartung der Anwendung, indem es die Codebasis modularisiert und die Abhängigkeiten von Klassen klar definiert.
### Tools, IDE
####	SQL Server Management Studio (SSMS)
####	Visual Studio

#### Das Hauptziel des Projekts "Automatisierte Parkplatzantragsverwaltung" ist es, ein System zu entwickeln, das es den Schülern ermöglicht, schnell und einfach Parkplätze zu reservieren und zu verwalten, während es gleichzeitig die Schulsekretärin bei der Bearbeitung von Schülerparkanträgen entlastet und ihr Zeit und Ressourcen spart. Um dieses Ziel zu erreichen, muss das System eine Reihe von Anforderungen erfüllen. 


Dazu gehören: 
 Benutzerfreundlichkeit: 

Das System sollte für Schüler einfach zu verwenden sein und eine intuitive Benutzeroberfläche haben, damit sie schnell und einfach Anträge auf Parkplätze stellen können. 

####	Automatisierte Antragsbearbeitung:

Das System sollte jeden Antrag automatisch bewerten und sortieren, indem es die Entfernung des Schülers von der Schule mithilfe von Google API live berechnet. 

####	Überblick über Anträge: Das System sollte einen Überblick über alle genehmigten, abgelehnten und wartelisten-Anträge bieten, damit die Schulsekretärin schnell und einfach auf Anfragen reagieren kann. 

####	Benachrichtigungen und Erinnerungen: 

Das System sollte die Möglichkeit bieten, Benachrichtigungen und Erinnerungen zu senden, um sicherzustellen, dass Benutzer ihre Reservierungen nicht vergessen. 

####	E-Mail-Integration: 

Das System sollte die Möglichkeit bieten, E-Mails an alle genehmigten oder abgelehnten Antragssteller zu senden, damit die Schulsekretärin schnell und einfach Kommunikation mit den Schülern pflegen kann.
