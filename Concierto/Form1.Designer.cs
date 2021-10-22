
namespace Concierto
{
    partial class frmConcierto
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
            this.components = new System.ComponentModel.Container();
            this.lblNroEntrada = new System.Windows.Forms.Label();
            this.lblCantidad0 = new System.Windows.Forms.Label();
            this.lblCantidad = new System.Windows.Forms.Label();
            this.lblSector = new System.Windows.Forms.Label();
            this.lblTipoComprador = new System.Windows.Forms.Label();
            this.txtNroEntrada = new System.Windows.Forms.TextBox();
            this.txtCantidad = new System.Windows.Forms.TextBox();
            this.cboSector = new System.Windows.Forms.ComboBox();
            this.cboTipoComprador = new System.Windows.Forms.ComboBox();
            this.lblCantidad1 = new System.Windows.Forms.Label();
            this.lvEntradas = new System.Windows.Forms.ListView();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label5 = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblNroEntrada
            // 
            this.lblNroEntrada.AutoSize = true;
            this.lblNroEntrada.Location = new System.Drawing.Point(45, 52);
            this.lblNroEntrada.Name = "lblNroEntrada";
            this.lblNroEntrada.Size = new System.Drawing.Size(64, 13);
            this.lblNroEntrada.TabIndex = 0;
            this.lblNroEntrada.Text = "Nro Entrada";
            // 
            // lblCantidad0
            // 
            this.lblCantidad0.AutoSize = true;
            this.lblCantidad0.Location = new System.Drawing.Point(45, 319);
            this.lblCantidad0.Name = "lblCantidad0";
            this.lblCantidad0.Size = new System.Drawing.Size(49, 13);
            this.lblCantidad0.TabIndex = 1;
            this.lblCantidad0.Text = "Cantidad";
            // 
            // lblCantidad
            // 
            this.lblCantidad.AutoSize = true;
            this.lblCantidad.Location = new System.Drawing.Point(112, 319);
            this.lblCantidad.Name = "lblCantidad";
            this.lblCantidad.Size = new System.Drawing.Size(13, 13);
            this.lblCantidad.TabIndex = 2;
            this.lblCantidad.Text = "0";
            // 
            // lblSector
            // 
            this.lblSector.AutoSize = true;
            this.lblSector.Location = new System.Drawing.Point(45, 92);
            this.lblSector.Name = "lblSector";
            this.lblSector.Size = new System.Drawing.Size(38, 13);
            this.lblSector.TabIndex = 3;
            this.lblSector.Text = "Sector";
            // 
            // lblTipoComprador
            // 
            this.lblTipoComprador.AutoSize = true;
            this.lblTipoComprador.Location = new System.Drawing.Point(322, 52);
            this.lblTipoComprador.Name = "lblTipoComprador";
            this.lblTipoComprador.Size = new System.Drawing.Size(82, 13);
            this.lblTipoComprador.TabIndex = 4;
            this.lblTipoComprador.Text = "Tipo Comprador";
            // 
            // txtNroEntrada
            // 
            this.txtNroEntrada.Location = new System.Drawing.Point(115, 52);
            this.txtNroEntrada.Name = "txtNroEntrada";
            this.txtNroEntrada.Size = new System.Drawing.Size(100, 20);
            this.txtNroEntrada.TabIndex = 5;
            // 
            // txtCantidad
            // 
            this.txtCantidad.Location = new System.Drawing.Point(422, 92);
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(100, 20);
            this.txtCantidad.TabIndex = 6;
            // 
            // cboSector
            // 
            this.cboSector.FormattingEnabled = true;
            this.cboSector.Items.AddRange(new object[] {
            "GENERAL",
            "VIP",
            "PLATINUM LATERAL",
            "PLATINUM CENTRAL"});
            this.cboSector.Location = new System.Drawing.Point(115, 92);
            this.cboSector.Name = "cboSector";
            this.cboSector.Size = new System.Drawing.Size(121, 21);
            this.cboSector.TabIndex = 7;
            // 
            // cboTipoComprador
            // 
            this.cboTipoComprador.FormattingEnabled = true;
            this.cboTipoComprador.Items.AddRange(new object[] {
            "ESTUDIANTE",
            "BOMBERO",
            "NORMAL"});
            this.cboTipoComprador.Location = new System.Drawing.Point(422, 52);
            this.cboTipoComprador.Name = "cboTipoComprador";
            this.cboTipoComprador.Size = new System.Drawing.Size(121, 21);
            this.cboTipoComprador.TabIndex = 8;
            // 
            // lblCantidad1
            // 
            this.lblCantidad1.AutoSize = true;
            this.lblCantidad1.Location = new System.Drawing.Point(322, 96);
            this.lblCantidad1.Name = "lblCantidad1";
            this.lblCantidad1.Size = new System.Drawing.Size(49, 13);
            this.lblCantidad1.TabIndex = 9;
            this.lblCantidad1.Text = "Cantidad";
            // 
            // lvEntradas
            // 
            this.lvEntradas.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.lvEntradas.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader7,
            this.columnHeader8});
            this.lvEntradas.FullRowSelect = true;
            this.lvEntradas.HideSelection = false;
            this.lvEntradas.Location = new System.Drawing.Point(38, 170);
            this.lvEntradas.Name = "lvEntradas";
            this.lvEntradas.Size = new System.Drawing.Size(635, 139);
            this.lvEntradas.TabIndex = 10;
            this.lvEntradas.UseCompatibleStateImageBehavior = false;
            this.lvEntradas.View = System.Windows.Forms.View.Details;
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(48, 130);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(75, 23);
            this.btnAgregar.TabIndex = 11;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(161, 130);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(75, 23);
            this.btnLimpiar.TabIndex = 12;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // btnCerrar
            // 
            this.btnCerrar.Location = new System.Drawing.Point(533, 130);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(75, 23);
            this.btnCerrar.TabIndex = 13;
            this.btnCerrar.Text = "Cerrar";
            this.btnCerrar.UseVisualStyleBackColor = true;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Nro_Entrada";
            this.columnHeader1.Width = 84;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Fecha";
            this.columnHeader2.Width = 76;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Sector";
            this.columnHeader3.Width = 102;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Precio";
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Cant.";
            this.columnHeader5.Width = 78;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "SubTotal";
            this.columnHeader6.Width = 76;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Descuento";
            this.columnHeader7.Width = 77;
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "Total";
            this.columnHeader8.Width = 65;
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.SystemColors.ControlDark;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(0, -1);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(708, 37);
            this.label5.TabIndex = 14;
            this.label5.Text = "FITO PAEZ EN CONCIERTO";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // frmConcierto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(710, 372);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.lvEntradas);
            this.Controls.Add(this.lblCantidad1);
            this.Controls.Add(this.cboTipoComprador);
            this.Controls.Add(this.cboSector);
            this.Controls.Add(this.txtCantidad);
            this.Controls.Add(this.txtNroEntrada);
            this.Controls.Add(this.lblTipoComprador);
            this.Controls.Add(this.lblSector);
            this.Controls.Add(this.lblCantidad);
            this.Controls.Add(this.lblCantidad0);
            this.Controls.Add(this.lblNroEntrada);
            this.Name = "frmConcierto";
            this.Text = "TELEVENTAS - VENTA DE ENTRADAS PARA FITO PAEZ EN CONCIERTO";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNroEntrada;
        private System.Windows.Forms.Label lblCantidad0;
        private System.Windows.Forms.Label lblCantidad;
        private System.Windows.Forms.Label lblSector;
        private System.Windows.Forms.Label lblTipoComprador;
        private System.Windows.Forms.TextBox txtNroEntrada;
        private System.Windows.Forms.TextBox txtCantidad;
        private System.Windows.Forms.ComboBox cboSector;
        private System.Windows.Forms.ComboBox cboTipoComprador;
        private System.Windows.Forms.Label lblCantidad1;
        private System.Windows.Forms.ListView lvEntradas;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}

