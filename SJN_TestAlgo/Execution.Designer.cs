namespace SJN_TestAlgo
{
    partial class Execution
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.listShow = new System.Windows.Forms.ListView();
            this.btnExecute = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listShow
            // 
            this.listShow.HideSelection = false;
            this.listShow.Location = new System.Drawing.Point(71, 59);
            this.listShow.Name = "listShow";
            this.listShow.Size = new System.Drawing.Size(525, 264);
            this.listShow.TabIndex = 0;
            this.listShow.UseCompatibleStateImageBehavior = false;
            // 
            // btnExecute
            // 
            this.btnExecute.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExecute.Location = new System.Drawing.Point(513, 340);
            this.btnExecute.Name = "btnExecute";
            this.btnExecute.Size = new System.Drawing.Size(83, 23);
            this.btnExecute.TabIndex = 42;
            this.btnExecute.Text = "Execute";
            this.btnExecute.UseVisualStyleBackColor = true;
            // 
            // Execution
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnExecute);
            this.Controls.Add(this.listShow);
            this.Name = "Execution";
            this.Size = new System.Drawing.Size(667, 410);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView listShow;
        private System.Windows.Forms.Button btnExecute;
    }
}
