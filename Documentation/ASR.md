# Architecture Significant Requirements Document

## 1. Einleitung
TODO 
## 2. Utility Tree
Der Utility Tree vergleicht den Nutzen mit dem technischen Aufwand einer Funktion der Software. 
Die Werte werden durch Niedrig (⭐) Mittel (⭐⭐) und Hoch (⭐⭐⭐) repräsentiert.

| Q-attribute            | Refinement                                  | Quality attribute scenarios                                                           | Business value | Technical risk |
|------------------------|---------------------------------------------|---------------------------------------------------------------------------------------|----------------|----------------|
| Sicherheit             | Datenschutz                                 | Die Gesundheitsdaten sollen sicher übertragen und gespeichert werden.                 | ⭐⭐⭐        | ⭐⭐⭐        |
| Sicherheit             | Nutzer Identifikation und Authentifizierung | Sicherer Login und Schutz vor unbefungten Zugriffen.                                  | ⭐⭐          | ⭐⭐           |
| Benutzerfreundlichkeit | Intuitives Design                           | Einfache Navigation und Benutzung der Anwendung                                       | ⭐⭐          | ⭐          |
| Benutzerfreundlichkeit | Anpassbarkeit                               | Nutzer können durch Einstellungen ihr Erlebnis anpassen                               | ⭐⭐             | ⭐⭐             |
| Zuverlässigkeit        | Stabilität und Verfügbarkeit                | Die App sollte auch mit mehreren Nutzern gut funktionieren und nicht abstürzen.       | ⭐⭐             | ⭐⭐⭐            |
| Zuverlässigkeit        | Genauigkeit                                 | Die gespeicherten Daten müssen korrekt sein.                                          | ⭐⭐⭐            | ⭐              |
| Performance            | Geschwindigkeit und Responsiveness          | Die App soll schnell auf verschiedenen Platformen funktionieren (Desktop, Smartphone) | ⭐⭐⭐            | ⭐              |
| Performance            | Skalierbarkeit                              | Die App soll mit einem schnellen Wachstum klar kommen.                                | ⭐              | ⭐⭐             |
| Funktionalität         | Verschiedene Funktionen                     | Die App soll viele verschiedene Funktionen zur Verfügung stellen                      | ⭐⭐⭐            | ⭐⭐⭐            |

## 3. Architektur Entscheidungen
