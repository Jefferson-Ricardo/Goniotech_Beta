namespace Goniotech
{
    partial class frm_consulta
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
            System.Windows.Forms.Label label3;
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btn_cancelar = new System.Windows.Forms.Button();
            this.btn_deletar = new System.Windows.Forms.Button();
            this.btn_editar = new System.Windows.Forms.Button();
            this.btn_novo = new System.Windows.Forms.Button();
            this.cb_especialidade = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_dtNasc = new System.Windows.Forms.TextBox();
            this.txt_nomePaciente = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 44);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(727, 260);
            this.dataGridView1.TabIndex = 47;
            // 
            // btn_cancelar
            // 
            this.btn_cancelar.BackColor = System.Drawing.Color.Transparent;
            this.btn_cancelar.FlatAppearance.BorderSize = 0;
            this.btn_cancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_cancelar.Image = global::Goniotech.Properties.Resources.cancel;
            this.btn_cancelar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_cancelar.Location = new System.Drawing.Point(673, 310);
            this.btn_cancelar.Name = "btn_cancelar";
            this.btn_cancelar.Size = new System.Drawing.Size(65, 55);
            this.btn_cancelar.TabIndex = 46;
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
            this.btn_deletar.Location = new System.Drawing.Point(603, 310);
            this.btn_deletar.Name = "btn_deletar";
            this.btn_deletar.Size = new System.Drawing.Size(55, 55);
            this.btn_deletar.TabIndex = 45;
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
            this.btn_editar.Location = new System.Drawing.Point(533, 310);
            this.btn_editar.Name = "btn_editar";
            this.btn_editar.Size = new System.Drawing.Size(55, 55);
            this.btn_editar.TabIndex = 44;
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
            this.btn_novo.Location = new System.Drawing.Point(463, 310);
            this.btn_novo.Name = "btn_novo";
            this.btn_novo.Size = new System.Drawing.Size(55, 55);
            this.btn_novo.TabIndex = 43;
            this.btn_novo.Text = "Novo";
            this.btn_novo.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_novo.UseVisualStyleBackColor = false;
            // 
            // cb_especialidade
            // 
            this.cb_especialidade.FormattingEnabled = true;
            this.cb_especialidade.Location = new System.Drawing.Point(603, 14);
            this.cb_especialidade.Name = "cb_especialidade";
            this.cb_especialidade.Size = new System.Drawing.Size(136, 21);
            this.cb_especialidade.TabIndex = 42;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(529, 17);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(73, 13);
            this.label6.TabIndex = 41;
            this.label6.Text = "Especialidade";
            // 
            // txt_dtNasc
            // 
            this.txt_dtNasc.Location = new System.Drawing.Point(416, 14);
            this.txt_dtNasc.Name = "txt_dtNasc";
            this.txt_dtNasc.Size = new System.Drawing.Size(107, 20);
            this.txt_dtNasc.TabIndex = 40;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            label3.Location = new System.Drawing.Point(317, 17);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(94, 13);
            label3.TabIndex = 39;
            label3.Text = "Registro/Matricula";
            // 
            // txt_nomePaciente
            // 
            this.txt_nomePaciente.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txt_nomePaciente.Location = new System.Drawing.Point(50, 14);
            this.txt_nomePaciente.Name = "txt_nomePaciente";
            this.txt_nomePaciente.Size = new System.Drawing.Size(261, 20);
            this.txt_nomePaciente.TabIndex = 38;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 37;
            this.label1.Text = "Nome";
            // 
            // frm_consulta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btn_cancelar);
            this.Controls.Add(this.btn_deletar);
            this.Controls.Add(this.btn_editar);
            this.Controls.Add(this.btn_novo);
            this.Controls.Add(this.cb_especialidade);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txt_dtNasc);
            this.Controls.Add(label3);
            this.Controls.Add(this.txt_nomePaciente);
            this.Controls.Add(this.label1);
            this.Name = "frm_consulta";
            this.Text = "frm_consulta";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btn_cancelar;
        private System.Windows.Forms.Button btn_deletar;
        private System.Windows.Forms.Button btn_editar;
        private System.Windows.Forms.Button btn_novo;
        private System.Windows.Forms.ComboBox cb_especialidade;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_dtNasc;
        private System.Windows.Forms.TextBox txt_nomePaciente;
        private System.Windows.Forms.Label label1;
    }
}