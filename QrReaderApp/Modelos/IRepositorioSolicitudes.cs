
namespace QrReaderApp.Modelos
{
    /// <summary>
    /// Interface para implementar repositorios de solicitudes.
    /// </summary>
    public interface IRepositorioSolicitudes
    {
        void ActualizarSolicitud(Solicitud solicitud);
        void EliminarSolicitud(int idSolicitud);
        void InsertarSolicitud(Solicitud solicitud);
        IEnumerable<Solicitud> ObtenerSolicitudes();
        Solicitud? ObtenerSolicitudPorId(int idSolicitud);
    }
}
