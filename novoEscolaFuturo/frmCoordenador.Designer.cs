namespace novoEscolaFuturo
{
    partial class frmCoordenador
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCoordenador));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btEmitirRelatorio = new System.Windows.Forms.Button();
            this.btnCadastrarCurso = new System.Windows.Forms.Button();
            this.pnlIndicador = new System.Windows.Forms.Panel();
            this.btnCadFuncionario = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnMinimizar = new System.Windows.Forms.Button();
            this.btnFechar = new System.Windows.Forms.Button();
            this.userControlCadFuncionario1 = new novoEscolaFuturo.UserControlCadFuncionario();
            this.userControlCadCurso1 = new novoEscolaFuturo.UserControlCadCurso();
            this.userControlFreqProf1 = new novoEscolaFuturo.UserControlFreqProf();
            this.userControlBemVindo1 = new novoEscolaFuturo.UserControlBemVindo();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btEmitirRelatorio);
            this.panel1.Controls.Add(this.btnCadastrarCurso);
            this.panel1.Controls.Add(this.pnlIndicador);
            this.panel1.Controls.Add(this.btnCadFuncionario);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(1, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(178, 480);
            this.panel1.TabIndex = 1;
            // 
            // btEmitirRelatorio
            // 
            this.btEmitirRelatorio.FlatAppearance.BorderSize = 0;
            this.btEmitirRelatorio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btEmitirRelatorio.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btEmitirRelatorio.ForeColor = System.Drawing.Color.White;
            this.btEmitirRelatorio.Image = ((System.Drawing.Image)(resources.GetObject("btEmitirRelatorio.Image")));
            this.btEmitirRelatorio.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btEmitirRelatorio.Location = new System.Drawing.Point(2, 383);
            this.btEmitirRelatorio.Name = "btEmitirRelatorio";
            this.btEmitirRelatorio.Size = new System.Drawing.Size(155, 97);
            this.btEmitirRelatorio.TabIndex = 20;
            this.btEmitirRelatorio.Text = "Emitir relatório de frequência do professor";
            this.btEmitirRelatorio.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btEmitirRelatorio.UseVisualStyleBackColor = true;
            this.btEmitirRelatorio.Click += new System.EventHandler(this.btEmitirRelatorio_Click);
            // 
            // btnCadastrarCurso
            // 
            this.btnCadastrarCurso.FlatAppearance.BorderSize = 0;
            this.btnCadastrarCurso.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCadastrarCurso.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCadastrarCurso.ForeColor = System.Drawing.Color.White;
            this.btnCadastrarCurso.Image = ((System.Drawing.Image)(resources.GetObject("btnCadastrarCurso.Image")));
            this.btnCadastrarCurso.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnCadastrarCurso.Location = new System.Drawing.Point(2, 259);
            this.btnCadastrarCurso.Name = "btnCadastrarCurso";
            this.btnCadastrarCurso.Size = new System.Drawing.Size(155, 97);
            this.btnCadastrarCurso.TabIndex = 19;
            this.btnCadastrarCurso.Text = "Cadastrar curso";
            this.btnCadastrarCurso.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnCadastrarCurso.UseVisualStyleBackColor = true;
            this.btnCadastrarCurso.Click += new System.EventHandler(this.btnCadastrarCurso_Click);
            // 
            // pnlIndicador
            // 
            this.pnlIndicador.BackColor = System.Drawing.Color.White;
            this.pnlIndicador.Location = new System.Drawing.Point(157, 128);
            this.pnlIndicador.Name = "pnlIndicador";
            this.pnlIndicador.Size = new System.Drawing.Size(20, 97);
            this.pnlIndicador.TabIndex = 18;
            // 
            // btnCadFuncionario
            // 
            this.btnCadFuncionario.FlatAppearance.BorderSize = 0;
            this.btnCadFuncionario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCadFuncionario.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCadFuncionario.ForeColor = System.Drawing.Color.White;
            this.btnCadFuncionario.Image = ((System.Drawing.Image)(resources.GetObject("btnCadFuncionario.Image")));
            this.btnCadFuncionario.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnCadFuncionario.Location = new System.Drawing.Point(2, 128);
            this.btnCadFuncionario.Name = "btnCadFuncionario";
            this.btnCadFuncionario.Size = new System.Drawing.Size(155, 97);
            this.btnCadFuncionario.TabIndex = 17;
            this.btnCadFuncionario.Text = "Cadastrar Funcionário";
            this.btnCadFuncionario.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnCadFuncionario.UseVisualStyleBackColor = true;
            this.btnCadFuncionario.Click += new System.EventHandler(this.btnCadFuncionario_Click);
            // 
            // panel2
            // 
            this.panel2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel2.BackgroundImage")));
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel2.Location = new System.Drawing.Point(19, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(146, 109);
            this.panel2.TabIndex = 16;
            // 
            // btnMinimizar
            // 
            this.btnMinimizar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnMinimizar.BackgroundImage")));
            this.btnMinimizar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnMinimizar.FlatAppearance.BorderSize = 0;
            this.btnMinimizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinimizar.Location = new System.Drawing.Point(798, 12);
            this.btnMinimizar.Name = "btnMinimizar";
            this.btnMinimizar.Size = new System.Drawing.Size(38, 33);
            this.btnMinimizar.TabIndex = 8;
            this.btnMinimizar.UseVisualStyleBackColor = true;
            this.btnMinimizar.Click += new System.EventHandler(this.btnMinimizar_Click);
            // 
            // btnFechar
            // 
            this.btnFechar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnFechar.BackgroundImage")));
            this.btnFechar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnFechar.FlatAppearance.BorderSize = 0;
            this.btnFechar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFechar.Location = new System.Drawing.Point(842, 12);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(38, 33);
            this.btnFechar.TabIndex = 7;
            this.btnFechar.UseVisualStyleBackColor = true;
            this.btnFechar.Click += new System.EventHandler(this.btnFechar_Click);
            // 
            // userControlCadFuncionario1
            // 
            this.userControlCadFuncionario1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(66)))), ((int)(((byte)(115)))));
            this.userControlCadFuncionario1.Location = new System.Drawing.Point(180, 51);
            this.userControlCadFuncionario1.Name = "userControlCadFuncionario1";
            this.userControlCadFuncionario1.Size = new System.Drawing.Size(700, 429);
            this.userControlCadFuncionario1.TabIndex = 9;
            // 
            // userControlCadCurso1
            // 
            this.userControlCadCurso1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(66)))), ((int)(((byte)(115)))));
            this.userControlCadCurso1.Location = new System.Drawing.Point(180, 41);
            this.userControlCadCurso1.Name = "userControlCadCurso1";
            this.userControlCadCurso1.Size = new System.Drawing.Size(700, 429);
            this.userControlCadCurso1.TabIndex = 10;
            this.userControlCadCurso1.Load += new System.EventHandler(this.userControlCadCurso1_Load);
            // 
            // userControlFreqProf1
            // 
            this.userControlFreqProf1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(66)))), ((int)(((byte)(115)))));
            this.userControlFreqProf1.Location = new System.Drawing.Point(180, 51);
            this.userControlFreqProf1.Name = "userControlFreqProf1";
            this.userControlFreqProf1.Size = new System.Drawing.Size(700, 429);
            this.userControlFreqProf1.TabIndex = 11;
            // 
            // userControlBemVindo1
            // 
            this.userControlBemVindo1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(66)))), ((int)(((byte)(115)))));
            this.userControlBemVindo1.Location = new System.Drawing.Point(180, 52);
            this.userControlBemVindo1.Name = "userControlBemVindo1";
            this.userControlBemVindo1.Size = new System.Drawing.Size(700, 429);
            this.userControlBemVindo1.TabIndex = 12;
            // 
            // frmCoordenador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(66)))), ((int)(((byte)(115)))));
            this.ClientSize = new System.Drawing.Size(882, 482);
            this.Controls.Add(this.userControlBemVindo1);
            this.Controls.Add(this.userControlFreqProf1);
            this.Controls.Add(this.userControlCadCurso1);
            this.Controls.Add(this.userControlCadFuncionario1);
            this.Controls.Add(this.btnMinimizar);
            this.Controls.Add(this.btnFechar);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmCoordenador";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmCoordenador";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btEmitirRelatorio;
        private System.Windows.Forms.Button btnCadastrarCurso;
        private System.Windows.Forms.Panel pnlIndicador;
        private System.Windows.Forms.Button btnCadFuncionario;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnMinimizar;
        private System.Windows.Forms.Button btnFechar;
        private UserControlCadFuncionario userControlCadFuncionario1;
        private UserControlCadCurso userControlCadCurso1;
        private UserControlFreqProf userControlFreqProf1;
        private UserControlBemVindo userControlBemVindo1;
    }
}