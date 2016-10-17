namespace Examen_I_Aplicada_I
{
    partial class Form1
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
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.LimitetextBox = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.FechatextBox = new System.Windows.Forms.TextBox();
            this.NombretextBox = new System.Windows.Forms.TextBox();
            this.IdtextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(43, 293);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 41);
            this.button1.TabIndex = 0;
            this.button1.Text = "Guardar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(91, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "ID cliente";
            // 
            // LimitetextBox
            // 
            this.LimitetextBox.Location = new System.Drawing.Point(94, 236);
            this.LimitetextBox.Name = "LimitetextBox";
            this.LimitetextBox.Size = new System.Drawing.Size(100, 20);
            this.LimitetextBox.TabIndex = 2;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(133, 293);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 41);
            this.button2.TabIndex = 3;
            this.button2.Text = "Modificar";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(248, 293);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 41);
            this.button3.TabIndex = 4;
            this.button3.Text = "Buscar";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(340, 293);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 41);
            this.button4.TabIndex = 5;
            this.button4.Text = "Eliminar";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(91, 129);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Fecha de Nacimiento";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(91, 208);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Limite de Credito";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(91, 61);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Nombre cliente";
            // 
            // FechatextBox
            // 
            this.FechatextBox.Location = new System.Drawing.Point(94, 158);
            this.FechatextBox.Name = "FechatextBox";
            this.FechatextBox.Size = new System.Drawing.Size(100, 20);
            this.FechatextBox.TabIndex = 9;
            // 
            // NombretextBox
            // 
            this.NombretextBox.Location = new System.Drawing.Point(94, 77);
            this.NombretextBox.Name = "NombretextBox";
            this.NombretextBox.Size = new System.Drawing.Size(100, 20);
            this.NombretextBox.TabIndex = 10;
            // 
            // IdtextBox
            // 
            this.IdtextBox.Location = new System.Drawing.Point(94, 25);
            this.IdtextBox.Name = "IdtextBox";
            this.IdtextBox.Size = new System.Drawing.Size(100, 20);
            this.IdtextBox.TabIndex = 11;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Examen_I_Aplicada_I.Properties.Resources.cropped_negocios;
            this.ClientSize = new System.Drawing.Size(533, 360);
            this.Controls.Add(this.IdtextBox);
            this.Controls.Add(this.NombretextBox);
            this.Controls.Add(this.FechatextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.LimitetextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Registro Fondesa";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox LimitetextBox;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox FechatextBox;
        private System.Windows.Forms.TextBox NombretextBox;
        private System.Windows.Forms.TextBox IdtextBox;
    }
}