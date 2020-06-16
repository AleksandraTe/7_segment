namespace _7_SEGtest
{
    partial class Form1
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtBox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this._7segment1 = new Wysw7seg._7segment();
            this.SuspendLayout();
            // 
            // txtBox
            // 
            this.txtBox.Font = new System.Drawing.Font("Bahnschrift", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtBox.Location = new System.Drawing.Point(74, 278);
            this.txtBox.Multiline = true;
            this.txtBox.Name = "txtBox";
            this.txtBox.Size = new System.Drawing.Size(102, 39);
            this.txtBox.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Bahnschrift", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button1.Location = new System.Drawing.Point(193, 278);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(110, 39);
            this.button1.TabIndex = 2;
            this.button1.Text = "Wyświetl";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // _7segment1
            // 
            this._7segment1.BackColor = System.Drawing.Color.LightGray;
            this._7segment1.BgColor = System.Drawing.Color.LightGray;
            this._7segment1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this._7segment1.ColOff = System.Drawing.Color.DarkGray;
            this._7segment1.ColOn = System.Drawing.Color.Red;
            this._7segment1.Location = new System.Drawing.Point(74, 89);
            this._7segment1.Name = "_7segment1";
            this._7segment1.Nr = "0";
            this._7segment1.NumberOfDisplays = 5;
            this._7segment1.Size = new System.Drawing.Size(459, 150);
            this._7segment1.TabIndex = 3;
            this._7segment1.Load += new System.EventHandler(this._7segment1_Load_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGray;
            this.ClientSize = new System.Drawing.Size(775, 356);
            this.Controls.Add(this._7segment1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtBox;
        private System.Windows.Forms.Button button1;
        private Wysw7seg._7segment _7segment1;
    }
}

