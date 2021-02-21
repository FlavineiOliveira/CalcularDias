
namespace CalcularDias.Forms
{
    partial class CalcularForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.ckbDiaUtil = new System.Windows.Forms.CheckBox();
            this.mtxtMinutos = new System.Windows.Forms.MaskedTextBox();
            this.mtxtHoraFim = new System.Windows.Forms.MaskedTextBox();
            this.mtxtHoraInicio = new System.Windows.Forms.MaskedTextBox();
            this.mtxtResultado = new System.Windows.Forms.MaskedTextBox();
            this.mtxtData = new System.Windows.Forms.MaskedTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Data";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(236, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(135, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Quantidade Minutos";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 101);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Hora ínicio";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(236, 101);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Hora Fim";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.ckbDiaUtil);
            this.groupBox1.Controls.Add(this.mtxtMinutos);
            this.groupBox1.Controls.Add(this.mtxtHoraFim);
            this.groupBox1.Controls.Add(this.mtxtHoraInicio);
            this.groupBox1.Controls.Add(this.mtxtResultado);
            this.groupBox1.Controls.Add(this.mtxtData);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.btnCalcular);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(591, 271);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Calcular data somando minutos considerando intervalo válido no dia ";
            // 
            // ckbDiaUtil
            // 
            this.ckbDiaUtil.AutoSize = true;
            this.ckbDiaUtil.Location = new System.Drawing.Point(14, 166);
            this.ckbDiaUtil.Name = "ckbDiaUtil";
            this.ckbDiaUtil.Size = new System.Drawing.Size(222, 21);
            this.ckbDiaUtil.TabIndex = 5;
            this.ckbDiaUtil.Text = "Considerar apenas dias úteis?";
            this.ckbDiaUtil.UseVisualStyleBackColor = true;
            // 
            // mtxtMinutos
            // 
            this.mtxtMinutos.Location = new System.Drawing.Point(239, 52);
            this.mtxtMinutos.Mask = "00000";
            this.mtxtMinutos.Name = "mtxtMinutos";
            this.mtxtMinutos.Size = new System.Drawing.Size(166, 22);
            this.mtxtMinutos.TabIndex = 2;
            this.mtxtMinutos.ValidatingType = typeof(int);
            // 
            // mtxtHoraFim
            // 
            this.mtxtHoraFim.Location = new System.Drawing.Point(239, 121);
            this.mtxtHoraFim.Mask = "90:00";
            this.mtxtHoraFim.Name = "mtxtHoraFim";
            this.mtxtHoraFim.Size = new System.Drawing.Size(166, 22);
            this.mtxtHoraFim.TabIndex = 4;
            this.mtxtHoraFim.ValidatingType = typeof(System.DateTime);
            // 
            // mtxtHoraInicio
            // 
            this.mtxtHoraInicio.Location = new System.Drawing.Point(14, 121);
            this.mtxtHoraInicio.Mask = "90:00";
            this.mtxtHoraInicio.Name = "mtxtHoraInicio";
            this.mtxtHoraInicio.Size = new System.Drawing.Size(166, 22);
            this.mtxtHoraInicio.TabIndex = 3;
            this.mtxtHoraInicio.ValidatingType = typeof(System.DateTime);
            // 
            // mtxtResultado
            // 
            this.mtxtResultado.Enabled = false;
            this.mtxtResultado.Location = new System.Drawing.Point(14, 236);
            this.mtxtResultado.Mask = "00/00/0000 90:00";
            this.mtxtResultado.Name = "mtxtResultado";
            this.mtxtResultado.Size = new System.Drawing.Size(560, 22);
            this.mtxtResultado.TabIndex = 7;
            this.mtxtResultado.ValidatingType = typeof(System.DateTime);
            // 
            // mtxtData
            // 
            this.mtxtData.Location = new System.Drawing.Point(14, 52);
            this.mtxtData.Mask = "00/00/0000 90:00";
            this.mtxtData.Name = "mtxtData";
            this.mtxtData.Size = new System.Drawing.Size(166, 22);
            this.mtxtData.TabIndex = 1;
            this.mtxtData.ValidatingType = typeof(System.DateTime);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(11, 216);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(290, 17);
            this.label5.TabIndex = 10;
            this.label5.Text = "Resultado data + minutos dentro do período:";
            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(432, 51);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(142, 92);
            this.btnCalcular.TabIndex = 6;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // CalcularForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(621, 295);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "CalcularForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Calcular data";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.MaskedTextBox mtxtResultado;
        private System.Windows.Forms.MaskedTextBox mtxtData;
        private System.Windows.Forms.MaskedTextBox mtxtHoraFim;
        private System.Windows.Forms.MaskedTextBox mtxtHoraInicio;
        private System.Windows.Forms.MaskedTextBox mtxtMinutos;
        private System.Windows.Forms.CheckBox ckbDiaUtil;
    }
}

