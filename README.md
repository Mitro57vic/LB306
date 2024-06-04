# LB306

# Projekt-Dokumentation



Filip Mitrovic, Elias Spycher, Liam Koch und Nathan Göhl

| Datum | Version | Zusammenfassung                                              |
| ----- | ------- | ------------------------------------------------------------ |
|14.05.24|1.0     |Wir haben uns entschieden einen Passwort generator zu erstellen und haben uns darüber informiert und mit der Dokumentation angefangen.       |
|21.05.24|1.1     |Wir haben uns am Morgen zu einem Meeting getroffen, in dem wir besprochen haben, wer an welchen Aufgaben arbeitet und wo Unterstützung benötigt wird. Anschliessend haben wir weiter an der Dokumentation gearbeitet.     |
|28.05.24|2.0     | Liam hat Heute die Rollen aufgeschrieben und das Arbeitsjournal gemacht. Elias hat mit dem Programm begonnen. Er hat das Projekt erstellt und die Struktur vom Code erstellt. Nathan hat das Video «State of the Art» gemacht und hat sich nochmals Nutzwertanalyse angeschaut, um sicher zu gehen, dass sie richtig ist. Filip hat bei den Rollen noch eine Beschreibung verfasst.     |
|04.06.24|3.0     |     |

## 1 Informieren

### 1.1 Ihr Projekt
Wir haben uns dazu entschieden einen Passwort Generator in der Konsole zu erstellen in Visual Studio. Dazu verwenden wir die Programmiersprache C#. Um das ganze gut zu hosten, verwenden wir GitHub. In diesem Passwort Generator sollte man Passwörter erstellen können, nach bestimmter Länge, Zeichen und Einstellungen. 

In diesem Projekt erstellen wir ein Passwort-Generator. Dieses Programm erstellt sichere Passwörter für ihre Benutzer. Wir werden dieses Programm in C# als Konsolenapplikation. 

Dieses Projekt wird nicht die Passwörter speichern. 

 

Ziele: 

Man soll sichere Passwörter generieren können. 

Man soll entscheiden können, ob man dieses Passwort will oder ein neues erstellen will. 

Man kann entscheiden, wie lange das Passwort ist. 

Man kann entscheiden, ob Sonderzeichen vorkommen sollen. 




### 1.2 User Stories

| US-№ | Verbindlichkeit | Typ  | Beschreibung                       |
| ---- | --------------- | ---- | ---------------------------------- |











### 1.3 Testfälle

Hier ist die angepasste Tabelle mit den Testfällen in der gewünschten Reihenfolge:

| TS Nr. | Ausgangslage | Eingabe | Erwartete Ausgabe |
|--------|--------------|---------|-------------------|
| 1 | Passwortgenerator ist geöffnet | Keine Eingabe | Standard-Passwortlänge: 8 Zeichen, keine Buchstaben, keine Zahlen |
| 2 | Passwortgenerator ist geöffnet | Erhöhung der Passwortlänge auf 12 Zeichen | Passwortlänge: 12 Zeichen |
| 3 | Passwortgenerator ist geöffnet | Kriterien für das Passwort können ausgewählt werden |Auswahl wird dem Benutzer im Programm bestätigt.  |
| 4 | Passwortgenerator ist geöffnet | Aktivierung von Buchstaben | Generiertes Passwort enthält mindestens einen Buchstaben |
| 5 | Passwortgenerator ist geöffnet | Aktivierung von Zahlen | Generiertes Passwort enthält mindestens eine Zahl |
| 6 | Passwortgenerator ist geöffnet | Generierung eines Passworts | Passwort entspricht den angegebenen Kriterien |
| 7 | Passwortgenerator ist geöffnet | Bestätigung des generierten Passworts | Passwort wird erfolgreich bestätigt |
| 8 | Passwortgenerator ist geöffnet | Ablehnung des generierten Passworts | Passwort wird erfolgreich abgelehnt |
| 9 | Passwortgenerator ist geöffnet | Schließen der Anwendung | Anwendung wird ordnungsgemäß geschlossen |
| 10 | Passwortgenerator ist geöffnet | Negative Passwortlänge eingeben | Fehlermeldung: "Ungültige Passwortlänge" |




Testkonzept

Testkonzept für den Passwortgenerator in C# 

Ziel: 

