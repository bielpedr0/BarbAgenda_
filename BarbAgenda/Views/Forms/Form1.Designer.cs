﻿namespace BarbAgenda.Views
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.menu = new System.Windows.Forms.FlowLayoutPanel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.btnMenu = new System.Windows.Forms.PictureBox();
            this.panelhome = new System.Windows.Forms.Panel();
            this.btnHome = new System.Windows.Forms.Button();
            this.panelDashboard = new System.Windows.Forms.Panel();
            this.btnDash = new System.Windows.Forms.Button();
            this.panelCalendar = new System.Windows.Forms.Panel();
            this.btnCalendario = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnCadastro = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnAgendamento = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.btnSair = new System.Windows.Forms.Button();
            this.sideBarTransition = new System.Windows.Forms.Timer(this.components);
            this.menu.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnMenu)).BeginInit();
            this.panelhome.SuspendLayout();
            this.panelDashboard.SuspendLayout();
            this.panelCalendar.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // menu
            // 
            this.menu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(40)))), ((int)(((byte)(45)))));
            this.menu.Controls.Add(this.panel2);
            this.menu.Controls.Add(this.panelhome);
            this.menu.Controls.Add(this.panelDashboard);
            this.menu.Controls.Add(this.panelCalendar);
            this.menu.Controls.Add(this.panel1);
            this.menu.Controls.Add(this.panel3);
            this.menu.Controls.Add(this.panel4);
            this.menu.Controls.Add(this.panel5);
            this.menu.Dock = System.Windows.Forms.DockStyle.Left;
            this.menu.Location = new System.Drawing.Point(0, 0);
            this.menu.Margin = new System.Windows.Forms.Padding(0);
            this.menu.Name = "menu";
            this.menu.Size = new System.Drawing.Size(210, 572);
            this.menu.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.btnMenu);
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(233, 96);
            this.panel2.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(89, 40);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 21);
            this.label1.TabIndex = 1;
            this.label1.Text = "Menu";
            // 
            // btnMenu
            // 
            this.btnMenu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMenu.Location = new System.Drawing.Point(26, 31);
            this.btnMenu.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnMenu.Name = "btnMenu";
            this.btnMenu.Size = new System.Drawing.Size(30, 33);
            this.btnMenu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnMenu.TabIndex = 0;
            this.btnMenu.TabStop = false;
            this.btnMenu.Click += new System.EventHandler(this.btnMenu_Click);
            // 
            // panelhome
            // 
            this.panelhome.Controls.Add(this.btnHome);
            this.panelhome.Location = new System.Drawing.Point(0, 96);
            this.panelhome.Margin = new System.Windows.Forms.Padding(0);
            this.panelhome.Name = "panelhome";
            this.panelhome.Size = new System.Drawing.Size(233, 67);
            this.panelhome.TabIndex = 0;
            // 
            // btnHome
            // 
            this.btnHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHome.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnHome.ForeColor = System.Drawing.Color.White;
            this.btnHome.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHome.Location = new System.Drawing.Point(-15, -10);
            this.btnHome.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnHome.Name = "btnHome";
            this.btnHome.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btnHome.Size = new System.Drawing.Size(248, 91);
            this.btnHome.TabIndex = 1;
            this.btnHome.Text = "             Home";
            this.btnHome.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHome.UseVisualStyleBackColor = true;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // panelDashboard
            // 
            this.panelDashboard.Controls.Add(this.btnDash);
            this.panelDashboard.Location = new System.Drawing.Point(0, 163);
            this.panelDashboard.Margin = new System.Windows.Forms.Padding(0);
            this.panelDashboard.Name = "panelDashboard";
            this.panelDashboard.Size = new System.Drawing.Size(233, 59);
            this.panelDashboard.TabIndex = 2;
            // 
            // btnDash
            // 
            this.btnDash.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDash.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnDash.ForeColor = System.Drawing.Color.White;
            this.btnDash.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDash.Location = new System.Drawing.Point(-15, -13);
            this.btnDash.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnDash.Name = "btnDash";
            this.btnDash.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btnDash.Size = new System.Drawing.Size(248, 84);
            this.btnDash.TabIndex = 3;
            this.btnDash.Text = "             Dashboard";
            this.btnDash.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDash.UseVisualStyleBackColor = true;
            this.btnDash.Click += new System.EventHandler(this.button2_Click);
            // 
            // panelCalendar
            // 
            this.panelCalendar.Controls.Add(this.btnCalendario);
            this.panelCalendar.Location = new System.Drawing.Point(0, 222);
            this.panelCalendar.Margin = new System.Windows.Forms.Padding(0);
            this.panelCalendar.Name = "panelCalendar";
            this.panelCalendar.Size = new System.Drawing.Size(233, 62);
            this.panelCalendar.TabIndex = 3;
            // 
            // btnCalendario
            // 
            this.btnCalendario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCalendario.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnCalendario.ForeColor = System.Drawing.Color.White;
            this.btnCalendario.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCalendario.Location = new System.Drawing.Point(-15, -12);
            this.btnCalendario.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnCalendario.Name = "btnCalendario";
            this.btnCalendario.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btnCalendario.Size = new System.Drawing.Size(248, 91);
            this.btnCalendario.TabIndex = 4;
            this.btnCalendario.Text = "             Calendario";
            this.btnCalendario.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCalendario.UseVisualStyleBackColor = true;
            this.btnCalendario.Click += new System.EventHandler(this.btnCalendario_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnCadastro);
            this.panel1.Location = new System.Drawing.Point(0, 284);
            this.panel1.Margin = new System.Windows.Forms.Padding(0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(233, 67);
            this.panel1.TabIndex = 4;
            // 
            // btnCadastro
            // 
            this.btnCadastro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCadastro.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnCadastro.ForeColor = System.Drawing.Color.White;
            this.btnCadastro.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCadastro.Location = new System.Drawing.Point(-15, -10);
            this.btnCadastro.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnCadastro.Name = "btnCadastro";
            this.btnCadastro.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btnCadastro.Size = new System.Drawing.Size(248, 91);
            this.btnCadastro.TabIndex = 5;
            this.btnCadastro.Text = "             Cadastro";
            this.btnCadastro.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCadastro.UseVisualStyleBackColor = true;
            this.btnCadastro.Click += new System.EventHandler(this.btnCadastro_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btnAgendamento);
            this.panel3.Location = new System.Drawing.Point(0, 351);
            this.panel3.Margin = new System.Windows.Forms.Padding(0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(233, 67);
            this.panel3.TabIndex = 5;
            // 
            // btnAgendamento
            // 
            this.btnAgendamento.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgendamento.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnAgendamento.ForeColor = System.Drawing.Color.White;
            this.btnAgendamento.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAgendamento.Location = new System.Drawing.Point(-15, -10);
            this.btnAgendamento.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnAgendamento.Name = "btnAgendamento";
            this.btnAgendamento.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btnAgendamento.Size = new System.Drawing.Size(248, 91);
            this.btnAgendamento.TabIndex = 5;
            this.btnAgendamento.Text = "            Agendamento";
            this.btnAgendamento.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAgendamento.UseVisualStyleBackColor = true;
            this.btnAgendamento.Click += new System.EventHandler(this.btnAgendamento_Click);
            // 
            // panel4
            // 
            this.panel4.Location = new System.Drawing.Point(0, 418);
            this.panel4.Margin = new System.Windows.Forms.Padding(0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(233, 78);
            this.panel4.TabIndex = 6;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.btnSair);
            this.panel5.Location = new System.Drawing.Point(0, 496);
            this.panel5.Margin = new System.Windows.Forms.Padding(0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(233, 72);
            this.panel5.TabIndex = 7;
            // 
            // btnSair
            // 
            this.btnSair.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSair.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnSair.ForeColor = System.Drawing.Color.White;
            this.btnSair.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSair.Location = new System.Drawing.Point(-15, -6);
            this.btnSair.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnSair.Name = "btnSair";
            this.btnSair.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btnSair.Size = new System.Drawing.Size(248, 91);
            this.btnSair.TabIndex = 5;
            this.btnSair.Text = "             Sair";
            this.btnSair.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // sideBarTransition
            // 
            this.sideBarTransition.Interval = 10;
            this.sideBarTransition.Tick += new System.EventHandler(this.menuTransition_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1014, 572);
            this.Controls.Add(this.menu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.IsMdiContainer = true;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "Form1";
            this.Text = " ";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menu.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnMenu)).EndInit();
            this.panelhome.ResumeLayout(false);
            this.panelDashboard.ResumeLayout(false);
            this.panelCalendar.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel menu;
        private System.Windows.Forms.Panel panelhome;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.Panel panelDashboard;
        private System.Windows.Forms.Button btnDash;
        private System.Windows.Forms.Panel panelCalendar;
        private System.Windows.Forms.Button btnCalendario;
        private System.Windows.Forms.PictureBox btnMenu;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer sideBarTransition;
        private System.Windows.Forms.Button btnCadastro;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnAgendamento;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Button btnSair;
    }
}

