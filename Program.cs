internal class Program
{
    private static void Main(string[] args)
    {
        //CREAR UN NUEVO DICCIONARIO
        Dictionary<string, string> diccionario = new();

        //AÑADIR ELEMENTOS A DICCIONARIO
        diccionario.Add("Nombre","Javier");
        diccionario.Add("Apellido","Morales");
        diccionario.Add("Edad", "17");
        diccionario.Add("Correo","javierevolution");

        //OBTENER EL NUMERO DE PARES INCLUIDOS EN EL DICCIONARIO
        Console.WriteLine("El total de elementos del diccionarios son: {0}", diccionario.Count);
        Console.ReadKey();

        //OBTENER TODAS LAS LLAVES DEL DICCIONARIO EN UNA LISTA
        Dictionary<string, string>.KeyCollection keyCall = diccionario.Keys;
        foreach (string key in keyCall)
        {
            Console.WriteLine(key);
        }
        Console.ReadKey();

        //OBTENER TODOS LOS VALORE DEL DICCIONARIO EN UNA LISTA
        Dictionary<string, string>.ValueCollection valueCall = diccionario.Values;
        foreach (string value in valueCall)
        {
            Console.WriteLine(value);
        }
        Console.ReadKey();

        //OBTENER LLAVES Y VALORES EN UNA LISTA
        foreach (KeyValuePair<string, string> pareja in diccionario)
        {
            Console.WriteLine("Llave: {0} - valor: {1}", pareja.Key, pareja.Value);
        }
        Console.ReadKey();

        //DETERINA SI EL DICCIONARIO CONTIENE UNA LLAVE ESPECIFICA
        if(diccionario.ContainsKey("Edad"))  Console.WriteLine("Esta llave si existe");
        else Console.WriteLine("Esta llave no se encuentra");
        Console.ReadKey();

        //ELIMINAR EL VALOR DE UNA CLAVE ESPECIFICA
        diccionario.Remove("Correo");
        foreach (KeyValuePair<string, string> pareja in diccionario)
        {
            Console.WriteLine("Llave: {0} - valor: {1}", pareja.Key, pareja.Value);
        }
        Console.ReadKey();

        //QUITAR TODAS LAS CLAVES Y LLAVES
        diccionario.Clear();
        if (diccionario.Count == 0) Console.WriteLine("Este diccionario se encuentra vacio");
        Console.ReadKey();
    }
}