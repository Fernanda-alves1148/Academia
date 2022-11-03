
namespace Academia
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
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose ();
            }
            base.Dispose (disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent() {
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.cmbAtiv = new System.Windows.Forms.ComboBox();
            this.lblpeso = new System.Windows.Forms.Label();
            this.lblmodalidade = new System.Windows.Forms.Label();
            this.lblhora = new System.Windows.Forms.Label();
            this.txtpeso = new System.Windows.Forms.TextBox();
            this.btncalcular = new System.Windows.Forms.Button();
            this.btnlimpar = new System.Windows.Forms.Button();
            this.btnsair = new System.Windows.Forms.Button();
            this.lblcalorias = new System.Windows.Forms.Label();
            this.txtcalorias = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(316, 139);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            6,
            0,
            0,
            0});
            this.numericUpDown1.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(120, 20);
            this.numericUpDown1.TabIndex = 0;
            this.numericUpDown1.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // cmbAtiv
            // 
            this.cmbAtiv.FormattingEnabled = true;
            this.cmbAtiv.Items.AddRange(new object[] {
            "Alongamento",
            "Boliche",
            "Boxe",
            "Ciclismo",
            "Yoga",
            "Meditação",
            "Natação"});
            this.cmbAtiv.Location = new System.Drawing.Point(400, 40);
            this.cmbAtiv.Name = "cmbAtiv";
            this.cmbAtiv.Size = new System.Drawing.Size(121, 21);
            this.cmbAtiv.TabIndex = 1;
            // 
            // lblpeso
            // 
            this.lblpeso.AutoSize = true;
            this.lblpeso.Font = new System.Drawing.Font("MS Reference Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblpeso.Location = new System.Drawing.Point(37, 79);
            this.lblpeso.Name = "lblpeso";
            this.lblpeso.Size = new System.Drawing.Size(168, 24);
            this.lblpeso.TabIndex = 2;
            this.lblpeso.Text = "Digite seu peso:";
            // 
            // lblmodalidade
            // 
            this.lblmodalidade.AutoSize = true;
            this.lblmodalidade.Font = new System.Drawing.Font("MS Reference Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblmodalidade.Location = new System.Drawing.Point(37, 34);
            this.lblmodalidade.Name = "lblmodalidade";
            this.lblmodalidade.Size = new System.Drawing.Size(357, 24);
            this.lblmodalidade.TabIndex = 3;
            this.lblmodalidade.Text = "Escolha a modalidade para praticar:";
            // 
            // lblhora
            // 
            this.lblhora.AutoSize = true;
            this.lblhora.Font = new System.Drawing.Font("MS Reference Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblhora.Location = new System.Drawing.Point(38, 135);
            this.lblhora.Name = "lblhora";
            this.lblhora.Size = new System.Drawing.Size(272, 24);
            this.lblhora.TabIndex = 4;
            this.lblhora.Text = "Horas praticadas de treino:";
            // 
            // txtpeso
            // 
            this.txtpeso.Location = new System.Drawing.Point(221, 82);
            this.txtpeso.Name = "txtpeso";
            this.txtpeso.Size = new System.Drawing.Size(100, 20);
            this.txtpeso.TabIndex = 5;
            // 
            // btncalcular
            // 
            this.btncalcular.Location = new System.Drawing.Point(42, 206);
            this.btncalcular.Name = "btncalcular";
            this.btncalcular.Size = new System.Drawing.Size(75, 23);
            this.btncalcular.TabIndex = 6;
            this.btncalcular.Text = "Calcular";
            this.btncalcular.UseVisualStyleBackColor = true;
            this.btncalcular.Click += new System.EventHandler(this.btncalcular_Click);
            // 
            // btnlimpar
            // 
            this.btnlimpar.Location = new System.Drawing.Point(246, 206);
            this.btnlimpar.Name = "btnlimpar";
            this.btnlimpar.Size = new System.Drawing.Size(75, 23);
            this.btnlimpar.TabIndex = 7;
            this.btnlimpar.Text = "Limpar";
            this.btnlimpar.UseVisualStyleBackColor = true;
            // 
            // btnsair
            // 
            this.btnsair.Location = new System.Drawing.Point(446, 205);
            this.btnsair.Name = "btnsair";
            this.btnsair.Size = new System.Drawing.Size(75, 23);
            this.btnsair.TabIndex = 8;
            this.btnsair.Text = "Sair";
            this.btnsair.UseVisualStyleBackColor = true;
            // 
            // lblcalorias
            // 
            this.lblcalorias.AutoSize = true;
            this.lblcalorias.Font = new System.Drawing.Font("MS Reference Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcalorias.Location = new System.Drawing.Point(37, 284);
            this.lblcalorias.Name = "lblcalorias";
            this.lblcalorias.Size = new System.Drawing.Size(307, 24);
            this.lblcalorias.TabIndex = 9;
            this.lblcalorias.Text = "Quantidade de calorias gastas:";
            // 
            // txtcalorias
            // 
            this.txtcalorias.Location = new System.Drawing.Point(341, 288);
            this.txtcalorias.Name = "txtcalorias";
            this.txtcalorias.Size = new System.Drawing.Size(100, 20);
            this.txtcalorias.TabIndex = 10;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtcalorias);
            this.Controls.Add(this.lblcalorias);
            this.Controls.Add(this.btnsair);
            this.Controls.Add(this.btnlimpar);
            this.Controls.Add(this.btncalcular);
            this.Controls.Add(this.txtpeso);
            this.Controls.Add(this.lblhora);
            this.Controls.Add(this.lblmodalidade);
            this.Controls.Add(this.lblpeso);
            this.Controls.Add(this.cmbAtiv);
            this.Controls.Add(this.numericUpDown1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.ComboBox cmbAtiv;
        private System.Windows.Forms.Label lblpeso;
        private System.Windows.Forms.Label lblmodalidade;
        private System.Windows.Forms.Label lblhora;
        private System.Windows.Forms.TextBox txtpeso;
        private System.Windows.Forms.Button btncalcular;
        private System.Windows.Forms.Button btnlimpar;
        private System.Windows.Forms.Button btnsair;
        private System.Windows.Forms.Label lblcalorias;
        private System.Windows.Forms.TextBox txtcalorias;
    }
}

