namespace ToDoList
{
    partial class ToDo
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.NewTaskBTN = new System.Windows.Forms.Button();
            this.MyTasksDG = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MyTasksDG)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.NewTaskBTN);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(805, 34);
            this.panel1.TabIndex = 0;
            // 
            // NewTaskBTN
            // 
            this.NewTaskBTN.Location = new System.Drawing.Point(12, 8);
            this.NewTaskBTN.Name = "NewTaskBTN";
            this.NewTaskBTN.Size = new System.Drawing.Size(75, 23);
            this.NewTaskBTN.TabIndex = 0;
            this.NewTaskBTN.Text = "button1";
            this.NewTaskBTN.UseVisualStyleBackColor = true;
            this.NewTaskBTN.Click += new System.EventHandler(this.NewTaskBTN_Click);
            // 
            // MyTasksDG
            // 
            this.MyTasksDG.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.MyTasksDG.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MyTasksDG.Location = new System.Drawing.Point(0, 34);
            this.MyTasksDG.Name = "MyTasksDG";
            this.MyTasksDG.Size = new System.Drawing.Size(805, 487);
            this.MyTasksDG.TabIndex = 1;
            // 
            // ToDo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(805, 521);
            this.Controls.Add(this.MyTasksDG);
            this.Controls.Add(this.panel1);
            this.Name = "ToDo";
            this.Text = "ToDo";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ToDo_FormClosed);
            this.Load += new System.EventHandler(this.ToDo_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.MyTasksDG)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button NewTaskBTN;
        private System.Windows.Forms.DataGridView MyTasksDG;
    }
}