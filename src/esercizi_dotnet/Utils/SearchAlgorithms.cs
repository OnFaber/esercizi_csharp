class SearchAlgorithms
{
    /// <summary>
    /// Esegue una ricerca sequenziale su un array per trovare la posizione di un valore specifico.
    /// La ricerca viene effettuata confrontando ogni elemento dell'array con il valore cercato.
    /// </summary>
    /// <param name="arr">L'array di interi in cui cercare.</param>
    /// <param name="value">Il valore da cercare nell'array.</param>
    /// <returns>
    /// L'indice del valore se trovato; -1 se il valore non è presente nell'array.
    /// </returns>
    public static int SequentialSearch(int[] arr, int value)
    {
        // Scorre ogni elemento dell'array
        for (int i = 0; i < arr.Length; i++)
        {
            // Se trova il valore cercato, restituisce l'indice
            if (value == arr[i])
            {
                return i;
            }
        }

        // Il valore non è stato trovato
        return -1;
    }

    /// <summary>
    /// Esegue una ricerca binaria su un array ordinato per trovare la posizione di un valore specifico.
    /// L'array deve essere ordinato in ordine crescente affinché l'algoritmo funzioni correttamente.
    /// </summary>
    /// <param name="arr">L'array ordinato di interi in cui cercare.</param>
    /// <param name="value">Il valore da cercare nell'array.</param>
    /// <returns>
    /// L'indice del valore se trovato; -1 se il valore non è presente nell'array.
    /// </returns>
    public static int BinarySearch(int[] arr, int value)
    {
        int mid;
        int low = 0, high = arr.Length - 1;

        // Ciclo finché la ricerca non si restringe completamente
        while (low <= high)
        {
            // Calcola l'indice centrale evitando overflow
            mid = low + (high - low) / 2;

            // Controlla se il valore centrale è quello cercato
            if (arr[mid] == value)
            {
                return mid;
            }
            // Se il valore centrale è minore, cerca nella metà destra
            else if (arr[mid] < value)
            {
                low = mid + 1;
            }
            // Altrimenti cerca nella metà sinistra
            else
            {
                high = mid - 1;
            }
        }

        // Il valore non è stato trovato
        return -1;
    }

}
