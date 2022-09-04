namespace Patrones_de_Diseño
{
	class GeneradorDeDatosAleatorios
	{
		static Random aleatorio = new Random();
		public GeneradorDeDatosAleatorios()
		{

		}
		public int NumeroAleatorio(int numerominimo, int numeromaximo)
		{
			return aleatorio.Next(numerominimo, numeromaximo);
		}
		public int NumeroAleatorio(int numeromaximo)
		{
			return aleatorio.Next(numeromaximo);
		}
		public string NombreAleatorio()//0-27
		{
			List<string> l1 = new List<string>()
			{
				"Alex","Belén","Cruz","Dante","Elena","Federico","Gastón","Hernan","Ivan","Juan","Kinga","Lauti","Mati","Norma",
				"Ñasd","Oscar","Pablo","Quico","Roxxana","Sebastian","Tomás","Úrsula","Victoria","Ximena","Wilson","Yamila","Zulma"
			};

			return l1[this.NumeroAleatorio(0, 27)];
		}
		public string StringAleatorio(int cantidaddecaracteres)//0-72
		{
			string? stringrandom = null;
			List<string> lista = new List<string>()
			{
				"A","B","C","D","E","F","G","H","I","J","K","L","M","N","Ñ","O","P","Q","R","S","T","U","V","W","X","Y","Z",
				"a","b","c","d","e","f","g","h","i","j","k","l","m","n","ñ","o","p","q","r","s","t","u","v","w","x","y","z",
                "Á","É","Í","Ó","Ú",
				"á","é","í","ó","ú",
				"0","1","2","3","5","6","7","8","9"
            };
			for (int i = 0; i < cantidaddecaracteres; i++)
			{
				stringrandom += lista[aleatorio.Next(0, 72)];
			}
			return stringrandom;
		}
	}
}