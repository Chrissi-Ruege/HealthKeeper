# Software Architecture Document

## 1. Architectural Goals and Constraints
### 1.1 Requirements
Unsere Gesundheits-Plattform muss eine Reihe von Anforderungen erfüllen, um eine effiziente, skalierbare und wartbare Lösung zu gewährleisten. Hier sind die wesentlichen Anforderungen an die Architektur:
        
1. **Klare Trennung der Zuständigkeiten:**
   - Die Struktur der Anwendung muss eine klare Trennung zwischen Datenverwaltung, Benutzeroberfläche und Geschäftslogik ermöglichen.
2. **Effizienter und flexibler Datenbankzugriff:**
   - Die Anwendung muss in der Lage sein, effizient und flexibel auf Datenbanken zuzugreifen und die Datenverwaltung zu vereinfachen.
3. **Trennung der Datenzugriffslogik von der Geschäftslogik:**
   - Die Datenzugriffslogik muss von der Geschäftslogik getrennt sein, um die Wartbarkeit der Anwendung zu verbessern.
4. **Entkopplung der Komponenten:**
   - Die verschiedenen Komponenten der Anwendung müssen entkoppelt sein, um die Flexibilität und Testbarkeit zu verbessern.
5. **Skalierbarkeit:**
   - Die Anwendung muss skalierbar sein, um zukünftigen Anforderungen und wachsenden Benutzerzahlen gerecht zu werden.
6. **Wartbarkeit:**
   - Die Anwendung muss leicht wartbar sein, um zukünftige Änderungen und Erweiterungen effizient durchführen zu können.
        
Durch die Erfüllung dieser Anforderungen stellen wir sicher, dass unsere Gesundheits-Plattform den aktuellen Bedürfnissen gerecht wird und flexibel sowie anpassungsfähig für zukünftige Entwicklungen ist. Diese Anforderungen bilden die Grundlage für eine robuste, effiziente und zukunftssichere Softwarearchitektur.
        
### 1.2 Architectural decisions

Unsere Architekturentscheidungen basieren auf bewährten Technologien und Mustern, um eine effiziente und skalierbare Lösung zu bieten:
        
- **ASP.NET und Model-View-Controller (MVC) Pattern:**
  - **Modelle:** Verwalten die Daten und Geschäftslogik der Anwendung.
  - **View:** Beschreibt die Benutzeroberfläche und präsentiert die Daten dem Benutzer.
  - **Controller:** Fungiert als Bindeglied zwischen Model und View, steuert die Datenflüsse und Interaktionen.
- **Entity Framework Core:**
  - Dieses ORM-Framework erleichtert den Datenbankzugriff, indem es eine objektorientierte Abbildung der Datenbankstrukturen ermöglicht und somit die Datenverwaltung effizient und flexibel gestaltet.
- **Design Patterns:**
  - **Repository Pattern:**
    - Zweck: Trennung der Datenlogik von der Geschäftslogik.
    - Vorteile: Bessere Wartbarkeit, klare Trennung der Zuständigkeiten.
    - Beispiel: Implementierung des Repository Patterns in `DatabaseContext.cs`.
  - **Dependency Injection:**
    - Zweck: Entkopplung der Komponenten und Verbesserung der Testbarkeit.
    - Vorteile: Verbesserte Testbarkeit, flexible Konfiguration der Abhängigkeiten.
    - Beispiel: Verwendung von Dependency Injection im `Program.cs`.
        
Durch diese Architekturentscheidungen gewährleisten wir die Skalierbarkeit und Wartbarkeit unserer Anwendung. Das MVC-Pattern ermöglicht eine klare Trennung von Datenverwaltung, Benutzeroberfläche und Geschäftslogik. Entity Framework Core sorgt für eine effiziente Datenverwaltung, während das Repository Pattern und Dependency Injection die Struktur und Testbarkeit der Anwendung verbessern. Diese Ansätze führen zu einer robusten, flexiblen und zukunftssicheren Softwarelösung.
        
