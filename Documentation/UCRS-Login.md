# Use-Case-Realization Specification: Login

## 1. Einleitung

Dieser Use-Case beschreibt den Ablauf, wenn sich ein Benutzer anmeldet.
Dieses Dokument beinhaltet alle zu diesem Use Case relevanten UML-Diagramme sowie eine textuelle Beschreibung.

### 1.1 Referenzen

* Aktivitätsdiagramm (Version 1, 05.11.2023)
* Sequenzdiagramm (Version 1, 06.11.2023)

## 2. Ablauf der Events

### 2.1 Textuelle Beschreibung

Um den Anwendungsfall zu starten öffnet ein Benutzer zuerst die Login Seite und gibt seine Anmeldedaten (Name, Passwort)
ein.
Das Backend validiert daraufhin die eingegebenen Daten. Bei falscher Eingabe wird ein Fehler angezeigt, bei korrekter Eingabe wird der Benutzer weitergeleitet.

### 2.2 Aktivitätsdiagramm

![login-activity](https://github.com/Chrissi-Ruege/HealthKeeper/assets/20227840/1a238697-1e4d-493d-be92-4a9cff365583)

### 2.3 Sequenzdiagramm

![login-sequence](https://github.com/Chrissi-Ruege/HealthKeeper/assets/20227840/c823dcef-24ec-4b88-9e44-b8c3b1fb4527)
