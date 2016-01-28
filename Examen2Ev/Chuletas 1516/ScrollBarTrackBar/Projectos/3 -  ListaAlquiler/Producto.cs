using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alquilar
{
    class Producto
    {
        int id;
        String nombre;
        String genero;
        String descripcion;
        Boolean estado_alquiler;
       
        public Producto (int id, String nombre, String genero, String descripcion, Boolean estado_alquiler) {

            this.id = id;
            this.nombre = nombre;
            this.descripcion = descripcion;
            this.estado_alquiler = estado_alquiler;
            this.genero = genero;
        }
        public Producto(int id, String nombre, String genero, String descripcion)
        {

            this.id = id;
            this.nombre = nombre;
            this.descripcion = descripcion;
            this.estado_alquiler = false;
            this.genero = genero;
        }
        public Producto()
        {
        }
        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        public String Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }
      
        public String Genero
        {
            get { return genero; }
            set { genero = value; }
        }
        public String Descripcion
        {
            get { return descripcion; }
            set { descripcion = value; }
        }
        public Boolean Estado_alquiler
        {
            get { return estado_alquiler; }
            set { estado_alquiler = value; }
        }

        public static List<Producto> rellenarlista()
        {
            List<Producto> p = new List<Producto>();

            p.Add(new Producto());
            p.Add(new Producto(1, "Metal Gear Solid: The Phantom Pain", "Sigilo", "Está ambientado en 1984, 9 años tras los acontecimientos de Ground Zeroes y 11 años antes de la trama de Metal Gear. Su subtítulo se refiere a una condición médica asociada con los amputados; cuando un individuo experimenta sensaciones, específicamente el dolor, en miembros fantasma que ya no forman parte de su cuerpo.", true));
            p.Add(new Producto(2, "Fifa 2016", "Deportes", "Videojuego de fútbol desarrollado por EA Canada y publicado por EA Sports."));
            p.Add(new Producto(3, "Assasins Creed", "Aventura", " Ficción histórica, desarrollado por Ubisoft Montreal.", true));
            p.Add(new Producto(4, "Dragon Ball Xenoverse", "Accion", "La historia inicia en la Ciudad Toki Toki, en donde nos encontraremos cara a cara con Trunks del Futuro. Allí debemos crear a nuestro propio personaje, y cuando ya finalicemos todos los cambios, Trunks, el líder de la patrulla temporal, nos reclutará para combatir. Una vez reclutado por Trunks, el jugador tendrá que rememorar todos los momentos de la historia de Dragon Ball participando en ellos, debido a que alguna magia secreta ha estado alterando el orden y, por consecuencia, los villanos se vuelven más poderosos. El flujo temporal de espacio-tiempo y la historia original de Dragon Ball cambiarán totalmente, y las Esferas del Dragón estarán en serio peligro.", true));
            p.Add(new Producto(5, "Halo: The Master Chief Collection", "Accion", " Recopilación remasterizada de los videojuegos de disparos en primera persona de la popular saga Halo"));
            p.Add(new Producto(6, "Zone of The Enders HD", "Accion", " Zone of the Enders se desarrolla en el siglo 22 tardío. La humanidad ha colonizado Marte, y colonias espaciales han sido puestas en órbita alrededor de Júpiter. Dos avances científicos se encuentran alimentando esta expansión: el desarrollo del Vehículo Extra - Orbital Laborioso o LEV, un mecha utilizado para trabajos regulares y uso militar y el descubrimiento del Metatron, un mineral de alta energía que se encuentra en Calisto.", true));
            p.Add(new Producto(7, "Tales of Xillia", "RPG", "La historia de Tales of Xillia está protagonizada por Jude Mathis, un estudiante de medicina que trabaja en el hospital de la ciudad de Ilfan realizando prácticas, y Milla Maxwell, una misteriosa joven con el poder de invocar a los cuatro espíritus elementales y unas habilidades mágicas sobrenaturales.La aventura transcurre en el mundo de Rieze Maxia, donde los seres humanos y espíritus conviven en armonía. El reino de Rashugal ha estado experimentando con un poderoso artefacto que ha estado absorbiendo el maná del mundo, y conscientes del daño que esto le puede provocar al mundo, Milla y Jude parten en una aventura cuyo objetivo será destruir dicho artefacto y devolver el maná al mundo."));
            p.Add(new Producto(8, "Final Fantasy XV", "RPG", "Ultimo videjuego desarollado por la compañia Square-Enix"));
            p.Add(new Producto(9, "Bayonetta 2 ", "Accion", "Equipada con nuevas armas y habilidades, Bayonetta usará nuevos movimientos y ataques clímax contra sus enemigos. Se podrá elegir entre dos modos de control, el tradicional y el táctil. El modo normal representa el esquema de control técnico que ya presenta el primer Bayonetta. El modo táctil, por otro lado, ofrece un estilo de juego más fácil para aquellos no estén familiarizados con los juegos de acción, aunque también se espera que le sea cómodo a los jugadores más experimentados. Otros personajes aparecerán para darle asistencia a Bayonetta dentro de los combates."));
            return p;

        }

 


    }
}
