using MaterialSkin;
using MaterialSkin.Controls;
using QrReaderApp.Core;
using QrReaderApp.Modelos;
using ZXing;

namespace QrReaderApp.Vistas
{
    /// <summary>
    /// Winform principal. Permite escanear un código QR o ingresar directamente el ID
    /// para buscar una solicitud.
    /// </summary>
    public partial class FormPrincipal : MaterialForm
    {
        #region Atributos
        private LectorQr? _lectorQr;
        private IRepositorioSolicitudes _repositorioSolicitudes;
        #endregion

        #region Constructor
        public FormPrincipal(IRepositorioSolicitudes repositorioSolicitudes)
        {
            InitializeComponent();

            MaterialSkinManager materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.DARK;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.Teal500, Primary.Teal700, Primary.Teal100, Accent.Orange200, TextShade.WHITE);

            _repositorioSolicitudes = repositorioSolicitudes;
            try
            {
                _lectorQr = new LectorQr(videoPictureBox);
            }
            catch(AForge.DeviceErrorException ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #endregion

        #region Metodos
        protected override void OnLoad(EventArgs e)
        {
            if(_lectorQr != null)
            {
                _lectorQr.Iniciar();
                timer.Start();
                dispositivosComboBox.Items.AddRange(_lectorQr.ObtenerDispositivos().ToArray());
                dispositivosComboBox.SelectedIndex = 0;
            }
            else
            {
                dispositivosComboBox.Enabled = false;
            }
        }
        #endregion

        private void OnClosing(object sender, FormClosingEventArgs e)
        {
            _lectorQr?.Detener();
            timer.Stop();
        }

        /// <summary>
        /// Comprueba si hay un QR en el video para buscar una solicitud en cada tick del timer.
        /// Por defecto es cada segundo.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TimerTick(object sender, EventArgs e)
        {
            if (videoPictureBox.Image != null)
            {
                Result? result = _lectorQr?.ComprobarFrame();
                if (result != null)
                {
                    BuscarSolicitud(result.Text);
                }
            }

        }

        /// <summary>
        /// Busca una solicitud en el repositorio de solicitudes y en caso
        /// de encontrar una, abre un <c>FormInfoSolicitud</c> que muestra su información.
        /// En caso de no encontrar o haber un error con el código, se muestra un mensaje en un SnackBar.
        /// </summary>
        /// <param name="idBuscado">ID de la solicitud.</param>
        private void BuscarSolicitud(string idBuscado)
        {
            if (int.TryParse(idBuscado, out int id))
            {
                Solicitud? solicitud = _repositorioSolicitudes.ObtenerSolicitudPorId(id);

                if (solicitud != null)
                {
                    FormInfoSolicitud formInfoSolicitud = new FormInfoSolicitud(solicitud);
                    formInfoSolicitud.Show();
                }
                else
                {
                    MostrarSnackBar($"La solicitud con el ID {id} no existe.");
                }
            }
            else
            {
                MostrarSnackBar($"Código QR o ID no válido.");
            }
        }

        private void DispositivosComboBoxSelectedIndexChanged(object sender, EventArgs e)
        {
            _lectorQr?.CambiarDispositivoCaptura(dispositivosComboBox.SelectedIndex);
        }

        private void BuscarButtonClick(object sender, EventArgs e)
        {
            BuscarSolicitud(idTextBox.Text);
        }

        private void MostrarSnackBar(string mensaje)
        {
            MaterialSnackBar messageSnackBar = new MaterialSnackBar(mensaje, 3000, "Ok");
            messageSnackBar.Show(this);
        }
    }
}