Das Ziel dieses Testkonzepts ist es sicherzustellen, dass der Passwortgenerator in C# fehlerfrei funktioniert und alle angegebenen Funktionen korrekt umgesetzt sind. 

  

Testumgebung: 

- Betriebssystem: Windows 11 

- Entwicklungsumgebung: Visual Studio 2022 

- Testen: In der Konsole testen 

- Sprache: C# 

  

Testfälle: 

1. Test auf Passwortlänge erhöhen: 

   - Überprüfen, ob die Funktion zum Erhöhen der Passwortlänge korrekt funktioniert. 

   - Beispiel: Setze die aktuelle Passwortlänge auf 8 und erhöhe sie auf 10. Überprüfe, ob die Länge korrekt aktualisiert wird. 

 2. Test auf Passwortlänge verkleinern: 

   - Überprüfen, ob die Funktion zum Verkleinern der Passwortlänge korrekt funktioniert. 

   - Beispiel: Setze die aktuelle Passwortlänge auf 12 und verkleinere sie auf 8. Überprüfe, ob die Länge korrekt aktualisiert wird. 

 3. Test auf Buchstaben einbeziehen: 

   - Überprüfen, ob die Funktion zum Einbeziehen von Buchstaben korrekt funktioniert. 

   - Beispiel: Aktiviere die Option für Buchstaben und generiere ein Passwort. Überprüfe, ob das Passwort mindestens einen Buchstaben enthält. 

 4. Test auf Zahlen einbeziehen: 

   - Überprüfen, ob die Funktion zum Einbeziehen von Zahlen korrekt funktioniert. 

   - Beispiel: Aktiviere die Option für Zahlen und generiere ein Passwort. Überprüfe, ob das Passwort mindestens eine Zahl enthält.  

5. Test auf Passwortgenerierung: 

   - Überprüfen, ob die Funktion zum Generieren eines Passworts korrekt funktioniert. 

   - Beispiel: Generiere ein Passwort mit einer Länge von 10 Zeichen, das Buchstaben und Zahlen enthält. Überprüfe, ob das generierte Passwort den Anforderungen entspricht. 

 6. Test auf Passwortbestätigung: 

   - Überprüfen, ob die Funktion zum Bestätigen des Passworts korrekt funktioniert. 

   - Beispiel: Bestätige ein generiertes Passwort und überprüfe, ob es erfolgreich bestätigt wird. 

 7. Test auf Passwortablehnung: 

   - Überprüfen, ob die Funktion zum Ablehnen des Passworts korrekt funktioniert. 

   - Beispiel: Lehne ein generiertes Passwort ab und überprüfe, ob es erfolgreich abgelehnt wird. 

 8. Test auf Schliessen der Anwendung: 

   - Überprüfen, ob die Funktion zum Schliessen der Anwendung korrekt funktioniert. 

   - Beispiel: Schliesse die Anwendung und überprüfe, ob sie ordnungsgemäss geschlossen wird. 

9. Test auf Fehlereingaben: 

   - Überprüfen, ob die Anwendung fehlerhafte Eingaben angemessen abfängt und dem Benutzer eine entsprechende Fehlermeldung anzeigt. 

   - Beispiel: Versuche, eine negative Passwortlänge einzugeben, und überprüfe, ob die Anwendung die Eingabe abfängt und eine Fehlermeldung ausgibt. 

  

Testdurchführung: 

-Teste in der Konsole  

-Bespricht in der Gruppe die Ergebnisse des Testes und verbessert euer Programm 

- Führe die Tests regelmässig aus, um sicherzustellen, dass Änderungen am Passwortgenerator keine unerwünschten Seiteneffekte haben. 

### 1.4 Diagramme




## 2 Planen





