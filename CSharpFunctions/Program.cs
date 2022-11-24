// See https://aka.ms/new-console-template for more information

int[] arrayNumeri = { 2, 6, 7, 5, 3, 9 };

StampaArrayInteri(arrayNumeri);

int[] arrayAlQuadrato = elevaArrayQuadrato(arrayNumeri);

Console.WriteLine("L'array al quadrato è: ");
StampaArrayInteri(arrayAlQuadrato);

Console.WriteLine("L'array originale era: ");
StampaArrayInteri(arrayNumeri);

Console.Write("La somma di tutti i numeri è: ");
Console.Write(sommaElementiArray(arrayNumeri)+"\n");

Console.Write("La somma di tutti i quadrati è: ");
Console.Write(sommaElementiArray(arrayAlQuadrato));












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

int quadratoNumero(int num)
{
    int quadrato = num * num;
    return quadrato;
}

int[] elevaArrayQuadrato(int[] arrayNumeri)
{
    int[] arrayQuadrato = (int[])arrayNumeri.Clone();
    for (int i = 0; i < arrayQuadrato.Length; i++)
    {
        arrayQuadrato[i] = quadratoNumero(arrayQuadrato[i]); 
    }
    return arrayQuadrato;
}

int sommaElementiArray(int[] arrayNumeri)
{
    int somma=0;
    foreach(int number in arrayNumeri)
    {
        somma += number;
    }
    return somma;
}