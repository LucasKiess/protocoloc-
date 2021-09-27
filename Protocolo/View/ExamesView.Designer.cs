
namespace Protocolo.View
{
    partial class frmExamesView
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmExamesView));
            this.grid = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tipo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Sigla = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Num = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Paci = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Medico = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Convenio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DataEnt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IdPac = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IdMed = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IdCon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.locaisBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sistemaprotocoloDataSet = new Protocolo.sistemaprotocoloDataSet();
            this.usuariosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.usuariosTableAdapter = new Protocolo.sistemaprotocoloDataSetTableAdapters.usuariosTableAdapter();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.locaisTableAdapter = new Protocolo.sistemaprotocoloDataSetTableAdapters.locaisTableAdapter();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtBusca = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.dtInicio = new System.Windows.Forms.DateTimePicker();
            this.dtFim = new System.Windows.Forms.DateTimePicker();
            this.btnBuscaPeriodo = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.grid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.locaisBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sistemaprotocoloDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usuariosBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // grid
            // 
            this.grid.AllowUserToAddRows = false;
            this.grid.AllowUserToDeleteRows = false;
            this.grid.AllowUserToResizeColumns = false;
            this.grid.AllowUserToResizeRows = false;
            this.grid.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.Tipo,
            this.Sigla,
            this.Num,
            this.Paci,
            this.Medico,
            this.Convenio,
            this.DataEnt,
            this.IdPac,
            this.IdMed,
            this.IdCon});
            this.grid.Location = new System.Drawing.Point(12, 71);
            this.grid.MultiSelect = false;
            this.grid.Name = "grid";
            this.grid.ReadOnly = true;
            this.grid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grid.Size = new System.Drawing.Size(753, 266);
            this.grid.TabIndex = 9;
            this.grid.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grid_CellDoubleClick);
            // 
            // id
            // 
            this.id.DataPropertyName = "ID";
            this.id.HeaderText = "ID";
            this.id.Name = "id";
            this.id.ReadOnly = true;
            this.id.Visible = false;
            // 
            // Tipo
            // 
            this.Tipo.DataPropertyName = "Tipo";
            this.Tipo.HeaderText = "Tipo";
            this.Tipo.Name = "Tipo";
            this.Tipo.ReadOnly = true;
            this.Tipo.Visible = false;
            this.Tipo.Width = 250;
            // 
            // Sigla
            // 
            this.Sigla.DataPropertyName = "Sigla";
            this.Sigla.HeaderText = "Tipo";
            this.Sigla.Name = "Sigla";
            this.Sigla.ReadOnly = true;
            this.Sigla.Width = 35;
            // 
            // Num
            // 
            this.Num.DataPropertyName = "Num";
            dataGridViewCellStyle1.Format = "d";
            dataGridViewCellStyle1.NullValue = null;
            this.Num.DefaultCellStyle = dataGridViewCellStyle1;
            this.Num.HeaderText = "Número";
            this.Num.Name = "Num";
            this.Num.ReadOnly = true;
            this.Num.Width = 50;
            // 
            // Paci
            // 
            this.Paci.DataPropertyName = "Paci";
            this.Paci.HeaderText = "Paciente";
            this.Paci.Name = "Paci";
            this.Paci.ReadOnly = true;
            this.Paci.Width = 250;
            // 
            // Medico
            // 
            this.Medico.DataPropertyName = "Medico";
            this.Medico.HeaderText = "Médico";
            this.Medico.Name = "Medico";
            this.Medico.ReadOnly = true;
            this.Medico.Width = 150;
            // 
            // Convenio
            // 
            this.Convenio.DataPropertyName = "Convenio";
            this.Convenio.HeaderText = "Convênio";
            this.Convenio.Name = "Convenio";
            this.Convenio.ReadOnly = true;
            // 
            // DataEnt
            // 
            this.DataEnt.DataPropertyName = "DataEnt";
            this.DataEnt.HeaderText = "Entrada";
            this.DataEnt.Name = "DataEnt";
            this.DataEnt.ReadOnly = true;
            // 
            // IdPac
            // 
            this.IdPac.DataPropertyName = "IdPac";
            this.IdPac.HeaderText = "IdPac";
            this.IdPac.Name = "IdPac";
            this.IdPac.ReadOnly = true;
            this.IdPac.Visible = false;
            // 
            // IdMed
            // 
            this.IdMed.DataPropertyName = "IdMed";
            this.IdMed.HeaderText = "IdMed";
            this.IdMed.Name = "IdMed";
            this.IdMed.ReadOnly = true;
            this.IdMed.Visible = false;
            // 
            // IdCon
            // 
            this.IdCon.DataPropertyName = "IdCon";
            this.IdCon.HeaderText = "IdCon";
            this.IdCon.Name = "IdCon";
            this.IdCon.ReadOnly = true;
            this.IdCon.Visible = false;
            // 
            // locaisBindingSource
            // 
            this.locaisBindingSource.DataMember = "locais";
            this.locaisBindingSource.DataSource = this.sistemaprotocoloDataSet;
            // 
            // sistemaprotocoloDataSet
            // 
            this.sistemaprotocoloDataSet.DataSetName = "sistemaprotocoloDataSet";
            this.sistemaprotocoloDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // usuariosBindingSource
            // 
            this.usuariosBindingSource.DataMember = "usuarios";
            this.usuariosBindingSource.DataSource = this.sistemaprotocoloDataSet;
            // 
            // usuariosTableAdapter
            // 
            this.usuariosTableAdapter.ClearBeforeFill = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(12, 352);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(180, 15);
            this.label2.TabIndex = 12;
            this.label2.Text = "*Duplo clique para abrir opções";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(664, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 15);
            this.label1.TabIndex = 11;
            this.label1.Text = "Novo registro";
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.panel1.Location = new System.Drawing.Point(683, 7);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(57, 43);
            this.panel1.TabIndex = 10;
            this.panel1.Click += new System.EventHandler(this.panel1_Click);
            // 
            // locaisTableAdapter
            // 
            this.locaisTableAdapter.ClearBeforeFill = true;
            // 
            // btnSalvar
            // 
            this.btnSalvar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSalvar.Location = new System.Drawing.Point(606, 343);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(159, 23);
            this.btnSalvar.TabIndex = 29;
            this.btnSalvar.Text = "Exibir todos os registros";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(32, 51);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 15);
            this.label3.TabIndex = 28;
            this.label3.Text = "Busca pac.:";
            // 
            // panel2
            // 
            this.panel2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel2.BackgroundImage")));
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel2.Cursor = System.Windows.Forms.Cursors.Default;
            this.panel2.Location = new System.Drawing.Point(35, 18);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(39, 30);
            this.panel2.TabIndex = 26;
            // 
            // txtBusca
            // 
            this.txtBusca.Location = new System.Drawing.Point(108, 46);
            this.txtBusca.Name = "txtBusca";
            this.txtBusca.Size = new System.Drawing.Size(170, 20);
            this.txtBusca.TabIndex = 27;
            this.txtBusca.TextChanged += new System.EventHandler(this.txtBusca_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(313, 51);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 15);
            this.label4.TabIndex = 30;
            this.label4.Text = "Busca período:";
            // 
            // dtInicio
            // 
            this.dtInicio.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtInicio.Location = new System.Drawing.Point(408, 18);
            this.dtInicio.Name = "dtInicio";
            this.dtInicio.Size = new System.Drawing.Size(101, 20);
            this.dtInicio.TabIndex = 31;
            // 
            // dtFim
            // 
            this.dtFim.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtFim.Location = new System.Drawing.Point(408, 47);
            this.dtFim.Name = "dtFim";
            this.dtFim.Size = new System.Drawing.Size(101, 20);
            this.dtFim.TabIndex = 32;
            // 
            // btnBuscaPeriodo
            // 
            this.btnBuscaPeriodo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBuscaPeriodo.Location = new System.Drawing.Point(515, 46);
            this.btnBuscaPeriodo.Name = "btnBuscaPeriodo";
            this.btnBuscaPeriodo.Size = new System.Drawing.Size(46, 22);
            this.btnBuscaPeriodo.TabIndex = 33;
            this.btnBuscaPeriodo.Text = "Busca";
            this.btnBuscaPeriodo.UseVisualStyleBackColor = true;
            this.btnBuscaPeriodo.Click += new System.EventHandler(this.btnBuscaPeriodo_Click);
            // 
            // frmExamesView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(780, 382);
            this.Controls.Add(this.btnBuscaPeriodo);
            this.Controls.Add(this.dtFim);
            this.Controls.Add(this.dtInicio);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.txtBusca);
            this.Controls.Add(this.grid);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmExamesView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Exames - Protocolo";
            this.Activated += new System.EventHandler(this.frmExamesView_Activated);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmExamesView_FormClosed);
            this.Load += new System.EventHandler(this.frmExamesView_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.locaisBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sistemaprotocoloDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usuariosBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView grid;
        private System.Windows.Forms.BindingSource locaisBindingSource;
        private sistemaprotocoloDataSet sistemaprotocoloDataSet;
        private System.Windows.Forms.BindingSource usuariosBindingSource;
        private sistemaprotocoloDataSetTableAdapters.usuariosTableAdapter usuariosTableAdapter;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private sistemaprotocoloDataSetTableAdapters.locaisTableAdapter locaisTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tipo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sigla;
        private System.Windows.Forms.DataGridViewTextBoxColumn Num;
        private System.Windows.Forms.DataGridViewTextBoxColumn Paci;
        private System.Windows.Forms.DataGridViewTextBoxColumn Medico;
        private System.Windows.Forms.DataGridViewTextBoxColumn Convenio;
        private System.Windows.Forms.DataGridViewTextBoxColumn DataEnt;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdPac;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdMed;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdCon;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txtBusca;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dtInicio;
        private System.Windows.Forms.DateTimePicker dtFim;
        private System.Windows.Forms.Button btnBuscaPeriodo;
    }
}