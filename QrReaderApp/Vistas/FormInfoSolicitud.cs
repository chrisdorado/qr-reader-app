using MaterialSkin;
using MaterialSkin.Controls;
using QrReaderApp.Modelos;

namespace QrReaderApp.Vistas
{
    /// <summary>
    /// Winform que permite mostrar la información de una solicitud.
    /// </summary>
    public partial class FormInfoSolicitud : MaterialForm
    {
        #region Atributos
        private Solicitud _solicitud;
        #endregion

        #region Constructor
        public FormInfoSolicitud(Solicitud solicitud)
        {
            InitializeComponent();
            _solicitud = solicitud;
            MaterialSkinManager materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
        }
        #endregion

        #region Metodos
        protected override void OnLoad(EventArgs e)
        {
            DateTime fechaActual = DateTime.Now;
            bool asesoriaDisponible = true;

            idValueLabel.Text = _solicitud.Id.ToString();
            fechaValueLabel.Text = _solicitud.Fecha.ToShortDateString();
            horaValueLabel.Text = _solicitud.Fecha.ToShortTimeString();
            hayAsesorValueLabel.Text = _solicitud.AsesorDisponible ? "Sí" : "No";

            // Hacer más validaciones...
            if (_solicitud.Fecha.Date != fechaActual.Date || !_solicitud.AsesorDisponible)
            {
                asesoriaDisponible = false;
            }

            estatusValueLabel.Text = asesoriaDisponible ? "Disponible" : "NO disponible";
        }
        #endregion
    }
}
