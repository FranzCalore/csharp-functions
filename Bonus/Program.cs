// See https://aka.ms/new-console-template for more information

Console.WriteLine("Questo programma genererà un array secondo le tue richieste:");
Console.WriteLine("Quanti numeri vuoi inserire nell'array?");
int grandezzaArrey = int.Parse(Console.ReadLine());
Console.WriteLine();
int[] arrayNumeri=CreaArray(grandezzaArrey);
Console.WriteLine("Calcolo in corso...");
Thread.Sleep(500);
Console.WriteLine("...");
Thread.Sleep(1000);
StampaArrayInteri(arrayNumeri);
int[] arrayAlQuadrato = ElevaArrayQuadrato(arrayNumeri);
Console.WriteLine("Calcolo dell'array quadro in corso...");
Thread.Sleep(1000);
StampaArrayInteri(arrayAlQuadrato);
Console.WriteLine("Recupero del vecchio array in corso, NON SPEGNERE...");
Thread.Sleep(1000);
StampaArrayInteri(arrayNumeri);
Console.WriteLine("Non andartene, sto sommando tutti i tuoi numeri...");
Thread.Sleep(1500);
Console.WriteLine("Calcolo non riuscito");
Thread.Sleep(2000);
Console.WriteLine("Aspetta, mi sono sbagliato, eccolo:");
Console.Write("La somma di tutti i numeri è: ");
Console.Write(SommaElementiArray(arrayNumeri) + "\n");

Console.Write("La somma di tutti i quadrati è: ");
Console.Write(SommaElementiArray(arrayAlQuadrato));

Console.WriteLine("");
Console.WriteLine("GRAZIE PER AVER USATO, GENERATORE DI ARRAY, POWERED BY VISUALSTUDIO2022©");











// ---------------------- FUNCTIONS ------------------------------

void StampaArrayInteri(int[] arrayInteri)

{
    string arrayStampato = "[";
    for (int i = 0; i < arrayInteri.Length; i++)
    {

        if (arrayInteri[i] == arrayInteri[arrayInteri.Length - 1])
        {
            arrayStampato = arrayStampato + arrayInteri[i];
        }
        else
        {
            arrayStampato = arrayStampato + arrayInteri[i] + ", ";
        }

    }
    arrayStampato = arrayStampato + "]";
    Console.WriteLine(arrayStampato);
}

int QuadratoNumero(int num)
{
    int quadrato = num * num;
    return quadrato;
}

int[] ElevaArrayQuadrato(int[] arrayNumeri)
{
    int[] arrayQuadrato = (int[])arrayNumeri.Clone();
    for (int i = 0; i < arrayQuadrato.Length; i++)
    {
        arrayQuadrato[i] = QuadratoNumero(arrayQuadrato[i]);
    }
    return arrayQuadrato;
}

int SommaElementiArray(int[] arrayNumeri)
{
    int somma = 0;
    foreach (int number in arrayNumeri)
    {
        somma += number;
    }
    return somma;
}

int[] CreaArray(int grandezza)
{
    int[] nuovoArray = new int[grandezza];
    for (int i=0; i <grandezza; i++)
    {
        Console.WriteLine("Dimmi il " + (i+1) + "° numero");
        int numero = int.Parse(Console.ReadLine());
        nuovoArray[i]= numero;
    }
    return nuovoArray;
}

