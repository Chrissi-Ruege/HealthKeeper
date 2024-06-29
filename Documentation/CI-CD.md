# CI/CD Pipelines
Das Projekt wird bei jedem Push auf das GitHub Repository von einer Continous Integration
Pipeline kompiliert und getestet. Wir nutzen hierfür GitHub Actions, da es einfach in der
Benutzung ist. Unsere Pipeline besitzt nur einen einzigen Job, der sich um alle Aufgaben
kümmert. Das Berechnen der Code Coverage findet auch in der CI-Pipeline statt.
Auf Continous Deployment verzichten wir, da es keine Produktionsumgebung gibt, auf welche
wir unsere Anwendung aufspielen könnten. Die fertig kompilierte Anwendung kann von GitHub
Actions heruntergeladen werden. Die Konfiguration der CI/CD Pipeline kann [hier](https://github.com/Chrissi-Ruege/HealthKeeper/blob/main/.github/workflows/dotnet.yml) eingesehen werden.

| ![image](https://github.com/Chrissi-Ruege/HealthKeeper/assets/20227840/f4692572-11ae-4cba-80c1-a9061f079af6) | 
|:--:| 
| *GitHub Actions Pipeline* |
