using Npgsql;

namespace QrReaderApp.Modelos
{
    /// <summary>
    /// Clase <c>RepositorioSolicitudesPostgresql</c>. Permite acceder a un conjunto de
    /// solicitudes utlilizando PostgreSQL. *NO IMPLEMENTADA*
    /// </summary>
    public class RepositorioSolicitudesPostgresql : IRepositorioSolicitudes
    {
        #region Atributos
        private NpgsqlDataSource _baseDatos;
        #endregion

        #region Constructor
        public RepositorioSolicitudesPostgresql(string hostname, string user, string password, string database)
        {
            _baseDatos = NpgsqlDataSource.Create($"Host={hostname};Username={user};Password={password};Database={database}");
        }
        #endregion

        #region Metodos
        public void ActualizarSolicitud(Solicitud solicitud)
        {
            throw new NotImplementedException();
        }

        public void EliminarSolicitud(int idSolicitud)
        {
            throw new NotImplementedException();
        }

        public void InsertarSolicitud(Solicitud solicitud)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Solicitud> ObtenerSolicitudes()
        {
            throw new NotImplementedException();
            // Tal vez sea algo así:
            /*List<Solicitud> solicitudes = new List<Solicitud>();
            NpgsqlCommand cmd = _baseDatos.CreateCommand("SELECT * FROM solicitudes");
            NpgsqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                solicitudes.Add(new Solicitud(reader.GetInt32(0), reader.GetDateTime(1), reader.GetBoolean(2)));
            }
            return solicitudes;*/
        }

        public Solicitud? ObtenerSolicitudPorId(int idSolicitud)
        {
            throw new NotImplementedException();
        }
        #endregion
    }
}
