namespace BYS.Satori.TA.UIPortal
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnLoad = new System.Windows.Forms.Button();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.treeView2 = new System.Windows.Forms.TreeView();
            this.btnLR = new System.Windows.Forms.Button();
            this.btnRL = new System.Windows.Forms.Button();
            this.btnAssign = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.btnAddUser = new System.Windows.Forms.Button();
            this.btnDel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(24, 25);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(417, 20);
            this.textBox1.TabIndex = 0;
            // 
            // btnLoad
            // 
            this.btnLoad.Location = new System.Drawing.Point(366, 60);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(75, 23);
            this.btnLoad.TabIndex = 1;
            this.btnLoad.Text = "Load";
            this.btnLoad.UseVisualStyleBackColor = true;
            // 
            // treeView1
            // 
            this.treeView1.Location = new System.Drawing.Point(24, 103);
            this.treeView1.Name = "treeView1";
            this.treeView1.Size = new System.Drawing.Size(163, 205);
            this.treeView1.TabIndex = 2;
            // 
            // treeView2
            // 
            this.treeView2.Location = new System.Drawing.Point(294, 103);
            this.treeView2.Name = "treeView2";
            this.treeView2.Size = new System.Drawing.Size(147, 204);
            this.treeView2.TabIndex = 3;
            // 
            // btnLR
            // 
            this.btnLR.Location = new System.Drawing.Point(204, 132);
            this.btnLR.Name = "btnLR";
            this.btnLR.Size = new System.Drawing.Size(75, 23);
            this.btnLR.TabIndex = 4;
            this.btnLR.Text = ">";
            this.btnLR.UseVisualStyleBackColor = true;
            // 
            // btnRL
            // 
            this.btnRL.Location = new System.Drawing.Point(204, 190);
            this.btnRL.Name = "btnRL";
            this.btnRL.Size = new System.Drawing.Size(75, 23);
            this.btnRL.TabIndex = 5;
            this.btnRL.Text = "<";
            this.btnRL.UseVisualStyleBackColor = true;
            // 
            // btnAssign
            // 
            this.btnAssign.Location = new System.Drawing.Point(366, 336);
            this.btnAssign.Name = "btnAssign";
            this.btnAssign.Size = new System.Drawing.Size(75, 23);
            this.btnAssign.TabIndex = 6;
            this.btnAssign.Text = "Assign";
            this.btnAssign.UseVisualStyleBackColor = true;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // btnAddUser
            // 
            this.btnAddUser.Location = new System.Drawing.Point(24, 336);
            this.btnAddUser.Name = "btnAddUser";
            this.btnAddUser.Size = new System.Drawing.Size(75, 23);
            this.btnAddUser.TabIndex = 7;
            this.btnAddUser.Text = "Add user";
            this.btnAddUser.UseVisualStyleBackColor = true;
            // 
            // btnDel
            // 
            this.btnDel.Location = new System.Drawing.Point(132, 336);
            this.btnDel.Name = "btnDel";
            this.btnDel.Size = new System.Drawing.Size(75, 23);
            this.btnDel.TabIndex = 8;
            this.btnDel.Text = "Delete user";
            this.btnDel.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(496, 390);
            this.Controls.Add(this.btnDel);
            this.Controls.Add(this.btnAddUser);
            this.Controls.Add(this.btnAssign);
            this.Controls.Add(this.btnRL);
            this.Controls.Add(this.btnLR);
            this.Controls.Add(this.treeView2);
            this.Controls.Add(this.treeView1);
            this.Controls.Add(this.btnLoad);
            this.Controls.Add(this.textBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.TreeView treeView2;
        private System.Windows.Forms.Button btnLR;
        private System.Windows.Forms.Button btnRL;
        private System.Windows.Forms.Button btnAssign;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Button btnAddUser;
        private System.Windows.Forms.Button btnDel;
    }
}

