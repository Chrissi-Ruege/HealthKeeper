# Use-Case-Realization Specification: Reset password

## 1. Einleitung

Sollte ein Benutzer sein Passwort vergessen haben, sollte dieser nicht seinen Account verlieren. Dieser Use-Case beschreibt den Ablauf zum Ändern des Passworts ohne Kontozugriff.
Dieses Dokument beinhaltet alle zu diesem Use Case relevanten UML-Diagramme sowie eine textuelle Beschreibung.

### 1.1 Referenzen

* Aktivitätsdiagramm (Version 1, 05.11.2023)
* Sequenzdiagramm (Version 1, 06.11.2023)

## 2. Ablauf der Events

### 2.1 Textuelle Beschreibung

Der Benutzer gibt auf einer "Passwort vergessen" Seite seine E-Mail Addresse an.
Das Backend prüft daraufhin ob die angegebene Addresse gültig ist.
In diesem Fall sendet der Server per Mail einen Token.
Der Benutzer gibt diesen Token nun zusammen mit dem neuen Passwort auf der Webseite ein.
Bei gültiger Eingabe speichert das Backend das neue Passwort.

### 2.2 Aktivitätsdiagramm

![resetpassword-activity](https://github.com/Chrissi-Ruege/HealthKeeper/assets/20227840/e0728bb7-8bbc-4c53-b669-281d9c5a18ab)

### 2.3 Sequenzdiagramm

![resetpassword-sequence](https://github.com/Chrissi-Ruege/HealthKeeper/assets/20227840/e822dd6e-27e7-4098-a5dc-a02a22794b72)
