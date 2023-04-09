
namespace QrReaderApp.Modelos
{
    public class Solicitud
    {
        #region Propiedades
        public int Id { get; set; }
        public DateTime Fecha { get; set; }
        public bool AsesorDisponible { get; set; }
        #endregion

        #region Constructor
        public Solicitud(int id, DateTime fecha, bool asesorDisponible)
        {
            Id = id;
            Fecha = fecha;
            AsesorDisponible = asesorDisponible;
        }
        #endregion

        #region Metodos
        public override string ToString()
        {
            return $"ID: {Id}, Fecha: {Fecha.ToShortDateString()}, Hora: {Fecha.ToShortTimeString()}, Asesor disponible: {(AsesorDisponible ? "Sí" : "No")}";
        }
        #endregion
    }
}
