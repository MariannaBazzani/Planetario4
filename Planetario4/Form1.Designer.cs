namespace Planetario4
{
    partial class Form1
    {
        /// <summary>
        /// Variabile di progettazione necessaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Pulire le risorse in uso.
        /// </summary>
        /// <param name="disposing">ha valore true se le risorse gestite devono essere eliminate, false in caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Codice generato da Progettazione Windows Form

        /// <summary>
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnStop = new System.Windows.Forms.Button();
            this.lstPianeti = new System.Windows.Forms.ListBox();
            this.lblVelocita = new System.Windows.Forms.Label();
            this.lblNome = new System.Windows.Forms.Label();
            this.txtPosizione = new System.Windows.Forms.TextBox();
            this.btnRemove = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnStart = new System.Windows.Forms.Button();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.btnClear = new System.Windows.Forms.Button();
            this.txtVelocita = new System.Windows.Forms.TextBox();
            this.txtMassa = new System.Windows.Forms.TextBox();
            this.lblPosizione = new System.Windows.Forms.Label();
            this.lblMassa = new System.Windows.Forms.Label();
            this.tiktak = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.btnStop);
            this.panel1.Controls.Add(this.lstPianeti);
            this.panel1.Controls.Add(this.lblVelocita);
            this.panel1.Controls.Add(this.lblNome);
            this.panel1.Controls.Add(this.txtPosizione);
            this.panel1.Controls.Add(this.btnRemove);
            this.panel1.Controls.Add(this.btnAdd);
            this.panel1.Controls.Add(this.btnStart);
            this.panel1.Controls.Add(this.txtNome);
            this.panel1.Controls.Add(this.btnClear);
            this.panel1.Controls.Add(this.txtVelocita);
            this.panel1.Controls.Add(this.txtMassa);
            this.panel1.Controls.Add(this.lblPosizione);
            this.panel1.Controls.Add(this.lblMassa);
            this.panel1.Location = new System.Drawing.Point(2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(203, 243);
            this.panel1.TabIndex = 0;
            // 
            // btnStop
            // 
            this.btnStop.Location = new System.Drawing.Point(102, 214);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(97, 23);
            this.btnStop.TabIndex = 14;
            this.btnStop.Text = "Stop";
            this.btnStop.UseVisualStyleBackColor = true;
            // 
            // lstPianeti
            // 
            this.lstPianeti.BackColor = System.Drawing.Color.White;
            this.lstPianeti.FormattingEnabled = true;
            this.lstPianeti.Location = new System.Drawing.Point(4, 139);
            this.lstPianeti.Name = "lstPianeti";
            this.lstPianeti.Size = new System.Drawing.Size(195, 69);
            this.lstPianeti.TabIndex = 12;
            // 
            // lblVelocita
            // 
            this.lblVelocita.AutoSize = true;
            this.lblVelocita.Location = new System.Drawing.Point(4, 9);
            this.lblVelocita.Name = "lblVelocita";
            this.lblVelocita.Size = new System.Drawing.Size(45, 13);
            this.lblVelocita.TabIndex = 1;
            this.lblVelocita.Text = "Velocita";
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(4, 88);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(35, 13);
            this.lblNome.TabIndex = 4;
            this.lblNome.Text = "Nome";
            // 
            // txtPosizione
            // 
            this.txtPosizione.BackColor = System.Drawing.Color.White;
            this.txtPosizione.Location = new System.Drawing.Point(62, 32);
            this.txtPosizione.Name = "txtPosizione";
            this.txtPosizione.Size = new System.Drawing.Size(137, 20);
            this.txtPosizione.TabIndex = 6;
            // 
            // btnRemove
            // 
            this.btnRemove.Location = new System.Drawing.Point(71, 110);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(61, 23);
            this.btnRemove.TabIndex = 10;
            this.btnRemove.Text = "Remove";
            this.btnRemove.UseVisualStyleBackColor = true;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(4, 110);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(61, 23);
            this.btnAdd.TabIndex = 9;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(4, 214);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(97, 23);
            this.btnStart.TabIndex = 13;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            // 
            // txtNome
            // 
            this.txtNome.BackColor = System.Drawing.Color.White;
            this.txtNome.Location = new System.Drawing.Point(61, 84);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(138, 20);
            this.txtNome.TabIndex = 8;
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(138, 110);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(61, 23);
            this.btnClear.TabIndex = 11;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            // 
            // txtVelocita
            // 
            this.txtVelocita.BackColor = System.Drawing.Color.White;
            this.txtVelocita.Location = new System.Drawing.Point(62, 6);
            this.txtVelocita.Name = "txtVelocita";
            this.txtVelocita.Size = new System.Drawing.Size(137, 20);
            this.txtVelocita.TabIndex = 5;
            // 
            // txtMassa
            // 
            this.txtMassa.BackColor = System.Drawing.Color.White;
            this.txtMassa.Location = new System.Drawing.Point(61, 58);
            this.txtMassa.Name = "txtMassa";
            this.txtMassa.Size = new System.Drawing.Size(138, 20);
            this.txtMassa.TabIndex = 7;
            // 
            // lblPosizione
            // 
            this.lblPosizione.AutoSize = true;
            this.lblPosizione.Location = new System.Drawing.Point(4, 35);
            this.lblPosizione.Name = "lblPosizione";
            this.lblPosizione.Size = new System.Drawing.Size(52, 13);
            this.lblPosizione.TabIndex = 2;
            this.lblPosizione.Text = "Posizione";
            // 
            // lblMassa
            // 
            this.lblMassa.AutoSize = true;
            this.lblMassa.Location = new System.Drawing.Point(4, 62);
            this.lblMassa.Name = "lblMassa";
            this.lblMassa.Size = new System.Drawing.Size(38, 13);
            this.lblMassa.TabIndex = 3;
            this.lblMassa.Text = "Massa";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.ListBox lstPianeti;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.TextBox txtMassa;
        private System.Windows.Forms.TextBox txtPosizione;
        private System.Windows.Forms.TextBox txtVelocita;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Label lblMassa;
        private System.Windows.Forms.Label lblPosizione;
        private System.Windows.Forms.Label lblVelocita;
        private System.Windows.Forms.Timer tiktak;
    }
}

