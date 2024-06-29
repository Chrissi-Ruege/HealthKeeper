# CI/CD Pipelines
Für die Umsetzung unserer CI/CD verwenden wir GitHub Actions. 
Bei jedem Push in den main Branch wird diese eine Pipeline ausgeführt, die zuerst eine .NET Umgebung auf einem Linux Runner installiert, daraufhin das Projekt kompiliert und anschließend die Unit Tests ausführt. 
Das fertige Projekt wird daraufhin als Artifact hochgeladen. 
Die Konfiguration der CI/CD Pipeline kann [hier](https://github.com/Chrissi-Ruege/HealthKeeper/blob/main/.github/workflows/dotnet.yml) eingesehen werden.

| ![image](https://github.com/Chrissi-Ruege/HealthKeeper/assets/20227840/f4692572-11ae-4cba-80c1-a9061f079af6) | 
|:--:| 
| *GitHub Actions Pipeline* |
