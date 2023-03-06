namespace renom_mass
{
    partial class frm_main
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
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.btnImporter = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_nombe = new System.Windows.Forms.Label();
            this.btn_rename = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 20;
            this.listBox1.Location = new System.Drawing.Point(12, 12);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(570, 184);
            this.listBox1.TabIndex = 0;
            // 
            // btnImporter
            // 
            this.btnImporter.Location = new System.Drawing.Point(12, 202);
            this.btnImporter.Name = "btnImporter";
            this.btnImporter.Size = new System.Drawing.Size(167, 29);
            this.btnImporter.TabIndex = 1;
            this.btnImporter.Text = "Ajouter des fichiers";
            this.btnImporter.UseVisualStyleBackColor = true;
            this.btnImporter.Click += new System.EventHandler(this.btnImporter_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(588, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Nombre Fichier :";
            // 
            // lbl_nombe
            // 
            this.lbl_nombe.AutoSize = true;
            this.lbl_nombe.Location = new System.Drawing.Point(712, 12);
            this.lbl_nombe.Name = "lbl_nombe";
            this.lbl_nombe.Size = new System.Drawing.Size(50, 20);
            this.lbl_nombe.TabIndex = 3;
            this.lbl_nombe.Text = "label2";
            // 
            // btn_rename
            // 
            this.btn_rename.Location = new System.Drawing.Point(12, 237);
            this.btn_rename.Name = "btn_rename";
            this.btn_rename.Size = new System.Drawing.Size(167, 29);
            this.btn_rename.TabIndex = 4;
            this.btn_rename.Text = "Renomer";
            this.btn_rename.UseVisualStyleBackColor = true;
            this.btn_rename.Click += new System.EventHandler(this.btnRename_Click);
            // 
            // frm_main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 280);
            this.Controls.Add(this.btn_rename);
            this.Controls.Add(this.lbl_nombe);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnImporter);
            this.Controls.Add(this.listBox1);
            this.Name = "frm_main";
            this.Text = "frm_main";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ListBox listBox1;
        private Button btnImporter;
        private Label label1;
        private Label lbl_nombe;
        private Button btn_rename;
    }
}