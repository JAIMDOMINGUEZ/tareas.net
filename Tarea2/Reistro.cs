namespace Tarea2
{
    internal class Registro
    {
      
        private Libreria li = new Libreria();
		


    public void MostrarMenu(Pelicula pelicula){
        int selct =0;
        while (selct<1&&selct>5)
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
                case 1: 
                break;
                case 2:
                break;
                case 3:
                break;
                case 4:
                break;
                case 5: 
                
                break 
                    
;
            default:
        }
    }
    public void MostrarMenu1(Pelicula pelicula){
        Console.WriteLine("|AgregarPelicula|");
        Console.WriteLine("Ingresa rl nombre de la pelicula");

        Console.WriteLine("Ingresa el genero de la pelicula");

        Console.WriteLine("ingresa el año");

        Console.WriteLine("Ingresa el director");
        
          Console.WriteLine("______________________________"); 
    }
    public void MostrarMenu1(Pelicula pelicula){
        Console.WriteLine("|AgregarPelicula|");
        Console.WriteLine("Ingresa rl nombre de la pelicula");

        Console.WriteLine("Ingresa el genero de la pelicula");

        Console.WriteLine("ingresa el año");

        Console.WriteLine("Ingresa el director");
        
          Console.WriteLine("______________________________"); 
    }
    public void MostrarMenu2(Pelicula pelicula){
        Console.WriteLine("|Editar pelicula|");
        Console.WriteLine("Ingresa el nombre de la pelicula");

        Console.WriteLine("Ingresa el nuevo nombre de la pelicula");

        Console.WriteLine("Ingresa el genero de la pelicula");

        Console.WriteLine("ingresa el año");

        Console.WriteLine("Ingresa el director");
        
          Console.WriteLine("______________________________"); 
    }
    public void MostrarMenu3(Pelicula pelicula){
        Console.WriteLine("|Eliminar pelicula|");
        Console.WriteLine("Ingresa el nombre de la pelicula");
        
        Console.WriteLine("______________________________"); 
    }


    public void editar(string nombre,string genero,int año,string director){
        if (nombre != null&&genero != null&&año != 0 &&director != null) {
               foreach(Pelicula pelicula in _peliculas)
                {
	                if(pelicula.nombre==nombre){
                        pelicula.genero=genero;
                        pelicula.año=año;
                        pelicula.director=director;

                    }
                }

		}

    }
    public void editar(string nombre){
        if (nombre != null) {
               foreach(Pelicula pelicula in _peliculas)
                {
	                if(pelicula.nombre==nombre){
                        _peliculas.Remove(pelicula);

                    }
                }

		}

    }


		
	}
}