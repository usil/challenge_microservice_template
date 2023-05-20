

# PASOS PARA EL RETO 02 EN COVERAGE

Para instalar:
dotnet tool install --global coverlet.console
dotnet tool install -g dotnet-reportgenerator-globaltool

Para capturar el test del coverage:
dotnet test --collect "Xplat Code Coverage"

comando de ejemplo para generar el reporte:
reportgenerator "-reports:.\UnitTestProject\TestResults\b45064cb-bf0b-448a-a7ea-202d60f18cb1\coverage.cobertura.xml" "-targetdir:coveragereport" -reporttypes:Html


![image](https://github.com/alxndr24/challenge_microservice_template/assets/49344337/73237b34-8c88-4696-80fd-93962ba26616)

