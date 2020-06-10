namespace SpeechText
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Voces = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Ratio = new System.Windows.Forms.TrackBar();
            this.Volumen = new System.Windows.Forms.TrackBar();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.Texto = new System.Windows.Forms.RichTextBox();
            this.Reproducir = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Ratio)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Volumen)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.Voces);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.Ratio);
            this.groupBox1.Controls.Add(this.Volumen);
            this.groupBox1.Location = new System.Drawing.Point(15, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(437, 239);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Configuraciones";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(159, 94);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Volumen";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(159, 172);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Ratio";
            // 
            // Voces
            // 
            this.Voces.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Voces.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.Voces.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.Voces.FormattingEnabled = true;
            this.Voces.Location = new System.Drawing.Point(47, 52);
            this.Voces.Name = "Voces";
            this.Voces.Size = new System.Drawing.Size(375, 21);
            this.Voces.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(159, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(25, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Voz";
            // 
            // Ratio
            // 
            this.Ratio.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Ratio.Location = new System.Drawing.Point(39, 188);
            this.Ratio.Name = "Ratio";
            this.Ratio.Size = new System.Drawing.Size(383, 45);
            this.Ratio.TabIndex = 6;
            // 
            // Volumen
            // 
            this.Volumen.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Volumen.Location = new System.Drawing.Point(39, 110);
            this.Volumen.Maximum = 100;
            this.Volumen.Name = "Volumen";
            this.Volumen.Size = new System.Drawing.Size(383, 45);
            this.Volumen.TabIndex = 5;
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.Texto);
            this.groupBox2.Controls.Add(this.Reproducir);
            this.groupBox2.Location = new System.Drawing.Point(15, 258);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(437, 172);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Texto";
            // 
            // Texto
            // 
            this.Texto.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Texto.Location = new System.Drawing.Point(78, 16);
            this.Texto.Name = "Texto";
            this.Texto.Size = new System.Drawing.Size(356, 153);
            this.Texto.TabIndex = 3;
            this.Texto.Text = resources.GetString("Texto.Text");
            // 
            // Reproducir
            // 
            this.Reproducir.Dock = System.Windows.Forms.DockStyle.Left;
            this.Reproducir.Location = new System.Drawing.Point(3, 16);
            this.Reproducir.Name = "Reproducir";
            this.Reproducir.Size = new System.Drawing.Size(75, 153);
            this.Reproducir.TabIndex = 6;
            this.Reproducir.Text = "Reproducir";
            this.Reproducir.UseVisualStyleBackColor = true;
            this.Reproducir.Click += new System.EventHandler(this.Reproducir_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(464, 442);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form1";
            this.Text = "Speech";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Ratio)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Volumen)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox Voces;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TrackBar Ratio;
        private System.Windows.Forms.TrackBar Volumen;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RichTextBox Texto;
        private System.Windows.Forms.Button Reproducir;
    }
}

