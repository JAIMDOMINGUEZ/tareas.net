using models;
namespace Ejercicio1;
{
    internal class Registro
    {
      
    Libreria li = new Libreria();
		


    public void MostrarMenu(){
        int select =0;
        while (select<1&&select>5)
        {
        Console.WriteLine("Menu");
        Console.WriteLine("1.Agregar Pelicula");
        Console.WriteLine("2.Editar Pelicula");
        Console.WriteLine("3.Eliminar Pelicula");
        Console.WriteLine("4.Mostrar Pelicula");
        Console.WriteLine("5.Mostrar todas las Peliculas");
        Console.WriteLine("______________________________");
        select =int.Parse(Console.ReadLine());
        
            
        }
        switch (select)
        {
                case 1: MostrarMenu1();
                break;
                case 2:MostrarMenu2();
                break;
                case 3:MostrarMenu3();
                break;
                case 4:MostrarMenu4();
                break;
                case 5: MostrarMenu5();

                break;
            
        }
    }
    public void MostrarMenu1(){
        Console.WriteLine("|AgregarPelicula|");
        Console.WriteLine("Ingresa rl nombre de la pelicula");
        string nombre =Console.ReadLine();
        Console.WriteLine("Ingresa el genero de la pelicula");
        string genero =Console.ReadLine();
        Console.WriteLine("ingresa el año");
        int año =int.Parse(Console.ReadLine());
        Console.WriteLine("Ingresa el director");
        string director =Console.ReadLine();
        Console.WriteLine("______________________________"); 
        Pelicula peli = new Pelicula(nombre,genero,año,director);
        li.agregar(peli);
    }
   
    
    public void MostrarMenu2(){
        Console.WriteLine("|Editar pelicula|");
        Console.WriteLine("Ingresa el nombre de la pelicula");
        string nombre =Console.ReadLine();
        Console.WriteLine("Ingresa el nuevo nombre de la pelicula");
        string nnombre =Console.ReadLine();
        Console.WriteLine("Ingresa el genero de la pelicula");
        string genero =Console.ReadLine();
        Console.WriteLine("ingresa el año");
        int año =int.Parse(Console.ReadLine());
        Console.WriteLine("Ingresa el director");
        string director =Console.ReadLine();
        Console.WriteLine("______________________________"); 
        li.editar(nnombre,nombre,genero,año,director);
        MostrarMenu();
    }
    public void MostrarMenu3(){
        Console.WriteLine("|Eliminar pelicula|");
        Console.WriteLine("Ingresa el nombre de la pelicula");
         string nombre =Console.ReadLine();
        Console.WriteLine("______________________________"); 
        li.eliminar(nombre);
        MostrarMenu();

    }
    public void MostrarMenu4(){
        Console.WriteLine("|Mostar Pelicula|");
        Console.WriteLine("Ingresa el nombre de la pelicula");
        string nombre =Console.ReadLine();
        li.mostrar(nombre);
        Console.WriteLine("______________________________"); 
        MostrarMenu();
    }
    public void MostrarMenu5(){
        Console.WriteLine("|Mostar Peliculas|");
        li.mostrarTodos();
        Console.WriteLine("______________________________"); 
        MostrarMenu();
    }


    

    }
    

}
