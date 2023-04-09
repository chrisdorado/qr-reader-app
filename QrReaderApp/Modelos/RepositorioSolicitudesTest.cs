
namespace QrReaderApp.Modelos
{
    /// <summary>
    /// Clase <c>RepositorioSolicitudesTest</c>. Permite acceder a un conjunto de
    /// solicitudes de prueba.
    /// </summary>
    internal class RepositorioSolicitudesTest : IRepositorioSolicitudes
    {
        #region Atributos
        private readonly List<Solicitud> _solicitudes;
        #endregion

        #region Constructor
        public RepositorioSolicitudesTest()
        {
            _solicitudes = new List<Solicitud> {
                new Solicitud(1, DateTime.Now.AddDays(-1), true),
                new Solicitud(2, DateTime.Now.AddDays(-1), true),
                new Solicitud(3, DateTime.Now.AddDays(-1), true),
                new Solicitud(4, DateTime.Now, true),
                new Solicitud(5, DateTime.Now, true),
                new Solicitud(6, DateTime.Now.AddDays(1), false),
                new Solicitud(7, DateTime.Now.AddDays(1), true),
                new Solicitud(8, DateTime.Now.AddDays(2), true),
                new Solicitud(9, DateTime.Now.AddDays(2), false),
                new Solicitud(10, DateTime.Now.AddDays(3), true),
                new Solicitud(11, DateTime.Now.AddDays(3), false),
                new Solicitud(12, DateTime.Now.AddDays(4), true),
            };
        }
        #endregion

        #region Metodos
        public void ActualizarSolicitud(Solicitud solicitud)
        {
            int index = _solicitudes.FindIndex(x => x.Id == solicitud.Id);
            if(index >= 0)
            {
                _solicitudes[index] = solicitud;
            }
        }

        public void EliminarSolicitud(int idSolicitud)
        {
            int index = _solicitudes.FindIndex(x => x.Id == idSolicitud);
            if (index >= 0)
            {
                _solicitudes.RemoveAt(index);
            }
        }

        public void InsertarSolicitud(Solicitud solicitud)
        {
            _solicitudes.Add(solicitud);
        }

        public IEnumerable<Solicitud> ObtenerSolicitudes()
        {
            return _solicitudes;
        }

        public Solicitud? ObtenerSolicitudPorId(int idSolicitud)
        {
            return _solicitudes.Where(x => x.Id == idSolicitud).FirstOrDefault();
        }
        #endregion
    }
}
