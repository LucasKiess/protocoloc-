
namespace Protocolo.View
{
    partial class frmMedicosView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMedicosView));
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.sistemaprotocoloDataSet1 = new Protocolo.sistemaprotocoloDataSet1();
            this.sistemaprotocoloDataSet1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.especialidadesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.especialidadesTableAdapter = new Protocolo.sistemaprotocoloDataSet1TableAdapters.especialidadesTableAdapter();
            this.medicosBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.medicosTableAdapter1 = new Protocolo.sistemaprotocoloDataSet1TableAdapters.medicosTableAdapter();
            this.grid = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.crm = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.especialidade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomeEsp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.data_cadastro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataTable1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sistemaprotocoloDataSet = new Protocolo.sistemaprotocoloDataSet();
            this.medicosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tipoexamesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.conveniosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.locaisBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.usuariosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.usuariosTableAdapter = new Protocolo.sistemaprotocoloDataSetTableAdapters.usuariosTableAdapter();
            this.locaisTableAdapter = new Protocolo.sistemaprotocoloDataSetTableAdapters.locaisTableAdapter();
            this.conveniosTableAdapter = new Protocolo.sistemaprotocoloDataSetTableAdapters.conveniosTableAdapter();
            this.tipo_examesTableAdapter = new Protocolo.sistemaprotocoloDataSetTableAdapters.tipo_examesTableAdapter();
            this.medicosTableAdapter = new Protocolo.sistemaprotocoloDataSetTableAdapters.medicosTableAdapter();
            this.dataTable1TableAdapter = new Protocolo.sistemaprotocoloDataSetTableAdapters.DataTable1TableAdapter();
            this.lblModo = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.sistemaprotocoloDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sistemaprotocoloDataSet1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.especialidadesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.medicosBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTable1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sistemaprotocoloDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.medicosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tipoexamesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.conveniosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.locaisBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usuariosBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(12, 343);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(180, 15);
            this.label2.TabIndex = 20;
            this.label2.Text = "*Duplo clique para abrir opções";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(675, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 15);
            this.label1.TabIndex = 19;
            this.label1.Text = "Novo registro";
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.panel1.Location = new System.Drawing.Point(694, 10);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(57, 43);
            this.panel1.TabIndex = 18;
            this.panel1.Click += new System.EventHandler(this.panel1_Click);
            // 
            // sistemaprotocoloDataSet1
            // 
            this.sistemaprotocoloDataSet1.DataSetName = "sistemaprotocoloDataSet1";
            this.sistemaprotocoloDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // sistemaprotocoloDataSet1BindingSource
            // 
            this.sistemaprotocoloDataSet1BindingSource.DataSource = this.sistemaprotocoloDataSet1;
            this.sistemaprotocoloDataSet1BindingSource.Position = 0;
            // 
            // especialidadesBindingSource
            // 
            this.especialidadesBindingSource.DataMember = "especialidades";
            this.especialidadesBindingSource.DataSource = this.sistemaprotocoloDataSet1BindingSource;
            // 
            // especialidadesTableAdapter
            // 
            this.especialidadesTableAdapter.ClearBeforeFill = true;
            // 
            // medicosBindingSource1
            // 
            this.medicosBindingSource1.DataMember = "medicos";
            this.medicosBindingSource1.DataSource = this.sistemaprotocoloDataSet1;
            // 
            // medicosTableAdapter1
            // 
            this.medicosTableAdapter1.ClearBeforeFill = true;
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
            this.nome,
            this.crm,
            this.especialidade,
            this.nomeEsp,
            this.data_cadastro});
            this.grid.Location = new System.Drawing.Point(12, 74);
            this.grid.MultiSelect = false;
            this.grid.Name = "grid";
            this.grid.ReadOnly = true;
            this.grid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grid.Size = new System.Drawing.Size(760, 266);
            this.grid.TabIndex = 21;
            this.grid.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grid_CellDoubleClick_1);
            // 
            // id
            // 
            this.id.DataPropertyName = "id";
            this.id.HeaderText = "ID";
            this.id.Name = "id";
            this.id.ReadOnly = true;
            this.id.Visible = false;
            // 
            // nome
            // 
            this.nome.DataPropertyName = "nome";
            this.nome.HeaderText = "Nome";
            this.nome.Name = "nome";
            this.nome.ReadOnly = true;
            this.nome.Width = 250;
            // 
            // crm
            // 
            this.crm.DataPropertyName = "crm";
            this.crm.HeaderText = "CRM";
            this.crm.Name = "crm";
            this.crm.ReadOnly = true;
            // 
            // especialidade
            // 
            this.especialidade.DataPropertyName = "especialidade";
            this.especialidade.HeaderText = "Código Especialidade";
            this.especialidade.Name = "especialidade";
            this.especialidade.ReadOnly = true;
            this.especialidade.Visible = false;
            // 
            // nomeEsp
            // 
            this.nomeEsp.DataPropertyName = "nomeEsp";
            this.nomeEsp.HeaderText = "Especialidade";
            this.nomeEsp.Name = "nomeEsp";
            this.nomeEsp.ReadOnly = true;
            this.nomeEsp.Width = 200;
            // 
            // data_cadastro
            // 
            this.data_cadastro.DataPropertyName = "data_cadastro";
            this.data_cadastro.HeaderText = "Data de Cadastro";
            this.data_cadastro.Name = "data_cadastro";
            this.data_cadastro.ReadOnly = true;
            this.data_cadastro.Width = 130;
            // 
            // dataTable1BindingSource
            // 
            this.dataTable1BindingSource.DataMember = "DataTable1";
            this.dataTable1BindingSource.DataSource = this.sistemaprotocoloDataSet;
            // 
            // sistemaprotocoloDataSet
            // 
            this.sistemaprotocoloDataSet.DataSetName = "sistemaprotocoloDataSet";
            this.sistemaprotocoloDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // medicosBindingSource
            // 
            this.medicosBindingSource.DataMember = "medicos";
            this.medicosBindingSource.DataSource = this.sistemaprotocoloDataSet;
            // 
            // tipoexamesBindingSource
            // 
            this.tipoexamesBindingSource.DataMember = "tipo_exames";
            this.tipoexamesBindingSource.DataSource = this.sistemaprotocoloDataSet;
            // 
            // conveniosBindingSource
            // 
            this.conveniosBindingSource.DataMember = "convenios";
            this.conveniosBindingSource.DataSource = this.sistemaprotocoloDataSet;
            // 
            // locaisBindingSource
            // 
            this.locaisBindingSource.DataMember = "locais";
            this.locaisBindingSource.DataSource = this.sistemaprotocoloDataSet;
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
            // locaisTableAdapter
            // 
            this.locaisTableAdapter.ClearBeforeFill = true;
            // 
            // conveniosTableAdapter
            // 
            this.conveniosTableAdapter.ClearBeforeFill = true;
            // 
            // tipo_examesTableAdapter
            // 
            this.tipo_examesTableAdapter.ClearBeforeFill = true;
            // 
            // medicosTableAdapter
            // 
            this.medicosTableAdapter.ClearBeforeFill = true;
            // 
            // dataTable1TableAdapter
            // 
            this.dataTable1TableAdapter.ClearBeforeFill = true;
            // 
            // lblModo
            // 
            this.lblModo.AutoSize = true;
            this.lblModo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblModo.ForeColor = System.Drawing.Color.Red;
            this.lblModo.Location = new System.Drawing.Point(12, 26);
            this.lblModo.Name = "lblModo";
            this.lblModo.Size = new System.Drawing.Size(37, 15);
            this.lblModo.TabIndex = 22;
            this.lblModo.Text = "..........";
            this.lblModo.Visible = false;
            // 
            // frmMedicosView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(788, 391);
            this.Controls.Add(this.lblModo);
            this.Controls.Add(this.grid);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmMedicosView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Medicos - Procotolo";
            this.Activated += new System.EventHandler(this.frmMedicosView_Activated);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmMedicosView_FormClosed);
            this.Load += new System.EventHandler(this.frmMedicosView_Load);
            ((System.ComponentModel.ISupportInitialize)(this.sistemaprotocoloDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sistemaprotocoloDataSet1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.especialidadesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.medicosBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTable1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sistemaprotocoloDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.medicosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tipoexamesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.conveniosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.locaisBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usuariosBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.BindingSource tipoexamesBindingSource;
        private sistemaprotocoloDataSet sistemaprotocoloDataSet;
        private System.Windows.Forms.BindingSource conveniosBindingSource;
        private System.Windows.Forms.BindingSource locaisBindingSource;
        private System.Windows.Forms.BindingSource usuariosBindingSource;
        private sistemaprotocoloDataSetTableAdapters.usuariosTableAdapter usuariosTableAdapter;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private sistemaprotocoloDataSetTableAdapters.locaisTableAdapter locaisTableAdapter;
        private sistemaprotocoloDataSetTableAdapters.conveniosTableAdapter conveniosTableAdapter;
        private sistemaprotocoloDataSetTableAdapters.tipo_examesTableAdapter tipo_examesTableAdapter;
        private System.Windows.Forms.BindingSource medicosBindingSource;
        private sistemaprotocoloDataSetTableAdapters.medicosTableAdapter medicosTableAdapter;
        private System.Windows.Forms.BindingSource sistemaprotocoloDataSet1BindingSource;
        private sistemaprotocoloDataSet1 sistemaprotocoloDataSet1;
        private System.Windows.Forms.BindingSource especialidadesBindingSource;
        private sistemaprotocoloDataSet1TableAdapters.especialidadesTableAdapter especialidadesTableAdapter;
        private System.Windows.Forms.BindingSource medicosBindingSource1;
        private sistemaprotocoloDataSet1TableAdapters.medicosTableAdapter medicosTableAdapter1;
        private System.Windows.Forms.DataGridView grid;
        private System.Windows.Forms.BindingSource dataTable1BindingSource;
        private sistemaprotocoloDataSetTableAdapters.DataTable1TableAdapter dataTable1TableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn nome;
        private System.Windows.Forms.DataGridViewTextBoxColumn crm;
        private System.Windows.Forms.DataGridViewTextBoxColumn especialidade;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomeEsp;
        private System.Windows.Forms.DataGridViewTextBoxColumn data_cadastro;
        public System.Windows.Forms.Label lblModo;
    }
}