# Software Requirements Specification

## 1. Einleitung

### 1.1 Zweck

Diese Software Requirements Specification (SRS) beschreibt alle Spezifikationen für das Projekt „HealthKeeper“. Sie
enthält einen Überblick über das Projekt und seine Zielsetzung, detaillierte Informationen über die geplanten Funktionen
und Randbedingungen des Entwicklungsprozesses.

### 1.2 Purpose

Im Rahmen des Projekts wird eine Fitness- and Health- Tracking- App entwickelt werden. Realisiert wird es als
Webanwendung und typische Akteure sind generelle Nutzer, die Fitness und Health interessiert sind.

Geplante Teilbereiche des Projekts sind:

* Grafiken: Es werden Diagramme zum tracken von Gewicht, Kalorien und ähnlichem eingebunden.
* Aktivitätentracker: Auflistung der Sportaktivitäten mit angegebener Kalorienverbrennung
* Ernährungstagebuch: Tägliche Eingabe von Mahlzeiten mit ihren Kalorienwerten, Makros und Nährwerten
* Wasserflasche: Grafische Darstellung von getrunkenem Wasser mit Erinnerung
* Kalender: Kalender mit Erinnerung an Sportterminen und Trainingsplänen
* Trainingspläne und Videos: Angebotene Fitness und Gesundheits Videos und Trainingspläne, angepasst auf Person und
  Suche
* Konto-System: Kontos erstellen und anmelden mit Fokus des Ziels (Abnehmen, Zunehmen, Gewicht halten mit
  Mengenangabe/Monat)

### 1.3 Abkürzungsverzeichnis

| Abkürzung | Beschreibung                                                       |
|-----------|--------------------------------------------------------------------|
| MVC       | Model View Controller                                              |
| ASP .NET  | Active Server Pages .NET (Web Application Framework von Microsoft) |
| API       | Application Programm Interface                                     |
| BCL       | Base Class Library                                                 |
| C#        | C Sharp                                                            |
| DAO       | Data Access Objects                                                |
| DTO       | Data Transfer Objects                                              |
| SDK       | Software Developement Kit                                          |

### 1.4 Referenzen

| Platform     | Link                                                                         |
|--------------|------------------------------------------------------------------------------|
| GitHub       | https://github.com/Chrissi-Ruege/HealthKeeper                                |
| Projekt Blog | https://github.com/Chrissi-Ruege/HealthKeeper/discussions                    |
| Jira         | https://healthkeeper22b5.atlassian.net/jira/software/projects/SCRUM/boards/1 |

## 2. Beschreibung

### 2.1 Beschreibung

Unsere Software soll eine ganzheitliche Gesundheits- und Fitness-Plattform werden. Diese soll es Benutzern ermöglichen, ihre
Gesundheits- und Fitnessziele zu erreichen, indem sie umfassende Werkzeuge und Informationen bietet. Menschen sollen unterstützt werden, 
ein gesünderes Leben zu führen, ihr Gewicht zu überwachen und auf ihre Fitness zu achten. 
Benutzer können Gewicht und BMI verfolgen, ein Ernährungstagebuch führen, die Wasserzufuhr überwachen,
Sportaktivitäten aufzeichnen und individuelle Gewichtsziele setzen. Die App liefert maßgeschneiderte Empfehlungen
basierend auf Fortschritten und erinnert an geplante sportliche Aktivitäten. Selbstverwaltung und Verbesserung der
Gesundheit stehen im Mittelpunkt unserer Software. Unser Ziel ist es, die Gesundheit und das Wohlbefinden der Benutzer
zu fördern und sie bei der Erreichung ihrer persönlichen Gesundheitsziele zu unterstützen.

### 2.2 Use Case Diagramm

