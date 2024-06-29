# HealthKeeper Test Plan

## 1. Einleitung

### 1.1 Zweck
Dieser Testplan soll alle Informationen sammeln, die für die Planung-/Steuerung des Testaufwands für HealthKeeper nötig sind.
Er beschreibt den Ansatz für das Testen der Software und ist der Plan auf oberster Ebene, der von den Managern erstellt und verwendet wird, um den Testaufwand zu steuern.

### 1.2 Verwendete Tests
Folgende Arten von Tests sollen eingesetzt werden:
* Unit-Tests: Zum Testen einzelner Funktionen
* Integration-Tests: Zum Testen ganzer Endpunkte

Auf tiefgreifendere automatisierte Tests wird aus Aufwandsgründen zunächst verzwichtet.

## 2. Werkzeuge

### 2.1 NUnit
> Von https://nunit.org/
>> NUnit is a unit-testing framework for all .Net languages. Initially ported from JUnit, the current production release,
>> version 3, has been completely rewritten with many new features and support for a wide range of .NET platforms.

### 2.2 Moq
> Von https://github.com/devlooped/moq
>> Moq (pronounced "Mock-you" or just "Mock") is the only mocking library for .NET developed from scratch to take full advantage of .NET Linq expression trees and lambda expressions, which makes it the most productive, type-safe and refactoring-friendly mocking library available.

### 2.3 Code Coverage Tool
Code Coverage Reports können mit der Microsoft .NET CLI automatisch im Cobertura Format erzeugt werden.
Um aus der Cobertura XML eine schöne Übersicht zu generieren wird der [ReportGenerator](https://github.com/danielpalme/ReportGenerator) verwendet.<br>
Bild des generierten Reports:<br>
![image](https://github.com/Chrissi-Ruege/HealthKeeper/assets/20227840/2697026c-dce7-4851-9ccb-40abe205ce29)

## 3. Zielwerte
Wir streben mit etwa 50 % eine recht geringe Testabdeckung an.
Dies liegt vor allem daran, dass unsere Codebase zu einem großen Teil aus Frontend Code, also HTML und CSS, besteht.

## 4. Struktur
Die Tests befinden sich in dem getrennten "HealthKeeper.Tests" Projekt. 
Für jede Klasse die getestet wird, wird eine eigene Test Datei "[Klasse]Test.cs" erstellt in welcher sich die verschiedenen Test-Cases befinden.

## 5. Ausführung
Sämtliche Tests sollen jeweils beim Kompilieren der Anwendung sowie beim Ausführen der CI/CD Pipeline ausgeführt werden.
Um die Anwendung bauen zu können müssen immer alle Tests erfolgreich sein.

