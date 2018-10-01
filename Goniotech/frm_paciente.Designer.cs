namespace Goniotech
{
    partial class frm_paciente
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
            System.Windows.Forms.Label label3;
            System.Windows.Forms.Label label5;
            this.label1 = new System.Windows.Forms.Label();
            this.txt_nomePaciente = new System.Windows.Forms.TextBox();
            this.txt_obs = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_dtNasc = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cb_fisio = new System.Windows.Forms.ComboBox();
            this.cb_sexo = new System.Windows.Forms.ComboBox();
            this.cb_especialidade = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btn_cancelar = new System.Windows.Forms.Button();
            this.btn_deletar = new System.Windows.Forms.Button();
            this.btn_editar = new System.Windows.Forms.Button();
            this.btn_novo = new System.Windows.Forms.Button();
            this.list_avaliacoes = new System.Windows.Forms.TextBox();
            this.pacienteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pacienteBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.nomePacienteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtNascDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sexoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            label3 = new System.Windows.Forms.Label();
            label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pacienteBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pacienteBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            label3.Location = new System.Drawing.Point(9, 43);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(104, 13);
            label3.TabIndex = 4;
            label3.Text = "Data de Nascimento";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            label5.Location = new System.Drawing.Point(238, 43);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(31, 13);
            label5.TabIndex = 8;
            label5.Text = "Sexo";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome";
            // 
            // txt_nomePaciente
            // 
            this.txt_nomePaciente.Location = new System.Drawing.Point(50, 14);
            this.txt_nomePaciente.Name = "txt_nomePaciente";
            this.txt_nomePaciente.Size = new System.Drawing.Size(376, 20);
            this.txt_nomePaciente.TabIndex = 1;
            // 
            // txt_obs
            // 
            this.txt_obs.Location = new System.Drawing.Point(12, 111);
            this.txt_obs.Multiline = true;
            this.txt_obs.Name = "txt_obs";
            this.txt_obs.Size = new System.Drawing.Size(727, 122);
            this.txt_obs.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Avaliações";
            // 
            // txt_dtNasc
            // 
            this.txt_dtNasc.Location = new System.Drawing.Point(119, 40);
            this.txt_dtNasc.Name = "txt_dtNasc";
            this.txt_dtNasc.Size = new System.Drawing.Size(110, 20);
            this.txt_dtNasc.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(444, 17);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Fisioterapeuta";
            // 
            // cb_fisio
            // 
            this.cb_fisio.FormattingEnabled = true;
            this.cb_fisio.Location = new System.Drawing.Point(523, 14);
            this.cb_fisio.Name = "cb_fisio";
            this.cb_fisio.Size = new System.Drawing.Size(216, 21);
            this.cb_fisio.TabIndex = 7;
            // 
            // cb_sexo
            // 
            this.cb_sexo.FormattingEnabled = true;
            this.cb_sexo.Location = new System.Drawing.Point(275, 40);
            this.cb_sexo.Name = "cb_sexo";
            this.cb_sexo.Size = new System.Drawing.Size(151, 21);
            this.cb_sexo.TabIndex = 9;
            // 
            // cb_especialidade
            // 
            this.cb_especialidade.FormattingEnabled = true;
            this.cb_especialidade.Location = new System.Drawing.Point(523, 40);
            this.cb_especialidade.Name = "cb_especialidade";
            this.cb_especialidade.Size = new System.Drawing.Size(216, 21);
            this.cb_especialidade.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(444, 43);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(73, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Especialidade";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(9, 93);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(70, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "Observações";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nomePacienteDataGridViewTextBoxColumn,
            this.dtNascDataGridViewTextBoxColumn,
            this.sexoDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.pacienteBindingSource1;
            this.dataGridView1.Location = new System.Drawing.Point(12, 248);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(727, 232);
            this.dataGridView1.TabIndex = 17;
            // 
            // btn_cancelar
            // 
            this.btn_cancelar.BackColor = System.Drawing.Color.Transparent;
            this.btn_cancelar.FlatAppearance.BorderSize = 0;
            this.btn_cancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_cancelar.Image = global::Goniotech.Properties.Resources.cancel;
            this.btn_cancelar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_cancelar.Location = new System.Drawing.Point(673, 486);
            this.btn_cancelar.Name = "btn_cancelar";
            this.btn_cancelar.Size = new System.Drawing.Size(65, 55);
            this.btn_cancelar.TabIndex = 16;
            this.btn_cancelar.Text = "Cancelar";
            this.btn_cancelar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_cancelar.UseVisualStyleBackColor = false;
            // 
            // btn_deletar
            // 
            this.btn_deletar.BackColor = System.Drawing.Color.Transparent;
            this.btn_deletar.FlatAppearance.BorderSize = 0;
            this.btn_deletar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_deletar.Image = global::Goniotech.Properties.Resources.delete;
            this.btn_deletar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_deletar.Location = new System.Drawing.Point(603, 486);
            this.btn_deletar.Name = "btn_deletar";
            this.btn_deletar.Size = new System.Drawing.Size(55, 55);
            this.btn_deletar.TabIndex = 15;
            this.btn_deletar.Text = "Deletar";
            this.btn_deletar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_deletar.UseVisualStyleBackColor = false;
            // 
            // btn_editar
            // 
            this.btn_editar.BackColor = System.Drawing.Color.Transparent;
            this.btn_editar.FlatAppearance.BorderSize = 0;
            this.btn_editar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_editar.Image = global::Goniotech.Properties.Resources.edit;
            this.btn_editar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_editar.Location = new System.Drawing.Point(533, 486);
            this.btn_editar.Name = "btn_editar";
            this.btn_editar.Size = new System.Drawing.Size(55, 55);
            this.btn_editar.TabIndex = 14;
            this.btn_editar.Text = "Editar";
            this.btn_editar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_editar.UseVisualStyleBackColor = false;
            // 
            // btn_novo
            // 
            this.btn_novo.BackColor = System.Drawing.Color.Transparent;
            this.btn_novo.FlatAppearance.BorderSize = 0;
            this.btn_novo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_novo.Image = global::Goniotech.Properties.Resources.save;
            this.btn_novo.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_novo.Location = new System.Drawing.Point(463, 486);
            this.btn_novo.Name = "btn_novo";
            this.btn_novo.Size = new System.Drawing.Size(55, 55);
            this.btn_novo.TabIndex = 13;
            this.btn_novo.Text = "Novo";
            this.btn_novo.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_novo.UseVisualStyleBackColor = false;
            this.btn_novo.Click += new System.EventHandler(this.button1_Click);
            // 
            // list_avaliacoes
            // 
            this.list_avaliacoes.Location = new System.Drawing.Point(74, 67);
            this.list_avaliacoes.Name = "list_avaliacoes";
            this.list_avaliacoes.Size = new System.Drawing.Size(665, 20);
            this.list_avaliacoes.TabIndex = 18;
            // 
            // pacienteBindingSource
            // 
            this.pacienteBindingSource.DataSource = typeof(sistema.DAL.Paciente);
            // 
            // pacienteBindingSource1
            // 
            this.pacienteBindingSource1.DataSource = typeof(sistema.DAL.Paciente);
            // 
            // nomePacienteDataGridViewTextBoxColumn
            // 
            this.nomePacienteDataGridViewTextBoxColumn.DataPropertyName = "nomePaciente";
            this.nomePacienteDataGridViewTextBoxColumn.HeaderText = "Paciente";
            this.nomePacienteDataGridViewTextBoxColumn.Name = "nomePacienteDataGridViewTextBoxColumn";
            this.nomePacienteDataGridViewTextBoxColumn.ReadOnly = true;
            this.nomePacienteDataGridViewTextBoxColumn.Width = 385;
            // 
            // dtNascDataGridViewTextBoxColumn
            // 
            this.dtNascDataGridViewTextBoxColumn.DataPropertyName = "dtNasc";
            this.dtNascDataGridViewTextBoxColumn.HeaderText = "Data de Nascimento";
            this.dtNascDataGridViewTextBoxColumn.Name = "dtNascDataGridViewTextBoxColumn";
            this.dtNascDataGridViewTextBoxColumn.ReadOnly = true;
            this.dtNascDataGridViewTextBoxColumn.Width = 180;
            // 
            // sexoDataGridViewTextBoxColumn
            // 
            this.sexoDataGridViewTextBoxColumn.DataPropertyName = "Sexo";
            this.sexoDataGridViewTextBoxColumn.HeaderText = "Sexo";
            this.sexoDataGridViewTextBoxColumn.Name = "sexoDataGridViewTextBoxColumn";
            this.sexoDataGridViewTextBoxColumn.ReadOnly = true;
            this.sexoDataGridViewTextBoxColumn.Width = 120;
            // 
            // frm_paciente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(753, 553);
            this.Controls.Add(this.list_avaliacoes);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btn_cancelar);
            this.Controls.Add(this.btn_deletar);
            this.Controls.Add(this.btn_editar);
            this.Controls.Add(this.btn_novo);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.cb_especialidade);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cb_sexo);
            this.Controls.Add(label5);
            this.Controls.Add(this.cb_fisio);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txt_dtNasc);
            this.Controls.Add(label3);
            this.Controls.Add(this.txt_obs);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_nomePaciente);
            this.Controls.Add(this.label1);
            this.Name = "frm_paciente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastrar Paciente";
            this.Load += new System.EventHandler(this.frm_paciente_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pacienteBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pacienteBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_nomePaciente;
        private System.Windows.Forms.TextBox txt_obs;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_dtNasc;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cb_fisio;
        private System.Windows.Forms.ComboBox cb_sexo;
        private System.Windows.Forms.ComboBox cb_especialidade;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btn_novo;
        private System.Windows.Forms.Button btn_editar;
        private System.Windows.Forms.Button btn_deletar;
        private System.Windows.Forms.Button btn_cancelar;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox list_avaliacoes;
        private System.Windows.Forms.BindingSource pacienteBindingSource1;
        private System.Windows.Forms.BindingSource pacienteBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomePacienteDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dtNascDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sexoDataGridViewTextBoxColumn;
    }
}