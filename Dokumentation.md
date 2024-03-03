# LA 1303

## 1 Informieren

### 1.1 Ihr Projekt

Mein Projekt ist ein einfaches Taschenrechner in Winforms.

### 1.2 Arbeitspakete

| Nr. | Typ | Verbindlichkeit | Beschreibung |
| --- |---- | ----- | --------- |
| 1.| muss | Funktional | Die Applikation kann man öffnen. |
| 2.| muss | Funktional | Man kann Knöpfe drücken. |
| 3.| muss | Funktional | Man kann Additionen machen. |
| 4.| muss | Funktional | Man kann Subtraktionen machen. |
| 5.| muss | Funktional | Man kann Multiplizieren. |
| 6.| muss | Funktional | Man kann Dividieren. |
| 7.| muss | Funktional | Man kann die Eingabe oder Ausgabe löschen.|
| 8.| muss | Qualität | Man kann bis zu 999'999'999'999 rechnen. |
| 9.| kann | Qualität | Der Taschenrechner sieht schön aus. |
| 10.| muss | Randbedingung | Das Frontend ist mit Winforms umgesetzt worden. |
| 11.| muss | Randbedingung | Das Backend ist mit C# umgestzt worden. |

### 1.3 Testfallspezifikationen

| TC-№ | Ausgangslage | Eingabe | Erwartete Ausgabe |
| ---- | ------------ | ------- | ----------------- |
| 1.1  | PC gestartet | Applikation öffnen | Applikation öffnet sich mit Taschenrechner. |
| 2.1  | Applikation gestartet | Knöpfe auf Rechner drücken 1 = | 1 |
| 3.1  | Applikation gestartet | Addition eingeben 1 + 1 | 2 |
| 4.1  | Applikation gestartet | Subtraktion eingeben 2 - 1 | 1 |
| 5.1  | Applikation gestartet | Multiplikation eingeben 2 * 2 | 4 |
| 6.1  | Applikation gestartet | Division eingeben 4 / 2 | 2 |
| 7.1  | Appliaktion gestartet und irgendeine Rechnung eingegeben. | c drücken | Eingabe gelöscht |
| 7.2  | Applikation gestartet und irgendeine Rechnung wurde durchgeführt. | c drücken | Ausgabe gelöscht |
| 8.1  | Applikation gestartet | 999'999'999'999 | 999'999'999'999 |
| 8.2  | Applikation gestartet | 1'000'000'000 | Error |

### 1.4 Diagramme


![Screenshot 2024-01-19 083534](https://github.com/Plasticgun21/LA1303/assets/110892742/1bc169e7-30ee-4a49-98ee-58b4f6268177)


## 2 Planen

| Nr. | Datum | Zuständig | Beschreibung | geplante Zeit |
| ---- | ----- | --------- | ------------ | ------------- |
| 1. | 19.1.24 | Luca.J.W | Arbeitspakete | 20 min |
| 2. | 19.1.24 | Luca.J.W | Testfälle | 20 min |
| 3. | 19.1.24 | Luca.J.W | Diagramm machen | 10 min |
| 4. | 19.1.24 | Luca.J.W | Taschenrechner Layout machen | 60 min |
| 5. | 19.1.24 | Luca.J.W | Knöfpe machen | 45 min |
| 6. | 26.1.24 | Luca.J.W | Eingabe/Ausgabe machen | 30 min |
| 7. | 26.1.24/2.2.24 | Luca.J.W | Backend machen | 240 min |
| 8. | 2.2.24 | Luca.J.W | Testfälle ausführen | 30 min |
| 9. | 2.2.24 | Luca.J.W | Testprotokoll machen | 20 min |
| 10. | 9.2.24 | Luca.J.W | Testbericht machen | 20 min |
| 11. | 9.2.24 | Luca.J.W | Portfolio machen | 180 min |

## 3 Entscheiden

Ich habe mir entschieden alle mein Projekt zu machen ausser den rechnungs limit, weil ich das unnötig finde.

## 4 Realisieren

| AP-№ | Datum | Zuständig | geplante Zeit | tatsächliche Zeit |
| ---- | ----- | --------- | ------------- | ----------------- |
| 4.   |19.1.24| Luca.J.W  |       60 min  |          75 min   |
| 5.   |19.1.24| Luca.J.W  |       45 min  |          50 min   |
| 6.   |19.1.24| Luca.J.W  |       30 min  |          40 min   |
| 7.   |26.1.24| Luca.J.W  |       240 min  |          240 min   |




## 5 Kontrollieren

### 5.1 Testprotokoll

| Test-Nr. |Testfall-Nr.| Datum | Resultat | Tester |
| ---- |---- | ----- | -------- | ------ |
| 1.1.1 |1.1|16.2.24 |funktioniert|Luca.J.W|
| 2.1.1 |2.1|16.2.24 |funktioniert nicht|Luca.J.W|
| 3.1.1 |3.1|16.2.24 |funktioniert|Luca.J.W|
| 4.1.1 |4.1|16.2.24 |funktioniert|Luca.J.W|
| 5.1.1 |5.1|16.2.24 |funktioniert|Luca.J.W|
| 6.1.1 |6.1|16.2.24 |funktioniert|Luca.J.W|
| 7.1.1 |7.1|16.2.24 |funktioniert|Luca.J.W|
| 7.2.1 |7.2|16.2.24 |funktioniert|Luca.J.W|
| 8.1.1 |8.1|16.2.24 |funktioniert|Luca.J.W|
| 8.2.1 |8.2|16.2.24 |functoniert nicht|Luca.J.W|

### 5.2 Testabschlussbericht

Die meisten Tests sind gut gegangen, obwohl es noch viele Probleme hat kann man mehr Funktionen zum Programm hinzufügen.


