namespace Kolmnurk
{
    partial class Kolmnurk_vorm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Kolmnurk_vorm));
            this.start_btn = new System.Windows.Forms.Button();
            this.lv = new System.Windows.Forms.ListView();
            this.Parametr = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Vartus = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.A_lbl = new System.Windows.Forms.Label();
            this.B_lbl = new System.Windows.Forms.Label();
            this.C_lbl = new System.Windows.Forms.Label();
            this.A_txt = new System.Windows.Forms.TextBox();
            this.B_txt = new System.Windows.Forms.TextBox();
            this.C_txt = new System.Windows.Forms.TextBox();
            this.H_txt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // start_btn
            // 
            this.start_btn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.start_btn.Cursor = System.Windows.Forms.Cursors.NoMove2D;
            this.start_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.start_btn.Location = new System.Drawing.Point(623, 277);
            this.start_btn.Name = "start_btn";
            this.start_btn.Size = new System.Drawing.Size(149, 74);
            this.start_btn.TabIndex = 0;
            this.start_btn.Text = "Arvuta";
            this.start_btn.UseVisualStyleBackColor = true;
            this.start_btn.Click += new System.EventHandler(this.start_btn_Click);
            // 
            // lv
            // 
            this.lv.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Parametr,
            this.Vartus});
            this.lv.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.lv.HideSelection = false;
            this.lv.Location = new System.Drawing.Point(317, 13);
            this.lv.Name = "lv";
            this.lv.Size = new System.Drawing.Size(309, 241);
            this.lv.TabIndex = 1;
            this.lv.UseCompatibleStateImageBehavior = false;
            this.lv.View = System.Windows.Forms.View.Details;
            // 
            // Parametr
            // 
            this.Parametr.Text = "Parametr";
            this.Parametr.Width = 150;
            // 
            // Vartus
            // 
            this.Vartus.Text = "Värtus";
            this.Vartus.Width = 150;
            // 
            // A_lbl
            // 
            this.A_lbl.AutoSize = true;
            this.A_lbl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.A_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.A_lbl.Location = new System.Drawing.Point(24, 27);
            this.A_lbl.Name = "A_lbl";
            this.A_lbl.Size = new System.Drawing.Size(103, 33);
            this.A_lbl.TabIndex = 2;
            this.A_lbl.Text = "Külg A:";
            // 
            // B_lbl
            // 
            this.B_lbl.AutoSize = true;
            this.B_lbl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.B_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.B_lbl.Location = new System.Drawing.Point(24, 76);
            this.B_lbl.Name = "B_lbl";
            this.B_lbl.Size = new System.Drawing.Size(103, 33);
            this.B_lbl.TabIndex = 3;
            this.B_lbl.Text = "Külg B:";
            // 
            // C_lbl
            // 
            this.C_lbl.AutoSize = true;
            this.C_lbl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.C_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.C_lbl.Location = new System.Drawing.Point(24, 125);
            this.C_lbl.Name = "C_lbl";
            this.C_lbl.Size = new System.Drawing.Size(105, 33);
            this.C_lbl.TabIndex = 4;
            this.C_lbl.Text = "Külg C:";
            // 
            // A_txt
            // 
            this.A_txt.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.A_txt.Location = new System.Drawing.Point(143, 24);
            this.A_txt.Name = "A_txt";
            this.A_txt.Size = new System.Drawing.Size(92, 38);
            this.A_txt.TabIndex = 5;
            // 
            // B_txt
            // 
            this.B_txt.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.B_txt.Location = new System.Drawing.Point(143, 73);
            this.B_txt.Name = "B_txt";
            this.B_txt.Size = new System.Drawing.Size(92, 38);
            this.B_txt.TabIndex = 6;
            // 
            // C_txt
            // 
            this.C_txt.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.C_txt.Location = new System.Drawing.Point(143, 125);
            this.C_txt.Name = "C_txt";
            this.C_txt.Size = new System.Drawing.Size(92, 38);
            this.C_txt.TabIndex = 7;
            // 
            // H_txt
            // 
            this.H_txt.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.H_txt.Location = new System.Drawing.Point(143, 173);
            this.H_txt.Name = "H_txt";
            this.H_txt.Size = new System.Drawing.Size(92, 38);
            this.H_txt.TabIndex = 9;
            this.H_txt.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.label1.Location = new System.Drawing.Point(24, 173);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 33);
            this.label1.TabIndex = 8;
            this.label1.Text = "Kõrgus:";
            // 
            // Kolmnurk_vorm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(784, 361);
            this.Controls.Add(this.H_txt);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.C_txt);
            this.Controls.Add(this.B_txt);
            this.Controls.Add(this.A_txt);
            this.Controls.Add(this.C_lbl);
            this.Controls.Add(this.B_lbl);
            this.Controls.Add(this.A_lbl);
            this.Controls.Add(this.lv);
            this.Controls.Add(this.start_btn);
            this.Cursor = System.Windows.Forms.Cursors.Cross;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Kolmnurk_vorm";
            this.Padding = new System.Windows.Forms.Padding(10);
            this.Text = "Kolmnurk";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button start_btn;
        private System.Windows.Forms.ListView lv;
        private System.Windows.Forms.ColumnHeader Parametr;
        private System.Windows.Forms.ColumnHeader Vartus;
        private System.Windows.Forms.Label A_lbl;
        private System.Windows.Forms.Label B_lbl;
        private System.Windows.Forms.Label C_lbl;
        private System.Windows.Forms.TextBox A_txt;
        private System.Windows.Forms.TextBox B_txt;
        private System.Windows.Forms.TextBox C_txt;
        private System.Windows.Forms.TextBox H_txt;
        private System.Windows.Forms.Label label1;
    }
}

