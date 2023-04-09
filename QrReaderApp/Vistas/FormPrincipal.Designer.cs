namespace QrReaderApp.Vistas
{
    partial class FormPrincipal
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            dispositivosComboBox = new MaterialSkin.Controls.MaterialComboBox();
            videoPictureBox = new PictureBox();
            idTextBox = new MaterialSkin.Controls.MaterialTextBox();
            buscarButton = new MaterialSkin.Controls.MaterialButton();
            timer = new System.Windows.Forms.Timer(components);
            ((System.ComponentModel.ISupportInitialize)videoPictureBox).BeginInit();
            SuspendLayout();
            // 
            // dispositivosComboBox
            // 
            dispositivosComboBox.AutoResize = false;
            dispositivosComboBox.BackColor = Color.FromArgb(255, 255, 255);
            dispositivosComboBox.Depth = 0;
            dispositivosComboBox.DrawMode = DrawMode.OwnerDrawVariable;
            dispositivosComboBox.DropDownHeight = 118;
            dispositivosComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            dispositivosComboBox.DropDownWidth = 121;
            dispositivosComboBox.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
            dispositivosComboBox.ForeColor = Color.FromArgb(222, 0, 0, 0);
            dispositivosComboBox.FormattingEnabled = true;
            dispositivosComboBox.IntegralHeight = false;
            dispositivosComboBox.ItemHeight = 29;
            dispositivosComboBox.Location = new Point(5, 77);
            dispositivosComboBox.MaxDropDownItems = 4;
            dispositivosComboBox.MouseState = MaterialSkin.MouseState.OUT;
            dispositivosComboBox.Name = "dispositivosComboBox";
            dispositivosComboBox.Size = new Size(364, 35);
            dispositivosComboBox.StartIndex = 0;
            dispositivosComboBox.TabIndex = 0;
            dispositivosComboBox.UseAccent = false;
            dispositivosComboBox.UseTallSize = false;
            dispositivosComboBox.SelectedIndexChanged += DispositivosComboBoxSelectedIndexChanged;
            // 
            // videoPictureBox
            // 
            videoPictureBox.BorderStyle = BorderStyle.FixedSingle;
            videoPictureBox.Location = new Point(6, 123);
            videoPictureBox.Name = "videoPictureBox";
            videoPictureBox.Size = new Size(364, 314);
            videoPictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            videoPictureBox.TabIndex = 1;
            videoPictureBox.TabStop = false;
            // 
            // idTextBox
            // 
            idTextBox.AnimateReadOnly = false;
            idTextBox.BorderStyle = BorderStyle.None;
            idTextBox.Depth = 0;
            idTextBox.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            idTextBox.Hint = "Ingrese el ID de la solicitud";
            idTextBox.LeadingIcon = null;
            idTextBox.Location = new Point(5, 443);
            idTextBox.MaxLength = 50;
            idTextBox.MouseState = MaterialSkin.MouseState.OUT;
            idTextBox.Multiline = false;
            idTextBox.Name = "idTextBox";
            idTextBox.Size = new Size(364, 36);
            idTextBox.TabIndex = 2;
            idTextBox.Text = "";
            idTextBox.TrailingIcon = null;
            idTextBox.UseAccent = false;
            idTextBox.UseTallSize = false;
            // 
            // buscarButton
            // 
            buscarButton.AutoSize = false;
            buscarButton.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            buscarButton.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            buscarButton.Depth = 0;
            buscarButton.HighEmphasis = true;
            buscarButton.Icon = null;
            buscarButton.Location = new Point(6, 488);
            buscarButton.Margin = new Padding(4, 6, 4, 6);
            buscarButton.MouseState = MaterialSkin.MouseState.HOVER;
            buscarButton.Name = "buscarButton";
            buscarButton.NoAccentTextColor = Color.Empty;
            buscarButton.Size = new Size(363, 36);
            buscarButton.TabIndex = 3;
            buscarButton.Text = "Buscar";
            buscarButton.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            buscarButton.UseAccentColor = false;
            buscarButton.UseVisualStyleBackColor = true;
            buscarButton.Click += BuscarButtonClick;
            // 
            // timer
            // 
            timer.Interval = 1000;
            timer.Tick += TimerTick;
            // 
            // FormPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(376, 542);
            Controls.Add(buscarButton);
            Controls.Add(idTextBox);
            Controls.Add(videoPictureBox);
            Controls.Add(dispositivosComboBox);
            MaximizeBox = false;
            Name = "FormPrincipal";
            Sizable = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Sistema de turnos";
            FormClosing += OnClosing;
            ((System.ComponentModel.ISupportInitialize)videoPictureBox).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private MaterialSkin.Controls.MaterialComboBox dispositivosComboBox;
        private PictureBox videoPictureBox;
        private MaterialSkin.Controls.MaterialTextBox idTextBox;
        private MaterialSkin.Controls.MaterialButton buscarButton;
        private System.Windows.Forms.Timer timer;
    }
}