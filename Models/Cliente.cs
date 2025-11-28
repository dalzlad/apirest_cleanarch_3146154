namespace ApiEmpresa.Models
{
    public class Cliente
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Whatsapp {  get; set; }
        public bool Estado { get; set; }

        //Clave foránea
        public int IdCity { get; set; }

        //Navegabilidad entre cliente y ciudad
        public City? City { get; set; }
    }
}
