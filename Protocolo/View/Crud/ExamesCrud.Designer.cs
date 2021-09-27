
namespace Protocolo.View.Crud
{
    partial class frmExamesCrud
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
            this.btnSalvar = new System.Windows.Forms.Button();
            this.data = new System.Windows.Forms.DateTimePicker();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.cbConvenio = new System.Windows.Forms.ComboBox();
            this.label13 = new System.Windows.Forms.Label();
            this.btnProcuraMedico = new System.Windows.Forms.Button();
            this.txtNomeMedico = new System.Windows.Forms.TextBox();
            this.txtIdMedico = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.txtCrm = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.txtNumero = new System.Windows.Forms.TextBox();
            this.cbTipo = new System.Windows.Forms.ComboBox();
            this.label17 = new System.Windows.Forms.Label();
            this.txtTipo = new System.Windows.Forms.TextBox();
            this.txtTelefonePaciente = new System.Windows.Forms.MaskedTextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.txtIdadePaciente = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.lblIdPaciente = new System.Windows.Forms.Label();
            this.txtNomePaciente = new System.Windows.Forms.TextBox();
            this.label21 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSalvar
            // 
            this.btnSalvar.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnSalvar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSalvar.FlatAppearance.BorderSize = 0;
            this.btnSalvar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalvar.Location = new System.Drawing.Point(321, 214);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(152, 23);
            this.btnSalvar.TabIndex = 50;
            this.btnSalvar.Text = "REGISTRAR EXAME";
            this.btnSalvar.UseVisualStyleBackColor = false;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // data
            // 
            this.data.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.data.Location = new System.Drawing.Point(321, 164);
            this.data.Name = "data";
            this.data.Size = new System.Drawing.Size(101, 20);
            this.data.TabIndex = 49;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(268, 166);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(47, 13);
            this.label11.TabIndex = 48;
            this.label11.Text = "Entrada:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(12, 166);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(55, 13);
            this.label12.TabIndex = 47;
            this.label12.Text = "Convênio:";
            // 
            // cbConvenio
            // 
            this.cbConvenio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbConvenio.FormattingEnabled = true;
            this.cbConvenio.Location = new System.Drawing.Point(73, 163);
            this.cbConvenio.Name = "cbConvenio";
            this.cbConvenio.Size = new System.Drawing.Size(159, 21);
            this.cbConvenio.TabIndex = 4;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.Red;
            this.label13.Location = new System.Drawing.Point(43, 127);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(90, 13);
            this.label13.TabIndex = 45;
            this.label13.Text = "Ou botão Procura";
            // 
            // btnProcuraMedico
            // 
            this.btnProcuraMedico.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnProcuraMedico.FlatAppearance.BorderSize = 0;
            this.btnProcuraMedico.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProcuraMedico.Location = new System.Drawing.Point(152, 89);
            this.btnProcuraMedico.Name = "btnProcuraMedico";
            this.btnProcuraMedico.Size = new System.Drawing.Size(52, 23);
            this.btnProcuraMedico.TabIndex = 44;
            this.btnProcuraMedico.Text = "Procura";
            this.btnProcuraMedico.UseVisualStyleBackColor = false;
            this.btnProcuraMedico.Click += new System.EventHandler(this.btnProcuraMedico_Click);
            // 
            // txtNomeMedico
            // 
            this.txtNomeMedico.Enabled = false;
            this.txtNomeMedico.Location = new System.Drawing.Point(259, 91);
            this.txtNomeMedico.Name = "txtNomeMedico";
            this.txtNomeMedico.Size = new System.Drawing.Size(214, 20);
            this.txtNomeMedico.TabIndex = 43;
            // 
            // txtIdMedico
            // 
            this.txtIdMedico.Enabled = false;
            this.txtIdMedico.Location = new System.Drawing.Point(218, 91);
            this.txtIdMedico.Name = "txtIdMedico";
            this.txtIdMedico.Size = new System.Drawing.Size(26, 20);
            this.txtIdMedico.TabIndex = 42;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.Red;
            this.label14.Location = new System.Drawing.Point(17, 114);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(162, 13);
            this.label14.TabIndex = 41;
            this.label14.Text = "Digite o CRM e pressione ENTER";
            // 
            // txtCrm
            // 
            this.txtCrm.Location = new System.Drawing.Point(73, 91);
            this.txtCrm.Name = "txtCrm";
            this.txtCrm.Size = new System.Drawing.Size(73, 20);
            this.txtCrm.TabIndex = 3;
            this.txtCrm.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtCrm_KeyDown);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(22, 94);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(45, 13);
            this.label15.TabIndex = 39;
            this.label15.Text = "Médico:";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(268, 47);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(35, 13);
            this.label16.TabIndex = 38;
            this.label16.Text = "Núm.:";
            // 
            // txtNumero
            // 
            this.txtNumero.Location = new System.Drawing.Point(309, 44);
            this.txtNumero.Name = "txtNumero";
            this.txtNumero.Size = new System.Drawing.Size(73, 20);
            this.txtNumero.TabIndex = 2;
            // 
            // cbTipo
            // 
            this.cbTipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTipo.FormattingEnabled = true;
            this.cbTipo.Location = new System.Drawing.Point(103, 44);
            this.cbTipo.Name = "cbTipo";
            this.cbTipo.Size = new System.Drawing.Size(159, 21);
            this.cbTipo.TabIndex = 36;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(36, 47);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(31, 13);
            this.label17.TabIndex = 35;
            this.label17.Text = "Tipo:";
            // 
            // txtTipo
            // 
            this.txtTipo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtTipo.Location = new System.Drawing.Point(73, 44);
            this.txtTipo.MaxLength = 1;
            this.txtTipo.Name = "txtTipo";
            this.txtTipo.Size = new System.Drawing.Size(24, 20);
            this.txtTipo.TabIndex = 1;
            this.txtTipo.TextChanged += new System.EventHandler(this.txtTipo_TextChanged);
            // 
            // txtTelefonePaciente
            // 
            this.txtTelefonePaciente.Enabled = false;
            this.txtTelefonePaciente.Location = new System.Drawing.Point(78, 112);
            this.txtTelefonePaciente.Mask = "(99) 00000-0000";
            this.txtTelefonePaciente.Name = "txtTelefonePaciente";
            this.txtTelefonePaciente.Size = new System.Drawing.Size(100, 20);
            this.txtTelefonePaciente.TabIndex = 55;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(20, 115);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(52, 13);
            this.label18.TabIndex = 57;
            this.label18.Text = "Telefone:";
            // 
            // txtIdadePaciente
            // 
            this.txtIdadePaciente.Enabled = false;
            this.txtIdadePaciente.Location = new System.Drawing.Point(78, 86);
            this.txtIdadePaciente.MaxLength = 3;
            this.txtIdadePaciente.Name = "txtIdadePaciente";
            this.txtIdadePaciente.Size = new System.Drawing.Size(40, 20);
            this.txtIdadePaciente.TabIndex = 54;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(35, 89);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(37, 13);
            this.label19.TabIndex = 56;
            this.label19.Text = "Idade:";
            // 
            // lblIdPaciente
            // 
            this.lblIdPaciente.AutoSize = true;
            this.lblIdPaciente.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIdPaciente.ForeColor = System.Drawing.Color.Red;
            this.lblIdPaciente.Location = new System.Drawing.Point(75, 32);
            this.lblIdPaciente.Name = "lblIdPaciente";
            this.lblIdPaciente.Size = new System.Drawing.Size(68, 17);
            this.lblIdPaciente.TabIndex = 53;
            this.lblIdPaciente.Text = "............";
            // 
            // txtNomePaciente
            // 
            this.txtNomePaciente.Enabled = false;
            this.txtNomePaciente.Location = new System.Drawing.Point(78, 59);
            this.txtNomePaciente.MaxLength = 50;
            this.txtNomePaciente.Name = "txtNomePaciente";
            this.txtNomePaciente.Size = new System.Drawing.Size(321, 20);
            this.txtNomePaciente.TabIndex = 51;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(34, 62);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(38, 13);
            this.label21.TabIndex = 52;
            this.label21.Text = "Nome:";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.txtIdadePaciente);
            this.panel1.Controls.Add(this.txtTelefonePaciente);
            this.panel1.Controls.Add(this.label21);
            this.panel1.Controls.Add(this.label18);
            this.panel1.Controls.Add(this.txtNomePaciente);
            this.panel1.Controls.Add(this.lblIdPaciente);
            this.panel1.Controls.Add(this.label19);
            this.panel1.Location = new System.Drawing.Point(12, 22);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(498, 147);
            this.panel1.TabIndex = 58;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(9, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 17);
            this.label1.TabIndex = 58;
            this.label1.Text = "Paciente";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.data);
            this.panel2.Controls.Add(this.txtTipo);
            this.panel2.Controls.Add(this.btnSalvar);
            this.panel2.Controls.Add(this.label17);
            this.panel2.Controls.Add(this.cbTipo);
            this.panel2.Controls.Add(this.label11);
            this.panel2.Controls.Add(this.txtNumero);
            this.panel2.Controls.Add(this.label12);
            this.panel2.Controls.Add(this.label16);
            this.panel2.Controls.Add(this.cbConvenio);
            this.panel2.Controls.Add(this.label15);
            this.panel2.Controls.Add(this.label13);
            this.panel2.Controls.Add(this.txtCrm);
            this.panel2.Controls.Add(this.btnProcuraMedico);
            this.panel2.Controls.Add(this.label14);
            this.panel2.Controls.Add(this.txtNomeMedico);
            this.panel2.Controls.Add(this.txtIdMedico);
            this.panel2.Location = new System.Drawing.Point(12, 202);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(498, 263);
            this.panel2.TabIndex = 59;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(9, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 17);
            this.label2.TabIndex = 59;
            this.label2.Text = "Exame";
            // 
            // frmExamesCrud
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(525, 486);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmExamesCrud";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro de Exames";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmExamesCrud_FormClosed);
            this.Load += new System.EventHandler(this.frmExamesCrud_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.DateTimePicker data;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox cbConvenio;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button btnProcuraMedico;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.TextBox txtNomeMedico;
        public System.Windows.Forms.TextBox txtIdMedico;
        public System.Windows.Forms.TextBox txtCrm;
        public System.Windows.Forms.TextBox txtNumero;
        public System.Windows.Forms.ComboBox cbTipo;
        public System.Windows.Forms.TextBox txtTipo;
        public System.Windows.Forms.MaskedTextBox txtTelefonePaciente;
        public System.Windows.Forms.TextBox txtIdadePaciente;
        public System.Windows.Forms.Label lblIdPaciente;
        public System.Windows.Forms.TextBox txtNomePaciente;
    }
}