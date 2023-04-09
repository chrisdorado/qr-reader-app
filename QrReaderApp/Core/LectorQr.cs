using AForge;
using AForge.Video;
using AForge.Video.DirectShow;
using ZXing;
using ZXing.Common;
using ZXing.Windows.Compatibility;

namespace QrReaderApp.Core
{
    /// <summary>
    /// Clase <c>LectorQr</c>. Permite colocar la imagen de un dispositivo de vídeo dentro de un
    /// PictureBox y revisar si encuentra un código QR dentro de la imagen.
    /// </summary>
    public class LectorQr
    {
        #region Atributos
        private VideoCaptureDevice _dispositivoCaptura;
        private readonly FilterInfoCollection _infoDispositivos;
        private readonly BarcodeReader _lector;
        private readonly PictureBox _contenedor;
        #endregion

        #region Constructor
        /// <param name="contenedor">PictureBox en el que se mostrara el vídeo capturado.</param>
        /// <exception cref="DeviceErrorException">Excepción lanzada en caso de no existir dispositivos disponibles.</exception>
        public LectorQr(PictureBox contenedor)
        {
            _contenedor = contenedor;
            _infoDispositivos = new FilterInfoCollection(FilterCategory.VideoInputDevice);
            if(_infoDispositivos.Count > 0)
            {
                _dispositivoCaptura = new VideoCaptureDevice(_infoDispositivos[0].MonikerString);
                _dispositivoCaptura.NewFrame += ActualizarContenedor;
                _lector = new BarcodeReader(null, null, source => new GlobalHistogramBinarizer(source))
                {
                    AutoRotate = true
                };
            }
            else
            {
                throw new DeviceErrorException("No se encontraron dispositivos de vídeo");
            }
        }
        #endregion

        #region Metodos
        /// <summary>
        /// Actualiza el contenedor colocando el frame que captura el dispositivo.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ActualizarContenedor(object sender, NewFrameEventArgs e)
        {
            _contenedor.Image = (Bitmap)e.Frame.Clone();
        }

        /// <summary>
        /// Revisa si el frame actual contiene un código QR.
        /// </summary>
        /// <returns>En caso de detectar un QR se devuelve su información, de otra forma devuelve null.</returns>
        public Result? ComprobarFrame()
        {
            return _lector.Decode((Bitmap)_contenedor.Image);
        }

        /// <summary>
        /// Devuelve una lista de los nombres de los dispositivos de captura.
        /// </summary>
        /// <returns></returns>
        public List<string> ObtenerDispositivos()
        {
            List<string> dispositivos = new List<string>();
            foreach (FilterInfo info in _infoDispositivos)
            {
                dispositivos.Add(info.Name);
            }
            return dispositivos;
        }

        /// <summary>
        /// Actauliza el dispositivo de captura que se está utilizando.
        /// </summary>
        /// <param name="id"></param>
        public void CambiarDispositivoCaptura(int id)
        {
            if (_infoDispositivos.Count > id && id >= 0)
            {
                Detener();
                _dispositivoCaptura = new VideoCaptureDevice(_infoDispositivos[id].MonikerString);
                _dispositivoCaptura.NewFrame += ActualizarContenedor;
                Iniciar();
            }
        }

        /// <summary>
        /// Comienza con la captura de video.
        /// </summary>
        public void Iniciar()
        {
            _dispositivoCaptura.Start();
        }

        /// <summary>
        /// Detiene la captura de video y libera los recursos.
        /// </summary>
        public void Detener()
        {
            if (_dispositivoCaptura.IsRunning)
            {
                _dispositivoCaptura.SignalToStop();
            }
        }
        #endregion
    }
}