![use-case-diagram](https://github.com/Chrissi-Ruege/HealthKeeper/assets/20227840/66c8bebe-7a3c-4d1a-ac6e-f02100b0e19b)

### 2.3 Tech Stack

Um die App auf möglichst jeder Plattform nutzen zu können wird eine Webseite entwickelt. Hierzu wird ein C# basierter
Tech Stack verwendet:

* ASP.NET
* EntityFramework-Core
* NUnit / Moq
* JIRA
* GitHub Actions
* HTML / CSS / JavaScript

Zur Versionskontrolle wird GitHub verwendet.

## 3. Anforderungen

### 3.1 Funktionalitäten

Wie im Use Case Diagramm zu sehen ist, gibt es einige Funktionalitäten, welche implementiert werden sollen.
Funktionalitäten, die mit dem Account der User zusammenhängen sind:

* Create an Account
* Login
* Logout
* Profile settings

Dazu kommen noch die generellen Funktionalitäten, mit welchen der User interagieren kann:

* Show statistics
* Activities tracker
* Calorie intake
* Water intake
* Show macronutrients
* Calender with notifications
* Show training plans and videos

Im Folgenden werden die einzelnen Funktionen genauer erläutert.

### 3.2 Usability

#### 3.2.1 Einarbeitungszeit

Da es sich bei HealthKeeper um eine Web-Applikation handelt, soll sie alle Funktionaltäten anbieten, nachdem die Seite
geöffnet wird. Sobald man sich in seinem Account anmeldet, können die Funktionen in vollem Umfang genutzt werden.

#### 3.2.2 Design

HealthKeeper soll ein einheitliches und intuitives Design verfolgen, um den Benutzern das Interagieren mit den
verschiedenen Funktionen der Web-App zu vereinfachen.

### 3.3 Andere Anforderungen

#### 3.3.1 Verfügbarkeit

Die Web-App soll rund um die Uhr verfügbar sein, damit beim Gesundbleiben der Benutzer keine Abstriche gemacht werden
müssen. Ausnahmen sind hierbei Wartungsarbeiten, welche im Vorfeld angekündigt werden, damit sich die Benutzer darauf
einstellen können, dass die Web-App mal nicht in vollem Umfang funktioniert. Damit ergibt sich eine Erreichbarkeit von
ca. 95% der Zeit.

#### 3.3.2 Genauigkeit

Da die Web-Applikation dabei helfen soll, sich um seine Gesundheit zu kümmern, müssen die Daten genau sein, um gute
Ergebnisse liefern zu können.

#### 3.3.3 Bugs

Zu kritischen Situation zählt es, wenn Datenverluste auftreten und somit die “Accuracy” nicht mehr gewährleistet werden
kann. Dazu zählen ebenfalls Probleme mit den Funktionen des HealthKeeper’s. Weniger kritische Bugs und Probleme wären
dabei zum Beispiel lange Ladezeiten der Web-App.

### 3.4 Performance
Da dieses Projekt keinen Production-State erreichen wird und vorallem Lokal getestet wird, ist die Performance nicht ganz so wichtig.

#### 3.4.1 Antwortzeit

Um den HealthKeeper so Benutzerfreundlich wie möglich zu halten, soll die Performance sowie die Ladezeiten so gut wie
möglich sein. Auf komplexe Optimierungen wird allerdings verzichtet.

#### 3.4.2 Capacity

Es soll keine Limits bei der Anzahl an Benutzern geben, welche den HealthKeeper gerne benutzen möchten.

#### 3.4.3 Speicher

Abgesehen von Browsercaches und Cookies wird auf den Geräten der Benutzer kein Speicher allokiert. 
Die Anwendung selbst wird im Backend keine großen Datenmengen verarbeiten, dadurch benötigt das Backend auch nur wenig Speicher.
Mit Datenbank und .NET Runtime sollten weniger als 2-3GB anfallen.

### 3.5 Supportability

Der Code soll grundsätzlichen Standards der Programmierung folgen. 
Um eine einfache Weiterentlickung zu ermöglichen soll, der Code übersichtlich gehalten werden.

### 3.6 Designvorgaben

Um die Web-App Entwicklung in Front- und Backend zu trennen, wird das MVC-Pattern verwendet. Zusätzlich zu C# wird auch
mit HTML, CSS und JS entwickelt, da es sich hierbei um eine Web-Applikation handelt. 