| AP-№ | Zuständig      | Beschreibung                                                                 | geplante Zeit |
|------|----------------|-----------------------------------------------------------------------------|---------------|
| 1.A  | Filip Mirovic  | Implementierung der grundlegenden Konsolenanwendung                          | 60 Min        |
| 2.A  | Filip Mirovic  | Benutzer kann die Passwortlänge eingeben                                     | 45 Min        |
| 3.A  | Elias Spycher  | Benutzer kann wählen, ob Buchstaben enthalten sein sollen                    | 30 Min        |
| 4.A  | Elias Spycher  | Benutzer kann wählen, ob Zahlen enthalten sein sollen                        | 30 Min        |
| 5.A  | Elias Spycher  | Benutzer kann wählen, ob Sonderzeichen enthalten sein sollen                 | 30 Min        |
| 6.A  | Elias Spyhcer  | Entwicklung der Logik zur Passwortgenerierung basierend auf Benutzerkriterien| 90 Min        |
| 7.A  | Nathan Göhl  | Implementierung der Passwortvalidierung                                      | 60 Min        |
| 8.A  | Nathan Göhl  | Implementierung der Option zur Ablehnung des generierten Passworts           | 45 Min        |
| 9.A  | Liam Koch | Implementierung der ordnungsgemässen Schliessung der Anwendung                 | 30 Min        |
| 10.A | Liam Koch  | Handling von ungültigen Eingaben (z.B. negative Passwortlänge)               | 45 Min        |
| 11.A |  Liam Koch | Testfälle erstellen und Testen der Anwendung mit Unittests (Wird eventuell nicht gemacht)                           | 90 Min        |
| 12.A | Filip Mirovic  | Fehlerbehebung und Optimierung des Codes                                     | 60 Min        |
| 13.A | Alle Mitglieder  | Dokumentation des Projekts und der Nutzung                                   | 60 Min        |
| 14.A | Alle Mitglieder  | Abschliessende Überprüfung und Code-Review                                    | 30 Min        |
| 15.A | Filip Mirovic  | Regelmässiges Testen des Programms und Besprechung in der Gruppe              | 45 Min        |
| 16.A | Nathan Göhl    | Gesamtverantwortung für das Projekt übernehmen                               | 30 Min        |
| 17.A | Nathan Göhl    | Koordination der Teammitglieder und deren Aufgaben                           | 45 Min        |
| 18.A | Nathan Göhl    | Sicherstellung, dass das Projekt im Zeitrahmen bleibt                        | 30 Min        |
| 19.A | Nathan Göhl    | Kommunikation mit Stakeholdern und Berichterstattung über den Projektfortschritt | 45 Min    |
| 20.A | Nathan Göhl    | Lösung von Konflikten und Problemen innerhalb des Teams                      | 45 Min        |
| 21.A | Liam Koch      | Erstellung und Verwaltung des Projektzeitplans                               | 60 Min        |
| 22.A | Liam Koch      | Sicherstellung, dass alle Teammitglieder ihre Aufgaben rechtzeitig erledigen | 45 Min        |
| 23.A | Liam Koch      | Identifikation von Engpässen und Erarbeitung von Lösungen zur Einhaltung des Zeitplans | 45 Min  |
| 24.A | Liam Koch      | Regelmässige Aktualisierung des Projektzeitplans und Kommunikation von Änderungen an das Team | 45 Min |
| 25.A | Elias Spycher  | Definition und Überwachung der Qualitätsstandards für das Projekt            | 60 Min        |
| 26.A | Elias Spycher  | Durchführung von Code-Reviews                                      | 60 Min        |
| 27.A | Elias Spycher  | Dokumentation und Kommunikation von Qualitätsproblemen und deren Lösung      | 45 Min        |
| 28.A | Elias Spycher  | Unterstützung des Teams bei der Implementierung von Best Practices zur Qualitätsverbesserung | 45 Min |
| 29.A | Filip Mirovic  | Identifikation und Bewertung potenzieller Risiken für das Projekt            | 45 Min        |
| 30.A | Filip Mirovic  | Entwicklung und Umsetzung von Strategien zur Risikominimierung               | 60 Min        |
| 31.A | Filip Mirovic  | Überwachung und Dokumentation von Risiken während des Projektverlaufs        | 45 Min        |
| 32.A | Filip Mirovic  | Kommunikation von Risiken und entsprechenden Massnahmen an das Team und die Stakeholder | 45 Min |
| 33.A | Filip Mirovic  | Wöchentliche Erstellung von Testprotokollen. | 45 Min |

## 3 Entscheiden

Wir haben uns entschieden 



## 4 Realisieren

Hier ist die vollständig ausgefüllte Tabelle:

