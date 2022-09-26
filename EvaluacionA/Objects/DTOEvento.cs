namespace EvaluacionA.Objects
{
    public class OEvento
    {
        public int ID { get; set; }
        public int UsuarioID { get; set; }
        public DateTime FechaAlta { get; set; }
        public string Latitud { get; set; }
        public string Longitud { get; set; }
        public string Origen { get; set; }
    }
}
