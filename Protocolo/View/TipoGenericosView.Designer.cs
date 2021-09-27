
namespace Protocolo.View
{
    partial class frmTipoGenericosView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTipoGenericosView));
            this.grid = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sigla = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descricao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipogenericosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sistemaprotocoloDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sistemaprotocoloDataSet = new Protocolo.sistemaprotocoloDataSet();
            this.tipoexamesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.conveniosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.locaisBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.usuariosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.usuariosTableAdapter = new Protocolo.sistemaprotocoloDataSetTableAdapters.usuariosTableAdapter();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.locaisTableAdapter = new Protocolo.sistemaprotocoloDataSetTableAdapters.locaisTableAdapter();
            this.conveniosTableAdapter = new Protocolo.sistemaprotocoloDataSetTableAdapters.conveniosTableAdapter();
            this.tipo_examesTableAdapter = new Protocolo.sistemaprotocoloDataSetTableAdapters.tipo_examesTableAdapter();
            this.tipo_genericosTableAdapter = new Protocolo.sistemaprotocoloDataSetTableAdapters.tipo_genericosTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.grid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tipogenericosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sistemaprotocoloDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sistemaprotocoloDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tipoexamesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.conveniosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.locaisBindingSource)).BeginInit();
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
            this.sigla,
            this.descricao});
            this.grid.Location = new System.Drawing.Point(12, 73);
            this.grid.MultiSelect = false;
            this.grid.Name = "grid";
            this.grid.ReadOnly = true;
            this.grid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grid.Size = new System.Drawing.Size(373, 266);
            this.grid.TabIndex = 17;
            this.grid.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grid_CellDoubleClick);
            // 
            // id
            // 
            this.id.DataPropertyName = "id";
            this.id.HeaderText = "ID";
            this.id.Name = "id";
            this.id.ReadOnly = true;
            this.id.Visible = false;
            // 
            // sigla
            // 
            this.sigla.DataPropertyName = "sigla";
            this.sigla.HeaderText = "Sigla";
            this.sigla.Name = "sigla";
            this.sigla.ReadOnly = true;
            this.sigla.Width = 50;
            // 
            // descricao
            // 
            this.descricao.DataPropertyName = "descricao";
            this.descricao.HeaderText = "Descrição";
            this.descricao.Name = "descricao";
            this.descricao.ReadOnly = true;
            this.descricao.Width = 250;
            // 
            // tipogenericosBindingSource
            // 
            this.tipogenericosBindingSource.DataMember = "tipo_genericos";
            this.tipogenericosBindingSource.DataSource = this.sistemaprotocoloDataSetBindingSource;
            // 
            // sistemaprotocoloDataSetBindingSource
            // 
            this.sistemaprotocoloDataSetBindingSource.DataSource = this.sistemaprotocoloDataSet;
            this.sistemaprotocoloDataSetBindingSource.Position = 0;
            // 
            // sistemaprotocoloDataSet
            // 
            this.sistemaprotocoloDataSet.DataSetName = "sistemaprotocoloDataSet";
            this.sistemaprotocoloDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(12, 342);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(180, 15);
            this.label2.TabIndex = 20;
            this.label2.Text = "*Duplo clique para abrir opções";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(295, 55);
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
            this.panel1.Location = new System.Drawing.Point(314, 9);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(57, 43);
            this.panel1.TabIndex = 18;
            this.panel1.Click += new System.EventHandler(this.panel1_Click);
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
            // tipo_genericosTableAdapter
            // 
            this.tipo_genericosTableAdapter.ClearBeforeFill = true;
            // 
            // frmTipoGenericosView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(402, 386);
            this.Controls.Add(this.grid);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmTipoGenericosView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tipos Genéricos - Protocolo";
            this.Activated += new System.EventHandler(this.frmTipoGenericosView_Activated);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmTipoGenericosView_FormClosed);
            this.Load += new System.EventHandler(this.frmTipoGenericosView_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tipogenericosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sistemaprotocoloDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sistemaprotocoloDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tipoexamesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.conveniosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.locaisBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usuariosBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView grid;
        private System.Windows.Forms.BindingSource sistemaprotocoloDataSetBindingSource;
        private sistemaprotocoloDataSet sistemaprotocoloDataSet;
        private System.Windows.Forms.BindingSource tipoexamesBindingSource;
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
        private System.Windows.Forms.BindingSource tipogenericosBindingSource;
        private sistemaprotocoloDataSetTableAdapters.tipo_genericosTableAdapter tipo_genericosTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn sigla;
        private System.Windows.Forms.DataGridViewTextBoxColumn descricao;
    }
}