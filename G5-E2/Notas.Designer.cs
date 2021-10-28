namespace G5_E2
{
    partial class Notas
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtcarnet = new System.Windows.Forms.TextBox();
            this.txtMat = new System.Windows.Forms.TextBox();
            this.txtp1 = new System.Windows.Forms.TextBox();
            this.txtp2 = new System.Windows.Forms.TextBox();
            this.txtp3 = new System.Windows.Forms.TextBox();
            this.txtnom = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lbNotaProm = new System.Windows.Forms.Label();
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.errorProviderNotas = new System.Windows.Forms.ErrorProvider(this.components);
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderNotas)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(69, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(169, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ingreso de Notas";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(33, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Carnet:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(29, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Materia ";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(29, 64);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Primer Periodo ";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(29, 111);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(89, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Segundo Periodo";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(30, 154);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(77, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "Tercer Periodo";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // txtcarnet
            // 
            this.txtcarnet.Location = new System.Drawing.Point(154, 58);
            this.txtcarnet.Name = "txtcarnet";
            this.txtcarnet.ReadOnly = true;
            this.txtcarnet.Size = new System.Drawing.Size(100, 20);
            this.txtcarnet.TabIndex = 7;
            // 
            // txtMat
            // 
            this.txtMat.Location = new System.Drawing.Point(154, 19);
            this.txtMat.Name = "txtMat";
            this.txtMat.Size = new System.Drawing.Size(100, 20);
            this.txtMat.TabIndex = 8;
            this.txtMat.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            this.txtMat.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMat_KeyPress);
            // 
            // txtp1
            // 
            this.txtp1.Location = new System.Drawing.Point(154, 61);
            this.txtp1.Name = "txtp1";
            this.txtp1.Size = new System.Drawing.Size(100, 20);
            this.txtp1.TabIndex = 9;
            this.txtp1.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            this.txtp1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtp1_KeyPress);
            // 
            // txtp2
            // 
            this.txtp2.Location = new System.Drawing.Point(154, 108);
            this.txtp2.Name = "txtp2";
            this.txtp2.Size = new System.Drawing.Size(100, 20);
            this.txtp2.TabIndex = 10;
            this.txtp2.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            this.txtp2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtp2_KeyPress);
            // 
            // txtp3
            // 
            this.txtp3.Location = new System.Drawing.Point(154, 147);
            this.txtp3.Name = "txtp3";
            this.txtp3.Size = new System.Drawing.Size(100, 20);
            this.txtp3.TabIndex = 12;
            this.txtp3.TextChanged += new System.EventHandler(this.textBox6_TextChanged);
            this.txtp3.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtp3_KeyPress);
            // 
            // txtnom
            // 
            this.txtnom.Location = new System.Drawing.Point(154, 19);
            this.txtnom.Name = "txtnom";
            this.txtnom.ReadOnly = true;
            this.txtnom.Size = new System.Drawing.Size(100, 20);
            this.txtnom.TabIndex = 13;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(33, 22);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(42, 13);
            this.label8.TabIndex = 14;
            this.label8.Text = "Alumno";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.txtnom);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtcarnet);
            this.groupBox1.Location = new System.Drawing.Point(24, 50);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(290, 88);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Infromacion del Alumno ";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lbNotaProm);
            this.groupBox2.Controls.Add(this.txtp3);
            this.groupBox2.Controls.Add(this.txtMat);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.txtp2);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.txtp1);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Location = new System.Drawing.Point(24, 144);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(290, 231);
            this.groupBox2.TabIndex = 16;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Registro de Notas";
            // 
            // lbNotaProm
            // 
            this.lbNotaProm.AutoSize = true;
            this.lbNotaProm.Location = new System.Drawing.Point(134, 191);
            this.lbNotaProm.Name = "lbNotaProm";
            this.lbNotaProm.Size = new System.Drawing.Size(80, 13);
            this.lbNotaProm.TabIndex = 13;
            this.lbNotaProm.Text = "Nota Promerio: ";
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.Location = new System.Drawing.Point(239, 393);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(75, 23);
            this.btnRegistrar.TabIndex = 17;
            this.btnRegistrar.Text = "Registrar";
            this.btnRegistrar.UseVisualStyleBackColor = true;
            this.btnRegistrar.Click += new System.EventHandler(this.btnRegistrar_Click);
            // 
            // errorProviderNotas
            // 
            this.errorProviderNotas.ContainerControl = this;
            // 
            // Notas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(341, 427);
            this.Controls.Add(this.btnRegistrar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Name = "Notas";
            this.Text = "Notas";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderNotas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtcarnet;
        private System.Windows.Forms.TextBox txtMat;
        private System.Windows.Forms.TextBox txtp1;
        private System.Windows.Forms.TextBox txtp2;
        private System.Windows.Forms.TextBox txtp3;
        private System.Windows.Forms.TextBox txtnom;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lbNotaProm;
        private System.Windows.Forms.Button btnRegistrar;
        private System.Windows.Forms.ErrorProvider errorProviderNotas;
    }
}