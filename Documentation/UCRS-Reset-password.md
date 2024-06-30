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

![reset-pw drawio](https://github.com/Chrissi-Ruege/HealthKeeper/assets/20227840/adce7012-cda9-4b88-8d72-e9a911df8449)

### 2.3 Sequenzdiagramm

![reset-pw2 drawio](https://github.com/Chrissi-Ruege/HealthKeeper/assets/20227840/8189957d-d8fc-473f-a345-b0744d6c33a4)
