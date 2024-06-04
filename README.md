# LB306

# Projekt-Dokumentation



Filip Mitrovic, Elias Spycher, Liam Koch und Nathan Göhl

| Datum | Version | Zusammenfassung                                              |
| ----- | ------- | ------------------------------------------------------------ |
|14.05.24|1.0     |Wir haben uns entschieden einen Passwort generator zu erstellen und haben uns darüber informiert und mit der Dokumentation angefangen.       |
|21.05.24|1.1     |Wir haben uns am Morgen zu einem Meeting getroffen, in dem wir besprochen haben, wer an welchen Aufgaben arbeitet und wo Unterstützung benötigt wird. Anschliessend haben wir weiter an der Dokumentation gearbeitet.     |

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

| AP-№ | Zuständig | Beschreibung | geplante Zeit |
| ---- |  --------- | ------------ | ------------- |





## 3 Entscheiden

Wir haben uns entschieden 



## 4 Realisieren

| AP-№ | Datum | Zuständig | geplante Zeit | tatsächliche Zeit |
| ---- | ----- | --------- | ------------- | ----------------- |




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

`Fazit testen 04.06.24:`



`Fazit zur LB 306:`

## 6 Auswerten
