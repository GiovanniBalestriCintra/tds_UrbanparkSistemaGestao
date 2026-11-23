namespace frmUrbanPark
{
    partial class FrmListVagas
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
            ctrStatusVagas1 = new frmUrbanPark.Parts.ctrStatusVagas();
            SuspendLayout();
            // 
            // ctrStatusVagas1
            // 
            ctrStatusVagas1.BackColor = Color.FromArgb(223, 247, 231);
            ctrStatusVagas1.BorderStyle = BorderStyle.FixedSingle;
            ctrStatusVagas1.Location = new Point(12, 35);
            ctrStatusVagas1.Name = "ctrStatusVagas1";
            ctrStatusVagas1.Size = new Size(188, 184);
            ctrStatusVagas1.TabIndex = 0;
            // 
            // FrmListVagas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(ctrStatusVagas1);
            Name = "FrmListVagas";
            Text = "FrmListVagas";
            Load += FrmListVagas_Load;
            ResumeLayout(false);
        }

        #endregion

        private Parts.ctrStatusVagas ctrStatusVagas1;
    }
}