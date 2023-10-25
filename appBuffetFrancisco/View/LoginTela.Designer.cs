namespace appBuffetFrancisco.View
{
    partial class LoginTela
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginTela));
            lbl_Usuario = new Label();
            lbl_Senha = new Label();
            btn_Acessar = new Button();
            txb_Usuario = new TextBox();
            txb_Senha = new TextBox();
            pictureBox1 = new PictureBox();
            btn_Sair = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // lbl_Usuario
            // 
            lbl_Usuario.AutoSize = true;
            lbl_Usuario.BackColor = Color.Transparent;
            lbl_Usuario.Font = new Font("Louis George Cafe", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_Usuario.ForeColor = SystemColors.Control;
            lbl_Usuario.Location = new Point(255, 153);
            lbl_Usuario.Name = "lbl_Usuario";
            lbl_Usuario.Size = new Size(84, 21);
            lbl_Usuario.TabIndex = 1;
            lbl_Usuario.Text = "Usuário:";
            // 
            // lbl_Senha
            // 
            lbl_Senha.AutoSize = true;
            lbl_Senha.BackColor = Color.Transparent;
            lbl_Senha.Font = new Font("Louis George Cafe", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_Senha.ForeColor = SystemColors.Control;
            lbl_Senha.Location = new Point(263, 220);
            lbl_Senha.Name = "lbl_Senha";
            lbl_Senha.Size = new Size(68, 21);
            lbl_Senha.TabIndex = 2;
            lbl_Senha.Text = "Senha:";
            // 
            // btn_Acessar
            // 
            btn_Acessar.Font = new Font("Louis George Cafe", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            btn_Acessar.Location = new Point(335, 295);
            btn_Acessar.Name = "btn_Acessar";
            btn_Acessar.Size = new Size(93, 30);
            btn_Acessar.TabIndex = 3;
            btn_Acessar.Text = "Acessar";
            btn_Acessar.UseVisualStyleBackColor = true;
            btn_Acessar.Click += btn_Acessar_Click;
            // 
            // txb_Usuario
            // 
            txb_Usuario.Font = new Font("Louis George Cafe Light", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            txb_Usuario.Location = new Point(167, 177);
            txb_Usuario.Name = "txb_Usuario";
            txb_Usuario.Size = new Size(261, 29);
            txb_Usuario.TabIndex = 4;
            // 
            // txb_Senha
            // 
            txb_Senha.Font = new Font("Louis George Cafe Light", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            txb_Senha.Location = new Point(167, 244);
            txb_Senha.Name = "txb_Senha";
            txb_Senha.PasswordChar = '@';
            txb_Senha.Size = new Size(261, 29);
            txb_Senha.TabIndex = 5;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(207, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(180, 123);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 6;
            pictureBox1.TabStop = false;
            // 
            // btn_Sair
            // 
            btn_Sair.Font = new Font("Louis George Cafe", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            btn_Sair.Location = new Point(167, 295);
            btn_Sair.Name = "btn_Sair";
            btn_Sair.Size = new Size(93, 30);
            btn_Sair.TabIndex = 7;
            btn_Sair.Text = "Sair";
            btn_Sair.UseVisualStyleBackColor = true;
            btn_Sair.Click += btn_Sair_Click;
            // 
            // LoginTela
            // 
            AcceptButton = btn_Acessar;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(14, 14, 14);
            ClientSize = new Size(605, 346);
            Controls.Add(btn_Sair);
            Controls.Add(pictureBox1);
            Controls.Add(txb_Senha);
            Controls.Add(txb_Usuario);
            Controls.Add(btn_Acessar);
            Controls.Add(lbl_Senha);
            Controls.Add(lbl_Usuario);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "LoginTela";
            Text = "Sistema de PDV The Francesco";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label lbl_Usuario;
        private Label lbl_Senha;
        private Button btn_Acessar;
        private TextBox txb_Usuario;
        private TextBox txb_Senha;
        private PictureBox pictureBox1;
        private Button btn_Sair;
    }
}