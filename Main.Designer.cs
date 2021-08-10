
namespace Website_Tools
{
    partial class Main
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
            this.websiteTB = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.save = new System.Windows.Forms.Button();
            this.pagelinkbutton = new System.Windows.Forms.Button();
            this.responseTB = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // websiteTB
            // 
            this.websiteTB.Location = new System.Drawing.Point(12, 32);
            this.websiteTB.Name = "websiteTB";
            this.websiteTB.Size = new System.Drawing.Size(251, 20);
            this.websiteTB.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Website:";
            // 
            // save
            // 
            this.save.Location = new System.Drawing.Point(12, 59);
            this.save.Name = "save";
            this.save.Size = new System.Drawing.Size(122, 23);
            this.save.TabIndex = 2;
            this.save.Text = "HTTP Header";
            this.save.UseVisualStyleBackColor = true;
            this.save.Click += new System.EventHandler(this.httpheader_Click);
            // 
            // pagelinkbutton
            // 
            this.pagelinkbutton.Location = new System.Drawing.Point(140, 59);
            this.pagelinkbutton.Name = "pagelinkbutton";
            this.pagelinkbutton.Size = new System.Drawing.Size(123, 23);
            this.pagelinkbutton.TabIndex = 3;
            this.pagelinkbutton.Text = "Page Links";
            this.pagelinkbutton.UseVisualStyleBackColor = true;
            this.pagelinkbutton.Click += new System.EventHandler(this.pagelinkbutton_Click);
            // 
            // responseTB
            // 
            this.responseTB.Location = new System.Drawing.Point(269, 13);
            this.responseTB.Name = "responseTB";
            this.responseTB.Size = new System.Drawing.Size(619, 464);
            this.responseTB.TabIndex = 4;
            this.responseTB.Text = "";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(891, 489);
            this.Controls.Add(this.responseTB);
            this.Controls.Add(this.pagelinkbutton);
            this.Controls.Add(this.save);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.websiteTB);
            this.Name = "Main";
            this.Text = "Cacti\'s Website Tool";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox websiteTB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button save;
        private System.Windows.Forms.Button pagelinkbutton;
        private System.Windows.Forms.RichTextBox responseTB;
    }
}

