namespace TwentyQuestions
{
    partial class Tree
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
            this.LabelTree = new System.Windows.Forms.Label();
            this.TreeListView = new System.Windows.Forms.ListView();
            this.NodeQuestion = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // LabelTree
            // 
            this.LabelTree.AutoSize = true;
            this.LabelTree.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.85714F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelTree.Location = new System.Drawing.Point(379, 34);
            this.LabelTree.Name = "LabelTree";
            this.LabelTree.Size = new System.Drawing.Size(254, 44);
            this.LabelTree.TabIndex = 2;
            this.LabelTree.Text = "Your Pet Tree";
            // 
            // TreeListView
            // 
            this.TreeListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.NodeQuestion});
            this.TreeListView.Location = new System.Drawing.Point(-2, 101);
            this.TreeListView.Name = "TreeListView";
            this.TreeListView.Size = new System.Drawing.Size(1069, 717);
            this.TreeListView.TabIndex = 3;
            this.TreeListView.UseCompatibleStateImageBehavior = false;
            // 
            // NodeQuestion
            // 
            this.NodeQuestion.Width = 200;
            // 
            // Tree
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1065, 822);
            this.Controls.Add(this.TreeListView);
            this.Controls.Add(this.LabelTree);
            this.Name = "Tree";
            this.Text = "Tree";
            this.Load += new System.EventHandler(this.Tree_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label LabelTree;
        private System.Windows.Forms.ListView TreeListView;
        private System.Windows.Forms.ColumnHeader NodeQuestion;
    }
}