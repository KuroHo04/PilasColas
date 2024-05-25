Arreglos.Pilas pilas = new Arreglos.Pilas(10);
Arreglos.Colas cola = new Arreglos.Colas(10);

Console.WriteLine(cola.ObtenerDatos());
Console.WriteLine("-------");
cola.Agregar("A");
cola.Agregar("B");
cola.Agregar("C");
cola.Agregar("D");
cola.Agregar("E");
cola.Agregar("F");
Console.WriteLine(cola.ObtenerDatos());
Console.WriteLine("-------");

Arreglos.Pilas pilas = new Arreglos.Pilas(10);
Console.WriteLine(pilas.ObtenerDatos());
Console.WriteLine("-------");
pilas.Agregar("A");
pilas.Agregar("B");
pilas.Agregar("C");
pilas.Agregar("D");
pilas.Agregar("E");
pilas.Agregar("F");
Console.WriteLine(pilas.ObtenerDatos());
Console.WriteLine("-------");

pilas.Eliminar();
Console.WriteLine(pilas.ObtenerDatos());
Console.WriteLine("-------");
pilas.Eliminar();
Console.WriteLine(pilas.ObtenerDatos());
Console.WriteLine("-------");
    }
}