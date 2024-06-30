# Architecture Significant Requirements Document

## 1. Einleitung
In diesem Dokument befindet sich unser Utility Tree sowie eine Übersicht zu unseren Architektur Entscheidungen.

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

### 3.1 Backend
ASP.NET dient als Grundlage für unsere Client-Server Anwendung.
Das Entity Framework Core erleichtert den Zugriff auf die Datenbank.

### 3.2 Frontend
Für das Frontend verwenden wir HTML, CSS und JavaScript. 

## 4. Design Patterns

- **Repository Pattern:**
    - **Zweck:** Für den Datenzugriff und die Trennung der Datenlogik von der Geschäftslogik.
    - **Implementierung:** Beispielsweise im `DatabaseContext.cs`.
    - **Vorteile:** Klare Trennung der Zuständigkeiten und verbesserte Wartbarkeit.
- **Dependency Injection:**
    - **Zweck:** Zur Entkopplung der Komponenten und zur Verbesserung der Testbarkeit.
    - **Implementierung:** Beispielsweise im `Program.cs`.
    - **Vorteile:** Verbesserte Testbarkeit und flexible Konfiguration der Abhängigkeiten.

Durch den Einsatz dieser Design Patterns verbessern wir die Testbarkeit, Wartbarkeit und die klare Trennung der Zuständigkeiten innerhalb unserer Anwendung, was zu einer robusteren und leichter zu wartenden Software führt. Die Kombination dieser Technologien und Muster gewährleistet eine skalierbare, wartbare und effiziente Lösung zur Unterstützung der Gesundheitsziele unserer Benutzer.