## 2. Use-Case View
![use_case](https://github.com/Chrissi-Ruege/HealthKeeper/assets/20227840/b4ecbc40-c58f-4e13-b302-945424e22db5)

## 3. Logical View - Klassendiagramm
    
Das vorliegende UML-Klassendiagramm beschreibt ein System zur Verwaltung von Benutzerkonten und deren Funktionen im Zusammenhang mit Fitness, Ernährung und Aktivitäten. Es enthält die folgenden Hauptklassen:
    
- **BenutzerKonto** Diese Klasse repräsentiert ein Benutzerkonto und enthält Informationen wie Benutzername, Passwort, Zielsetzungen und Funktionen zur Verwaltung von Aktivitäten, Ernährung, Wasserzufuhr, Kalenderereignissen und Fitnessvideos.
- **Grafik** Diese Klasse dient der Darstellung von Grafiken und enthält Datenpunkte für die Anzeige von Informationen wie den Body Mass Index (BMI).    
- **Daten** Datenpunkte, die von der Grafikklasse verwendet werden, um Informationen wie Datum und Gewicht zu speichern.
- **Aktivitätentracker** Eine Klasse, die die Verfolgung von Sportaktivitäten unterstützt und eine Liste von Sportaktivitäten enthält.
- **Ernährungstagebuch** Hier können Benutzer Mahlzeiten in ihr Tagebuch eingeben.  
- **Wasserflasche** Diese Klasse ermöglicht das Verfolgen und Erinnern an die Wasserzufuhr.   
- **Kalender** Verwaltet Sporttermine im Kalender.
- **TrainingspläneUndVideos** Bietet Funktionen zum Anzeigen von Fitnessvideos und Trainingsplänen.
    
Weitere spezifische Informationen zu den Klassen und deren Beziehungen sind im Diagramm enthalten
    
![Untitled](https://github.com/Chrissi-Ruege/HealthKeeper/assets/20227840/2ca435f6-6de7-49c1-8b56-7d4e15cf209a)

## 4. Process View - Aktivitäts- und Sequenzdiagramme
    
### 4.1 Create calendar entry
In diesen Diagrammen wird beschrieben, wie ein Benutzer einen neuen Kalender Eintrag anlegt.
    
![create-calendar-entry](https://github.com/Chrissi-Ruege/HealthKeeper/assets/20227840/c916b927-5613-4c72-9100-d48c8dbca992)

![create-c drawio](https://github.com/Chrissi-Ruege/HealthKeeper/assets/20227840/1f8fae93-897b-4945-b4d8-cff997d304f7)

### 4.2 Login
    
Die folgenden Diagramme beschreiben den Weg des Users von der Login Seite bis zur Startseite.

![login-seq drawio](https://github.com/Chrissi-Ruege/HealthKeeper/assets/20227840/be432b5e-de4b-437d-8072-dcc7968f30e4)

### 4.2 Reset password
    
Sollte ein Benutzer sein Passwort vergessen, sollte dieser es wieder zurücksetzen können.

![reset-pw drawio](https://github.com/Chrissi-Ruege/HealthKeeper/assets/20227840/35e5e325-04ab-45ab-95fd-48685670baae)

![reset-pw2 drawio](https://github.com/Chrissi-Ruege/HealthKeeper/assets/20227840/a879046c-1230-4f3a-9401-61bb82544ff1)

## 5. Implementation
### 5.1 Layers
        
Unsere Gesundheits-Plattform ist in mehrere klar definierte Schichten unterteilt, die jeweils spezifische Aufgaben erfüllen und zusammenarbeiten, um eine robuste und skalierbare Anwendung zu gewährleisten.
        
#### 5.1.1 Präsentationsschicht (Presentation Layer)
Die Präsentationsschicht bildet die Benutzeroberfläche unserer Anwendung. Hier interagieren Benutzer direkt mit der Plattform über intuitive Views im MVC-Pattern. Diese Schicht ermöglicht Funktionen wie das Verfolgen von Gewicht und BMI, das Führen eines Ernährungstagebuchs und die Verwaltung von Fitnessterminen.
        
#### 5.1.2 Anwendungsschicht (Application Layer)
Die Anwendungsschicht beinhaltet die Geschäftslogik der Plattform. Sie nimmt Anfragen aus der Präsentationsschicht entgegen, koordiniert die Interaktionen und ruft entsprechende Services auf. Diese Schicht stellt sicher, dass die Geschäftsregeln der Anwendung konsistent und effizient umgesetzt werden.
        
#### 5.1.3 Datenzugriffsschicht (Data Access Layer)
Die Datenzugriffsschicht ermöglicht den Zugriff auf die Datenbank oder andere externe Datenquellen. Mithilfe von Technologien wie Entity Framework Core werden Daten gelesen, geschrieben und verwaltet. Diese Schicht gewährleistet eine effiziente Datenverwaltung und -zugriff, während Datenintegrität und -konsistenz sichergestellt werden.
        
#### 5.1.4 Infrastrukturschicht (Infrastructure Layer)
Die Infrastrukturschicht umfasst technische Details und externe Systeme, die für den Betrieb der Anwendung notwendig sind. Hierzu zählen Logging, Konfigurationsmanagement sowie die Integration externer APIs und Dienste. Diese Schicht sorgt dafür, dass die Anwendung robust und zuverlässig in ihrer Umgebung funktioniert.
        
### 5.2 Software Tools/Techniken
Für die Entwicklung und den Betrieb unserer Gesundheits-Plattform haben wir eine Reihe von Softwaretools und Technologien eingesetzt, um eine effiziente Entwicklung, Zusammenarbeit und Bereitstellung zu gewährleisten:
        
#### 5.2.1 Programmiersprachen und Frameworks
  - **C#:** Hauptprogrammiersprache für die Entwicklung der Anwendungslogik.
  - **HTML, JavaScript:** Verwendet für die Entwicklung der Benutzeroberfläche und clientseitige Interaktionen.
  - **ASP.NET Core:** Framework für die Entwicklung von Webanwendungen unter Verwendung des MVC-Patterns.
  - **Entity Framework Core:** ORM (Object-Relational Mapping) Framework für den Datenbankzugriff.
#### 5.2.2 Datenbank
  - **SQL Server:** Verwendet als relationale Datenbankmanagement-System für die Speicherung von Anwendungsdaten.
#### 5.2.3 Testen
  - **NUnit:** Framework für das unit testing von C#-Code, um die Qualität und Zuverlässigkeit der Anwendung sicherzustellen.
#### 5.2.4 Versionskontrolle und Collaboration
  - **Git und GitHub:** Für Versionskontrolle, Code-Management und kollaborative Entwicklung zwischen Teammitgliedern.
  - **GitHub Actions:** Zur Automatisierung von Build-, Test- und Deploy-Prozessen direkt aus dem GitHub-Repository heraus.
#### 5.2.5 Projektmanagement:
  - **Jira:** Zur Verwaltung von Aufgaben, Sprints und Projektfortschritt, einschließlich Fehlerverfolgung und Roadmap-Planung.
## 6. Size and Performance
    
### 6.1 Size

#### 6.1.1 Umfang der Funktionalitäten
Unsere Gesundheits-Plattform bietet eine breite Palette an Werkzeugen und Funktionen, die darauf ausgelegt sind, Benutzer bei der Erreichung ihrer Gesundheitsziele zu unterstützen. Zu den Kernfunktionen gehören die Verfolgung von Gewicht und BMI, ein detailliertes Ernährungstagebuch sowie die Möglichkeit, Fitnesstermine in einem personalisierten Kalender zu planen. Diese integrierten Funktionen sind nahtlos miteinander verbunden, um eine ganzheitliche Benutzererfahrung zu gewährleisten.
#### 6.1.2 Datenmodell und Datenbankgröße:
Die Plattform basiert auf einem robusten Datenmodell, das die Basis für die Speicherung und Verarbeitung der Benutzerdaten bildet. Durch die Nutzung von SQL Server als Datenbanklösung gewährleisten wir eine effiziente und skalierbare Datenverwaltung. Das Datenmodell wurde sorgfältig entworfen, um die spezifischen Anforderungen an die Gesundheitsdaten unserer Benutzer zu erfüllen und gleichzeitig die Leistung der Plattform zu optimieren.
    
### 6.2 Performance
#### 6.2.1 Systemreaktionszeit
Unsere Plattform zeichnet sich durch eine schnelle Systemreaktionszeit aus, die es Benutzern ermöglicht, Daten schnell abzurufen, Berechnungen durchzuführen und Interaktionen reibungslos auszuführen. Die Architektur, die auf modernen Technologien wie .NET Core und ASP.NET basiert, unterstützt diese schnelle Reaktionszeit und trägt dazu bei, eine herausragende Benutzererfahrung zu bieten.
#### 6.2.2 Skalierbarkeit und Lasttests
Die Plattform wurde intensiv auf Skalierbarkeit und Leistung getestet, um sicherzustellen, dass sie unter unterschiedlichen Lastszenarien effektiv funktioniert. Die Implementierung von GitHub Actions für Continuous Integration und die Verwendung von NUnit für umfassende Tests spielen eine entscheidende Rolle dabei, die Leistungsfähigkeit der Plattform unter Beweis zu stellen und sicherzustellen, dass sie den Anforderungen eines wachsenden Benutzerstamms gerecht wird.

## 7. Quality
Die Benutzerfreundlichkeit steht bei unseren Gesundheits-Plattform im Vordergrund: Wir haben eine intuitive Benutzeroberfläche entwickelt, die es Benutzern ermöglicht, einfach ihr Gewicht und BMI zu verfolgen, Fitnesstermine zu planen und ein Ernährungstagebuch zu führen. Dies soll sicherstellen, dass unsere Plattform für eine breite Nutzerbasis zugänglich ist und ein reibungsloses Nutzungserlebnis bietet. Unsere Plattform ist auf Skalierbarkeit und Flexibilität ausgelegt. Die Architektur ist darauf ausgerichtet, mit dem Wachstum unserer Benutzerbasis mitzuwachsen und neue Anforderungen zu unterstützen.