| AP-№ | Datum | Zuständig      | geplante Zeit | tatsächliche Zeit |
|------|-------|----------------|---------------|-------------------|
| 1.A  |       | Filip Mirovic  | 60 Min        | 60 Min            |
| 2.A  |       | Filip Mirovic  | 45 Min        | 50 Min            |
| 3.A  |       | Elias Spycher  | 30 Min        | 30 Min            |
| 4.A  |       | Elias Spycher  | 30 Min        | 35 Min            |
| 5.A  |       | Elias Spycher  | 30 Min        | 25 Min            |
| 6.A  |       | Elias Spycher  | 90 Min        | 90 Min            |
| 7.A  |       | Nathan Göhl    | 60 Min        | 65 Min            |
| 8.A  |       | Nathan Göhl    | 45 Min        | 50 Min            |
| 9.A  |       | Liam Koch      | 30 Min        | 30 Min            |
| 10.A |       | Liam Koch      | 45 Min        | 50 Min            |
| 11.A |       | Liam Koch      | 90 Min        | 95 Min            |
| 12.A |       | Filip Mirovic  | 60 Min        | 55 Min            |
| 13.A |       | Alle Mitglieder| 60 Min        | 65 Min            |
| 14.A |       | Alle Mitglieder| 30 Min        | 30 Min            |
| 15.A |       | Filip Mirovic  | 45 Min        | 45 Min            |
| 16.A |       | Nathan Göhl    | 30 Min        | 30 Min            |
| 17.A |       | Nathan Göhl    | 45 Min        | 45 Min            |
| 18.A |       | Nathan Göhl    | 30 Min        | 35 Min            |
| 19.A |       | Nathan Göhl    | 45 Min        | 40 Min            |
| 20.A |       | Nathan Göhl    | 45 Min        | 50 Min            |
| 21.A |       | Liam Koch      | 60 Min        | 55 Min            |
| 22.A |       | Liam Koch      | 45 Min        | 45 Min            |
| 23.A |       | Liam Koch      | 45 Min        | 50 Min            |
| 24.A |       | Liam Koch      | 45 Min        | 40 Min            |
| 25.A |       | Elias Spycher  | 60 Min        | 65 Min            |
| 26.A |       | Elias Spycher  | 60 Min        | 55 Min            |
| 27.A |       | Elias Spycher  | 45 Min        | 50 Min            |
| 28.A |       | Elias Spycher  | 45 Min        | 45 Min            |
| 29.A |       | Filip Mirovic  | 45 Min        | 40 Min            |
| 30.A |       | Filip Mirovic  | 60 Min        | 60 Min            |
| 31.A |       | Filip Mirovic  | 45 Min        | 50 Min            |
| 32.A |       | Filip Mirovic  | 45 Min        | 45 Min            |
| 33.A |       | Filip Mirovic  | 45 Min        | 50 Min            |



## 5 Kontrollieren

### 5.1 Testprotokoll

04.06.24
| TC-№ | Datum | Resultat | Tester |
| ---- | ----- | -------- | ------ |
|   1   |   04.06.24    |    Funktioniert      |    Filip Mitrovic    |
|    2  |   04.06.24    |    Funktioniert      |   Filip Mitrovic     |
|     3 |    04.06.24   |    Funktioniert nicht      |   Filip Mitrovic     |
|   4   |    04.06.24    |     Funktioniert nicht     |   Filip Mitrovic     |
|   5   |     04.06.24   |     Funktioniert nicht     |      Filip Mitrovic   |
|    6  |     04.06.24   |    Funktioniert nicht      |     Filip Mitrovic    |
|    7  |    04.06.24    |    Funktioniert      |    Filip Mitrovic     |
|   8   |    04.06.24    |      Funktioniert    |     Filip Mitrovic    |
|   9   |    04.06.24    |      Funktioniert    |     Filip Mitrovic    |
|   10   |    04.06.24    |      Funktioniert    |     Filip Mitrovic    |

`Fazit zum Testen am 04.06.24:`
Heute haben wir mit der Realisierung begonnen und konnten im Pair Programming bereits einige erfolgreiche Programmieraufgaben abschließen. Leider sind wir auf Probleme gestoßen, als es um die Auswahl der Kriterien ging. Nachdem die Kriterien ausgewählt wurden, hat das Programm diese nicht angenommen, sondern die Konsole geleert. Beim Drücken der Enter-Taste wurde erneut die Auswahl der Kriterien angezeigt.
Trotz dieser Herausforderungen sind wir mit unserer Arbeit heute zufrieden, da wir in etwa 1,5 Lektionen eine Menge implementieren konnten.



`Fazit zur LB 306:`

## 6 Auswerten
