namespace QrReaderApp.Vistas
{
    partial class FormInfoSolicitud
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            idLabel = new MaterialSkin.Controls.MaterialLabel();
            fechaLabel = new MaterialSkin.Controls.MaterialLabel();
            horaLabel = new MaterialSkin.Controls.MaterialLabel();
            hayAsesorLabel = new MaterialSkin.Controls.MaterialLabel();
            estatusCard = new MaterialSkin.Controls.MaterialCard();
            estatusValueLabel = new MaterialSkin.Controls.MaterialLabel();
            estatusLabel = new MaterialSkin.Controls.MaterialLabel();
            idValueLabel = new MaterialSkin.Controls.MaterialLabel();
            fechaValueLabel = new MaterialSkin.Controls.MaterialLabel();
            horaValueLabel = new MaterialSkin.Controls.MaterialLabel();
            hayAsesorValueLabel = new MaterialSkin.Controls.MaterialLabel();
            infoSolicitudCard = new MaterialSkin.Controls.MaterialCard();
            estatusCard.SuspendLayout();
            infoSolicitudCard.SuspendLayout();
            SuspendLayout();
            // 
            // idLabel
            // 
            idLabel.AutoSize = true;
            idLabel.Depth = 0;
            idLabel.Font = new Font("Roboto Medium", 20F, FontStyle.Bold, GraphicsUnit.Pixel);
            idLabel.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            idLabel.Location = new Point(198, 73);
            idLabel.MouseState = MaterialSkin.MouseState.HOVER;
            idLabel.Name = "idLabel";
            idLabel.Size = new Size(20, 24);
            idLabel.TabIndex = 0;
            idLabel.Text = "ID";
            // 
            // fechaLabel
            // 
            fechaLabel.AutoSize = true;
            fechaLabel.Depth = 0;
            fechaLabel.Font = new Font("Roboto Medium", 20F, FontStyle.Bold, GraphicsUnit.Pixel);
            fechaLabel.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            fechaLabel.Location = new Point(17, 14);
            fechaLabel.MouseState = MaterialSkin.MouseState.HOVER;
            fechaLabel.Name = "fechaLabel";
            fechaLabel.Size = new Size(55, 24);
            fechaLabel.TabIndex = 1;
            fechaLabel.Text = "Fecha";
            // 
            // horaLabel
            // 
            horaLabel.AutoSize = true;
            horaLabel.Depth = 0;
            horaLabel.Font = new Font("Roboto Medium", 20F, FontStyle.Bold, GraphicsUnit.Pixel);
            horaLabel.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            horaLabel.Location = new Point(160, 14);
            horaLabel.MouseState = MaterialSkin.MouseState.HOVER;
            horaLabel.Name = "horaLabel";
            horaLabel.Size = new Size(44, 24);
            horaLabel.TabIndex = 2;
            horaLabel.Text = "Hora";
            // 
            // hayAsesorLabel
            // 
            hayAsesorLabel.AutoSize = true;
            hayAsesorLabel.Depth = 0;
            hayAsesorLabel.Font = new Font("Roboto Medium", 20F, FontStyle.Bold, GraphicsUnit.Pixel);
            hayAsesorLabel.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            hayAsesorLabel.Location = new Point(248, 14);
            hayAsesorLabel.MouseState = MaterialSkin.MouseState.HOVER;
            hayAsesorLabel.Name = "hayAsesorLabel";
            hayAsesorLabel.Size = new Size(159, 24);
            hayAsesorLabel.TabIndex = 3;
            hayAsesorLabel.Text = "Asesor disponible";
            // 
            // estatusCard
            // 
            estatusCard.BackColor = Color.FromArgb(255, 255, 255);
            estatusCard.Controls.Add(estatusValueLabel);
            estatusCard.Controls.Add(estatusLabel);
            estatusCard.Depth = 0;
            estatusCard.ForeColor = Color.FromArgb(222, 0, 0, 0);
            estatusCard.Location = new Point(23, 217);
            estatusCard.Margin = new Padding(14);
            estatusCard.MouseState = MaterialSkin.MouseState.HOVER;
            estatusCard.Name = "estatusCard";
            estatusCard.Padding = new Padding(14);
            estatusCard.Size = new Size(423, 31);
            estatusCard.TabIndex = 5;
            // 
            // estatusValueLabel
            // 
            estatusValueLabel.AutoSize = true;
            estatusValueLabel.Depth = 0;
            estatusValueLabel.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            estatusValueLabel.Location = new Point(175, 6);
            estatusValueLabel.MouseState = MaterialSkin.MouseState.HOVER;
            estatusValueLabel.Name = "estatusValueLabel";
            estatusValueLabel.Size = new Size(76, 19);
            estatusValueLabel.TabIndex = 1;
            estatusValueLabel.Text = "Disponible";
            // 
            // estatusLabel
            // 
            estatusLabel.AutoSize = true;
            estatusLabel.Depth = 0;
            estatusLabel.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            estatusLabel.Location = new Point(17, 6);
            estatusLabel.MouseState = MaterialSkin.MouseState.HOVER;
            estatusLabel.Name = "estatusLabel";
            estatusLabel.Size = new Size(54, 19);
            estatusLabel.TabIndex = 0;
            estatusLabel.Text = "Estatus";
            // 
            // idValueLabel
            // 
            idValueLabel.AutoSize = true;
            idValueLabel.Depth = 0;
            idValueLabel.Font = new Font("Roboto Medium", 20F, FontStyle.Bold, GraphicsUnit.Pixel);
            idValueLabel.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            idValueLabel.Location = new Point(229, 73);
            idValueLabel.MouseState = MaterialSkin.MouseState.HOVER;
            idValueLabel.Name = "idValueLabel";
            idValueLabel.Size = new Size(23, 24);
            idValueLabel.TabIndex = 6;
            idValueLabel.Text = "14";
            // 
            // fechaValueLabel
            // 
            fechaValueLabel.AutoSize = true;
            fechaValueLabel.Depth = 0;
            fechaValueLabel.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            fechaValueLabel.Location = new Point(17, 50);
            fechaValueLabel.MouseState = MaterialSkin.MouseState.HOVER;
            fechaValueLabel.Name = "fechaValueLabel";
            fechaValueLabel.Size = new Size(87, 19);
            fechaValueLabel.TabIndex = 7;
            fechaValueLabel.Text = "03/04/2023";
            // 
            // horaValueLabel
            // 
            horaValueLabel.AutoSize = true;
            horaValueLabel.Depth = 0;
            horaValueLabel.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            horaValueLabel.Location = new Point(160, 50);
            horaValueLabel.MouseState = MaterialSkin.MouseState.HOVER;
            horaValueLabel.Name = "horaValueLabel";
            horaValueLabel.Size = new Size(41, 19);
            horaValueLabel.TabIndex = 8;
            horaValueLabel.Text = "03:52";
            // 
            // hayAsesorValueLabel
            // 
            hayAsesorValueLabel.AutoSize = true;
            hayAsesorValueLabel.Depth = 0;
            hayAsesorValueLabel.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            hayAsesorValueLabel.Location = new Point(316, 50);
            hayAsesorValueLabel.MouseState = MaterialSkin.MouseState.HOVER;
            hayAsesorValueLabel.Name = "hayAsesorValueLabel";
            hayAsesorValueLabel.Size = new Size(15, 19);
            hayAsesorValueLabel.TabIndex = 9;
            hayAsesorValueLabel.Text = "Sí";
            // 
            // infoSolicitudCard
            // 
            infoSolicitudCard.BackColor = Color.FromArgb(255, 255, 255);
            infoSolicitudCard.Controls.Add(hayAsesorLabel);
            infoSolicitudCard.Controls.Add(fechaLabel);
            infoSolicitudCard.Controls.Add(hayAsesorValueLabel);
            infoSolicitudCard.Controls.Add(horaLabel);
            infoSolicitudCard.Controls.Add(horaValueLabel);
            infoSolicitudCard.Controls.Add(fechaValueLabel);
            infoSolicitudCard.Depth = 0;
            infoSolicitudCard.ForeColor = Color.FromArgb(222, 0, 0, 0);
            infoSolicitudCard.Location = new Point(23, 104);
            infoSolicitudCard.Margin = new Padding(14);
            infoSolicitudCard.MouseState = MaterialSkin.MouseState.HOVER;
            infoSolicitudCard.Name = "infoSolicitudCard";
            infoSolicitudCard.Padding = new Padding(14);
            infoSolicitudCard.Size = new Size(423, 100);
            infoSolicitudCard.TabIndex = 11;
            // 
            // FormInfoSolicitud
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(472, 266);
            Controls.Add(infoSolicitudCard);
            Controls.Add(idValueLabel);
            Controls.Add(estatusCard);
            Controls.Add(idLabel);
            MaximizeBox = false;
            Name = "FormInfoSolicitud";
            Sizable = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Solicitud";
            estatusCard.ResumeLayout(false);
            estatusCard.PerformLayout();
            infoSolicitudCard.ResumeLayout(false);
            infoSolicitudCard.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MaterialSkin.Controls.MaterialLabel idLabel;
        private MaterialSkin.Controls.MaterialLabel fechaLabel;
        private MaterialSkin.Controls.MaterialLabel horaLabel;
        private MaterialSkin.Controls.MaterialLabel hayAsesorLabel;
        private MaterialSkin.Controls.MaterialCard estatusCard;
        private MaterialSkin.Controls.MaterialLabel estatusValueLabel;
        private MaterialSkin.Controls.MaterialLabel estatusLabel;
        private MaterialSkin.Controls.MaterialLabel idValueLabel;
        private MaterialSkin.Controls.MaterialLabel fechaValueLabel;
        private MaterialSkin.Controls.MaterialLabel horaValueLabel;
        private MaterialSkin.Controls.MaterialLabel hayAsesorValueLabel;
        private MaterialSkin.Controls.MaterialCard infoSolicitudCard;
    }
}