namespace RenombraTusCapis
{
    partial class Principal
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Principal));
            this.menuTop1 = new System.Windows.Forms.MenuStrip();
            this.configuraciónToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.opcionesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.acercaDeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panelVistaPrevia = new System.Windows.Forms.DataGridView();
            this.Seleccion = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.srtOriginal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.buscaSrt = new System.Windows.Forms.DataGridViewButtonColumn();
            this.srtDestino = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.videoOriginal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.buscarVideo = new System.Windows.Forms.DataGridViewButtonColumn();
            this.videoDestino = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BarraHerramientas = new System.Windows.Forms.ToolStrip();
            this.bSettings = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bBuscar = new System.Windows.Forms.ToolStripButton();
            this.bRun = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.bSalir = new System.Windows.Forms.ToolStripButton();
            this.panelOpciones = new System.Windows.Forms.Panel();
            this.bBuscarCarpetaSeries = new System.Windows.Forms.Button();
            this.labelPath = new System.Windows.Forms.Label();
            this.labelOpciones = new System.Windows.Forms.Label();
            this.textoPathSeries = new System.Windows.Forms.TextBox();
            this.bGuardar = new System.Windows.Forms.Button();
            this.bCancelar = new System.Windows.Forms.Button();
            this.dialogoBuscarCarpetaSeries = new System.Windows.Forms.FolderBrowserDialog();
            this.menuTop1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelVistaPrevia)).BeginInit();
            this.BarraHerramientas.SuspendLayout();
            this.panelOpciones.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuTop1
            // 
            this.menuTop1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.configuraciónToolStripMenuItem,
            this.acercaDeToolStripMenuItem});
            this.menuTop1.Location = new System.Drawing.Point(0, 0);
            this.menuTop1.Name = "menuTop1";
            this.menuTop1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.menuTop1.Size = new System.Drawing.Size(1141, 24);
            this.menuTop1.TabIndex = 0;
            this.menuTop1.Text = "menuStrip1";
            // 
            // configuraciónToolStripMenuItem
            // 
            this.configuraciónToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.opcionesToolStripMenuItem});
            this.configuraciónToolStripMenuItem.Name = "configuraciónToolStripMenuItem";
            this.configuraciónToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.configuraciónToolStripMenuItem.Text = "Archivo";
            // 
            // opcionesToolStripMenuItem
            // 
            this.opcionesToolStripMenuItem.Name = "opcionesToolStripMenuItem";
            this.opcionesToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.opcionesToolStripMenuItem.Text = "Opciones";
            this.opcionesToolStripMenuItem.Click += new System.EventHandler(this.opcionesToolStripMenuItem_Click);
            // 
            // acercaDeToolStripMenuItem
            // 
            this.acercaDeToolStripMenuItem.Name = "acercaDeToolStripMenuItem";
            this.acercaDeToolStripMenuItem.Size = new System.Drawing.Size(53, 20);
            this.acercaDeToolStripMenuItem.Text = "Ayuda";
            // 
            // panelVistaPrevia
            // 
            this.panelVistaPrevia.AllowUserToAddRows = false;
            this.panelVistaPrevia.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelVistaPrevia.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.panelVistaPrevia.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Seleccion,
            this.srtOriginal,
            this.buscaSrt,
            this.srtDestino,
            this.videoOriginal,
            this.buscarVideo,
            this.videoDestino});
            this.panelVistaPrevia.Location = new System.Drawing.Point(0, 63);
            this.panelVistaPrevia.Name = "panelVistaPrevia";
            this.panelVistaPrevia.Size = new System.Drawing.Size(1141, 462);
            this.panelVistaPrevia.TabIndex = 2;
            this.panelVistaPrevia.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Seleccion
            // 
            this.Seleccion.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Seleccion.Frozen = true;
            this.Seleccion.HeaderText = "";
            this.Seleccion.MinimumWidth = 20;
            this.Seleccion.Name = "Seleccion";
            this.Seleccion.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Seleccion.Width = 20;
            // 
            // srtOriginal
            // 
            this.srtOriginal.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.srtOriginal.HeaderText = "Subtitulo Original";
            this.srtOriginal.MinimumWidth = 150;
            this.srtOriginal.Name = "srtOriginal";
            this.srtOriginal.ReadOnly = true;
            // 
            // buscaSrt
            // 
            this.buscaSrt.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.buscaSrt.HeaderText = "";
            this.buscaSrt.MinimumWidth = 25;
            this.buscaSrt.Name = "buscaSrt";
            this.buscaSrt.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.buscaSrt.Text = "...";
            this.buscaSrt.ToolTipText = "Buscar";
            this.buscaSrt.Width = 25;
            // 
            // srtDestino
            // 
            this.srtDestino.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.srtDestino.HeaderText = "Subtitulo Destino";
            this.srtDestino.MinimumWidth = 150;
            this.srtDestino.Name = "srtDestino";
            this.srtDestino.ReadOnly = true;
            this.srtDestino.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.srtDestino.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // videoOriginal
            // 
            this.videoOriginal.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.videoOriginal.HeaderText = "Video Original";
            this.videoOriginal.MinimumWidth = 150;
            this.videoOriginal.Name = "videoOriginal";
            this.videoOriginal.ReadOnly = true;
            // 
            // buscarVideo
            // 
            this.buscarVideo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.buscarVideo.HeaderText = "";
            this.buscarVideo.MinimumWidth = 25;
            this.buscarVideo.Name = "buscarVideo";
            this.buscarVideo.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.buscarVideo.Text = "buscar";
            this.buscarVideo.ToolTipText = "Buscar";
            this.buscarVideo.Width = 25;
            // 
            // videoDestino
            // 
            this.videoDestino.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.videoDestino.HeaderText = "Video Destino";
            this.videoDestino.MinimumWidth = 150;
            this.videoDestino.Name = "videoDestino";
            this.videoDestino.ReadOnly = true;
            // 
            // BarraHerramientas
            // 
            this.BarraHerramientas.AllowMerge = false;
            this.BarraHerramientas.BackColor = System.Drawing.Color.Transparent;
            this.BarraHerramientas.GripMargin = new System.Windows.Forms.Padding(0);
            this.BarraHerramientas.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.BarraHerramientas.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.BarraHerramientas.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bSettings,
            this.toolStripSeparator1,
            this.bBuscar,
            this.bRun,
            this.toolStripSeparator2,
            this.bSalir});
            this.BarraHerramientas.Location = new System.Drawing.Point(0, 24);
            this.BarraHerramientas.Name = "BarraHerramientas";
            this.BarraHerramientas.Padding = new System.Windows.Forms.Padding(0);
            this.BarraHerramientas.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.BarraHerramientas.Size = new System.Drawing.Size(1141, 39);
            this.BarraHerramientas.TabIndex = 3;
            this.BarraHerramientas.Text = "Barra De Herramientas";
            // 
            // bSettings
            // 
            this.bSettings.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bSettings.Image = global::RenombraTusCapis.Properties.Resources.settings;
            this.bSettings.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.bSettings.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.bSettings.Name = "bSettings";
            this.bSettings.Padding = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.bSettings.Size = new System.Drawing.Size(46, 36);
            this.bSettings.Text = "Configuracion";
            this.bSettings.Click += new System.EventHandler(this.bSettings_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Margin = new System.Windows.Forms.Padding(0, 0, 5, 0);
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 39);
            // 
            // bBuscar
            // 
            this.bBuscar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bBuscar.Image = ((System.Drawing.Image)(resources.GetObject("bBuscar.Image")));
            this.bBuscar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.bBuscar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.bBuscar.Margin = new System.Windows.Forms.Padding(0, 0, 5, 0);
            this.bBuscar.Name = "bBuscar";
            this.bBuscar.Size = new System.Drawing.Size(36, 39);
            this.bBuscar.Text = "toolStripButton1";
            this.bBuscar.ToolTipText = "Buscar";
            this.bBuscar.Click += new System.EventHandler(this.bBuscar_Click);
            // 
            // bRun
            // 
            this.bRun.AutoSize = false;
            this.bRun.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bRun.Image = ((System.Drawing.Image)(resources.GetObject("bRun.Image")));
            this.bRun.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.bRun.Margin = new System.Windows.Forms.Padding(0, 0, 5, 0);
            this.bRun.Name = "bRun";
            this.bRun.Size = new System.Drawing.Size(36, 39);
            this.bRun.Text = "Convertir";
            this.bRun.Click += new System.EventHandler(this.bRun_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Margin = new System.Windows.Forms.Padding(0, 0, 5, 0);
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 39);
            // 
            // bSalir
            // 
            this.bSalir.AutoSize = false;
            this.bSalir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.bSalir.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bSalir.Image = global::RenombraTusCapis.Properties.Resources.exit;
            this.bSalir.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.bSalir.Margin = new System.Windows.Forms.Padding(0, 0, 5, 0);
            this.bSalir.Name = "bSalir";
            this.bSalir.Size = new System.Drawing.Size(32, 30);
            this.bSalir.Text = "Salir";
            this.bSalir.ToolTipText = "Salir";
            this.bSalir.Click += new System.EventHandler(this.bSalir_Click);
            // 
            // panelOpciones
            // 
            this.panelOpciones.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelOpciones.Controls.Add(this.bBuscarCarpetaSeries);
            this.panelOpciones.Controls.Add(this.labelPath);
            this.panelOpciones.Controls.Add(this.labelOpciones);
            this.panelOpciones.Controls.Add(this.textoPathSeries);
            this.panelOpciones.Controls.Add(this.bGuardar);
            this.panelOpciones.Controls.Add(this.bCancelar);
            this.panelOpciones.Location = new System.Drawing.Point(0, 24);
            this.panelOpciones.Margin = new System.Windows.Forms.Padding(10);
            this.panelOpciones.Name = "panelOpciones";
            this.panelOpciones.Size = new System.Drawing.Size(1141, 501);
            this.panelOpciones.TabIndex = 4;
            this.panelOpciones.Visible = false;
            // 
            // bBuscarCarpetaSeries
            // 
            this.bBuscarCarpetaSeries.Location = new System.Drawing.Point(405, 37);
            this.bBuscarCarpetaSeries.Name = "bBuscarCarpetaSeries";
            this.bBuscarCarpetaSeries.Size = new System.Drawing.Size(75, 23);
            this.bBuscarCarpetaSeries.TabIndex = 8;
            this.bBuscarCarpetaSeries.Text = "Buscar...";
            this.bBuscarCarpetaSeries.UseVisualStyleBackColor = true;
            this.bBuscarCarpetaSeries.Click += new System.EventHandler(this.bBuscarCarpetaSeries_Click);
            // 
            // labelPath
            // 
            this.labelPath.AutoSize = true;
            this.labelPath.Location = new System.Drawing.Point(37, 42);
            this.labelPath.Name = "labelPath";
            this.labelPath.Size = new System.Drawing.Size(137, 13);
            this.labelPath.TabIndex = 7;
            this.labelPath.Text = "Ruta a la carpeta de series:";
            // 
            // labelOpciones
            // 
            this.labelOpciones.AutoSize = true;
            this.labelOpciones.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelOpciones.Location = new System.Drawing.Point(12, 14);
            this.labelOpciones.Name = "labelOpciones";
            this.labelOpciones.Size = new System.Drawing.Size(60, 13);
            this.labelOpciones.TabIndex = 5;
            this.labelOpciones.Text = "Opciones";
            // 
            // textoPathSeries
            // 
            this.textoPathSeries.Location = new System.Drawing.Point(180, 39);
            this.textoPathSeries.Name = "textoPathSeries";
            this.textoPathSeries.Size = new System.Drawing.Size(219, 20);
            this.textoPathSeries.TabIndex = 6;
            // 
            // bGuardar
            // 
            this.bGuardar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.bGuardar.Location = new System.Drawing.Point(974, 465);
            this.bGuardar.Name = "bGuardar";
            this.bGuardar.Size = new System.Drawing.Size(75, 23);
            this.bGuardar.TabIndex = 1;
            this.bGuardar.Text = "Guardar";
            this.bGuardar.UseVisualStyleBackColor = true;
            this.bGuardar.Click += new System.EventHandler(this.bGuardar_Click);
            // 
            // bCancelar
            // 
            this.bCancelar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.bCancelar.Location = new System.Drawing.Point(1055, 465);
            this.bCancelar.Name = "bCancelar";
            this.bCancelar.Size = new System.Drawing.Size(74, 23);
            this.bCancelar.TabIndex = 0;
            this.bCancelar.Text = "Cancelar";
            this.bCancelar.UseVisualStyleBackColor = true;
            this.bCancelar.Click += new System.EventHandler(this.bCancelar_Click);
            // 
            // dialogoBuscarCarpetaSeries
            // 
            this.dialogoBuscarCarpetaSeries.Description = "Carpeta Series";
            this.dialogoBuscarCarpetaSeries.HelpRequest += new System.EventHandler(this.dialogoBuscarCarpetaSeries_HelpRequest);
            // 
            // Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1141, 524);
            this.Controls.Add(this.panelOpciones);
            this.Controls.Add(this.BarraHerramientas);
            this.Controls.Add(this.panelVistaPrevia);
            this.Controls.Add(this.menuTop1);
            this.MainMenuStrip = this.menuTop1;
            this.Name = "Principal";
            this.Text = "Renombra Tus Capis";
            this.Load += new System.EventHandler(this.Principal_Load);
            this.menuTop1.ResumeLayout(false);
            this.menuTop1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelVistaPrevia)).EndInit();
            this.BarraHerramientas.ResumeLayout(false);
            this.BarraHerramientas.PerformLayout();
            this.panelOpciones.ResumeLayout(false);
            this.panelOpciones.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuTop1;
        private System.Windows.Forms.ToolStripMenuItem configuraciónToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem opcionesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem acercaDeToolStripMenuItem;
        private System.Windows.Forms.DataGridView panelVistaPrevia;
        private System.Windows.Forms.ToolStrip BarraHerramientas;
        private System.Windows.Forms.ToolStripButton bBuscar;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton bRun;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton bSalir;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Seleccion;
        private System.Windows.Forms.DataGridViewTextBoxColumn srtOriginal;
        private System.Windows.Forms.DataGridViewButtonColumn buscaSrt;
        private System.Windows.Forms.DataGridViewTextBoxColumn srtDestino;
        private System.Windows.Forms.DataGridViewTextBoxColumn videoOriginal;
        private System.Windows.Forms.DataGridViewButtonColumn buscarVideo;
        private System.Windows.Forms.DataGridViewTextBoxColumn videoDestino;
        private System.Windows.Forms.Panel panelOpciones;
        private System.Windows.Forms.Button bGuardar;
        private System.Windows.Forms.Button bCancelar;
        private System.Windows.Forms.ToolStripButton bSettings;
        private System.Windows.Forms.Button bBuscarCarpetaSeries;
        private System.Windows.Forms.Label labelPath;
        private System.Windows.Forms.Label labelOpciones;
        private System.Windows.Forms.TextBox textoPathSeries;
        private System.Windows.Forms.FolderBrowserDialog dialogoBuscarCarpetaSeries;
    }
}

