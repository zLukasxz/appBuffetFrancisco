namespace appBuffetFrancisco.View
{
    partial class PDVTela
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PDVTela));
            btn_Coxinha = new Button();
            btn_Kibe = new Button();
            btn_Esfiha = new Button();
            btn_BoloQueijo = new Button();
            btn_Suco = new Button();
            btn_Refrigerante = new Button();
            groupBox1 = new GroupBox();
            groupBox2 = new GroupBox();
            btn_Cafe = new Button();
            btn_Cancelar = new Button();
            btn_Receber = new Button();
            lbl_ValorTotal = new Label();
            lbl_Valor = new Label();
            lbl_Codigo = new Label();
            lbl_Qtde = new Label();
            nud_Qtd = new NumericUpDown();
            txb_Codigo = new TextBox();
            pictureBox1 = new PictureBox();
            dgv_PDV = new DataGridView();
            Produto = new DataGridViewTextBoxColumn();
            Qtde = new DataGridViewTextBoxColumn();
            Unitário = new DataGridViewTextBoxColumn();
            Total = new DataGridViewTextBoxColumn();
            btn_Adicionar = new Button();
            btn_Limpar = new Button();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nud_Qtd).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgv_PDV).BeginInit();
            SuspendLayout();
            // 
            // btn_Coxinha
            // 
            btn_Coxinha.Font = new Font("Louis George Cafe", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btn_Coxinha.ForeColor = Color.Black;
            btn_Coxinha.Location = new Point(6, 22);
            btn_Coxinha.Name = "btn_Coxinha";
            btn_Coxinha.Size = new Size(80, 60);
            btn_Coxinha.TabIndex = 2;
            btn_Coxinha.Text = "Coxinha";
            btn_Coxinha.UseVisualStyleBackColor = true;
            btn_Coxinha.Click += btn_Coxinha_Click;
            // 
            // btn_Kibe
            // 
            btn_Kibe.Font = new Font("Louis George Cafe", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btn_Kibe.ForeColor = Color.Black;
            btn_Kibe.Location = new Point(92, 22);
            btn_Kibe.Name = "btn_Kibe";
            btn_Kibe.Size = new Size(80, 60);
            btn_Kibe.TabIndex = 3;
            btn_Kibe.Text = "Kibe";
            btn_Kibe.UseVisualStyleBackColor = true;
            btn_Kibe.Click += btn_Kibe_Click;
            // 
            // btn_Esfiha
            // 
            btn_Esfiha.Font = new Font("Louis George Cafe", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btn_Esfiha.ForeColor = Color.Black;
            btn_Esfiha.Location = new Point(6, 88);
            btn_Esfiha.Name = "btn_Esfiha";
            btn_Esfiha.Size = new Size(80, 60);
            btn_Esfiha.TabIndex = 4;
            btn_Esfiha.Text = "Esfiha";
            btn_Esfiha.UseVisualStyleBackColor = true;
            btn_Esfiha.Click += btn_Esfiha_Click;
            // 
            // btn_BoloQueijo
            // 
            btn_BoloQueijo.Font = new Font("Louis George Cafe", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btn_BoloQueijo.ForeColor = Color.Black;
            btn_BoloQueijo.Location = new Point(92, 88);
            btn_BoloQueijo.Name = "btn_BoloQueijo";
            btn_BoloQueijo.Size = new Size(80, 60);
            btn_BoloQueijo.TabIndex = 5;
            btn_BoloQueijo.Text = "Bolinho de Queijo";
            btn_BoloQueijo.UseVisualStyleBackColor = true;
            btn_BoloQueijo.Click += btn_BoloQueijo_Click;
            // 
            // btn_Suco
            // 
            btn_Suco.Font = new Font("Louis George Cafe", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btn_Suco.ForeColor = Color.Black;
            btn_Suco.Location = new Point(6, 22);
            btn_Suco.Name = "btn_Suco";
            btn_Suco.Size = new Size(80, 60);
            btn_Suco.TabIndex = 6;
            btn_Suco.Text = "Suco";
            btn_Suco.UseVisualStyleBackColor = true;
            btn_Suco.Click += btn_Suco_Click;
            // 
            // btn_Refrigerante
            // 
            btn_Refrigerante.Font = new Font("Louis George Cafe", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btn_Refrigerante.ForeColor = Color.Black;
            btn_Refrigerante.Location = new Point(92, 22);
            btn_Refrigerante.Name = "btn_Refrigerante";
            btn_Refrigerante.Size = new Size(80, 60);
            btn_Refrigerante.TabIndex = 7;
            btn_Refrigerante.Text = "Refrigerante";
            btn_Refrigerante.UseVisualStyleBackColor = true;
            btn_Refrigerante.Click += btn_Refrigerante_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btn_Coxinha);
            groupBox1.Controls.Add(btn_Kibe);
            groupBox1.Controls.Add(btn_Esfiha);
            groupBox1.Controls.Add(btn_BoloQueijo);
            groupBox1.Font = new Font("Louis George Cafe", 12F, FontStyle.Bold, GraphicsUnit.Point);
            groupBox1.ForeColor = Color.Goldenrod;
            groupBox1.Location = new Point(13, 115);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(182, 157);
            groupBox1.TabIndex = 8;
            groupBox1.TabStop = false;
            groupBox1.Text = "Produtos";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(btn_Cafe);
            groupBox2.Controls.Add(btn_Suco);
            groupBox2.Controls.Add(btn_Refrigerante);
            groupBox2.Font = new Font("Louis George Cafe", 12F, FontStyle.Bold, GraphicsUnit.Point);
            groupBox2.ForeColor = Color.Goldenrod;
            groupBox2.Location = new Point(250, 115);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(178, 157);
            groupBox2.TabIndex = 9;
            groupBox2.TabStop = false;
            groupBox2.Text = "Bebidas";
            // 
            // btn_Cafe
            // 
            btn_Cafe.Font = new Font("Louis George Cafe", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btn_Cafe.ForeColor = Color.Black;
            btn_Cafe.Location = new Point(6, 88);
            btn_Cafe.Name = "btn_Cafe";
            btn_Cafe.Size = new Size(80, 60);
            btn_Cafe.TabIndex = 10;
            btn_Cafe.Text = "Café";
            btn_Cafe.UseVisualStyleBackColor = true;
            btn_Cafe.Click += btn_Cafe_Click;
            // 
            // btn_Cancelar
            // 
            btn_Cancelar.Font = new Font("Louis George Cafe", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btn_Cancelar.Location = new Point(128, 531);
            btn_Cancelar.Name = "btn_Cancelar";
            btn_Cancelar.Size = new Size(103, 49);
            btn_Cancelar.TabIndex = 10;
            btn_Cancelar.Text = "Cancelar";
            btn_Cancelar.UseVisualStyleBackColor = true;
            btn_Cancelar.Click += btn_Cancelar_Click;
            // 
            // btn_Receber
            // 
            btn_Receber.Font = new Font("Louis George Cafe", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btn_Receber.Location = new Point(266, 531);
            btn_Receber.Name = "btn_Receber";
            btn_Receber.Size = new Size(103, 49);
            btn_Receber.TabIndex = 11;
            btn_Receber.Text = "Receber e Finalizar";
            btn_Receber.UseVisualStyleBackColor = true;
            btn_Receber.Click += btn_Receber_Click;
            // 
            // lbl_ValorTotal
            // 
            lbl_ValorTotal.AutoSize = true;
            lbl_ValorTotal.Font = new Font("Louis George Cafe", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_ValorTotal.ForeColor = SystemColors.ControlLight;
            lbl_ValorTotal.Location = new Point(12, 531);
            lbl_ValorTotal.Name = "lbl_ValorTotal";
            lbl_ValorTotal.Size = new Size(88, 17);
            lbl_ValorTotal.TabIndex = 12;
            lbl_ValorTotal.Text = "Valor Total";
            // 
            // lbl_Valor
            // 
            lbl_Valor.AutoSize = true;
            lbl_Valor.Font = new Font("Louis George Cafe", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_Valor.ForeColor = SystemColors.ControlLight;
            lbl_Valor.Location = new Point(12, 557);
            lbl_Valor.Name = "lbl_Valor";
            lbl_Valor.Size = new Size(57, 17);
            lbl_Valor.TabIndex = 13;
            lbl_Valor.Text = "R$ 0,0";
            // 
            // lbl_Codigo
            // 
            lbl_Codigo.AutoSize = true;
            lbl_Codigo.Font = new Font("Louis George Cafe", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_Codigo.ForeColor = SystemColors.ControlLight;
            lbl_Codigo.Location = new Point(39, 286);
            lbl_Codigo.Name = "lbl_Codigo";
            lbl_Codigo.Size = new Size(60, 17);
            lbl_Codigo.TabIndex = 15;
            lbl_Codigo.Text = "Código";
            // 
            // lbl_Qtde
            // 
            lbl_Qtde.AutoSize = true;
            lbl_Qtde.Font = new Font("Louis George Cafe", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_Qtde.ForeColor = SystemColors.ControlLight;
            lbl_Qtde.Location = new Point(221, 286);
            lbl_Qtde.Name = "lbl_Qtde";
            lbl_Qtde.Size = new Size(44, 17);
            lbl_Qtde.TabIndex = 16;
            lbl_Qtde.Text = "Qtde";
            // 
            // nud_Qtd
            // 
            nud_Qtd.Font = new Font("Louis George Cafe", 12F, FontStyle.Regular, GraphicsUnit.Point);
            nud_Qtd.Location = new Point(276, 281);
            nud_Qtd.Name = "nud_Qtd";
            nud_Qtd.Size = new Size(77, 26);
            nud_Qtd.TabIndex = 17;
            // 
            // txb_Codigo
            // 
            txb_Codigo.Font = new Font("Louis George Cafe", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txb_Codigo.Location = new Point(110, 281);
            txb_Codigo.Name = "txb_Codigo";
            txb_Codigo.Size = new Size(100, 26);
            txb_Codigo.TabIndex = 18;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.InitialImage = null;
            pictureBox1.Location = new Point(151, 14);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(138, 96);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 19;
            pictureBox1.TabStop = false;
            // 
            // dgv_PDV
            // 
            dgv_PDV.BackgroundColor = SystemColors.Control;
            dgv_PDV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_PDV.Columns.AddRange(new DataGridViewColumn[] { Produto, Qtde, Unitário, Total });
            dgv_PDV.GridColor = SystemColors.ControlText;
            dgv_PDV.Location = new Point(19, 364);
            dgv_PDV.Name = "dgv_PDV";
            dgv_PDV.RowHeadersVisible = false;
            dgv_PDV.RowTemplate.Height = 25;
            dgv_PDV.Size = new Size(404, 150);
            dgv_PDV.TabIndex = 20;
            // 
            // Produto
            // 
            Produto.HeaderText = "Produto";
            Produto.Name = "Produto";
            // 
            // Qtde
            // 
            Qtde.HeaderText = "Qtde";
            Qtde.Name = "Qtde";
            // 
            // Unitário
            // 
            Unitário.HeaderText = "Unitário";
            Unitário.Name = "Unitário";
            // 
            // Total
            // 
            Total.HeaderText = "Total";
            Total.Name = "Total";
            // 
            // btn_Adicionar
            // 
            btn_Adicionar.Font = new Font("Louis George Cafe", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btn_Adicionar.Location = new Point(65, 323);
            btn_Adicionar.Name = "btn_Adicionar";
            btn_Adicionar.Size = new Size(97, 23);
            btn_Adicionar.TabIndex = 21;
            btn_Adicionar.Text = "Adicionar";
            btn_Adicionar.UseVisualStyleBackColor = true;
            btn_Adicionar.Click += btn_Adicionar_Click;
            // 
            // btn_Limpar
            // 
            btn_Limpar.Font = new Font("Louis George Cafe", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btn_Limpar.Location = new Point(230, 323);
            btn_Limpar.Name = "btn_Limpar";
            btn_Limpar.Size = new Size(97, 23);
            btn_Limpar.TabIndex = 22;
            btn_Limpar.Text = "Limpar";
            btn_Limpar.UseVisualStyleBackColor = true;
            btn_Limpar.Click += btn_Limpar_Click;
            // 
            // PDVTela
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(440, 592);
            Controls.Add(btn_Limpar);
            Controls.Add(btn_Adicionar);
            Controls.Add(dgv_PDV);
            Controls.Add(pictureBox1);
            Controls.Add(txb_Codigo);
            Controls.Add(nud_Qtd);
            Controls.Add(lbl_Qtde);
            Controls.Add(lbl_Codigo);
            Controls.Add(lbl_Valor);
            Controls.Add(lbl_ValorTotal);
            Controls.Add(btn_Receber);
            Controls.Add(btn_Cancelar);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "PDVTela";
            Text = "PDVTela";
            groupBox1.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)nud_Qtd).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgv_PDV).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button btn_Coxinha;
        private Button btn_Kibe;
        private Button btn_Esfiha;
        private Button btn_BoloQueijo;
        private Button btn_Suco;
        private Button btn_Refrigerante;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private Button btn_Cafe;
        private Button btn_Cancelar;
        private Button btn_Receber;
        private Label lbl_ValorTotal;
        private Label lbl_Codigo;
        private Label lbl_Qtde;
        private NumericUpDown nud_Qtd;
        private TextBox txb_Codigo;
        private PictureBox pictureBox1;
        private DataGridView dgv_PDV;
        private DataGridViewTextBoxColumn Produto;
        private DataGridViewTextBoxColumn Qtde;
        private DataGridViewTextBoxColumn Unitário;
        private DataGridViewTextBoxColumn Total;
        private Button btn_Adicionar;
        private Button btn_Limpar;
        public Label lbl_Valor;
    }
}