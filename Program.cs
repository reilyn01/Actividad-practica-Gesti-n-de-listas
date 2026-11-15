//Proyecto Gestion de listas

// Listas que almacenan los productos y sus precios
List<string> productos = new List<string>() {"Pan", "Cafe", "Chocolate", "Tee" };
List<double> precios = new List<double>() { 30 , 40 , 60 , 25 };
int opcion = 1;


// Agrega un producto y su precio a las listas
static void AgregarProductoYprecio(List<string> productos, List<double> precios)
{
    Console.Write("Ingrese un producto: ");
    string nuevo = Console.ReadLine();

    Console.Write("Ingrese un precio: ");
    double nuevoP = Convert.ToDouble(Console.ReadLine());

    productos.Add(nuevo);
    precios.Add(nuevoP);

}

// Muestra los productos y sus precios
static void MostrarProductosYprecio(List<string> productos , List<double> precios)
{
    Console.WriteLine("Productos: ");
    foreach (string p in productos)
    {
        
        Console.WriteLine("- " + p);
    };

    Console.WriteLine("precios: ");
    foreach (double pc in precios)
    {
        
        Console.WriteLine("- " + pc);
    }

}

// Busca si un producto y precio existe en la lista
static void BuscarProductoYprecio(List<string> productos , List<double> precios)
{
    Console.Write("Buscar producto: ");
    string buscar = Console.ReadLine();

    Console.Write("Buscar precio: ");
    double buscarP = Convert.ToDouble(Console.ReadLine());

    if (productos.Contains(buscar))
        Console.WriteLine("Encontrado");
    else
        Console.WriteLine("No encontrado");

    if (precios.Contains(buscarP))
        Console.WriteLine("Encontrado");
    else
        Console.WriteLine("No encontrado");


}

// Modifica el producto y el precio 
static void ModificarProductoYprecio(List<string> productos , List<double> precios)
{
    Console.Write("Ingrese la posicion del producto que desea modificar: ");
    int posicion = Convert.ToInt32(Console.ReadLine());

    Console.Write("Ingrese la posicion del precio que desea modificar: ");
    int posicionP = Convert.ToInt32(Console.ReadLine());

    Console.Write("Nuevo nombre: ");
    productos[posicion] = Console.ReadLine();

    Console.Write("Nuevo precio: ");
    precios[posicionP] = Convert.ToInt32(Console.ReadLine());
}

// Elimina un producto y  precio
static void EliminarProductoYprecio(List<string> productos, List<double> precios)
{
    Console.Write("Eliminar producto: ");
    string eliminar = Console.ReadLine();

    Console.Write("Eliminar precio: ");
    double eliminarP = Convert.ToDouble(Console.ReadLine());

    productos.Remove(eliminar);
}

// Calcula las estadísticas de los productos
static void MostrarEstadisticas(List<string> productos, List<double> precios)
{
    Console.WriteLine("Total de productos: " + productos.Count);
    Console.WriteLine("Precio mayor: " + precios.Max());
    Console.WriteLine("Precio menor: " + precios.Min());
    Console.WriteLine("Promedio: " + precios.Average());
}

// Ordena los productos en orden alfabético y ordena los precios de menor a mayor
static void OrdenarProductosYprecio(List<string> productos , List<double> precios)
{
    productos.Sort();
    precios.Sort();

    Console.WriteLine("Productos:");
    foreach (string o in productos)
    {
        Console.WriteLine("- " + o);
    }

    Console.WriteLine("Precios:");
    foreach (double e in precios)
    {
        Console.WriteLine("- " + e);
    }
}




// Repite el menú hasta seleccionar la opción 0

while (opcion != 0) {

    Console.WriteLine("1. Agregar");
    Console.WriteLine("2. Mostrar");
    Console.WriteLine("3. Buscar");
    Console.WriteLine("4. Modificar");
    Console.WriteLine("5. Eliminar");
    Console.WriteLine("6. Mostrar estadistica");
    Console.WriteLine("7. Ordenar lista");
    Console.WriteLine("0. Salir");

    Console.WriteLine("Seleccione una opcion");
    opcion = Convert.ToInt32(Console.ReadLine());


    // Ejecuta el método  a la opción elegida
    switch (opcion)
    {
        case 1:
            AgregarProductoYprecio(productos, precios);
            break;

        case 2:
            MostrarProductosYprecio(productos, precios);
            break;

        case 3:
            BuscarProductoYprecio(productos , precios);
            break;

        case 4:
            ModificarProductoYprecio(productos , precios);
            break;

        case 5:
            EliminarProductoYprecio(productos , precios );
            break;

        case 6:
            MostrarEstadisticas(productos, precios);
            break;

        case 7:
            OrdenarProductosYprecio(productos, precios);
            break;
    }

}

