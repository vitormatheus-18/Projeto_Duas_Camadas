
using System;
using System.Windows.Forms;

namespace GUI
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblNomeDaMoeda = new System.Windows.Forms.Label();
            this.txtNomeDaMoeda = new System.Windows.Forms.TextBox();
            this.txtTerritorio = new System.Windows.Forms.TextBox();
            this.lblTerritorio = new System.Windows.Forms.Label();
            this.txtSimbolo = new System.Windows.Forms.TextBox();
            this.lblSimbolo = new System.Windows.Forms.Label();
            this.btnEnviar = new System.Windows.Forms.Button();
            this.gridMoedas = new System.Windows.Forms.DataGridView();
            this.txtCodigoISO = new System.Windows.Forms.TextBox();
            this.lblCodigoISO = new System.Windows.Forms.Label();
            this.lblValorReais = new System.Windows.Forms.Label();
            this.lblUnidade = new System.Windows.Forms.Label();
            this.txtValorReais = new System.Windows.Forms.TextBox();
            this.txtUnidade = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.gridMoedas)).BeginInit();
            this.SuspendLayout();
            // 
            // lblNomeDaMoeda
            // 
            this.lblNomeDaMoeda.AutoSize = true;
            this.lblNomeDaMoeda.Location = new System.Drawing.Point(12, 9);
            this.lblNomeDaMoeda.Name = "lblNomeDaMoeda";
            this.lblNomeDaMoeda.Size = new System.Drawing.Size(99, 15);
            this.lblNomeDaMoeda.TabIndex = 0;
            this.lblNomeDaMoeda.Text = "Nome da Moeda:";
            this.lblNomeDaMoeda.Click += new System.EventHandler(this.lblNomeDaMoeda_Click);
            // 
            // txtNomeDaMoeda
            // 
            this.txtNomeDaMoeda.Location = new System.Drawing.Point(139, 6);
            this.txtNomeDaMoeda.Name = "txtNomeDaMoeda";
            this.txtNomeDaMoeda.Size = new System.Drawing.Size(342, 23);
            this.txtNomeDaMoeda.TabIndex = 1;
            // 
            // txtTerritorio
            // 
            this.txtTerritorio.Location = new System.Drawing.Point(139, 35);
            this.txtTerritorio.Name = "txtTerritorio";
            this.txtTerritorio.Size = new System.Drawing.Size(342, 23);
            this.txtTerritorio.TabIndex = 3;
            // 
            // lblTerritorio
            // 
            this.lblTerritorio.AutoSize = true;
            this.lblTerritorio.Location = new System.Drawing.Point(12, 38);
            this.lblTerritorio.Name = "lblTerritorio";
            this.lblTerritorio.Size = new System.Drawing.Size(121, 15);
            this.lblTerritorio.TabIndex = 2;
            this.lblTerritorio.Text = "Território/País de uso:\r\n";
            // 
            // txtSimbolo
            // 
            this.txtSimbolo.Location = new System.Drawing.Point(72, 67);
            this.txtSimbolo.Name = "txtSimbolo";
            this.txtSimbolo.Size = new System.Drawing.Size(67, 23);
            this.txtSimbolo.TabIndex = 5;
            // 
            // lblSimbolo
            // 
            this.lblSimbolo.AutoSize = true;
            this.lblSimbolo.Location = new System.Drawing.Point(12, 70);
            this.lblSimbolo.Name = "lblSimbolo";
            this.lblSimbolo.Size = new System.Drawing.Size(54, 15);
            this.lblSimbolo.TabIndex = 4;
            this.lblSimbolo.Text = "Símbolo:";
            // 
            // btnEnviar
            // 
            this.btnEnviar.Location = new System.Drawing.Point(406, 138);
            this.btnEnviar.Name = "btnEnviar";
            this.btnEnviar.Size = new System.Drawing.Size(75, 23);
            this.btnEnviar.TabIndex = 6;
            this.btnEnviar.Text = "Enviar";
            this.btnEnviar.UseVisualStyleBackColor = true;
            this.btnEnviar.Click += new System.EventHandler(this.btnEnviar_Click);
            // 
            // gridMoedas
            // 
            this.gridMoedas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridMoedas.Location = new System.Drawing.Point(12, 167);
            this.gridMoedas.Name = "gridMoedas";
            this.gridMoedas.RowTemplate.Height = 25;
            this.gridMoedas.Size = new System.Drawing.Size(469, 168);
            this.gridMoedas.TabIndex = 7;
            // 
            // txtCodigoISO
            // 
            this.txtCodigoISO.Location = new System.Drawing.Point(221, 67);
            this.txtCodigoISO.Name = "txtCodigoISO";
            this.txtCodigoISO.Size = new System.Drawing.Size(65, 23);
            this.txtCodigoISO.TabIndex = 8;
            // 
            // lblCodigoISO
            // 
            this.lblCodigoISO.AutoSize = true;
            this.lblCodigoISO.Location = new System.Drawing.Point(145, 70);
            this.lblCodigoISO.Name = "lblCodigoISO";
            this.lblCodigoISO.Size = new System.Drawing.Size(70, 15);
            this.lblCodigoISO.TabIndex = 9;
            this.lblCodigoISO.Text = "Codigo ISO:";
            // 
            // lblValorReais
            // 
            this.lblValorReais.AutoSize = true;
            this.lblValorReais.Location = new System.Drawing.Point(12, 109);
            this.lblValorReais.Name = "lblValorReais";
            this.lblValorReais.Size = new System.Drawing.Size(72, 15);
            this.lblValorReais.TabIndex = 10;
            this.lblValorReais.Text = "Valor em R$:";
            // 
            // lblUnidade
            // 
            this.lblUnidade.AutoSize = true;
            this.lblUnidade.Location = new System.Drawing.Point(292, 70);
            this.lblUnidade.Name = "lblUnidade";
            this.lblUnidade.Size = new System.Drawing.Size(115, 15);
            this.lblUnidade.TabIndex = 11;
            this.lblUnidade.Text = "Unidade Fracionária:";
            // 
            // txtValorReais
            // 
            this.txtValorReais.Location = new System.Drawing.Point(90, 106);
            this.txtValorReais.Name = "txtValorReais";
            this.txtValorReais.Size = new System.Drawing.Size(91, 23);
            this.txtValorReais.TabIndex = 12;
            // 
            // txtUnidade
            // 
            this.txtUnidade.Location = new System.Drawing.Point(414, 67);
            this.txtUnidade.Name = "txtUnidade";
            this.txtUnidade.Size = new System.Drawing.Size(67, 23);
            this.txtUnidade.TabIndex = 13;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(495, 347);
            this.Controls.Add(this.txtUnidade);
            this.Controls.Add(this.txtValorReais);
            this.Controls.Add(this.lblUnidade);
            this.Controls.Add(this.lblValorReais);
            this.Controls.Add(this.lblCodigoISO);
            this.Controls.Add(this.txtCodigoISO);
            this.Controls.Add(this.gridMoedas);
            this.Controls.Add(this.btnEnviar);
            this.Controls.Add(this.txtSimbolo);
            this.Controls.Add(this.lblSimbolo);
            this.Controls.Add(this.txtTerritorio);
            this.Controls.Add(this.lblTerritorio);
            this.Controls.Add(this.txtNomeDaMoeda);
            this.Controls.Add(this.lblNomeDaMoeda);
            this.Name = "Form1";
            this.Text = "Câmbio Senac PE";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridMoedas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNomeDaMoeda;
        private System.Windows.Forms.TextBox txtNomeDaMoeda;
        private System.Windows.Forms.TextBox txtTerritorio;
        private System.Windows.Forms.Label lblTerritorio;
        private System.Windows.Forms.TextBox txtSimbolo;
        private System.Windows.Forms.Label lblSimbolo;
        private System.Windows.Forms.Button btnEnviar;
        private System.Windows.Forms.DataGridView gridMoedas;
        private System.Windows.Forms.TextBox txtCodigoISO;
        private System.Windows.Forms.Label lblCodigoISO;
        private System.Windows.Forms.Label lblValorReais;
        private System.Windows.Forms.Label lblUnidade;
        private System.Windows.Forms.TextBox txtValorReais;
        private System.Windows.Forms.TextBox txtUnidade;
        private EventHandler txtSimbolo_TextChanged;
        private EventHandler lblSimbolo_Click;
        private DataGridViewCellEventHandler gridMoedas_CellContentClick;
        private EventHandler txtCodigoISO_TextChanged;
        private EventHandler lblCodigoISO_Click;
        private EventHandler lblValorReais_Click;
        private EventHandler lblUnidade_Click;
        private EventHandler txtValorReais_TextChanged;
        private EventHandler txtUnidade_TextChanged;
    }
}

