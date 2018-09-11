﻿namespace Goniotech
{
    partial class frm_principal
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
            this.menu = new System.Windows.Forms.MenuStrip();
            this.cadastrosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pacienteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fisioterapeutaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.localizarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.relatoriosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.equipeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.professorWalterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.professorWalterToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.professorRodrigoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.professoraLucianaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.coOrientedorRodrigoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.alunoJeffersonRicardoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btn_cad_paciente = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btn_cad_fisio = new System.Windows.Forms.Button();
            this.menu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // menu
            // 
            this.menu.BackColor = System.Drawing.Color.ForestGreen;
            this.menu.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cadastrosToolStripMenuItem,
            this.localizarToolStripMenuItem,
            this.relatoriosToolStripMenuItem,
            this.equipeToolStripMenuItem});
            this.menu.Location = new System.Drawing.Point(0, 0);
            this.menu.Name = "menu";
            this.menu.Size = new System.Drawing.Size(784, 24);
            this.menu.TabIndex = 1;
            this.menu.Text = "menuStrip1";
            // 
            // cadastrosToolStripMenuItem
            // 
            this.cadastrosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pacienteToolStripMenuItem,
            this.fisioterapeutaToolStripMenuItem});
            this.cadastrosToolStripMenuItem.Name = "cadastrosToolStripMenuItem";
            this.cadastrosToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
            this.cadastrosToolStripMenuItem.Text = "Cadastros";
            // 
            // pacienteToolStripMenuItem
            // 
            this.pacienteToolStripMenuItem.Name = "pacienteToolStripMenuItem";
            this.pacienteToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.pacienteToolStripMenuItem.Text = "Paciente";
            // 
            // fisioterapeutaToolStripMenuItem
            // 
            this.fisioterapeutaToolStripMenuItem.Name = "fisioterapeutaToolStripMenuItem";
            this.fisioterapeutaToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.fisioterapeutaToolStripMenuItem.Text = "Fisioterapeuta";
            // 
            // localizarToolStripMenuItem
            // 
            this.localizarToolStripMenuItem.Name = "localizarToolStripMenuItem";
            this.localizarToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
            this.localizarToolStripMenuItem.Text = "Consultas";
            // 
            // relatoriosToolStripMenuItem
            // 
            this.relatoriosToolStripMenuItem.Name = "relatoriosToolStripMenuItem";
            this.relatoriosToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
            this.relatoriosToolStripMenuItem.Text = "Relatórios";
            // 
            // equipeToolStripMenuItem
            // 
            this.equipeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.professorWalterToolStripMenuItem,
            this.coOrientedorRodrigoToolStripMenuItem});
            this.equipeToolStripMenuItem.Name = "equipeToolStripMenuItem";
            this.equipeToolStripMenuItem.Size = new System.Drawing.Size(108, 20);
            this.equipeToolStripMenuItem.Text = "Desenvolvedores";
            this.equipeToolStripMenuItem.Click += new System.EventHandler(this.equipeToolStripMenuItem_Click);
            // 
            // professorWalterToolStripMenuItem
            // 
            this.professorWalterToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.professorWalterToolStripMenuItem1,
            this.professorRodrigoToolStripMenuItem,
            this.professoraLucianaToolStripMenuItem});
            this.professorWalterToolStripMenuItem.Name = "professorWalterToolStripMenuItem";
            this.professorWalterToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.professorWalterToolStripMenuItem.Text = "Orientadores";
            // 
            // professorWalterToolStripMenuItem1
            // 
            this.professorWalterToolStripMenuItem1.Name = "professorWalterToolStripMenuItem1";
            this.professorWalterToolStripMenuItem1.Size = new System.Drawing.Size(213, 22);
            this.professorWalterToolStripMenuItem1.Text = "Professor Walter Travassos";
            // 
            // professorRodrigoToolStripMenuItem
            // 
            this.professorRodrigoToolStripMenuItem.Name = "professorRodrigoToolStripMenuItem";
            this.professorRodrigoToolStripMenuItem.Size = new System.Drawing.Size(213, 22);
            this.professorRodrigoToolStripMenuItem.Text = "Professor Rodrigo Farias";
            // 
            // professoraLucianaToolStripMenuItem
            // 
            this.professoraLucianaToolStripMenuItem.Name = "professoraLucianaToolStripMenuItem";
            this.professoraLucianaToolStripMenuItem.Size = new System.Drawing.Size(213, 22);
            this.professoraLucianaToolStripMenuItem.Text = "Professora Luciana Soares";
            // 
            // coOrientedorRodrigoToolStripMenuItem
            // 
            this.coOrientedorRodrigoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.alunoJeffersonRicardoToolStripMenuItem});
            this.coOrientedorRodrigoToolStripMenuItem.Name = "coOrientedorRodrigoToolStripMenuItem";
            this.coOrientedorRodrigoToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.coOrientedorRodrigoToolStripMenuItem.Text = "Desenvolvedor";
            // 
            // alunoJeffersonRicardoToolStripMenuItem
            // 
            this.alunoJeffersonRicardoToolStripMenuItem.Name = "alunoJeffersonRicardoToolStripMenuItem";
            this.alunoJeffersonRicardoToolStripMenuItem.Size = new System.Drawing.Size(199, 22);
            this.alunoJeffersonRicardoToolStripMenuItem.Text = "Aluno Jefferson Ricardo";
            // 
            // btn_cad_paciente
            // 
            this.btn_cad_paciente.BackColor = System.Drawing.Color.Transparent;
            this.btn_cad_paciente.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_cad_paciente.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_cad_paciente.FlatAppearance.BorderSize = 0;
            this.btn_cad_paciente.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btn_cad_paciente.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btn_cad_paciente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_cad_paciente.ForeColor = System.Drawing.Color.Transparent;
            this.btn_cad_paciente.Image = global::Goniotech.Properties.Resources.btn_cadastrarPaciente2;
            this.btn_cad_paciente.Location = new System.Drawing.Point(368, 48);
            this.btn_cad_paciente.Name = "btn_cad_paciente";
            this.btn_cad_paciente.Size = new System.Drawing.Size(201, 87);
            this.btn_cad_paciente.TabIndex = 2;
            this.btn_cad_paciente.UseVisualStyleBackColor = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::Goniotech.Properties.Resources.Logo3;
            this.pictureBox1.Location = new System.Drawing.Point(6, 48);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(356, 351);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // btn_cad_fisio
            // 
            this.btn_cad_fisio.BackColor = System.Drawing.Color.Transparent;
            this.btn_cad_fisio.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_cad_fisio.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_cad_fisio.FlatAppearance.BorderSize = 0;
            this.btn_cad_fisio.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btn_cad_fisio.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btn_cad_fisio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_cad_fisio.ForeColor = System.Drawing.Color.Transparent;
            this.btn_cad_fisio.Image = global::Goniotech.Properties.Resources.btn_cadastrarFisio2;
            this.btn_cad_fisio.Location = new System.Drawing.Point(571, 48);
            this.btn_cad_fisio.Name = "btn_cad_fisio";
            this.btn_cad_fisio.Size = new System.Drawing.Size(201, 87);
            this.btn_cad_fisio.TabIndex = 3;
            this.btn_cad_fisio.UseVisualStyleBackColor = false;
            // 
            // frm_principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.ForestGreen;
            this.BackgroundImage = global::Goniotech.Properties.Resources.bg;
            this.ClientSize = new System.Drawing.Size(784, 411);
            this.Controls.Add(this.btn_cad_fisio);
            this.Controls.Add(this.btn_cad_paciente);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.menu);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainMenuStrip = this.menu;
            this.Name = "frm_principal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Goniotech";
            this.Load += new System.EventHandler(this.frm_principal_Load);
            this.menu.ResumeLayout(false);
            this.menu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.MenuStrip menu;
        private System.Windows.Forms.ToolStripMenuItem cadastrosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pacienteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fisioterapeutaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem localizarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem relatoriosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem equipeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem professorWalterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem professorWalterToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem professorRodrigoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem professoraLucianaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem coOrientedorRodrigoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem alunoJeffersonRicardoToolStripMenuItem;
        private System.Windows.Forms.Button btn_cad_paciente;
        private System.Windows.Forms.Button btn_cad_fisio;
    }
}

