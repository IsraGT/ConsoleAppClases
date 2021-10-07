using System;

namespace ConsoleApp50Clases
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Telefono"); 
            Telefono TelefonoCelular = new Telefono("Samsung", "Negro", "Inteligente");

            Console.WriteLine("La marca del telefono es: " + TelefonoCelular.marca);
            Console.WriteLine("El color del telefono es : " + TelefonoCelular.color);
            Console.WriteLine("El telefono es tipo : " + TelefonoCelular.tipo);

            Console.WriteLine("Vehiculo");
            Vehiculo auto = new Vehiculo("BMW", "Blanco", "HOLA1212");
            Console.WriteLine("La marca del auto es : " + auto.marca);
            Console.WriteLine("El color del auto es : " + auto.color);
            Console.WriteLine("Las placas son : " + auto.placas);

            Console.WriteLine("Pokemon");
            Pokemon poke = new Pokemon("Gengar", "Sinestro", "Lucha , Bicho, Hada");
            Console.WriteLine("Este pokemon se llama : " + poke.nombre);
            Console.WriteLine("Es tipo: " + poke.tipo);
            Console.WriteLine("Es debil contra tipo : " + poke.debilidad);

            Console.WriteLine("Ciudad");
            Ciudad cd = new Ciudad("Juarez", "Chihuahua", "1.51M de habitantes");
            Console.WriteLine("La ciudad es : " + cd.ciudad);
            Console.WriteLine("Cuenta con : " + cd.habitantes);
            Console.WriteLine("Esta en el estado de : " + cd.habitantes);

            Console.WriteLine("PC"); 
            PC compu = new PC("Razer","Roja", "AMD Ryzen 5000");
            Console.WriteLine("Esta PC es marca : " + compu.marca);
            Console.WriteLine("Es color ; " + compu.color);
            Console.WriteLine("Tiene un procesador: " + compu.procesador);

            Console.WriteLine("Estudiante");
            Estudiante estu = new Estudiante("Juan Perez Gonzales", "TEC", "Ingeniera Industrial");
            Console.WriteLine("Su nombre es:" + estu.nombre);
            Console.WriteLine("Estudia en:" + estu.escuela);
            Console.WriteLine("Esta en la carrera de:" + estu.carrera);

            Console.WriteLine("Puerta");
            Door pta = new Door("Madera", "Chocolate", "2m x 40cm");
            Console.WriteLine(" El material de la puerta es:" + pta.material);
            Console.WriteLine("Es color:" + pta.color);
            Console.WriteLine("Sus medidas son:" + pta.tamaño);

            Console.WriteLine("Video Juego");
            VG game = new VG("Call of Duty BO2", "Xbox 360", "Online, Campaña, zombies");
            Console.WriteLine("El nombre del videojuego es:" + game.nombre);
            Console.WriteLine("Sen lanzo para:" + game.plataforma);
            Console.WriteLine("Sus modos de juego son;" + game.modos);

            Console.WriteLine("Pokemon");
            Pokemoon pok = new Pokemoon("Charizrd", "Fuego/Volador", "Fuego,Agua,Roca, dragon");
            Console.WriteLine("Este pokemon se llama : " + pok.nombre);
            Console.WriteLine("Es tipo: " + pok.tipo);
            Console.WriteLine("Es debil contra tipo : " + pok.debilidad);

            Console.WriteLine("Cancion");
            Cancion song = new Cancion("Devuelveme a mi chica", "Pop", "Hombres G");
            Console.WriteLine("El nombre de la cancion es;" + song.nombre);
            Console.WriteLine("Pertenece al genero:" + song.genero);
            Console.WriteLine("La toca la banda:" + song.banda);
               













        }
    }
}
