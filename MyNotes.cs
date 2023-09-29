public static class MyNotes
{
    public static string VariablesPageOne =
@"...
Hvis du vil vide hvordan forskellige variabler fungere så er du på den rigtige side.
Variabler er et sted hvor man opbevarer forskellige former for data.
Det kan være tal uden komma tal også kendt som en interger aka int.
Det kan være en string, som er bokstaver.
Det kan være tal med komma tal, float.
Og det kan være en bool som kan være sand eller falsk.

Eksempler
 int age = 18;
 string name = ""Anton, Alexander"";
 float awesomeLevel = 99.9f;
 bool TooCoolForSchool = true;
";

    public static string VariablesPageTwo =
@"...
Variabler er den mest grundlæggende del af kode som du kommer til at lære om.
De hjælper med at holde styr på store mængder af data som beskriver forskellige ting.
For eksempel så er denne tekst gemt i en 'string' som vi kan printe på hvillket som helst tidspunkt.
Lad os så gå over de forskellige variabler og deres funktion med nogle eksempler.
En 'int' kan være hvilket som helst hel tal, dvs. (1,2,3,4,5,6,7,8,9,10) osv.
En 'string' kan være hvilket som helst tekst, dvs. (Jeg har en rumraket i min have)
I en 'string' skal der være gåseøjne før du kan starte den tekst.
En 'float' kan være hvilket som helst komma tal, dvs. (1,645984. 98,5165) osv.
En 'bool' kan være true eller false dvs. (Er vi TooCoolForSchool?) True/False.
";


//Loops
public static string LoopsPageOne =
@"...
Loops er en funktion som får en variabel eller lign. til at gøre gentagende gange.
Der er 4 forskellige loops som du skal kende til de er.
While loop som gør noget mens et givent kriterie er opfyldt
For loop som gør noget flere gange med en specifik variabel eller lign.
Do while loop som gør noget hvis et Do loop er opfyldt og derefter køre den så sit while loop.
Nested loop som bruges når du vil have et loop inde i et andet loop.
På side 2 vil der være nogle eksempler.";

public static string LoopsPageTwo =
@"...
Eksempler.
While loop while(xxx = true){
    Console.WriteLine('True')
};
Så længe vores bool xxx = true vil den skrive true i terminalen.
--------------------------------------------------------------------------------------
For loop 
for (int i = 1; i <= 10; i++)
{
    Console.Wirteline(i);
}
--------------------------------------------------------------------------------------
do {
    Console.WriteLine('True') 
} while (xxx = true);

Do while loop først har vi aktionen og derefter kommer betingelserne.
Forskellen på et Do while loop og et while loop er at den i vores eksempel vil altid 
starte med at printe 'true' i konsolen ligemeget om xxx er sand eller falsk.

Nested loop

for(int)

Så længe tallet ikke er 10 dvs. er mindre end 10 så ville loopet bilve ved med at køre. Den 
";
}