
namespace ReajusteFolhaPagamento
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.ccccc = new System.Windows.Forms.Label();
            this.cc = new System.Windows.Forms.Label();
            this.TotalSEM = new System.Windows.Forms.TextBox();
            this.totalCOM = new System.Windows.Forms.TextBox();
            this.percentual = new System.Windows.Forms.TextBox();
            this.txtArquivo = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.dgvLeitura = new System.Windows.Forms.DataGridView();
            this.ofdListaFuncionarios = new System.Windows.Forms.OpenFileDialog();
            this.ddd = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLeitura)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.tableLayoutPanel1);
            this.panel1.Location = new System.Drawing.Point(91, 37);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(545, 78);
            this.panel1.TabIndex = 1;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 179F));
            this.tableLayoutPanel1.Controls.Add(this.ddd, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.ccccc, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.cc, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.TotalSEM, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.totalCOM, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.percentual, 2, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(539, 72);
            this.tableLayoutPanel1.TabIndex = 3;
            // 
            // ccccc
            // 
            this.ccccc.BackColor = System.Drawing.Color.Yellow;
            this.ccccc.Location = new System.Drawing.Point(363, 0);
            this.ccccc.Name = "ccccc";
            this.ccccc.Size = new System.Drawing.Size(170, 20);
            this.ccccc.TabIndex = 2;
            this.ccccc.Text = "Percentual reajuste";
            this.ccccc.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cc
            // 
            this.cc.BackColor = System.Drawing.Color.Yellow;
            this.cc.Location = new System.Drawing.Point(183, 0);
            this.cc.Name = "cc";
            this.cc.Size = new System.Drawing.Size(174, 20);
            this.cc.TabIndex = 1;
            this.cc.Text = "Total com Reajuste";
            this.cc.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TotalSEM
            // 
            this.TotalSEM.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.TotalSEM.Enabled = false;
            this.TotalSEM.Location = new System.Drawing.Point(40, 44);
            this.TotalSEM.Name = "TotalSEM";
            this.TotalSEM.Size = new System.Drawing.Size(100, 20);
            this.TotalSEM.TabIndex = 3;
            // 
            // totalCOM
            // 
            this.totalCOM.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.totalCOM.Enabled = false;
            this.totalCOM.Location = new System.Drawing.Point(220, 44);
            this.totalCOM.Name = "totalCOM";
            this.totalCOM.Size = new System.Drawing.Size(100, 20);
            this.totalCOM.TabIndex = 4;
            // 
            // percentual
            // 
            this.percentual.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.percentual.Enabled = false;
            this.percentual.Location = new System.Drawing.Point(399, 44);
            this.percentual.Name = "percentual";
            this.percentual.Size = new System.Drawing.Size(100, 20);
            this.percentual.TabIndex = 5;
            // 
            // txtArquivo
            // 
            this.txtArquivo.Enabled = false;
            this.txtArquivo.Location = new System.Drawing.Point(91, 13);
            this.txtArquivo.Name = "txtArquivo";
            this.txtArquivo.Size = new System.Drawing.Size(498, 20);
            this.txtArquivo.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(595, 13);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(40, 20);
            this.button1.TabIndex = 3;
            this.button1.Text = "...";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.BtnSelecionarArquivo_Click);
            // 
            // dgvLeitura
            // 
            this.dgvLeitura.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLeitura.Location = new System.Drawing.Point(91, 121);
            this.dgvLeitura.Name = "dgvLeitura";
            this.dgvLeitura.Size = new System.Drawing.Size(545, 224);
            this.dgvLeitura.TabIndex = 4;
            // 
            // ofdListaFuncionarios
            // 
            this.ofdListaFuncionarios.DefaultExt = "*.txt";
            this.ofdListaFuncionarios.FileName = "openFileDialog1";
            this.ofdListaFuncionarios.Filter = "Arquivos textos|*.txt";
            this.ofdListaFuncionarios.Title = ": Seleção do arquivo com dados de funcionários";
            // 
            // ddd
            // 
            this.ddd.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.ddd.BackColor = System.Drawing.Color.Yellow;
            this.ddd.Location = new System.Drawing.Point(5, 0);
            this.ddd.Name = "ddd";
            this.ddd.Size = new System.Drawing.Size(170, 20);
            this.ddd.TabIndex = 0;
            this.ddd.Text = "Total sem reajuste";
            this.ddd.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgvLeitura);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtArquivo);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLeitura)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label ccccc;
        private System.Windows.Forms.Label cc;
        private System.Windows.Forms.TextBox txtArquivo;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dgvLeitura;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TextBox TotalSEM;
        private System.Windows.Forms.TextBox totalCOM;
        private System.Windows.Forms.TextBox percentual;
        private System.Windows.Forms.OpenFileDialog ofdListaFuncionarios;
        private System.Windows.Forms.Label ddd;
    }
}

