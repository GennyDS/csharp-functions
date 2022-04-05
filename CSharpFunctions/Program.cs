int quadratoeArray(int[] array)
{
    int[] copiarrey = (int[])array.Clone();

    int[] risultato = new int[copiarrey.Length];
    for (int i = 0; i < copiarrey.Length; i++)
    {
        risultato[i] = (int)Quadrato(copiarrey[i]);
    }
    return risultato;
}

double Quadrato(int numero)
{
    double risultato = Math.Pow(numero, 2);
    return risultato;

}


int sommaElementiArrey(int[] arrey)
{
 
    int[] copiarrey = (int[])arrey.Clone();
    int somma=0;
    for (int i = 0; i < copiarrey.Length; i++)
    {
       somma += copiarrey[i];
    }
    return somma;
}



void StampaArrayInteri(int[] array)
{
    int ultimoIndiceArray = array.Length - 1;
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        if (i == ultimoIndiceArray)
        {
            Console.Write(array[i]);
        }
        else
        {
            Console.Write(array[i] + ", ");
        }
    }
    Console.WriteLine("]");
}




int[] arrey = new int[] { 2, 6, 7, 5, 3, 9 };

Console.WriteLine("l'arrey è: ");
StampaArrayInteri(arrey);
Console.WriteLine("la somma è: ");
sommaElementiArrey(arrey);
